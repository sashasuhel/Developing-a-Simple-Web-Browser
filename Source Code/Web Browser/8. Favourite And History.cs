namespace Web_Browser
{
    public class FavouriteClass
    {
#nullable disable
        private readonly MainForm mainForm;

        public FavouriteClass(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public WebBrowser browser;

        // To be able to open the contextmenustrip at the exact position required for FavouriteClass List
        public int FavlistIndex;

        public void AddFavourite(EventArgs e)
        {
            TabManager tabPage = (TabManager)mainForm.tabhead.SelectedTab;
            // If the Favourite link is already in the Favourite list then the item will be removed
            // If its not present in the list then it will be added into the list 
            if (!mainForm.browser.FavouriteItemChecker(mainForm.tb1.Text))
            {

                if (MainForm.UrlChecker(mainForm.tb1.Text))
                {
                    mainForm.browser.AddToFavorites(mainForm.tb1.Text,
                        new Interpreter.Address(tabPage.Text, mainForm.tb1.Text, DateTime.Now));
                    mainForm.favlist.Items.Add(tabPage.Text + " <|> " + mainForm.tb1.Text);
                }
            }
            else
            {
                MessageBox.Show("The URL is already Bookmarked", "Information");
            }

        }

        public void DeleteContextMenuStripFav(out String[] temp)
        {
            temp = mainForm.favlist.Items[FavlistIndex].ToString()?.Split(' ');
            // To delete the selected item only from the list
            mainForm.favlist.Items.RemoveAt(FavlistIndex);
            if (temp != null) mainForm.browser.DeleteFromFavorite(temp[^1]);
            // '_' is used to discard the unwanted data which is more efficient than declaring a variable
            _ = (TabManager)mainForm.tabhead.SelectedTab;
        }

        public void OpenFavContextMenuForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Points out at the item at which is shown in the 'favlist"
                int index = mainForm.favlist.IndexFromPoint(e.Location);
                mainForm.Pointerlocation = e.Location;
                FavlistIndex = index;
                // if the pointer is on top of an item only then the menu strip is shown
                if (index < 0)
                {
                    return;
                }

                // Shows the menu strip for edit or delete
                mainForm.contextMenuFavorite.Show(mainForm.favlist, e.Location);
                

            }
        }

        public void FormatToAddToFavList(Interpreter.Address url)
        {
            mainForm.favlist.Items.RemoveAt(FavlistIndex);
            mainForm.favlist.Items.Insert(FavlistIndex, url.Title + " <|> " + url.Url);
            _ = (TabManager)mainForm.tabhead.SelectedTab;
        }

        public void FavouriteButtonFunctionality(out ToolTip FavEditToolTip)
        {
            mainForm.favlist.Visible = !mainForm.favlist.Visible;
            mainForm.hislist.Visible = false;
            mainForm.Settingsmenu.Visible = false;
            FavEditToolTip = new();
            FavEditToolTip.SetToolTip(mainForm.favlist, "Right Click on the Favourite Item to Edit or Delete the Selection");
            FavEditToolTip.InitialDelay = 150;
        }

    }

    public class HistoryClass
    {
        private readonly MainForm mainForm;

        public HistoryClass(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }
        
        // To be able to open the contextmenustrip at the exact position required for history List
        public int HislistIndex;

        public void HistoryClearAllShortcut(EventArgs e)
        {
            mainForm.hislist.Items.Clear();
            mainForm.browser.ClearAllHistory();
            mainForm.Settingsmenu.Visible = false;

        }
        public void PushUrlToHistoryList(Interpreter.Address url)
        {
            mainForm.hislist.Items.Insert(0, url.Title + " <|> " + url.Url);
            // Set to true since its disabled if the index is > 0
            mainForm.hislist.Enabled = true;
        }
        public void OpenDeleteOptionHistory(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = mainForm.hislist.IndexFromPoint(e.Location);
                HislistIndex = index;
                if (index >= 0)
                {
                    mainForm.contextMenuHistory.Show(mainForm.hislist, e.Location);
                }
            }
        }
        
        public void HistoryListFunctionality(out ToolTip HisEditToolTip)
        {
            mainForm.hislist.Visible = !mainForm.hislist.Visible;
            mainForm.favlist.Visible = false;
            mainForm.Settingsmenu.Visible = false;
            HisEditToolTip = new();
            HisEditToolTip.SetToolTip(mainForm.hislist, "Right Click on the History Item to Delete the Selection");
            HisEditToolTip.InitialDelay = 150;
        }
    }
}

