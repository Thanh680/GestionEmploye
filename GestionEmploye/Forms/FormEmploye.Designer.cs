namespace GestionEmploye
{
    partial class FormEmploye
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnDeleteEmploye = new FontAwesome.Sharp.IconButton();
            this.btnEditEmploye = new FontAwesome.Sharp.IconButton();
            this.btnNewEmploye = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.employeDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEmployeDataSet = new GestionEmploye.GestionEmployeDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxCompetence = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxProjet = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxCompetence = new System.Windows.Forms.ListBox();
            this.employeTableAdapter = new GestionEmploye.GestionEmployeDataSetTableAdapters.EmployeTableAdapter();
            this.tableAdapterManager = new GestionEmploye.GestionEmployeDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmployeDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDeleteEmploye);
            this.panel1.Controls.Add(this.btnEditEmploye);
            this.panel1.Controls.Add(this.btnNewEmploye);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 100);
            this.panel1.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnRefresh.IconColor = System.Drawing.Color.White;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 30;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRefresh.Location = new System.Drawing.Point(644, 44);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 44);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Rafraichir";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteEmploye
            // 
            this.btnDeleteEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnDeleteEmploye.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmploye.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnDeleteEmploye.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmploye.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmploye.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnDeleteEmploye.IconColor = System.Drawing.Color.White;
            this.btnDeleteEmploye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteEmploye.IconSize = 30;
            this.btnDeleteEmploye.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteEmploye.Location = new System.Drawing.Point(764, 44);
            this.btnDeleteEmploye.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteEmploye.Name = "btnDeleteEmploye";
            this.btnDeleteEmploye.Rotation = 45D;
            this.btnDeleteEmploye.Size = new System.Drawing.Size(167, 44);
            this.btnDeleteEmploye.TabIndex = 2;
            this.btnDeleteEmploye.Text = "Supprimer employe";
            this.btnDeleteEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteEmploye.UseVisualStyleBackColor = false;
            this.btnDeleteEmploye.Click += new System.EventHandler(this.btnDeleteEmploye_Click);
            // 
            // btnEditEmploye
            // 
            this.btnEditEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnEditEmploye.FlatAppearance.BorderSize = 0;
            this.btnEditEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmploye.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnEditEmploye.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEditEmploye.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditEmploye.IconColor = System.Drawing.Color.White;
            this.btnEditEmploye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditEmploye.IconSize = 30;
            this.btnEditEmploye.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditEmploye.Location = new System.Drawing.Point(201, 44);
            this.btnEditEmploye.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditEmploye.Name = "btnEditEmploye";
            this.btnEditEmploye.Size = new System.Drawing.Size(149, 44);
            this.btnEditEmploye.TabIndex = 1;
            this.btnEditEmploye.Text = "Modifier employe";
            this.btnEditEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditEmploye.UseVisualStyleBackColor = false;
            this.btnEditEmploye.Click += new System.EventHandler(this.btnEditEmploye_Click);
            // 
            // btnNewEmploye
            // 
            this.btnNewEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnNewEmploye.FlatAppearance.BorderSize = 0;
            this.btnNewEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEmploye.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnNewEmploye.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmploye.ForeColor = System.Drawing.Color.White;
            this.btnNewEmploye.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNewEmploye.IconColor = System.Drawing.Color.White;
            this.btnNewEmploye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewEmploye.IconSize = 30;
            this.btnNewEmploye.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewEmploye.Location = new System.Drawing.Point(23, 44);
            this.btnNewEmploye.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewEmploye.Name = "btnNewEmploye";
            this.btnNewEmploye.Size = new System.Drawing.Size(149, 44);
            this.btnNewEmploye.TabIndex = 0;
            this.btnNewEmploye.Text = "Ajouter employe";
            this.btnNewEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewEmploye.UseVisualStyleBackColor = false;
            this.btnNewEmploye.Click += new System.EventHandler(this.btnNewEmploye_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.panelDesktop.Controls.Add(this.groupBox4);
            this.panelDesktop.Controls.Add(this.groupBox3);
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(950, 489);
            this.panelDesktop.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.employeDataGridView);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(617, 426);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // employeDataGridView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.employeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.employeDataGridView.AutoGenerateColumns = false;
            this.employeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.employeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn});
            this.employeDataGridView.DataSource = this.employeBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.employeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeDataGridView.EnableHeadersVisualStyles = false;
            this.employeDataGridView.GridColor = System.Drawing.Color.Gray;
            this.employeDataGridView.Location = new System.Drawing.Point(3, 16);
            this.employeDataGridView.Name = "employeDataGridView";
            this.employeDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Olive;
            this.employeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.employeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeDataGridView.Size = new System.Drawing.Size(611, 407);
            this.employeDataGridView.TabIndex = 0;
            this.employeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeDataGridView_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeBindingSource
            // 
            this.employeBindingSource.DataMember = "Employe";
            this.employeBindingSource.DataSource = this.gestionEmployeDataSet;
            // 
            // gestionEmployeDataSet
            // 
            this.gestionEmployeDataSet.DataSetName = "GestionEmployeDataSet";
            this.gestionEmployeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBoxCompetence);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 134);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rechercher par compétence";
            // 
            // checkedListBoxCompetence
            // 
            this.checkedListBoxCompetence.CheckOnClick = true;
            this.checkedListBoxCompetence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxCompetence.FormattingEnabled = true;
            this.checkedListBoxCompetence.Location = new System.Drawing.Point(3, 18);
            this.checkedListBoxCompetence.Name = "checkedListBoxCompetence";
            this.checkedListBoxCompetence.Size = new System.Drawing.Size(611, 113);
            this.checkedListBoxCompetence.TabIndex = 0;
            this.checkedListBoxCompetence.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxCompetence_ItemCheck);
            this.checkedListBoxCompetence.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxCompetence_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(617, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 489);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxProjet);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(0, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 177);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projet";
            // 
            // listBoxProjet
            // 
            this.listBoxProjet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProjet.FormattingEnabled = true;
            this.listBoxProjet.ItemHeight = 16;
            this.listBoxProjet.Location = new System.Drawing.Point(3, 18);
            this.listBoxProjet.Name = "listBoxProjet";
            this.listBoxProjet.Size = new System.Drawing.Size(327, 156);
            this.listBoxProjet.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxCompetence);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compétences";
            // 
            // listBoxCompetence
            // 
            this.listBoxCompetence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCompetence.FormattingEnabled = true;
            this.listBoxCompetence.ItemHeight = 16;
            this.listBoxCompetence.Location = new System.Drawing.Point(3, 18);
            this.listBoxCompetence.Name = "listBoxCompetence";
            this.listBoxCompetence.Size = new System.Drawing.Size(327, 160);
            this.listBoxCompetence.TabIndex = 1;
            // 
            // employeTableAdapter
            // 
            this.employeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetenceTableAdapter = null;
            this.tableAdapterManager.EmployeCompetenceTableAdapter = null;
            this.tableAdapterManager.EmployeTableAdapter = this.employeTableAdapter;
            this.tableAdapterManager.ProjetCompetenceTableAdapter = null;
            this.tableAdapterManager.ProjetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionEmploye.GestionEmployeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 589);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmploye";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEmploye_Load);
            this.panel1.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmployeDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnDeleteEmploye;
        private FontAwesome.Sharp.IconButton btnEditEmploye;
        private FontAwesome.Sharp.IconButton btnNewEmploye;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.DataGridView employeDataGridView;
        private GestionEmployeDataSet gestionEmployeDataSet;
        private System.Windows.Forms.BindingSource employeBindingSource;
        private GestionEmployeDataSetTableAdapters.EmployeTableAdapter employeTableAdapter;
        private GestionEmployeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxCompetence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxProjet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkedListBoxCompetence;
    }
}