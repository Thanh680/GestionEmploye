using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEmploye.Forms;
using System.Data.SqlClient;

namespace GestionEmploye
{
    public partial class FormCompetence : Form
    {
        public FormCompetence()
        {
            InitializeComponent();
        }

        private void competenceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.competenceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionEmployeDataSet);

        }

        private void FormCompetence_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionEmployeDataSet.Employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.competenceTableAdapter.Fill(this.gestionEmployeDataSet.Competence);
        }

        private void btnNewCompetence_Click(object sender, EventArgs e)
        {
            FormNewCompetence fnc = new FormNewCompetence();
            fnc.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.competenceTableAdapter.Fill(this.gestionEmployeDataSet.Competence);
        }

        private void competenceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // LISTE EMPLOYE
            listBoxEmploye.Items.Clear();
            SqlDataReader dr;
            string query = "SELECT nom, prenom " +
                "FROM Employe " +
                "JOIN EmployeCompetence ON Employe.id = EmployeCompetence.idEmploye " +
                "WHERE idCompetence = '" + competenceDataGridView.SelectedRows[0].Cells[0].Value + "'";
            SqlCommand cmd = new SqlCommand(query, Connexion.getInstance());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBoxEmploye.Items.Add(dr["nom"].ToString() + " " + dr["prenom"].ToString());
            }
            cmd = null;
            dr.Close();
            dr = null;
            // FIN LISTE EMPLOYE
        }
    }
}
