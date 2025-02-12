namespace WinformTodo
{
    partial class TaskControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnComplete = new Button();
            label1 = new Label();
            label2 = new Label();
            lblTaskDescription = new Label();
            lblDueDate = new Label();
            SuspendLayout();
            // 
            // btnComplete
            // 
            btnComplete.AutoSize = true;
            btnComplete.Location = new Point(220, 122);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(99, 25);
            btnComplete.TabIndex = 0;
            btnComplete.Text = "Mark Complete";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Due Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "Description: ";
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTaskDescription.AutoSize = true;
            lblTaskDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaskDescription.Location = new Point(3, 41);
            lblTaskDescription.MaximumSize = new Size(294, 0);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(280, 50);
            lblTaskDescription.TabIndex = 3;
            lblTaskDescription.Text = "This is a description of a task to be done";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(69, 11);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(65, 15);
            lblDueDate.TabIndex = 4;
            lblDueDate.Text = "2025-01-01";
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(lblDueDate);
            Controls.Add(lblTaskDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnComplete);
            Name = "TaskControl";
            Size = new Size(326, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComplete;
        private Label label1;
        private Label label2;
        private Label lblTaskDescription;
        private Label lblDueDate;
    }
}
