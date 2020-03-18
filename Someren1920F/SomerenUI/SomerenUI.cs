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
                studentsPanel.Hide();
                dashboardPanel.Show();
                imageDashboard.Show();
            }
            else if(panelName == "Students")
            {
                // Manage panels
                studentsPanel.Show();
                dashboardPanel.Hide();
                imageDashboard.Hide();

                // Manage panel sub view
                studentsListview.Show();
                studentsDatagrid.Hide();

                // Set panel title
                studentsHeader.Text = "Students";

                // Force elements to update mid run
                studentsPanel.Refresh();
                dashboardPanel.Refresh();
                imageDashboard.Refresh();
                studentsListview.Refresh();
                studentsDatagrid.Refresh();
                studentsHeader.Refresh();

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.getStudents();

                // clear the listview before filling it again
                studentsListview.Clear();
                studentsListview.Columns.Add("Name");
                studentsListview.Columns.Add("ID");

                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(s.name);
                    li.SubItems.Add(s.number.ToString());
                    studentsListview.Items.Add(li);
                }
            }
            else if (panelName == "Rooms")
            {
                // Manage panels
                studentsPanel.Show();
                dashboardPanel.Hide();
                imageDashboard.Hide();

                // Manage panel sub view
                studentsListview.Show();
                studentsDatagrid.Hide();

                // Set panel title
                studentsHeader.Text = "Rooms";

                // Force elements to update mid run
                studentsPanel.Refresh();
                dashboardPanel.Refresh();
                imageDashboard.Refresh();
                studentsListview.Refresh();
                studentsDatagrid.Refresh();
                studentsHeader.Refresh();

                RoomService roomService = new RoomService();
                List<Room> rooms = roomService.getRooms(false);

                studentsListview.Clear();
                studentsListview.Columns.Add("Number");
                studentsListview.Columns.Add("Capacity");
                studentsListview.Columns.Add("Type");

                foreach (Room r in rooms)
                {
                    ListViewItem li = new ListViewItem(r.number.ToString());
                    li.SubItems.Add(r.capacity.ToString());
                    li.SubItems.Add((r.type) ? "Student_Room" : "Teacher_Room");
                    studentsListview.Items.Add(li);
                }
            }

            else if (panelName == "Lecturers")
            {
                // Manage panels
                studentsPanel.Show();
                dashboardPanel.Hide();
                imageDashboard.Hide();

                // Manage panel sub view
                studentsListview.Show();
                studentsDatagrid.Hide();

                // Set panel title
                studentsHeader.Text = "Lecturers";

                // Force elements to update mid run
                studentsPanel.Refresh();
                dashboardPanel.Refresh();
                imageDashboard.Refresh();
                studentsListview.Refresh();
                studentsDatagrid.Refresh();
                studentsHeader.Refresh();

                Lecturers_Service lectService = new Lecturers_Service();
                List<Lecturer> Lecturerslist = lectService.getLecturers();

                // clear the listview before filling it again
                studentsListview.Clear();
                studentsListview.Columns.Add("Name");
                studentsListview.Columns.Add("ID");

                foreach (Lecturer l in Lecturerslist)
                {
                    ListViewItem li = new ListViewItem(l.name) ;
                    li.SubItems.Add(l.number.ToString());
                    studentsListview.Items.Add(li);
                }
            }

            else if (panelName == "Allocation")
            {
                // Manage panels
                studentsPanel.Show();
                dashboardPanel.Hide();
                imageDashboard.Hide();

                // Manage panel sub view
                studentsListview.Hide();
                studentsDatagrid.Show();

                // Set panel title
                studentsHeader.Text = "Allocation";

                // Force elements to update mid run
                studentsPanel.Refresh();
                dashboardPanel.Refresh();
                imageDashboard.Refresh();
                studentsListview.Refresh();
                studentsDatagrid.Refresh();
                studentsHeader.Refresh();

                RoomService roomService = new RoomService();
                List<Room> roomList = roomService.getRooms(true);

                //TODO: Implement a base class to avoid these double foreach loops

                foreach (Room room in roomList)
                {
                    foreach (Student student in room.students)
                    {
                        studentsDatagrid.Rows.Add(student.number, student.name, student.birthDate, room.number);
                    }

                    foreach (Lecturer lecturer in room.lecturers)
                    {
                        studentsDatagrid.Rows.Add(lecturer.number, lecturer.name, "", room.number);
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

        private void imageDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void studentsListview_SelectedIndexChanged(object sender, EventArgs e)
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
