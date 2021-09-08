using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Adelante.Core.Services;
using Microsoft.ApplicationBlocks.Data;
using escAlerta;
using Newtonsoft.Json;

namespace Adelante
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DataSet dts = null;
        public void Limpiar() 
        {
            txtPass.ResetText();
            txtUser.ResetText();
            txtUser.Focus();
        }
        public void Login() 
        {
            if (txtPass.IsEmpty())
            {
                txtPass.showError(txtPass.mensajeError);

            }
            else
            {
                txtPass.clearError();
            }
            if (txtUser.IsEmpty())
            {
                txtUser.showError(txtUser.mensajeError);

            }
            else
            {
                txtUser.clearError();
            }
            if (txtUser.IsEmpty() == false && txtPass.IsEmpty() == false)
            {

                SessionService sessionService = new SessionService();
                try
                {
                    var result = sessionService.Login(txtUser.Text, txtPass.Text);

                    if (result != null)
                    {
                        Properties.Settings.Default.Accesos = JsonConvert.SerializeObject(result);
                        Properties.Settings.Default.Sesion = true;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        Alerta A = new Alerta();
                        A.MessageAlert("El usuario no existe", "Inicio de Sesion", Alerta.MessageIcon.ErrorVista, Alerta.MessageButton.Ok);
                        Limpiar();
                    }


                }
                catch (Exception ex)
                {
                    Alerta A = new Alerta();
                    A.BackColor = Color.LightSteelBlue;
                    A.BackgroundImage = null;
                    A.MessageAlert("El usuario no existe", "Inicio de Sesion", Alerta.MessageIcon.ErrorVista, Alerta.MessageButton.Ok);
                    Limpiar();

                }
                finally
                {
                    GC.Collect();
                }
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Login(); 
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
         txtPass.ehKeyEnter+=new txtBox.uctxtBox.EventHandlerEnter(Login);  
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

      

        

        
    }
}
