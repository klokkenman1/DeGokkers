using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DeGokkers.Classes
{
    static class LangResource
    {
        public static ResourceManager rm;

        public static void RecManager()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("nl-NL");
            rm = ResourceManager.CreateFileBasedResourceManager("common", "./", null);
        }

        public static string GetTranslation(string key)
        {
            try
            {
                return rm.GetString(key);
            }
            catch (MissingManifestResourceException e)
            {
                return key;
            }       
        }
    }
}
