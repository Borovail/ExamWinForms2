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
    public partial class CreateTasksForDays : Form
    {
        static int counterRow = 0;
        IOServices services;
        BindingList<Tasks> tasks;
        public CreateTasksForDays(string path)
        {
            InitializeComponent();
            services= new IOServices(path);
            tasks = new BindingList<Tasks>();
            services.SetLayoutPanelSize(tableLayoutPanel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            services.SaveData(tasks);
        }

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
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
        }

    }
}
