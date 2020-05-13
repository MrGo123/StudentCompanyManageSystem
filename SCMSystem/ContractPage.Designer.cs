namespace SCMSystem
{
    partial class ContractPage
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
            this.合同编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.签订日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.毕业生学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用人单位编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.薪资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.签订协议BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCompanyDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCompanyDBDataSet1 = new SCMSystem.StudentCompanyDBDataSet1();
            this.签订协议TableAdapter = new SCMSystem.StudentCompanyDBDataSet1TableAdapters.签订协议TableAdapter();
            this.ConBoxConId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConExit = new System.Windows.Forms.Button();
            this.ConUpdateBT = new System.Windows.Forms.Button();
            this.ConDeleBT = new System.Windows.Forms.Button();
            this.ConAddBT = new System.Windows.Forms.Button();
            this.ConSearchBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.签订协议BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanyDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanyDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.合同编号DataGridViewTextBoxColumn,
            this.签订日期DataGridViewTextBoxColumn,
            this.毕业生学号DataGridViewTextBoxColumn,
            this.用人单位编号DataGridViewTextBoxColumn,
            this.薪资DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.签订协议BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(183, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(930, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // 合同编号DataGridViewTextBoxColumn
            // 
            this.合同编号DataGridViewTextBoxColumn.DataPropertyName = "合同编号";
            this.合同编号DataGridViewTextBoxColumn.HeaderText = "合同编号";
            this.合同编号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.合同编号DataGridViewTextBoxColumn.Name = "合同编号DataGridViewTextBoxColumn";
            this.合同编号DataGridViewTextBoxColumn.Width = 125;
            // 
            // 签订日期DataGridViewTextBoxColumn
            // 
            this.签订日期DataGridViewTextBoxColumn.DataPropertyName = "签订日期";
            this.签订日期DataGridViewTextBoxColumn.HeaderText = "签订日期";
            this.签订日期DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.签订日期DataGridViewTextBoxColumn.Name = "签订日期DataGridViewTextBoxColumn";
            this.签订日期DataGridViewTextBoxColumn.Width = 125;
            // 
            // 毕业生学号DataGridViewTextBoxColumn
            // 
            this.毕业生学号DataGridViewTextBoxColumn.DataPropertyName = "毕业生学号";
            this.毕业生学号DataGridViewTextBoxColumn.HeaderText = "毕业生学号";
            this.毕业生学号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.毕业生学号DataGridViewTextBoxColumn.Name = "毕业生学号DataGridViewTextBoxColumn";
            this.毕业生学号DataGridViewTextBoxColumn.Width = 125;
            // 
            // 用人单位编号DataGridViewTextBoxColumn
            // 
            this.用人单位编号DataGridViewTextBoxColumn.DataPropertyName = "用人单位编号";
            this.用人单位编号DataGridViewTextBoxColumn.HeaderText = "用人单位编号";
            this.用人单位编号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.用人单位编号DataGridViewTextBoxColumn.Name = "用人单位编号DataGridViewTextBoxColumn";
            this.用人单位编号DataGridViewTextBoxColumn.Width = 125;
            // 
            // 薪资DataGridViewTextBoxColumn
            // 
            this.薪资DataGridViewTextBoxColumn.DataPropertyName = "薪资";
            this.薪资DataGridViewTextBoxColumn.HeaderText = "薪资";
            this.薪资DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.薪资DataGridViewTextBoxColumn.Name = "薪资DataGridViewTextBoxColumn";
            this.薪资DataGridViewTextBoxColumn.Width = 125;
            // 
            // 签订协议BindingSource
            // 
            this.签订协议BindingSource.DataMember = "签订协议";
            this.签订协议BindingSource.DataSource = this.studentCompanyDBDataSet1BindingSource;
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
            // 签订协议TableAdapter
            // 
            this.签订协议TableAdapter.ClearBeforeFill = true;
            // 
            // ConBoxConId
            // 
            this.ConBoxConId.Font = new System.Drawing.Font("宋体", 10F);
            this.ConBoxConId.Location = new System.Drawing.Point(320, 125);
            this.ConBoxConId.Name = "ConBoxConId";
            this.ConBoxConId.Size = new System.Drawing.Size(126, 27);
            this.ConBoxConId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F);
            this.label1.Location = new System.Drawing.Point(229, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "合同编号";
            // 
            // ConExit
            // 
            this.ConExit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConExit.Location = new System.Drawing.Point(940, 157);
            this.ConExit.Name = "ConExit";
            this.ConExit.Size = new System.Drawing.Size(78, 30);
            this.ConExit.TabIndex = 6;
            this.ConExit.Text = "返回";
            this.ConExit.UseVisualStyleBackColor = true;
            this.ConExit.Click += new System.EventHandler(this.ConExit_Click);
            // 
            // ConUpdateBT
            // 
            this.ConUpdateBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConUpdateBT.Location = new System.Drawing.Point(940, 88);
            this.ConUpdateBT.Name = "ConUpdateBT";
            this.ConUpdateBT.Size = new System.Drawing.Size(78, 30);
            this.ConUpdateBT.TabIndex = 7;
            this.ConUpdateBT.Text = "修改";
            this.ConUpdateBT.UseVisualStyleBackColor = true;
            this.ConUpdateBT.Click += new System.EventHandler(this.ConUpdateBT_Click);
            // 
            // ConDeleBT
            // 
            this.ConDeleBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConDeleBT.Location = new System.Drawing.Point(774, 157);
            this.ConDeleBT.Name = "ConDeleBT";
            this.ConDeleBT.Size = new System.Drawing.Size(78, 30);
            this.ConDeleBT.TabIndex = 8;
            this.ConDeleBT.Text = "删除";
            this.ConDeleBT.UseVisualStyleBackColor = true;
            this.ConDeleBT.Click += new System.EventHandler(this.ConDeleBT_Click);
            // 
            // ConAddBT
            // 
            this.ConAddBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConAddBT.Location = new System.Drawing.Point(774, 88);
            this.ConAddBT.Name = "ConAddBT";
            this.ConAddBT.Size = new System.Drawing.Size(78, 30);
            this.ConAddBT.TabIndex = 9;
            this.ConAddBT.Text = "添加";
            this.ConAddBT.UseVisualStyleBackColor = true;
            this.ConAddBT.Click += new System.EventHandler(this.ConAddBT_Click);
            // 
            // ConSearchBT
            // 
            this.ConSearchBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConSearchBT.Location = new System.Drawing.Point(484, 125);
            this.ConSearchBT.Name = "ConSearchBT";
            this.ConSearchBT.Size = new System.Drawing.Size(77, 27);
            this.ConSearchBT.TabIndex = 10;
            this.ConSearchBT.Text = "查询";
            this.ConSearchBT.UseVisualStyleBackColor = true;
            this.ConSearchBT.Click += new System.EventHandler(this.ConSearchBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 22F);
            this.label3.Location = new System.Drawing.Point(547, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "合同表单";
            // 
            // ContractPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1348, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConSearchBT);
            this.Controls.Add(this.ConAddBT);
            this.Controls.Add(this.ConDeleBT);
            this.Controls.Add(this.ConUpdateBT);
            this.Controls.Add(this.ConExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConBoxConId);
            this.Controls.Add(this.dataGridView1);
            this.HelpButton = true;
            this.Name = "ContractPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ContractPage";
            this.Load += new System.EventHandler(this.ContractPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.签订协议BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanyDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanyDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentCompanyDBDataSet1BindingSource;
        private StudentCompanyDBDataSet1 studentCompanyDBDataSet1;
        private System.Windows.Forms.BindingSource 签订协议BindingSource;
        private StudentCompanyDBDataSet1TableAdapters.签订协议TableAdapter 签订协议TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合同编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 签订日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 毕业生学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用人单位编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 薪资DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox ConBoxConId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConExit;
        private System.Windows.Forms.Button ConUpdateBT;
        private System.Windows.Forms.Button ConDeleBT;
        private System.Windows.Forms.Button ConAddBT;
        private System.Windows.Forms.Button ConSearchBT;
        private System.Windows.Forms.Label label3;
    }
}