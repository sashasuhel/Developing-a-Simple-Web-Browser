using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Web_Browser
{
    public partial class FavoriteForm : Form
    {
        private readonly WebBrowser browser;
        private readonly String url;
        private readonly String title;

        public FavoriteForm(ref WebBrowser browser, String url, String title)
        {
            InitializeComponent();
            this.browser = browser;
            this.url = url;
            this.title = title;
            tb2.Text = title;
            tb3.Text = url;
        }
        /// <summary>
        /// To pass the updated title and url from the tb2 and tb3 to the Browser class
        /// </summary>
        private void Savebtn_Click(object sender, EventArgs e)
        {
            // Since '|' is used as a split sign, the title cannot have this sign
            if (!UrlChecker(tb3.Text) || tb2.Text.Contains('#') || tb2.Text.Length == 0)
            {
                MessageBox.Show("Wrong Address or title contains \"#\" or title is empty", "Wrong", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            else
            {
                browser.EditFavoriteTitle(tb2.Text, tb3.Text, url);
                Close();
            }
        }
        private static bool UrlChecker(string input)
        {
            return Regex.IsMatch(input, "(https?)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]");
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
