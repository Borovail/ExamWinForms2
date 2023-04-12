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

        public  void InitSearchPanel()
        {
            tableLayoutPanel1.Controls.Clear();
           
            TasksSource.services.InitPanel(tableLayoutPanel1,TasksSource.tasks);
        }


    }
}
