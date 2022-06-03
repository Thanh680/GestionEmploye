namespace GestionEmploye.Forms
{
    partial class FormEditProjet
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxdateDebut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDateFin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(177, 78);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 1;
            // 
            // txtBoxLibelle
            // 
            this.txtBoxLibelle.Location = new System.Drawing.Point(177, 128);
            this.txtBoxLibelle.Name = "txtBoxLibelle";
            this.txtBoxLibelle.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLibelle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "libelle";
            // 
            // txtBoxdateDebut
            // 
            this.txtBoxdateDebut.Location = new System.Drawing.Point(177, 182);
            this.txtBoxdateDebut.Name = "txtBoxdateDebut";
            this.txtBoxdateDebut.Size = new System.Drawing.Size(100, 20);
            this.txtBoxdateDebut.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "dateDebut";
            // 
            // txtBoxDateFin
            // 
            this.txtBoxDateFin.Location = new System.Drawing.Point(177, 229);
            this.txtBoxDateFin.Name = "txtBoxDateFin";
            this.txtBoxDateFin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDateFin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "dateFin";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(186, 279);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // FormEditProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 358);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtBoxDateFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxdateDebut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label1);
            this.Name = "FormEditProjet";
            this.Text = "FormEditProjet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxLibelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxdateDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDateFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnValider;
    }
}