
namespace WindowsFormsApp1
{
    partial class LoginForm01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm01));
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.labelAcc = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.linkLabelChangePas = new System.Windows.Forms.LinkLabel();
            this.panelChangePas = new System.Windows.Forms.Panel();
            this.labelChangeAccount = new System.Windows.Forms.Label();
            this.BtnBackToLog = new System.Windows.Forms.Button();
            this.BtnChangeConfirm = new System.Windows.Forms.Button();
            this.textBoxChangeAccount = new System.Windows.Forms.TextBox();
            this.textBoxNewPas = new System.Windows.Forms.TextBox();
            this.textBoxOldPas = new System.Windows.Forms.TextBox();
            this.labelNewPas = new System.Windows.Forms.Label();
            this.labelOldPas = new System.Windows.Forms.Label();
            this.panelChangePas.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(308, 85);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(193, 25);
            this.textBoxAccount.TabIndex = 0;
            this.textBoxAccount.Text = "2020";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(308, 146);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(193, 25);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "bupt";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(367, 200);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 31);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Location = new System.Drawing.Point(242, 95);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(37, 15);
            this.labelAcc.TabIndex = 3;
            this.labelAcc.Text = "账号";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(242, 156);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(37, 15);
            this.labelPas.TabIndex = 4;
            this.labelPas.Text = "密码";
            // 
            // linkLabelChangePas
            // 
            this.linkLabelChangePas.AutoSize = true;
            this.linkLabelChangePas.Location = new System.Drawing.Point(375, 244);
            this.linkLabelChangePas.Name = "linkLabelChangePas";
            this.linkLabelChangePas.Size = new System.Drawing.Size(67, 15);
            this.linkLabelChangePas.TabIndex = 5;
            this.linkLabelChangePas.TabStop = true;
            this.linkLabelChangePas.Text = "修改密码";
            this.linkLabelChangePas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangePas_LinkClicked);
            // 
            // panelChangePas
            // 
            this.panelChangePas.Controls.Add(this.labelChangeAccount);
            this.panelChangePas.Controls.Add(this.BtnBackToLog);
            this.panelChangePas.Controls.Add(this.BtnChangeConfirm);
            this.panelChangePas.Controls.Add(this.textBoxChangeAccount);
            this.panelChangePas.Controls.Add(this.textBoxNewPas);
            this.panelChangePas.Controls.Add(this.textBoxOldPas);
            this.panelChangePas.Controls.Add(this.labelNewPas);
            this.panelChangePas.Controls.Add(this.labelOldPas);
            this.panelChangePas.Location = new System.Drawing.Point(245, 85);
            this.panelChangePas.Name = "panelChangePas";
            this.panelChangePas.Size = new System.Drawing.Size(316, 178);
            this.panelChangePas.TabIndex = 6;
            this.panelChangePas.Visible = false;
            // 
            // labelChangeAccount
            // 
            this.labelChangeAccount.AutoSize = true;
            this.labelChangeAccount.Location = new System.Drawing.Point(17, 20);
            this.labelChangeAccount.Name = "labelChangeAccount";
            this.labelChangeAccount.Size = new System.Drawing.Size(37, 15);
            this.labelChangeAccount.TabIndex = 6;
            this.labelChangeAccount.Text = "账号";
            // 
            // BtnBackToLog
            // 
            this.BtnBackToLog.Location = new System.Drawing.Point(213, 144);
            this.BtnBackToLog.Name = "BtnBackToLog";
            this.BtnBackToLog.Size = new System.Drawing.Size(75, 23);
            this.BtnBackToLog.TabIndex = 5;
            this.BtnBackToLog.Text = "返回登录";
            this.BtnBackToLog.UseVisualStyleBackColor = true;
            this.BtnBackToLog.Click += new System.EventHandler(this.BtnBackToLog_Click);
            // 
            // BtnChangeConfirm
            // 
            this.BtnChangeConfirm.Location = new System.Drawing.Point(75, 144);
            this.BtnChangeConfirm.Name = "BtnChangeConfirm";
            this.BtnChangeConfirm.Size = new System.Drawing.Size(86, 23);
            this.BtnChangeConfirm.TabIndex = 4;
            this.BtnChangeConfirm.Text = "确认修改";
            this.BtnChangeConfirm.UseVisualStyleBackColor = true;
            this.BtnChangeConfirm.Click += new System.EventHandler(this.BtnChangeConfirm_Click);
            // 
            // textBoxChangeAccount
            // 
            this.textBoxChangeAccount.Location = new System.Drawing.Point(86, 17);
            this.textBoxChangeAccount.Name = "textBoxChangeAccount";
            this.textBoxChangeAccount.Size = new System.Drawing.Size(188, 25);
            this.textBoxChangeAccount.TabIndex = 3;
            // 
            // textBoxNewPas
            // 
            this.textBoxNewPas.Location = new System.Drawing.Point(86, 92);
            this.textBoxNewPas.Name = "textBoxNewPas";
            this.textBoxNewPas.Size = new System.Drawing.Size(188, 25);
            this.textBoxNewPas.TabIndex = 3;
            // 
            // textBoxOldPas
            // 
            this.textBoxOldPas.Location = new System.Drawing.Point(86, 57);
            this.textBoxOldPas.Name = "textBoxOldPas";
            this.textBoxOldPas.Size = new System.Drawing.Size(188, 25);
            this.textBoxOldPas.TabIndex = 2;
            // 
            // labelNewPas
            // 
            this.labelNewPas.AutoSize = true;
            this.labelNewPas.Location = new System.Drawing.Point(14, 96);
            this.labelNewPas.Name = "labelNewPas";
            this.labelNewPas.Size = new System.Drawing.Size(52, 15);
            this.labelNewPas.TabIndex = 1;
            this.labelNewPas.Text = "新密码";
            // 
            // labelOldPas
            // 
            this.labelOldPas.AutoSize = true;
            this.labelOldPas.Location = new System.Drawing.Point(14, 60);
            this.labelOldPas.Name = "labelOldPas";
            this.labelOldPas.Size = new System.Drawing.Size(52, 15);
            this.labelOldPas.TabIndex = 0;
            this.labelOldPas.Text = "旧密码";
            // 
            // LoginForm01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChangePas);
            this.Controls.Add(this.linkLabelChangePas);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.labelAcc);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm01";
            this.Text = "登录";
            this.panelChangePas.ResumeLayout(false);
            this.panelChangePas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label labelAcc;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.LinkLabel linkLabelChangePas;
        private System.Windows.Forms.Panel panelChangePas;
        private System.Windows.Forms.Button BtnChangeConfirm;
        private System.Windows.Forms.TextBox textBoxNewPas;
        private System.Windows.Forms.TextBox textBoxOldPas;
        private System.Windows.Forms.Label labelNewPas;
        private System.Windows.Forms.Label labelOldPas;
        private System.Windows.Forms.Button BtnBackToLog;
        private System.Windows.Forms.Label labelChangeAccount;
        private System.Windows.Forms.TextBox textBoxChangeAccount;
    }
}