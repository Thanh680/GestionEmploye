namespace GestionEmploye
{
    partial class FormCompetence
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnDeleteCompetence = new FontAwesome.Sharp.IconButton();
            this.btnNewCompetence = new FontAwesome.Sharp.IconButton();
            this.gestionEmployeDataSet = new GestionEmploye.GestionEmployeDataSet();
            this.competenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competenceTableAdapter = new GestionEmploye.GestionEmployeDataSetTableAdapters.CompetenceTableAdapter();
            this.tableAdapterManager = new GestionEmploye.GestionEmployeDataSetTableAdapters.TableAdapterManager();
            this.competenceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxEmploye = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmployeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenceDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDeleteCompetence);
            this.panel1.Controls.Add(this.btnNewCompetence);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 111);
            this.panel1.TabIndex = 0;
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
            this.btnRefresh.Location = new System.Drawing.Point(534, 46);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 44);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Rafraichir";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteCompetence
            // 
            this.btnDeleteCompetence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCompetence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnDeleteCompetence.FlatAppearance.BorderSize = 0;
            this.btnDeleteCompetence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCompetence.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnDeleteCompetence.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCompetence.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCompetence.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnDeleteCompetence.IconColor = System.Drawing.Color.White;
            this.btnDeleteCompetence.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteCompetence.IconSize = 30;
            this.btnDeleteCompetence.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteCompetence.Location = new System.Drawing.Point(651, 46);
            this.btnDeleteCompetence.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteCompetence.Name = "btnDeleteCompetence";
            this.btnDeleteCompetence.Rotation = 45D;
            this.btnDeleteCompetence.Size = new System.Drawing.Size(198, 44);
            this.btnDeleteCompetence.TabIndex = 3;
            this.btnDeleteCompetence.Text = "Supprimer competence";
            this.btnDeleteCompetence.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCompetence.UseVisualStyleBackColor = false;
            this.btnDeleteCompetence.Click += new System.EventHandler(this.btnDeleteCompetence_Click);
            // 
            // btnNewCompetence
            // 
            this.btnNewCompetence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnNewCompetence.FlatAppearance.BorderSize = 0;
            this.btnNewCompetence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCompetence.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnNewCompetence.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCompetence.ForeColor = System.Drawing.Color.White;
            this.btnNewCompetence.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNewCompetence.IconColor = System.Drawing.Color.White;
            this.btnNewCompetence.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewCompetence.IconSize = 30;
            this.btnNewCompetence.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewCompetence.Location = new System.Drawing.Point(25, 46);
            this.btnNewCompetence.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewCompetence.Name = "btnNewCompetence";
            this.btnNewCompetence.Size = new System.Drawing.Size(192, 44);
            this.btnNewCompetence.TabIndex = 1;
            this.btnNewCompetence.Text = "Nouvelle Competence";
            this.btnNewCompetence.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewCompetence.UseVisualStyleBackColor = false;
            this.btnNewCompetence.Click += new System.EventHandler(this.btnNewCompetence_Click);
            // 
            // gestionEmployeDataSet
            // 
            this.gestionEmployeDataSet.DataSetName = "GestionEmployeDataSet";
            this.gestionEmployeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // competenceBindingSource
            // 
            this.competenceBindingSource.DataMember = "Competence";
            this.competenceBindingSource.DataSource = this.gestionEmployeDataSet;
            // 
            // competenceTableAdapter
            // 
            this.competenceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetenceTableAdapter = this.competenceTableAdapter;
            this.tableAdapterManager.EmployeCompetenceTableAdapter = null;
            this.tableAdapterManager.EmployeTableAdapter = null;
            this.tableAdapterManager.ProjetCompetenceTableAdapter = null;
            this.tableAdapterManager.ProjetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionEmploye.GestionEmployeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // competenceDataGridView
            // 
            this.competenceDataGridView.AutoGenerateColumns = false;
            this.competenceDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.competenceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.competenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competenceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.competenceDataGridView.DataSource = this.competenceBindingSource;
            this.competenceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.competenceDataGridView.EnableHeadersVisualStyles = false;
            this.competenceDataGridView.Location = new System.Drawing.Point(0, 111);
            this.competenceDataGridView.Name = "competenceDataGridView";
            this.competenceDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.competenceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive;
            this.competenceDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.competenceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.competenceDataGridView.Size = new System.Drawing.Size(872, 435);
            this.competenceDataGridView.TabIndex = 1;
            this.competenceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.competenceDataGridView_CellClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(624, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 435);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxEmploye);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employe";
            // 
            // listBoxEmploye
            // 
            this.listBoxEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.listBoxEmploye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEmploye.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxEmploye.FormattingEnabled = true;
            this.listBoxEmploye.ItemHeight = 16;
            this.listBoxEmploye.Location = new System.Drawing.Point(3, 18);
            this.listBoxEmploye.Name = "listBoxEmploye";
            this.listBoxEmploye.Size = new System.Drawing.Size(242, 414);
            this.listBoxEmploye.TabIndex = 0;
            // 
            // FormCompetence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(872, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.competenceDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FormCompetence";
            this.Text = "FormCompetence";
            this.Load += new System.EventHandler(this.FormCompetence_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmployeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenceDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnNewCompetence;
        private FontAwesome.Sharp.IconButton btnDeleteCompetence;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private GestionEmployeDataSet gestionEmployeDataSet;
        private System.Windows.Forms.BindingSource competenceBindingSource;
        private GestionEmployeDataSetTableAdapters.CompetenceTableAdapter competenceTableAdapter;
        private GestionEmployeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView competenceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxEmploye;
    }
}