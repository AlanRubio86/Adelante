namespace Adelante
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxValidate = new System.Windows.Forms.CheckBox();
            this.checkBoxRegistry = new System.Windows.Forms.CheckBox();
            this.checkBoxAddress = new System.Windows.Forms.CheckBox();
            this.checkBoxNeighboors = new System.Windows.Forms.CheckBox();
            this.checkBoxUsers = new System.Windows.Forms.CheckBox();
            this.checkBoxClients = new System.Windows.Forms.CheckBox();
            this.lblconfir = new System.Windows.Forms.Label();
            this.txtpassconfirm = new txtBox.uctxtBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpass = new txtBox.uctxtBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnick = new txtBox.uctxtBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtusername = new txtBox.uctxtBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtapellido = new txtBox.uctxtBox();
            this.txtnombre = new txtBox.uctxtBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new txtBox.uctxtBox();
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.ttEstado = new System.Windows.Forms.ToolTip(this.components);
            this.combopuesto = new escComboBox.escComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbAdelanteDataSet = new Adelante.dbAdelanteDataSet();
            this.txtcel = new escMaskTextBox.escMaskTxtBox();
            this.roleTableAdapter = new Adelante.dbAdelanteDataSetTableAdapters.RoleTableAdapter();
            this.gbMenuContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAdelanteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenuContainer
            // 
            this.gbMenuContainer.Location = new System.Drawing.Point(0, 466);
            this.gbMenuContainer.Size = new System.Drawing.Size(748, 67);
            this.gbMenuContainer.TabIndex = 36;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(86, 11);
            this.btnGuardar.TabIndex = 37;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(192, 10);
            this.btnEditar.TabIndex = 38;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(404, 11);
            this.btnEliminar.TabIndex = 40;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(510, 11);
            this.btnBuscar.TabIndex = 41;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(616, 11);
            this.btnSalir.TabIndex = 42;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(298, 10);
            this.btnLimpiar.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBoxValidate);
            this.groupBox1.Controls.Add(this.checkBoxRegistry);
            this.groupBox1.Controls.Add(this.checkBoxAddress);
            this.groupBox1.Controls.Add(this.checkBoxNeighboors);
            this.groupBox1.Controls.Add(this.checkBoxUsers);
            this.groupBox1.Controls.Add(this.checkBoxClients);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(495, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 458);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // checkBoxValidate
            // 
            this.checkBoxValidate.AutoSize = true;
            this.checkBoxValidate.Enabled = false;
            this.checkBoxValidate.Location = new System.Drawing.Point(21, 131);
            this.checkBoxValidate.Name = "checkBoxValidate";
            this.checkBoxValidate.Size = new System.Drawing.Size(145, 22);
            this.checkBoxValidate.TabIndex = 28;
            this.checkBoxValidate.Text = "Acceso - Validacion";
            this.checkBoxValidate.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegistry
            // 
            this.checkBoxRegistry.AutoSize = true;
            this.checkBoxRegistry.Enabled = false;
            this.checkBoxRegistry.Location = new System.Drawing.Point(21, 113);
            this.checkBoxRegistry.Name = "checkBoxRegistry";
            this.checkBoxRegistry.Size = new System.Drawing.Size(192, 22);
            this.checkBoxRegistry.TabIndex = 27;
            this.checkBoxRegistry.Text = "Mi control - Registrar visita";
            this.checkBoxRegistry.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddress
            // 
            this.checkBoxAddress.AutoSize = true;
            this.checkBoxAddress.Enabled = false;
            this.checkBoxAddress.Location = new System.Drawing.Point(21, 93);
            this.checkBoxAddress.Name = "checkBoxAddress";
            this.checkBoxAddress.Size = new System.Drawing.Size(166, 22);
            this.checkBoxAddress.TabIndex = 26;
            this.checkBoxAddress.Text = "Mi control - Domicilios";
            this.checkBoxAddress.UseVisualStyleBackColor = true;
            // 
            // checkBoxNeighboors
            // 
            this.checkBoxNeighboors.AutoSize = true;
            this.checkBoxNeighboors.Enabled = false;
            this.checkBoxNeighboors.Location = new System.Drawing.Point(21, 71);
            this.checkBoxNeighboors.Name = "checkBoxNeighboors";
            this.checkBoxNeighboors.Size = new System.Drawing.Size(201, 22);
            this.checkBoxNeighboors.TabIndex = 23;
            this.checkBoxNeighboors.Text = "Catalogo - Fraccionamientos";
            this.checkBoxNeighboors.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsers
            // 
            this.checkBoxUsers.AutoSize = true;
            this.checkBoxUsers.Enabled = false;
            this.checkBoxUsers.Location = new System.Drawing.Point(21, 27);
            this.checkBoxUsers.Name = "checkBoxUsers";
            this.checkBoxUsers.Size = new System.Drawing.Size(145, 22);
            this.checkBoxUsers.TabIndex = 21;
            this.checkBoxUsers.Text = "Catalogo - Usuarios";
            this.checkBoxUsers.UseVisualStyleBackColor = true;
            // 
            // checkBoxClients
            // 
            this.checkBoxClients.AutoSize = true;
            this.checkBoxClients.Enabled = false;
            this.checkBoxClients.Location = new System.Drawing.Point(21, 49);
            this.checkBoxClients.Name = "checkBoxClients";
            this.checkBoxClients.Size = new System.Drawing.Size(143, 22);
            this.checkBoxClients.TabIndex = 22;
            this.checkBoxClients.Text = "Catalogo - Clientes";
            this.checkBoxClients.UseVisualStyleBackColor = true;
            // 
            // lblconfir
            // 
            this.lblconfir.AutoSize = true;
            this.lblconfir.BackColor = System.Drawing.Color.Transparent;
            this.lblconfir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfir.ForeColor = System.Drawing.Color.Black;
            this.lblconfir.Location = new System.Drawing.Point(25, 395);
            this.lblconfir.Name = "lblconfir";
            this.lblconfir.Size = new System.Drawing.Size(119, 15);
            this.lblconfir.TabIndex = 109;
            this.lblconfir.Text = "Confirmar Password";
            // 
            // txtpassconfirm
            // 
            this.txtpassconfirm.Ancho = 0;
            this.txtpassconfirm.AutoComplete = false;
            this.txtpassconfirm.AutoCompleteSource = null;
            this.txtpassconfirm.BackColor = System.Drawing.SystemColors.Window;
            this.txtpassconfirm.Background = System.Drawing.Color.Empty;
            this.txtpassconfirm.Cancel = false;
            this.txtpassconfirm.DisplayMember = null;
            this.txtpassconfirm.Error = false;
            this.txtpassconfirm.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtpassconfirm.ForeColor = System.Drawing.Color.Black;
            this.txtpassconfirm.Location = new System.Drawing.Point(28, 413);
            this.txtpassconfirm.Mascara = "*";
            this.txtpassconfirm.Mascaras_List = null;
            this.txtpassconfirm.MaskCustom = false;
            this.txtpassconfirm.MaskFecha = false;
            this.txtpassconfirm.MaskNumeros = false;
            this.txtpassconfirm.mensajeError = "No puede dejar este campo vacio";
            this.txtpassconfirm.mensajeTag = "Confirma tu contraseña";
            this.txtpassconfirm.Name = "txtpassconfirm";
            this.txtpassconfirm.OnlyNumbers = false;
            this.txtpassconfirm.Password = true;
            this.txtpassconfirm.PasswordChar = '*';
            this.txtpassconfirm.Rango = 0D;
            this.txtpassconfirm.Requerido = false;
            this.txtpassconfirm.Size = new System.Drawing.Size(160, 21);
            this.txtpassconfirm.TabIndex = 13;
            this.txtpassconfirm.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtpassconfirm.TituloError = null;
            this.txtpassconfirm.UpperCase = false;
            this.txtpassconfirm.Value = null;
            this.txtpassconfirm.ValueMember = null;
            this.txtpassconfirm.Zerofill = false;
            this.txtpassconfirm.Leave += new System.EventHandler(this.txtpassconfirm_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(25, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 108;
            this.label12.Text = "Password";
            // 
            // txtpass
            // 
            this.txtpass.Ancho = 0;
            this.txtpass.AutoComplete = false;
            this.txtpass.AutoCompleteSource = null;
            this.txtpass.BackColor = System.Drawing.SystemColors.Window;
            this.txtpass.Background = System.Drawing.Color.Empty;
            this.txtpass.Cancel = false;
            this.txtpass.DisplayMember = null;
            this.txtpass.Error = false;
            this.txtpass.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.Location = new System.Drawing.Point(28, 371);
            this.txtpass.Mascara = "*";
            this.txtpass.Mascaras_List = null;
            this.txtpass.MaskCustom = false;
            this.txtpass.MaskFecha = false;
            this.txtpass.MaskNumeros = false;
            this.txtpass.mensajeError = "No puede dejar este campo vacio";
            this.txtpass.mensajeTag = "Introduce contraseña menor de 10 digitos";
            this.txtpass.Name = "txtpass";
            this.txtpass.OnlyNumbers = false;
            this.txtpass.Password = true;
            this.txtpass.PasswordChar = '*';
            this.txtpass.Rango = 0D;
            this.txtpass.Requerido = false;
            this.txtpass.Size = new System.Drawing.Size(160, 21);
            this.txtpass.TabIndex = 12;
            this.txtpass.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtpass.TituloError = null;
            this.txtpass.UpperCase = false;
            this.txtpass.Value = null;
            this.txtpass.ValueMember = null;
            this.txtpass.Zerofill = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(25, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 107;
            this.label11.Text = "Nickname";
            // 
            // txtnick
            // 
            this.txtnick.Ancho = 0;
            this.txtnick.AutoComplete = false;
            this.txtnick.AutoCompleteSource = null;
            this.txtnick.BackColor = System.Drawing.SystemColors.Window;
            this.txtnick.Background = System.Drawing.Color.Empty;
            this.txtnick.Cancel = false;
            this.txtnick.DisplayMember = null;
            this.txtnick.Error = false;
            this.txtnick.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtnick.ForeColor = System.Drawing.Color.Black;
            this.txtnick.Location = new System.Drawing.Point(28, 327);
            this.txtnick.Mascara = null;
            this.txtnick.Mascaras_List = null;
            this.txtnick.MaskCustom = false;
            this.txtnick.MaskFecha = false;
            this.txtnick.MaskNumeros = false;
            this.txtnick.mensajeError = "No puede dejar este campo vacio";
            this.txtnick.mensajeTag = "Introduce  el nickname";
            this.txtnick.Name = "txtnick";
            this.txtnick.OnlyNumbers = false;
            this.txtnick.Password = false;
            this.txtnick.Rango = 0D;
            this.txtnick.Requerido = false;
            this.txtnick.Size = new System.Drawing.Size(289, 21);
            this.txtnick.TabIndex = 11;
            this.txtnick.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtnick.TituloError = null;
            this.txtnick.UpperCase = false;
            this.txtnick.Value = null;
            this.txtnick.ValueMember = null;
            this.txtnick.Zerofill = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(25, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 106;
            this.label10.Text = "Celular";
            // 
            // txtusername
            // 
            this.txtusername.Ancho = 0;
            this.txtusername.AutoComplete = false;
            this.txtusername.AutoCompleteSource = null;
            this.txtusername.BackColor = System.Drawing.SystemColors.Window;
            this.txtusername.Background = System.Drawing.Color.Empty;
            this.txtusername.Cancel = false;
            this.txtusername.DisplayMember = null;
            this.txtusername.Error = false;
            this.txtusername.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(28, 283);
            this.txtusername.Mascara = null;
            this.txtusername.Mascaras_List = null;
            this.txtusername.MaskCustom = false;
            this.txtusername.MaskFecha = false;
            this.txtusername.MaskNumeros = false;
            this.txtusername.mensajeError = null;
            this.txtusername.mensajeTag = "Introduce el correo";
            this.txtusername.Name = "txtusername";
            this.txtusername.OnlyNumbers = false;
            this.txtusername.Password = false;
            this.txtusername.Rango = 0D;
            this.txtusername.Requerido = false;
            this.txtusername.Size = new System.Drawing.Size(289, 21);
            this.txtusername.TabIndex = 8;
            this.txtusername.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtusername.TituloError = null;
            this.txtusername.UpperCase = false;
            this.txtusername.Value = null;
            this.txtusername.ValueMember = null;
            this.txtusername.Zerofill = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 105;
            this.label7.Text = "Nombre de Usuario";
            // 
            // txtapellido
            // 
            this.txtapellido.Ancho = 0;
            this.txtapellido.AutoComplete = false;
            this.txtapellido.AutoCompleteSource = null;
            this.txtapellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtapellido.Background = System.Drawing.Color.Empty;
            this.txtapellido.Cancel = false;
            this.txtapellido.DisplayMember = null;
            this.txtapellido.Error = false;
            this.txtapellido.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtapellido.ForeColor = System.Drawing.Color.Black;
            this.txtapellido.Location = new System.Drawing.Point(28, 131);
            this.txtapellido.Mascara = null;
            this.txtapellido.Mascaras_List = null;
            this.txtapellido.MaskCustom = false;
            this.txtapellido.MaskFecha = false;
            this.txtapellido.MaskNumeros = false;
            this.txtapellido.mensajeError = "No puede dejar este campo vacio";
            this.txtapellido.mensajeTag = "Escribe los apellidos";
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.OnlyNumbers = false;
            this.txtapellido.Password = false;
            this.txtapellido.Rango = 0D;
            this.txtapellido.Requerido = true;
            this.txtapellido.Size = new System.Drawing.Size(289, 21);
            this.txtapellido.TabIndex = 3;
            this.txtapellido.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtapellido.TituloError = null;
            this.txtapellido.UpperCase = false;
            this.txtapellido.Value = null;
            this.txtapellido.ValueMember = null;
            this.txtapellido.Zerofill = false;
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
            this.txtnombre.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(28, 82);
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
            this.txtnombre.Size = new System.Drawing.Size(289, 21);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.TipoNumero = txtBox.uctxtBox.typeNum.Ninguno;
            this.txtnombre.TituloError = null;
            this.txtnombre.UpperCase = false;
            this.txtnombre.Value = null;
            this.txtnombre.ValueMember = null;
            this.txtnombre.Zerofill = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 93;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 90;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 88;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 86;
            this.label1.Text = "Id Usuario";
            // 
            // txtid
            // 
            this.txtid.Ancho = 0;
            this.txtid.AutoComplete = false;
            this.txtid.AutoCompleteSource = null;
            this.txtid.BackColor = System.Drawing.SystemColors.Window;
            this.txtid.Background = System.Drawing.Color.Empty;
            this.txtid.Cancel = false;
            this.txtid.DisplayMember = null;
            this.txtid.Enabled = false;
            this.txtid.Error = false;
            this.txtid.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(101, 21);
            this.txtid.Mascara = null;
            this.txtid.Mascaras_List = null;
            this.txtid.MaskCustom = false;
            this.txtid.MaskFecha = false;
            this.txtid.MaskNumeros = false;
            this.txtid.MaxLength = 11;
            this.txtid.mensajeError = null;
            this.txtid.mensajeTag = null;
            this.txtid.Name = "txtid";
            this.txtid.OnlyNumbers = true;
            this.txtid.Password = false;
            this.txtid.Rango = 2147483647D;
            this.txtid.Requerido = false;
            this.txtid.Size = new System.Drawing.Size(100, 21);
            this.txtid.TabIndex = 1;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtid.TipoNumero = txtBox.uctxtBox.typeNum.Int;
            this.txtid.TituloError = null;
            this.txtid.UpperCase = false;
            this.txtid.Value = null;
            this.txtid.ValueMember = null;
            this.txtid.Zerofill = false;
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.BackColor = System.Drawing.Color.Transparent;
            this.ckEstado.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.ckEstado.ForeColor = System.Drawing.Color.Black;
            this.ckEstado.Location = new System.Drawing.Point(254, 23);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(59, 19);
            this.ckEstado.TabIndex = 14;
            this.ckEstado.Text = "Activo";
            this.ttEstado.SetToolTip(this.ckEstado, "Testear casilla si desea inhabilitar a este usuario");
            this.ckEstado.UseVisualStyleBackColor = false;
            // 
            // combopuesto
            // 
            this.combopuesto.BackColor = System.Drawing.Color.White;
            this.combopuesto.Cancel = false;
            this.combopuesto.DataSource = this.roleBindingSource;
            this.combopuesto.DisplayMember = "Name";
            this.combopuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combopuesto.Error = false;
            this.combopuesto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combopuesto.FormattingEnabled = true;
            this.combopuesto.Location = new System.Drawing.Point(28, 177);
            this.combopuesto.mensajeError = null;
            this.combopuesto.mensajeTag = null;
            this.combopuesto.Name = "combopuesto";
            this.combopuesto.OnlyNumbers = false;
            this.combopuesto.SearchMember = null;
            this.combopuesto.Size = new System.Drawing.Size(289, 23);
            this.combopuesto.TabIndex = 4;
            this.combopuesto.TituloError = null;
            this.combopuesto.ValorDisplay = null;
            this.combopuesto.Value = "";
            this.combopuesto.ValueMember = "Id";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.dbAdelanteDataSet;
            // 
            // dbAdelanteDataSet
            // 
            this.dbAdelanteDataSet.DataSetName = "dbAdelanteDataSet";
            this.dbAdelanteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtcel
            // 
            this.txtcel.Cancel = false;
            this.txtcel.Error = false;
            this.txtcel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcel.Location = new System.Drawing.Point(28, 232);
            this.txtcel.Mask = "(999)000-0000";
            this.txtcel.mensajeError = null;
            this.txtcel.mensajeTag = "Captura el numero de celular";
            this.txtcel.Name = "txtcel";
            this.txtcel.OnlyNumbers = false;
            this.txtcel.Size = new System.Drawing.Size(130, 24);
            this.txtcel.TabIndex = 7;
            this.txtcel.TituloError = null;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(748, 533);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.combopuesto);
            this.Controls.Add(this.ckEstado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblconfir);
            this.Controls.Add(this.txtpassconfirm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtnick);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.Controls.SetChildIndex(this.txtid, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.txtapellido, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtusername, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtnick, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtpass, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtpassconfirm, 0);
            this.Controls.SetChildIndex(this.lblconfir, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.ckEstado, 0);
            this.Controls.SetChildIndex(this.combopuesto, 0);
            this.Controls.SetChildIndex(this.txtcel, 0);
            this.Controls.SetChildIndex(this.gbMenuContainer, 0);
            this.gbMenuContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAdelanteDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxNeighboors;
        private System.Windows.Forms.CheckBox checkBoxUsers;
        private System.Windows.Forms.CheckBox checkBoxClients;
        private System.Windows.Forms.Label lblconfir;
        private txtBox.uctxtBox txtpassconfirm;
        private System.Windows.Forms.Label label12;
        private txtBox.uctxtBox txtpass;
        private System.Windows.Forms.Label label11;
        private txtBox.uctxtBox txtnick;
        private System.Windows.Forms.Label label10;
        private txtBox.uctxtBox txtusername;
        private System.Windows.Forms.Label label7;
        private txtBox.uctxtBox txtapellido;
        private txtBox.uctxtBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private txtBox.uctxtBox txtid;
        private System.Windows.Forms.CheckBox ckEstado;
        private System.Windows.Forms.ToolTip ttEstado;
        private escComboBox.escComboBox combopuesto;
        private escMaskTextBox.escMaskTxtBox txtcel;
        private System.Windows.Forms.CheckBox checkBoxRegistry;
        private System.Windows.Forms.CheckBox checkBoxAddress;
        private System.Windows.Forms.CheckBox checkBoxValidate;
        private Adelante.dbAdelanteDataSet dbAdelanteDataSet;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private Adelante.dbAdelanteDataSetTableAdapters.RoleTableAdapter roleTableAdapter;
    }
}