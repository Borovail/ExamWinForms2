using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkList
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        public TableLayoutPanel GetPanel()
        {
            tableLayoutPanel1.Controls.Clear();
            return tableLayoutPanel1;
        }

       
    }
}
