namespace GestionEmploye
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompetence = new FontAwesome.Sharp.IconButton();
            this.btnEmploye = new FontAwesome.Sharp.IconButton();
            this.btnProjet = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnCompetence);
            this.panel1.Controls.Add(this.btnEmploye);
            this.panel1.Controls.Add(this.btnProjet);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 658);
            this.panel1.TabIndex = 0;
            // 
            // btnCompetence
            // 
            this.btnCompetence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btnCompetence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompetence.FlatAppearance.BorderSize = 0;
            this.btnCompetence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetence.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetence.ForeColor = System.Drawing.Color.White;
            this.btnCompetence.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnCompetence.IconColor = System.Drawing.Color.White;
            this.btnCompetence.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompetence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetence.Location = new System.Drawing.Point(0, 218);
            this.btnCompetence.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCompetence.Name = "btnCompetence";
            this.btnCompetence.Size = new System.Drawing.Size(236, 54);
            this.btnCompetence.TabIndex = 7;
            this.btnCompetence.Text = "Competence";
            this.btnCompetence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompetence.UseVisualStyleBackColor = false;
            this.btnCompetence.Click += new System.EventHandler(this.btnCompetence_Click);
            // 
            // btnEmploye
            // 
            this.btnEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btnEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmploye.FlatAppearance.BorderSize = 0;
            this.btnEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEmploye.IconChar = FontAwesome.Sharp.IconChar.HardHat;
            this.btnEmploye.IconColor = System.Drawing.Color.White;
            this.btnEmploye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploye.Location = new System.Drawing.Point(0, 164);
            this.btnEmploye.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Size = new System.Drawing.Size(236, 54);
            this.btnEmploye.TabIndex = 6;
            this.btnEmploye.Text = "Employe";
            this.btnEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmploye.UseVisualStyleBackColor = false;
            this.btnEmploye.Click += new System.EventHandler(this.btnEmploye_Click);
            // 
            // btnProjet
            // 
            this.btnProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btnProjet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjet.FlatAppearance.BorderSize = 0;
            this.btnProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjet.ForeColor = System.Drawing.Color.White;
            this.btnProjet.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnProjet.IconColor = System.Drawing.Color.White;
            this.btnProjet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProjet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjet.Location = new System.Drawing.Point(0, 110);
            this.btnProjet.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProjet.Name = "btnProjet";
            this.btnProjet.Size = new System.Drawing.Size(236, 54);
            this.btnProjet.TabIndex = 5;
            this.btnProjet.Text = "Projet";
            this.btnProjet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjet.UseVisualStyleBackColor = false;
            this.btnProjet.Click += new System.EventHandler(this.btnProjet_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 110);
            this.panel4.TabIndex = 4;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(236, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(928, 658);
            this.panelDesktop.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(236, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(928, 34);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.HackerNews;
            this.btnMinimize.IconColor = System.Drawing.Color.Transparent;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(780, -21);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 54);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.btnMaximize.IconColor = System.Drawing.Color.Transparent;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.Location = new System.Drawing.Point(830, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(48, 32);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.btnClose.IconColor = System.Drawing.Color.Transparent;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(880, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 658);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnCompetence;
        private FontAwesome.Sharp.IconButton btnEmploye;
        private FontAwesome.Sharp.IconButton btnProjet;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}

