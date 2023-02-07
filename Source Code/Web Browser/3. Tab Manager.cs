using System.Net;
using System.Text.RegularExpressions;

namespace Web_Browser
{
#nullable disable
    /// <summary>
    /// To properly inherit from TabPage, each TabPage is an item in the browser which have their own list of url
    /// to achieve multithreading from my browser, each thread can respond for one single TabPage
    /// </summary>
    class TabManager : TabPage
    {
        /// <summary>
        /// <param name="NewPanel"> Shows the HtML code on the panel </param>
        /// </summary>
        public RichTextBox NewPanel = new();

        /// <summary>
        /// <param name="UrlList"> Keeps track of the list of url bytesize to help browse back and forth through websites</param>
        /// </summary>
        public List<String> UrlList = new();
        private int index = -1;
        private readonly WebBrowser browser;
        /// <summary>
        /// The constructor starts a rick text box into a new tab 
        /// </summary>
        /// <param name="browser"></param>
        public TabManager(ref WebBrowser browser)
        {
            this.browser = browser;
            NewPanel.Multiline = true;
            NewPanel.WordWrap = true;
            NewPanel.SelectionFont = new Font("MS Reference Sans Serif", 12);
            NewPanel.ReadOnly = true;
            NewPanel.Parent = this;
            NewPanel.Dock = DockStyle.Fill;
            NewPanel.Show();
        }
        /// <summary>
        /// An overload constructor is required to start with an url
        /// </summary>

        public TabManager(ref WebBrowser browser, String url)
        {
            this.browser = browser;
            NewPanel.Multiline = true;
            NewPanel.WordWrap = true;
            NewPanel.SelectionFont = new Font("MS Reference Sans Serif", 12);
            NewPanel.ReadOnly = true;
            NewPanel.Parent = this;
            NewPanel.Dock = DockStyle.Fill;
            PullHttpRequest(url);
            NewPanel.Show();
        }
        // To bring the title to the top of the web browser
        public string LabelTitle;
        /// <summary>
        /// The Main Http Web request class that pulls the http code of the websites
        /// This class helps to generates HTTP Requests at server side so users can read it.
        /// </summary>
        /// <param name="url"> Contains the url of the websites</param>
        /// <exception cref="InvalidOperationException"> An exception is added incase if a wrong operator is added </exception>
        public void PullHttpRequest(String url)
        {

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Method = "Get";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using StreamReader readStream = new(response.GetResponseStream() ?? throw new InvalidOperationException());
                String temp = readStream.ReadToEnd();
                this.Text = PullTitle(temp).Trim() + " " + Convert.ToInt32(response.StatusCode);
                LabelTitle = this.Text;
                UrlList.Add(url);
                // To make the Index at the end
                index = UrlList.Count - 1;
                NewPanel.Text = temp;
                // To add a new url to the history 
                browser.AddToHistory(new Interpreter.Address(Text, url, DateTime.Now));
            }
            catch (WebException e)
            {
                Regex rx;
                if (true)
                {
                    string pattern = "^\\(+[0-9]*";
                    rx = new(pattern);
                }
                // To print out the error status code and name into the main panel
                NewPanel.Text = rx.IsMatch(e.Message.Split(':')[1].Trim()) ? e.Message.Split(':')[1] : e.Message;
                Text = "Invalid URL";
                UrlList.Add(url);
                index = UrlList.Count - 1;
                browser.AddToHistory(new Interpreter.Address(Text, url, DateTime.Now));
            }
            catch (Exception e)
            {
                NewPanel.Text = e.Message;
                Text = "Error";
                UrlList.Add(url);
                index = UrlList.Count - 1;
                browser.AddToHistory(new Interpreter.Address(Text, url, DateTime.Now));
            }
        }
        /// <summary>
        /// To refresh the current page
        /// </summary>
        public void Reload(String url)
        {
            int temp = index;
            PullHttpRequest(url);
            index = temp;
            UrlList.RemoveAt(UrlList.Count - 1);
        }
        /// <summary>
        /// To go back to the previous url
        /// </summary>
        /// <returns></returns>
        public int Back()
        {
            switch (index)
            {
                case > 0:
                    {
                        int temp = index - 1;
                        PullHttpRequest(UrlList[--index]);
                        index = temp;
                        UrlList.RemoveAt(UrlList.Count - 1);
                        return 0;
                    }

                default:
                    return -1;
            }
        }
        /// <summary>
        /// To go to the succeding url from the list
        /// </summary>
        /// <returns></returns>
        public int Forward()
        {
         // Checks the range of index 
            if (index < UrlList.Count - 1)
            {
                int temp = index + 1;
                // After the reqest is sent, the index will become the last one
                PullHttpRequest(UrlList[++index]);
                // To change the index back to the original added with one
                index = temp;
                // Removes he last url from the list, since its not there anymore
                UrlList.RemoveAt(UrlList.Count - 1);
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public void BulkFile(String url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Method = "Get";
                var response = (HttpWebResponse)request.GetResponse();
                // To Convert http status code into int 
                var bytesize = "<" + Convert.ToInt32(response.StatusCode) + "> ";
                using StreamReader readStream = new(response.GetResponseStream() ?? throw new InvalidOperationException());
                var temp = readStream.ReadToEnd();
                // Gets the whole size
                bytesize += "<" + System.Text.Encoding.ASCII.GetByteCount(temp) + "> ";
                bytesize += "<" + url + ">" + "\r\n";
                NewPanel.Text += bytesize;
            }
            catch (WebException e)
            {
                try
                {
                    // Incase if an exception takes place the message will be shown
                    var wRespStatusCode = (((HttpWebResponse)e.Response)!).StatusCode;
                    NewPanel.Text += "<" + Convert.ToInt32(wRespStatusCode) + "> " + "<0> " + "<" + url + "> " + "\r\n";
                }
                catch (Exception msg)
                {
                    NewPanel.Text += msg.Message + "\r\n";
                }
            }
            catch (Exception msg)
            {
                NewPanel.Text += msg.Message + "\r\n";
            }
        }
        /// <summary>
        /// Using regular expression to filter the title in the return code 
        /// </summary>
        /// <returns></returns>
        public static String PullTitle(String strUrl)
        {
           // To find <title> in the html
            String pattern = "<title>(?<title>[^<]*)</title>";
            String tabtitle = Regex.Match(strUrl, pattern).ToString();
           // To delete the starting 
            tabtitle = tabtitle.Replace("<title>", "");
            // To delete the ending 
            tabtitle = tabtitle.Replace("</title>", "");
            return tabtitle;
        }


        /// <summary>
        /// Return the current url shown in the Tab
        /// </summary>
        /// <returns></returns>
        public String PullUrl()
        {
            return index != -1 ? UrlList[index] : "";
        }
        public int Index => index;

    }

}
