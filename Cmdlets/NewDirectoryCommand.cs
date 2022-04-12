using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.IO;
using static System.IO.Path;

namespace Utilities.Cmdlets
{
    public class NewDirectoryCommand : PSCmdlet
    {
        /// <summary>
        /// The name of the directory.
        /// </summary>
        [Parameter(Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The name of the directory.")]
        public string Name { get; set; }

        /// <summary>
        /// The path to the directory.
        /// </summary>
        [Alias("Path")]
        [Parameter(Position = 0,
            Mandatory = false,
            ValueFromPipeline = true,
            HelpMessage = "The path to the directory.")]
        // For PowerShell users, Directory.GetCurrentDirectory() returns the same thing as $pwd.Path
        public string CreationPath { get; set; } = Directory.GetCurrentDirectory();

        protected override void ProcessRecord()
        {
            string path = Path.Combine(this.CreationPath, this.Name);
            Directory.CreateDirectory(path);
        }
    }
}
