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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BaselineList = new Sunny.UI.UIDataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DdescriptionColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ItemColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.uiContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.OpenSubKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FieldColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.StandardColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.RealityColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FortifyColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ValueTypeColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CheckBtn = new Sunny.UI.UISymbolButton();
            this.FortifyBtn = new Sunny.UI.UISymbolButton();
            this.ReportBtn = new Sunny.UI.UISymbolButton();
            this.AboutLinkLabel = new Sunny.UI.UILinkLabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.totalCountLabel = new Sunny.UI.UILabel();
            this.passCountLabel = new Sunny.UI.UILabel();
            this.failCountLabel = new Sunny.UI.UILabel();
            this.rateLabel = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.OSLabel = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.IPLabel = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.OSNameLabel = new Sunny.UI.UILabel();
            this.checkAllCheckBox = new Sunny.UI.UICheckBox();
            this.RepoLinkLabel = new Sunny.UI.UILinkLabel();
            this.showValueTypeuiCheckBox = new Sunny.UI.UICheckBox();
            this.AddRulebtn = new Sunny.UI.UISymbolButton();
            this.uiLabel8 = new Sunny.UI.UILabel();
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
            this.NameColumn,
            this.DdescriptionColumn,
            this.ItemColumn,
            this.FieldColumn,
            this.StandardColumn,
            this.RealityColumn,
            this.StatusColumn,
            this.FortifyColumn,
            this.ValueTypeColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BaselineList.DefaultCellStyle = dataGridViewCellStyle4;
            this.BaselineList.EnableHeadersVisualStyles = false;
            this.BaselineList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaselineList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.BaselineList.Location = new System.Drawing.Point(27, 104);
            this.BaselineList.Name = "BaselineList";
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
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "检测名称";
            this.NameColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.NameColumn.LinkColor = System.Drawing.Color.Black;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameColumn.TrackVisitedState = false;
            this.NameColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // DdescriptionColumn
            // 
            this.DdescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DdescriptionColumn.HeaderText = "描述";
            this.DdescriptionColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.DdescriptionColumn.LinkColor = System.Drawing.Color.Black;
            this.DdescriptionColumn.Name = "DdescriptionColumn";
            this.DdescriptionColumn.TrackVisitedState = false;
            this.DdescriptionColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // ItemColumn
            // 
            this.ItemColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemColumn.ContextMenuStrip = this.uiContextMenuStrip;
            this.ItemColumn.HeaderText = "注册/SecEdit表项";
            this.ItemColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ItemColumn.LinkColor = System.Drawing.Color.Black;
            this.ItemColumn.Name = "ItemColumn";
            this.ItemColumn.TrackVisitedState = false;
            this.ItemColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // uiContextMenuStrip
            // 
            this.uiContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.uiContextMenuStrip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSubKeyToolStripMenuItem});
            this.uiContextMenuStrip.Name = "uiContextMenuStrip";
            this.uiContextMenuStrip.Size = new System.Drawing.Size(171, 26);
            this.uiContextMenuStrip.Style = Sunny.UI.UIStyle.Custom;
            // 
            // OpenSubKeyToolStripMenuItem
            // 
            this.OpenSubKeyToolStripMenuItem.Image = global::WindowsBaselineAssistant.Properties.Resources.file_type_registry_icon_130200;
            this.OpenSubKeyToolStripMenuItem.Name = "OpenSubKeyToolStripMenuItem";
            this.OpenSubKeyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.OpenSubKeyToolStripMenuItem.Text = "打开注册表项";
            this.OpenSubKeyToolStripMenuItem.Click += new System.EventHandler(this.OpenSubKeyToolStripMenuItem_Click);
            // 
            // FieldColumn
            // 
            this.FieldColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FieldColumn.HeaderText = "注册/SecEdit表字段";
            this.FieldColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.FieldColumn.LinkColor = System.Drawing.Color.Black;
            this.FieldColumn.Name = "FieldColumn";
            this.FieldColumn.TrackVisitedState = false;
            this.FieldColumn.VisitedLinkColor = System.Drawing.Color.Black;
            this.FieldColumn.Width = 156;
            // 
            // StandardColumn
            // 
            this.StandardColumn.HeaderText = "标准值";
            this.StandardColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.StandardColumn.LinkColor = System.Drawing.Color.Black;
            this.StandardColumn.Name = "StandardColumn";
            this.StandardColumn.TrackVisitedState = false;
            this.StandardColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // RealityColumn
            // 
            this.RealityColumn.HeaderText = "检测值";
            this.RealityColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.RealityColumn.LinkColor = System.Drawing.Color.Black;
            this.RealityColumn.Name = "RealityColumn";
            this.RealityColumn.TrackVisitedState = false;
            this.RealityColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // StatusColumn
            // 
            this.StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.StatusColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.StatusColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusColumn.HeaderText = "检测结果";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusColumn.Width = 76;
            // 
            // FortifyColumn
            // 
            this.FortifyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FortifyColumn.HeaderText = "加固";
            this.FortifyColumn.Name = "FortifyColumn";
            this.FortifyColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FortifyColumn.Width = 44;
            // 
            // ValueTypeColumn
            // 
            this.ValueTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ValueTypeColumn.HeaderText = "数据类型";
            this.ValueTypeColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ValueTypeColumn.LinkColor = System.Drawing.Color.Black;
            this.ValueTypeColumn.Name = "ValueTypeColumn";
            this.ValueTypeColumn.ReadOnly = true;
            this.ValueTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValueTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ValueTypeColumn.TrackVisitedState = false;
            this.ValueTypeColumn.Visible = false;
            this.ValueTypeColumn.VisitedLinkColor = System.Drawing.Color.Black;
            this.ValueTypeColumn.Width = 5;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBtn.Location = new System.Drawing.Point(251, 580);
            this.CheckBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(100, 35);
            this.CheckBtn.Symbol = 61442;
            this.CheckBtn.TabIndex = 1;
            this.CheckBtn.Text = "检测";
            this.CheckBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // FortifyBtn
            // 
            this.FortifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FortifyBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FortifyBtn.Location = new System.Drawing.Point(409, 580);
            this.FortifyBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.FortifyBtn.Name = "FortifyBtn";
            this.FortifyBtn.Size = new System.Drawing.Size(100, 35);
            this.FortifyBtn.Symbol = 61475;
            this.FortifyBtn.TabIndex = 1;
            this.FortifyBtn.Text = "加固";
            this.FortifyBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FortifyBtn.Click += new System.EventHandler(this.FortifyBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReportBtn.Location = new System.Drawing.Point(576, 580);
            this.ReportBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(100, 35);
            this.ReportBtn.Symbol = 61568;
            this.ReportBtn.TabIndex = 1;
            this.ReportBtn.Text = "导出结果";
            this.ReportBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // AboutLinkLabel
            // 
            this.AboutLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.AboutLinkLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AboutLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.AboutLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.AboutLinkLabel.Location = new System.Drawing.Point(909, 628);
            this.AboutLinkLabel.Name = "AboutLinkLabel";
            this.AboutLinkLabel.Size = new System.Drawing.Size(142, 27);
            this.AboutLinkLabel.TabIndex = 2;
            this.AboutLinkLabel.TabStop = true;
            this.AboutLinkLabel.Text = "Author: S0cke3t";
            this.AboutLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.rateLabel.Size = new System.Drawing.Size(399, 23);
            this.rateLabel.TabIndex = 4;
            this.rateLabel.Text = "-";
            this.rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(27, 60);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(80, 23);
            this.uiLabel5.TabIndex = 5;
            this.uiLabel5.Text = "系统版本: ";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OSLabel
            // 
            this.OSLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OSLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.OSLabel.Location = new System.Drawing.Point(113, 61);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(416, 23);
            this.OSLabel.TabIndex = 6;
            this.OSLabel.Text = "-";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(547, 60);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(67, 23);
            this.uiLabel6.TabIndex = 7;
            this.uiLabel6.Text = "IP地址: ";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IPLabel
            // 
            this.IPLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.IPLabel.Location = new System.Drawing.Point(613, 60);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(170, 23);
            this.IPLabel.TabIndex = 8;
            this.IPLabel.Text = "-";
            this.IPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(802, 61);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(71, 23);
            this.uiLabel7.TabIndex = 9;
            this.uiLabel7.Text = "主机名: ";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OSNameLabel
            // 
            this.OSNameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OSNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.OSNameLabel.Location = new System.Drawing.Point(872, 60);
            this.OSNameLabel.Name = "OSNameLabel";
            this.OSNameLabel.Size = new System.Drawing.Size(166, 23);
            this.OSNameLabel.TabIndex = 10;
            this.OSNameLabel.Text = "-";
            this.OSNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkAllCheckBox
            // 
            this.checkAllCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkAllCheckBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkAllCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkAllCheckBox.Location = new System.Drawing.Point(988, 535);
            this.checkAllCheckBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkAllCheckBox.Name = "checkAllCheckBox";
            this.checkAllCheckBox.Size = new System.Drawing.Size(63, 29);
            this.checkAllCheckBox.TabIndex = 11;
            this.checkAllCheckBox.Text = "全选";
            this.checkAllCheckBox.CheckedChanged += new System.EventHandler(this.checkAllCheckBox_CheckedChanged);
            // 
            // RepoLinkLabel
            // 
            this.RepoLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.RepoLinkLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RepoLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.RepoLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.RepoLinkLabel.Location = new System.Drawing.Point(921, 659);
            this.RepoLinkLabel.Name = "RepoLinkLabel";
            this.RepoLinkLabel.Size = new System.Drawing.Size(135, 27);
            this.RepoLinkLabel.TabIndex = 12;
            this.RepoLinkLabel.TabStop = true;
            this.RepoLinkLabel.Text = "代码仓库&&BUG反馈";
            this.RepoLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.RepoLinkLabel.Click += new System.EventHandler(this.RepoLinkLabel_Click);
            // 
            // showValueTypeuiCheckBox
            // 
            this.showValueTypeuiCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showValueTypeuiCheckBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showValueTypeuiCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.showValueTypeuiCheckBox.Location = new System.Drawing.Point(925, 570);
            this.showValueTypeuiCheckBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.showValueTypeuiCheckBox.Name = "showValueTypeuiCheckBox";
            this.showValueTypeuiCheckBox.Size = new System.Drawing.Size(126, 29);
            this.showValueTypeuiCheckBox.TabIndex = 13;
            this.showValueTypeuiCheckBox.Text = "显示数据类型";
            this.showValueTypeuiCheckBox.CheckedChanged += new System.EventHandler(this.showValueTypeuiCheckBox_CheckedChanged);
            // 
            // AddRulebtn
            // 
            this.AddRulebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRulebtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddRulebtn.Location = new System.Drawing.Point(740, 580);
            this.AddRulebtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddRulebtn.Name = "AddRulebtn";
            this.AddRulebtn.Size = new System.Drawing.Size(100, 35);
            this.AddRulebtn.Symbol = 61543;
            this.AddRulebtn.TabIndex = 1;
            this.AddRulebtn.Text = "添加规则";
            this.AddRulebtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddRulebtn.Click += new System.EventHandler(this.AddRulebtn_Click);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.Red;
            this.uiLabel8.Location = new System.Drawing.Point(535, 655);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(338, 23);
            this.uiLabel8.TabIndex = 14;
            this.uiLabel8.Text = "Tips: 右键注册表项可快速定位到该注册表项";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1078, 693);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.showValueTypeuiCheckBox);
            this.Controls.Add(this.RepoLinkLabel);
            this.Controls.Add(this.checkAllCheckBox);
            this.Controls.Add(this.OSNameLabel);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.OSLabel);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.failCountLabel);
            this.Controls.Add(this.passCountLabel);
            this.Controls.Add(this.totalCountLabel);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.AboutLinkLabel);
            this.Controls.Add(this.AddRulebtn);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.FortifyBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.BaselineList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Windows基线检测加固助手";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaselineList)).EndInit();
            this.uiContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView BaselineList;
        private Sunny.UI.UISymbolButton CheckBtn;
        private Sunny.UI.UISymbolButton FortifyBtn;
        private Sunny.UI.UISymbolButton ReportBtn;
        private Sunny.UI.UILinkLabel AboutLinkLabel;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel totalCountLabel;
        private Sunny.UI.UILabel passCountLabel;
        private Sunny.UI.UILabel failCountLabel;
        private Sunny.UI.UILabel rateLabel;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenSubKeyToolStripMenuItem;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel OSLabel;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel IPLabel;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel OSNameLabel;
        private Sunny.UI.UICheckBox checkAllCheckBox;
        private Sunny.UI.UILinkLabel RepoLinkLabel;
        private Sunny.UI.UICheckBox showValueTypeuiCheckBox;
        private System.Windows.Forms.DataGridViewLinkColumn NameColumn;
        private System.Windows.Forms.DataGridViewLinkColumn DdescriptionColumn;
        private System.Windows.Forms.DataGridViewLinkColumn ItemColumn;
        private System.Windows.Forms.DataGridViewLinkColumn FieldColumn;
        private System.Windows.Forms.DataGridViewLinkColumn StandardColumn;
        private System.Windows.Forms.DataGridViewLinkColumn RealityColumn;
        private System.Windows.Forms.DataGridViewButtonColumn StatusColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FortifyColumn;
        private System.Windows.Forms.DataGridViewLinkColumn ValueTypeColumn;
        private Sunny.UI.UISymbolButton AddRulebtn;
        private Sunny.UI.UILabel uiLabel8;
    }
}