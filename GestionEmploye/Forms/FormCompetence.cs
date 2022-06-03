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
    }
}
