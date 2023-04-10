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
    public partial class TasksList : Form
    {
        static int counterRow = 2;
        static int counterPosition = 0;
        public BindingList<Tasks> tasks= new BindingList<Tasks>();

        public TasksList()
        {
            InitializeComponent();

            tableLayoutPanel1.ColumnStyles[4].SizeType = SizeType.Absolute;
            tableLayoutPanel1.ColumnStyles[4].Width = 120;
            tableLayoutPanel1.ColumnStyles[5].SizeType = SizeType.Absolute;
            tableLayoutPanel1.ColumnStyles[5].Width = 120;
            tableLayoutPanel1.ColumnStyles[3].SizeType = SizeType.Absolute;
            tableLayoutPanel1.ColumnStyles[3].Width = 200;
            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Absolute;
            tableLayoutPanel1.ColumnStyles[2].Width = 200;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
            tableLayoutPanel1.ColumnStyles[0].Width = 250;
            tableLayoutPanel1.ColumnStyles[6].SizeType = SizeType.Absolute;
            tableLayoutPanel1.ColumnStyles[6].Width = 100;


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


            tasks.Add(new Tasks(label1.Text, comboBox1.SelectedText, dateTimePicker1.Value, label6.Text, label2.Text, checkBox1.Checked));
            tasks.Add(new Tasks(label10.Text, comboBox2.SelectedText, dateTimePicker2.Value, label12.Text, label11.Text, checkBox2.Checked));

        }
        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            var label = (Label)sender;
            if (label.Tag != null)
                label.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).Tag = new object();
        }

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void tableLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(Label)))
                return;

            var draggedButton = (Label)e.Data.GetData(typeof(Label));

            //label2.Text = draggedButton.Text;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.Dock= DockStyle.Fill;
            Elements elements = new Elements();
            elements.label.Text = NewTask.Text;
            elements.label1.Text = textBox1.Text;
            elements.label2.Text = textBox2.Text;



            tableLayoutPanel1.Controls.Add(elements.label, 0, counterRow);
            tableLayoutPanel1.Controls.Add(elements.comboBox, 1, counterRow);
            tableLayoutPanel1.Controls.Add(elements.dateTimePicker, 2, counterRow);
            tableLayoutPanel1.Controls.Add(elements.label1, 3, counterRow);
            tableLayoutPanel1.Controls.Add(elements.label2, 4, counterRow);
            tableLayoutPanel1.Controls.Add(elements.checkBox, 5, counterRow);


            tasks.Add(new Tasks(elements.label.Text, elements.comboBox.SelectedText, elements.dateTimePicker.Value, label1.Text, label2.Text, elements.checkBox.Checked));

            counterRow++;
        }

        void OtherInicialization(BindingList<Tasks> _tasks)
        {
            tableLayoutPanel1.Controls.Clear();

            for (int i = 0; i < _tasks.Count; i++)
            {
                Elements elements = new Elements();

                elements.label.Text = _tasks[i].task;
                elements.comboBox.SelectedValue = _tasks[i].priority;
                elements.dateTimePicker.Value = _tasks[i].date;
                elements.label1.Text = _tasks[i].time;
                elements.label2.Text = _tasks[i].comment;
                elements.checkBox.Checked = _tasks[i].done;



                tableLayoutPanel1.Controls.Add(elements.label, 0, i);
                tableLayoutPanel1.Controls.Add(elements.comboBox, 1, i);
                tableLayoutPanel1.Controls.Add(elements.dateTimePicker, 2, i);
                tableLayoutPanel1.Controls.Add(elements.label1, 3, i);
                tableLayoutPanel1.Controls.Add(elements.label2, 4, i);
                tableLayoutPanel1.Controls.Add(elements.checkBox, 5, i);
            }
            

        }

    }
}