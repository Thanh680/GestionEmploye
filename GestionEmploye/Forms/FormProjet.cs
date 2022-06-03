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

            string req = "DELETE FROM Projet " +
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
    }
}
