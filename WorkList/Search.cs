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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WorkList
{
    public partial class Search : Form
    {
        static int counter = 2;
        public Search()
        {
            InitializeComponent();
            TasksSource.services.SetLayoutPanelSize(tableLayoutPanel1);
            TasksSource.services.InitPanel(tableLayoutPanel1);
        }

        public  void InitSearchPanel()
        {
            tableLayoutPanel1.Controls.Clear();
           
                    TasksSource.services.InitPanel(tableLayoutPanel1);

            //Elements elements = new Elements();
            //DataContext = TasksSource.tasks[counter];

            //elements.label.DataBindings.Add("Text", TasksSource.tasks[counter], "task");
            //elements.comboBox.DataBindings.Add("SelectedItem", TasksSource.tasks[counter], "priority");
            //elements.dateTimePicker.DataBindings.Add("Value", TasksSource.tasks[counter], "date");
            //elements.label1.DataBindings.Add("Text", TasksSource.tasks[counter], "time");
            //elements.label2.DataBindings.Add("Text", TasksSource.tasks[counter], "comment");
            //elements.checkBox.DataBindings.Add("Checked", TasksSource.tasks[counter], "done");


            //tableLayoutPanel1.Controls.Add(elements.label, 0, counter);
            //tableLayoutPanel1.Controls.Add(elements.comboBox, 1, counter);
            //tableLayoutPanel1.Controls.Add(elements.dateTimePicker, 2, counter);
            //tableLayoutPanel1.Controls.Add(elements.label1, 3, counter);
            //tableLayoutPanel1.Controls.Add(elements.label2, 4, counter);
            //tableLayoutPanel1.Controls.Add(elements.checkBox, 5, counter);
        }


    }
}
