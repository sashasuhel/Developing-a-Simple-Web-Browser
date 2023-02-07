using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Web_Browser
{
#nullable disable
    public partial class MainForm : Form
    {
        public MainForm()
        {
            hisfeatures = new HistoryClass(this);
            favfeatures = new FavouriteClass(this);
            InitializeComponent();
        }
        public FavouriteClass Favourite
        {
            get { return favfeatures; }
        }

        public HistoryClass History
        {
            get { return hisfeatures; }
        }

        //Calling Dllimport library that contains methods to give form movable functionality 
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr one, int two, int three, int four);

        // X and Y are pointers used 
        public Point Pointerlocation;

        public WebBrowser browser;
        private readonly FavouriteClass favfeatures;
        private readonly HistoryClass hisfeatures;


        public MainForm(ref WebBrowser browser)
        {
            hisfeatures = new HistoryClass(this);
            favfeatures = new FavouriteClass(this);
            InitializeComponent();
            this.browser = browser;
            CallHistory();
            CallFavorites();
            // To load changed hist list
            browser.Changed += CallUrLtoHisList;
            // To load the changed event
            browser.Edited += EditFavoriteTools;
            NewUrlTab(ref browser, browser.GetDefaultPage());

        }

        public void NewUrlTab(ref WebBrowser browser, String url)
        {
            // To initialize a new TabManager
            TabManager page = new(ref browser, url);
            // To input the url into the Textbox 'tb1'
            tb1.Text = url;
            // To add a tab page 
            tabhead.TabPages.Add(page);
            // Switch to the TabManager
            tabhead.SelectedTab = page;
            // Adds the title of the tab to the label on top of the browser
            BrowserTitle.Text = page.LabelTitle;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            // closes the application
            this.Close();
        }

        private void Max_Click(object sender, EventArgs e)
        {
            // switch case used to maximize the screen or keep it at normal state
            WindowState = WindowState switch
            {
                FormWindowState.Normal => FormWindowState.Maximized,
                _ => FormWindowState.Normal,
            };
        }

        private void Min_Click(object sender, EventArgs e)
        {
            // Function to minimize the web browser
            WindowState = FormWindowState.Minimized;
        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            // Calling the method to help move the Web browser around the screen
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Forward button to go to the succeeding url from the current url if there is any
        /// </summary>
        private void Forward_Click(object sender, EventArgs e)
        {
            TabManager tabPage = (TabManager)tabhead.SelectedTab;
            tabPage.Forward();
            tb1.Text = tabPage.PullUrl();
            // Forward and Backward button only can be triggered if there are urls to shift betweeen back and forth from
            forbtn.Visible = tabPage.Index > 0;
            backbtn.Visible = tabPage.Index < tabPage.UrlList.Count - 1;

        }
        /// <summary>
        /// Button that goes to the previous url if there is any
        /// </summary>
        private void Back_Click(object sender, EventArgs e)
        {

            TabManager tabPage = (TabManager)tabhead.SelectedTab;
            tabPage.Back();
            tb1.Text = tabPage.PullUrl();
            //Forward button will only apprear if there is an index to go forward to 
            forbtn.Visible = tabPage.Index < tabPage.UrlList.Count - 1;
            //Back button will only appear if there is an index to go back to 
            backbtn.Visible = tabPage.Index > 0;
        }
        /// <summary>
        ///  To refresh a page 
        /// </summary>
        private void Reload_Click(object sender, EventArgs e)
        {
            TabManager temp = (TabManager)tabhead.SelectedTab;
            temp.Reload(temp.PullUrl());
            tb1.Text = temp.PullUrl();
        }
        /// <summary>
        /// The Default page that is set opens up whent he home buttton is clicked
        /// </summary>
        private void Home_Click(object sender, EventArgs e)
        {
            TabManager tabPage = new(ref browser, browser.GetDefaultPage());
            tabhead.TabPages.Add(tabPage);
            tabhead.SelectedTab = tabPage;
            tb1.Text = tabPage.PullUrl();
        }
        /// <summary>
        /// Setting a button for more additional options
        /// </summary>
        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            Settingsmenu.Visible = !Settingsmenu.Visible;
            favlist.Visible = false;
            hislist.Visible = false;
        }


        /// <summary>
        /// The home button will open up a form to set personalized default pages to load during start and access easily
        /// Will open the HomePage Form
        /// </summary>
        private void Setdefaultpage_Click(object sender, EventArgs e)
        {
            Settingsmenu.Visible = false;
            HomePageForm homepageForm = new(ref browser);
            homepageForm.ShowDialog();
        }
        /// <summary>
        ///  To add a tab to the tabhead
        /// </summary>
        private void AddTab_Click(object sender, EventArgs e)
        {
            TabManager page = new(ref browser);
            tabhead.TabPages.Add(page);
            page.Text = "Blank Page";
            tabhead.SelectedTab = page;
            tb1.Text = "";
            BrowserTitle.Text = "Blank Page";
        }
        /// <summary>
        ///  To delete the selected tab open
        /// </summary>
        private void DelTab_Click(object sender, EventArgs e)
        {
            // Will only delete the tab if the number of tabs open is greater than 1
            if (tabhead.TabPages.Count <= 1)
            {
                return;
            }
            tabhead.TabPages.Remove(tabhead.SelectedTab);
            tabhead.SelectedTab = tabhead.TabPages[^1];
            TabManager temp = (TabManager)tabhead.SelectedTab;
            tb1.Text = temp.PullUrl();

        }

        /// <summary>
        /// Setting changes depending on the tabhead
        /// </summary>
        private void Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabManager tabPage = (TabManager)tabhead.SelectedTab;
            backbtn.Visible = tabPage.Index > 0;
            forbtn.Visible = tabPage.Index < tabPage.UrlList.Count - 1;
            tb1.Text = tabPage.PullUrl();
            BrowserTitle.Text = tabPage.LabelTitle;

        }
        /// <summary>
        /// Will trigger the http reponse and show the html code on the panel only after the 'Enter' button is pressed
        /// </summary>

        private void Tb1_KeyDown(object sender, KeyEventArgs e)
        {
            TabManager temp = (TabManager)tabhead.SelectedTab;
            // Setting the 'Enter' key as a trigger to initiate the process
            if (e.KeyCode == Keys.Enter)
            {
                
                if (!UrlChecker(tb1.Text))
                {
                    temp.Text = "URL IS INVALID";
                }
                else
                {
                    temp.PullHttpRequest(tb1.Text);
                    backbtn.Visible = temp.Index > 0;
                    hislist.Visible = false;
                    Settingsmenu.Visible = false;
                    favlist.Visible = false;
                }
                BrowserTitle.Text = temp.LabelTitle;
            }


        }

        ///FavouriteClass Features///

        ///<summary>
        /// FavouriteClass list will be shown only if the button is clicked or unclicked
        ///</summary>
        private void Favourite_Click(object sender, EventArgs e)
        {
            Favourite.FavouriteButtonFunctionality(out var FavEditToolTip);
        }
        /// <summary>
        /// Clears all the favourite list
        /// </summary>
        private void ClearFavourite_Click(object sender, EventArgs e)
        {
            favlist.Items.Clear();
            browser.ClearAllFavourite();
            Settingsmenu.Visible = false;
        }
        /// <summary>
        /// Adds the page into Favourite list along with showing the shortcut
        /// </summary>
        private void Bookmarkpage_Click(object sender, EventArgs e)
        {
            Favourite.AddFavourite(e);
            Settingsmenu.Visible = false;

        }
        /// <summary>
        /// This function allows an url along with the title to be added or removed into the Favourite list
        /// </summary>
        /// <remarks> press 'Ctrl + D' keys on keyboard </remarks>
        public void Favbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control) && e.KeyCode == Keys.D)
            {
                Favourite.AddFavourite(e);
            }
        }

        /// <summary>
        ///  Edit button in context menu strip to edit the Favourite url link address by title and url
        /// </summary>
        private void FavEDIT_Click(object sender, EventArgs e)
        {
            //Splitting the url by white space and selecting the last item in the string array
            String[] temp = favlist.Items[Favourite.FavlistIndex].ToString()?.Split(' ');
            // If the list is not null then the following will execute
            if (temp != null)
            {
                //FavouriteClass form will open 
                FavoriteForm editFavourite = new(ref browser, temp[^1],
                    browser.PullTitle(temp[^1]))
                {
                    Location = Pointerlocation with { X = SystemInformation.WorkingArea.Width / 2 + Pointerlocation.X }
                };
                editFavourite.ShowDialog();
            }
        }
        /// <summary>
        /// TimeStamp complexity O = N*logN
        /// </summary>
        public void CallFavorites()
        {
            // Linq is used here for easy conversions and getting the data easily 
            Dictionary<String, Interpreter.Address> favourites = browser.GetFavoritesList();
            var sortedByTime = from d in favourites
                               orderby d.Value.TimeStamp.ToFileTime()
                               select d.Value;
            foreach (Interpreter.Address Favourite in sortedByTime)
            {
                // To give separation between the title and the url 
                // No other separation can be given as it will hinder when using the same link again as a url
                favlist.Items.Add(Favourite.Title + " <|> " + Favourite.Url);
            }
        }

        /// <summary>
        /// To delete the selected url from the Favourite list 
        /// </summary>
        private void FavDELETE_Click(object sender, EventArgs e)
        {
            Favourite.DeleteContextMenuStripFav(out _);
        }

        /// <summary>
        /// Method to insert and remove items on the list
        /// </summary>
        public void EditFavoriteTools(Interpreter.Address url)
        {
            Favourite.FormatToAddToFavList(url);
        }

        /// <summary>
        /// When the url link is pressed from the Favourite list, the url will open into a new tab
        /// </summary>
        public void Favlist_SelectedIndexChanged(object sender, EventArgs e)
        {

            DialogResult d;
            d = MessageBox.Show("Click Yes to open link into a new tab", "Select Desired Option", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
                {
                    int index = favlist.SelectedIndex;
                    if (index != -1)
                    {
                        favlist.Visible = false;
                        String[] temp = favlist.Items[index].ToString()?.Split(' ');
                    if (temp != null) NewUrlTab(ref browser, temp[^1]);
                    }
                }
            else
            {
                favlist.Visible = !favlist.Visible;
            }
            
        }

        /// <summary>
        /// Open the context menu strip if the mouse right click has been pressed at that specific location
        /// </summary>
        private void Favlist_MouseUp(object sender, MouseEventArgs e)
        {
            Favourite.OpenFavContextMenuForm(e);
        }

        ///HistoryClass Features///

        ///<summary>
        ///History list will be shown only if the button is clicked or unclicked
        ///</summary>
        private void History_Click(object sender, EventArgs e)
        {
            History.HistoryListFunctionality(out var HisEditToolTip);
        }

        ///<summary>
        /// TimeStamp Complexity O = N
        ///</summary>
        private void CallHistory()
        {
            List<Interpreter.Address> list = browser.GetHistoryList();
            for (int i = 0; i < list.Count; i++)
            {
                Interpreter.Address url = list[i];
                hislist.Items.Add(url.Title + " <|> " + url.Url);
            }
        }
        /// <summary>
        /// Shortcut to deleting many items at a faster rate to clear out the history 
        /// </summary>
        /// <remarks> press 'Delete' key on keyboard </remarks>
        private void Hisbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                History.HistoryClearAllShortcut((KeyEventArgs)e);
            }
        }

        private void Clearhistory_Click(object sender, EventArgs e)
        {
            History.HistoryClearAllShortcut(e);
        }
        /// <summary>
        /// Pattern to insert the url into the 'hislist'
        /// </summary>
        public void CallUrLtoHisList(Interpreter.Address url)
        {
            History.PushUrlToHistoryList(url);
        }

        /// <summary>
        /// Opens up the context menu strip when the right mouse click is pressed at its location of the index 
        /// </summary>
        private void Hislist_MouseUp(object sender, MouseEventArgs e)
        {
            History.OpenDeleteOptionHistory(e);
        }
        
        private void HisDELETE_Click(object sender, EventArgs e)
        {
            //Deletes the specifc item only from the 'hisist'
            hislist.Items.RemoveAt(History.HislistIndex);
            browser.DeleteFromHistory(History.HislistIndex);
        }
        /// <summary>
        /// To open a new tab if an url is clicked from the history list
        /// </summary>
        private void Hislist_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Click Yes to open link into a new tab", "Select Desired Option", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
                int index = hislist.SelectedIndex;
                if (index != -1)
                {
                    hislist.Visible = false;
                    NewUrlTab(ref browser, browser.IndexOfHistory(index));
                }
            }
            else
            {
                hislist.Visible = !hislist.Visible;
            }
        }
        /// <summary>
        /// Allows the initial start of http//: or https//:, will only take the variables assigned in the field
        /// </summary>
        /// <param name="input"> url stored into a variable input </param>
        /// <returns></returns>
        public static bool UrlChecker(string input)
        {
            return Regex.IsMatch(input, "(https?)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]");
        }

        /// Bulk Download ///
        /// <summary> 
        /// Pulls the bulk download file to show the code and byte size of the file along with the url
        /// Exceptions created incase if wrong file has been addedor wrong url
        /// </summary>
        private void Bulk_Click(object sender, EventArgs e)
        {
            hislist.Visible = false;
            favlist.Visible = false;
            Settingsmenu.Visible = false;
            // Performing an infinity loop to always read the .txt file inserted
            while (true)
            {
                DialogResult dr = BulkFile.ShowDialog();
                String filename = BulkFile.FileName;
                String pattern = ".txt";
                if (dr == DialogResult.OK)
                {

                    if (Regex.IsMatch(filename, pattern))
                    {

                        List<String> urls = browser.GetBulkDownloadUrLs(filename);
                        TabManager page = new(ref browser);
                        tabhead.TabPages.Add(page);
                        page.Text = "Bulk Download";
                        page.NewPanel.Text = "<code>  <bytes>  <URL> \r\n";
                        tabhead.SelectedTab = page;
                        tb1.Text = "";

                        for (int i = 0; i < urls.Count; i++)
                        {
                            string url = urls[i];
                            if (url != "")
                            {
                                if (!UrlChecker(url))
                                {
                                    page.NewPanel.Text += "The URL is invalid" + "\r\n";
                                }
                                else
                                {
                                    page.BulkFile(url);
                                }
                            }
                            else
                            {
                                page.NewPanel.Text += "Please Enter URL into a file" + "\r\n";
                            }
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("" + filename, " Wrong file format", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    break;
                }
            }
        }
    }
}