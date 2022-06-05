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
    public partial class FormNewProjet : Form
    {
        public FormNewProjet()
        {
            InitializeComponent();
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
                    listBoxIDC.Items.Add(dr1["id"].ToString());
                }
                cmd1 = null;
                dr1.Close();
                dr1 = null;
            }
            // FIN COMPETENCE

            // EMPLOYE
            SqlDataReader dr2;
            foreach (string s in checkedListBoxEmploye.CheckedItems)
            {
                string[] tokens = s.Split(' ');
                MessageBox.Show(tokens[0]);
                string query2 = "select id from Employe where nom = '" + tokens[0] + "'";
                
                SqlCommand cmd2 = new SqlCommand(query2, Connexion.getInstance());
                dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    listBoxIDE.Items.Add(dr2["id"].ToString());
                }
                cmd2 = null;
                dr2.Close();
                dr2 = null;
            }
            //FIN EMPLOYE

            //Requête de type INSERT INTO
            string req = "INSERT INTO Projet VALUES('" + txtBoxId.Text + "','" + txtBoxLibelle.Text + "','" + dateTimePickerDebut.Text + "','')";
            foreach (string s in listBoxIDC.Items)
            {
                req += "INSERT INTO ProjetCompetence VALUES('" + txtBoxId.Text + "','" + s + "')";
            }
            foreach (string s in listBoxIDE.Items)
            {
                req += "UPDATE Employe SET idProjet = "+ txtBoxId.Text + " WHERE id = " + s;
            }
            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                //On exécute la commande
                com.ExecuteNonQuery();

                //Libération de la commande
                com = null;

                MessageBox.Show("Projet enregistré");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FormNewProjet_Load(object sender, EventArgs e)
        {
            // LIST COMPETENCE
            string query1 = "select * from Competence";
            SqlCommand cmd1 = new SqlCommand(query1, Connexion.getInstance());
            SqlDataAdapter sda1;
            DataTable dt1 = new DataTable();
            sda1 = new SqlDataAdapter(cmd1);
            sda1.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                checkedListBoxCompetence.Items.Add(dt1.Rows[i]["libelle"].ToString());
            }
            // FIN LIST COMPETENCE

            // LIST EMPLOYE
            string query2 = "select * from Employe";
            SqlCommand cmd2 = new SqlCommand(query2, Connexion.getInstance());
            SqlDataAdapter sda2;
            DataTable dt2 = new DataTable();
            sda2 = new SqlDataAdapter(cmd2);
            sda2.Fill(dt2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                string s = dt2.Rows[i]["nom"].ToString() + " " + dt2.Rows[i]["prenom"].ToString();
                checkedListBoxEmploye.Items.Add(s);
            }
            // FIN LIST EMPLOYE
        }

        private void checkedListBoxCompetence_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            checkedListBoxEmploye.Items.Clear();
            string chkBox = "";
            foreach (object itemChecked in checkedListBoxCompetence.CheckedItems)
            {
                if (chkBox == "")
                {
                    chkBox = "'" + itemChecked.ToString() + "'";
                }
                else
                {
                    chkBox += "," + "'" + itemChecked.ToString() + "'";
                }
            }
            string query = "select DISTINCT nom, prenom " +
                "from Employe " +
                "JOIN EmployeCompetence ON Employe.id = EmployeCompetence.idEmploye " +
                "JOIN Competence ON Competence.id = EmployeCompetence.idCompetence " +
                "where Competence.libelle in (" + chkBox + ")";
            SqlCommand cmd = new SqlCommand(query, Connexion.getInstance());
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            try
            {
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string s = dt.Rows[i]["nom"].ToString() + " " + dt.Rows[i]["prenom"].ToString();
                    checkedListBoxEmploye.Items.Add(s);
                }
                cmd = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
