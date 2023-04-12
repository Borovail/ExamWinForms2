namespace WorkList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.taskListPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewTask = new System.Windows.Forms.TextBox();
            this.addNewTaskButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.startSearchButton = new System.Windows.Forms.Button();
            this.createTaskListPanel = new System.Windows.Forms.Panel();
            this.createDayTaskListButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openTaskListPanel = new System.Windows.Forms.Panel();
            this.openTaskListButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.taskListPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.createTaskListPanel.SuspendLayout();
            this.openTaskListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 55);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkLabel4);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 450);
            this.panel1.TabIndex = 1;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 290);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(130, 50);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Open Task List \r\non The Day";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Collapse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(3, 215);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(136, 50);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Create Task List \r\non The Day";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(3, 141);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(98, 25);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Find a Task";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 83);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 25);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Task List";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // taskListPanel
            // 
            this.taskListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskListPanel.Controls.Add(this.label5);
            this.taskListPanel.Controls.Add(this.textBox2);
            this.taskListPanel.Controls.Add(this.textBox1);
            this.taskListPanel.Controls.Add(this.label4);
            this.taskListPanel.Controls.Add(this.label3);
            this.taskListPanel.Controls.Add(this.NewTask);
            this.taskListPanel.Controls.Add(this.addNewTaskButton);
            this.taskListPanel.Location = new System.Drawing.Point(511, 174);
            this.taskListPanel.Name = "taskListPanel";
            this.taskListPanel.Size = new System.Drawing.Size(133, 155);
            this.taskListPanel.TabIndex = 2;
            this.taskListPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(313, 292);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 31);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 31);
            this.textBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Task";
            // 
            // NewTask
            // 
            this.NewTask.Location = new System.Drawing.Point(299, 57);
            this.NewTask.Name = "NewTask";
            this.NewTask.Size = new System.Drawing.Size(252, 31);
            this.NewTask.TabIndex = 11;
            // 
            // addNewTaskButton
            // 
            this.addNewTaskButton.Location = new System.Drawing.Point(122, 273);
            this.addNewTaskButton.Name = "addNewTaskButton";
            this.addNewTaskButton.Size = new System.Drawing.Size(125, 81);
            this.addNewTaskButton.TabIndex = 10;
            this.addNewTaskButton.Text = "Add new Task";
            this.addNewTaskButton.UseVisualStyleBackColor = true;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.startSearchButton);
            this.searchPanel.Controls.Add(this.createTaskListPanel);
            this.searchPanel.Controls.Add(this.dateTimePicker1);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.comboBox1);
            this.searchPanel.Controls.Add(this.checkBox1);
            this.searchPanel.Controls.Add(this.label6);
            this.searchPanel.Controls.Add(this.label7);
            this.searchPanel.Controls.Add(this.label8);
            this.searchPanel.Controls.Add(this.textBox3);
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Location = new System.Drawing.Point(155, 1);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(649, 437);
            this.searchPanel.TabIndex = 3;
            this.searchPanel.Visible = false;
            // 
            // startSearchButton
            // 
            this.startSearchButton.Location = new System.Drawing.Point(244, 375);
            this.startSearchButton.Name = "startSearchButton";
            this.startSearchButton.Size = new System.Drawing.Size(112, 34);
            this.startSearchButton.TabIndex = 21;
            this.startSearchButton.Text = "Find";
            this.startSearchButton.UseVisualStyleBackColor = true;
            this.startSearchButton.Click += new System.EventHandler(this.startSearchButton_Click);
            // 
            // createTaskListPanel
            // 
            this.createTaskListPanel.Controls.Add(this.createDayTaskListButton);
            this.createTaskListPanel.Controls.Add(this.label10);
            this.createTaskListPanel.Controls.Add(this.comboBoxDay);
            this.createTaskListPanel.Location = new System.Drawing.Point(531, 35);
            this.createTaskListPanel.Name = "createTaskListPanel";
            this.createTaskListPanel.Size = new System.Drawing.Size(83, 144);
            this.createTaskListPanel.TabIndex = 4;
            this.createTaskListPanel.Visible = false;
            // 
            // createDayTaskListButton
            // 
            this.createDayTaskListButton.Location = new System.Drawing.Point(253, 287);
            this.createDayTaskListButton.Name = "createDayTaskListButton";
            this.createDayTaskListButton.Size = new System.Drawing.Size(112, 34);
            this.createDayTaskListButton.TabIndex = 2;
            this.createDayTaskListButton.Text = "Create";
            this.createDayTaskListButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "What day do you want to set tasks for?";
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxDay.Location = new System.Drawing.Point(233, 124);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(182, 33);
            this.comboBoxDay.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(319, 295);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 4, 12, 11, 9, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 31);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(370, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 33);
            this.comboBox1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(212, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 29);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Done?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Task is ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Task priority";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Search Patterns";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 31);
            this.textBox3.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Task\'s name";
            // 
            // openTaskListPanel
            // 
            this.openTaskListPanel.Controls.Add(this.openTaskListButton);
            this.openTaskListPanel.Controls.Add(this.label11);
            this.openTaskListPanel.Controls.Add(this.comboBox2);
            this.openTaskListPanel.Location = new System.Drawing.Point(239, 36);
            this.openTaskListPanel.Name = "openTaskListPanel";
            this.openTaskListPanel.Size = new System.Drawing.Size(183, 73);
            this.openTaskListPanel.TabIndex = 5;
            this.openTaskListPanel.Visible = false;
            // 
            // openTaskListButton
            // 
            this.openTaskListButton.Location = new System.Drawing.Point(250, 306);
            this.openTaskListButton.Name = "openTaskListButton";
            this.openTaskListButton.Size = new System.Drawing.Size(112, 34);
            this.openTaskListButton.TabIndex = 5;
            this.openTaskListButton.Text = "Open";
            this.openTaskListButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(314, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "What day do you want to open tasks?";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBox2.Location = new System.Drawing.Point(222, 162);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 33);
            this.comboBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openTaskListPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.taskListPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.taskListPanel.ResumeLayout(false);
            this.taskListPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.createTaskListPanel.ResumeLayout(false);
            this.createTaskListPanel.PerformLayout();
            this.openTaskListPanel.ResumeLayout(false);
            this.openTaskListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private Label label1;
        private Panel taskListPanel;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private TextBox NewTask;
        private Button addNewTaskButton;
        private Panel searchPanel;
        private Button startSearchButton;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private Panel createTaskListPanel;
        private Button createDayTaskListButton;
        private Label label10;
        private ComboBox comboBoxDay;
        private LinkLabel linkLabel2;
        private Panel openTaskListPanel;
        private Button openTaskListButton;
        private Label label11;
        private ComboBox comboBox2;
    }
}