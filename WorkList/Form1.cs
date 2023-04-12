using System.ComponentModel;
using System.Linq;
using WorkList.TaskElemets;

namespace WorkList
{
    public partial class Form1 : Form
    {
        static int counter1 = 0;
        static int counter2 = 0;
        Search search;
        TasksList _tasksList;
        public Form1()
        {
            InitializeComponent();
            TasksSource.tasks.ListChanged += Tasks_ListChanged;
        }

        private void Tasks_ListChanged(object? sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemAdded || e.ListChangedType == System.ComponentModel.ListChangedType.ItemDeleted)
            {
                if (search != null)
                {
                    search.InitSearchPanel();
                    _tasksList.BringToFront();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                SetPanels(taskListPanel);
        }

       

        private void _tasksList_FormClosed(object? sender, FormClosedEventArgs e)
        {
            counter1--;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {         
                SetPanels(searchPanel);      
                _tasksList=new TasksList();

           

            _tasksList.Show();
        }

        private void Search_FormClosed(object? sender, FormClosedEventArgs e)
        {
            counter2--;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(button1.Width+5, button1.Height+5);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetPanels(createTaskListPanel);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(162, 450);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetPanels(openTaskListPanel);
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

        private void startSearchButton_Click(object sender, EventArgs e)
        {
            List<Tasks> searchedTasks;
            if (textBox3.Text != "")
            {
                searchedTasks = TasksSource.tasks.Where(i => i.task == textBox3.Text && i.priority == comboBox1.SelectedItem && i.date == dateTimePicker1.Value && i.done == checkBox1.Checked).ToList();
            }
            else
            {
                searchedTasks = TasksSource.tasks.Where(i => i.priority == comboBox1.SelectedItem && i.date == dateTimePicker1.Value && i.done == checkBox1.Checked).ToList();
            }


            if (searchedTasks.Count != 0)
            {
            _tasksList.OtherInicialization(searchedTasks);
            }

        }



     
    }
}