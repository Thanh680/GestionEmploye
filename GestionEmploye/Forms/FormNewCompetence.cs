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
    public partial class FormNewCompetence : Form
    {
        public FormNewCompetence()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Requête de type INSERT INTO
            string req = "INSERT INTO Competence VALUES('" + txtBoxID.Text + "','" + txtBoxNom.Text + "')";
            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                //On exécute la commande
                com.ExecuteNonQuery();

                //Libération de la commande
                com = null;

                MessageBox.Show("Competence enregistré");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
