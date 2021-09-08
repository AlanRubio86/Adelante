using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using escBaseForm;
using escAlerta;
using System.Data.SqlClient;
using Adelante.Core.Models;
using Adelante.Core.Services;
using Microsoft.ApplicationBlocks.Data;

namespace Adelante
{
    public partial class frmUsuarios : BaseForm
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAdelanteDataSet.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.dbAdelanteDataSet.Role);
            txtid.Focus();
            MaxId();

        }
        public void Limpiar()
        {
            MaxId();
            txtnombre.ResetText();
            txtapellido.ResetText();
            txtcel.ResetText();
            txtusername.ResetText();
            txtnick.ResetText();
            txtpass.ResetText();
            txtpassconfirm.ResetText();
            combopuesto.ResetText();

            ckEstado.Checked = false;
            txtnombre.Focus();
        }
        public void MaxId()
        {
            try
            {
                UserService userService = new UserService();
                txtid.Text = userService.MaxId().ToString();
            }
            catch (Exception exc)
            {
                Alerta A = new Alerta();
                A.MessageAlert(exc.Message, "Catalogo de usuarios", Alerta.MessageIcon.ErrorVista, Alerta.MessageButton.Ok);
            }

        }
        public override void Guardar()
        {
            if (validaCampos())
            {
                EditAndInsert("Actualizado con éxito", "Actualizar", ckEstado.Checked);
                Limpiar();
            }

        }

        public override void Editar()
        {
            Habilitar(true);
            txtnombre.Focus();
        }

        public void EditAndInsert(string psMensage, string psTitulo, bool piEstado)
        {
            Alerta A = new Alerta();
            chekarPermisos();
            try
            {
                UserService userService = new UserService();
                UserModel user = new UserModel
                {
                    Id = Convert.ToInt32(txtid.Text),
                    Name = txtnombre.Text,
                    LastName = txtapellido.Text,
                    CellPhone = txtcel.Text,
                    UserName = txtusername.Text,
                    Nickname = txtnick.Text,
                    Password = txtpass.Text,
                    Active = piEstado,
                    RoleId = (int)combopuesto.SelectedValue
                };
                var result = userService.Add(user);
                Limpiar();

            }
            catch (Exception ex)
            {
                A.MessageAlert("Error al tratar de insertar en la base de datos " + ex.Message, "Error  al insertar", Alerta.MessageIcon.ErrorVista, Alerta.MessageButton.Ok);
            }
            finally
            {
                A.MessageAlert(psMensage, psTitulo, Alerta.MessageIcon.Good, Alerta.MessageButton.Ok);
                GC.Collect();
            }

        }

        public bool validaCampos()
        {
            BaseClase bas = new BaseClase();
            object[] loControles = new object[]
                                                {
                                                  txtid,
                                                  txtnombre,
                                                  txtapellido,
                                                  txtnick,
                                                  txtpass,
                                                  txtpassconfirm
                                                };
            return bas.checarControles(loControles);
        }

        public void llenaRenglon(DataGridViewRow drDatos)
        {

            txtid.Text = drDatos.Cells["colId"].Value.ToString();
            txtnombre.Text = drDatos.Cells["colNombre"].Value.ToString();
            txtapellido.Text = drDatos.Cells["colApellidos"].Value.ToString();
            txtcel.Text = drDatos.Cells["colCelular"].Value.ToString();

            combopuesto.Text = drDatos.Cells["colPuesto"].Value.ToString();
            txtusername.Text = drDatos.Cells["colCorreo"].Value.ToString();
            txtnick.Text = drDatos.Cells["colNickname"].Value.ToString();
            txtpass.Text = drDatos.Cells["colPassword"].Value.ToString();
            txtpassconfirm.Text = drDatos.Cells["colPassword"].Value.ToString();

            ckEstado.Checked = Convert.ToBoolean(drDatos.Cells["colStatus"].Value);
            checkBoxUsers.Checked = Convert.ToBoolean(drDatos.Cells["colCatUsuarios"].Value);
            checkBoxClients.Checked = Convert.ToBoolean(drDatos.Cells["colCatClientes"].Value);
            checkBoxNeighboors.Checked = Convert.ToBoolean(drDatos.Cells["colCatAreas"].Value);


            Habilitar(false);
        }


        public override void Restablecer()
        {
            Limpiar();
            ClearError();
            Habilitar(true);
        }

        public void ClearError()
        {
            txtid.clearError();
            txtnombre.clearError();
            txtapellido.clearError();
            txtnick.clearError();
            txtpass.clearError();
            txtpassconfirm.clearError();
        }

        public void chekarPermisos()
        {

        }

        private void txtpassconfirm_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text.Equals(txtpassconfirm.Text) == false)
            {
                Alerta A = new Alerta();
                A.MessageAlert("Favor de introducir correctamente la contraseña", "Catalogo de Usuarios", Alerta.MessageIcon.Good, Alerta.MessageButton.Ok);
                txtpass.Focus();
            }
        }

        public void Habilitar(bool pbHabilita)
        {
            txtnombre.Enabled = pbHabilita;
            txtapellido.Enabled = pbHabilita;
            txtcel.Enabled = pbHabilita;
            txtusername.Enabled = pbHabilita;
            txtnick.Enabled = pbHabilita;
            txtpass.Enabled = pbHabilita;
            txtpassconfirm.Enabled = pbHabilita;
            combopuesto.Enabled = pbHabilita;

            ckEstado.Enabled = pbHabilita;

            checkBoxUsers.Enabled = pbHabilita;
            checkBoxClients.Enabled = pbHabilita;
            checkBoxNeighboors.Enabled = pbHabilita;
            btnGuardar.Enabled = pbHabilita;

        }

    }
}




