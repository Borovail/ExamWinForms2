using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkList.TaskElemets
{
    internal class Elements
    {
        public Label label = new Label();
        public ComboBox comboBox = new ComboBox();
        public DateTimePicker dateTimePicker = new DateTimePicker();
        public Label label1 = new Label();
        public CheckBox checkBox = new CheckBox();
        public Label label2 = new Label();

        public Elements()
        {

            label.TabIndex = TasksSource.counter;
            comboBox.TabIndex = TasksSource.counter;
            dateTimePicker.TabIndex = TasksSource.counter;
            label1.TabIndex = TasksSource.counter;
            label2.TabIndex = TasksSource.counter;
            checkBox.TabIndex = TasksSource.counter;


            label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label.AutoSize = true;
            label.Name = "label";
            label.Size = new Size(0, 40);
            label.Text = "Task " + "\n";



            comboBox.Items.Add("High");
            comboBox.Items.Add("Average");
            comboBox.Items.Add("Low");
            comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox.FormattingEnabled = true;
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(100, 33);



            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.MinDate = new DateTime(2023, 4, 9, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 31);
            dateTimePicker.Value = new DateTime(2023, 4, 9, 13, 13, 39, 0);




            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Name = "labell";
            label1.Size = new Size(0, 40);
            label1.Text = "Planned time for \nsolve the task(min): \n";



            checkBox.Dock = DockStyle.Fill;
            checkBox.TextAlign = ContentAlignment.MiddleCenter;
            checkBox.AutoSize = true;
            checkBox.Location = new Point(741, 142);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(89, 29);
            checkBox.Text = "Done?";
            checkBox.UseVisualStyleBackColor = true;



            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Name = "labelll";
            label2.Size = new Size(0, 40);
            label2.Text = "Comments:\n";
        }

       public Elements(Label _label,ComboBox _comboBox ,DateTimePicker _dateTimePicker ,Label _label1 ,CheckBox _checkBox ,Label _label2 )
        {
            label = _label;
            comboBox = _comboBox;
            dateTimePicker= _dateTimePicker;
            label1= _label1;
            label2= _label2;
            checkBox= _checkBox;
        }
    }
}
