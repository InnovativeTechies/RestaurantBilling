using System;
using System.Reflection;

namespace RestaurantBilling.UI.WPF
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            // In WPF, we have more options for storing the database file.
            // In fact, we can actually store the database file in any folder the user has permissions to access.
            // Here we store the database in the user's local app data folder.
            // This is a recommended location to store application data that users don't interact with directly.

            // Get the title of this application (this is set in our AssemblyInfo.cs file).
            var assembly = Assembly.GetEntryAssembly();
            var titleAttribute = (AssemblyTitleAttribute)Assembly.GetEntryAssembly().GetCustomAttribute(typeof(AssemblyTitleAttribute));

            // Get the Users/UserName/AppData/Local path and combine it with this application's title.
            var localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var fullPath = System.IO.Path.Combine(localAppDataPath, titleAttribute.Title);

            // .Net 4.5 and later - no need to check if the directory exists first.
            // https://msdn.microsoft.com/en-us/library/54a0at6s%28v=vs.110%29.aspx
            System.IO.Directory.CreateDirectory(fullPath);

            return System.IO.Path.Combine(fullPath, filename);
        }
    }
}
