namespace WindowsBaselineAssistant
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BaselineList = new Sunny.UI.UIDataGridView();
            this.CheckBtn = new Sunny.UI.UIButton();
            this.FortifyBtn = new Sunny.UI.UIButton();
            this.ReportBtn = new Sunny.UI.UIButton();
            this.AboutLinkLabel = new Sunny.UI.UILinkLabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.totalCountLabel = new Sunny.UI.UILabel();
            this.passCountLabel = new Sunny.UI.UILabel();
            this.failCountLabel = new Sunny.UI.UILabel();
            this.rateLabel = new Sunny.UI.UILabel();
            this.uiContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.OpenSubKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BaselineList)).BeginInit();
            this.uiContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaselineList
            // 
            this.BaselineList.AllowUserToAddRows = false;
            this.BaselineList.AllowUserToDeleteRows = false;
            this.BaselineList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.BaselineList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BaselineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BaselineList.BackgroundColor = System.Drawing.Color.White;
            this.BaselineList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BaselineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BaselineList.ColumnHeadersHeight = 32;
            this.BaselineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BaselineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BaselineList.DefaultCellStyle = dataGridViewCellStyle4;
            this.BaselineList.EnableHeadersVisualStyles = false;
            this.BaselineList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaselineList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.BaselineList.Location = new System.Drawing.Point(27, 104);
            this.BaselineList.Name = "BaselineList";
            this.BaselineList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BaselineList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BaselineList.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaselineList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.BaselineList.RowTemplate.Height = 23;
            this.BaselineList.SelectedIndex = -1;
            this.BaselineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BaselineList.Size = new System.Drawing.Size(1024, 425);
            this.BaselineList.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.BaselineList.TabIndex = 0;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBtn.Location = new System.Drawing.Point(377, 595);
            this.CheckBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(100, 35);
            this.CheckBtn.TabIndex = 1;
            this.CheckBtn.Text = "检测";
            this.CheckBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // FortifyBtn
            // 
            this.FortifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FortifyBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FortifyBtn.Location = new System.Drawing.Point(535, 595);
            this.FortifyBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.FortifyBtn.Name = "FortifyBtn";
            this.FortifyBtn.Size = new System.Drawing.Size(100, 35);
            this.FortifyBtn.TabIndex = 1;
            this.FortifyBtn.Text = "加固";
            this.FortifyBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // ReportBtn
            // 
            this.ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReportBtn.Location = new System.Drawing.Point(702, 595);
            this.ReportBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(100, 35);
            this.ReportBtn.TabIndex = 1;
            this.ReportBtn.Text = "导出报告";
            this.ReportBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // AboutLinkLabel
            // 
            this.AboutLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.AboutLinkLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AboutLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.AboutLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.AboutLinkLabel.Location = new System.Drawing.Point(912, 650);
            this.AboutLinkLabel.Name = "AboutLinkLabel";
            this.AboutLinkLabel.Size = new System.Drawing.Size(139, 27);
            this.AboutLinkLabel.TabIndex = 2;
            this.AboutLinkLabel.TabStop = true;
            this.AboutLinkLabel.Text = "Author: S0cke3t";
            this.AboutLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AboutLinkLabel.Click += new System.EventHandler(this.AboutLinkLabel_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(24, 550);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "总检测数: ";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Green;
            this.uiLabel2.Location = new System.Drawing.Point(24, 582);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "符合数: ";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiLabel3.Location = new System.Drawing.Point(24, 614);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "不符合数: ";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiLabel4.Location = new System.Drawing.Point(24, 647);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "符合率: ";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCountLabel
            // 
            this.totalCountLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.totalCountLabel.Location = new System.Drawing.Point(130, 550);
            this.totalCountLabel.Name = "totalCountLabel";
            this.totalCountLabel.Size = new System.Drawing.Size(129, 23);
            this.totalCountLabel.TabIndex = 4;
            this.totalCountLabel.Text = "-";
            this.totalCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passCountLabel
            // 
            this.passCountLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.passCountLabel.Location = new System.Drawing.Point(130, 582);
            this.passCountLabel.Name = "passCountLabel";
            this.passCountLabel.Size = new System.Drawing.Size(116, 23);
            this.passCountLabel.TabIndex = 4;
            this.passCountLabel.Text = "-";
            this.passCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // failCountLabel
            // 
            this.failCountLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.failCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.failCountLabel.Location = new System.Drawing.Point(130, 614);
            this.failCountLabel.Name = "failCountLabel";
            this.failCountLabel.Size = new System.Drawing.Size(116, 23);
            this.failCountLabel.TabIndex = 4;
            this.failCountLabel.Text = "-";
            this.failCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rateLabel
            // 
            this.rateLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rateLabel.Location = new System.Drawing.Point(130, 647);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(116, 23);
            this.rateLabel.TabIndex = 4;
            this.rateLabel.Text = "-";
            this.rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiContextMenuStrip
            // 
            this.uiContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.uiContextMenuStrip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSubKeyToolStripMenuItem});
            this.uiContextMenuStrip.Name = "uiContextMenuStrip";
            this.uiContextMenuStrip.Size = new System.Drawing.Size(181, 48);
            this.uiContextMenuStrip.Style = Sunny.UI.UIStyle.Custom;
            // 
            // OpenSubKeyToolStripMenuItem
            // 
            this.OpenSubKeyToolStripMenuItem.Image = global::WindowsBaselineAssistant.Properties.Resources.file_type_registry_icon_130200;
            this.OpenSubKeyToolStripMenuItem.Name = "OpenSubKeyToolStripMenuItem";
            this.OpenSubKeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenSubKeyToolStripMenuItem.Text = "打开注册表项";
            this.OpenSubKeyToolStripMenuItem.Click += new System.EventHandler(this.OpenSubKeyToolStripMenuItem_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "检测名称";
            this.Column1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Column1.LinkColor = System.Drawing.Color.Black;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.TrackVisitedState = false;
            this.Column1.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "描述";
            this.Column2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Column2.LinkColor = System.Drawing.Color.Black;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.TrackVisitedState = false;
            this.Column2.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.ContextMenuStrip = this.uiContextMenuStrip;
            this.Column6.HeaderText = "注册/策略表项";
            this.Column6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Column6.LinkColor = System.Drawing.Color.Black;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.TrackVisitedState = false;
            this.Column6.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.HeaderText = "注册/策略表字段";
            this.Column7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Column7.LinkColor = System.Drawing.Color.Black;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.TrackVisitedState = false;
            this.Column7.VisitedLinkColor = System.Drawing.Color.Black;
            this.Column7.Width = 132;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "标准值";
            this.Column3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Column3.LinkColor = System.Drawing.Color.Black;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.TrackVisitedState = false;
            this.Column3.VisitedLinkColor = System.Drawing.Color.Black;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "检测值";
            this.Column4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Column4.LinkColor = System.Drawing.Color.Black;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.TrackVisitedState = false;
            this.Column4.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column5.HeaderText = "检测结果";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 76;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1078, 693);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.failCountLabel);
            this.Controls.Add(this.passCountLabel);
            this.Controls.Add(this.totalCountLabel);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.AboutLinkLabel);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.FortifyBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.BaselineList);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "WindowsBaselineAssistant";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.BaselineList)).EndInit();
            this.uiContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView BaselineList;
        private Sunny.UI.UIButton CheckBtn;
        private Sunny.UI.UIButton FortifyBtn;
        private Sunny.UI.UIButton ReportBtn;
        private Sunny.UI.UILinkLabel AboutLinkLabel;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel totalCountLabel;
        private Sunny.UI.UILabel passCountLabel;
        private Sunny.UI.UILabel failCountLabel;
        private Sunny.UI.UILabel rateLabel;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column6;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenSubKeyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewLinkColumn Column7;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
        private System.Windows.Forms.DataGridViewLinkColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}