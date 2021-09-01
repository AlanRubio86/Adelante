namespace SLD_v1._0
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtUser = new txtBox.uctxtBox();
            this.txtPass = new txtBox.uctxtBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(76, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(76, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnaceptar.Location = new System.Drawing.Point(41, 308);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(105, 35);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncancelar.Location = new System.Drawing.Point(216, 308);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(110, 35);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtUser
            // 
            this.txtUser.Ancho = 0;
            this.txtUser.AutoComplete = false;
            this.txtUser.AutoCompleteSource = null;
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.Background = System.Drawing.Color.Empty;
            this.txtUser.Cancel = false;
            this.txtUser.DisplayMember = null;
            this.txtUser.Error = false;
            this.txtUser.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(167, 193);
            this.txtUser.Mascara = null;
            this.txtUser.Mascaras_List = null;
            this.txtUser.MaskCustom = false;
            this.txtUser.MaskFecha = false;
            this.txtUser.MaskNumeros = false;
            this.txtUser.mensajeError = "No se permiten campos vacios";
            this.txtUser.mensajeTag = "Introducir el Usuario";
            this.txtUser.Name = "txtUser";
            this.txtUser.OnlyNumbers = false;
            this.txtUser.Password = false;
            this.txtUser.Rango = 0D;
            this.txtUser.Requerido = true;
            this.txtUser.Size = new System.Drawing.Size(100, 24);
            this.txtUser.TabIndex = 0;
            this.txtUser.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtUser.TituloError = null;
            this.txtUser.UpperCase = false;
            this.txtUser.Value = null;
            this.txtUser.ValueMember = null;
            this.txtUser.Zerofill = false;
            // 
            // txtPass
            // 
            this.txtPass.Ancho = 0;
            this.txtPass.AutoComplete = false;
            this.txtPass.AutoCompleteSource = null;
            this.txtPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass.Background = System.Drawing.Color.Empty;
            this.txtPass.Cancel = false;
            this.txtPass.DisplayMember = null;
            this.txtPass.Error = false;
            this.txtPass.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(167, 226);
            this.txtPass.Mascara = null;
            this.txtPass.Mascaras_List = null;
            this.txtPass.MaskCustom = false;
            this.txtPass.MaskFecha = false;
            this.txtPass.MaskNumeros = false;
            this.txtPass.mensajeError = "No se permiten campos vacios";
            this.txtPass.mensajeTag = "Introducir la contraseña";
            this.txtPass.Name = "txtPass";
            this.txtPass.OnlyNumbers = false;
            this.txtPass.Password = true;
            this.txtPass.PasswordChar = '*';
            this.txtPass.Rango = 0D;
            this.txtPass.Requerido = true;
            this.txtPass.Size = new System.Drawing.Size(100, 24);
            this.txtPass.TabIndex = 1;
            this.txtPass.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtPass.TituloError = null;
            this.txtPass.UpperCase = false;
            this.txtPass.Value = null;
            this.txtPass.ValueMember = null;
            this.txtPass.Zerofill = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 368);
            this.ControlBox = false;
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private txtBox.uctxtBox txtUser;
        private txtBox.uctxtBox txtPass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

