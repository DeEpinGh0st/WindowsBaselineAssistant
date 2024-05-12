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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            BaselineList = new Sunny.UI.UIDataGridView();
            NameColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            DdescriptionColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            ItemColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            uiContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            OpenSubKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            FieldColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            StandardColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            RealityColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            StatusColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            FortifyColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ValueTypeColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            CheckBtn = new Sunny.UI.UISymbolButton();
            FortifyBtn = new Sunny.UI.UISymbolButton();
            ReportBtn = new Sunny.UI.UISymbolButton();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            totalCountLabel = new Sunny.UI.UILabel();
            passCountLabel = new Sunny.UI.UILabel();
            failCountLabel = new Sunny.UI.UILabel();
            rateLabel = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            OSLabel = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            uiLabel7 = new Sunny.UI.UILabel();
            OSNameLabel = new Sunny.UI.UILabel();
            checkAllCheckBox = new Sunny.UI.UICheckBox();
            showValueTypeuiCheckBox = new Sunny.UI.UICheckBox();
            AddRulebtn = new Sunny.UI.UISymbolButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            Tipbtn = new Sunny.UI.UIButton();
            Logbtn = new Sunny.UI.UIButton();
            uiToolTip1 = new Sunny.UI.UIToolTip(components);
            BlogAvatar = new Sunny.UI.UIAvatar();
            RepoAvatar = new Sunny.UI.UIAvatar();
            IpListComboBox = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)BaselineList).BeginInit();
            uiContextMenuStrip.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BaselineList
            // 
            BaselineList.AllowUserToAddRows = false;
            BaselineList.AllowUserToDeleteRows = false;
            BaselineList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            BaselineList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            BaselineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            BaselineList.BackgroundColor = System.Drawing.Color.White;
            BaselineList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            BaselineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BaselineList.ColumnHeadersHeight = 32;
            BaselineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BaselineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { NameColumn, DdescriptionColumn, ItemColumn, FieldColumn, StandardColumn, RealityColumn, StatusColumn, FortifyColumn, ValueTypeColumn });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            BaselineList.DefaultCellStyle = dataGridViewCellStyle4;
            BaselineList.EnableHeadersVisualStyles = false;
            BaselineList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            BaselineList.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            BaselineList.Location = new System.Drawing.Point(27, 104);
            BaselineList.Name = "BaselineList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            BaselineList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            BaselineList.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            BaselineList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            BaselineList.RowTemplate.Height = 23;
            BaselineList.SelectedIndex = -1;
            BaselineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            BaselineList.Size = new System.Drawing.Size(1024, 425);
            BaselineList.StripeOddColor = System.Drawing.Color.FromArgb(235, 243, 255);
            BaselineList.TabIndex = 0;
            // 
            // NameColumn
            // 
            NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            NameColumn.HeaderText = "检测名称";
            NameColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            NameColumn.LinkColor = System.Drawing.Color.Black;
            NameColumn.Name = "NameColumn";
            NameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            NameColumn.TrackVisitedState = false;
            NameColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // DdescriptionColumn
            // 
            DdescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            DdescriptionColumn.HeaderText = "描述";
            DdescriptionColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            DdescriptionColumn.LinkColor = System.Drawing.Color.Black;
            DdescriptionColumn.Name = "DdescriptionColumn";
            DdescriptionColumn.TrackVisitedState = false;
            DdescriptionColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // ItemColumn
            // 
            ItemColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ItemColumn.ContextMenuStrip = uiContextMenuStrip;
            ItemColumn.HeaderText = "注册/SecEdit表项";
            ItemColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            ItemColumn.LinkColor = System.Drawing.Color.Black;
            ItemColumn.Name = "ItemColumn";
            ItemColumn.TrackVisitedState = false;
            ItemColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // uiContextMenuStrip
            // 
            uiContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(238, 248, 248);
            uiContextMenuStrip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiContextMenuStrip.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { OpenSubKeyToolStripMenuItem });
            uiContextMenuStrip.Name = "uiContextMenuStrip";
            uiContextMenuStrip.Size = new System.Drawing.Size(171, 26);
            uiContextMenuStrip.Style = Sunny.UI.UIStyle.Custom;
            // 
            // OpenSubKeyToolStripMenuItem
            // 
            OpenSubKeyToolStripMenuItem.Image = Properties.Resources.file_type_registry_icon_130200;
            OpenSubKeyToolStripMenuItem.Name = "OpenSubKeyToolStripMenuItem";
            OpenSubKeyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            OpenSubKeyToolStripMenuItem.Text = "打开注册表项";
            OpenSubKeyToolStripMenuItem.Click += OpenSubKeyToolStripMenuItem_Click;
            // 
            // FieldColumn
            // 
            FieldColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            FieldColumn.HeaderText = "注册/SecEdit表字段";
            FieldColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            FieldColumn.LinkColor = System.Drawing.Color.Black;
            FieldColumn.Name = "FieldColumn";
            FieldColumn.TrackVisitedState = false;
            FieldColumn.VisitedLinkColor = System.Drawing.Color.Black;
            FieldColumn.Width = 156;
            // 
            // StandardColumn
            // 
            StandardColumn.HeaderText = "标准值";
            StandardColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            StandardColumn.LinkColor = System.Drawing.Color.Black;
            StandardColumn.Name = "StandardColumn";
            StandardColumn.TrackVisitedState = false;
            StandardColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // RealityColumn
            // 
            RealityColumn.HeaderText = "检测值";
            RealityColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            RealityColumn.LinkColor = System.Drawing.Color.Black;
            RealityColumn.Name = "RealityColumn";
            RealityColumn.TrackVisitedState = false;
            RealityColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // StatusColumn
            // 
            StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            StatusColumn.DefaultCellStyle = dataGridViewCellStyle3;
            StatusColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StatusColumn.HeaderText = "检测结果";
            StatusColumn.Name = "StatusColumn";
            StatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            StatusColumn.Width = 76;
            // 
            // FortifyColumn
            // 
            FortifyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            FortifyColumn.HeaderText = "加固";
            FortifyColumn.Name = "FortifyColumn";
            FortifyColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            FortifyColumn.Width = 44;
            // 
            // ValueTypeColumn
            // 
            ValueTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ValueTypeColumn.HeaderText = "数据类型";
            ValueTypeColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            ValueTypeColumn.LinkColor = System.Drawing.Color.Black;
            ValueTypeColumn.Name = "ValueTypeColumn";
            ValueTypeColumn.ReadOnly = true;
            ValueTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ValueTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            ValueTypeColumn.TrackVisitedState = false;
            ValueTypeColumn.Visible = false;
            ValueTypeColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // CheckBtn
            // 
            CheckBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            CheckBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            CheckBtn.Location = new System.Drawing.Point(251, 580);
            CheckBtn.MinimumSize = new System.Drawing.Size(1, 1);
            CheckBtn.Name = "CheckBtn";
            CheckBtn.Size = new System.Drawing.Size(100, 35);
            CheckBtn.Symbol = 61442;
            CheckBtn.TabIndex = 1;
            CheckBtn.Text = "检测";
            CheckBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            CheckBtn.Click += CheckBtn_Click;
            // 
            // FortifyBtn
            // 
            FortifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            FortifyBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            FortifyBtn.Location = new System.Drawing.Point(409, 580);
            FortifyBtn.MinimumSize = new System.Drawing.Size(1, 1);
            FortifyBtn.Name = "FortifyBtn";
            FortifyBtn.Size = new System.Drawing.Size(100, 35);
            FortifyBtn.Symbol = 61475;
            FortifyBtn.TabIndex = 1;
            FortifyBtn.Text = "加固";
            FortifyBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            FortifyBtn.Click += FortifyBtn_Click;
            // 
            // ReportBtn
            // 
            ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            ReportBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            ReportBtn.Location = new System.Drawing.Point(576, 580);
            ReportBtn.MinimumSize = new System.Drawing.Size(1, 1);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new System.Drawing.Size(100, 35);
            ReportBtn.Symbol = 61568;
            ReportBtn.TabIndex = 1;
            ReportBtn.Text = "导出结果";
            ReportBtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            ReportBtn.Click += ReportBtn_Click;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new System.Drawing.Point(24, 550);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(100, 23);
            uiLabel1.TabIndex = 3;
            uiLabel1.Text = "总检测数: ";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = System.Drawing.Color.Green;
            uiLabel2.Location = new System.Drawing.Point(24, 582);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(100, 23);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "符合数: ";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            uiLabel3.Location = new System.Drawing.Point(24, 614);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(100, 23);
            uiLabel3.TabIndex = 3;
            uiLabel3.Text = "不符合数: ";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel4.ForeColor = System.Drawing.Color.FromArgb(192, 0, 192);
            uiLabel4.Location = new System.Drawing.Point(24, 647);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(100, 23);
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "符合率: ";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCountLabel
            // 
            totalCountLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            totalCountLabel.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            totalCountLabel.Location = new System.Drawing.Point(130, 550);
            totalCountLabel.Name = "totalCountLabel";
            totalCountLabel.Size = new System.Drawing.Size(129, 23);
            totalCountLabel.TabIndex = 4;
            totalCountLabel.Text = "-";
            totalCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passCountLabel
            // 
            passCountLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            passCountLabel.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            passCountLabel.Location = new System.Drawing.Point(130, 582);
            passCountLabel.Name = "passCountLabel";
            passCountLabel.Size = new System.Drawing.Size(116, 23);
            passCountLabel.TabIndex = 4;
            passCountLabel.Text = "-";
            passCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // failCountLabel
            // 
            failCountLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            failCountLabel.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            failCountLabel.Location = new System.Drawing.Point(130, 614);
            failCountLabel.Name = "failCountLabel";
            failCountLabel.Size = new System.Drawing.Size(116, 23);
            failCountLabel.TabIndex = 4;
            failCountLabel.Text = "-";
            failCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rateLabel
            // 
            rateLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            rateLabel.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            rateLabel.Location = new System.Drawing.Point(130, 647);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(399, 23);
            rateLabel.TabIndex = 4;
            rateLabel.Text = "-";
            rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel5.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new System.Drawing.Point(27, 60);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new System.Drawing.Size(80, 23);
            uiLabel5.TabIndex = 5;
            uiLabel5.Text = "系统版本: ";
            uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OSLabel
            // 
            OSLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            OSLabel.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            OSLabel.Location = new System.Drawing.Point(113, 61);
            OSLabel.Name = "OSLabel";
            OSLabel.Size = new System.Drawing.Size(416, 23);
            OSLabel.TabIndex = 6;
            OSLabel.Text = "-";
            OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel6.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new System.Drawing.Point(541, 60);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new System.Drawing.Size(67, 23);
            uiLabel6.TabIndex = 7;
            uiLabel6.Text = "IP地址: ";
            uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel7.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel7.Location = new System.Drawing.Point(802, 61);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new System.Drawing.Size(71, 23);
            uiLabel7.TabIndex = 9;
            uiLabel7.Text = "主机名: ";
            uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OSNameLabel
            // 
            OSNameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            OSNameLabel.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            OSNameLabel.Location = new System.Drawing.Point(872, 60);
            OSNameLabel.Name = "OSNameLabel";
            OSNameLabel.Size = new System.Drawing.Size(166, 23);
            OSNameLabel.TabIndex = 10;
            OSNameLabel.Text = "-";
            OSNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkAllCheckBox
            // 
            checkAllCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            checkAllCheckBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            checkAllCheckBox.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            checkAllCheckBox.Location = new System.Drawing.Point(988, 535);
            checkAllCheckBox.MinimumSize = new System.Drawing.Size(1, 1);
            checkAllCheckBox.Name = "checkAllCheckBox";
            checkAllCheckBox.Size = new System.Drawing.Size(63, 29);
            checkAllCheckBox.TabIndex = 11;
            checkAllCheckBox.Text = "全选";
            checkAllCheckBox.CheckedChanged += checkAllCheckBox_CheckedChanged;
            // 
            // showValueTypeuiCheckBox
            // 
            showValueTypeuiCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            showValueTypeuiCheckBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            showValueTypeuiCheckBox.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            showValueTypeuiCheckBox.Location = new System.Drawing.Point(925, 570);
            showValueTypeuiCheckBox.MinimumSize = new System.Drawing.Size(1, 1);
            showValueTypeuiCheckBox.Name = "showValueTypeuiCheckBox";
            showValueTypeuiCheckBox.Size = new System.Drawing.Size(126, 29);
            showValueTypeuiCheckBox.TabIndex = 13;
            showValueTypeuiCheckBox.Text = "显示数据类型";
            showValueTypeuiCheckBox.CheckedChanged += showValueTypeuiCheckBox_CheckedChanged;
            // 
            // AddRulebtn
            // 
            AddRulebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            AddRulebtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            AddRulebtn.Location = new System.Drawing.Point(740, 580);
            AddRulebtn.MinimumSize = new System.Drawing.Size(1, 1);
            AddRulebtn.Name = "AddRulebtn";
            AddRulebtn.Size = new System.Drawing.Size(100, 35);
            AddRulebtn.Symbol = 61543;
            AddRulebtn.TabIndex = 1;
            AddRulebtn.Text = "添加规则";
            AddRulebtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            AddRulebtn.Click += AddRulebtn_Click;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(Tipbtn);
            uiGroupBox1.Controls.Add(Logbtn);
            uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(238, 248, 248);
            uiGroupBox1.FillColor2 = System.Drawing.Color.FromArgb(238, 248, 248);
            uiGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiGroupBox1.Location = new System.Drawing.Point(661, 621);
            uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new System.Drawing.Size(179, 63);
            uiGroupBox1.TabIndex = 15;
            uiGroupBox1.Text = null;
            uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tipbtn
            // 
            Tipbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            Tipbtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            Tipbtn.LightStyle = true;
            Tipbtn.Location = new System.Drawing.Point(17, 27);
            Tipbtn.MinimumSize = new System.Drawing.Size(1, 1);
            Tipbtn.Name = "Tipbtn";
            Tipbtn.Size = new System.Drawing.Size(66, 28);
            Tipbtn.TabIndex = 16;
            Tipbtn.Text = "Tips";
            Tipbtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiToolTip1.SetToolTip(Tipbtn, "- 右键注册表项可快速定位到该项位置.\r\n- 拷贝日志时,请先关闭软件再进行操作.\r\n");
            // 
            // Logbtn
            // 
            Logbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            Logbtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            Logbtn.LightStyle = true;
            Logbtn.Location = new System.Drawing.Point(97, 27);
            Logbtn.MinimumSize = new System.Drawing.Size(1, 1);
            Logbtn.Name = "Logbtn";
            Logbtn.Size = new System.Drawing.Size(66, 28);
            Logbtn.TabIndex = 16;
            Logbtn.Text = "日志目录";
            Logbtn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            Logbtn.TipsText = "!";
            Logbtn.Click += Logbtn_Click;
            // 
            // uiToolTip1
            // 
            uiToolTip1.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
            uiToolTip1.ForeColor = System.Drawing.Color.FromArgb(239, 239, 239);
            uiToolTip1.IsBalloon = true;
            uiToolTip1.OwnerDraw = true;
            uiToolTip1.TitleFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            uiToolTip1.ToolTipTitle = "Tips";
            // 
            // BlogAvatar
            // 
            BlogAvatar.FillColor = System.Drawing.Color.FromArgb(238, 248, 248);
            BlogAvatar.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            BlogAvatar.Location = new System.Drawing.Point(971, 644);
            BlogAvatar.MinimumSize = new System.Drawing.Size(1, 1);
            BlogAvatar.Name = "BlogAvatar";
            BlogAvatar.Size = new System.Drawing.Size(37, 40);
            BlogAvatar.Symbol = 161850;
            BlogAvatar.TabIndex = 17;
            BlogAvatar.Click += BlogAvatar_Click;
            // 
            // RepoAvatar
            // 
            RepoAvatar.FillColor = System.Drawing.Color.FromArgb(238, 248, 248);
            RepoAvatar.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            RepoAvatar.Location = new System.Drawing.Point(1019, 644);
            RepoAvatar.MinimumSize = new System.Drawing.Size(1, 1);
            RepoAvatar.Name = "RepoAvatar";
            RepoAvatar.Size = new System.Drawing.Size(37, 40);
            RepoAvatar.Symbol = 161595;
            RepoAvatar.TabIndex = 17;
            RepoAvatar.Text = "uiAvatar1";
            RepoAvatar.Click += RepoAvatar_Click;
            // 
            // IpListComboBox
            // 
            IpListComboBox.DataSource = null;
            IpListComboBox.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            IpListComboBox.FillColor = System.Drawing.Color.White;
            IpListComboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            IpListComboBox.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            IpListComboBox.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            IpListComboBox.Location = new System.Drawing.Point(609, 58);
            IpListComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            IpListComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            IpListComboBox.Name = "IpListComboBox";
            IpListComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            IpListComboBox.Size = new System.Drawing.Size(165, 30);
            IpListComboBox.SymbolSize = 24;
            IpListComboBox.TabIndex = 16;
            IpListComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            IpListComboBox.Watermark = "";
            // 
            // Main
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(238, 248, 248);
            ClientSize = new System.Drawing.Size(1078, 693);
            ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(51, 171, 160);
            Controls.Add(RepoAvatar);
            Controls.Add(BlogAvatar);
            Controls.Add(IpListComboBox);
            Controls.Add(uiGroupBox1);
            Controls.Add(showValueTypeuiCheckBox);
            Controls.Add(checkAllCheckBox);
            Controls.Add(OSNameLabel);
            Controls.Add(uiLabel7);
            Controls.Add(uiLabel6);
            Controls.Add(OSLabel);
            Controls.Add(uiLabel5);
            Controls.Add(rateLabel);
            Controls.Add(failCountLabel);
            Controls.Add(passCountLabel);
            Controls.Add(totalCountLabel);
            Controls.Add(uiLabel4);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel1);
            Controls.Add(AddRulebtn);
            Controls.Add(ReportBtn);
            Controls.Add(FortifyBtn);
            Controls.Add(CheckBtn);
            Controls.Add(BaselineList);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            RectColor = System.Drawing.Color.FromArgb(0, 150, 136);
            Style = Sunny.UI.UIStyle.Custom;
            Text = "Windows基线检测加固助手";
            TitleColor = System.Drawing.Color.FromArgb(0, 150, 136);
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)BaselineList).EndInit();
            uiContextMenuStrip.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView BaselineList;
        private Sunny.UI.UISymbolButton CheckBtn;
        private Sunny.UI.UISymbolButton FortifyBtn;
        private Sunny.UI.UISymbolButton ReportBtn;
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
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel OSNameLabel;
        private Sunny.UI.UICheckBox checkAllCheckBox;
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
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton Tipbtn;
        private Sunny.UI.UIButton Logbtn;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UIComboBox IpListComboBox;
        private Sunny.UI.UIAvatar BlogAvatar;
        private Sunny.UI.UIAvatar RepoAvatar;
    }
}