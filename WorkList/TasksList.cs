using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkList.TaskElemets;

namespace WorkList
{
    public partial class TasksList : Form
    {
        static int counterRow = 2;
        static int counterPosition = 0;
        public TasksList()
        {
            InitializeComponent();

            TasksSource.services.SetLayoutPanelSize(tableLayoutPanel1);

            StartPosition = FormStartPosition.Manual;
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            //Перенос в нижний правый угол экрана без панели задач
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //Перенос в местоположение верхнего левого угла формы, чтобы её правый нижний угол попал в правый нижний угол экрана
            pt.Offset(-Width, -Height);
            //Новое положение формы
           Location = pt;

            TasksSource.tasks = TasksSource.services.LoadData();

            if (TasksSource.tasks.Count <=2)
            {

                tableLayoutPanel1.Controls.Add(label1, 0, 0);
                tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
                tableLayoutPanel1.Controls.Add(dateTimePicker1, 2, 0);
                tableLayoutPanel1.Controls.Add(label6, 3, 0);
                tableLayoutPanel1.Controls.Add(label2, 4, 0);
                tableLayoutPanel1.Controls.Add(checkBox1, 5, 0);


                tableLayoutPanel1.Controls.Add(label10, 0, 1);
                tableLayoutPanel1.Controls.Add(comboBox2, 1, 1);
                tableLayoutPanel1.Controls.Add(dateTimePicker2, 2, 1);
                tableLayoutPanel1.Controls.Add(label12, 3, 1);
                tableLayoutPanel1.Controls.Add(label11, 4, 1);
                tableLayoutPanel1.Controls.Add(checkBox2, 5, 1);
                //tableLayoutPanel1.Controls.RemoveAt(3);


                TasksSource.tasks.Add(new Tasks(label1.Text, comboBox1.SelectedItem, dateTimePicker1.Value, label6.Text, label2.Text, checkBox1.Checked));
                TasksSource.tasks.Add(new Tasks(label10.Text, comboBox2.SelectedItem, dateTimePicker2.Value, label12.Text, label11.Text, checkBox2.Checked));
            }
            else
            {
                TasksSource.services.InitPanel(tableLayoutPanel1, TasksSource.tasks);
            }
           
        }
        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            var label = (Label)sender;
            if (label.Tag != null)
                label.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).Tag = new object();
        }

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void tableLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(Label)))
                return;

            var draggedButton = (Label)e.Data.GetData(typeof(Label));

            //label2.Text = draggedButton.Text;
        }





        internal  void AddNewTasks(Elements elements)
        {
                    tableLayoutPanel1.Controls.Add(elements.label, 0, counterRow);
                    tableLayoutPanel1.Controls.Add(elements.comboBox, 1, counterRow);
                    tableLayoutPanel1.Controls.Add(elements.dateTimePicker, 2, counterRow);
                    tableLayoutPanel1.Controls.Add(elements.label1, 3, counterRow);
                    tableLayoutPanel1.Controls.Add(elements.label2, 4, counterRow);
                    tableLayoutPanel1.Controls.Add(elements.checkBox, 5, counterRow);
            counterRow++;
        }

        public void OtherInicialization(List<Tasks> tasks)
        {
            tableLayoutPanel1.Controls.Clear();
            BindingList<Tasks> Tasklist = new BindingList<Tasks>();

            foreach(var task in tasks)
            {
                Tasklist.Add(task);
            }
    
            TasksSource.services.InitPanel(tableLayoutPanel1, Tasklist);
        }
    }
}