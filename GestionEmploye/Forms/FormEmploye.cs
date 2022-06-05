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
    public partial class FormEmploye : Form
    {
        public FormEmploye()
        {
            InitializeComponent();
        }

        private void btnNewEmploye_Click(object sender, EventArgs e)
        {
            FormNewEmploye fne = new FormNewEmploye();
            fne.ShowDialog();
        }

        private void FormEmploye_Load(object sender, EventArgs e)
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
            for (int i = 0; i < checkedListBoxCompetence.Items.Count; i++)
            {
                checkedListBoxCompetence.SetItemChecked(i, true);
            }
            // TODO: cette ligne de code charge les données dans la table 'gestionEmployeDataSet.Employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.gestionEmployeDataSet.Employe);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.employeTableAdapter.Fill(this.gestionEmployeDataSet.Employe);
        }

        private void btnDeleteEmploye_Click(object sender, EventArgs e)
        {
            string req = "DELETE FROM EmployeCompetence " +
                "WHERE idEmploye = " + employeDataGridView.SelectedRows[0].Cells[0].Value;
            req += "DELETE FROM Employe " +
                         "WHERE id = " + employeDataGridView.SelectedRows[0].Cells[0].Value;
            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                //Exécution de la commande
                com.ExecuteNonQuery();

                //Libération de la commande
                com = null;
                MessageBox.Show("Employe supprimé");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            this.employeTableAdapter.Fill(this.gestionEmployeDataSet.Employe);
        }

        private void btnEditEmploye_Click(object sender, EventArgs e)
        {

        }

        private void employeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listBoxCompetence.Items.Clear();
            SqlDataReader dr1;
            string query1 = "SELECT libelle " +
                "FROM Competence " +
                "JOIN EmployeCompetence ON Competence.id = EmployeCompetence.idCompetence " +
                "WHERE idEmploye = '" + employeDataGridView.SelectedRows[0].Cells[0].Value + "'";
            SqlCommand cmd1 = new SqlCommand(query1, Connexion.getInstance());
            dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                listBoxCompetence.Items.Add(dr1["libelle"].ToString());
            }
            cmd1 = null;
            dr1.Close();
            dr1 = null;

            listBoxProjet.Items.Clear();
            SqlDataReader dr2;
            string query2 = "SELECT libelle " +
                "FROM Projet " +
                "JOIN Employe ON Projet.id = Employe.idProjet " +
                "WHERE Employe.id = '" + employeDataGridView.SelectedRows[0].Cells[0].Value + "'";
            SqlCommand cmd2 = new SqlCommand(query2, Connexion.getInstance());
            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                listBoxProjet.Items.Add(dr2["libelle"].ToString());
            }
            cmd2 = null;
            dr2.Close();
            dr2 = null;
        }

        private void checkedListBoxCompetence_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            string query = "select DISTINCT Employe.id, nom, prenom " +
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
                employeDataGridView.DataSource = dt;
                cmd = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                this.employeTableAdapter.Fill(this.gestionEmployeDataSet.Employe);
            }
        }

        private void checkedListBoxCompetence_ItemCheck(object sender, ItemCheckEventArgs e)
        {
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
            string query = "select DISTINCT Employe.id, nom, prenom " +
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
                employeDataGridView.DataSource = dt;
                cmd = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                this.employeTableAdapter.Fill(this.gestionEmployeDataSet.Employe);
            }

        }
    }
}

