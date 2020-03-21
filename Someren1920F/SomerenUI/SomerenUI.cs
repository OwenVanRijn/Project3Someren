﻿
using SomerenDAL;
using SomerenLogic;
using SomerenModel;
using System;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public object ControlChars { get; private set; }

        static readonly string[] ignoredDrinks =
        {
            "Water",
            "Sinas",
            "Kersensap"
        };

        public SomerenUI()
        {
            InitializeComponent();
        }

        private void somerenUILoad(object sender, EventArgs e)
        {
            showPanel();
        }

        private void showPanel(string panelName = null)
        {
            // Added services to scope since two panels use the same service
            RoomService roomService = new RoomService();
            DrinkService drinkService = new DrinkService();
            StudentService studentService = new StudentService();
            LecturerService lecturerService = new LecturerService();

            HideAll();
            forceRefresh();

            switch (panelName)
            {
                case "students": 
                    label_title.Text = "Students";
                    pnl_viewmenu.Show();
                    lv_viewmenu.Show();

                    lv_viewmenu.Columns.Add("Name");
                    lv_viewmenu.Columns.Add("ID");

                    foreach (Student student in studentService.getStudents())
                    {
                        ListViewItem li = new ListViewItem(student.name);
                        li.SubItems.Add(student.number.ToString());
                        lv_viewmenu.Items.Add(li);
                    }

                    break;

                case "rooms":
                    label_title.Text = "Rooms";
                    pnl_viewmenu.Show();
                    lv_viewmenu.Show();

                    lv_viewmenu.Columns.Add("Number");
                    lv_viewmenu.Columns.Add("Capacity");
                    lv_viewmenu.Columns.Add("Type");

                    foreach (Room room in roomService.getRooms(false))
                    {
                        ListViewItem li = new ListViewItem(room.number.ToString());
                        li.SubItems.Add(room.capacity.ToString());
                        li.SubItems.Add((room.type) ? "Student_Room" : "Teacher_Room");
                        lv_viewmenu.Items.Add(li);
                    }

                    break;

                case "lecturers":
                    label_title.Text = "Lecturers";
                    pnl_viewmenu.Show();
                    lv_viewmenu.Show();

                    lv_viewmenu.Columns.Add("Name");
                    lv_viewmenu.Columns.Add("ID");

                    foreach (Lecturer lecturer in lecturerService.getLecturers())
                    {
                        ListViewItem li = new ListViewItem(lecturer.name) ;
                        li.SubItems.Add(lecturer.number.ToString());
                        lv_viewmenu.Items.Add(li);
                    }

                    break;

                case "allocation":
                    label_title.Text = "Allocation";
                    pnl_viewmenu.Show();
                    dg_viewmenu.Show();

                    lv_viewmenu.Columns.Add("Name");
                    lv_viewmenu.Columns.Add("ID");

                    // TODO: Remove double foreach loop if possible
                    foreach (Room room in roomService.getRooms(true))
                    {
                        foreach (Student student in room.students)
                        {
                            dg_viewmenu.Rows.Add(student.number, student.name, student.birthDate, room.number);
                        }

                        foreach (Lecturer lecturer in room.lecturers)
                        {
                            dg_viewmenu.Rows.Add(lecturer.number, lecturer.name, "", room.number);
                        }
                    }

                    break;

                case "drankvoorraad":
                    label_title.Text = "Drinks";
                    pnl_viewmenu.Show();
                    lv_viewmenu.Show();

                    lv_viewmenu.Columns.Add("Name");
                    lv_viewmenu.Columns.Add("Amount");
                    lv_viewmenu.Columns.Add("Price");
                    lv_viewmenu.Columns.Add("BTW");

                    foreach (Drink drink in drinkService.getDrinks())
                    {
                        bool isContinue = false;
                        foreach (string ignoreddrink in ignoredDrinks)
                            if (drink.name == ignoreddrink)
                                isContinue = true;

                        if (isContinue)
                            continue;
                                
                        ListViewItem li = new ListViewItem(drink.name);
                        li.SubItems.Add(drink.amount.ToString());
                        li.SubItems.Add(drink.price.ToString());
                        li.SubItems.Add(drink.btw.ToString());
                        lv_viewmenu.Items.Add(li);
                    }

                    break;
                case "kassa":
                    lbl_kassa_status.Text = "Bezig met laden...";
                    pnl_kassa.Show();
  
                    lv_KassaStudenten.Columns.Add("Name");
                    lv_KassaStudenten.Columns.Add("ID");

                    foreach (Student student in studentService.getStudents())
                    {
                        ListViewItem li = new ListViewItem(student.name);
                        li.SubItems.Add(student.number.ToString());
                     
                        lv_KassaStudenten.Items.Add(li);
                    }
                    lv_KassaDrankjes.Columns.Add("Name");
                    lv_KassaDrankjes.Columns.Add("Amount");
                    lv_KassaDrankjes.Columns.Add("Price");
                    lv_KassaDrankjes.Columns.Add("BTW");
                    lv_KassaDrankjes.Columns.Add("ID");

                    foreach (Drink drink in drinkService.getDrinks())
                    {
                        ListViewItem li = new ListViewItem(drink.name);
                        li.SubItems.Add(drink.amount.ToString());
                        li.SubItems.Add(drink.price.ToString());
                        li.SubItems.Add(drink.btw.ToString());
                        li.SubItems.Add(drink.id.ToString());
                        lv_KassaDrankjes.Items.Add(li);
                    }
                    lbl_kassa_status.Text = "Ready!";
                    break;
                case "rapport":
                    pnl_rapport.Show();

                    break;
                case "belasting":
                    pnl_belasting.Show();

                    break;
                default:
                    pnl_dashboard.Show();
                    break;
            }
        }

        private void forceRefresh()
        {
            /*
            // Refresh panels
            panel_information_container.Refresh();
            panel_dashboard_container.Refresh();

            // Refresh dataview
            listview_overview.Refresh();
            

            // Refresh title
            label_title.Refresh();
            */

            lv_viewmenu.Clear();
            dg_viewmenu.Rows.Clear();
            dg_viewmenu.Refresh();

            lv_KassaDrankjes.Clear();
            lv_KassaStudenten.Clear();
            lv_rapport.Clear();
        }

        private void HideAll()
        {
            pnl_viewmenu.Hide();
            pnl_dashboard.Hide();

            lv_viewmenu.Hide();
            dg_viewmenu.Hide();
            pnl_rapport.Hide();
            pnl_kassa.Hide();
            pnl_belasting.Hide();
        }

        private void btn_calc_rapport_Click(object sender, EventArgs e)
        {
            btn_calc_rapport.Enabled = false;
            OrderDrinkService orderDrinkService = new OrderDrinkService();
            lv_rapport.Clear();
            lv_rapport.Refresh();

            try
            {
                Rapport rapport = orderDrinkService.CreateReport(cal_begindate.SelectionStart, cal_enddate.SelectionStart);
                lv_rapport.Items.Add($"Afzet: {rapport.Afzet}");
                lv_rapport.Items.Add($"Omzet: {rapport.Omzet:0.00}");
                lv_rapport.Items.Add($"Klanten: {rapport.Klanten}");
            }
            catch (Exception f)
            {
                lv_rapport.Items.Add("Invalid datum!");
                lv_rapport.Items.Add(f.Message);
            }

            btn_calc_rapport.Enabled = true;
        }

        private void btn_berekenbelasting_Click(object sender, EventArgs e)
        {
            btn_berekenbelasting.Enabled = false;

            DateTime start;
            DateTime end;

            start = new DateTime();
            end = new DateTime();

            // I would use a switch but I'm very low on time so this will be a TODO - Schotsl
            if (rb_1kwartaal.Checked) {
                start = new DateTime(2020, 01, 01);
                end = new DateTime(2020, 03, 31);
            }

            if (rb_2kwartaal.Checked)
            {
                start = new DateTime(2020, 04, 01);
                end = new DateTime(2020, 06, 30);
            }

            if (rb_3kwartaal.Checked)
            {
                start = new DateTime(2020, 07, 01);
                end = new DateTime(2020, 09, 30);
            }

            if (rb_4kwartaal.Checked)
            {
                start = new DateTime(2020, 10, 01);
                end = new DateTime(2020, 12, 31);
            }

            OrderDrinkDAO oarderDrinkDAO = new OrderDrinkDAO();

            string drinks = oarderDrinkDAO.getProfit(9, start, end);
            string alchol = oarderDrinkDAO.getProfit(21, start, end);

            tb_overzicht.Text = "";
            tb_overzicht.Text += "Totaal 6% tarief: " + Math.Round(Decimal.Parse(drinks), 2);
            tb_overzicht.Text += Environment.NewLine;
            tb_overzicht.Text += "totaal 21% tarief: " + Math.Round(Decimal.Parse(alchol), 2);
            tb_overzicht.Text += Environment.NewLine;
            tb_overzicht.Text += "Totale afdracht BTW periode: " + Math.Round(Decimal.Parse(drinks) + Decimal.Parse(alchol), 2).ToString();


            btn_berekenbelasting.Enabled = true;
        }

        private void lv_KassaDrankjes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_KassaDrankjes.SelectedItems.Count > 1)
                lv_KassaDrankjes.SelectedItems[0].Selected = false;
        }

        private void lv_KassaStudenten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_KassaStudenten.SelectedItems.Count > 1)
                lv_KassaStudenten.SelectedItems[0].Selected = false;
        }

        private void btn_kassa_afrekenen_Click(object sender, EventArgs e)
        {
            btn_kassa_afrekenen.Enabled = false;

            if (lv_KassaStudenten.SelectedItems.Count != 1 || lv_KassaDrankjes.SelectedItems.Count != 1)
            {
                lbl_kassa_status.Text = "Error: Geen student of geen drankje geselecteerd!";
                btn_kassa_afrekenen.Enabled = true;
                return;
            }

            lbl_kassa_status.Text = "Bezig met order maken...";

            OrderDrinkService orderDrinkService = new OrderDrinkService();
            int drankid = int.Parse(lv_KassaDrankjes.SelectedItems[0].SubItems[4].Text);
            int studentid = int.Parse(lv_KassaStudenten.SelectedItems[0].SubItems[1].Text);
            orderDrinkService.AddOrder(studentid, drankid, 1);

            showPanel("kassa");
            btn_kassa_afrekenen.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("dashboard");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("students");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("rooms");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("lecturers");
        }

        private void roomAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("allocation");
        }

        private void drankvoorraadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("drankvoorraad");
        }

        private void rapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("rapport");
        }

        private void belastingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("belasting");
        }

        private void kassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("kassa");
        }
    }
    
}
