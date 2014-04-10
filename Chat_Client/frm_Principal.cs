using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InternetApplications.ChatApp;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Chat_Client
{
    public partial class frm_Principal : Form
    {
        frm_Conectar Padre;
        public static List<frm_Chat> LConversaciones = new List<frm_Chat>();
        public static Queue<Mensaje> QMensajesRecibidos= new Queue<Mensaje>();
        public static Queue<Mensaje> QMensajesAEnviar= new Queue<Mensaje>();
        public string Nickname { get; set; }
        public int IdServer { get; set; }
        public TcpClient ServerSocket;
        public NetworkStream ServerStream;
        public byte[] DatosFromServer;
        public byte[] DatosToServer;
        public static int Buffer=1024;
        public frm_Principal(string U, string IP,string Port ,frm_Conectar P)        
        {            
            Padre = P;
            InitializeComponent();
            this.Nickname=U;
            DatosFromServer = new byte[Buffer];
            try
            {
                ServerSocket = new TcpClient();
                ServerSocket.Connect(IPAddress.Parse(IP), Convert.ToInt32(Port));
                ServerStream = ServerSocket.GetStream();
                Mensaje M = RecibirDatos();
                this.Text = "Bienvenido " + U + " // ServerId: "+M.Contenido;
                Mensaje Logged = new Mensaje(Mensaje.TipoDeMensaje.ClientLoggedIn, this.Nickname, "ALL", this.Nickname, DateTime.Now);
                EnviarDatos(Logged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK);
                Padre.Show();
                this.Close();
            }            
        }
        private void btn_ChatGeneral_Click(object sender, EventArgs e)
        {  
            Mensaje Msj = new Mensaje(Mensaje.TipoDeMensaje.Message, Nickname, "ALL", txt_ChatGeneral.Text, DateTime.Now);
            EnviarDatos(Msj);
            txt_ChatGeneral.Text = "";
            Msj.Clear();
        }
        private void frm_Principal_Load(object sender, EventArgs e)
        {
            rtb_ChatGeneral.Enabled = false;
            tmr_Principal.Enabled = true;
        }
        private void ltb_Conectados_DoubleClick(object sender, EventArgs e)
        {
            frm_Chat NuevaVentana = new frm_Chat(this.ltb_Conectados.SelectedItem.ToString(),this);
            NuevaVentana.Show();
            LConversaciones.Add(NuevaVentana);            
        }
        private void frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {            
            //Mensaje Logged = new Mensaje(Mensaje.TipoDeMensaje.ClientLoggedOut, this.Nickname, "ALL", this.Nickname, DateTime.Now);
            //Padre.EnviarDatos(Logged);
            //tmr_Principal.Enabled = false;
            //this.Padre.ClientSocket.Close();
            //this.Padre.Show();
        }        
        void EntregarMensajesConversaciones()
        {
            while (QMensajesRecibidos.Count > 0)
            {
                Mensaje Msj = QMensajesRecibidos.Dequeue();
                rtb_ChatGeneral.AppendText(Msj.Remitente+": "+Msj.Contenido + Environment.NewLine);
                //switch (Msj.Tipo)
                //{
                //    case Mensaje.TipoDeMensaje.ClientLoggedIn:
                //        ltb_Conectados.Items.Add(Msj.Contenido);
                //        break;
                //    case Mensaje.TipoDeMensaje.ClientLoggedOut:
                //        ltb_Conectados.Items.Remove(Msj.Contenido);
                //        break;
                //    case Mensaje.TipoDeMensaje.Message:
                //        if (Msj.Destinatario == "ALL")
                //        {
                //            rtb_ChatGeneral.Enabled = true;
                //            rtb_ChatGeneral.AppendText(Msj.Remitente+" : "+Msj.Contenido + Environment.NewLine);
                //            rtb_ChatGeneral.Enabled = false;
                //        }
                //        else
                //        {
                //            bool Found=false;
                //            if (Msj.Destinatario == this.Nickname)
                //            {
                //                foreach (frm_Chat Chat in LConversaciones)
                //                {
                //                    if (Chat.Contacto == Msj.Remitente)
                //                    {
                //                        Chat.QRecibidos.Enqueue(Msj);
                //                        Msj.Clear();
                //                        Found = true;                                       
                //                    }
                //                }
                //                if (Found == false)
                //                {
                //                    frm_Chat Nw = new frm_Chat(Msj.Remitente, this);
                //                    LConversaciones.Add(Nw);
                //                    Nw.Show();
                //                    Nw.QRecibidos.Enqueue(Msj);
                //                }
                //            }
                //        }
                //        break;
                //    case Mensaje.TipoDeMensaje.Disconnect_Request:
                //        this.Close();
                //        break;
                //}
            }
        }
        void RecibirMensajes()
        {           
            if (ServerStream.DataAvailable)
            {      
                Mensaje M = RecibirDatos();
                QMensajesRecibidos.Enqueue(M);
            }            
        }
        void EnviarMensajes()
        {           
            while(QMensajesAEnviar.Count>0)
            {
                Mensaje M=QMensajesAEnviar.Dequeue();
                EnviarDatos(M);
            }            
        }
        private void tmr_Principal_Tick(object sender, EventArgs e)
        {
            RecibirMensajes();
            EnviarMensajes();
            EntregarMensajesConversaciones();
        }
        public void EnviarDatos(Mensaje M)
        {
            DatosToServer = M.ParseMessageToBinary();
            ServerStream.Write(DatosToServer, 0, DatosToServer.Length);
            ServerStream.Flush();
            Array.Clear(DatosToServer, 0, DatosToServer.Length);
        }
        public Mensaje RecibirDatos()
        {            
            this.ServerStream.Read(DatosFromServer, 0, DatosFromServer.Length);
            Mensaje M = new Mensaje();
            M.ParseBinaryToMessage(DatosFromServer);
            this.ServerStream.Flush();
            Array.Clear(DatosFromServer, 0, DatosFromServer.Length);
            return M;
        }
    }
}
