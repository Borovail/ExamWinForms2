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
            StartPosition = FormStartPosition.Manual;
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            //Перенос в нижний правый угол экрана без панели задач
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //Перенос в местоположение верхнего левого угла формы, чтобы её правый нижний угол попал в правый нижний угол экрана
            pt.Offset(-Width, -Height);
            //Новое положение формы
            Location = pt;

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
