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
            // TODO: cette ligne de code charge les données dans la table 'gestionEmployeDataSet.Employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.gestionEmployeDataSet.Employe);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.employeTableAdapter.Fill(this.gestionEmployeDataSet.Employe);
        }

        private void btnDeleteEmploye_Click(object sender, EventArgs e)
        {
            string req = "DELETE FROM Employe " +
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
    }
}
