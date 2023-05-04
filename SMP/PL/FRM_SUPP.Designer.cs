
namespace SMP.PL
{
    partial class FRM_SUPP
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
            this.pn_cat = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBCATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SMPDataSet = new SMP.DB_SMPDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tB_CATTableAdapter = new SMP.DB_SMPDataSetTableAdapters.TB_CATTableAdapter();
            this.dB_SMPDataSet1 = new SMP.DB_SMPDataSet1();
            this.tBsuppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_suppTableAdapter = new SMP.DB_SMPDataSet1TableAdapters.TB_suppTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBsuppBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.dataGridView1);
            this.pn_cat.Controls.Add(this.panel2);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(936, 617);
            this.pn_cat.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.suppnameDataGridViewTextBoxColumn,
            this.suppphoneDataGridViewTextBoxColumn,
            this.suppemailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBsuppBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(936, 520);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tBCATBindingSource
            // 
            this.tBCATBindingSource.DataMember = "TB_CAT";
            this.tBCATBindingSource.DataSource = this.dB_SMPDataSet;
            // 
            // dB_SMPDataSet
            // 
            this.dB_SMPDataSet.DataSetName = "DB_SMPDataSet";
            this.dB_SMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 97);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(465, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 49);
            this.button4.TabIndex = 6;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_delete.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(241, 25);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(179, 49);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_add.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(11, 25);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(182, 49);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tB_CATTableAdapter
            // 
            this.tB_CATTableAdapter.ClearBeforeFill = true;
            // 
            // dB_SMPDataSet1
            // 
            this.dB_SMPDataSet1.DataSetName = "DB_SMPDataSet1";
            this.dB_SMPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBsuppBindingSource
            // 
            this.tBsuppBindingSource.DataMember = "TB_supp";
            this.tBsuppBindingSource.DataSource = this.dB_SMPDataSet1;
            // 
            // tB_suppTableAdapter
            // 
            this.tB_suppTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // suppnameDataGridViewTextBoxColumn
            // 
            this.suppnameDataGridViewTextBoxColumn.DataPropertyName = "supp_name";
            this.suppnameDataGridViewTextBoxColumn.HeaderText = "supp_name";
            this.suppnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suppnameDataGridViewTextBoxColumn.Name = "suppnameDataGridViewTextBoxColumn";
            this.suppnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // suppphoneDataGridViewTextBoxColumn
            // 
            this.suppphoneDataGridViewTextBoxColumn.DataPropertyName = "supp_phone";
            this.suppphoneDataGridViewTextBoxColumn.HeaderText = "supp_phone";
            this.suppphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suppphoneDataGridViewTextBoxColumn.Name = "suppphoneDataGridViewTextBoxColumn";
            this.suppphoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // suppemailDataGridViewTextBoxColumn
            // 
            this.suppemailDataGridViewTextBoxColumn.DataPropertyName = "supp_email";
            this.suppemailDataGridViewTextBoxColumn.HeaderText = "supp_email";
            this.suppemailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suppemailDataGridViewTextBoxColumn.Name = "suppemailDataGridViewTextBoxColumn";
            this.suppemailDataGridViewTextBoxColumn.Width = 125;
            // 
            // FRM_SUPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 617);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SUPP";
            this.Text = "FRM_CAT";
            this.Load += new System.EventHandler(this.FRM_CAT_Load);
            this.pn_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBsuppBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Panel pn_cat;
        public System.Windows.Forms.DataGridView dataGridView1;
        private DB_SMPDataSet dB_SMPDataSet;
        private System.Windows.Forms.BindingSource tBCATBindingSource;
        private DB_SMPDataSetTableAdapters.TB_CATTableAdapter tB_CATTableAdapter;
        private System.Windows.Forms.Button button4;
        private DB_SMPDataSet1 dB_SMPDataSet1;
        private System.Windows.Forms.BindingSource tBsuppBindingSource;
        private DB_SMPDataSet1TableAdapters.TB_suppTableAdapter tB_suppTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppemailDataGridViewTextBoxColumn;
    }
}