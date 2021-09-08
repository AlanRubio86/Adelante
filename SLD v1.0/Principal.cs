using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using escAlerta;
using System.Data.SqlClient;
using Adelante.Core.Models;
using Microsoft.ApplicationBlocks.Data;
using Newtonsoft.Json;

namespace Adelante
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        DataSet dts = null;

        private void DisableOptions()
        {
            toolStripUsers.Enabled = false;
            toolStripClients.Enabled = false;
            toolStripNeighboors.Enabled = false;
            toolStripAddress.Enabled = false;
            toolStripRegistry.Enabled = false;
            toolStripValidate.Enabled = false;
        }

        public void Permisos(UserRoleModel userRoleModel)
        {
            try
            {
                DisableOptions();

                foreach (var permission in userRoleModel.Role.RolePermissions)
                {

                    switch (permission.Permission.Name)
                    {
                        case "Usuarios":
                            toolStripUsers.Enabled = true;
                            break;
                        case "Clientes":
                            toolStripClients.Enabled = true;
                            break;
                        case "Fraccionamientos":
                            toolStripNeighboors.Enabled = true;
                            break;
                        case "Domicilios":
                            toolStripAddress.Enabled = true;
                            break;
                        case "Registrar Visita":
                            toolStripRegistry.Enabled = true;
                            break;
                        case "Validacion":
                            toolStripValidate.Enabled = true;
                            break;
                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("aqui esta tronando" + e.ToString());
            }

        }
        private void Principal_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLoad load = new frmLoad();
            DialogResult resul = load.ShowDialog();
            if (resul.Equals(DialogResult.OK))
            {
                frmlogin login = new frmlogin();
                DialogResult result = login.ShowDialog();
                if (result.Equals(DialogResult.OK))
                {
                    this.Visible = true;
                    UserModel user = JsonConvert.DeserializeObject<UserModel>(Properties.Settings.Default.Accesos);
                    Permisos(user.UserRoles.First());
                    usuarioToolStripMenuItem1.Text = $"Usuario : {user.Name} {user.LastName}";
                }
                else
                {
                    Properties.Settings.Default.Sesion = false;
                    this.Close();

                }

            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Alerta A = new Alerta();
            DialogResult result = A.MessageAlert("Deseas Salir Del Sistema", "Sistema de Control de Visitantes", Alerta.MessageIcon.QuestionVista, Alerta.MessageButton.OkCancel);
            if (result.Equals(DialogResult.Cancel))
            {

                if (Properties.Settings.Default.Sesion == false)
                {
                    // e.Cancel = false;
                    e.Cancel = true;
                    this.Visible = false;
                    frmlogin login = new frmlogin();
                    result = login.ShowDialog();
                    if (result.Equals(DialogResult.OK))
                    {
                        this.Visible = true;
                        UserModel user = JsonConvert.DeserializeObject<UserModel>(Properties.Settings.Default.Accesos);
                        Permisos(user.UserRoles.First());
                        usuarioToolStripMenuItem1.Text = $"Usuario : {user.Name} {user.LastName}";
                    }
                    else
                    {
                        Properties.Settings.Default.Sesion = false;
                        this.Close();

                    }
                }
                else
                {

                    e.Cancel = true;
                }

            }

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmlogin login = new frmlogin();
            DialogResult result = login.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                this.Visible = true;
                UserModel user = JsonConvert.DeserializeObject<UserModel>(Properties.Settings.Default.Accesos);
                Permisos(JsonConvert.DeserializeObject<UserRoleModel>(Properties.Settings.Default.Accesos));
                usuarioToolStripMenuItem1.Text = $"Usuario : {user.Name} {user.LastName}";
            }
            else
            {
                this.Close();

            }
        }

        private void clientesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmClientes catClients = new frmClientes();
            catClients.MdiParent = this;
            catClients.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmUsuarios catUsuarios = new frmUsuarios();
            catUsuarios.MdiParent = this;
            catUsuarios.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmNeighborhood catNeighborhood = new frmNeighborhood();
            catNeighborhood.MdiParent = this;
            catNeighborhood.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmAdresses catAdresses = new frmAdresses();
            catAdresses.MdiParent = this;
            catAdresses.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmRegistryVisit catRegistryVisit = new frmRegistryVisit();
            catRegistryVisit.MdiParent = this;
            catRegistryVisit.Show();

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmValidAccess catValidAccess = new frmValidAccess();
            catValidAccess.MdiParent = this;
            catValidAccess.Show();
        }
    }
}
