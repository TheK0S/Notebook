using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DataClass.form1_main.Add(new Form1(0));
            DataClass.objectCounter++;
            Application.Run(DataClass.form1_main[0]);

        }
    }
}