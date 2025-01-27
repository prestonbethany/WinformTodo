namespace WinformTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var date = DateTime.Parse(txtDueDate.Text);
            Todo myTodo = new Todo(txtTaskDescription.Text, date);

            lvTasks.Items.Add(myTodo.ToString());

            ClearForm();
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
    }
}
