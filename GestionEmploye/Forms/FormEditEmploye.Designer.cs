namespace GestionEmploye.Forms
{
    partial class FormEditEmploye
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
            this.listBoxID = new System.Windows.Forms.ListBox();
            this.checkedListBoxCompetence = new System.Windows.Forms.CheckedListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxID
            // 
            this.listBoxID.FormattingEnabled = true;
            this.listBoxID.Location = new System.Drawing.Point(513, 235);
            this.listBoxID.Name = "listBoxID";
            this.listBoxID.Size = new System.Drawing.Size(120, 95);
            this.listBoxID.TabIndex = 17;
            this.listBoxID.Visible = false;
            // 
            // checkedListBoxCompetence
            // 
            this.checkedListBoxCompetence.FormattingEnabled = true;
            this.checkedListBoxCompetence.Location = new System.Drawing.Point(104, 218);
            this.checkedListBoxCompetence.Name = "checkedListBoxCompetence";
            this.checkedListBoxCompetence.Size = new System.Drawing.Size(269, 124);
            this.checkedListBoxCompetence.TabIndex = 16;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(181, 373);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(181, 160);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrenom.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Prenom";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(181, 100);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNom.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // comboBoxId
            // 
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Location = new System.Drawing.Point(181, 48);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(100, 21);
            this.comboBoxId.TabIndex = 18;
            this.comboBoxId.SelectedIndexChanged += new System.EventHandler(this.comboBoxId_SelectedIndexChanged);
            // 
            // FormEditEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 425);
            this.Controls.Add(this.comboBoxId);
            this.Controls.Add(this.listBoxID);
            this.Controls.Add(this.checkedListBoxCompetence);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditEmploye";
            this.Text = "FormEditEmploye";
            this.Load += new System.EventHandler(this.FormEditEmploye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxID;
        private System.Windows.Forms.CheckedListBox checkedListBoxCompetence;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxId;
    }
}