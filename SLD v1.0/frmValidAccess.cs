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
    public partial class frmValidAccess : BaseForm
    {
        public frmValidAccess()
        {
            InitializeComponent();
        }

        private void frmValidAccess_Load(object sender, EventArgs e)
        {
            llenaComboSexo();
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


        public override void Guardar()
        {
            EditAndInsert("Insertado con éxito", "Guardar", 0);
        }

        public override void Editar()
        {
            Habilitar(true);
        }

        public override void Eliminar()
        {
            Alerta A = new Alerta();
            DialogResult result = A.MessageAlert("Deseas eliminar la información", "Eliminar", Alerta.MessageIcon.QuestionVista, Alerta.MessageButton.OkCancel);

            if (result.Equals(DialogResult.OK))
            {
                
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
        
        public void llenaRenglon(DataGridViewRow drDatos)
        {
            int total = drDatos.Cells["colCorreo"].Value.ToString().Length;
            string correo = drDatos.Cells["colCorreo"].Value.ToString();

            Habilitar(false);
        }

        public void Habilitar(bool pbHabilita)
        {
            btnGuardar.Enabled = pbHabilita;
        }

        public override void Restablecer()
        {
            Habilitar(true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
