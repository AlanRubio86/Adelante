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

namespace SLD_v1._0
{
    public partial class frmUsuarios : BaseForm
    {
        string movcitas = "0", movtrat = "0", movventa = "0", movcajas = "0", movabonos = "0";
        string catusua = "0", catcli = "0", catarea = "0",catproductos="0",catcajas="0";
        string repusua = "0", repclie = "0", repare = "0",repproductos="0",repcitas="0",reptrat="0",reppunto="0";
        string movusuarios = "0", AdmonBD = "0",Algoritmo="0";


        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            txtid.Focus();
            MaxId();
          
        }
        public void Limpiar() 
        {
            MaxId();
            txtnombre.ResetText();
            txtapellido.ResetText();
            txtcel.ResetText();
            txtcorreo.ResetText();
            txtnick.ResetText();
            txtpass.ResetText();
            txtpassconfirm.ResetText();
            combopuesto.ResetText();

            ckEstado.Checked = false;
            movcitas = "0"; movtrat = "0"; movventa = "0"; movcajas = "0"; movabonos = "0";
            catusua = "0"; catcli = "0";catarea = "0"; catproductos = "0"; catcajas = "0";
            repusua = "0"; repclie = "0"; repare = "0"; repproductos = "0"; repcitas = "0"; reptrat = "0"; reppunto = "0";
            movusuarios = "0"; AdmonBD = "0"; Algoritmo = "0"; 

            checkBoxcatusua.Checked = false; 
            checkBoxcatcli.Checked = false;  
            checkBoxcatarea.Checked = false;
            txtnombre.Focus();
        }
        public void MaxId() 
        {
            SqlConnection Conexion = new SqlConnection(SLD_v1._0.Properties.Settings.Default.Conexion);
            try
            {

                Conexion.Open();
                string consulta = "select max(IdUsuario) as maximo from Usuarios";
                DataSet dataset = new DataSet();
                dataset = SqlHelper.ExecuteDataset(Conexion, CommandType.Text, consulta);
                if (dataset != null && dataset.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in dataset.Tables[0].Rows)
                    {
                        if (row["maximo"].ToString().Equals(""))
                        {
                            txtid.Text = "1";
                        }
                        else
                        {
                            txtid.Text = (Convert.ToInt32(row["maximo"].ToString()) + 1).ToString();
                        }
                    } 
                }
            }
            catch (Exception exc)
            {
                Alerta A = new Alerta();
                 A.MessageAlert(exc.Message, "Catalogo de usuarios", Alerta.MessageIcon.ErrorVista, Alerta.MessageButton.Ok); 
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
                    viEstado = 1;
                else
                    viEstado = 0;
                EditAndInsert("Actualizado con éxito", "Actualizar", viEstado);
                Limpiar();
            }

        }

        public override void Editar()
        {
            Habilitar(true);
            txtnombre.Focus();
        }

        public void EditAndInsert(string psMensage, string psTitulo, int piEstado)
        {
                Alerta A = new Alerta();
                SqlConnection Conexion = new SqlConnection(SLD_v1._0.Properties.Settings.Default.Conexion);
                 
                Conexion.Open();
                SqlTransaction trans = Conexion.BeginTransaction();
                 
                chekarPermisos();
                try
                {
                    string Sp = "Sp_AltaUsuario";
                    SqlParameter[] pars = new SqlParameter[33];
                    pars[0] = new SqlParameter("@id", Convert.ToInt32(txtid.Text));
                    pars[1] = new SqlParameter("@nombre", txtnombre.Text);
                    pars[2] = new SqlParameter("@apellidos", txtapellido.Text);
                    pars[3] = new SqlParameter("@puesto", combopuesto.SelectedItem.ToString());
                    pars[8] = new SqlParameter("@celular", txtcel.Text);
                    pars[9] = new SqlParameter("@correo", txtcorreo.Text);
                    pars[10] = new SqlParameter("@nick", txtnick.Text);
                    pars[11] = new SqlParameter("@pass", txtpass.Text);
                    pars[12] = new SqlParameter("@movcitas", movcitas);
                    pars[13] = new SqlParameter("@movtrat", movtrat);
                    pars[14] = new SqlParameter("@catusua", catusua);
                    pars[15] = new SqlParameter("@catclie", catcli);
                    pars[16] = new SqlParameter("@catarea", catarea);
                    pars[17] = new SqlParameter("@repusua", repusua);
                    pars[18] = new SqlParameter("@repclie", repclie);
                    pars[19] = new SqlParameter("@reparea", repare);
                    pars[20] = new SqlParameter("@repproductos", repproductos);
                    pars[21] = new SqlParameter("@repcitas", repcitas);
                    pars[22] = new SqlParameter("@reptrat", reptrat);
                    pars[23] = new SqlParameter("@movventas", movventa);
                    pars[24] = new SqlParameter("@movcajas" ,movcajas);
                    pars[25] = new SqlParameter("@movabonos",movabonos);
                    pars[26] = new SqlParameter("@catproductos",catproductos);
                    pars[27] = new SqlParameter("@catcajas" ,catcajas);
                    pars[28] = new SqlParameter("@reppunto",reppunto);
                    pars[29] = new SqlParameter("@movusuarios",movusuarios);
                    pars[30] = new SqlParameter("@admindb",AdmonBD);
                    pars[31] = new SqlParameter("@algoritmo", Algoritmo);
                    pars[32] = new SqlParameter("@status", piEstado);
                    SqlHelper.ExecuteDataset(trans, Sp, pars);
                    trans.Commit();
                    
                    Limpiar();

                }
                catch (Exception ex)
                {

                    A.MessageAlert("Error al tratar de insertar en la base de datos " + ex.Message, "Error  al insertar", Alerta.MessageIcon.ErrorVista, Alerta.MessageButton.Ok);
                }
                finally
                {
                  
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
            txtcorreo.Text = drDatos.Cells["colCorreo"].Value.ToString();
            txtnick.Text = drDatos.Cells["colNickname"].Value.ToString();
            txtpass.Text = drDatos.Cells["colPassword"].Value.ToString();
            txtpassconfirm.Text = drDatos.Cells["colPassword"].Value.ToString();

            ckEstado.Checked = Convert.ToBoolean(drDatos.Cells["colStatus"].Value);
            checkBoxcatusua.Checked = Convert.ToBoolean(drDatos.Cells["colCatUsuarios"].Value);
            checkBoxcatcli.Checked = Convert.ToBoolean(drDatos.Cells["colCatClientes"].Value);
            checkBoxcatarea.Checked = Convert.ToBoolean(drDatos.Cells["colCatAreas"].Value);

 
           
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
            if (checkBoxcatusua.Checked)  catusua = "1";  else catusua = "0"; 
            if (checkBoxcatcli.Checked )   catcli = "1";   else catcli = "0"; 
            if (checkBoxcatarea.Checked )  catarea = "1";  else catarea = "0";
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
            txtcorreo.Enabled = pbHabilita;
            txtnick.Enabled = pbHabilita;
            txtpass.Enabled = pbHabilita;
            txtpassconfirm.Enabled = pbHabilita;
            combopuesto.Enabled = pbHabilita;

            ckEstado.Enabled = pbHabilita;

            checkBoxcatusua.Enabled = pbHabilita;
            checkBoxcatcli.Enabled = pbHabilita;
            checkBoxcatarea.Enabled = pbHabilita;
            btnGuardar.Enabled = pbHabilita;
        
        } 
   } 
}

       
    

