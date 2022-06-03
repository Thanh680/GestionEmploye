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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnDeleteEmploye = new FontAwesome.Sharp.IconButton();
            this.btnEditEmploye = new FontAwesome.Sharp.IconButton();
            this.btnNewEmploye = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxCompetence = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEmployeDataSet = new GestionEmploye.GestionEmployeDataSet();
            this.employeTableAdapter = new GestionEmploye.GestionEmployeDataSetTableAdapters.EmployeTableAdapter();
            this.tableAdapterManager = new GestionEmploye.GestionEmployeDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmployeDataSet)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(915, 100);
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
            this.btnRefresh.Location = new System.Drawing.Point(609, 44);
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
            this.btnDeleteEmploye.Location = new System.Drawing.Point(729, 44);
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
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Controls.Add(this.employeDataGridView);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(915, 441);
            this.panelDesktop.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxCompetence);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(582, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 441);
            this.panel2.TabIndex = 1;
            // 
            // listBoxCompetence
            // 
            this.listBoxCompetence.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxCompetence.FormattingEnabled = true;
            this.listBoxCompetence.Location = new System.Drawing.Point(0, 13);
            this.listBoxCompetence.Name = "listBoxCompetence";
            this.listBoxCompetence.Size = new System.Drawing.Size(333, 212);
            this.listBoxCompetence.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compétence";
            // 
            // employeDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.employeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeDataGridView.AutoGenerateColumns = false;
            this.employeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn});
            this.employeDataGridView.DataSource = this.employeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.employeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeDataGridView.EnableHeadersVisualStyles = false;
            this.employeDataGridView.GridColor = System.Drawing.Color.Gray;
            this.employeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.employeDataGridView.Name = "employeDataGridView";
            this.employeDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Olive;
            this.employeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.employeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeDataGridView.Size = new System.Drawing.Size(915, 441);
            this.employeDataGridView.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(915, 541);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmploye";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEmploye_Load);
            this.panel1.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmployeDataSet)).EndInit();
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
        private System.Windows.Forms.Label label1;
    }
}