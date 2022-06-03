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
            this.label2.Location = new System.Drawing.Point(113, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "libelle";
            // 
            // txtBoxLibelle
            // 
            this.txtBoxLibelle.Location = new System.Drawing.Point(159, 107);
            this.txtBoxLibelle.Name = "txtBoxLibelle";
            this.txtBoxLibelle.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLibelle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "datedebut";
            // 
            // txtBoxDateDebut
            // 
            this.txtBoxDateDebut.Location = new System.Drawing.Point(159, 172);
            this.txtBoxDateDebut.Name = "txtBoxDateDebut";
            this.txtBoxDateDebut.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDateDebut.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "datefin";
            // 
            // txtBoxDateFin
            // 
            this.txtBoxDateFin.Location = new System.Drawing.Point(159, 235);
            this.txtBoxDateFin.Name = "txtBoxDateFin";
            this.txtBoxDateFin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDateFin.TabIndex = 6;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(159, 301);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FormNewProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 439);
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
    }
}