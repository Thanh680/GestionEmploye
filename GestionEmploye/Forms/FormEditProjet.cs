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
    public partial class FormEditProjet : Form
    {
        public FormEditProjet()
        {
            InitializeComponent();
        }

        private void FormEditProjet_Load(object sender, EventArgs e)
        {
            string query = "select * from Projet";
            SqlCommand cmd = new SqlCommand(query, Connexion.getInstance());

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
    }
}
