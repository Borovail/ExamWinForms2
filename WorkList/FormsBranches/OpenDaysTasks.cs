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
    public partial class OpenDaysTasks : Form
    {
        IOServices services;
        BindingList<Tasks> tasks;
        public OpenDaysTasks(string path)
        {
            InitializeComponent();
            services=new IOServices(path);
            tasks = services.LoadData();
            services.InitPanel(tableLayoutPanel1, tasks);
        }




    }
}
