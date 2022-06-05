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
            this.btnValider = new System.Windows.Forms.Button();
            this.checkedListBoxCompetence = new System.Windows.Forms.CheckedListBox();
            this.listBoxIDC = new System.Windows.Forms.ListBox();
            this.checkedListBoxEmploye = new System.Windows.Forms.CheckedListBox();
            this.listBoxIDE = new System.Windows.Forms.ListBox();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
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
            this.label3.Location = new System.Drawing.Point(86, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "dateCreation";
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
            this.checkedListBoxCompetence.CheckOnClick = true;
            this.checkedListBoxCompetence.FormattingEnabled = true;
            this.checkedListBoxCompetence.Location = new System.Drawing.Point(80, 222);
            this.checkedListBoxCompetence.Name = "checkedListBoxCompetence";
            this.checkedListBoxCompetence.Size = new System.Drawing.Size(269, 124);
            this.checkedListBoxCompetence.TabIndex = 9;
            this.checkedListBoxCompetence.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxCompetence_ItemCheck);
            // 
            // listBoxIDC
            // 
            this.listBoxIDC.FormattingEnabled = true;
            this.listBoxIDC.Location = new System.Drawing.Point(328, 46);
            this.listBoxIDC.Name = "listBoxIDC";
            this.listBoxIDC.Size = new System.Drawing.Size(31, 4);
            this.listBoxIDC.TabIndex = 10;
            this.listBoxIDC.Visible = false;
            // 
            // checkedListBoxEmploye
            // 
            this.checkedListBoxEmploye.CheckOnClick = true;
            this.checkedListBoxEmploye.FormattingEnabled = true;
            this.checkedListBoxEmploye.Location = new System.Drawing.Point(399, 222);
            this.checkedListBoxEmploye.Name = "checkedListBoxEmploye";
            this.checkedListBoxEmploye.Size = new System.Drawing.Size(269, 124);
            this.checkedListBoxEmploye.TabIndex = 11;
            // 
            // listBoxIDE
            // 
            this.listBoxIDE.FormattingEnabled = true;
            this.listBoxIDE.Location = new System.Drawing.Point(378, 46);
            this.listBoxIDE.Name = "listBoxIDE";
            this.listBoxIDE.Size = new System.Drawing.Size(32, 4);
            this.listBoxIDE.TabIndex = 12;
            this.listBoxIDE.Visible = false;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(159, 139);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(86, 20);
            this.dateTimePickerDebut.TabIndex = 13;
            // 
            // FormNewProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 461);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.listBoxIDE);
            this.Controls.Add(this.checkedListBoxEmploye);
            this.Controls.Add(this.listBoxIDC);
            this.Controls.Add(this.checkedListBoxCompetence);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.CheckedListBox checkedListBoxCompetence;
        private System.Windows.Forms.ListBox listBoxIDC;
        private System.Windows.Forms.CheckedListBox checkedListBoxEmploye;
        private System.Windows.Forms.ListBox listBoxIDE;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
    }
}