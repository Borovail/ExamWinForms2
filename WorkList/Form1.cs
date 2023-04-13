using System.ComponentModel;
using System.Linq;
using WorkList.TaskElemets;
using Aspose.Words;
using System.Collections.Generic;

namespace WorkList
{
    public partial class Form1 : Form
    {
        static int counter1 = 0;
        static int counter2 = 0;
        static int counter3 = 0;
        static int counter4 = 0;

        Search _search;
        TasksList _tasksList;
        CreateTasksForDays _createTask ;
        OpenDaysTasks _openTask ;

        public Form1()
        {
            InitializeComponent();
            TasksSource.tasks.ListChanged += Tasks_ListChanged;
            comboBox2.Enter += ComboBox2_Enter;
            dateTimePickerOpen.Enter += DateTimePickerOpen_Enter;
            dateTimePickerCreate.Enter += DateTimePickerCreate_Enter;
            comboBoxDay.Enter += ComboBoxDay_Enter;
        }

        private void ComboBoxDay_Enter(object? sender, EventArgs e)
        {
            label14.Visible = false;
        }

        private void DateTimePickerCreate_Enter(object? sender, EventArgs e)
        {
            label14.Visible = false;
        }

        private void DateTimePickerOpen_Enter(object? sender, EventArgs e)
        {
            label13.Visible = false;
        }

        private void ComboBox2_Enter(object? sender, EventArgs e)
        {
           label13.Visible= false;
        }






        ///////////////////Form1/////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(162, 450);
        }


        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(button1.Width, button1.Height);
        }
















        ///////////////////Form1/////////////////////////////







        ////////////////////////TaskList///////////////////////////////
        private async void addNewTaskButton_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Invoke(new Action(() =>
                {
                    Elements elements = new Elements();
                    elements.label.Text += textBoxNewTask.Text;
                    elements.comboBox.SelectedItem = comboBoxPriority.SelectedItem;
                    elements.label1.Text += textBoxTime.Text;
                    elements.label2.Text += textBoxComment.Text;
                    elements.checkBox.Checked = false;

                    _tasksList.AddNewTasks(elements);
                    TasksSource.services.SaveData(TasksSource.tasks);
                   

                }));
            });
           
        }








        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                SetPanels(taskListPanel);
            if (counter1 == 0)
            {
                _tasksList = new TasksList();
                _tasksList.Show();
                _tasksList.FormClosed += _tasksList_FormClosed1;
                counter1++;
            }
        }

        private void _tasksList_FormClosed1(object? sender, FormClosedEventArgs e)
        {
            TasksSource.services.SaveData(TasksSource.tasks);
            counter1--;
        }




      

















        ////////////////////////TaskList///////////////////////////////







        ////////////////////////Search//////////////////////////////////
        private  void startSearchButton_Click(object sender, EventArgs e)
        {
            Elements elements = new Elements();
            
            if (textBox3.Text != "" && comboBox1.SelectedItem.ToString() != "")
            {
                List<Tasks> searchedTasks = TasksSource.tasks.Where(i => i.task == TasksSource.label.Text + textBox3.Text && i.priority.ToString() == comboBox1.SelectedItem.ToString() && i.done == checkBox1.Checked).ToList();
                    if (searchedTasks.Count != 0)
                    {
                        _search.OtherInicialization(searchedTasks);
                    }
            }
            if (textBox3.Text != "")
            {
                List<Tasks> searchedTasks = TasksSource.tasks.Where(i => i.task == TasksSource.label.Text + textBox3.Text  && i.done == checkBox1.Checked).ToList();
                if (searchedTasks.Count != 0)
                {
                    _search.OtherInicialization(searchedTasks);
                }
            }
        }



        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                SetPanels(searchPanel);
            if (counter2 == 0)
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
            if (counter3 == 0)
            {


                string path = $"{Environment.CurrentDirectory}\\" + comboBoxDay.SelectedItem + dateTimePickerCreate.Value.ToString().Remove(10) + ".json";
                if (!File.Exists(path))
                {

                    _createTask = new CreateTasksForDays($"{Environment.CurrentDirectory}\\" + comboBoxDay.SelectedItem + dateTimePickerCreate.Value.ToString().Remove(10) + ".json");
                    _createTask.FormClosed += _createTask_FormClosed;
                    _createTask.Show();

                }
                else
                {
                    label14.Visible = true;
                    label14.Text = "That file already exists";
                }
                counter3++;
            }
        }

        private void _createTask_FormClosed(object? sender, FormClosedEventArgs e)
        {
            counter3--;
        }






        ////////////////////Create Task////////////////////////////////////






        //////////////////////////Open Task///////////////////////////////////
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetPanels(openTaskListPanel);
        }

        private void openTaskListButton_Click(object sender, EventArgs e)
        {
            if (counter4 == 0)
            {


                if (File.Exists($"{Environment.CurrentDirectory}\\" + comboBox2.SelectedItem + dateTimePickerOpen.Value.ToString().Remove(10) + ".json"))
                {
                    _openTask = new OpenDaysTasks($"{Environment.CurrentDirectory}\\" + comboBox2.SelectedItem + dateTimePickerOpen.Value.ToString().Remove(10) + ".json");
                    _openTask.FormClosed += _openTask_FormClosed;
                    _openTask.Show();
                }
                else
                {
                    label13.Visible = true;
                    label13.Text = "That file doesn't exist";
                }
                counter4++;
            }
        }

        private void _openTask_FormClosed(object? sender, FormClosedEventArgs e)
        {
            counter4--;
        }












        //////////////////////////Open Task///////////////////////////////////













        private void Tasks_ListChanged(object? sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemAdded || e.ListChangedType == System.ComponentModel.ListChangedType.ItemDeleted)
            {
                if (_search != null)
                {
                    TasksSource.services.SaveData(TasksSource.tasks);
                    _tasksList.BringToFront();
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

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var doc = new Document(TasksSource.Path);         
            if(File.Exists(TasksSource.Path.Remove(5) + ".pdf")) { File.Delete(TasksSource.Path.Remove(5) + ".pdf"); }
            doc.Save(TasksSource.Path.Remove(5) + ".pdf") ;
            MessageBox.Show("Pdf file succesfully created");
        }

      
    }
}