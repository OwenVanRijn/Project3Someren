namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drankvoorraadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kassaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belastingAfdragenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_dashboard_container = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.panel_information_container = new System.Windows.Forms.Panel();
            this.afrekenen = new System.Windows.Forms.Button();
            this.kassaListView = new System.Windows.Forms.ListView();
            this.datagrid_overview = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listview_overview = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picturebox_logo = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.pnl_rapport = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calc_rapport = new System.Windows.Forms.Button();
            this.cal_enddate = new System.Windows.Forms.MonthCalendar();
            this.cal_begindate = new System.Windows.Forms.MonthCalendar();
            this.lv_rapport = new System.Windows.Forms.ListView();
            this.pnl_belasting = new System.Windows.Forms.Panel();
            this.tb_overzicht = new System.Windows.Forms.TextBox();
            this.lbl_belastingoverzicht = new System.Windows.Forms.Label();
            this.label_keuze1 = new System.Windows.Forms.Label();
            this.btn_berekenbelasting = new System.Windows.Forms.Button();
            this.rb_1kwartaal = new System.Windows.Forms.RadioButton();
            this.rb_2kwartaal = new System.Windows.Forms.RadioButton();
            this.rb_3kwartaal = new System.Windows.Forms.RadioButton();
            this.rb_4kwartaal = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panel_dashboard_container.SuspendLayout();
            this.panel_information_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_overview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).BeginInit();
            this.pnl_rapport.SuspendLayout();
            this.pnl_belasting.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.llocationToolStripMenuItem,
            this.drankvoorraadToolStripMenuItem,
            this.kassaToolStripMenuItem,
            this.rapportToolStripMenuItem,
            this.belastingAfdragenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1443, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // llocationToolStripMenuItem
            // 
            this.llocationToolStripMenuItem.Name = "llocationToolStripMenuItem";
            this.llocationToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.llocationToolStripMenuItem.Text = "Allocation";
            this.llocationToolStripMenuItem.Click += new System.EventHandler(this.llocationToolStripMenuItem_Click);
            // 
            // drankvoorraadToolStripMenuItem
            // 
            this.drankvoorraadToolStripMenuItem.Name = "drankvoorraadToolStripMenuItem";
            this.drankvoorraadToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.drankvoorraadToolStripMenuItem.Text = "Drankvoorraad";
            this.drankvoorraadToolStripMenuItem.Click += new System.EventHandler(this.drankvoorraadToolStripMenuItem_Click);
            // 
            // kassaToolStripMenuItem
            // 
            this.kassaToolStripMenuItem.Name = "kassaToolStripMenuItem";
            this.kassaToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.kassaToolStripMenuItem.Text = "Kassa";
            this.kassaToolStripMenuItem.Click += new System.EventHandler(this.kassaToolStripMenuItem_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.rapportToolStripMenuItem.Text = "Rapport";
            this.rapportToolStripMenuItem.Click += new System.EventHandler(this.rapportToolStripMenuItem_Click);
            // 
            // belastingAfdragenToolStripMenuItem
            // 
            this.belastingAfdragenToolStripMenuItem.Name = "belastingAfdragenToolStripMenuItem";
            this.belastingAfdragenToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.belastingAfdragenToolStripMenuItem.Text = "Belasting ";
            this.belastingAfdragenToolStripMenuItem.Click += new System.EventHandler(this.belastingToolStripMenuItem_Click);
            // 
            // panel_dashboard_container
            // 
            this.panel_dashboard_container.Controls.Add(this.lbl_Dashboard);
            this.panel_dashboard_container.Location = new System.Drawing.Point(18, 41);
            this.panel_dashboard_container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_dashboard_container.Name = "panel_dashboard_container";
            this.panel_dashboard_container.Size = new System.Drawing.Size(1407, 719);
            this.panel_dashboard_container.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(19, 20);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(275, 20);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // panel_information_container
            // 
            this.panel_information_container.Controls.Add(this.afrekenen);
            this.panel_information_container.Controls.Add(this.kassaListView);
            this.panel_information_container.Controls.Add(this.datagrid_overview);
            this.panel_information_container.Controls.Add(this.listview_overview);
            this.panel_information_container.Controls.Add(this.picturebox_logo);
            this.panel_information_container.Controls.Add(this.label_title);
            this.panel_information_container.Location = new System.Drawing.Point(14, 41);
            this.panel_information_container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_information_container.Name = "panel_information_container";
            this.panel_information_container.Size = new System.Drawing.Size(1412, 719);
            this.panel_information_container.TabIndex = 4;
            // 
            // afrekenen
            // 
            this.afrekenen.Location = new System.Drawing.Point(1007, 561);
            this.afrekenen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.afrekenen.Name = "afrekenen";
            this.afrekenen.Size = new System.Drawing.Size(165, 71);
            this.afrekenen.TabIndex = 8;
            this.afrekenen.Text = "Afrekenen";
            this.afrekenen.UseVisualStyleBackColor = true;
            this.afrekenen.Click += new System.EventHandler(this.afrekenen_Click);
            // 
            // kassaListView
            // 
            this.kassaListView.HideSelection = false;
            this.kassaListView.Location = new System.Drawing.Point(531, 80);
            this.kassaListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kassaListView.Name = "kassaListView";
            this.kassaListView.Size = new System.Drawing.Size(638, 470);
            this.kassaListView.TabIndex = 7;
            this.kassaListView.UseCompatibleStateImageBehavior = false;
            this.kassaListView.View = System.Windows.Forms.View.Details;
            this.kassaListView.Visible = false;
            // 
            // datagrid_overview
            // 
            this.datagrid_overview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_overview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.birth,
            this.room});
            this.datagrid_overview.Location = new System.Drawing.Point(22, 80);
            this.datagrid_overview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagrid_overview.Name = "datagrid_overview";
            this.datagrid_overview.RowHeadersWidth = 51;
            this.datagrid_overview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagrid_overview.Size = new System.Drawing.Size(1149, 472);
            this.datagrid_overview.TabIndex = 6;
            this.datagrid_overview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_overview_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // birth
            // 
            this.birth.HeaderText = "Date of Birth";
            this.birth.MinimumWidth = 6;
            this.birth.Name = "birth";
            this.birth.Width = 125;
            // 
            // room
            // 
            this.room.HeaderText = "Room";
            this.room.MinimumWidth = 6;
            this.room.Name = "room";
            this.room.ReadOnly = true;
            this.room.Width = 125;
            // 
            // listview_overview
            // 
            this.listview_overview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listview_overview.HideSelection = false;
            this.listview_overview.Location = new System.Drawing.Point(22, 80);
            this.listview_overview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listview_overview.Name = "listview_overview";
            this.listview_overview.Size = new System.Drawing.Size(1147, 470);
            this.listview_overview.TabIndex = 5;
            this.listview_overview.UseCompatibleStateImageBehavior = false;
            this.listview_overview.View = System.Windows.Forms.View.Details;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            this.studentID.Width = 100;
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            this.studentName.Width = 150;
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            this.studentDOB.Width = 186;
            // 
            // picturebox_logo
            // 
            this.picturebox_logo.Image = global::SomerenUI.Properties.Resources.someren;
            this.picturebox_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturebox_logo.InitialImage")));
            this.picturebox_logo.Location = new System.Drawing.Point(1212, 5);
            this.picturebox_logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picturebox_logo.Name = "picturebox_logo";
            this.picturebox_logo.Size = new System.Drawing.Size(195, 189);
            this.picturebox_logo.TabIndex = 0;
            this.picturebox_logo.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(15, 14);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(151, 39);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Students";
            // 
            // pnl_rapport
            // 
            this.pnl_rapport.Controls.Add(this.label3);
            this.pnl_rapport.Controls.Add(this.label2);
            this.pnl_rapport.Controls.Add(this.label1);
            this.pnl_rapport.Controls.Add(this.btn_calc_rapport);
            this.pnl_rapport.Controls.Add(this.cal_enddate);
            this.pnl_rapport.Controls.Add(this.cal_begindate);
            this.pnl_rapport.Controls.Add(this.lv_rapport);
            this.pnl_rapport.Location = new System.Drawing.Point(14, 36);
            this.pnl_rapport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_rapport.Name = "pnl_rapport";
            this.pnl_rapport.Size = new System.Drawing.Size(1416, 728);
            this.pnl_rapport.TabIndex = 5;
            this.pnl_rapport.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(755, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rapport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eind Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Begin datum";
            // 
            // btn_calc_rapport
            // 
            this.btn_calc_rapport.Location = new System.Drawing.Point(553, 391);
            this.btn_calc_rapport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_calc_rapport.Name = "btn_calc_rapport";
            this.btn_calc_rapport.Size = new System.Drawing.Size(253, 65);
            this.btn_calc_rapport.TabIndex = 3;
            this.btn_calc_rapport.Text = "Bereken Rapport";
            this.btn_calc_rapport.UseVisualStyleBackColor = true;
            this.btn_calc_rapport.Click += new System.EventHandler(this.btn_calc_rapport_Click);
            // 
            // cal_enddate
            // 
            this.cal_enddate.Location = new System.Drawing.Point(377, 74);
            this.cal_enddate.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.cal_enddate.MaxSelectionCount = 1;
            this.cal_enddate.Name = "cal_enddate";
            this.cal_enddate.TabIndex = 2;
            // 
            // cal_begindate
            // 
            this.cal_begindate.Location = new System.Drawing.Point(49, 74);
            this.cal_begindate.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.cal_begindate.MaxSelectionCount = 1;
            this.cal_begindate.Name = "cal_begindate";
            this.cal_begindate.TabIndex = 1;
            // 
            // lv_rapport
            // 
            this.lv_rapport.HideSelection = false;
            this.lv_rapport.Location = new System.Drawing.Point(751, 69);
            this.lv_rapport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_rapport.Name = "lv_rapport";
            this.lv_rapport.Size = new System.Drawing.Size(454, 258);
            this.lv_rapport.TabIndex = 0;
            this.lv_rapport.UseCompatibleStateImageBehavior = false;
            this.lv_rapport.View = System.Windows.Forms.View.List;
            // 
            // pnl_belasting
            // 
            this.pnl_belasting.Controls.Add(this.rb_4kwartaal);
            this.pnl_belasting.Controls.Add(this.rb_3kwartaal);
            this.pnl_belasting.Controls.Add(this.rb_2kwartaal);
            this.pnl_belasting.Controls.Add(this.rb_1kwartaal);
            this.pnl_belasting.Controls.Add(this.btn_berekenbelasting);
            this.pnl_belasting.Controls.Add(this.label_keuze1);
            this.pnl_belasting.Controls.Add(this.lbl_belastingoverzicht);
            this.pnl_belasting.Controls.Add(this.tb_overzicht);
            this.pnl_belasting.Location = new System.Drawing.Point(10, 34);
            this.pnl_belasting.Name = "pnl_belasting";
            this.pnl_belasting.Size = new System.Drawing.Size(1417, 731);
            this.pnl_belasting.TabIndex = 5;
            this.pnl_belasting.Visible = false;
            // 
            // tb_overzicht
            // 
            this.tb_overzicht.Location = new System.Drawing.Point(799, 85);
            this.tb_overzicht.Multiline = true;
            this.tb_overzicht.Name = "tb_overzicht";
            this.tb_overzicht.Size = new System.Drawing.Size(406, 340);
            this.tb_overzicht.TabIndex = 0;
            // 
            // lbl_belastingoverzicht
            // 
            this.lbl_belastingoverzicht.AutoSize = true;
            this.lbl_belastingoverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_belastingoverzicht.Location = new System.Drawing.Point(924, 43);
            this.lbl_belastingoverzicht.Name = "lbl_belastingoverzicht";
            this.lbl_belastingoverzicht.Size = new System.Drawing.Size(160, 37);
            this.lbl_belastingoverzicht.TabIndex = 1;
            this.lbl_belastingoverzicht.Text = "Overzicht";
            this.lbl_belastingoverzicht.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_keuze1
            // 
            this.label_keuze1.AutoSize = true;
            this.label_keuze1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keuze1.Location = new System.Drawing.Point(42, 43);
            this.label_keuze1.Name = "label_keuze1";
            this.label_keuze1.Size = new System.Drawing.Size(259, 37);
            this.label_keuze1.TabIndex = 4;
            this.label_keuze1.Text = "Keuze kwartaal ";
            // 
            // btn_berekenbelasting
            // 
            this.btn_berekenbelasting.Location = new System.Drawing.Point(49, 365);
            this.btn_berekenbelasting.Name = "btn_berekenbelasting";
            this.btn_berekenbelasting.Size = new System.Drawing.Size(341, 60);
            this.btn_berekenbelasting.TabIndex = 6;
            this.btn_berekenbelasting.Text = "Bereken Belasting over gekozen kwartaal";
            this.btn_berekenbelasting.UseVisualStyleBackColor = true;
            this.btn_berekenbelasting.Click += new System.EventHandler(this.btn_berekenbelasting_Click);
            // 
            // rb_1kwartaal
            // 
            this.rb_1kwartaal.AutoSize = true;
            this.rb_1kwartaal.Location = new System.Drawing.Point(49, 123);
            this.rb_1kwartaal.Name = "rb_1kwartaal";
            this.rb_1kwartaal.Size = new System.Drawing.Size(117, 24);
            this.rb_1kwartaal.TabIndex = 7;
            this.rb_1kwartaal.TabStop = true;
            this.rb_1kwartaal.Text = "1e Kwartaal";
            this.rb_1kwartaal.UseVisualStyleBackColor = true;
            // 
            // rb_2kwartaal
            // 
            this.rb_2kwartaal.AutoSize = true;
            this.rb_2kwartaal.Location = new System.Drawing.Point(49, 167);
            this.rb_2kwartaal.Name = "rb_2kwartaal";
            this.rb_2kwartaal.Size = new System.Drawing.Size(117, 24);
            this.rb_2kwartaal.TabIndex = 8;
            this.rb_2kwartaal.TabStop = true;
            this.rb_2kwartaal.Text = "2e Kwartaal";
            this.rb_2kwartaal.UseVisualStyleBackColor = true;
            // 
            // rb_3kwartaal
            // 
            this.rb_3kwartaal.AutoSize = true;
            this.rb_3kwartaal.Location = new System.Drawing.Point(49, 213);
            this.rb_3kwartaal.Name = "rb_3kwartaal";
            this.rb_3kwartaal.Size = new System.Drawing.Size(117, 24);
            this.rb_3kwartaal.TabIndex = 9;
            this.rb_3kwartaal.TabStop = true;
            this.rb_3kwartaal.Text = "3e Kwartaal";
            this.rb_3kwartaal.UseVisualStyleBackColor = true;
            // 
            // rb_4kwartaal
            // 
            this.rb_4kwartaal.AutoSize = true;
            this.rb_4kwartaal.Location = new System.Drawing.Point(49, 261);
            this.rb_4kwartaal.Name = "rb_4kwartaal";
            this.rb_4kwartaal.Size = new System.Drawing.Size(117, 24);
            this.rb_4kwartaal.TabIndex = 10;
            this.rb_4kwartaal.TabStop = true;
            this.rb_4kwartaal.Text = "4e Kwartaal";
            this.rb_4kwartaal.UseVisualStyleBackColor = true;
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 779);
            this.Controls.Add(this.pnl_belasting);
            this.Controls.Add(this.pnl_rapport);
            this.Controls.Add(this.panel_information_container);
            this.Controls.Add(this.panel_dashboard_container);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.somerenUILoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_dashboard_container.ResumeLayout(false);
            this.panel_dashboard_container.PerformLayout();
            this.panel_information_container.ResumeLayout(false);
            this.panel_information_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_overview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).EndInit();
            this.pnl_rapport.ResumeLayout(false);
            this.pnl_rapport.PerformLayout();
            this.pnl_belasting.ResumeLayout(false);
            this.pnl_belasting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel_dashboard_container;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel panel_information_container;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox picturebox_logo;
        private System.Windows.Forms.ListView listview_overview;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.ToolStripMenuItem llocationToolStripMenuItem;
        private System.Windows.Forms.DataGridView datagrid_overview;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.ToolStripMenuItem drankvoorraadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kassaToolStripMenuItem;
        private System.Windows.Forms.ListView kassaListView;
        private System.Windows.Forms.Button afrekenen;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_rapport;
        private System.Windows.Forms.ListView lv_rapport;
        private System.Windows.Forms.MonthCalendar cal_enddate;
        private System.Windows.Forms.MonthCalendar cal_begindate;
        private System.Windows.Forms.Button btn_calc_rapport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem belastingAfdragenToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_belasting;
        private System.Windows.Forms.Button btn_berekenbelasting;
        private System.Windows.Forms.Label label_keuze1;
        private System.Windows.Forms.Label lbl_belastingoverzicht;
        private System.Windows.Forms.TextBox tb_overzicht;
        private System.Windows.Forms.RadioButton rb_4kwartaal;
        private System.Windows.Forms.RadioButton rb_3kwartaal;
        private System.Windows.Forms.RadioButton rb_2kwartaal;
        private System.Windows.Forms.RadioButton rb_1kwartaal;
    }
}

