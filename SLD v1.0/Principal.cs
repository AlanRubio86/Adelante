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
using Microsoft.ApplicationBlocks.Data;
namespace SLD_v1._0
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        DataSet dts = null;
        public void Permisos(DataSet dts)
        {
            try
            {
                if (dts.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dts.Tables[0].Rows)
                    {


                        //Catalogo-Usuarios
                        usuarioToolStripMenuItem.Enabled = Convert.ToBoolean(row["Acceso_CatUsuarios"].ToString());
                        //catalogo--Clientes
                        clientesToolStripMenuItem1.Enabled = Convert.ToBoolean(row["Acceso_CatClientes"].ToString());

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
                   // Permisos(SLD_v1._0.Properties.Settings.Default.Accesos);
                    //DataTable dtUsuario = SLD_v1._0.Properties.Settings.Default.Accesos.Tables[0];
                    //usuarioToolStripMenuItem1.Text = "Usuario : " + dtUsuario.Rows[0]["Nombre"].ToString();
                    //lblInicioSesion.Text = "Inicio de Sesión : " + DateTime.Now;
                }
                else
                {
                    SLD_v1._0.Properties.Settings.Default.Sesion = false;
                    this.Close();

                }

            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Alerta A = new Alerta();
            DialogResult result = A.MessageAlert("Deseas Salir Del Sistema", "Sistema de Administracion y Gestion De Citas", Alerta.MessageIcon.QuestionVista, Alerta.MessageButton.OkCancel);
            if (result.Equals(DialogResult.Cancel))
            {

                if (SLD_v1._0.Properties.Settings.Default.Sesion == false)
                {
                    // e.Cancel = false;
                    e.Cancel = true;
                    this.Visible = false;
                    frmlogin login = new frmlogin();
                    result = login.ShowDialog();
                    if (result.Equals(DialogResult.OK))
                    {
                        this.Visible = true;
                        Permisos(SLD_v1._0.Properties.Settings.Default.Accesos);
                        DataTable dtUsuario = SLD_v1._0.Properties.Settings.Default.Accesos.Tables[0];
                        usuarioToolStripMenuItem1.Text = "Usuario : " + dtUsuario.Rows[0]["Nombre"].ToString();
                    }
                    else
                    {
                        SLD_v1._0.Properties.Settings.Default.Sesion = false;
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
                Permisos(SLD_v1._0.Properties.Settings.Default.Accesos);
                DataTable dtUsuario = SLD_v1._0.Properties.Settings.Default.Accesos.Tables[0];
                usuarioToolStripMenuItem1.Text = "Usuario : " + dtUsuario.Rows[0]["Nombre"].ToString();
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
