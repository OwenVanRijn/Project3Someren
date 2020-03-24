﻿namespace SomerenUI
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
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomAllocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drankvoorraadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belastingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kassaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_viewmenu = new System.Windows.Forms.Panel();
            this.picturebox_logo = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.dg_viewmenu = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lv_viewmenu = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_rapport = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calc_rapport = new System.Windows.Forms.Button();
            this.cal_enddate = new System.Windows.Forms.MonthCalendar();
            this.cal_begindate = new System.Windows.Forms.MonthCalendar();
            this.lv_rapport = new System.Windows.Forms.ListView();
            this.pnl_belasting = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_4kwartaal = new System.Windows.Forms.RadioButton();
            this.rb_3kwartaal = new System.Windows.Forms.RadioButton();
            this.rb_2kwartaal = new System.Windows.Forms.RadioButton();
            this.rb_1kwartaal = new System.Windows.Forms.RadioButton();
            this.btn_berekenbelasting = new System.Windows.Forms.Button();
            this.label_keuze1 = new System.Windows.Forms.Label();
            this.lbl_belastingoverzicht = new System.Windows.Forms.Label();
            this.pnl_kassa = new System.Windows.Forms.Panel();
            this.lbl_kassa_status = new System.Windows.Forms.Label();
            this.btn_kassa_afrekenen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_KassaDrankjes = new System.Windows.Forms.ListView();
            this.lv_KassaStudenten = new System.Windows.Forms.ListView();
            this.pnl_activity = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_activity = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_activity_omschrijving = new System.Windows.Forms.TextBox();
            this.tb_activity_student_aantal = new System.Windows.Forms.TextBox();
            this.tb_activity_begeleider_aantal = new System.Windows.Forms.TextBox();
            this.btn_activity_edit = new System.Windows.Forms.Button();
            this.btn_activity_delete = new System.Windows.Forms.Button();
            this.lbl_activity_edit_status = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnl_dashboard.SuspendLayout();
            this.pnl_viewmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_viewmenu)).BeginInit();
            this.pnl_rapport.SuspendLayout();
            this.pnl_belasting.SuspendLayout();
            this.pnl_kassa.SuspendLayout();
            this.pnl_activity.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.interactToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 30);
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
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.roomAllocationToolStripMenuItem,
            this.drankvoorraadToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 28);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // roomAllocationToolStripMenuItem
            // 
            this.roomAllocationToolStripMenuItem.Name = "roomAllocationToolStripMenuItem";
            this.roomAllocationToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.roomAllocationToolStripMenuItem.Text = "Room Allocation";
            this.roomAllocationToolStripMenuItem.Click += new System.EventHandler(this.roomAllocationToolStripMenuItem_Click);
            // 
            // drankvoorraadToolStripMenuItem
            // 
            this.drankvoorraadToolStripMenuItem.Name = "drankvoorraadToolStripMenuItem";
            this.drankvoorraadToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.drankvoorraadToolStripMenuItem.Text = "Drankvoorraad";
            this.drankvoorraadToolStripMenuItem.Click += new System.EventHandler(this.drankvoorraadToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportToolStripMenuItem,
            this.belastingToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.calculateToolStripMenuItem.Text = "Calculate";
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.rapportToolStripMenuItem.Text = "Rapport";
            this.rapportToolStripMenuItem.Click += new System.EventHandler(this.rapportToolStripMenuItem_Click);
            // 
            // belastingToolStripMenuItem
            // 
            this.belastingToolStripMenuItem.Name = "belastingToolStripMenuItem";
            this.belastingToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.belastingToolStripMenuItem.Text = "Belasting";
            this.belastingToolStripMenuItem.Click += new System.EventHandler(this.belastingToolStripMenuItem_Click);
            // 
            // interactToolStripMenuItem
            // 
            this.interactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kassaToolStripMenuItem,
            this.activitiesToolStripMenuItem});
            this.interactToolStripMenuItem.Name = "interactToolStripMenuItem";
            this.interactToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.interactToolStripMenuItem.Text = "Interact";
            // 
            // kassaToolStripMenuItem
            // 
            this.kassaToolStripMenuItem.Name = "kassaToolStripMenuItem";
            this.kassaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kassaToolStripMenuItem.Text = "Kassa";
            this.kassaToolStripMenuItem.Click += new System.EventHandler(this.kassaToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // pnl_dashboard
            // 
            this.pnl_dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_dashboard.Location = new System.Drawing.Point(16, 33);
            this.pnl_dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_dashboard.Name = "pnl_dashboard";
            this.pnl_dashboard.Size = new System.Drawing.Size(1251, 575);
            this.pnl_dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(17, 16);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(243, 17);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnl_viewmenu
            // 
            this.pnl_viewmenu.Controls.Add(this.picturebox_logo);
            this.pnl_viewmenu.Controls.Add(this.label_title);
            this.pnl_viewmenu.Controls.Add(this.dg_viewmenu);
            this.pnl_viewmenu.Controls.Add(this.lv_viewmenu);
            this.pnl_viewmenu.Location = new System.Drawing.Point(12, 33);
            this.pnl_viewmenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_viewmenu.Name = "pnl_viewmenu";
            this.pnl_viewmenu.Size = new System.Drawing.Size(1255, 575);
            this.pnl_viewmenu.TabIndex = 4;
            // 
            // picturebox_logo
            // 
            this.picturebox_logo.Image = global::SomerenUI.Properties.Resources.someren;
            this.picturebox_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturebox_logo.InitialImage")));
            this.picturebox_logo.Location = new System.Drawing.Point(1077, 4);
            this.picturebox_logo.Margin = new System.Windows.Forms.Padding(4);
            this.picturebox_logo.Name = "picturebox_logo";
            this.picturebox_logo.Size = new System.Drawing.Size(173, 151);
            this.picturebox_logo.TabIndex = 0;
            this.picturebox_logo.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(13, 11);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(129, 33);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Students";
            // 
            // dg_viewmenu
            // 
            this.dg_viewmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_viewmenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.birth,
            this.room});
            this.dg_viewmenu.Location = new System.Drawing.Point(20, 64);
            this.dg_viewmenu.Margin = new System.Windows.Forms.Padding(4);
            this.dg_viewmenu.Name = "dg_viewmenu";
            this.dg_viewmenu.RowHeadersWidth = 51;
            this.dg_viewmenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_viewmenu.Size = new System.Drawing.Size(1021, 378);
            this.dg_viewmenu.TabIndex = 6;
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
            // lv_viewmenu
            // 
            this.lv_viewmenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.lv_viewmenu.HideSelection = false;
            this.lv_viewmenu.Location = new System.Drawing.Point(20, 64);
            this.lv_viewmenu.Margin = new System.Windows.Forms.Padding(4);
            this.lv_viewmenu.Name = "lv_viewmenu";
            this.lv_viewmenu.Size = new System.Drawing.Size(1020, 377);
            this.lv_viewmenu.TabIndex = 5;
            this.lv_viewmenu.UseCompatibleStateImageBehavior = false;
            this.lv_viewmenu.View = System.Windows.Forms.View.Details;
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
            // pnl_rapport
            // 
            this.pnl_rapport.Controls.Add(this.label3);
            this.pnl_rapport.Controls.Add(this.label2);
            this.pnl_rapport.Controls.Add(this.label1);
            this.pnl_rapport.Controls.Add(this.btn_calc_rapport);
            this.pnl_rapport.Controls.Add(this.cal_enddate);
            this.pnl_rapport.Controls.Add(this.cal_begindate);
            this.pnl_rapport.Controls.Add(this.lv_rapport);
            this.pnl_rapport.Location = new System.Drawing.Point(12, 30);
            this.pnl_rapport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_rapport.Name = "pnl_rapport";
            this.pnl_rapport.Size = new System.Drawing.Size(1259, 582);
            this.pnl_rapport.TabIndex = 5;
            this.pnl_rapport.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rapport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eind Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Begin datum";
            // 
            // btn_calc_rapport
            // 
            this.btn_calc_rapport.Location = new System.Drawing.Point(492, 313);
            this.btn_calc_rapport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_calc_rapport.Name = "btn_calc_rapport";
            this.btn_calc_rapport.Size = new System.Drawing.Size(225, 52);
            this.btn_calc_rapport.TabIndex = 3;
            this.btn_calc_rapport.Text = "Bereken Rapport";
            this.btn_calc_rapport.UseVisualStyleBackColor = true;
            this.btn_calc_rapport.Click += new System.EventHandler(this.btn_calc_rapport_Click);
            // 
            // cal_enddate
            // 
            this.cal_enddate.Location = new System.Drawing.Point(335, 59);
            this.cal_enddate.MaxSelectionCount = 1;
            this.cal_enddate.Name = "cal_enddate";
            this.cal_enddate.TabIndex = 2;
            // 
            // cal_begindate
            // 
            this.cal_begindate.Location = new System.Drawing.Point(44, 59);
            this.cal_begindate.MaxSelectionCount = 1;
            this.cal_begindate.Name = "cal_begindate";
            this.cal_begindate.TabIndex = 1;
            // 
            // lv_rapport
            // 
            this.lv_rapport.HideSelection = false;
            this.lv_rapport.Location = new System.Drawing.Point(668, 55);
            this.lv_rapport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_rapport.Name = "lv_rapport";
            this.lv_rapport.Size = new System.Drawing.Size(404, 207);
            this.lv_rapport.TabIndex = 0;
            this.lv_rapport.UseCompatibleStateImageBehavior = false;
            this.lv_rapport.View = System.Windows.Forms.View.List;
            // 
            // pnl_belasting
            // 
            this.pnl_belasting.Controls.Add(this.label11);
            this.pnl_belasting.Controls.Add(this.label10);
            this.pnl_belasting.Controls.Add(this.label9);
            this.pnl_belasting.Controls.Add(this.label8);
            this.pnl_belasting.Controls.Add(this.label7);
            this.pnl_belasting.Controls.Add(this.label6);
            this.pnl_belasting.Controls.Add(this.rb_4kwartaal);
            this.pnl_belasting.Controls.Add(this.rb_3kwartaal);
            this.pnl_belasting.Controls.Add(this.rb_2kwartaal);
            this.pnl_belasting.Controls.Add(this.rb_1kwartaal);
            this.pnl_belasting.Controls.Add(this.btn_berekenbelasting);
            this.pnl_belasting.Controls.Add(this.label_keuze1);
            this.pnl_belasting.Controls.Add(this.lbl_belastingoverzicht);
            this.pnl_belasting.Location = new System.Drawing.Point(9, 27);
            this.pnl_belasting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_belasting.Name = "pnl_belasting";
            this.pnl_belasting.Size = new System.Drawing.Size(1260, 585);
            this.pnl_belasting.TabIndex = 5;
            this.pnl_belasting.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(557, 126);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "€ 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(557, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "€ 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(557, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "€ 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Totale afdracht BTW:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Totaal 21% tarief:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Totaal 9% tarief:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rb_4kwartaal
            // 
            this.rb_4kwartaal.AutoSize = true;
            this.rb_4kwartaal.Location = new System.Drawing.Point(47, 151);
            this.rb_4kwartaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_4kwartaal.Name = "rb_4kwartaal";
            this.rb_4kwartaal.Size = new System.Drawing.Size(103, 21);
            this.rb_4kwartaal.TabIndex = 10;
            this.rb_4kwartaal.TabStop = true;
            this.rb_4kwartaal.Text = "4e Kwartaal";
            this.rb_4kwartaal.UseVisualStyleBackColor = true;
            // 
            // rb_3kwartaal
            // 
            this.rb_3kwartaal.AutoSize = true;
            this.rb_3kwartaal.Location = new System.Drawing.Point(47, 126);
            this.rb_3kwartaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_3kwartaal.Name = "rb_3kwartaal";
            this.rb_3kwartaal.Size = new System.Drawing.Size(103, 21);
            this.rb_3kwartaal.TabIndex = 9;
            this.rb_3kwartaal.TabStop = true;
            this.rb_3kwartaal.Text = "3e Kwartaal";
            this.rb_3kwartaal.UseVisualStyleBackColor = true;
            // 
            // rb_2kwartaal
            // 
            this.rb_2kwartaal.AutoSize = true;
            this.rb_2kwartaal.Location = new System.Drawing.Point(47, 100);
            this.rb_2kwartaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_2kwartaal.Name = "rb_2kwartaal";
            this.rb_2kwartaal.Size = new System.Drawing.Size(103, 21);
            this.rb_2kwartaal.TabIndex = 8;
            this.rb_2kwartaal.TabStop = true;
            this.rb_2kwartaal.Text = "2e Kwartaal";
            this.rb_2kwartaal.UseVisualStyleBackColor = true;
            // 
            // rb_1kwartaal
            // 
            this.rb_1kwartaal.AutoSize = true;
            this.rb_1kwartaal.Location = new System.Drawing.Point(47, 74);
            this.rb_1kwartaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_1kwartaal.Name = "rb_1kwartaal";
            this.rb_1kwartaal.Size = new System.Drawing.Size(103, 21);
            this.rb_1kwartaal.TabIndex = 7;
            this.rb_1kwartaal.TabStop = true;
            this.rb_1kwartaal.Text = "1e Kwartaal";
            this.rb_1kwartaal.UseVisualStyleBackColor = true;
            // 
            // btn_berekenbelasting
            // 
            this.btn_berekenbelasting.Location = new System.Drawing.Point(44, 186);
            this.btn_berekenbelasting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_berekenbelasting.Name = "btn_berekenbelasting";
            this.btn_berekenbelasting.Size = new System.Drawing.Size(227, 37);
            this.btn_berekenbelasting.TabIndex = 6;
            this.btn_berekenbelasting.Text = "Bereken belasting";
            this.btn_berekenbelasting.UseVisualStyleBackColor = true;
            this.btn_berekenbelasting.Click += new System.EventHandler(this.btn_berekenbelasting_Click);
            // 
            // label_keuze1
            // 
            this.label_keuze1.AutoSize = true;
            this.label_keuze1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keuze1.Location = new System.Drawing.Point(37, 31);
            this.label_keuze1.Name = "label_keuze1";
            this.label_keuze1.Size = new System.Drawing.Size(222, 31);
            this.label_keuze1.TabIndex = 4;
            this.label_keuze1.Text = "Keuze kwartaal ";
            // 
            // lbl_belastingoverzicht
            // 
            this.lbl_belastingoverzicht.AutoSize = true;
            this.lbl_belastingoverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_belastingoverzicht.Location = new System.Drawing.Point(397, 31);
            this.lbl_belastingoverzicht.Name = "lbl_belastingoverzicht";
            this.lbl_belastingoverzicht.Size = new System.Drawing.Size(139, 31);
            this.lbl_belastingoverzicht.TabIndex = 1;
            this.lbl_belastingoverzicht.Text = "Overzicht";
            this.lbl_belastingoverzicht.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_kassa
            // 
            this.pnl_kassa.Controls.Add(this.lbl_kassa_status);
            this.pnl_kassa.Controls.Add(this.btn_kassa_afrekenen);
            this.pnl_kassa.Controls.Add(this.label5);
            this.pnl_kassa.Controls.Add(this.label4);
            this.pnl_kassa.Controls.Add(this.lv_KassaDrankjes);
            this.pnl_kassa.Controls.Add(this.lv_KassaStudenten);
            this.pnl_kassa.Location = new System.Drawing.Point(9, 27);
            this.pnl_kassa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_kassa.Name = "pnl_kassa";
            this.pnl_kassa.Size = new System.Drawing.Size(1257, 581);
            this.pnl_kassa.TabIndex = 6;
            // 
            // lbl_kassa_status
            // 
            this.lbl_kassa_status.AutoSize = true;
            this.lbl_kassa_status.Location = new System.Drawing.Point(908, 484);
            this.lbl_kassa_status.Name = "lbl_kassa_status";
            this.lbl_kassa_status.Size = new System.Drawing.Size(66, 17);
            this.lbl_kassa_status.TabIndex = 5;
            this.lbl_kassa_status.Text = "Unknown";
            // 
            // btn_kassa_afrekenen
            // 
            this.btn_kassa_afrekenen.Location = new System.Drawing.Point(909, 505);
            this.btn_kassa_afrekenen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kassa_afrekenen.Name = "btn_kassa_afrekenen";
            this.btn_kassa_afrekenen.Size = new System.Drawing.Size(135, 50);
            this.btn_kassa_afrekenen.TabIndex = 4;
            this.btn_kassa_afrekenen.Text = "Afrekenen";
            this.btn_kassa_afrekenen.UseVisualStyleBackColor = true;
            this.btn_kassa_afrekenen.Click += new System.EventHandler(this.btn_kassa_afrekenen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Drankjes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Studenten";
            // 
            // lv_KassaDrankjes
            // 
            this.lv_KassaDrankjes.HideSelection = false;
            this.lv_KassaDrankjes.Location = new System.Drawing.Point(468, 89);
            this.lv_KassaDrankjes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_KassaDrankjes.Name = "lv_KassaDrankjes";
            this.lv_KassaDrankjes.Size = new System.Drawing.Size(433, 466);
            this.lv_KassaDrankjes.TabIndex = 1;
            this.lv_KassaDrankjes.UseCompatibleStateImageBehavior = false;
            this.lv_KassaDrankjes.View = System.Windows.Forms.View.Details;
            this.lv_KassaDrankjes.SelectedIndexChanged += new System.EventHandler(this.lv_KassaDrankjes_SelectedIndexChanged);
            // 
            // lv_KassaStudenten
            // 
            this.lv_KassaStudenten.HideSelection = false;
            this.lv_KassaStudenten.Location = new System.Drawing.Point(35, 89);
            this.lv_KassaStudenten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_KassaStudenten.Name = "lv_KassaStudenten";
            this.lv_KassaStudenten.Size = new System.Drawing.Size(396, 466);
            this.lv_KassaStudenten.TabIndex = 0;
            this.lv_KassaStudenten.UseCompatibleStateImageBehavior = false;
            this.lv_KassaStudenten.View = System.Windows.Forms.View.Details;
            this.lv_KassaStudenten.SelectedIndexChanged += new System.EventHandler(this.lv_KassaStudenten_SelectedIndexChanged);
            // 
            // pnl_activity
            // 
            this.pnl_activity.Controls.Add(this.label12);
            this.pnl_activity.Controls.Add(this.lv_activity);
            this.pnl_activity.Controls.Add(this.groupBox2);
            this.pnl_activity.Controls.Add(this.groupBox1);
            this.pnl_activity.Location = new System.Drawing.Point(4, 26);
            this.pnl_activity.Name = "pnl_activity";
            this.pnl_activity.Size = new System.Drawing.Size(1262, 585);
            this.pnl_activity.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_activity_edit_status);
            this.groupBox1.Controls.Add(this.btn_activity_delete);
            this.groupBox1.Controls.Add(this.btn_activity_edit);
            this.groupBox1.Controls.Add(this.tb_activity_begeleider_aantal);
            this.groupBox1.Controls.Add(this.tb_activity_student_aantal);
            this.groupBox1.Controls.Add(this.tb_activity_omschrijving);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(803, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Activity";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(803, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Activity";
            // 
            // lv_activity
            // 
            this.lv_activity.HideSelection = false;
            this.lv_activity.Location = new System.Drawing.Point(22, 65);
            this.lv_activity.Name = "lv_activity";
            this.lv_activity.Size = new System.Drawing.Size(519, 490);
            this.lv_activity.TabIndex = 2;
            this.lv_activity.UseCompatibleStateImageBehavior = false;
            this.lv_activity.View = System.Windows.Forms.View.Details;
            this.lv_activity.SelectedIndexChanged += new System.EventHandler(this.lv_activity_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 32);
            this.label12.TabIndex = 3;
            this.label12.Text = "Activities";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Omschrijving: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Studenten_Aantal: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "Begeleider_Aantal: ";
            // 
            // tb_activity_omschrijving
            // 
            this.tb_activity_omschrijving.Location = new System.Drawing.Point(142, 19);
            this.tb_activity_omschrijving.Name = "tb_activity_omschrijving";
            this.tb_activity_omschrijving.Size = new System.Drawing.Size(302, 22);
            this.tb_activity_omschrijving.TabIndex = 3;
            // 
            // tb_activity_student_aantal
            // 
            this.tb_activity_student_aantal.Location = new System.Drawing.Point(142, 45);
            this.tb_activity_student_aantal.Name = "tb_activity_student_aantal";
            this.tb_activity_student_aantal.Size = new System.Drawing.Size(302, 22);
            this.tb_activity_student_aantal.TabIndex = 4;
            // 
            // tb_activity_begeleider_aantal
            // 
            this.tb_activity_begeleider_aantal.Location = new System.Drawing.Point(142, 73);
            this.tb_activity_begeleider_aantal.Name = "tb_activity_begeleider_aantal";
            this.tb_activity_begeleider_aantal.Size = new System.Drawing.Size(302, 22);
            this.tb_activity_begeleider_aantal.TabIndex = 5;
            // 
            // btn_activity_edit
            // 
            this.btn_activity_edit.Location = new System.Drawing.Point(10, 203);
            this.btn_activity_edit.Name = "btn_activity_edit";
            this.btn_activity_edit.Size = new System.Drawing.Size(321, 34);
            this.btn_activity_edit.TabIndex = 6;
            this.btn_activity_edit.Text = "Edit";
            this.btn_activity_edit.UseVisualStyleBackColor = true;
            this.btn_activity_edit.Click += new System.EventHandler(this.btn_activity_edit_Click);
            // 
            // btn_activity_delete
            // 
            this.btn_activity_delete.Location = new System.Drawing.Point(337, 203);
            this.btn_activity_delete.Name = "btn_activity_delete";
            this.btn_activity_delete.Size = new System.Drawing.Size(107, 34);
            this.btn_activity_delete.TabIndex = 7;
            this.btn_activity_delete.Text = "Delete";
            this.btn_activity_delete.UseVisualStyleBackColor = true;
            this.btn_activity_delete.Click += new System.EventHandler(this.btn_activity_delete_Click);
            // 
            // lbl_activity_edit_status
            // 
            this.lbl_activity_edit_status.AutoSize = true;
            this.lbl_activity_edit_status.Location = new System.Drawing.Point(10, 183);
            this.lbl_activity_edit_status.Name = "lbl_activity_edit_status";
            this.lbl_activity_edit_status.Size = new System.Drawing.Size(58, 17);
            this.lbl_activity_edit_status.TabIndex = 8;
            this.lbl_activity_edit_status.Text = "Unkown";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 623);
            this.Controls.Add(this.pnl_activity);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_belasting);
            this.Controls.Add(this.pnl_rapport);
            this.Controls.Add(this.pnl_kassa);
            this.Controls.Add(this.pnl_viewmenu);
            this.Controls.Add(this.pnl_dashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.somerenUILoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_dashboard.ResumeLayout(false);
            this.pnl_dashboard.PerformLayout();
            this.pnl_viewmenu.ResumeLayout(false);
            this.pnl_viewmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_viewmenu)).EndInit();
            this.pnl_rapport.ResumeLayout(false);
            this.pnl_rapport.PerformLayout();
            this.pnl_belasting.ResumeLayout(false);
            this.pnl_belasting.PerformLayout();
            this.pnl_kassa.ResumeLayout(false);
            this.pnl_kassa.PerformLayout();
            this.pnl_activity.ResumeLayout(false);
            this.pnl_activity.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.Panel pnl_viewmenu;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox picturebox_logo;
        private System.Windows.Forms.ListView lv_viewmenu;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.DataGridView dg_viewmenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.Panel pnl_rapport;
        private System.Windows.Forms.ListView lv_rapport;
        private System.Windows.Forms.MonthCalendar cal_enddate;
        private System.Windows.Forms.MonthCalendar cal_begindate;
        private System.Windows.Forms.Button btn_calc_rapport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_belasting;
        private System.Windows.Forms.Button btn_berekenbelasting;
        private System.Windows.Forms.Label label_keuze1;
        private System.Windows.Forms.Label lbl_belastingoverzicht;
        private System.Windows.Forms.RadioButton rb_4kwartaal;
        private System.Windows.Forms.RadioButton rb_3kwartaal;
        private System.Windows.Forms.RadioButton rb_2kwartaal;
        private System.Windows.Forms.RadioButton rb_1kwartaal;
        private System.Windows.Forms.Panel pnl_kassa;
        private System.Windows.Forms.ListView lv_KassaDrankjes;
        private System.Windows.Forms.ListView lv_KassaStudenten;
        private System.Windows.Forms.Button btn_kassa_afrekenen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_kassa_status;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomAllocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drankvoorraadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem belastingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kassaToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_activity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lv_activity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_activity_begeleider_aantal;
        private System.Windows.Forms.TextBox tb_activity_student_aantal;
        private System.Windows.Forms.TextBox tb_activity_omschrijving;
        private System.Windows.Forms.Button btn_activity_delete;
        private System.Windows.Forms.Button btn_activity_edit;
        private System.Windows.Forms.Label lbl_activity_edit_status;
    }
}

