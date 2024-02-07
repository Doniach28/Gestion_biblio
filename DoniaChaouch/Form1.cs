using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoniaChaouch
{
    public partial class Form1 : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = bibliotheque.mdb";
        public Form1()
        {
            InitializeComponent();
        }
        public void charger_Liste_livre()
        {
            dataGridView1.Rows.Clear();
            string txtsql = "select * from livre";

            try
            {
                using (OleDbConnection ocn = new OleDbConnection(sconstr))
                {
                    ocn.Open(); // Vérifier si l'ouverture de la connexion se fait sans erreur
                    using (OleDbCommand ocm = new OleDbCommand(txtsql, ocn))
                    {
                        using (OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (reader.Read())
                            {
                                string[] row = new string[] { reader.GetValue(0).ToString(),
                                 reader.GetString(1),
                                 reader.GetString(2),
                                 reader.GetValue(3).ToString(),
                                 reader.GetString(4),
                                 reader.GetString(5)
                                };
                                dataGridView1.Rows.Add(row);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des données : " + ex.Message);
            }
        }

        public void nbr_livre()
        {
            Int32 count = 0;
            string txtsql;
            txtsql = "select count (*) from livre";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            count = Convert.ToInt32(ocm.ExecuteScalar());

            ocn.Close();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn_ajout_Click(object sender, EventArgs e)
        {

            Ajout aj = new Ajout();
            aj.ShowDialog();
            charger_Liste_livre();
            nbr_livre();
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {

            modifier_livre frm_modif = new modifier_livre(); // nom de formulaire modifier_livre
            int lignecourrant;
            string ISBN, Titrelivre, Auteur, Annéesortie, Typelivre, Editeur;

            if (dataGridView1.RowCount == 0)
                return;
            lignecourrant = dataGridView1.CurrentRow.Index;


            ISBN = dataGridView1.Rows[lignecourrant].Cells[0].Value.ToString();
            Titrelivre = dataGridView1.Rows[lignecourrant].Cells[1].Value.ToString();
            Auteur = dataGridView1.Rows[lignecourrant].Cells[2].Value.ToString();
            Annéesortie = dataGridView1.Rows[lignecourrant].Cells[3].Value.ToString();
            Typelivre = dataGridView1.Rows[lignecourrant].Cells[4].Value.ToString();
            Editeur = dataGridView1.Rows[lignecourrant].Cells[5].Value.ToString();

            frm_modif.TxT_isbn.Text = ISBN;
            frm_modif.TxT_titre_livre.Text = Titrelivre;
            frm_modif.TxT_auteur.Text = Auteur;
            frm_modif.TxT_annee_sortie.Text = Annéesortie;
            frm_modif.List_type_livre.Text = Typelivre;
            frm_modif.TxT_editeur.Text = Editeur;
            frm_modif.TxT_isbn.Enabled = false;
            frm_modif.ShowDialog();
            charger_Liste_livre();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            charger_Liste_livre();
            nbr_livre();
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
                int k = ocm.ExecuteNonQuery();
                ocn.Close();
                MessageBox.Show("***Supression terminer avec succée***");
            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }
        }

        private void btn_supprime_Click(object sender, EventArgs e)
        {
            int lignecourrant;
            string isbn;
            string req_sup;
            if (dataGridView1.RowCount == 0)
                return;
            lignecourrant = dataGridView1.CurrentRow.Index;

            isbn = dataGridView1.Rows[lignecourrant].Cells[0].Value.ToString();
            DialogResult Supp_client =
                (MessageBox.Show("voulez vous supprimer le livre '" +
                dataGridView1.Rows[lignecourrant].Cells[1].Value.ToString() +
                "'", "supression livre", MessageBoxButtons.YesNo));
            if (Supp_client == DialogResult.Yes)
            {
                req_sup = "delete from livre where isbn=" + isbn + "";
                lancerRequete(req_sup);
                charger_Liste_livre();
            }
            else
            {
                return;
            }

        }


        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_recherche_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string txtsql;
            //txtsql = "select *  from client where numclient like '%" + txt_recherche_clt.Text + "%' or nomclient like '%" + txt_recherche_clt.Text + "%' or ville like '%" + txt_recherche_clt.Text + "%' or CP like '%" + txt_recherche_clt.Text + "%' or tel like '%" + txt_recherche_clt.Text + "%' ";
            txtsql = "select *  from livre where  titre_livre like '%" + btn_recherche.Text + "%' or auteur  like '%" + btn_recherche.Text + "%'";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string[] row = new string[] { reader.GetValue(0).ToString(),
                    reader.GetString(1),
                                 reader.GetString(2),
                                 reader.GetValue(3).ToString(),
                                 reader.GetString(4),
                                 reader.GetString(5) };
                dataGridView1.Rows.Add(row);

            }
            reader.Close();
            ocn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}


