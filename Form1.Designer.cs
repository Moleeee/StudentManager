
using System.Text;

namespace WindowsFormsApp1
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAddSinfo = new System.Windows.Forms.Button();
            this.panelAddSinfo = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxSgrade = new System.Windows.Forms.ComboBox();
            this.labelSgrade = new System.Windows.Forms.Label();
            this.labelSsex = new System.Windows.Forms.Label();
            this.comboBoxSsex = new System.Windows.Forms.ComboBox();
            this.buttonAddConform = new System.Windows.Forms.Button();
            this.textBoxSdeg = new System.Windows.Forms.TextBox();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.labelSdeg = new System.Windows.Forms.Label();
            this.labelSname = new System.Windows.Forms.Label();
            this.labelSno = new System.Windows.Forms.Label();
            this.textBoxSno = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDelSinfo = new System.Windows.Forms.Panel();
            this.buttonDelConform = new System.Windows.Forms.Button();
            this.textBoxDel = new System.Windows.Forms.TextBox();
            this.labelDel = new System.Windows.Forms.Label();
            this.buttonAllSinfo = new System.Windows.Forms.Button();
            this.buttonDelSinfo = new System.Windows.Forms.Button();
            this.buttonGetSAverage = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelHistory = new System.Windows.Forms.Label();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.listBoxShow = new System.Windows.Forms.ListBox();
            this.buttonSearchSinfo = new System.Windows.Forms.Button();
            this.panelSearchSinfo = new System.Windows.Forms.Panel();
            this.buttonSearchConfirm = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.stuinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminDataSet = new WindowsFormsApp1.AdminDataSet();
            this.stuinfoTableAdapter = new WindowsFormsApp1.AdminDataSetTableAdapters.stuinfoTableAdapter();
            this.panelAddSinfo.SuspendLayout();
            this.panelDelSinfo.SuspendLayout();
            this.panelSearchSinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddSinfo
            // 
            this.buttonAddSinfo.Location = new System.Drawing.Point(16, 61);
            this.buttonAddSinfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSinfo.Name = "buttonAddSinfo";
            this.buttonAddSinfo.Size = new System.Drawing.Size(164, 29);
            this.buttonAddSinfo.TabIndex = 1;
            this.buttonAddSinfo.Text = "增改学生信息";
            this.buttonAddSinfo.UseVisualStyleBackColor = true;
            this.buttonAddSinfo.Click += new System.EventHandler(this.buttonAddSinfo_Click);
            // 
            // panelAddSinfo
            // 
            this.panelAddSinfo.Controls.Add(this.buttonUpdate);
            this.panelAddSinfo.Controls.Add(this.comboBoxSgrade);
            this.panelAddSinfo.Controls.Add(this.labelSgrade);
            this.panelAddSinfo.Controls.Add(this.labelSsex);
            this.panelAddSinfo.Controls.Add(this.comboBoxSsex);
            this.panelAddSinfo.Controls.Add(this.buttonAddConform);
            this.panelAddSinfo.Controls.Add(this.textBoxSdeg);
            this.panelAddSinfo.Controls.Add(this.textBoxSname);
            this.panelAddSinfo.Controls.Add(this.labelSdeg);
            this.panelAddSinfo.Controls.Add(this.labelSname);
            this.panelAddSinfo.Controls.Add(this.labelSno);
            this.panelAddSinfo.Controls.Add(this.textBoxSno);
            this.panelAddSinfo.Location = new System.Drawing.Point(192, 61);
            this.panelAddSinfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelAddSinfo.Name = "panelAddSinfo";
            this.panelAddSinfo.Size = new System.Drawing.Size(445, 285);
            this.panelAddSinfo.TabIndex = 3;
            this.panelAddSinfo.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(269, 220);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 29);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "修改";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxSgrade
            // 
            this.comboBoxSgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSgrade.FormattingEnabled = true;
            this.comboBoxSgrade.Items.AddRange(new object[] {
            "大一",
            "大二",
            "大三",
            "大四"});
            this.comboBoxSgrade.Location = new System.Drawing.Point(161, 163);
            this.comboBoxSgrade.Name = "comboBoxSgrade";
            this.comboBoxSgrade.Size = new System.Drawing.Size(200, 23);
            this.comboBoxSgrade.TabIndex = 10;
            // 
            // labelSgrade
            // 
            this.labelSgrade.AutoSize = true;
            this.labelSgrade.Location = new System.Drawing.Point(69, 163);
            this.labelSgrade.Name = "labelSgrade";
            this.labelSgrade.Size = new System.Drawing.Size(52, 15);
            this.labelSgrade.TabIndex = 11;
            this.labelSgrade.Text = "年级：";
            // 
            // labelSsex
            // 
            this.labelSsex.AutoSize = true;
            this.labelSsex.Location = new System.Drawing.Point(69, 126);
            this.labelSsex.Name = "labelSsex";
            this.labelSsex.Size = new System.Drawing.Size(52, 15);
            this.labelSsex.TabIndex = 10;
            this.labelSsex.Text = "性别：";
            // 
            // comboBoxSsex
            // 
            this.comboBoxSsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSsex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxSsex.FormattingEnabled = true;
            this.comboBoxSsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxSsex.Location = new System.Drawing.Point(161, 123);
            this.comboBoxSsex.Name = "comboBoxSsex";
            this.comboBoxSsex.Size = new System.Drawing.Size(200, 23);
            this.comboBoxSsex.TabIndex = 9;
            // 
            // buttonAddConform
            // 
            this.buttonAddConform.Location = new System.Drawing.Point(111, 220);
            this.buttonAddConform.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddConform.Name = "buttonAddConform";
            this.buttonAddConform.Size = new System.Drawing.Size(100, 29);
            this.buttonAddConform.TabIndex = 11;
            this.buttonAddConform.Text = "添加";
            this.buttonAddConform.UseVisualStyleBackColor = true;
            this.buttonAddConform.Click += new System.EventHandler(this.buttonAddConfirm_Click);
            // 
            // textBoxSdeg
            // 
            this.textBoxSdeg.Location = new System.Drawing.Point(161, 82);
            this.textBoxSdeg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSdeg.Name = "textBoxSdeg";
            this.textBoxSdeg.Size = new System.Drawing.Size(200, 25);
            this.textBoxSdeg.TabIndex = 8;
            this.textBoxSdeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(161, 45);
            this.textBoxSname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(200, 25);
            this.textBoxSname.TabIndex = 7;
            // 
            // labelSdeg
            // 
            this.labelSdeg.AutoSize = true;
            this.labelSdeg.Location = new System.Drawing.Point(69, 86);
            this.labelSdeg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSdeg.Name = "labelSdeg";
            this.labelSdeg.Size = new System.Drawing.Size(52, 15);
            this.labelSdeg.TabIndex = 6;
            this.labelSdeg.Text = "成绩：";
            // 
            // labelSname
            // 
            this.labelSname.AutoSize = true;
            this.labelSname.Location = new System.Drawing.Point(69, 49);
            this.labelSname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSname.Name = "labelSname";
            this.labelSname.Size = new System.Drawing.Size(52, 15);
            this.labelSname.TabIndex = 5;
            this.labelSname.Text = "姓名：";
            // 
            // labelSno
            // 
            this.labelSno.AutoSize = true;
            this.labelSno.Location = new System.Drawing.Point(69, 7);
            this.labelSno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSno.Name = "labelSno";
            this.labelSno.Size = new System.Drawing.Size(52, 15);
            this.labelSno.TabIndex = 4;
            this.labelSno.Text = "学号：";
            // 
            // textBoxSno
            // 
            this.textBoxSno.Location = new System.Drawing.Point(161, 3);
            this.textBoxSno.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSno.Name = "textBoxSno";
            this.textBoxSno.Size = new System.Drawing.Size(200, 25);
            this.textBoxSno.TabIndex = 6;
            this.textBoxSno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Enabled = false;
            this.labelTitle.Location = new System.Drawing.Point(13, 28);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(157, 15);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "欢迎使用学生管理系统";
            // 
            // panelDelSinfo
            // 
            this.panelDelSinfo.Controls.Add(this.buttonDelConform);
            this.panelDelSinfo.Controls.Add(this.textBoxDel);
            this.panelDelSinfo.Controls.Add(this.labelDel);
            this.panelDelSinfo.Location = new System.Drawing.Point(192, 61);
            this.panelDelSinfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelDelSinfo.Name = "panelDelSinfo";
            this.panelDelSinfo.Size = new System.Drawing.Size(449, 249);
            this.panelDelSinfo.TabIndex = 4;
            this.panelDelSinfo.Visible = false;
            // 
            // buttonDelConform
            // 
            this.buttonDelConform.Location = new System.Drawing.Point(171, 127);
            this.buttonDelConform.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelConform.Name = "buttonDelConform";
            this.buttonDelConform.Size = new System.Drawing.Size(100, 29);
            this.buttonDelConform.TabIndex = 13;
            this.buttonDelConform.Text = "删除";
            this.buttonDelConform.UseVisualStyleBackColor = true;
            this.buttonDelConform.Click += new System.EventHandler(this.buttonDelConfirm_Click);
            // 
            // textBoxDel
            // 
            this.textBoxDel.Location = new System.Drawing.Point(163, 16);
            this.textBoxDel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDel.Name = "textBoxDel";
            this.textBoxDel.Size = new System.Drawing.Size(200, 25);
            this.textBoxDel.TabIndex = 12;
            // 
            // labelDel
            // 
            this.labelDel.AutoSize = true;
            this.labelDel.Location = new System.Drawing.Point(64, 22);
            this.labelDel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDel.Name = "labelDel";
            this.labelDel.Size = new System.Drawing.Size(75, 15);
            this.labelDel.TabIndex = 0;
            this.labelDel.Text = "删除学号:";
            // 
            // buttonAllSinfo
            // 
            this.buttonAllSinfo.Location = new System.Drawing.Point(16, 156);
            this.buttonAllSinfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllSinfo.Name = "buttonAllSinfo";
            this.buttonAllSinfo.Size = new System.Drawing.Size(164, 29);
            this.buttonAllSinfo.TabIndex = 3;
            this.buttonAllSinfo.Text = "显示所有信息";
            this.buttonAllSinfo.UseVisualStyleBackColor = true;
            this.buttonAllSinfo.Click += new System.EventHandler(this.buttonAllSinfo_Click);
            // 
            // buttonDelSinfo
            // 
            this.buttonDelSinfo.Location = new System.Drawing.Point(17, 106);
            this.buttonDelSinfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelSinfo.Name = "buttonDelSinfo";
            this.buttonDelSinfo.Size = new System.Drawing.Size(163, 29);
            this.buttonDelSinfo.TabIndex = 2;
            this.buttonDelSinfo.Text = "删除学生信息";
            this.buttonDelSinfo.UseVisualStyleBackColor = true;
            this.buttonDelSinfo.Click += new System.EventHandler(this.buttonDelSinfo_Click);
            // 
            // buttonGetSAverage
            // 
            this.buttonGetSAverage.Location = new System.Drawing.Point(16, 210);
            this.buttonGetSAverage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetSAverage.Name = "buttonGetSAverage";
            this.buttonGetSAverage.Size = new System.Drawing.Size(163, 29);
            this.buttonGetSAverage.TabIndex = 4;
            this.buttonGetSAverage.Text = "查看平均分数";
            this.buttonGetSAverage.UseVisualStyleBackColor = true;
            this.buttonGetSAverage.Click += new System.EventHandler(this.buttonGetSAverage_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(16, 536);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 15);
            this.labelDate.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(651, 11);
            this.labelHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(75, 15);
            this.labelHistory.TabIndex = 10;
            this.labelHistory.Text = "历史记录:";
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 15;
            this.listBoxHistory.Location = new System.Drawing.Point(645, 32);
            this.listBoxHistory.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(542, 214);
            this.listBoxHistory.TabIndex = 11;
            // 
            // listBoxShow
            // 
            this.listBoxShow.FormattingEnabled = true;
            this.listBoxShow.ItemHeight = 15;
            this.listBoxShow.Location = new System.Drawing.Point(645, 298);
            this.listBoxShow.Name = "listBoxShow";
            this.listBoxShow.Size = new System.Drawing.Size(542, 259);
            this.listBoxShow.TabIndex = 14;
            // 
            // buttonSearchSinfo
            // 
            this.buttonSearchSinfo.Location = new System.Drawing.Point(16, 264);
            this.buttonSearchSinfo.Name = "buttonSearchSinfo";
            this.buttonSearchSinfo.Size = new System.Drawing.Size(163, 28);
            this.buttonSearchSinfo.TabIndex = 5;
            this.buttonSearchSinfo.Text = "查找特定学号";
            this.buttonSearchSinfo.UseVisualStyleBackColor = true;
            this.buttonSearchSinfo.Click += new System.EventHandler(this.buttonSearchSinfo_Click);
            // 
            // panelSearchSinfo
            // 
            this.panelSearchSinfo.Controls.Add(this.buttonSearchConfirm);
            this.panelSearchSinfo.Controls.Add(this.textBoxSearch);
            this.panelSearchSinfo.Controls.Add(this.labelSearch);
            this.panelSearchSinfo.Location = new System.Drawing.Point(192, 28);
            this.panelSearchSinfo.Name = "panelSearchSinfo";
            this.panelSearchSinfo.Size = new System.Drawing.Size(445, 260);
            this.panelSearchSinfo.TabIndex = 16;
            this.panelSearchSinfo.Visible = false;
            // 
            // buttonSearchConfirm
            // 
            this.buttonSearchConfirm.Location = new System.Drawing.Point(169, 157);
            this.buttonSearchConfirm.Name = "buttonSearchConfirm";
            this.buttonSearchConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchConfirm.TabIndex = 15;
            this.buttonSearchConfirm.Text = "查找";
            this.buttonSearchConfirm.UseVisualStyleBackColor = true;
            this.buttonSearchConfirm.Click += new System.EventHandler(this.buttonSearchConfirm_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(149, 55);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(171, 25);
            this.textBoxSearch.TabIndex = 14;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(52, 61);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(82, 15);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "查找学号：";
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShow.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(645, 298);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.RowHeadersVisible = false;
            this.dataGridViewShow.RowHeadersWidth = 51;
            this.dataGridViewShow.RowTemplate.Height = 27;
            this.dataGridViewShow.Size = new System.Drawing.Size(540, 260);
            this.dataGridViewShow.TabIndex = 17;
            // 
            // stuinfoBindingSource
            // 
            this.stuinfoBindingSource.DataMember = "stuinfo";
            this.stuinfoBindingSource.DataSource = this.adminDataSet;
            // 
            // adminDataSet
            // 
            this.adminDataSet.DataSetName = "AdminDataSet";
            this.adminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stuinfoTableAdapter
            // 
            this.stuinfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 562);
            this.Controls.Add(this.panelAddSinfo);
            this.Controls.Add(this.panelSearchSinfo);
            this.Controls.Add(this.panelDelSinfo);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.buttonSearchSinfo);
            this.Controls.Add(this.listBoxShow);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonGetSAverage);
            this.Controls.Add(this.buttonDelSinfo);
            this.Controls.Add(this.buttonAllSinfo);
            this.Controls.Add(this.buttonAddSinfo);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "学生管理系统";
            this.panelAddSinfo.ResumeLayout(false);
            this.panelAddSinfo.PerformLayout();
            this.panelDelSinfo.ResumeLayout(false);
            this.panelDelSinfo.PerformLayout();
            this.panelSearchSinfo.ResumeLayout(false);
            this.panelSearchSinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        



        #endregion
        private System.Windows.Forms.Button buttonAddSinfo;
        private System.Windows.Forms.Panel panelAddSinfo;
        private System.Windows.Forms.TextBox textBoxSno;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSno;
        private System.Windows.Forms.Label labelSdeg;
        private System.Windows.Forms.Label labelSname;
        public System.Windows.Forms.TextBox textBoxSdeg;
        public System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.Button buttonAddConform;
        private System.Windows.Forms.Button buttonAllSinfo;
        private System.Windows.Forms.Button buttonDelSinfo;
        private System.Windows.Forms.Panel panelDelSinfo;
        private System.Windows.Forms.Label labelDel;
        private System.Windows.Forms.TextBox textBoxDel;
        private System.Windows.Forms.Button buttonDelConform;
        private System.Windows.Forms.Button buttonGetSAverage;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.ComboBox comboBoxSsex;
        private System.Windows.Forms.Label labelSsex;
        private System.Windows.Forms.Label labelSgrade;
        private System.Windows.Forms.ComboBox comboBoxSgrade;
        private System.Windows.Forms.ListBox listBoxShow;
        private System.Windows.Forms.Button buttonSearchSinfo;
        private System.Windows.Forms.Panel panelSearchSinfo;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSearchConfirm;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private AdminDataSet adminDataSet;
        private System.Windows.Forms.BindingSource stuinfoBindingSource;
        private AdminDataSetTableAdapters.stuinfoTableAdapter stuinfoTableAdapter;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

