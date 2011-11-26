namespace cjgl
{
    partial class Frmmmxg
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.txtOpwd = new System.Windows.Forms.TextBox();
            this.txtNpwd = new System.Windows.Forms.TextBox();
            this.txtQNpwd = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "原密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "确认密码";
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(101, 28);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(100, 21);
            this.txtUserid.TabIndex = 4;
            // 
            // txtOpwd
            // 
            this.txtOpwd.Location = new System.Drawing.Point(101, 61);
            this.txtOpwd.Name = "txtOpwd";
            this.txtOpwd.Size = new System.Drawing.Size(100, 21);
            this.txtOpwd.TabIndex = 5;
            // 
            // txtNpwd
            // 
            this.txtNpwd.Location = new System.Drawing.Point(101, 94);
            this.txtNpwd.Name = "txtNpwd";
            this.txtNpwd.Size = new System.Drawing.Size(100, 21);
            this.txtNpwd.TabIndex = 6;
            // 
            // txtQNpwd
            // 
            this.txtQNpwd.Location = new System.Drawing.Point(101, 127);
            this.txtQNpwd.Name = "txtQNpwd";
            this.txtQNpwd.Size = new System.Drawing.Size(100, 21);
            this.txtQNpwd.TabIndex = 7;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(24, 171);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 8;
            this.btnMod.Text = "修改";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(119, 171);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 9;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // Frmmmxg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 215);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.txtQNpwd);
            this.Controls.Add(this.txtNpwd);
            this.Controls.Add(this.txtOpwd);
            this.Controls.Add(this.txtUserid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frmmmxg";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.Frmmmxg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.TextBox txtOpwd;
        private System.Windows.Forms.TextBox txtNpwd;
        private System.Windows.Forms.TextBox txtQNpwd;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnCancle;
    }
}