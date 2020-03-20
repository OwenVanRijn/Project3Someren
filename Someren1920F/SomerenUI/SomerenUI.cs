
using SomerenLogic;
using SomerenModel;
using System;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
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

            switch (panelName)
            {
                case "students": 
                    label_title.Text = "Students";
                    listview_overview.Clear();

                    toggleDatalist();
                    forceRefresh();

                    listview_overview.Columns.Add("Name");
                    listview_overview.Columns.Add("ID");

                    foreach (Student student in studentService.getStudents())
                    {
                        ListViewItem li = new ListViewItem(student.name);
                        li.SubItems.Add(student.number.ToString());
                        listview_overview.Items.Add(li);
                    }

                    break;

                case "rooms":
                    label_title.Text = "Rooms";
                    listview_overview.Clear();

                    toggleDatalist();
                    forceRefresh();

                    listview_overview.Columns.Add("Number");
                    listview_overview.Columns.Add("Capacity");
                    listview_overview.Columns.Add("Type");

                    foreach (Room room in roomService.getRooms(false))
                    {
                        ListViewItem li = new ListViewItem(room.number.ToString());
                        li.SubItems.Add(room.capacity.ToString());
                        li.SubItems.Add((room.type) ? "Student_Room" : "Teacher_Room");
                        listview_overview.Items.Add(li);
                    }

                    break;

                case "lecturers":
                    label_title.Text = "Lecturers";
                    listview_overview.Clear();

                    toggleDatalist();
                    forceRefresh();

                    listview_overview.Columns.Add("Name");
                    listview_overview.Columns.Add("ID");

                    foreach (Lecturer lecturer in lecturerService.getLecturers())
                    {
                        ListViewItem li = new ListViewItem(lecturer.name) ;
                        li.SubItems.Add(lecturer.number.ToString());
                        listview_overview.Items.Add(li);
                    }

                    break;

                case "allocation":
                    label_title.Text = "Allocation";
                    datagrid_overview.ClearSelection();

                    toggleDatagrid();
                    forceRefresh();

                    listview_overview.Columns.Add("Name");
                    listview_overview.Columns.Add("ID");

                    // TODO: Remove double foreach loop if possible
                    foreach (Room room in roomService.getRooms(true))
                    {
                        foreach (Student student in room.students)
                        {
                            datagrid_overview.Rows.Add(student.number, student.name, student.birthDate, room.number);
                        }

                        foreach (Lecturer lecturer in room.lecturers)
                        {
                            datagrid_overview.Rows.Add(lecturer.number, lecturer.name, "", room.number);
                        }
                    }

                    break;

                case "drankvoorraad":
                    label_title.Text = "Drinks";
                    listview_overview.Clear();

                    toggleDatalist();
                    forceRefresh();

                    listview_overview.Columns.Add("Name");
                    listview_overview.Columns.Add("Amount");
                    listview_overview.Columns.Add("Price");
                    listview_overview.Columns.Add("BTW");

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
                        listview_overview.Items.Add(li);
                    }

                    break;
                case "kassa":
                    lbl_kassa_status.Text = "Bezig met laden...";
                    panel_dashboard_container.Hide();
                    panel_information_container.Hide();
                    pnl_belasting.Hide();
                    pnl_rapport.Hide();
                    pnl_kassa.Show();

                    lv_KassaDrankjes.Clear();
                    lv_KassaStudenten.Clear();
  
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
                    panel_dashboard_container.Hide();
                    panel_information_container.Hide();
                    pnl_belasting.Hide();
                    pnl_kassa.Hide();
                    pnl_rapport.Show();

                    lv_rapport.Clear();
                    lv_rapport.Refresh();

                    break;
                case "belasting":
                    
                    panel_dashboard_container.Hide();
                    panel_information_container.Hide();
                    pnl_rapport.Hide();
                    pnl_belasting.Show();

                    break;

                default:
                    toggleDashboard();
                    break;
            }
        }

        private void forceRefresh()
        {
            // Refresh panels
            panel_information_container.Refresh();
            panel_dashboard_container.Refresh();

            // Refresh dataview
            listview_overview.Refresh();
            datagrid_overview.Refresh();

            // Refresh title
            label_title.Refresh();
        }

        private void toggleDatagrid()
        {
            // Hide dashboard panel and show data panel
            panel_information_container.Show();
            panel_dashboard_container.Hide();
            

            // Show datagrid and hide listview
            listview_overview.Hide();
            datagrid_overview.Show();
            pnl_rapport.Hide();
            pnl_kassa.Hide();
        }

        private void toggleDatalist()
        {
            // Hide dashboard panel and show data panel
            panel_information_container.Show();
            panel_dashboard_container.Hide();

            // Show listview and hide datagrid
            listview_overview.Show();
            datagrid_overview.Hide();
            pnl_rapport.Hide();
            pnl_kassa.Hide();
        }

        private void toggleDashboard()
        {
            // Hide data panel and show dashboard panel
            panel_information_container.Hide();
            pnl_rapport.Hide();
            pnl_kassa.Hide();
            panel_dashboard_container.Show();
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

        private void llocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("allocation");
        }

        private void drankvoorraadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("drankvoorraad");
        }

        private void kassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("kassa");
        }

        private void datagrid_overview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kassaListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void afrekenen_Click(object sender, EventArgs e)
        {
             
        }

        private void rapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("rapport");
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

        private void belastingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("belasting");
        }

        private void btn_berekenbelasting_Click(object sender, EventArgs e)
        {
            btn_berekenbelasting.Enabled = false;
            tb_overzicht.Text = ($"totaal 6% tarief: ");
            tb_overzicht.Text = ($"totaal 21% tarief: ");
            tb_overzicht.Text = ($"totale afdracht btw periode: ");

            /*
            catch (Exception f)
            {
                lv_rapport.Items.Add("Invalid datum!");
                lv_rapport.Items.Add(f.Message);
            }
            */

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
    }
    
}
