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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkList
{
    public partial class CreateTasksForDays : Form
    {
        static int counterRow = 2;
        IOServices services;
        BindingList<Tasks> tasks;
        public CreateTasksForDays(string path)
        {
            InitializeComponent();
            services= new IOServices(path);
            tasks = new BindingList<Tasks>();
            services.SetLayoutPanelSize(tableLayoutPanel1);



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


            tasks.Add(new Tasks(label1.Text, comboBox1.SelectedItem, dateTimePicker1.Value, label6.Text, label2.Text, checkBox1.Checked));
            tasks.Add(new Tasks(label10.Text, comboBox2.SelectedItem, dateTimePicker2.Value, label12.Text, label11.Text, checkBox2.Checked));
            tasks.ListChanged += Tasks_ListChanged;
            services.SaveData(tasks);
        }

        private void Tasks_ListChanged(object? sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemAdded || e.ListChangedType == System.ComponentModel.ListChangedType.ItemDeleted)
            {             
                   services.SaveData(tasks); 
            }
        }

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (sender == null)
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            if (!e.Data.GetDataPresent(typeof(Label)))
                return;
            e.Effect = e.AllowedEffect;
        }

        private void tableLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
             if (!e.Data.GetDataPresent(typeof(Label)))
                return;

                tableLayoutPanel1.Controls.Add(TasksSource.SelectedElement.label, 0, counterRow);
                tableLayoutPanel1.Controls.Add(TasksSource.SelectedElement.comboBox, 1, counterRow);
                tableLayoutPanel1.Controls.Add(TasksSource.SelectedElement.dateTimePicker, 2, counterRow);
                tableLayoutPanel1.Controls.Add(TasksSource.SelectedElement.label1, 3, counterRow);
                tableLayoutPanel1.Controls.Add(TasksSource.SelectedElement.label2, 4, counterRow);
                tableLayoutPanel1.Controls.Add(TasksSource.SelectedElement.checkBox, 5, counterRow);
                counterRow++;
            tasks.Add(new Tasks(TasksSource.SelectedElement.label.Text, TasksSource.SelectedElement.comboBox.SelectedItem, TasksSource.SelectedElement.dateTimePicker.Value, TasksSource.SelectedElement.label1.Text, TasksSource.SelectedElement.label2.Text, TasksSource.SelectedElement.checkBox.Checked));

            sender = null;
            e.Effect = DragDropEffects.None;
            return;
        }

    }
}
