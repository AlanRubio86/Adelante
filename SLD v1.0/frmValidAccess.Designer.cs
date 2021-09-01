using System.Drawing;
namespace SLD_v1._0
{
    partial class frmValidAccess
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
            this.ttEstado = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new txtBox.uctxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbMenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenuContainer
            // 
            this.gbMenuContainer.Location = new System.Drawing.Point(0, 444);
            this.gbMenuContainer.Size = new System.Drawing.Size(693, 87);
            this.gbMenuContainer.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.BackgroundImage = global::SLD_v1._0.Properties.Resources._1904659_arrow_backup_down_download_save_storage_transfer_122509__1_;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(86, 11);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditar.BackgroundImage = global::SLD_v1._0.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(192, 10);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.BackgroundImage = global::SLD_v1._0.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(404, 11);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.BackgroundImage = global::SLD_v1._0.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(510, 11);
            this.btnBuscar.TabIndex = 41;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.BackgroundImage = global::SLD_v1._0.Properties.Resources.exit_icon_icons_com_70975;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(616, 11);
            this.btnSalir.TabIndex = 42;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.BackgroundImage = global::SLD_v1._0.Properties.Resources.reset_undo_arrow_icon_149006;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(298, 10);
            this.btnLimpiar.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(438, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 29);
            this.label4.TabIndex = 122;
            this.label4.Text = "Lunes, 30 Agosto, 15:30";
            // 
            // txtnombre
            // 
            this.txtnombre.Ancho = 0;
            this.txtnombre.AutoComplete = false;
            this.txtnombre.AutoCompleteSource = null;
            this.txtnombre.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtnombre.Background = System.Drawing.Color.Empty;
            this.txtnombre.Cancel = false;
            this.txtnombre.DisplayMember = null;
            this.txtnombre.Error = false;
            this.txtnombre.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(17, 99);
            this.txtnombre.Mascara = null;
            this.txtnombre.Mascaras_List = null;
            this.txtnombre.MaskCustom = false;
            this.txtnombre.MaskFecha = false;
            this.txtnombre.MaskNumeros = false;
            this.txtnombre.mensajeError = "No puede dejar este campo vacio";
            this.txtnombre.mensajeTag = "Escribe el nombre";
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.OnlyNumbers = false;
            this.txtnombre.Password = false;
            this.txtnombre.Rango = 0D;
            this.txtnombre.Requerido = true;
            this.txtnombre.Size = new System.Drawing.Size(664, 53);
            this.txtnombre.TabIndex = 123;
            this.txtnombre.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtnombre.TituloError = null;
            this.txtnombre.UpperCase = false;
            this.txtnombre.Value = null;
            this.txtnombre.ValueMember = null;
            this.txtnombre.Zerofill = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 124;
            this.label2.Text = "Codigo de Acceso";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SLD_v1._0.Properties.Resources.barcode_scanner_4249;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(230, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 194);
            this.button1.TabIndex = 125;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 126;
            this.label1.Text = "Fraccionamiento: Las Sombrillas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SLD_v1._0.Properties.Resources.success_1050751;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::SLD_v1._0.Properties.Resources.success_105075;
            this.pictureBox1.Location = new System.Drawing.Point(562, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 102);
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SLD_v1._0.Properties.Resources.emblemunreadable_93487;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(443, 336);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 102);
            this.pictureBox2.TabIndex = 128;
            this.pictureBox2.TabStop = false;
            // 
            // frmValidAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(693, 531);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "frmValidAccess";
            this.Tag = "Marcar si desea deshabilitar este cliente";
            this.Text = "Registro de Accesos";
            this.Load += new System.EventHandler(this.frmValidAccess_Load);
            this.Controls.SetChildIndex(this.gbMenuContainer, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.gbMenuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion 
        private System.Windows.Forms.ToolTip ttEstado;
        private System.Windows.Forms.Label label4;
        private txtBox.uctxtBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}