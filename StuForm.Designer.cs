
namespace WindowsFormsApp1
{
    partial class StuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuForm));
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonSelectLesson = new System.Windows.Forms.Button();
            this.comboBoxSL = new System.Windows.Forms.ComboBox();
            this.panelSL = new System.Windows.Forms.Panel();
            this.labelChoosedLesson = new System.Windows.Forms.Label();
            this.labelCL = new System.Windows.Forms.Label();
            this.buttonSLBack = new System.Windows.Forms.Button();
            this.buttonSLConfirm = new System.Windows.Forms.Button();
            this.labelSL = new System.Windows.Forms.Label();
            this.labelnowSno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSL.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(244, 107);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(87, 24);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "查询成绩";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonSelectLesson
            // 
            this.buttonSelectLesson.Location = new System.Drawing.Point(244, 165);
            this.buttonSelectLesson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelectLesson.Name = "buttonSelectLesson";
            this.buttonSelectLesson.Size = new System.Drawing.Size(87, 23);
            this.buttonSelectLesson.TabIndex = 1;
            this.buttonSelectLesson.Text = "选课";
            this.buttonSelectLesson.UseVisualStyleBackColor = true;
            this.buttonSelectLesson.Click += new System.EventHandler(this.buttonSelectLesson_Click);
            // 
            // comboBoxSL
            // 
            this.comboBoxSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSL.FormattingEnabled = true;
            this.comboBoxSL.Items.AddRange(new object[] {
            "模拟电路",
            "数字电路",
            "概率论",
            "信号与系统",
            "程序设计实践"});
            this.comboBoxSL.Location = new System.Drawing.Point(62, 42);
            this.comboBoxSL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSL.Name = "comboBoxSL";
            this.comboBoxSL.Size = new System.Drawing.Size(125, 20);
            this.comboBoxSL.TabIndex = 0;
            // 
            // panelSL
            // 
            this.panelSL.Controls.Add(this.labelChoosedLesson);
            this.panelSL.Controls.Add(this.labelCL);
            this.panelSL.Controls.Add(this.buttonSLBack);
            this.panelSL.Controls.Add(this.buttonSLConfirm);
            this.panelSL.Controls.Add(this.labelSL);
            this.panelSL.Controls.Add(this.comboBoxSL);
            this.panelSL.Location = new System.Drawing.Point(182, 63);
            this.panelSL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSL.Name = "panelSL";
            this.panelSL.Size = new System.Drawing.Size(218, 182);
            this.panelSL.TabIndex = 2;
            this.panelSL.Visible = false;
            // 
            // labelChoosedLesson
            // 
            this.labelChoosedLesson.AutoSize = true;
            this.labelChoosedLesson.Location = new System.Drawing.Point(79, 10);
            this.labelChoosedLesson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChoosedLesson.Name = "labelChoosedLesson";
            this.labelChoosedLesson.Size = new System.Drawing.Size(29, 12);
            this.labelChoosedLesson.TabIndex = 5;
            this.labelChoosedLesson.Text = "未选";
            // 
            // labelCL
            // 
            this.labelCL.AutoSize = true;
            this.labelCL.Location = new System.Drawing.Point(18, 10);
            this.labelCL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCL.Name = "labelCL";
            this.labelCL.Size = new System.Drawing.Size(59, 12);
            this.labelCL.TabIndex = 4;
            this.labelCL.Text = "当前已选:";
            // 
            // buttonSLBack
            // 
            this.buttonSLBack.Location = new System.Drawing.Point(142, 142);
            this.buttonSLBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSLBack.Name = "buttonSLBack";
            this.buttonSLBack.Size = new System.Drawing.Size(45, 27);
            this.buttonSLBack.TabIndex = 3;
            this.buttonSLBack.Text = "返回";
            this.buttonSLBack.UseVisualStyleBackColor = true;
            this.buttonSLBack.Click += new System.EventHandler(this.buttonSLBack_Click);
            // 
            // buttonSLConfirm
            // 
            this.buttonSLConfirm.Location = new System.Drawing.Point(38, 142);
            this.buttonSLConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSLConfirm.Name = "buttonSLConfirm";
            this.buttonSLConfirm.Size = new System.Drawing.Size(50, 27);
            this.buttonSLConfirm.TabIndex = 2;
            this.buttonSLConfirm.Text = "确认";
            this.buttonSLConfirm.UseVisualStyleBackColor = true;
            this.buttonSLConfirm.Click += new System.EventHandler(this.buttonSLConfirm_Click);
            // 
            // labelSL
            // 
            this.labelSL.AutoSize = true;
            this.labelSL.Location = new System.Drawing.Point(18, 44);
            this.labelSL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(35, 12);
            this.labelSL.TabIndex = 1;
            this.labelSL.Text = "选课:";
            // 
            // labelnowSno
            // 
            this.labelnowSno.AutoSize = true;
            this.labelnowSno.Location = new System.Drawing.Point(107, 9);
            this.labelnowSno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnowSno.Name = "labelnowSno";
            this.labelnowSno.Size = new System.Drawing.Size(41, 12);
            this.labelnowSno.TabIndex = 3;
            this.labelnowSno.Text = "nowSno";
            this.labelnowSno.Click += new System.EventHandler(this.labelnowSno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "当前登录学号：";
            // 
            // StuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSL);
            this.Controls.Add(this.labelnowSno);
            this.Controls.Add(this.buttonSelectLesson);
            this.Controls.Add(this.buttonCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StuForm";
            this.Text = "StuForm";
            this.panelSL.ResumeLayout(false);
            this.panelSL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonSelectLesson;
        private System.Windows.Forms.ComboBox comboBoxSL;
        private System.Windows.Forms.Panel panelSL;
        private System.Windows.Forms.Button buttonSLBack;
        private System.Windows.Forms.Button buttonSLConfirm;
        private System.Windows.Forms.Label labelSL;
        private System.Windows.Forms.Label labelChoosedLesson;
        private System.Windows.Forms.Label labelCL;
        private System.Windows.Forms.Label labelnowSno;
        private System.Windows.Forms.Label label1;
    }
}