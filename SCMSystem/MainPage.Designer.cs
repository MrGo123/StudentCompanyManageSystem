namespace SCMSystem
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.Stu = new System.Windows.Forms.Button();
            this.Company = new System.Windows.Forms.Button();
            this.Contract = new System.Windows.Forms.Button();
            this.ExitMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22F);
            this.label1.Location = new System.Drawing.Point(563, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理菜单";
            // 
            // Stu
            // 
            this.Stu.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stu.Location = new System.Drawing.Point(557, 156);
            this.Stu.Name = "Stu";
            this.Stu.Size = new System.Drawing.Size(171, 42);
            this.Stu.TabIndex = 1;
            this.Stu.Text = "毕业生名单";
            this.Stu.UseVisualStyleBackColor = true;
            this.Stu.Click += new System.EventHandler(this.Stu_Click);
            // 
            // Company
            // 
            this.Company.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Company.Location = new System.Drawing.Point(557, 233);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(171, 41);
            this.Company.TabIndex = 2;
            this.Company.Text = "公司名单";
            this.Company.UseVisualStyleBackColor = true;
            this.Company.Click += new System.EventHandler(this.Company_Click);
            // 
            // Contract
            // 
            this.Contract.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Contract.Location = new System.Drawing.Point(557, 312);
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(171, 37);
            this.Contract.TabIndex = 3;
            this.Contract.Text = "合同表单";
            this.Contract.UseVisualStyleBackColor = true;
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitMenu.Location = new System.Drawing.Point(557, 390);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(171, 37);
            this.ExitMenu.TabIndex = 4;
            this.ExitMenu.Text = "退出系统";
            this.ExitMenu.UseVisualStyleBackColor = true;
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 561);
            this.Controls.Add(this.ExitMenu);
            this.Controls.Add(this.Contract);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.Stu);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Stu;
        private System.Windows.Forms.Button Company;
        private System.Windows.Forms.Button Contract;
        private System.Windows.Forms.Button ExitMenu;
    }
}