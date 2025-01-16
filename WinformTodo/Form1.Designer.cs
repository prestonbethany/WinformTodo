namespace WinformTodo
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
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            lblDueDate = new Label();
            textBox1 = new TextBox();
            lblTaskBox = new Label();
            txtTaskDescription = new TextBox();
            gbTaskList = new GroupBox();
            lvTasks = new ListView();
            groupBox1.SuspendLayout();
            gbTaskList.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lblDueDate);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblTaskBox);
            groupBox1.Controls.Add(txtTaskDescription);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 105);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Form";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(42, 74);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(123, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(6, 48);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(55, 15);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Due Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 45);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "2025-01-20";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 2;
            // 
            // lblTaskBox
            // 
            lblTaskBox.AutoSize = true;
            lblTaskBox.Location = new Point(6, 19);
            lblTaskBox.Name = "lblTaskBox";
            lblTaskBox.Size = new Size(30, 15);
            lblTaskBox.TabIndex = 1;
            lblTaskBox.Text = "Task";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(42, 16);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(156, 23);
            txtTaskDescription.TabIndex = 0;
            // 
            // gbTaskList
            // 
            gbTaskList.Controls.Add(lvTasks);
            gbTaskList.Location = new Point(12, 123);
            gbTaskList.Name = "gbTaskList";
            gbTaskList.Size = new Size(204, 365);
            gbTaskList.TabIndex = 1;
            gbTaskList.TabStop = false;
            gbTaskList.Text = "Task List";
            // 
            // lvTasks
            // 
            lvTasks.Location = new Point(0, 22);
            lvTasks.Name = "lvTasks";
            lvTasks.Size = new Size(204, 343);
            lvTasks.TabIndex = 0;
            lvTasks.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 500);
            Controls.Add(gbTaskList);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbTaskList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTaskBox;
        private TextBox txtTaskDescription;
        private Label lblDueDate;
        private TextBox textBox1;
        private Button btnAdd;
        private Button btnClear;
        private GroupBox gbTaskList;
        private ListView lvTasks;
    }
}
