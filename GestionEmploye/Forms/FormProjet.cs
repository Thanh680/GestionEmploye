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
using GestionEmploye.Forms;

namespace GestionEmploye
{
    public partial class FormProjet : Form
    {
        public FormProjet()
        {
            InitializeComponent();
        }

        private void btnNewProjet_Click(object sender, EventArgs e)
        {
            FormNewProjet fnp = new FormNewProjet();
            fnp.ShowDialog();
        }

        public void FormProjet_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionEmployeDataSet.Projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.projetTableAdapter.Fill(this.gestionEmployeDataSet.Projet);
        }

        private void btnDeleteProjet_Click(object sender, EventArgs e)
        {

            string req = "UPDATE Employe SET idProjet = NULL " +
                "WHERE idProjet = " + projetDataGridView.SelectedRows[0].Cells[0].Value; 
            req += "DELETE FROM ProjetCompetence " +
                         "WHERE idProjet = " + projetDataGridView.SelectedRows[0].Cells[0].Value;
            req += "DELETE FROM Projet " +
                   "WHERE id = " + projetDataGridView.SelectedRows[0].Cells[0].Value;
            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                //Exécution de la commande
                com.ExecuteNonQuery();

                //Libération de la commande
                com = null;
                MessageBox.Show("Projet supprimé");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            this.projetTableAdapter.Fill(this.gestionEmployeDataSet.Projet);
        }

        private void btnRefreshProjet_Click(object sender, EventArgs e)
        {
            this.projetTableAdapter.Fill(this.gestionEmployeDataSet.Projet);
        }

        private void btnEditProjet_Click(object sender, EventArgs e)
        {
            FormEditProjet fep = new FormEditProjet();
            fep.ShowDialog();
        }

        private void projetDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // LISTE COMPETENCE
            listBoxCompetence.Items.Clear();
            SqlDataReader dr1;
            string query1 = "SELECT libelle " +
                "FROM Competence " +
                "JOIN ProjetCompetence ON Competence.id = ProjetCompetence.idCompetence " +
                "WHERE idProjet = '" + projetDataGridView.SelectedRows[0].Cells[0].Value + "'";
            SqlCommand cmd = new SqlCommand(query1, Connexion.getInstance());
            dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                listBoxCompetence.Items.Add(dr1["libelle"].ToString());
            }
            cmd = null;
            dr1.Close();
            dr1 = null;
            // FIN LISTE COMPETENCE

            // LISTE EMPLOYE
            listBoxEmploye.Items.Clear();
            SqlDataReader dr2;
            string query = "SELECT nom, prenom " +
                "FROM Projet " +
                "JOIN Employe ON Projet.id = Employe.idProjet " +
                "WHERE idProjet = '" + projetDataGridView.SelectedRows[0].Cells[0].Value + "'";
            SqlCommand cmd2 = new SqlCommand(query, Connexion.getInstance());
            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                listBoxEmploye.Items.Add(dr2["nom"].ToString() + " " + dr2["prenom"].ToString());
            }
            cmd = null;
            dr2.Close();
            dr2 = null;
            // FIN LISTE EMPLOYE

        }
    }
}
