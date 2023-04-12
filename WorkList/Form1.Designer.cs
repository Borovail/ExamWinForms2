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
            this.openTaskListPanel = new System.Windows.Forms.Panel();
            this.openTaskListButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.taskListPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewTask = new System.Windows.Forms.TextBox();
            this.addNewTaskButton = new System.Windows.Forms.Button();
            this.createTaskListPanel = new System.Windows.Forms.Panel();
            this.createDayTaskListButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.startSearchButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.openTaskListPanel.SuspendLayout();
            this.taskListPanel.SuspendLayout();
            this.createTaskListPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
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
            // openTaskListPanel
            // 
            this.openTaskListPanel.Controls.Add(this.openTaskListButton);
            this.openTaskListPanel.Controls.Add(this.comboBox2);
            this.openTaskListPanel.Controls.Add(this.label11);
            this.openTaskListPanel.Location = new System.Drawing.Point(167, 255);
            this.openTaskListPanel.Name = "openTaskListPanel";
            this.openTaskListPanel.Size = new System.Drawing.Size(26, 67);
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
            this.comboBox2.Location = new System.Drawing.Point(225, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 33);
            this.comboBox2.TabIndex = 3;
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
            // taskListPanel
            // 
            this.taskListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskListPanel.Controls.Add(this.label12);
            this.taskListPanel.Controls.Add(this.comboBoxPriority);
            this.taskListPanel.Controls.Add(this.label5);
            this.taskListPanel.Controls.Add(this.textBoxComment);
            this.taskListPanel.Controls.Add(this.textBoxTime);
            this.taskListPanel.Controls.Add(this.label4);
            this.taskListPanel.Controls.Add(this.label3);
            this.taskListPanel.Controls.Add(this.textBoxNewTask);
            this.taskListPanel.Controls.Add(this.addNewTaskButton);
            this.taskListPanel.Location = new System.Drawing.Point(520, -1);
            this.taskListPanel.Name = "taskListPanel";
            this.taskListPanel.Size = new System.Drawing.Size(282, 55);
            this.taskListPanel.TabIndex = 2;
            this.taskListPanel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Priority for the Task";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "High",
            "Average",
            "Low"});
            this.comboBoxPriority.Location = new System.Drawing.Point(50, 55);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(134, 33);
            this.comboBoxPriority.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Comment:";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(33, 193);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(252, 31);
            this.textBoxComment.TabIndex = 15;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(378, 165);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(116, 31);
            this.textBoxTime.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 50);
            this.label4.TabIndex = 13;
            this.label4.Text = "Planned time for \r\nsolve the task";
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
            // textBoxNewTask
            // 
            this.textBoxNewTask.Location = new System.Drawing.Point(299, 57);
            this.textBoxNewTask.Name = "textBoxNewTask";
            this.textBoxNewTask.Size = new System.Drawing.Size(252, 31);
            this.textBoxNewTask.TabIndex = 11;
            // 
            // addNewTaskButton
            // 
            this.addNewTaskButton.Location = new System.Drawing.Point(230, 292);
            this.addNewTaskButton.Name = "addNewTaskButton";
            this.addNewTaskButton.Size = new System.Drawing.Size(125, 81);
            this.addNewTaskButton.TabIndex = 10;
            this.addNewTaskButton.Text = "Add new Task";
            this.addNewTaskButton.UseVisualStyleBackColor = true;
            this.addNewTaskButton.Click += new System.EventHandler(this.addNewTaskButton_Click);
            // 
            // createTaskListPanel
            // 
            this.createTaskListPanel.Controls.Add(this.createDayTaskListButton);
            this.createTaskListPanel.Controls.Add(this.label10);
            this.createTaskListPanel.Controls.Add(this.comboBoxDay);
            this.createTaskListPanel.Location = new System.Drawing.Point(182, 1);
            this.createTaskListPanel.Name = "createTaskListPanel";
            this.createTaskListPanel.Size = new System.Drawing.Size(620, 412);
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
            this.createDayTaskListButton.Click += new System.EventHandler(this.createDayTaskListButton_Click);
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
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.startSearchButton);
            this.searchPanel.Controls.Add(this.dateTimePicker1);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.comboBox1);
            this.searchPanel.Controls.Add(this.checkBox1);
            this.searchPanel.Controls.Add(this.label6);
            this.searchPanel.Controls.Add(this.label7);
            this.searchPanel.Controls.Add(this.label8);
            this.searchPanel.Controls.Add(this.textBox3);
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Location = new System.Drawing.Point(179, 212);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(34, 11);
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
            this.comboBox1.Items.AddRange(new object[] {
            "High",
            "Average",
            "Low"});
            this.comboBox1.Location = new System.Drawing.Point(370, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 33);
            this.comboBox1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(191, 299);
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
            this.label7.Location = new System.Drawing.Point(370, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Task priority";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sort Patterns";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openTaskListPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.createTaskListPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.taskListPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.openTaskListPanel.ResumeLayout(false);
            this.openTaskListPanel.PerformLayout();
            this.taskListPanel.ResumeLayout(false);
            this.taskListPanel.PerformLayout();
            this.createTaskListPanel.ResumeLayout(false);
            this.createTaskListPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
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
        private TextBox textBoxComment;
        private TextBox textBoxTime;
        private Label label4;
        private Label label3;
        private TextBox textBoxNewTask;
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
        private Label label12;
        private ComboBox comboBoxPriority;
    }
}