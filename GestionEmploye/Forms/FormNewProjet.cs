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
            //Requête de type INSERT INTO
            string req = "INSERT INTO Projet VALUES('" + txtBoxId.Text + "','" + txtBoxLibelle.Text + "','" + txtBoxDateDebut.Text + "','" + txtBoxDateFin.Text + "')";
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

    }
}
