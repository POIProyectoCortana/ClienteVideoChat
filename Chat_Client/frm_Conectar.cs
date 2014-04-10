using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using InternetApplications.ChatApp;

namespace Chat_Client
{
    public partial class frm_Conectar : Form
    {
        public frm_Conectar()
        {
            InitializeComponent();  
        }
        private void frm_Conectar_Load(object sender, EventArgs e)
        {

        }
        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            try
            {                
                if(this.txt_Nickname.Text =="" ||  this.txt_Nickname.Text== null)
                {
                    throw new Exception("El Nickname de identificación no debe estar vacío. No se ha podido iniciar la conexión");
                }
                else
                {                   
                    frm_Principal MainScreen = new frm_Principal(txt_Nickname.Text, txt_IPServidor.Text,txt_Puerto.Text, this);                                      
                    this.Hide();
                    MainScreen.Show(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK);              
            }
            
        }
        private void frm_Conectar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
       
    }
}
