
namespace Web_Browser
{
#nullable disable
    public class WebBrowser
    {
        //To be able to add a new url to history, this will inform 'hislist' method in the Main class to add the latest url into the list
        public delegate void AddToHisList(Interpreter.Address url);
        //To be able to add the changed url
        public event AddToHisList Changed;

        //To be able to bring changes to the FavouriteClass url details
        public delegate void EditFavList(Interpreter.Address url);
        //Will bring changes to 'favlist' in the Main class to the updated one
        public event EditFavList Edited;

        //Saving the history url's as a list 
        private List<Interpreter.Address> history = new();
        //Saving the title names and url's in a dictionary for favoruties to have single key pair values
        private Dictionary<String, Interpreter.Address> favorite = new();

        private readonly Interpreter fileIo = new();
        private String homePage;
        // helps keep the files together at load
        private readonly String path = Application.StartupPath;


        public WebBrowser() {Load();} // helps load all the text files
        private void Load()
        {
            fileIo.ReadToTextFile(ref favorite, Path.Combine(path, "FavoriteFile.txt"), LoadToDictionary);
            homePage = Interpreter.ReadDefaultPage(Path.Combine(path, "DefaultpageFile.txt"));
            fileIo.ReadToTextFile(ref history, Path.Combine(path, "HistoryFile.txt"), LoadToList);
        }
        /// <summary>
        /// Adds The URL to the favourite list file based on timestamp and title
        /// </summary>
        /// <param name="list">Variable initialized</param>
        /// <exception cref="ArgumentNullException">Throws exception if varible is null</exception>
        public static void LoadToList(ref List<Interpreter.Address> list, String[] temp, String rule)
        {
            //Deserialization 
            if (temp == null) throw new ArgumentNullException(nameof(temp));
            temp = rule.Split('#');
            list.Add(new Interpreter.Address(temp[0], temp[1], DateTime.FromFileTime(long.Parse(temp[2]))));
        }
        /// <summary>
        /// Adds the URL to the history list based on the timestamp and title of the url
        /// </summary>
        /// <param name="dictionary">Initializing th evarible as a dictionary type</param>
        /// <exception cref="ArgumentNullException">Throws exception if varible is null</exception>
        public static void LoadToDictionary(ref Dictionary<String, Interpreter.Address> dictionary, String[] temp, String rule)
        {
            if (temp != null)
            {
                temp = rule.Split('#');
                dictionary.Add(temp[1], new Interpreter.Address(temp[0], temp[1], DateTime.FromFileTime(long.Parse(temp[2]))));
            }
            else
                throw new ArgumentNullException(nameof(temp));
        }

        public static void LoadDownload(ref List<String> list, String[] temp, String rule)
        {
            //Adds and item at the end of the list
            list.Add(rule);
        }

        public string GetDefaultPage() => homePage;

        public void SetHomePage(string value)
        {
            // Saving the Defaultpage, so it opens up in every load 
            homePage = value;
            Interpreter.WriteToTextFile(value, Path.Combine(path, "DefaultpageFile.txt"), false);
        }

        public void AddToFavorites(String stringUrl, Interpreter.Address url)
        {
            //Adds the specific item as a string title and url link
            favorite.Add(stringUrl, url);
            //Calling a method to activiate a loop
            WriteToFavouriteFile();
        }

        public void DeleteFromFavorite(String key)
        {
            //Removes the specific item as a string title and url link
            favorite.Remove(key);
            WriteToFavouriteFile();
        }
        /// <summary>
        /// Method Created to edit the previous title and url from the favourites list and overwrite it with the new data
        /// </summary>
        /// <param name="updatedTitle">New Title typed by user</param>
        /// <param name="newkey">updated url link</param>
        /// <param name="key">Item in the favourites list</param>
        public void EditFavoriteTitle(String updatedTitle, String newkey, String key)
        {
            // Keeping the same old timestamp
            DateTime temp = favorite[key].TimeStamp;
            favorite.Remove(key);
            Interpreter.Address url = new(updatedTitle, newkey, temp);
            favorite.Add(newkey, url);
            // To let the Main class pull the method from here
            Edited?.Invoke(url);
            WriteToFavouriteFile();
        }

        public Dictionary<String, Interpreter.Address> GetFavoritesList()
        {
            return favorite;
        }

        public bool FavouriteItemChecker(String key)
        {
            return favorite.ContainsKey(key);
        }

        public String PullTitle(String key)
        {
            //title of the favourite item
            return favorite[key].Title;
        }
        public void AddToHistory(Interpreter.Address url)
        {
           // hisfeatures has to keep the same order by the timestamp added in descending order
           // The new url inserted will be added to the top of the list
            history.Insert(0, url);
            WriteToHistoryFile();
            // Caling this method to inform 'hislist' to do the same as well 
            Changed?.Invoke(url);
        }

        public void DeleteFromHistory(int index)
        {
            // Deletes the index in history as well as 'hislist'
            history.RemoveAt(index);
            WriteToHistoryFile();
        }

        public List<Interpreter.Address> GetHistoryList()
        {
            return history;
        }

        public String IndexOfHistory(int index)
        {
            return history[index].Url;
        }
        /// <summary>
        /// After all the changes are done, then they are saved permanently to Favourites.txt file
        /// </summary>
        private void WriteToFavouriteFile()
        {
            String outcome = "";
            foreach (KeyValuePair<String, Interpreter.Address> keyvalue in favorite)
            {
                outcome += keyvalue.Value.ToString();
                outcome += "\r\n";
            }

            Interpreter.WriteToTextFile(outcome, Path.Combine(path, "FavoriteFile.txt"), false);
        }
        /// <summary>
        ///  After all the changes are done, then they are saved permanently HistoryFile.txt file
        /// </summary>
        private void WriteToHistoryFile()
        {
            String outcome = "";
            foreach (Interpreter.Address url in history)
            {
                outcome += url.ToString();
                outcome += "\r\n";
            }

            Interpreter.WriteToTextFile(outcome, Path.Combine(path, "HistoryFile.txt"), false);
        }
        /// <summary>
        /// Storing the file names from Bulk Download
        /// </summary>
        /// <returns></returns>
        public List<String> GetBulkDownloadUrLs(String filename)
        {
            List<String> urls = new();
            // Using delegates here
            fileIo.ReadToTextFile(ref urls, filename, LoadDownload);
            return urls;
        }

        /// <summary>
        /// To delete complete history file by overwriting with empty strings at every instance 
        /// </summary>
        public void ClearAllHistory()
        {
            String outcome = "";
            foreach (Interpreter.Address url in history)
            {
                outcome += "\r\n";
            }
            Interpreter.WriteToTextFile(outcome, Path.Combine(path, "HistoryFile.txt"), false);
        }
        /// <summary>
        ///  To delete complete favourite file by overwriting with empty strings at every instance
        /// </summary>
        public void ClearAllFavourite()
        {
            String outcome = "";
            foreach (KeyValuePair<String, Interpreter.Address> keyvalue in favorite)
            {
                outcome += "\r\n";
            }

            Interpreter.WriteToTextFile(outcome, Path.Combine(path, "FavoriteFile.txt"), false);
        }

    }
}