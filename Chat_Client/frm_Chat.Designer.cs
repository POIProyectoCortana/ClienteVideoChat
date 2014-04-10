namespace Chat_Client
{
    partial class frm_Chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtb_Contenido = new System.Windows.Forms.RichTextBox();
            this.btn_Adjuntar = new System.Windows.Forms.Button();
            this.txt_Contenido = new System.Windows.Forms.TextBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.tmr_Conversacion = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtb_Contenido
            // 
            this.rtb_Contenido.Location = new System.Drawing.Point(13, 13);
            this.rtb_Contenido.Name = "rtb_Contenido";
            this.rtb_Contenido.Size = new System.Drawing.Size(401, 247);
            this.rtb_Contenido.TabIndex = 0;
            this.rtb_Contenido.Text = "";
            // 
            // btn_Adjuntar
            // 
            this.btn_Adjuntar.Location = new System.Drawing.Point(326, 267);
            this.btn_Adjuntar.Name = "btn_Adjuntar";
            this.btn_Adjuntar.Size = new System.Drawing.Size(88, 23);
            this.btn_Adjuntar.TabIndex = 1;
            this.btn_Adjuntar.Text = "Adjuntar";
            this.btn_Adjuntar.UseVisualStyleBackColor = true;
            // 
            // txt_Contenido
            // 
            this.txt_Contenido.Location = new System.Drawing.Point(13, 267);
            this.txt_Contenido.Multiline = true;
            this.txt_Contenido.Name = "txt_Contenido";
            this.txt_Contenido.Size = new System.Drawing.Size(307, 52);
            this.txt_Contenido.TabIndex = 2;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(326, 296);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(88, 23);
            this.btn_Enviar.TabIndex = 3;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // tmr_Conversacion
            // 
            this.tmr_Conversacion.Tick += new System.EventHandler(this.tmr_Conversacion_Tick);
            // 
            // frm_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 328);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.txt_Contenido);
            this.Controls.Add(this.btn_Adjuntar);
            this.Controls.Add(this.rtb_Contenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Chat_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Contenido;
        private System.Windows.Forms.Button btn_Adjuntar;
        private System.Windows.Forms.TextBox txt_Contenido;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Timer tmr_Conversacion;
    }
}