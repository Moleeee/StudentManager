
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
            this.labelSL = new System.Windows.Forms.Label();
            this.buttonSLConfirm = new System.Windows.Forms.Button();
            this.buttonSLBack = new System.Windows.Forms.Button();
            this.labelCL = new System.Windows.Forms.Label();
            this.labelChoosedLesson = new System.Windows.Forms.Label();
            this.panelSL.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(326, 134);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "查询成绩";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonSelectLesson
            // 
            this.buttonSelectLesson.Location = new System.Drawing.Point(326, 206);
            this.buttonSelectLesson.Name = "buttonSelectLesson";
            this.buttonSelectLesson.Size = new System.Drawing.Size(75, 23);
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
            this.comboBoxSL.Location = new System.Drawing.Point(83, 52);
            this.comboBoxSL.Name = "comboBoxSL";
            this.comboBoxSL.Size = new System.Drawing.Size(165, 23);
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
            this.panelSL.Location = new System.Drawing.Point(243, 79);
            this.panelSL.Name = "panelSL";
            this.panelSL.Size = new System.Drawing.Size(291, 227);
            this.panelSL.TabIndex = 2;
            this.panelSL.Visible = false;
            // 
            // labelSL
            // 
            this.labelSL.AutoSize = true;
            this.labelSL.Location = new System.Drawing.Point(24, 55);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(45, 15);
            this.labelSL.TabIndex = 1;
            this.labelSL.Text = "选课:";
            // 
            // buttonSLConfirm
            // 
            this.buttonSLConfirm.Location = new System.Drawing.Point(51, 178);
            this.buttonSLConfirm.Name = "buttonSLConfirm";
            this.buttonSLConfirm.Size = new System.Drawing.Size(59, 23);
            this.buttonSLConfirm.TabIndex = 2;
            this.buttonSLConfirm.Text = "确认";
            this.buttonSLConfirm.UseVisualStyleBackColor = true;
            this.buttonSLConfirm.Click += new System.EventHandler(this.buttonSLConfirm_Click);
            // 
            // buttonSLBack
            // 
            this.buttonSLBack.Location = new System.Drawing.Point(189, 178);
            this.buttonSLBack.Name = "buttonSLBack";
            this.buttonSLBack.Size = new System.Drawing.Size(59, 23);
            this.buttonSLBack.TabIndex = 3;
            this.buttonSLBack.Text = "返回";
            this.buttonSLBack.UseVisualStyleBackColor = true;
            this.buttonSLBack.Click += new System.EventHandler(this.buttonSLBack_Click);
            // 
            // labelCL
            // 
            this.labelCL.AutoSize = true;
            this.labelCL.Location = new System.Drawing.Point(24, 13);
            this.labelCL.Name = "labelCL";
            this.labelCL.Size = new System.Drawing.Size(75, 15);
            this.labelCL.TabIndex = 4;
            this.labelCL.Text = "当前已选:";
            // 
            // labelChoosedLesson
            // 
            this.labelChoosedLesson.AutoSize = true;
            this.labelChoosedLesson.Location = new System.Drawing.Point(105, 13);
            this.labelChoosedLesson.Name = "labelChoosedLesson";
            this.labelChoosedLesson.Size = new System.Drawing.Size(37, 15);
            this.labelChoosedLesson.TabIndex = 5;
            this.labelChoosedLesson.Text = "未选";
            // 
            // StuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSL);
            this.Controls.Add(this.buttonSelectLesson);
            this.Controls.Add(this.buttonCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StuForm";
            this.Text = "StuForm";
            this.panelSL.ResumeLayout(false);
            this.panelSL.PerformLayout();
            this.ResumeLayout(false);

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
    }
}