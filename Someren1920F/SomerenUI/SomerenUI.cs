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
            ActivityService activityService = new ActivityService();
            BegeleiderService begeleiderService = new BegeleiderService();


            HideAll();
            forceRefresh();

            switch (panelName)
            {
                case "students":
                    Cursor.Current = Cursors.WaitCursor;

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

                    Cursor.Current = Cursors.Default;
                    break;

                case "rooms":
                    Cursor.Current = Cursors.WaitCursor;

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

                    Cursor.Current = Cursors.Default;
                    break;

                case "lecturers":
                    Cursor.Current = Cursors.WaitCursor;

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

                    Cursor.Current = Cursors.Default;
                    break;

                case "allocation":
                    Cursor.Current = Cursors.WaitCursor;

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

                    Cursor.Current = Cursors.Default;
                    break;

                case "drankvoorraad":
                    Cursor.Current = Cursors.WaitCursor;

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

                    Cursor.Current = Cursors.Default;
                    break;
                
                case "kassa":
                    Cursor.Current = Cursors.WaitCursor;

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

                    Cursor.Current = Cursors.Default;
                    break;
                case "activity":
                    pnl_activity.Show();
                    lv_activity_SelectedIndexChanged(null, null); //cheeky way to not duplicate code
                    tb_activity_create_begeleider_count.Text = "";
                    tb_activity_create_omschrijving.Text = "";
                    tb_activity_create_student_count.Text = "";

                    lv_activity.Columns.Add("Omschrijving");
                    lv_activity.Columns[0].Width *= 2;
                    lv_activity.Columns.Add("Studenten");
                    lv_activity.Columns.Add("Begeleiders");
                    lv_activity.Columns.Add("ID");

                    foreach (Activity activity in activityService.GetActivities())
                    {
                        ListViewItem li = new ListViewItem(activity.Omschrijving);
                        li.SubItems.Add(activity.AantalStudenten.ToString());
                        li.SubItems.Add(activity.AantalBegeleiders.ToString());
                        li.SubItems.Add(activity.Id.ToString());
                        lv_activity.Items.Add(li);
                    }

                    lbl_activity_edit_status.Text = "Ready!";
                    break;

                case "begeleiders":
                    pnl_begeleiders.Show();
                    lv_activity_SelectedIndexChanged(null, null);
                    tb_docentid.Text = "";
                    
                    lv_begeleiders.Columns.Add("ID");

                    foreach (Begeleider begeleider in begeleiderService.GetBegeleiders())
                    {
                        ListViewItem li = new ListViewItem(begeleider.DocentId.ToString());
                        lv_begeleiders.Items.Add(li);
                    }
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
            lv_activity.Clear();
            lv_begeleiders.Clear();
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
            pnl_activity.Hide();
            pnl_begeleiders.Hide();
        }

        private void btn_calc_rapport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

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

            Cursor.Current = Cursors.Default;
        }

        private void btn_berekenbelasting_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // Disable all user input
            btn_berekenbelasting.Enabled = false;
            rb_1kwartaal.Enabled = false;
            rb_2kwartaal.Enabled = false;
            rb_3kwartaal.Enabled = false;
            rb_4kwartaal.Enabled = false;

            DateTime current = DateTime.Today;
            DateTime start;
            DateTime end;

            if (rb_1kwartaal.Checked) {
                start = new DateTime(current.Year, 01, 01);
                end = new DateTime(current.Year, 03, 31);
            } else if (rb_2kwartaal.Checked) {
                start = new DateTime(current.Year, 04, 01);
                end = new DateTime(current.Year, 06, 30);
            } else if (rb_3kwartaal.Checked) {
                start = new DateTime(current.Year, 07, 01);
                end = new DateTime(current.Year, 09, 30);
            } else {
                start = new DateTime(current.Year, 10, 01);
                end = new DateTime(current.Year, 12, 31);
            }

            OrderDrinkDAO oarderDrinkDAO = new OrderDrinkDAO();

            string drinks = oarderDrinkDAO.getProfit(9, start, end);
            string alchol = oarderDrinkDAO.getProfit(21, start, end);

            if (String.IsNullOrEmpty(drinks)) drinks = "0";
            if (String.IsNullOrEmpty(alchol)) alchol = "0";

            label9.Text = "€ " + Math.Round(Decimal.Parse(drinks), 2);
            label10.Text = "€ " + Math.Round(Decimal.Parse(alchol), 2);
            label11.Text = "€ " + Math.Round(Decimal.Parse(drinks) + Decimal.Parse(alchol), 2).ToString();

            // Disable all user input
            btn_berekenbelasting.Enabled = true;
            rb_1kwartaal.Enabled = true;
            rb_2kwartaal.Enabled = true;
            rb_3kwartaal.Enabled = true;
            rb_4kwartaal.Enabled = true;

            Cursor.Current = Cursors.Default;
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
            Cursor.Current = Cursors.WaitCursor;

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

            Cursor.Current = Cursors.Default;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("activity");
        }

        private void lv_activity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_activity.SelectedItems.Count > 1)
                lv_activity.SelectedItems[0].Selected = false;
            else if (lv_activity.SelectedItems.Count == 1)
            {
                tb_activity_begeleider_aantal.Enabled = true;
                tb_activity_omschrijving.Enabled = true;
                tb_activity_student_aantal.Enabled = true;
                btn_activity_delete.Enabled = true;
                btn_activity_edit.Enabled = true;

                tb_activity_omschrijving.Text = lv_activity.SelectedItems[0].SubItems[0].Text;
                tb_activity_student_aantal.Text = lv_activity.SelectedItems[0].SubItems[1].Text;
                tb_activity_begeleider_aantal.Text = lv_activity.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                tb_activity_begeleider_aantal.Enabled = false;
                tb_activity_omschrijving.Enabled = false;
                tb_activity_student_aantal.Enabled = false;
                btn_activity_delete.Enabled = false;
                btn_activity_edit.Enabled = false;

                tb_activity_omschrijving.Text = "";
                tb_activity_begeleider_aantal.Text = "";
                tb_activity_student_aantal.Text = "";
            }
        }

        private void btn_activity_edit_Click(object sender, EventArgs e)
        {
            ActivityService activityService = new ActivityService();
            btn_activity_delete.Enabled = false;
            btn_activity_edit.Enabled = false;

            try
            {
                activityService.EditActivity(
                   tb_activity_omschrijving.Text,
                   tb_activity_student_aantal.Text,
                   tb_activity_begeleider_aantal.Text,
                   lv_activity.SelectedItems[0].SubItems[3].Text
                );
                showPanel("activity");
            }
            catch(Exception f)
            {
                lbl_activity_edit_status.Text = $"Error: {f.Message}";
            }
        }

        private void btn_activity_delete_Click(object sender, EventArgs e)
        {
            ActivityService activityService = new ActivityService();
            btn_activity_delete.Enabled = false;
            btn_activity_edit.Enabled = false;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this activity?",
                "Confirm removal",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                activityService.DeleteActivity(lv_activity.SelectedItems[0].SubItems[3].Text);
                showPanel("activity");
            }
            else
            {
                btn_activity_delete.Enabled = true;
                btn_activity_edit.Enabled = true;
            }
        }

        private void btn_activity_create_Click(object sender, EventArgs e)
        {
            ActivityService activityService = new ActivityService();
            btn_activity_create.Enabled = false;

            try
            {
                activityService.AddActivity(tb_activity_create_omschrijving.Text, tb_activity_create_student_count.Text, tb_activity_create_begeleider_count.Text);
                showPanel("activity");
            }
            catch (Exception f)
            {
                lbl_activity_create_status.Text = $"Error: {f.Message}";
            }
            finally
            {
                btn_activity_create.Enabled = true;
            }
        }

        private void lv_begeleiders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_begeleiders.SelectedItems.Count > 1)
                lv_begeleiders.SelectedItems[0].Selected = false;
            else if (lv_begeleiders.SelectedItems.Count == 1)
            {
                btn_verwijderen_van_begeleiders.Enabled = true;
                btn_toevegen_aan_begeleiders.Enabled = true;
            }
            else
            {

                btn_verwijderen_van_begeleiders.Enabled = false;
                btn_toevegen_aan_begeleiders.Enabled = false;
            }
        }

        private void btn_toevegen_aan_begeleiders_Click(object sender, EventArgs e)
        {
            BegeleiderService begeleiderService = new BegeleiderService();
            begeleiderService.AddBegeleider(tb_docentid.Text);
        }

        private void btn_verwijderen_van_begeleiders_Click(object sender, EventArgs e)
        {
            BegeleiderService begeleiderService = new BegeleiderService();
            begeleiderService.DeleteBegeleider(lv_begeleiders.SelectedItems[0].Text);
        }

        private void begeleidersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("begeleiders");
        }
    }
    
}
