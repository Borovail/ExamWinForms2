using WorkList.TaskElemets;

namespace WorkList
{
    public partial class Form1 : Form
    {
        static int counter1 = 0;
        static int counter2 = 0;
        Search search;
        TasksList _tasksList;
        public Form1()
        {
            InitializeComponent();
            TasksSource.tasks.ListChanged += Tasks_ListChanged;
        }

        private void Tasks_ListChanged(object? sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemAdded || e.ListChangedType == System.ComponentModel.ListChangedType.ItemDeleted)
            {
                if (search != null)
                {
                    search.InitSearchPanel();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (counter1 != 1)
            {
                _tasksList = new TasksList();
                _tasksList.FormClosed += _tasksList_FormClosed;
                _tasksList.Show();
                counter1++;
            }
        }

       

        private void _tasksList_FormClosed(object? sender, FormClosedEventArgs e)
        {
            counter1--;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (counter2!= 1)
            {
                search=new Search();
                search.FormClosed += Search_FormClosed;
                search.Show();
                counter2++;
            }
           
        }

        private void Search_FormClosed(object? sender, FormClosedEventArgs e)
        {
            counter2--;
        }
    }
}