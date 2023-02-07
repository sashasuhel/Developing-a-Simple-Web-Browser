
namespace Web_Browser
{
#nullable disable
    /// <summary>
    /// Initializing a generic delegate
    /// </summary>
    /// <typeparam name="T"> 'T' can be list or a dictionary by using String[] and String</typeparam>
    public delegate void SpecificStructure<T>(ref T t,String[] temp,String rule);

    public class Interpreter
    {
        /// <summary>
        /// Storing history and Favourite information back into a file
        /// </summary>
        private readonly String[] temp = new string[3];

        /// <summary>
        /// To pull the file required
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fileName">The target file can be obtained from filename</param>
        /// <param name="append">Bool append helps to decide whether or not to overwrite the file</param>
        public static void WriteToTextFile(String text, String fileName, bool append)
        {
            try
            {
                StreamWriter streamw = new(fileName, append);
                streamw.WriteLine(text);
                streamw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e + " Unable To Load " + fileName);
                throw;
            }
        }

        /// <summary>
        /// To read the the target file based on the kind of data structure it is (flexible)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"> Assigning a data structure </param>
        /// <param name="fileName"></param>
        /// <param name="structure"> delegate method</param>
        public void ReadToTextFile<T>(ref T t, String fileName, SpecificStructure<T> structure)
        {
            String rule;
            try
            {
                using StreamReader streamr = new(fileName);
                while ((rule = streamr.ReadLine()) != null)
                {
                    //Using ref so its possible to override the data structure 
                    structure(ref t, temp, rule);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file {" + fileName + "} could not be read");
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Reads the default page and sends it to the Load() to intialize it at start
        /// </summary>
        /// <param name="fileName">Takes the website url from the default page </param>
        /// <returns></returns>
        public static String ReadDefaultPage(String fileName)
        {
            try
            {
                using StreamReader sr = new(fileName);
                //read only the first rule in the file
                return sr.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file {" + fileName + "} could not be read");
                Console.WriteLine(e.Message);
            }

            return null;
        }
        /// <summary>
        /// Separating the class URL into different objects
        /// </summary>
        public class Address
        {
            private string title, url;
            private DateTime timestamp;

            public Address(string title, string url, DateTime timestamp)
            {
                this.timestamp = timestamp;
                this.title = title;
                this.url = url;
            }

            //Overwriting the ToString method
            //Serializing so that i can pass the the object 
            public override String ToString()
            {
                //Taking into the assumption that the user will not use '#' into the url
                //"#" will not be shown during execution
                return title + "#" + url + "#" + timestamp.ToFileTime();
            }

            public string Title
            {
                get => title;
                set => title = value;
            }

            public string Url
            {
                get => url;
                set => url = value;
            }

            public DateTime TimeStamp
            {
                get => timestamp;
                set => timestamp = value;
            }

        }

    }

}