using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace Utilities.Cmdlets.Statistics
{
    [Cmdlet(VerbsCommon.Get, "Mean", HelpUri = "https://github.com/ChessGeekBoy/Utilities/tree/main/docs/Cmdlets/Statistics/Get-Mean.md")]
    public class GetMeanCommand : PSCmdlet
    {
        [Parameter(Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The data from which the mean should be found.")]
        public IEnumerable<decimal> Data { get; set; }

        protected override void EndProcessing()
        {
            decimal mean = Utilities.Math.Statistics.GetMean(this.Data);
            WriteObject(mean);
        }
    }
}
