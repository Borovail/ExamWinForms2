using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WorkList.TaskElemets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WorkList
{
    public partial class TasksList : Form
    {

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
            pt.Offset(-Width-200, -Height-900);
            //Новое положение формы
            Location = pt;

            TasksSource.tasks = TasksSource.services.LoadData();

            if (TasksSource.tasks == null)
            {
                TasksSource.tasks = new BindingList<Tasks>();
                TasksSource.elements = new BindingList<Elements>();


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
                TasksSource.elements.Add(new Elements(label1, comboBox1, dateTimePicker1, label6, checkBox1, label2));
                TasksSource.elements.Add(new Elements(label10, comboBox2, dateTimePicker2, label12, checkBox2, label11));
            }
            else
            {
                for (int i = 0; i < TasksSource.tasks.Count; i++)
                {



                    Elements elements = new Elements();
                    elements.label.Text = TasksSource.tasks[i].task;
                    elements.comboBox.SelectedItem = TasksSource.tasks[i].priority;
                    elements.label1.Text = TasksSource.tasks[i].time;
                    elements.label2.Text = TasksSource.tasks[i].comment;
                    elements.checkBox.Checked = TasksSource.tasks[i].done;

                    elements.label.TabIndex = i;
                    elements.comboBox.TabIndex = i;
                    elements.label1.TabIndex = i;
                    elements.label2.TabIndex = i;
                    elements.checkBox.TabIndex = i;
                    elements.dateTimePicker.TabIndex = i;



                    elements.label.DragEnter += Label_DragEnter;
                    elements.label.MouseMove += Label_MouseMove;
                    elements.label.MouseDown += Label_MouseDown;
                    elements.comboBox.SelectedValueChanged += ComboBox_SelectedValueChanged;
                    elements.dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
                    elements.checkBox.CheckedChanged += CheckBox_CheckedChanged;

                    tableLayoutPanel1.Controls.Add(elements.label, 0, i);
                    tableLayoutPanel1.Controls.Add(elements.comboBox, 1, i);
                    tableLayoutPanel1.Controls.Add(elements.dateTimePicker, 2, i);
                    tableLayoutPanel1.Controls.Add(elements.label1, 3, i);
                    tableLayoutPanel1.Controls.Add(elements.label2, 4, i);
                    tableLayoutPanel1.Controls.Add(elements.checkBox, 5, i);

                    TasksSource.elements.Add(elements);

                }
                TasksSource.counter = TasksSource.tasks.Count;
            }
            
        }



        internal   void AddNewTasks(Elements elements)
        {
           
            elements.label.DragEnter += Label_DragEnter;
            elements.label.MouseMove += Label_MouseMove;
            elements.label.MouseDown += Label_MouseDown;
            elements.comboBox.SelectedValueChanged += ComboBox_SelectedValueChanged;
            elements.dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
            elements.checkBox.CheckedChanged += CheckBox_CheckedChanged;
                    tableLayoutPanel1.Controls.Add(elements.label, 0, TasksSource.counter);
                    tableLayoutPanel1.Controls.Add(elements.comboBox, 1, TasksSource.counter);
                    tableLayoutPanel1.Controls.Add(elements.dateTimePicker, 2, TasksSource.counter);
                    tableLayoutPanel1.Controls.Add(elements.label1, 3, TasksSource.counter);
                    tableLayoutPanel1.Controls.Add(elements.label2, 4, TasksSource.counter);
                    tableLayoutPanel1.Controls.Add(elements.checkBox, 5, TasksSource.counter);

            TasksSource.counter++;
            TasksSource.tasks.Add(new Tasks(elements.label.Text, elements.comboBox.SelectedItem, elements.dateTimePicker.Value, elements.label1.Text, elements.label2.Text, false));
            TasksSource.elements.Add(elements);
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            TasksSource.tasks[((CheckBox)sender).TabIndex].done = ((CheckBox)sender).Checked;
        }

        private void DateTimePicker_ValueChanged(object? sender, EventArgs e)
        {
            TasksSource.tasks[((DateTimePicker)sender).TabIndex].date = ((DateTimePicker)sender).Value;
        }

        private void ComboBox_SelectedValueChanged(object? sender, EventArgs e)
        {
            TasksSource.tasks[((ComboBox)sender).TabIndex].priority = ((ComboBox)sender).SelectedItem;
        }

        private void Label_MouseDown(object? sender, MouseEventArgs e)
        {
            ((Label)sender).Tag = new object();
            TasksSource.SelectedElement = TasksSource.elements.Where(i => i.label.TabIndex == ((Label)sender).TabIndex).First();
            
        }
        
        private void Label_MouseMove(object? sender, MouseEventArgs e)
        {
            var label = ((Label)sender);
            if (label.Tag != null)
                label.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void Label_DragEnter(object? sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        public  void OtherInicialization(List<Tasks> tasks)
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