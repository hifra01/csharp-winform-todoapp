namespace TodoAppWinForm
{
    partial class TasksForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addTaskTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.tasksDataGridView = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addTaskTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tasksDataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasks";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add new task";
            // 
            // addTaskTextBox
            // 
            this.addTaskTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTaskTextBox.Location = new System.Drawing.Point(13, 321);
            this.addTaskTextBox.Name = "addTaskTextBox";
            this.addTaskTextBox.Size = new System.Drawing.Size(774, 31);
            this.addTaskTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(13, 358);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(774, 46);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tasksDataGridView
            // 
            this.tasksDataGridView.AllowUserToAddRows = false;
            this.tasksDataGridView.AllowUserToDeleteRows = false;
            this.tasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.IsDone,
            this.FinishButton,
            this.DeleteButton});
            this.tasksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksDataGridView.Location = new System.Drawing.Point(13, 38);
            this.tasksDataGridView.Name = "tasksDataGridView";
            this.tasksDataGridView.ReadOnly = true;
            this.tasksDataGridView.RowHeadersWidth = 62;
            this.tasksDataGridView.RowTemplate.Height = 33;
            this.tasksDataGridView.Size = new System.Drawing.Size(774, 252);
            this.tasksDataGridView.TabIndex = 5;
            this.tasksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tasksDataGridView_CellContentClick);
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.MinimumWidth = 8;
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            this.Task.Width = 150;
            // 
            // IsDone
            // 
            this.IsDone.HeaderText = "Finished?";
            this.IsDone.MinimumWidth = 8;
            this.IsDone.Name = "IsDone";
            this.IsDone.ReadOnly = true;
            this.IsDone.Width = 150;
            // 
            // FinishButton
            // 
            this.FinishButton.HeaderText = "Finish";
            this.FinishButton.MinimumWidth = 8;
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.ReadOnly = true;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseColumnTextForButtonValue = true;
            this.FinishButton.Width = 150;
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.MinimumWidth = 8;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TasksForm";
            this.Text = "To-do List";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox addTaskTextBox;
        private Button addButton;
        private DataGridView tasksDataGridView;
        private DataGridViewTextBoxColumn Task;
        private DataGridViewTextBoxColumn IsDone;
        private DataGridViewButtonColumn FinishButton;
        private DataGridViewButtonColumn DeleteButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
    }
}