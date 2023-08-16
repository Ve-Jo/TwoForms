namespace TwoForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();

            form1.Show();

            Application.Run(); // Run the main message loop for the application
        }
    }
}


