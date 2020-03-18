using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void somerenUILoad(object sender, EventArgs e)
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
                List<Student> studentList = studService.getStudents();

                // clear the listview before filling it again
                listViewStudents.Clear();
                listViewStudents.Columns.Add("Name");
                listViewStudents.Columns.Add("ID");

                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(s.name);
                    li.SubItems.Add(s.number.ToString());
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

                RoomService roomService = new RoomService();
                List<Room> rooms = roomService.getRooms(false);

                listViewStudents.Clear();
                listViewStudents.Columns.Add("Number");
                listViewStudents.Columns.Add("Capacity");
                listViewStudents.Columns.Add("Type");

                foreach (Room r in rooms)
                {
                    ListViewItem li = new ListViewItem(r.number.ToString());
                    li.SubItems.Add(r.capacity.ToString());
                    li.SubItems.Add((r.type) ? "Student_Room" : "Teacher_Room");
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

                Lecturers_Service lectService = new Lecturers_Service();
                List<Lecturer> Lecturerslist = lectService.getLecturers();

                // clear the listview before filling it again
                listViewStudents.Clear();
                listViewStudents.Columns.Add("Name");
                listViewStudents.Columns.Add("ID");

                foreach (Lecturer l in Lecturerslist)
                {
                    ListViewItem li = new ListViewItem(l.name) ;
                    li.SubItems.Add(l.number.ToString());
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

                RoomService roomService = new RoomService();
                List<Room> roomList = roomService.getRooms(true);

                //TODO: Implement a base class to avoid these double foreach loops

                foreach (Room room in roomList)
                {
                    foreach (Student student in room.students)
                    {
                        dateGridStudents.Rows.Add(student.number, student.name, student.birthDate, room.number);
                    }

                    foreach (Lecturer lecturer in room.lecturers)
                    {
                        dateGridStudents.Rows.Add(lecturer.number, lecturer.name, "", room.number);
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
