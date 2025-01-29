namespace WinformTodo
{
    public partial class Form1 : Form
    {
        private List<Todo> TaskList { get; set; }

        public Form1()
        {
            InitializeComponent();
            TaskList = new List<Todo>();

        }

        private void submitForm(object sender, EventArgs e)
        {
            if (Validators.IsEmptyText(txtTaskDescription))
            {
                MessageBox.Show("Description is empty, please provide a description.");
                return;
            }

            if (Validators.IsTextNull(txtTaskDescription))
            {
                MessageBox.Show("How did you do that? You nulled the text box.");
                return;
            }
            
            if (Validators.IsEmptyText(txtDueDate))
            {
                MessageBox.Show("Missing a due date.");
                return;
            }

            if (!Validators.IsValidDate(txtDueDate))
            {
                MessageBox.Show("Date is incorrectly formatted, please resubmit."); 
            }

            var date = DateTime.Parse(txtDueDate.Text);
            Todo myTodo = new Todo(txtTaskDescription.Text, date);
            TaskList.Add(myTodo);

            UpdateListBox();
            //lbTaskList.Items.Add(myTodo.ToString());

            ClearForm();
        }

        public void UpdateListBox()
        {
            lbTaskList.Items.Clear();

            var tempList = TaskList.Where(t => t.IsDone == false)
                .OrderBy(t => t.DueDate)
                .ToList();
            
            for (int i = 0; i < tempList.Count; i++)
            {
                lbTaskList.Items.Add(tempList[i].ToString());
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("Form cleared.");
        }

        private void ClearForm()
        {
            txtTaskDescription.Clear();
            txtDueDate.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 )
            {
                submitForm(sender, e);
            }
        }
    }
}
