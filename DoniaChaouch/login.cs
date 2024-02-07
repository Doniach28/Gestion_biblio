using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DoniaChaouch
{
    public partial class login : Form

    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = bibliotheque.mdb";
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtsql = "select count (login) from connexion where login='" + TXT_login.Text + "' and pwd='" + TXT_pwd.Text + "'";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            Int32 ival;

            try
            {
                ocm.Connection.Open();
                ival = Convert.ToInt32(ocm.ExecuteScalar());
                if (ival == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("verifier l'identifient", "erreur login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXT_login.Text = "";
                    TXT_pwd.Text = "";
                    TXT_login.Focus();
                    ocm.Connection.Close();
                }
                else
                {
                    ocm.Connection.Close();
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

