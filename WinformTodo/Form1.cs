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
            
            MessageBox.Show(myTodo.ToString());

        }
    }
}
