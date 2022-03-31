using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using Utilities.Files;
using System.IO;

namespace Utilities.Cmdlets
{
    public class NewDirectoryCommand : PSCmdlet
    {
        [Parameter(Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The name of the directory")]
        public string Name { get; set; }

        [Parameter(Position = 0,
            Mandatory = false,
            ValueFromPipeline = true,
            HelpMessage = "The path to the directory")]
        public string Path { get; set; }

        protected override void ProcessRecord()
        {
            string path = System.IO.Path.Combine(this.Path, this.Name);
        }
    }
}
