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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNewProjet = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefreshProjet = new FontAwesome.Sharp.IconButton();
            this.btnDeleteProjet = new FontAwesome.Sharp.IconButton();
            this.btnEditProjet = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxEmploye = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxCompetence = new System.Windows.Forms.ListBox();
            this.projetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEmployeDataSet = new GestionEmploye.GestionEmployeDataSet();
            this.projetTableAdapter = new GestionEmploye.GestionEmployeDataSetTableAdapters.ProjetTableAdapter();
            this.tableAdapterManager = new GestionEmploye.GestionEmployeDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmployeDataSet)).BeginInit();
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
            this.btnNewProjet.Location = new System.Drawing.Point(23, 44);
            this.btnNewProjet.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewProjet.Name = "btnNewProjet";
            this.btnNewProjet.Size = new System.Drawing.Size(149, 44);
            this.btnNewProjet.TabIndex = 0;
            this.btnNewProjet.Text = "Nouveau projet";
            this.btnNewProjet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewProjet.UseVisualStyleBackColor = false;
            this.btnNewProjet.Click += new System.EventHandler(this.btnNewProjet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefreshProjet);
            this.panel1.Controls.Add(this.btnDeleteProjet);
            this.panel1.Controls.Add(this.btnEditProjet);
            this.panel1.Controls.Add(this.btnNewProjet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnRefreshProjet
            // 
            this.btnRefreshProjet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnRefreshProjet.FlatAppearance.BorderSize = 0;
            this.btnRefreshProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshProjet.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnRefreshProjet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProjet.ForeColor = System.Drawing.Color.White;
            this.btnRefreshProjet.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnRefreshProjet.IconColor = System.Drawing.Color.White;
            this.btnRefreshProjet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshProjet.IconSize = 30;
            this.btnRefreshProjet.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRefreshProjet.Location = new System.Drawing.Point(649, 44);
            this.btnRefreshProjet.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshProjet.Name = "btnRefreshProjet";
            this.btnRefreshProjet.Size = new System.Drawing.Size(107, 44);
            this.btnRefreshProjet.TabIndex = 3;
            this.btnRefreshProjet.Text = "Rafraichir";
            this.btnRefreshProjet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshProjet.UseVisualStyleBackColor = false;
            this.btnRefreshProjet.Click += new System.EventHandler(this.btnRefreshProjet_Click);
            // 
            // btnDeleteProjet
            // 
            this.btnDeleteProjet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnDeleteProjet.FlatAppearance.BorderSize = 0;
            this.btnDeleteProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProjet.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnDeleteProjet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProjet.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProjet.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnDeleteProjet.IconColor = System.Drawing.Color.White;
            this.btnDeleteProjet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteProjet.IconSize = 30;
            this.btnDeleteProjet.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteProjet.Location = new System.Drawing.Point(780, 44);
            this.btnDeleteProjet.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteProjet.Name = "btnDeleteProjet";
            this.btnDeleteProjet.Rotation = 45D;
            this.btnDeleteProjet.Size = new System.Drawing.Size(149, 44);
            this.btnDeleteProjet.TabIndex = 2;
            this.btnDeleteProjet.Text = "Supprimer projet";
            this.btnDeleteProjet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProjet.UseVisualStyleBackColor = false;
            this.btnDeleteProjet.Click += new System.EventHandler(this.btnDeleteProjet_Click);
            // 
            // btnEditProjet
            // 
            this.btnEditProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnEditProjet.FlatAppearance.BorderSize = 0;
            this.btnEditProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProjet.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnEditProjet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProjet.ForeColor = System.Drawing.Color.White;
            this.btnEditProjet.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditProjet.IconColor = System.Drawing.Color.White;
            this.btnEditProjet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditProjet.IconSize = 30;
            this.btnEditProjet.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditProjet.Location = new System.Drawing.Point(201, 44);
            this.btnEditProjet.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditProjet.Name = "btnEditProjet";
            this.btnEditProjet.Size = new System.Drawing.Size(149, 44);
            this.btnEditProjet.TabIndex = 1;
            this.btnEditProjet.Text = "Modifier projet";
            this.btnEditProjet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditProjet.UseVisualStyleBackColor = false;
            this.btnEditProjet.Click += new System.EventHandler(this.btnEditProjet_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.projetDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 514);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(649, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 514);
            this.panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxEmploye);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(0, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 177);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employe";
            // 
            // listBoxEmploye
            // 
            this.listBoxEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.listBoxEmploye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxEmploye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEmploye.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxEmploye.FormattingEnabled = true;
            this.listBoxEmploye.ItemHeight = 16;
            this.listBoxEmploye.Location = new System.Drawing.Point(3, 18);
            this.listBoxEmploye.Name = "listBoxEmploye";
            this.listBoxEmploye.Size = new System.Drawing.Size(293, 156);
            this.listBoxEmploye.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxCompetence);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compétences attendues";
            // 
            // listBoxCompetence
            // 
            this.listBoxCompetence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.listBoxCompetence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxCompetence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCompetence.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxCompetence.FormattingEnabled = true;
            this.listBoxCompetence.ItemHeight = 16;
            this.listBoxCompetence.Location = new System.Drawing.Point(3, 18);
            this.listBoxCompetence.Name = "listBoxCompetence";
            this.listBoxCompetence.Size = new System.Drawing.Size(293, 177);
            this.listBoxCompetence.TabIndex = 0;
            // 
            // projetDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Olive;
            this.projetDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.projetDataGridView.AutoGenerateColumns = false;
            this.projetDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projetDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.projetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.projetDataGridView.DataSource = this.projetBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projetDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.projetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projetDataGridView.EnableHeadersVisualStyles = false;
            this.projetDataGridView.Location = new System.Drawing.Point(0, 0);
            this.projetDataGridView.Name = "projetDataGridView";
            this.projetDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projetDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Olive;
            this.projetDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.projetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projetDataGridView.Size = new System.Drawing.Size(948, 514);
            this.projetDataGridView.TabIndex = 0;
            this.projetDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projetDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "libelle";
            this.dataGridViewTextBoxColumn2.HeaderText = "libelle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dateDebut";
            this.dataGridViewTextBoxColumn3.HeaderText = "dateDebut";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dateFin";
            this.dataGridViewTextBoxColumn4.HeaderText = "dateFin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataMember = "Projet";
            this.projetBindingSource.DataSource = this.gestionEmployeDataSet;
            // 
            // gestionEmployeDataSet
            // 
            this.gestionEmployeDataSet.DataSetName = "GestionEmployeDataSet";
            this.gestionEmployeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetTableAdapter
            // 
            this.projetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetenceTableAdapter = null;
            this.tableAdapterManager.EmployeCompetenceTableAdapter = null;
            this.tableAdapterManager.EmployeTableAdapter = null;
            this.tableAdapterManager.ProjetCompetenceTableAdapter = null;
            this.tableAdapterManager.ProjetTableAdapter = this.projetTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestionEmploye.GestionEmployeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(948, 614);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormProjet";
            this.Text = "FormProjet";
            this.Load += new System.EventHandler(this.FormProjet_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmployeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnNewProjet;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnDeleteProjet;
        private FontAwesome.Sharp.IconButton btnEditProjet;
        private System.Windows.Forms.Panel panel2;
        private GestionEmployeDataSet gestionEmployeDataSet;
        private System.Windows.Forms.BindingSource projetBindingSource;
        private GestionEmployeDataSetTableAdapters.ProjetTableAdapter projetTableAdapter;
        private GestionEmployeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView projetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private FontAwesome.Sharp.IconButton btnRefreshProjet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxEmploye;
        private System.Windows.Forms.ListBox listBoxCompetence;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}