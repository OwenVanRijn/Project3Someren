using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if(panelName == "Dashboard")
            {

                // hide all other panels
                pnl_Students.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if(panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();

                // show students
                pnl_Students.Show();

                lbl_Students.Text = "Students";

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Clear();
                listViewStudents.Columns.Add("Name");
                listViewStudents.Columns.Add("ID");

                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(s.Name);
                    li.SubItems.Add(s.Number.ToString());
                    listViewStudents.Items.Add(li);
                }
            }
            else if (panelName == "Rooms")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();

                // show students
                pnl_Students.Show();
                listViewStudents.Clear();

                lbl_Students.Text = "Rooms";

                Room_Service room_Service = new Room_Service();
                List<Room> rooms = room_Service.GetRooms();

                listViewStudents.Clear();
                listViewStudents.Columns.Add("Number");
                listViewStudents.Columns.Add("Capacity");
                listViewStudents.Columns.Add("Type");

                foreach (Room r in rooms)
                {
                    ListViewItem li = new ListViewItem(r.Number.ToString());
                    li.SubItems.Add(r.Capacity.ToString());
                    li.SubItems.Add((r.Type) ? "Student_Room" : "Teacher_Room");
                    listViewStudents.Items.Add(li);
                }
            }

            else if (panelName == "Lecturers")
            {
                                         
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();

                // show lecturers
                pnl_Students.Show();
                listViewStudents.Clear();

                lbl_Students.Text = "Lecturers";

                Lecturers_Service LectService = new Lecturers_Service();
                List<Lecturer> Lecturerslist = LectService.GetLecturers();

                // clear the listview before filling it again
                listViewStudents.Clear();
                listViewStudents.Columns.Add("Name");
                listViewStudents.Columns.Add("ID");

                foreach (Lecturer l in Lecturerslist)
                {
                    ListViewItem li = new ListViewItem(l.Name) ;
                    li.SubItems.Add(l.Number.ToString());
                    listViewStudents.Items.Add(li);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Lecturers");
        }
    }
}
