namespace TwoForms
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                parentForm.UpdateTextFromChildForm(textBox1.Text);
                textBox1.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void UpdateChildText(string text)
        {
            textBox1.Text = text;
        }
    }
}
