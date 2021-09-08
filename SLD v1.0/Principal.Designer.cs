namespace Adelante
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripClients = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNeighboors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRegistry = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripValidate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem6,
            this.catalogosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.usuarioToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsers,
            this.toolStripClients,
            this.toolStripNeighboors});
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 23);
            this.toolStripMenuItem2.Text = "Catalogos";
            // 
            // toolStripUsers
            // 
            this.toolStripUsers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripUsers.ForeColor = System.Drawing.Color.Black;
            this.toolStripUsers.Name = "toolStripUsers";
            this.toolStripUsers.Size = new System.Drawing.Size(185, 22);
            this.toolStripUsers.Text = "Usuario";
            this.toolStripUsers.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripClients
            // 
            this.toolStripClients.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripClients.ForeColor = System.Drawing.Color.Black;
            this.toolStripClients.Name = "toolStripClients";
            this.toolStripClients.Size = new System.Drawing.Size(185, 22);
            this.toolStripClients.Text = "Clientes";
            this.toolStripClients.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click_1);
            // 
            // toolStripNeighboors
            // 
            this.toolStripNeighboors.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripNeighboors.ForeColor = System.Drawing.Color.Black;
            this.toolStripNeighboors.Name = "toolStripNeighboors";
            this.toolStripNeighboors.Size = new System.Drawing.Size(185, 22);
            this.toolStripNeighboors.Text = "Fraccionamientos";
            this.toolStripNeighboors.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddress,
            this.toolStripRegistry});
            this.toolStripMenuItem6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(85, 23);
            this.toolStripMenuItem6.Text = "Mi Control";
            // 
            // toolStripAddress
            // 
            this.toolStripAddress.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripAddress.ForeColor = System.Drawing.Color.Black;
            this.toolStripAddress.Name = "toolStripAddress";
            this.toolStripAddress.Size = new System.Drawing.Size(180, 22);
            this.toolStripAddress.Text = "Domicilios";
            this.toolStripAddress.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripRegistry
            // 
            this.toolStripRegistry.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripRegistry.ForeColor = System.Drawing.Color.Black;
            this.toolStripRegistry.Name = "toolStripRegistry";
            this.toolStripRegistry.Size = new System.Drawing.Size(180, 22);
            this.toolStripRegistry.Text = "Registrar visita";
            this.toolStripRegistry.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripValidate});
            this.catalogosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.catalogosToolStripMenuItem.Text = "Accesos";
            // 
            // toolStripValidate
            // 
            this.toolStripValidate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripValidate.ForeColor = System.Drawing.Color.Black;
            this.toolStripValidate.Name = "toolStripValidate";
            this.toolStripValidate.Size = new System.Drawing.Size(180, 22);
            this.toolStripValidate.Text = "Validacion";
            this.toolStripValidate.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(73, 23);
            this.usuarioToolStripMenuItem1.Text = "Usuario";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1268, 720);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripValidate;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripUsers;
        private System.Windows.Forms.ToolStripMenuItem toolStripClients;
        private System.Windows.Forms.ToolStripMenuItem toolStripNeighboors;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddress;
        private System.Windows.Forms.ToolStripMenuItem toolStripRegistry;
    }
}