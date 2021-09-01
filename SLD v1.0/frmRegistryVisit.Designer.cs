using System.Drawing;
namespace SLD_v1._0
{
    partial class frmRegistryVisit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new txtBox.uctxtBox();
            this.txtClave = new txtBox.uctxtBox();
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.ttEstado = new System.Windows.Forms.ToolTip(this.components);
            this.cbxsexo = new escComboBox.escComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgDatos = new escDataGridCustom.escDataGrid(this.components);
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escComboBox1 = new escComboBox.escComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbMenuContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenuContainer
            // 
            this.gbMenuContainer.Location = new System.Drawing.Point(0, 439);
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
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditar.BackgroundImage = global::SLD_v1._0.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(192, 10);
            this.btnEditar.TabIndex = 38;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.BackgroundImage = global::SLD_v1._0.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(404, 11);
            this.btnEliminar.TabIndex = 40;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 111;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 109;
            this.label1.Text = "Id Visita";
            // 
            // txtNombres
            // 
            this.txtNombres.Ancho = 0;
            this.txtNombres.AutoComplete = false;
            this.txtNombres.AutoCompleteSource = null;
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.Background = System.Drawing.Color.Empty;
            this.txtNombres.Cancel = false;
            this.txtNombres.DisplayMember = null;
            this.txtNombres.Error = false;
            this.txtNombres.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtNombres.ForeColor = System.Drawing.Color.Black;
            this.txtNombres.Location = new System.Drawing.Point(6, 39);
            this.txtNombres.Mascara = null;
            this.txtNombres.Mascaras_List = null;
            this.txtNombres.MaskCustom = false;
            this.txtNombres.MaskFecha = false;
            this.txtNombres.MaskNumeros = false;
            this.txtNombres.mensajeError = "No puede dejar este campo vacio";
            this.txtNombres.mensajeTag = "Escribe el nombre";
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.OnlyNumbers = false;
            this.txtNombres.Password = false;
            this.txtNombres.Rango = 0D;
            this.txtNombres.Requerido = true;
            this.txtNombres.Size = new System.Drawing.Size(326, 21);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.Tag = "Teclee nombre de cliente ";
            this.txtNombres.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtNombres.TituloError = null;
            this.txtNombres.UpperCase = false;
            this.txtNombres.Value = null;
            this.txtNombres.ValueMember = null;
            this.txtNombres.Zerofill = false;
            // 
            // txtClave
            // 
            this.txtClave.Ancho = 0;
            this.txtClave.AutoComplete = false;
            this.txtClave.AutoCompleteSource = null;
            this.txtClave.BackColor = System.Drawing.SystemColors.Window;
            this.txtClave.Background = System.Drawing.Color.Empty;
            this.txtClave.Cancel = false;
            this.txtClave.DisplayMember = null;
            this.txtClave.Enabled = false;
            this.txtClave.Error = false;
            this.txtClave.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(148, 10);
            this.txtClave.Mascara = null;
            this.txtClave.Mascaras_List = null;
            this.txtClave.MaskCustom = false;
            this.txtClave.MaskFecha = false;
            this.txtClave.MaskNumeros = false;
            this.txtClave.MaxLength = 11;
            this.txtClave.mensajeError = "No puede dejar este campo vacio";
            this.txtClave.mensajeTag = null;
            this.txtClave.Name = "txtClave";
            this.txtClave.OnlyNumbers = true;
            this.txtClave.Password = false;
            this.txtClave.Rango = 2147483647D;
            this.txtClave.Requerido = false;
            this.txtClave.Size = new System.Drawing.Size(100, 21);
            this.txtClave.TabIndex = 1;
            this.txtClave.Tag = "introdusca un numero 1,2,3 ... etc";
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClave.TipoNumero = txtBox.uctxtBox.typeNum.Int;
            this.txtClave.TituloError = null;
            this.txtClave.UpperCase = false;
            this.txtClave.Value = null;
            this.txtClave.ValueMember = null;
            this.txtClave.Zerofill = false;
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.BackColor = System.Drawing.Color.Transparent;
            this.ckEstado.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.ckEstado.ForeColor = System.Drawing.Color.Black;
            this.ckEstado.Location = new System.Drawing.Point(304, 12);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(59, 19);
            this.ckEstado.TabIndex = 18;
            this.ckEstado.Text = "Activo";
            this.ttEstado.SetToolTip(this.ckEstado, "Testear casilla si desea inhabilitar a este cliente");
            this.ckEstado.UseVisualStyleBackColor = false;
            // 
            // cbxsexo
            // 
            this.cbxsexo.Cancel = false;
            this.cbxsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsexo.Error = false;
            this.cbxsexo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsexo.FormattingEnabled = true;
            this.cbxsexo.Location = new System.Drawing.Point(31, 66);
            this.cbxsexo.mensajeError = null;
            this.cbxsexo.mensajeTag = "Selecciona un sexo";
            this.cbxsexo.Name = "cbxsexo";
            this.cbxsexo.OnlyNumbers = false;
            this.cbxsexo.SearchMember = null;
            this.cbxsexo.Size = new System.Drawing.Size(274, 23);
            this.cbxsexo.TabIndex = 121;
            this.cbxsexo.TituloError = null;
            this.cbxsexo.ValorDisplay = null;
            this.cbxsexo.Value = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 122;
            this.label4.Text = "Fraccionamiento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dgDatos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Location = new System.Drawing.Point(31, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 225);
            this.groupBox2.TabIndex = 128;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.BackgroundImage = global::SLD_v1._0.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(349, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 118;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AllowUserToResizeColumns = false;
            this.dgDatos.AllowUserToResizeRows = false;
            this.dgDatos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDatos.Cancel = false;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.Codigo});
            this.dgDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgDatos.Location = new System.Drawing.Point(6, 66);
            this.dgDatos.mensajeError = null;
            this.dgDatos.mensajeTag = null;
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(570, 142);
            this.dgDatos.TabIndex = 117;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNombre.DataPropertyName = "Productos_Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // escComboBox1
            // 
            this.escComboBox1.Cancel = false;
            this.escComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.escComboBox1.Error = false;
            this.escComboBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escComboBox1.FormattingEnabled = true;
            this.escComboBox1.Location = new System.Drawing.Point(31, 119);
            this.escComboBox1.mensajeError = null;
            this.escComboBox1.mensajeTag = "Selecciona un sexo";
            this.escComboBox1.Name = "escComboBox1";
            this.escComboBox1.OnlyNumbers = false;
            this.escComboBox1.SearchMember = null;
            this.escComboBox1.Size = new System.Drawing.Size(274, 23);
            this.escComboBox1.TabIndex = 129;
            this.escComboBox1.TituloError = null;
            this.escComboBox1.ValorDisplay = null;
            this.escComboBox1.Value = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 130;
            this.label3.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(29, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 132;
            this.label5.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 20);
            this.dateTimePicker1.TabIndex = 133;
            // 
            // frmRegistryVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(693, 526);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.escComboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbxsexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClave);
            this.Name = "frmRegistryVisit";
            this.Tag = "Marcar si desea deshabilitar este cliente";
            this.Text = "Registro de Accesos";
            this.Load += new System.EventHandler(this.frmRegistryVisit_Load);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.gbMenuContainer, 0);
            this.Controls.SetChildIndex(this.ckEstado, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbxsexo, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.escComboBox1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.gbMenuContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion 
        private txtBox.uctxtBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private txtBox.uctxtBox txtClave;
        private System.Windows.Forms.CheckBox ckEstado;
        private System.Windows.Forms.ToolTip ttEstado;
        private escComboBox.escComboBox cbxsexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private escDataGridCustom.escDataGrid dgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private escComboBox.escComboBox escComboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}