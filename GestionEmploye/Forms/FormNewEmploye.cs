using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GestionEmploye.Forms
{
    public partial class FormNewEmploye : Form
    {
        public FormNewEmploye()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            foreach (string s in checkedListBoxCompetence.CheckedItems)
            {
                string query = "select id from Competence where libelle = '" + s + "'";
                SqlCommand cmd = new SqlCommand(query, Connexion.getInstance());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    listBoxID.Items.Add(dr["id"].ToString());
                }
                cmd = null;
                dr.Close();
                dr = null;
            }
            //Requête de type INSERT INTO
            string req = "INSERT INTO Employe VALUES(" + txtBoxID.Text + ",'" + txtBoxNom.Text + "','" + txtBoxPrenom.Text + "', NULL)";
            foreach (string s in listBoxID.Items)
            {
                req += "INSERT INTO EmployeCompetence VALUES(" + txtBoxID.Text + "," + s + ")";
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

        private void FormNewEmploye_Load(object sender, EventArgs e)
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
        }

    }
}
