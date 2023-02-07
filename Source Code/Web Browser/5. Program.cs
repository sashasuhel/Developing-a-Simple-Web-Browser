
namespace Web_Browser
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //Its allows only a single instance of the WebBrowser to start 
            WebBrowser browser = new();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(ref browser));
        }
    }
}