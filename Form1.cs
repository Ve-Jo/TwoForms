namespace TwoForms
{
    public partial class Form1 : Form
    {
        private Form2 childForm;

        public Form1()
        {
            InitializeComponent();
            childForm = new Form2(this);
            childForm.Show();
        }

        public void UpdateTextInChildForm(string text)
        {
            childForm.UpdateChildText(text);
            textBox1.Clear();
        }

        public void UpdateTextFromChildForm(string text)
        {
            textBox1.Text = text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateTextInChildForm(textBox1.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}