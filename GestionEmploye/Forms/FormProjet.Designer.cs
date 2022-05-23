namespace GestionEmploye
{
    partial class FormProjet
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
            this.btnNewProjet = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnNewProjet
            // 
            this.btnNewProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnNewProjet.FlatAppearance.BorderSize = 0;
            this.btnNewProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProjet.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnNewProjet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProjet.ForeColor = System.Drawing.Color.White;
            this.btnNewProjet.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNewProjet.IconColor = System.Drawing.Color.White;
            this.btnNewProjet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewProjet.IconSize = 30;
            this.btnNewProjet.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewProjet.Location = new System.Drawing.Point(36, 40);
            this.btnNewProjet.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewProjet.Name = "btnNewProjet";
            this.btnNewProjet.Size = new System.Drawing.Size(149, 44);
            this.btnNewProjet.TabIndex = 0;
            this.btnNewProjet.Text = "Nouveau projet";
            this.btnNewProjet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewProjet.UseVisualStyleBackColor = false;
            // 
            // FormProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1063, 614);
            this.Controls.Add(this.btnNewProjet);
            this.Name = "FormProjet";
            this.Text = "FormProjet";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnNewProjet;
    }
}