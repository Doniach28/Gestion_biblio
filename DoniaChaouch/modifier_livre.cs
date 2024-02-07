using Microsoft.VisualBasic;
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

namespace DoniaChaouch
{
    public partial class modifier_livre : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = bibliotheque.mdb";
        public modifier_livre()
        {
            InitializeComponent();
        }
        public void lancerRequete(string requete)
        {
            OleDbConnection ocn = new OleDbConnection();
            OleDbCommand ocm = new OleDbCommand();
            ocn.ConnectionString = sconstr;
            try
            {
                ocn.Open();
                ocm.Connection = ocn;
                ocm.CommandText = requete;
                ocm.ExecuteNonQuery();
                ocn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception Générée : " + ex.Message);
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            //UPDATE livre SET nom_colonne_1 = '" + TxT_titre_livre.Text + "' WHERE where isbn = " + TxT_isbn.Text + ";
            string txtsql = "UPDATE livre SET " +
     "titre_livre = '" + TxT_titre_livre.Text + "', " +
     "auteur = '" + TxT_auteur.Text + "', " +
     "annee_sortie = '" + TxT_annee_sortie.Text + "', " +
     "type_livre = '" + List_type_livre.Text + "', " +
     "editeur = '" + TxT_editeur.Text + "' " +
     "WHERE isbn = " + TxT_isbn.Text;


            lancerRequete(txtsql);
            MessageBox.Show("Modification Terminer");
            Form1 menuPrincipal = new Form1();

            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void modifier_client_Load(object sender, EventArgs e)
        {

        }
    }
}
