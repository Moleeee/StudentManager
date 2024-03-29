﻿
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
            this.comboBoxIsTeacher = new System.Windows.Forms.ComboBox();
            this.labelIsTeacher = new System.Windows.Forms.Label();
            this.panelChangePas.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(308, 85);
            this.textBoxAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(193, 25);
            this.textBoxAccount.TabIndex = 0;
            this.textBoxAccount.Text = "2020";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(308, 126);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(193, 25);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "bupt";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(367, 212);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 31);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Location = new System.Drawing.Point(243, 95);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(37, 15);
            this.labelAcc.TabIndex = 3;
            this.labelAcc.Text = "账号";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(243, 136);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(37, 15);
            this.labelPas.TabIndex = 4;
            this.labelPas.Text = "密码";
            // 
            // linkLabelChangePas
            // 
            this.linkLabelChangePas.AutoSize = true;
            this.linkLabelChangePas.Location = new System.Drawing.Point(375, 256);
            this.linkLabelChangePas.Name = "linkLabelChangePas";
            this.linkLabelChangePas.Size = new System.Drawing.Size(67, 15);
            this.linkLabelChangePas.TabIndex = 4;
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
            this.panelChangePas.Location = new System.Drawing.Point(224, 76);
            this.panelChangePas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChangePas.Name = "panelChangePas";
            this.panelChangePas.Size = new System.Drawing.Size(323, 195);
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
            this.BtnBackToLog.Location = new System.Drawing.Point(201, 138);
            this.BtnBackToLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBackToLog.Name = "BtnBackToLog";
            this.BtnBackToLog.Size = new System.Drawing.Size(107, 29);
            this.BtnBackToLog.TabIndex = 9;
            this.BtnBackToLog.Text = "返回登录";
            this.BtnBackToLog.UseVisualStyleBackColor = true;
            this.BtnBackToLog.Click += new System.EventHandler(this.BtnBackToLog_Click);
            // 
            // BtnChangeConfirm
            // 
            this.BtnChangeConfirm.Location = new System.Drawing.Point(85, 138);
            this.BtnChangeConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnChangeConfirm.Name = "BtnChangeConfirm";
            this.BtnChangeConfirm.Size = new System.Drawing.Size(97, 29);
            this.BtnChangeConfirm.TabIndex = 8;
            this.BtnChangeConfirm.Text = "确认修改";
            this.BtnChangeConfirm.UseVisualStyleBackColor = true;
            this.BtnChangeConfirm.Click += new System.EventHandler(this.BtnChangeConfirm_Click);
            // 
            // textBoxChangeAccount
            // 
            this.textBoxChangeAccount.Location = new System.Drawing.Point(85, 18);
            this.textBoxChangeAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxChangeAccount.Name = "textBoxChangeAccount";
            this.textBoxChangeAccount.Size = new System.Drawing.Size(188, 25);
            this.textBoxChangeAccount.TabIndex = 5;
            this.textBoxChangeAccount.TextChanged += new System.EventHandler(this.textBoxChangeAccount_TextChanged);
            // 
            // textBoxNewPas
            // 
            this.textBoxNewPas.Location = new System.Drawing.Point(85, 92);
            this.textBoxNewPas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewPas.Name = "textBoxNewPas";
            this.textBoxNewPas.Size = new System.Drawing.Size(188, 25);
            this.textBoxNewPas.TabIndex = 7;
            // 
            // textBoxOldPas
            // 
            this.textBoxOldPas.Location = new System.Drawing.Point(85, 58);
            this.textBoxOldPas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOldPas.Name = "textBoxOldPas";
            this.textBoxOldPas.Size = new System.Drawing.Size(188, 25);
            this.textBoxOldPas.TabIndex = 6;
            // 
            // labelNewPas
            // 
            this.labelNewPas.AutoSize = true;
            this.labelNewPas.Location = new System.Drawing.Point(13, 96);
            this.labelNewPas.Name = "labelNewPas";
            this.labelNewPas.Size = new System.Drawing.Size(52, 15);
            this.labelNewPas.TabIndex = 1;
            this.labelNewPas.Text = "新密码";
            // 
            // labelOldPas
            // 
            this.labelOldPas.AutoSize = true;
            this.labelOldPas.Location = new System.Drawing.Point(13, 60);
            this.labelOldPas.Name = "labelOldPas";
            this.labelOldPas.Size = new System.Drawing.Size(52, 15);
            this.labelOldPas.TabIndex = 0;
            this.labelOldPas.Text = "旧密码";
            // 
            // comboBoxIsTeacher
            // 
            this.comboBoxIsTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsTeacher.FormattingEnabled = true;
            this.comboBoxIsTeacher.Items.AddRange(new object[] {
            "管理员",
            "学生"});
            this.comboBoxIsTeacher.Location = new System.Drawing.Point(308, 168);
            this.comboBoxIsTeacher.Name = "comboBoxIsTeacher";
            this.comboBoxIsTeacher.Size = new System.Drawing.Size(193, 23);
            this.comboBoxIsTeacher.TabIndex = 2;
            // 
            // labelIsTeacher
            // 
            this.labelIsTeacher.AutoSize = true;
            this.labelIsTeacher.Location = new System.Drawing.Point(246, 175);
            this.labelIsTeacher.Name = "labelIsTeacher";
            this.labelIsTeacher.Size = new System.Drawing.Size(37, 15);
            this.labelIsTeacher.TabIndex = 8;
            this.labelIsTeacher.Text = "身份";
            // 
            // LoginForm01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChangePas);
            this.Controls.Add(this.labelIsTeacher);
            this.Controls.Add(this.comboBoxIsTeacher);
            this.Controls.Add(this.linkLabelChangePas);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.labelAcc);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox comboBoxIsTeacher;
        private System.Windows.Forms.Label labelIsTeacher;
    }
}