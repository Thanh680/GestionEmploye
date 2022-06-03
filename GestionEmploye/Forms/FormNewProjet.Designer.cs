namespace GestionEmploye.Forms
{
    partial class FormNewProjet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLibelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDateDebut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDateFin = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.checkedListBoxCompetence = new System.Windows.Forms.CheckedListBox();
            this.listBoxIDC = new System.Windows.Forms.ListBox();
            this.checkedListBoxEmploye = new System.Windows.Forms.CheckedListBox();
            this.listBoxIDE = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(159, 46);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "libelle";
            // 
            // txtBoxLibelle
            // 
            this.txtBoxLibelle.Location = new System.Drawing.Point(159, 91);
            this.txtBoxLibelle.Name = "txtBoxLibelle";
            this.txtBoxLibelle.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLibelle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "datedebut";
            // 
            // txtBoxDateDebut
            // 
            this.txtBoxDateDebut.Location = new System.Drawing.Point(159, 136);
            this.txtBoxDateDebut.Name = "txtBoxDateDebut";
            this.txtBoxDateDebut.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDateDebut.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "datefin";
            // 
            // txtBoxDateFin
            // 
            this.txtBoxDateFin.Location = new System.Drawing.Point(159, 183);
            this.txtBoxDateFin.Name = "txtBoxDateFin";
            this.txtBoxDateFin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDateFin.TabIndex = 6;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(170, 378);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // checkedListBoxCompetence
            // 
            this.checkedListBoxCompetence.FormattingEnabled = true;
            this.checkedListBoxCompetence.Location = new System.Drawing.Point(80, 222);
            this.checkedListBoxCompetence.Name = "checkedListBoxCompetence";
            this.checkedListBoxCompetence.Size = new System.Drawing.Size(269, 124);
            this.checkedListBoxCompetence.TabIndex = 9;
            // 
            // listBoxIDC
            // 
            this.listBoxIDC.FormattingEnabled = true;
            this.listBoxIDC.Location = new System.Drawing.Point(308, 100);
            this.listBoxIDC.Name = "listBoxIDC";
            this.listBoxIDC.Size = new System.Drawing.Size(96, 56);
            this.listBoxIDC.TabIndex = 10;
            this.listBoxIDC.Visible = false;
            // 
            // checkedListBoxEmploye
            // 
            this.checkedListBoxEmploye.FormattingEnabled = true;
            this.checkedListBoxEmploye.Location = new System.Drawing.Point(399, 222);
            this.checkedListBoxEmploye.Name = "checkedListBoxEmploye";
            this.checkedListBoxEmploye.Size = new System.Drawing.Size(269, 124);
            this.checkedListBoxEmploye.TabIndex = 11;
            // 
            // listBoxIDE
            // 
            this.listBoxIDE.FormattingEnabled = true;
            this.listBoxIDE.Location = new System.Drawing.Point(446, 100);
            this.listBoxIDE.Name = "listBoxIDE";
            this.listBoxIDE.Size = new System.Drawing.Size(96, 56);
            this.listBoxIDE.TabIndex = 12;
            // 
            // FormNewProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 461);
            this.Controls.Add(this.listBoxIDE);
            this.Controls.Add(this.checkedListBoxEmploye);
            this.Controls.Add(this.listBoxIDC);
            this.Controls.Add(this.checkedListBoxCompetence);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxDateFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxDateDebut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxLibelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxId);
            this.Name = "FormNewProjet";
            this.Text = "FormNewProjet";
            this.Load += new System.EventHandler(this.FormNewProjet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLibelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDateDebut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxDateFin;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.CheckedListBox checkedListBoxCompetence;
        private System.Windows.Forms.ListBox listBoxIDC;
        private System.Windows.Forms.CheckedListBox checkedListBoxEmploye;
        private System.Windows.Forms.ListBox listBoxIDE;
    }
}