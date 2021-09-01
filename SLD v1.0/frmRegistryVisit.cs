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
using Microsoft.ApplicationBlocks.Data;
using System.IO;

namespace SLD_v1._0
{
    public partial class frmRegistryVisit : BaseForm
    {
        public frmRegistryVisit()
        {
            InitializeComponent();
        }

        private void frmRegistryVisit_Load(object sender, EventArgs e)
        {
            llenaComboSexo();
            MaxId();
        }

        public void llenaComboSexo()
        {
            DataTable tblSexo = new DataTable();
            tblSexo.Columns.Add("Tipo", typeof(string));
            tblSexo.Columns.Add("Descripcion", typeof(string));
            object[] objArr = new object[] { "Mujer", "Mujer" };
            tblSexo.Rows.Add(objArr);
            objArr = new object[] { "Hombre", "Hombre" };
            tblSexo.Rows.Add(objArr);

            cbxsexo.ValueMember = "Tipo";
            cbxsexo.DisplayMember = "Descripcion";
            cbxsexo.DataSource = tblSexo;

            DataTable tbltipo = new DataTable();
            tbltipo.Columns.Add("Tipo", typeof(int));
            tbltipo.Columns.Add("Descripcion", typeof(string));
            object[] objArr2 = new object[] { 0, "Pagado" };
            tbltipo.Rows.Add(objArr2);
            objArr2 = new object[] { 1, "Pagos" };
            tbltipo.Rows.Add(objArr2);
            objArr2 = new object[] { 2, "Moroso" };
            tbltipo.Rows.Add(objArr2);
        }

        public void MaxId()
        {
            SqlConnection Conexion = new SqlConnection(SLD_v1._0.Properties.Settings.Default.Conexion);
            try
            {
                Conexion.Open();
                string consulta = "select max(IdCliente) as maximo from Clientes";
                DataSet dataset = new DataSet();
                dataset = SqlHelper.ExecuteDataset(Conexion, CommandType.Text, consulta);
                if (dataset != null && dataset.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in dataset.Tables[0].Rows)
                    {
                        if (row["maximo"].ToString().Equals(""))
                        {

                            txtClave.Text = "1";
                        }
                        else
                        {
                            txtClave.Text = (Convert.ToInt32(row["maximo"].ToString()) + 1).ToString();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Alerta A = new Alerta();
                A.MessageAlert(exc.Message, base.Text, Alerta.MessageIcon.ErrorVista, Alerta.MessageButton.Ok);

            }
            finally
            {
                Conexion.Close();
                Conexion.Dispose();
                GC.Collect();
            }

        }

        public override void Guardar()
        {
            if (validaCampos())
            {
                int viEstado;
                if (ckEstado.Checked)
                    viEstado = 0;
                else
                    viEstado = 0;

                EditAndInsert("Insertado con éxito", "Guardar", viEstado);
                Limpiar();
            }
        }

        public override void Editar()
        {
            Habilitar(true);
            txtNombres.Focus();
        }

        public override void Eliminar()
        {
            Alerta A = new Alerta();
            DialogResult result = A.MessageAlert("Deseas eliminar la información", "Eliminar", Alerta.MessageIcon.QuestionVista, Alerta.MessageButton.OkCancel);

            if (result.Equals(DialogResult.OK))
            {
                if (!txtClave.IsEmpty())
                    EditAndInsert("Eliminado con éxito", "Eliminar", 1);
                else
                {
                    A.MessageAlert("No ha tecleado un id para eliminar", "Eliminar", Alerta.MessageIcon.ErrorVista, Alerta.MessageButton.Ok);
                }
            }
        }

        public void EditAndInsert(string psMensage, string psTitulo, int piEstado)
        {
            SqlConnection Conexion = new SqlConnection(SLD_v1._0.Properties.Settings.Default.Conexion);

            Conexion.Open();
            SqlTransaction trans = Conexion.BeginTransaction();

            try
            {
                string Sp = "Sp_AltaClientes";
                SqlParameter[] pars = new SqlParameter[17];
                pars[0] = new SqlParameter("@id", Convert.ToInt32(txtClave.Text));
                pars[1] = new SqlParameter("@nombre", txtNombres.Text);
                pars[6] = new SqlParameter("@sexo", cbxsexo.SelectedValue.ToString());
                pars[13] = new SqlParameter("@status", piEstado);

                SqlHelper.ExecuteDataset(trans, Sp, pars);

                trans.Commit();

            }


            catch (Exception ex)
            {

                Alerta A = new Alerta();
                A.MessageAlert("Error al tratar de insertar en la base de datos " + ex, "Error", Alerta.MessageIcon.ErrorVista, Alerta.MessageButton.Ok);

            }
            finally
            {
                Alerta A = new Alerta();
                A.MessageAlert(psMensage, psTitulo, Alerta.MessageIcon.Good, Alerta.MessageButton.Ok);

                Conexion.Close();
                Conexion.Dispose();
                GC.Collect();
            }

        }

        public bool validaCampos()
        {
            BaseClase bas = new BaseClase();
            object[] loControles = new object[]
                                                {
                                                  txtClave,
                                                  txtNombres
                                                };
            return bas.checarControles(loControles);
        }


        public void llenaRenglon(DataGridViewRow drDatos)
        {
            txtClave.Text = drDatos.Cells["colId"].Value.ToString();
            txtNombres.Text = drDatos.Cells["colNombre"].Value.ToString();
            cbxsexo.Text = drDatos.Cells["colSexo"].Value.ToString();
            int total = drDatos.Cells["colCorreo"].Value.ToString().Length;
            string correo = drDatos.Cells["colCorreo"].Value.ToString();
            ckEstado.Checked = Convert.ToBoolean(drDatos.Cells["colStatus"].Value);

            CargarFoto();
            Habilitar(false);
        }
        public void CargarFoto()
        {
            string path = @"C:\FotosClientes\" + txtClave.Text + ".Jpeg";
            Image imagen;
            if (File.Exists(path))
            {
                imagen = Image.FromFile(path);
            }
            else
            {
                imagen = SLD_v1._0.Properties.Resources.Document;
            }
        }
        public void Limpiar()
        {

            ckEstado.Checked = false;
            txtNombres.ResetText();
            cbxsexo.SelectedItem = 0;
            ClearError();
            MaxId();
        }

        public void ClearError()
        {
            txtClave.clearError();
            txtNombres.clearError();
        }

        public void Habilitar(bool pbHabilita)
        {
            ckEstado.Enabled = pbHabilita;
            txtNombres.Enabled = pbHabilita;
            cbxsexo.Enabled = pbHabilita;
            btnGuardar.Enabled = pbHabilita;
        }

        public override void Restablecer()
        {
            Limpiar();
            Habilitar(true);
        }
    }
}
