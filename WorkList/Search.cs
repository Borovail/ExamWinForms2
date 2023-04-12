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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            TasksSource.services.SetLayoutPanelSize(tableLayoutPanel1);
            TasksSource.services.InitPanel(tableLayoutPanel1, TasksSource.tasks);
        }

     
        public void OtherInicialization(List<Tasks> tasks)
        {
            tableLayoutPanel1.Controls.Clear();   
            BindingList<Tasks> Tasklist = new BindingList<Tasks>();
        

            foreach (var task in tasks)
            {
                Tasklist.Add(task);
            }

            TasksSource.services.InitPanel(tableLayoutPanel1, Tasklist);
        }

    }
}
