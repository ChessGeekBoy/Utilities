using System.Management.Automation;
using System.IO;

namespace Utilities.Cmdlets.IO
{
    [Cmdlet(VerbsCommon.New, "Directory",  HelpUri = "https://www.github.com/ChessGeekBoy/Utilities/blob/main/docs/Cmdlets/Invoke-RestMethodAsync.md")]
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
        // For PowerShell users, this.SessionState.Path returns the same thing as $pwd.Path
        public string LiteralPath { get; set; }

        protected override void ProcessRecord()
        {
            if (this.LiteralPath == ".")
            {
                this.LiteralPath = this.SessionState.Path.CurrentFileSystemLocation.Path;
            }
            
            string path = Path.Combine(LiteralPath, Name);
            Directory.CreateDirectory(path);
        }
    }
}
