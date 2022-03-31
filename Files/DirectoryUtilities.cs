using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Utilities.Files
{
    public static class DirectoryUtilities
    {
        /// <summary>
        /// Creates a directory without throwing any exception.
        /// </summary>
        /// <param name="path">The path for the directory to be created.</param>
        /// <returns></returns>
        public static void CreateDirectorySafe(string path)
        {
            bool success = false;
            string[] directories = path.Split(@"\");

            
        }
    }
}
