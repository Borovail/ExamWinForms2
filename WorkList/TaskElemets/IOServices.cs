using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkList.TaskElemets
{
    internal class IOServices
    {
        private readonly string _path;

        public IOServices(string path)
        {
            _path = path;
        }

        public BindingList<Tasks> LoadData()
        {
            if (!File.Exists(_path))
            {
                File.CreateText(_path).Dispose();
                return new BindingList<Tasks>();
            }

            using (var reader = File.OpenText(_path))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Tasks>>(fileText);
            }
        }

        public void SaveData<T>(T productsinfo)
        {
            using (StreamWriter writer = File.CreateText(_path))
            {
                string output = JsonConvert.SerializeObject(productsinfo);
                writer.WriteLine(output);
            }
        }


        public async void InitPanel(TableLayoutPanel tableLayoutPanel)
        {
            
                for (int i = 0; i < TasksSource.tasks.Count; i++)
                {
                    Elements elements = new Elements();

                    elements.label.Text = TasksSource.tasks[i].task;
                    elements.comboBox.SelectedItem = TasksSource.tasks[i].priority;
                    elements.dateTimePicker.Value = TasksSource.tasks[i].date;
                    elements.label1.Text = TasksSource.tasks[i].time;
                    elements.label2.Text = TasksSource.tasks[i].comment;
                    elements.checkBox.Checked = TasksSource.tasks[i].done;

                    tableLayoutPanel.Controls.Add(elements.label, 0, i);
                    tableLayoutPanel.Controls.Add(elements.comboBox, 1, i);
                    tableLayoutPanel.Controls.Add(elements.dateTimePicker, 2, i);
                    tableLayoutPanel.Controls.Add(elements.label1, 3, i);
                    tableLayoutPanel.Controls.Add(elements.label2, 4, i);
                    tableLayoutPanel.Controls.Add(elements.checkBox, 5, i);
                }
        }


        public void SetLayoutPanelSize(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.ColumnStyles[4].SizeType = SizeType.Absolute;
            tableLayoutPanel.ColumnStyles[4].Width = 120;
            tableLayoutPanel.ColumnStyles[5].SizeType = SizeType.Absolute;
            tableLayoutPanel.ColumnStyles[5].Width = 120;
            tableLayoutPanel.ColumnStyles[3].SizeType = SizeType.Absolute;
            tableLayoutPanel.ColumnStyles[3].Width = 200;
            tableLayoutPanel.ColumnStyles[2].SizeType = SizeType.Absolute;
            tableLayoutPanel.ColumnStyles[2].Width = 200;
            tableLayoutPanel.ColumnStyles[0].SizeType = SizeType.Absolute;
            tableLayoutPanel.ColumnStyles[0].Width = 250;
            //tableLayoutPanel.ColumnStyles[6].SizeType = SizeType.Absolute;
            //tableLayoutPanel.ColumnStyles[6].Width = 100;
        }

    }
}
