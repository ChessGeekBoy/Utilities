using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.IO;

namespace Utilities.Cmdlets.IO
{
    public class NewDirectoryCommand : PSCmdlet
    {
        [Parameter(Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The name of the directory.")]
        public string Name { get; set; }

        [Parameter(Position = 0,
            Mandatory = false,
            ValueFromPipeline = true,
            HelpMessage = "The path to the directory.")]
        // For PowerShell users, Directory.GetCurrentDirectory() returns the same thing as $pwd.Path
        public string LiteralPath { get; set; } = Directory.GetCurrentDirectory();

        protected override void ProcessRecord()
        {
            string path = Path.Combine(LiteralPath, Name);
            Directory.CreateDirectory(path);
        }
    }
}
