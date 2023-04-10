namespace WorkList
{
    public partial class Form1 : Form
    {
        TasksList _tasksList=new TasksList();
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
            _tasksList.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}