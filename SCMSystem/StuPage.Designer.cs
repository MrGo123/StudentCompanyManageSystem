namespace SCMSystem
{
    partial class StuPage
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
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年龄DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学院DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.毕业生BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCompanyDBDataSet1 = new SCMSystem.StudentCompanyDBDataSet1();
            this.毕业生TableAdapter = new SCMSystem.StudentCompanyDBDataSet1TableAdapters.毕业生TableAdapter();
            this.StuNumLable = new System.Windows.Forms.Label();
            this.StuNameLable = new System.Windows.Forms.Label();
            this.GetBoxStuNum = new System.Windows.Forms.TextBox();
            this.GetBoxStuName = new System.Windows.Forms.TextBox();
            this.StuSearchBT = new System.Windows.Forms.Button();
            this.StuExit = new System.Windows.Forms.Button();
            this.StuUpdateBT = new System.Windows.Forms.Button();
            this.StuDeleBT = new System.Windows.Forms.Button();
            this.StuAddBT = new System.Windows.Forms.Button();
            this.StuLable = new System.Windows.Forms.Label();
            this.StuID = new System.Windows.Forms.Label();
            this.GetBoxStuID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.毕业生BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanyDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号DataGridViewTextBoxColumn,
            this.身份证号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.年龄DataGridViewTextBoxColumn,
            this.联系方式DataGridViewTextBoxColumn,
            this.学院DataGridViewTextBoxColumn,
            this.专业DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.毕业生BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1260, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
            this.学号DataGridViewTextBoxColumn.Width = 125;
            // 
            // 身份证号DataGridViewTextBoxColumn
            // 
            this.身份证号DataGridViewTextBoxColumn.DataPropertyName = "身份证号";
            this.身份证号DataGridViewTextBoxColumn.HeaderText = "身份证号";
            this.身份证号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.身份证号DataGridViewTextBoxColumn.Name = "身份证号DataGridViewTextBoxColumn";
            this.身份证号DataGridViewTextBoxColumn.Width = 125;
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            this.姓名DataGridViewTextBoxColumn.Width = 125;
            // 
            // 年龄DataGridViewTextBoxColumn
            // 
            this.年龄DataGridViewTextBoxColumn.DataPropertyName = "年龄";
            this.年龄DataGridViewTextBoxColumn.HeaderText = "年龄";
            this.年龄DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.年龄DataGridViewTextBoxColumn.Name = "年龄DataGridViewTextBoxColumn";
            this.年龄DataGridViewTextBoxColumn.Width = 125;
            // 
            // 联系方式DataGridViewTextBoxColumn
            // 
            this.联系方式DataGridViewTextBoxColumn.DataPropertyName = "联系方式";
            this.联系方式DataGridViewTextBoxColumn.HeaderText = "联系方式";
            this.联系方式DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.联系方式DataGridViewTextBoxColumn.Name = "联系方式DataGridViewTextBoxColumn";
            this.联系方式DataGridViewTextBoxColumn.Width = 125;
            // 
            // 学院DataGridViewTextBoxColumn
            // 
            this.学院DataGridViewTextBoxColumn.DataPropertyName = "学院";
            this.学院DataGridViewTextBoxColumn.HeaderText = "学院";
            this.学院DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.学院DataGridViewTextBoxColumn.Name = "学院DataGridViewTextBoxColumn";
            this.学院DataGridViewTextBoxColumn.Width = 125;
            // 
            // 专业DataGridViewTextBoxColumn
            // 
            this.专业DataGridViewTextBoxColumn.DataPropertyName = "专业";
            this.专业DataGridViewTextBoxColumn.HeaderText = "专业";
            this.专业DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.专业DataGridViewTextBoxColumn.Name = "专业DataGridViewTextBoxColumn";
            this.专业DataGridViewTextBoxColumn.Width = 125;
            // 
            // 毕业生BindingSource
            // 
            this.毕业生BindingSource.DataMember = "毕业生";
            this.毕业生BindingSource.DataSource = this.studentCompanyDBDataSet1;
            // 
            // studentCompanyDBDataSet1
            // 
            this.studentCompanyDBDataSet1.DataSetName = "StudentCompanyDBDataSet1";
            this.studentCompanyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 毕业生TableAdapter
            // 
            this.毕业生TableAdapter.ClearBeforeFill = true;
            // 
            // StuNumLable
            // 
            this.StuNumLable.AutoSize = true;
            this.StuNumLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuNumLable.Location = new System.Drawing.Point(195, 84);
            this.StuNumLable.Name = "StuNumLable";
            this.StuNumLable.Size = new System.Drawing.Size(105, 24);
            this.StuNumLable.TabIndex = 1;
            this.StuNumLable.Text = "按学号查询";
            // 
            // StuNameLable
            // 
            this.StuNameLable.AutoSize = true;
            this.StuNameLable.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuNameLable.Location = new System.Drawing.Point(196, 184);
            this.StuNameLable.Name = "StuNameLable";
            this.StuNameLable.Size = new System.Drawing.Size(104, 19);
            this.StuNameLable.TabIndex = 2;
            this.StuNameLable.Text = "按姓名查询";
            // 
            // GetBoxStuNum
            // 
            this.GetBoxStuNum.Font = new System.Drawing.Font("宋体", 10F);
            this.GetBoxStuNum.Location = new System.Drawing.Point(306, 83);
            this.GetBoxStuNum.Name = "GetBoxStuNum";
            this.GetBoxStuNum.Size = new System.Drawing.Size(136, 27);
            this.GetBoxStuNum.TabIndex = 3;
            // 
            // GetBoxStuName
            // 
            this.GetBoxStuName.Font = new System.Drawing.Font("宋体", 10F);
            this.GetBoxStuName.Location = new System.Drawing.Point(306, 178);
            this.GetBoxStuName.Name = "GetBoxStuName";
            this.GetBoxStuName.Size = new System.Drawing.Size(136, 27);
            this.GetBoxStuName.TabIndex = 4;
            // 
            // StuSearchBT
            // 
            this.StuSearchBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuSearchBT.Location = new System.Drawing.Point(500, 126);
            this.StuSearchBT.Name = "StuSearchBT";
            this.StuSearchBT.Size = new System.Drawing.Size(84, 30);
            this.StuSearchBT.TabIndex = 5;
            this.StuSearchBT.Text = "查询";
            this.StuSearchBT.UseVisualStyleBackColor = true;
            this.StuSearchBT.Click += new System.EventHandler(this.StuSearchBT_Click);
            // 
            // StuExit
            // 
            this.StuExit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuExit.Location = new System.Drawing.Point(983, 174);
            this.StuExit.Name = "StuExit";
            this.StuExit.Size = new System.Drawing.Size(75, 28);
            this.StuExit.TabIndex = 6;
            this.StuExit.Text = "返回";
            this.StuExit.UseVisualStyleBackColor = true;
            this.StuExit.Click += new System.EventHandler(this.StuExit_Click);
            // 
            // StuUpdateBT
            // 
            this.StuUpdateBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuUpdateBT.Location = new System.Drawing.Point(983, 78);
            this.StuUpdateBT.Name = "StuUpdateBT";
            this.StuUpdateBT.Size = new System.Drawing.Size(75, 29);
            this.StuUpdateBT.TabIndex = 7;
            this.StuUpdateBT.Text = "修改";
            this.StuUpdateBT.UseVisualStyleBackColor = true;
            this.StuUpdateBT.Click += new System.EventHandler(this.StuUpdateBT_Click);
            // 
            // StuDeleBT
            // 
            this.StuDeleBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuDeleBT.Location = new System.Drawing.Point(870, 174);
            this.StuDeleBT.Name = "StuDeleBT";
            this.StuDeleBT.Size = new System.Drawing.Size(75, 28);
            this.StuDeleBT.TabIndex = 8;
            this.StuDeleBT.Text = "删除";
            this.StuDeleBT.UseVisualStyleBackColor = true;
            this.StuDeleBT.Click += new System.EventHandler(this.StuDeleBT_Click);
            // 
            // StuAddBT
            // 
            this.StuAddBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuAddBT.Location = new System.Drawing.Point(870, 78);
            this.StuAddBT.Name = "StuAddBT";
            this.StuAddBT.Size = new System.Drawing.Size(75, 29);
            this.StuAddBT.TabIndex = 9;
            this.StuAddBT.Text = "添加";
            this.StuAddBT.UseVisualStyleBackColor = true;
            this.StuAddBT.Click += new System.EventHandler(this.StuAddBT_Click);
            // 
            // StuLable
            // 
            this.StuLable.AutoSize = true;
            this.StuLable.Font = new System.Drawing.Font("宋体", 22F);
            this.StuLable.Location = new System.Drawing.Point(538, 21);
            this.StuLable.Name = "StuLable";
            this.StuLable.Size = new System.Drawing.Size(202, 37);
            this.StuLable.TabIndex = 10;
            this.StuLable.Text = "毕业生名单";
            // 
            // StuID
            // 
            this.StuID.AutoSize = true;
            this.StuID.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuID.Location = new System.Drawing.Point(158, 132);
            this.StuID.Name = "StuID";
            this.StuID.Size = new System.Drawing.Size(142, 19);
            this.StuID.TabIndex = 11;
            this.StuID.Text = "按身份证号查询";
            // 
            // GetBoxStuID
            // 
            this.GetBoxStuID.Font = new System.Drawing.Font("宋体", 10F);
            this.GetBoxStuID.Location = new System.Drawing.Point(306, 130);
            this.GetBoxStuID.Name = "GetBoxStuID";
            this.GetBoxStuID.Size = new System.Drawing.Size(136, 27);
            this.GetBoxStuID.TabIndex = 12;
            // 
            // StuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 561);
            this.Controls.Add(this.GetBoxStuID);
            this.Controls.Add(this.StuID);
            this.Controls.Add(this.StuLable);
            this.Controls.Add(this.StuAddBT);
            this.Controls.Add(this.StuDeleBT);
            this.Controls.Add(this.StuUpdateBT);
            this.Controls.Add(this.StuExit);
            this.Controls.Add(this.StuSearchBT);
            this.Controls.Add(this.GetBoxStuName);
            this.Controls.Add(this.GetBoxStuNum);
            this.Controls.Add(this.StuNameLable);
            this.Controls.Add(this.StuNumLable);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StuPage";
            this.Text = "StuPage";
            this.Load += new System.EventHandler(this.StuPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.毕业生BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanyDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentCompanyDBDataSet1 studentCompanyDBDataSet1;
        private System.Windows.Forms.BindingSource 毕业生BindingSource;
        private StudentCompanyDBDataSet1TableAdapters.毕业生TableAdapter 毕业生TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年龄DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学院DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label StuNumLable;
        private System.Windows.Forms.Label StuNameLable;
        private System.Windows.Forms.TextBox GetBoxStuNum;
        private System.Windows.Forms.TextBox GetBoxStuName;
        private System.Windows.Forms.Button StuSearchBT;
        private System.Windows.Forms.Button StuExit;
        private System.Windows.Forms.Button StuUpdateBT;
        private System.Windows.Forms.Button StuDeleBT;
        private System.Windows.Forms.Button StuAddBT;
        private System.Windows.Forms.Label StuLable;
        private System.Windows.Forms.Label StuID;
        private System.Windows.Forms.TextBox GetBoxStuID;
    }
}