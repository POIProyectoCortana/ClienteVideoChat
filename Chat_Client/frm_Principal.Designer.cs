namespace Chat_Client
{
    partial class frm_Principal
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
            this.grb_ChatGeneral = new System.Windows.Forms.GroupBox();
            this.btn_ChatGeneral = new System.Windows.Forms.Button();
            this.txt_ChatGeneral = new System.Windows.Forms.TextBox();
            this.rtb_ChatGeneral = new System.Windows.Forms.RichTextBox();
            this.grb_Conectados = new System.Windows.Forms.GroupBox();
            this.ltb_Conectados = new System.Windows.Forms.ListBox();
            this.tmr_Principal = new System.Windows.Forms.Timer(this.components);
            this.grb_ChatGeneral.SuspendLayout();
            this.grb_Conectados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_ChatGeneral
            // 
            this.grb_ChatGeneral.Controls.Add(this.btn_ChatGeneral);
            this.grb_ChatGeneral.Controls.Add(this.txt_ChatGeneral);
            this.grb_ChatGeneral.Controls.Add(this.rtb_ChatGeneral);
            this.grb_ChatGeneral.Location = new System.Drawing.Point(12, 12);
            this.grb_ChatGeneral.Name = "grb_ChatGeneral";
            this.grb_ChatGeneral.Size = new System.Drawing.Size(345, 375);
            this.grb_ChatGeneral.TabIndex = 0;
            this.grb_ChatGeneral.TabStop = false;
            this.grb_ChatGeneral.Text = "Chat general";
            // 
            // btn_ChatGeneral
            // 
            this.btn_ChatGeneral.Location = new System.Drawing.Point(254, 323);
            this.btn_ChatGeneral.Name = "btn_ChatGeneral";
            this.btn_ChatGeneral.Size = new System.Drawing.Size(75, 23);
            this.btn_ChatGeneral.TabIndex = 2;
            this.btn_ChatGeneral.Text = "Enviar";
            this.btn_ChatGeneral.UseVisualStyleBackColor = true;
            this.btn_ChatGeneral.Click += new System.EventHandler(this.btn_ChatGeneral_Click);
            // 
            // txt_ChatGeneral
            // 
            this.txt_ChatGeneral.Location = new System.Drawing.Point(7, 312);
            this.txt_ChatGeneral.Multiline = true;
            this.txt_ChatGeneral.Name = "txt_ChatGeneral";
            this.txt_ChatGeneral.Size = new System.Drawing.Size(241, 52);
            this.txt_ChatGeneral.TabIndex = 1;
            // 
            // rtb_ChatGeneral
            // 
            this.rtb_ChatGeneral.Location = new System.Drawing.Point(7, 20);
            this.rtb_ChatGeneral.Name = "rtb_ChatGeneral";
            this.rtb_ChatGeneral.Size = new System.Drawing.Size(332, 286);
            this.rtb_ChatGeneral.TabIndex = 0;
            this.rtb_ChatGeneral.Text = "";
            // 
            // grb_Conectados
            // 
            this.grb_Conectados.Controls.Add(this.ltb_Conectados);
            this.grb_Conectados.Location = new System.Drawing.Point(363, 12);
            this.grb_Conectados.Name = "grb_Conectados";
            this.grb_Conectados.Size = new System.Drawing.Size(200, 375);
            this.grb_Conectados.TabIndex = 1;
            this.grb_Conectados.TabStop = false;
            this.grb_Conectados.Text = "Amigos conectados";
            // 
            // ltb_Conectados
            // 
            this.ltb_Conectados.FormattingEnabled = true;
            this.ltb_Conectados.Items.AddRange(new object[] {
            "Contacto1",
            "Contacto2"});
            this.ltb_Conectados.Location = new System.Drawing.Point(17, 20);
            this.ltb_Conectados.Name = "ltb_Conectados";
            this.ltb_Conectados.Size = new System.Drawing.Size(157, 342);
            this.ltb_Conectados.TabIndex = 0;
            this.ltb_Conectados.DoubleClick += new System.EventHandler(this.ltb_Conectados_DoubleClick);
            // 
            // tmr_Principal
            // 
            this.tmr_Principal.Tick += new System.EventHandler(this.tmr_Principal_Tick);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 399);
            this.Controls.Add(this.grb_Conectados);
            this.Controls.Add(this.grb_ChatGeneral);
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Principal_FormClosed);
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.grb_ChatGeneral.ResumeLayout(false);
            this.grb_ChatGeneral.PerformLayout();
            this.grb_Conectados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ChatGeneral;
        private System.Windows.Forms.Button btn_ChatGeneral;
        private System.Windows.Forms.TextBox txt_ChatGeneral;
        private System.Windows.Forms.RichTextBox rtb_ChatGeneral;
        private System.Windows.Forms.GroupBox grb_Conectados;
        private System.Windows.Forms.ListBox ltb_Conectados;
        private System.Windows.Forms.Timer tmr_Principal;
    }
}