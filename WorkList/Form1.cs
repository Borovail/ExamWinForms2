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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Size = new System.Drawing.Size(162, 450);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(button1.Width+5, button1.Height+5);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (counter1 != 1)
            {
                _tasksList = new TasksList();
                _tasksList.FormClosed += _tasksList_FormClosed;
                _tasksList.BackColorChanged += _tasksList_BackColorChanged;
                _tasksList.Show();
                counter1++;
            }
        }

        private void _tasksList_BackColorChanged(object? sender, EventArgs e)
        {
            _tasksList.JoinPanels(search.GetPanel());
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
                _tasksList.JoinPanels(search.GetPanel());
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