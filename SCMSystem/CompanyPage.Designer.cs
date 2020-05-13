namespace SCMSystem
{
    partial class CompanyPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.公司编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCompanyDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCompanyDBDataSet1 = new SCMSystem.StudentCompanyDBDataSet1();
            this.公司TableAdapter = new SCMSystem.StudentCompanyDBDataSet1TableAdapters.公司TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ComBoxId = new System.Windows.Forms.TextBox();
            this.ComBoxName = new System.Windows.Forms.TextBox();
            this.ComSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ComDeleteBT = new System.Windows.Forms.Button();
            this.AddComBT = new System.Windows.Forms.Button();
            this.ComCancleBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanyDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanyDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.公司编号DataGridViewTextBoxColumn,
            this.公司名称DataGridViewTextBoxColumn,
            this.公司地址DataGridViewTextBoxColumn,
            this.联系电话DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.公司BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(274, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(764, 326);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // 公司编号DataGridViewTextBoxColumn
            // 
            this.公司编号DataGridViewTextBoxColumn.DataPropertyName = "公司编号";
            this.公司编号DataGridViewTextBoxColumn.HeaderText = "公司编号";
            this.公司编号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.公司编号DataGridViewTextBoxColumn.Name = "公司编号DataGridViewTextBoxColumn";
            this.公司编号DataGridViewTextBoxColumn.Width = 125;
            // 
            // 公司名称DataGridViewTextBoxColumn
            // 
            this.公司名称DataGridViewTextBoxColumn.DataPropertyName = "公司名称";
            this.公司名称DataGridViewTextBoxColumn.HeaderText = "公司名称";
            this.公司名称DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.公司名称DataGridViewTextBoxColumn.Name = "公司名称DataGridViewTextBoxColumn";
            this.公司名称DataGridViewTextBoxColumn.Width = 125;
            // 
            // 公司地址DataGridViewTextBoxColumn
            // 
            this.公司地址DataGridViewTextBoxColumn.DataPropertyName = "公司地址";
            this.公司地址DataGridViewTextBoxColumn.HeaderText = "公司地址";
            this.公司地址DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.公司地址DataGridViewTextBoxColumn.Name = "公司地址DataGridViewTextBoxColumn";
            this.公司地址DataGridViewTextBoxColumn.Width = 125;
            // 
            // 联系电话DataGridViewTextBoxColumn
            // 
            this.联系电话DataGridViewTextBoxColumn.DataPropertyName = "联系电话";
            this.联系电话DataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.联系电话DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.联系电话DataGridViewTextBoxColumn.Name = "联系电话DataGridViewTextBoxColumn";
            this.联系电话DataGridViewTextBoxColumn.Width = 125;
            // 
            // 公司BindingSource
            // 
            this.公司BindingSource.DataMember = "公司";
            this.公司BindingSource.DataSource = this.studentCompanyDBDataSet1BindingSource;
            // 
            // studentCompanyDBDataSet1BindingSource
            // 
            this.studentCompanyDBDataSet1BindingSource.DataSource = this.studentCompanyDBDataSet1;
            this.studentCompanyDBDataSet1BindingSource.Position = 0;
            // 
            // studentCompanyDBDataSet1
            // 
            this.studentCompanyDBDataSet1.DataSetName = "StudentCompanyDBDataSet1";
            this.studentCompanyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 公司TableAdapter
            // 
            this.公司TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22F);
            this.label1.Location = new System.Drawing.Point(576, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "公司名单";
            // 
            // ComBoxId
            // 
            this.ComBoxId.Font = new System.Drawing.Font("宋体", 10F);
            this.ComBoxId.Location = new System.Drawing.Point(361, 85);
            this.ComBoxId.Name = "ComBoxId";
            this.ComBoxId.Size = new System.Drawing.Size(131, 27);
            this.ComBoxId.TabIndex = 3;
            // 
            // ComBoxName
            // 
            this.ComBoxName.Font = new System.Drawing.Font("宋体", 10F);
            this.ComBoxName.Location = new System.Drawing.Point(361, 141);
            this.ComBoxName.Name = "ComBoxName";
            this.ComBoxName.Size = new System.Drawing.Size(131, 27);
            this.ComBoxName.TabIndex = 4;
            // 
            // ComSearch
            // 
            this.ComSearch.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComSearch.Location = new System.Drawing.Point(531, 116);
            this.ComSearch.Name = "ComSearch";
            this.ComSearch.Size = new System.Drawing.Size(75, 30);
            this.ComSearch.TabIndex = 5;
            this.ComSearch.Text = "查询";
            this.ComSearch.UseVisualStyleBackColor = true;
            this.ComSearch.Click += new System.EventHandler(this.ComSearch_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(976, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ComDeleteBT
            // 
            this.ComDeleteBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComDeleteBT.Location = new System.Drawing.Point(812, 136);
            this.ComDeleteBT.Name = "ComDeleteBT";
            this.ComDeleteBT.Size = new System.Drawing.Size(77, 33);
            this.ComDeleteBT.TabIndex = 7;
            this.ComDeleteBT.Text = "删除";
            this.ComDeleteBT.UseVisualStyleBackColor = true;
            this.ComDeleteBT.Click += new System.EventHandler(this.ComDeleteBT_Click);
            // 
            // AddComBT
            // 
            this.AddComBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddComBT.Location = new System.Drawing.Point(812, 73);
            this.AddComBT.Name = "AddComBT";
            this.AddComBT.Size = new System.Drawing.Size(77, 33);
            this.AddComBT.TabIndex = 8;
            this.AddComBT.Text = "添加";
            this.AddComBT.UseVisualStyleBackColor = true;
            this.AddComBT.Click += new System.EventHandler(this.AddComBT_Click);
            // 
            // ComCancleBT
            // 
            this.ComCancleBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComCancleBT.Location = new System.Drawing.Point(976, 136);
            this.ComCancleBT.Name = "ComCancleBT";
            this.ComCancleBT.Size = new System.Drawing.Size(77, 33);
            this.ComCancleBT.TabIndex = 9;
            this.ComCancleBT.Text = "返回";
            this.ComCancleBT.UseVisualStyleBackColor = true;
            this.ComCancleBT.Click += new System.EventHandler(this.ComCancleBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F);
            this.label2.Location = new System.Drawing.Point(251, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "按公司编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F);
            this.label3.Location = new System.Drawing.Point(251, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "按公司名称";
            // 
            // CompanyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComCancleBT);
            this.Controls.Add(this.AddComBT);
            this.Controls.Add(this.ComDeleteBT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ComSearch);
            this.Controls.Add(this.ComBoxName);
            this.Controls.Add(this.ComBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CompanyPage";
            this.Text = "CompanyPage";
            this.Load += new System.EventHandler(this.CompanyPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanyDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanyDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentCompanyDBDataSet1BindingSource;
        private StudentCompanyDBDataSet1 studentCompanyDBDataSet1;
        private System.Windows.Forms.BindingSource 公司BindingSource;
        private StudentCompanyDBDataSet1TableAdapters.公司TableAdapter 公司TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ComBoxId;
        private System.Windows.Forms.TextBox ComBoxName;
        private System.Windows.Forms.Button ComSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ComDeleteBT;
        private System.Windows.Forms.Button AddComBT;
        private System.Windows.Forms.Button ComCancleBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}