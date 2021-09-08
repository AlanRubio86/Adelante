using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Net.Mail;

namespace Adelante
{
    public partial class frmLoad : Form
    {
        public static int a = 0;
        public frmLoad()
        {
            InitializeComponent();
        }

        private void frmLoad_Load(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value += 1;
            progressBar1.Text = progressBar1.Value.ToString() + "% Completed";
            if (progressBar1.Value == progressBar1.Maximum)
                tmrTiempo.Stop();
            if (progressBar1.Value == 100 && a == 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }   
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            tmrTiempo.Tick += new EventHandler(frmLoad_Load);
            tmrTiempo.Start();  
        }
    }
}
