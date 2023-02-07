using System.Text.RegularExpressions;

namespace Web_Browser
{
    public partial class HomePageForm : Form
    {
        private readonly WebBrowser browser;
        public HomePageForm(ref WebBrowser browser)
        {
            InitializeComponent();
            this.browser = browser;
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        ///  To pass the updated homepage url from tb4 to the Browser class
        /// </summary>

        private void Savebtn_Click(object sender, EventArgs e)
        {
            String hyperlink = tb4.Text;
            if (!UrlChecker(hyperlink))
            {
                MessageBox.Show("Wrong Address", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                browser.SetHomePage(hyperlink);
                Close();
            }

        }
        private static bool UrlChecker(string input)
        {
            return Regex.IsMatch(input, "(https?)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]");
        }
    }
}
