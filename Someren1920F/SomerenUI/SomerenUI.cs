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
                // Manage panel view
                pnl_Students.Hide();
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if(panelName == "Students")
            {
                // Manage panels
                pnl_Students.Show();
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();

                // Manage panel sub view
                listViewStudents.Show();
                dateGridStudents.Hide();

                // Set panel title
                lbl_Students.Text = "Students";

                // Force elements to update mid run
                pnl_Students.Refresh();
                pnl_Dashboard.Refresh();
                img_Dashboard.Refresh();
                listViewStudents.Refresh();
                dateGridStudents.Refresh();
                lbl_Students.Refresh();

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
                // Manage panels
                pnl_Students.Show();
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();

                // Manage panel sub view
                listViewStudents.Show();
                dateGridStudents.Hide();

                // Set panel title
                lbl_Students.Text = "Rooms";

                // Force elements to update mid run
                pnl_Students.Refresh();
                pnl_Dashboard.Refresh();
                img_Dashboard.Refresh();
                listViewStudents.Refresh();
                dateGridStudents.Refresh();
                lbl_Students.Refresh();

                Room_Service room_Service = new Room_Service();
                List<Room> rooms = room_Service.GetRooms(false);

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
                // Manage panels
                pnl_Students.Show();
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();

                // Manage panel sub view
                listViewStudents.Show();
                dateGridStudents.Hide();

                // Set panel title
                lbl_Students.Text = "Lecturers";

                // Force elements to update mid run
                pnl_Students.Refresh();
                pnl_Dashboard.Refresh();
                img_Dashboard.Refresh();
                listViewStudents.Refresh();
                dateGridStudents.Refresh();
                lbl_Students.Refresh();

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

            else if (panelName == "Allocation")
            {
                // Manage panels
                pnl_Students.Show();
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();

                // Manage panel sub view
                listViewStudents.Hide();
                dateGridStudents.Show();

                // Set panel title
                lbl_Students.Text = "Allocation";

                // Force elements to update mid run
                pnl_Students.Refresh();
                pnl_Dashboard.Refresh();
                img_Dashboard.Refresh();
                listViewStudents.Refresh();
                dateGridStudents.Refresh();
                lbl_Students.Refresh();

                Room_Service RoomService = new Room_Service();
                List<Room> roomList = RoomService.GetRooms(true);

                //TODO: Implement a base class to avoid these double foreach loops

                foreach (Room room in roomList)
                {
                    foreach (Student student in room.Students)
                    {
                        dateGridStudents.Rows.Add(student.Number, student.Name, student.BirthDate, room.Number);
                    }

                    foreach (Lecturer lecturer in room.Lecturers)
                    {
                        dateGridStudents.Rows.Add(lecturer.Number, lecturer.Name, "", room.Number);
                    }
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

        private void llocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Allocation");
        }
    }
}
