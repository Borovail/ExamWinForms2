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
    }
}
