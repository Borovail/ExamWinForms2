using System.ComponentModel;
using System.Linq;
using WorkList.TaskElemets;

namespace WorkList
{
    public partial class Form1 : Form
    {
        static int counter1 = 0;
        static int counter2 = 0;
        Search _search;
        TasksList _tasksList;
        CreateTaskForDay _taskForDay ;
        OpenTaskForDay _openTask ;

        public Form1()
        {
            InitializeComponent();
            TasksSource.tasks.ListChanged += Tasks_ListChanged;
        }



        ///////////////////Form1/////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(162, 450);
        }


        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(button1.Width + 5, button1.Height + 5);
        }
















        ///////////////////Form1/////////////////////////////







        ////////////////////////TaskList///////////////////////////////
        private void addNewTaskButton_Click(object sender, EventArgs e)
        {

            Elements elements = new Elements();
            elements.label.Text += textBoxNewTask.Text;
            elements.comboBox.SelectedItem = comboBoxPriority.SelectedItem;
            elements.dateTimePicker.Value = dateTimePicker1.Value;
            elements.label1.Text += textBoxTime.Text;
            elements.label2.Text += textBoxComment.Text;
            elements.checkBox.Checked = false;

            _tasksList.AddNewTasks(elements);
            TasksSource.tasks.Add(new Tasks(textBoxNewTask.Text, comboBoxPriority.SelectedItem, dateTimePicker1.Value, textBoxTime.Text, textBoxComment.Text, false));
        }




    



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                SetPanels(taskListPanel);
            if (counter1 != 1)
            {
                _tasksList = new TasksList();
                _tasksList.Show();
                _tasksList.FormClosed += _tasksList_FormClosed1;
                counter1++;
            }
        }

        private void _tasksList_FormClosed1(object? sender, FormClosedEventArgs e)
        {
            counter1--;
        }




      

















        ////////////////////////TaskList///////////////////////////////







        ////////////////////////Search//////////////////////////////////
        private void startSearchButton_Click(object sender, EventArgs e)
        {
            List<Tasks> searchedTasks;

            searchedTasks = TasksSource.tasks.Where(i => i.task == textBox3.Text || i.priority == comboBox1.SelectedItem || i.date == dateTimePicker1.Value || i.done == checkBox1.Checked).ToList();

            if (searchedTasks.Count != 0)
            {
                _search.OtherInicialization(searchedTasks);
            }

        }



        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                SetPanels(searchPanel);
            if (counter2 != 1)
            {
                _search = new Search();
                _search.FormClosed += Search_FormClosed;
                _search.Show();
                counter2++;
            }
        }

        private void Search_FormClosed(object? sender, FormClosedEventArgs e)
        {
            counter2--;
        }














        ////////////////////////Search//////////////////////////////////











        ////////////////////Create Task////////////////////////////////////

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetPanels(createTaskListPanel);
        }

        private void createDayTaskListButton_Click(object sender, EventArgs e)
        {

        }








        ////////////////////Create Task////////////////////////////////////






        //////////////////////////Open Task///////////////////////////////////
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetPanels(openTaskListPanel);
        }














        //////////////////////////Open Task///////////////////////////////////













        private void Tasks_ListChanged(object? sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemAdded || e.ListChangedType == System.ComponentModel.ListChangedType.ItemDeleted)
            {
                if (_search != null)
                {
                    _tasksList.BringToFront();
                    TasksSource.services.SaveData(_tasksList);
                }
            }
        }

        private void SetPanels(Panel panel)
        {
            taskListPanel.Visible = false;
            searchPanel.Visible = false;
            createTaskListPanel.Visible = false;
            openTaskListPanel.Visible = false;
            panel.Location = new Point(158, -1);
            panel.Size = new Size(642, 450);
            panel.Visible = true;
        }

       
    }
}