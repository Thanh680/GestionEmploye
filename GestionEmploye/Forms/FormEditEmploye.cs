using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionEmploye.Forms
{
    public partial class FormEditEmploye : Form
    {
        public FormEditEmploye()
        {
            InitializeComponent();
        }

        private void FormEditEmploye_Load(object sender, EventArgs e)
        {
            string query = "select * from Competence";
            SqlCommand cmd = new SqlCommand(query, Connexion.getInstance());
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                checkedListBoxCompetence.Items.Add(dt.Rows[i]["libelle"].ToString());
            }

            string query0 = "select * from Employe";
            SqlCommand cmd0 = new SqlCommand(query0, Connexion.getInstance());
            SqlDataAdapter sda0;
            DataTable dt0 = new DataTable();
            sda0 = new SqlDataAdapter(cmd0);
            sda0.Fill(dt0);
            for (int i = 0; i < dt0.Rows.Count; i++)
            {
                comboBoxId.Items.Add(dt0.Rows[i]["id"].ToString());
            }
            cmd0 = null;
        }

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr;
            string query = "select * from Employe WHERE id = " + comboBoxId.Text;
            SqlCommand cmd = new SqlCommand(query, Connexion.getInstance());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtBoxNom.Text = dr["nom"].ToString();
                txtBoxPrenom.Text = dr["prenom"].ToString();
            }
            cmd = null;
            dr.Close();
            dr = null;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // COMPETENCE
            SqlDataReader dr1;
            foreach (string s in checkedListBoxCompetence.CheckedItems)
            {
                string query1 = "select id from Competence where libelle = '" + s + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Connexion.getInstance());
                dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    listBoxID.Items.Add(dr1["id"].ToString());
                }
                cmd1 = null;
                dr1.Close();
                dr1 = null;
            }
            // FIN COMPETENCE

            //Recupere idProjet
            string idProjet = null;
            SqlDataReader dr2;
            string query2 = "select * from Employe where id = " + comboBoxId.Text;
            SqlCommand cmd2 = new SqlCommand(query2, Connexion.getInstance());
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                idProjet = dr2["idProjet"].ToString();
            }
            cmd2 = null;
            dr2.Close();
            dr2 = null;


            //Requête de type DELETE
            string reqD ="DELETE FROM EmployeCompetence " +
                         "WHERE idEmploye = " + comboBoxId.Text;
            reqD += "DELETE FROM Employe " +
                   "WHERE id = " + comboBoxId.Text;
            SqlCommand comD = new SqlCommand(reqD, Connexion.getInstance());
            try
            {
                //Exécution de la commande
                comD.ExecuteNonQuery();

                //Libération de la commande
                comD = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //FIN Requete DELETE

            //Requête de type INSERT INTO
            string req = "INSERT INTO Employe VALUES(" + comboBoxId.Text + ",'" + txtBoxNom.Text + "','" + txtBoxPrenom.Text + "','"+ idProjet +"')";
            foreach (string s in listBoxID.Items)
            {
                req += "INSERT INTO EmployeCompetence VALUES(" + comboBoxId.Text + "," + s + ")";
            }
            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                //On exécute la commande
                com.ExecuteNonQuery();

                //Libération de la commande
                com = null;

                MessageBox.Show("Employe enregistré");
                listBoxID.Items.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
