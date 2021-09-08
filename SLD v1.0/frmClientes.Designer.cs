using System.Drawing;
namespace Adelante
{
    partial class frmClientes
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
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new txtBox.uctxtBox();
            this.txtCorreo = new txtBox.uctxtBox();
            this.txtDireccion = new txtBox.uctxtBox();
            this.txtNombres = new txtBox.uctxtBox();
            this.txtClave = new txtBox.uctxtBox();
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.ttEstado = new System.Windows.Forms.ToolTip(this.components);
            this.cbxsexo = new escComboBox.escComboBox();
            this.matbTelefono = new escMaskTextBox.escMaskTxtBox();
            this.ala = new escMaskTextBox.escMaskTxtBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgDatos = new escDataGridCustom.escDataGrid(this.components);
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escComboBox1 = new escComboBox.escComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbMenuContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenuContainer
            // 
            this.gbMenuContainer.Location = new System.Drawing.Point(0, 527);
            this.gbMenuContainer.Size = new System.Drawing.Size(702, 67);
            this.gbMenuContainer.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.BackgroundImage = global::Adelante.Properties.Resources._1904659_arrow_backup_down_download_save_storage_transfer_122509__1_;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(86, 11);
            this.btnGuardar.TabIndex = 37;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditar.BackgroundImage = global::Adelante.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(192, 10);
            this.btnEditar.TabIndex = 38;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.BackgroundImage = global::Adelante.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(404, 11);
            this.btnEliminar.TabIndex = 40;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.BackgroundImage = global::Adelante.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(510, 11);
            this.btnBuscar.TabIndex = 41;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.BackgroundImage = global::Adelante.Properties.Resources.exit_icon_icons_com_70975;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(616, 11);
            this.btnSalir.TabIndex = 42;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.BackgroundImage = global::Adelante.Properties.Resources.reset_undo_arrow_icon_149006;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(298, 10);
            this.btnLimpiar.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(34, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 126;
            this.label10.Text = "Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 125;
            this.label7.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 119;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 117;
            this.label5.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 113;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 111;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 109;
            this.label1.Text = "Id Cliente";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Ancho = 0;
            this.txtApellidos.AutoComplete = false;
            this.txtApellidos.AutoCompleteSource = null;
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.Background = System.Drawing.Color.Empty;
            this.txtApellidos.Cancel = false;
            this.txtApellidos.DisplayMember = null;
            this.txtApellidos.Error = false;
            this.txtApellidos.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtApellidos.ForeColor = System.Drawing.Color.Black;
            this.txtApellidos.Location = new System.Drawing.Point(31, 103);
            this.txtApellidos.Mascara = null;
            this.txtApellidos.Mascaras_List = null;
            this.txtApellidos.MaskCustom = false;
            this.txtApellidos.MaskFecha = false;
            this.txtApellidos.MaskNumeros = false;
            this.txtApellidos.mensajeError = "No puede dejar este campo vacio";
            this.txtApellidos.mensajeTag = "Escribe los apellidos del cliente";
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.OnlyNumbers = false;
            this.txtApellidos.Password = false;
            this.txtApellidos.Rango = 0D;
            this.txtApellidos.Requerido = true;
            this.txtApellidos.Size = new System.Drawing.Size(274, 21);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.Tag = "Teclee apellidos del cliente ";
            this.txtApellidos.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtApellidos.TituloError = null;
            this.txtApellidos.UpperCase = false;
            this.txtApellidos.Value = null;
            this.txtApellidos.ValueMember = null;
            this.txtApellidos.Zerofill = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Ancho = 0;
            this.txtCorreo.AutoComplete = false;
            this.txtCorreo.AutoCompleteSource = null;
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.Background = System.Drawing.Color.Empty;
            this.txtCorreo.Cancel = false;
            this.txtCorreo.DisplayMember = null;
            this.txtCorreo.Error = false;
            this.txtCorreo.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(31, 279);
            this.txtCorreo.Mascara = null;
            this.txtCorreo.Mascaras_List = null;
            this.txtCorreo.MaskCustom = false;
            this.txtCorreo.MaskFecha = false;
            this.txtCorreo.MaskNumeros = false;
            this.txtCorreo.mensajeError = null;
            this.txtCorreo.mensajeTag = "Introduce el correo";
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.OnlyNumbers = false;
            this.txtCorreo.Password = false;
            this.txtCorreo.Rango = 0D;
            this.txtCorreo.Requerido = false;
            this.txtCorreo.Size = new System.Drawing.Size(271, 21);
            this.txtCorreo.TabIndex = 11;
            this.txtCorreo.Tag = "Teclee correo del cliente";
            this.txtCorreo.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtCorreo.TituloError = null;
            this.txtCorreo.UpperCase = false;
            this.txtCorreo.Value = null;
            this.txtCorreo.ValueMember = null;
            this.txtCorreo.Zerofill = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Ancho = 0;
            this.txtDireccion.AutoComplete = false;
            this.txtDireccion.AutoCompleteSource = null;
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.Background = System.Drawing.Color.Empty;
            this.txtDireccion.Cancel = false;
            this.txtDireccion.DisplayMember = null;
            this.txtDireccion.Error = false;
            this.txtDireccion.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(31, 321);
            this.txtDireccion.Mascara = null;
            this.txtDireccion.Mascaras_List = null;
            this.txtDireccion.MaskCustom = false;
            this.txtDireccion.MaskFecha = false;
            this.txtDireccion.MaskNumeros = false;
            this.txtDireccion.mensajeError = "No puede dejar este campo vacio";
            this.txtDireccion.mensajeTag = "Introduce la direccion";
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.OnlyNumbers = false;
            this.txtDireccion.Password = false;
            this.txtDireccion.Rango = 0D;
            this.txtDireccion.Requerido = true;
            this.txtDireccion.Size = new System.Drawing.Size(312, 21);
            this.txtDireccion.TabIndex = 14;
            this.txtDireccion.Tag = "Teclee dirección del cliente";
            this.txtDireccion.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtDireccion.TituloError = null;
            this.txtDireccion.UpperCase = false;
            this.txtDireccion.Value = null;
            this.txtDireccion.ValueMember = null;
            this.txtDireccion.Zerofill = false;
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
            this.txtNombres.Location = new System.Drawing.Point(31, 61);
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
            this.txtNombres.Size = new System.Drawing.Size(274, 21);
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
            this.txtClave.Location = new System.Drawing.Point(120, 15);
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
            this.cbxsexo.Location = new System.Drawing.Point(9, 19);
            this.cbxsexo.mensajeError = null;
            this.cbxsexo.mensajeTag = "Selecciona un sexo";
            this.cbxsexo.Name = "cbxsexo";
            this.cbxsexo.OnlyNumbers = false;
            this.cbxsexo.SearchMember = null;
            this.cbxsexo.Size = new System.Drawing.Size(181, 23);
            this.cbxsexo.TabIndex = 4;
            this.cbxsexo.TituloError = null;
            this.cbxsexo.ValorDisplay = null;
            this.cbxsexo.Value = "";
            // 
            // matbTelefono
            // 
            this.matbTelefono.Cancel = false;
            this.matbTelefono.Error = false;
            this.matbTelefono.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matbTelefono.Location = new System.Drawing.Point(31, 189);
            this.matbTelefono.Mask = "(999)000-0000";
            this.matbTelefono.mensajeError = null;
            this.matbTelefono.mensajeTag = "Introduce el telefono";
            this.matbTelefono.Name = "matbTelefono";
            this.matbTelefono.OnlyNumbers = false;
            this.matbTelefono.Size = new System.Drawing.Size(99, 24);
            this.matbTelefono.TabIndex = 6;
            this.matbTelefono.TituloError = null;
            // 
            // ala
            // 
            this.ala.Cancel = false;
            this.ala.Error = false;
            this.ala.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ala.Location = new System.Drawing.Point(31, 234);
            this.ala.Mask = "(999)000-0000";
            this.ala.mensajeError = null;
            this.ala.mensajeTag = "Introduce el celular";
            this.ala.Name = "ala";
            this.ala.OnlyNumbers = false;
            this.ala.Size = new System.Drawing.Size(101, 24);
            this.ala.TabIndex = 8;
            this.ala.TituloError = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgDatos);
            this.groupBox1.Controls.Add(this.cbxsexo);
            this.groupBox1.Location = new System.Drawing.Point(31, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 164);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fraccionamientos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.BackgroundImage = global::Adelante.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(196, 15);
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
            this.colNombre});
            this.dgDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgDatos.Location = new System.Drawing.Point(9, 48);
            this.dgDatos.mensajeError = null;
            this.dgDatos.mensajeTag = null;
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(428, 95);
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
            // escComboBox1
            // 
            this.escComboBox1.Cancel = false;
            this.escComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.escComboBox1.Error = false;
            this.escComboBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escComboBox1.FormattingEnabled = true;
            this.escComboBox1.Location = new System.Drawing.Point(31, 145);
            this.escComboBox1.mensajeError = null;
            this.escComboBox1.mensajeTag = "Selecciona un sexo";
            this.escComboBox1.Name = "escComboBox1";
            this.escComboBox1.OnlyNumbers = false;
            this.escComboBox1.SearchMember = null;
            this.escComboBox1.Size = new System.Drawing.Size(181, 23);
            this.escComboBox1.TabIndex = 128;
            this.escComboBox1.TituloError = null;
            this.escComboBox1.ValorDisplay = null;
            this.escComboBox1.Value = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 129;
            this.label8.Text = "Genero";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(702, 594);
            this.Controls.Add(this.escComboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ala);
            this.Controls.Add(this.matbTelefono);
            this.Controls.Add(this.ckEstado);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClave);
            this.Name = "frmClientes";
            this.Tag = "Marcar si desea deshabilitar este cliente";
            this.Text = "Clientes";
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtNombres, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtCorreo, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.gbMenuContainer, 0);
            this.Controls.SetChildIndex(this.txtApellidos, 0);
            this.Controls.SetChildIndex(this.ckEstado, 0);
            this.Controls.SetChildIndex(this.matbTelefono, 0);
            this.Controls.SetChildIndex(this.ala, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.escComboBox1, 0);
            this.gbMenuContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion 

        private System.Windows.Forms.Label label10;
        private txtBox.uctxtBox txtCorreo;
        private System.Windows.Forms.Label label7;
        private txtBox.uctxtBox txtDireccion;
        private txtBox.uctxtBox txtNombres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private txtBox.uctxtBox txtClave;
        private txtBox.uctxtBox txtApellidos;
        private System.Windows.Forms.CheckBox ckEstado;
        private System.Windows.Forms.ToolTip ttEstado;
        private escComboBox.escComboBox cbxsexo;
        private escMaskTextBox.escMaskTxtBox matbTelefono;
        private escMaskTextBox.escMaskTxtBox ala;
        private System.Windows.Forms.GroupBox groupBox1;
        private escComboBox.escComboBox escComboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private escDataGridCustom.escDataGrid dgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
    }
}