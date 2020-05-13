namespace SCMSystem
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBT = new System.Windows.Forms.Button();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textUserPSW = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.Location = new System.Drawing.Point(611, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户登录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(469, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(469, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码";
            // 
            // LoginBT
            // 
            this.LoginBT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginBT.Location = new System.Drawing.Point(580, 450);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(80, 32);
            this.LoginBT.TabIndex = 6;
            this.LoginBT.Text = "登录";
            this.LoginBT.UseVisualStyleBackColor = true;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("宋体", 12F);
            this.textUserName.Location = new System.Drawing.Point(580, 274);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(232, 30);
            this.textUserName.TabIndex = 7;
            this.textUserName.TextChanged += new System.EventHandler(this.textUserName_TextChanged);
            // 
            // textUserPSW
            // 
            this.textUserPSW.Font = new System.Drawing.Font("宋体", 12F);
            this.textUserPSW.Location = new System.Drawing.Point(580, 351);
            this.textUserPSW.Name = "textUserPSW";
            this.textUserPSW.PasswordChar = '*';
            this.textUserPSW.Size = new System.Drawing.Size(232, 30);
            this.textUserPSW.TabIndex = 8;
            this.textUserPSW.TextChanged += new System.EventHandler(this.textUserPSW_TextChanged);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.Location = new System.Drawing.Point(732, 450);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 32);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 26F);
            this.label4.Location = new System.Drawing.Point(394, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(592, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "高校毕业生就业信息管理系统";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.textUserPSW);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginBT;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textUserPSW;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label4;
    }
}