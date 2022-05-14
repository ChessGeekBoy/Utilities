# `ValidatePathAttribute`
## Inheritance
`System.Object` -> `System.Attribute` -> `Utilities.Attributes.Validation.ValidatePathAttribute`

## Properties
### `PositionalProperty`
#### Description
The property upon which the validation should be enacted.

## Examples
### C#
Here is an example in C#:
```csharp
using System.Management.Automation;
using System.IO;
using System.Text.RegularExpressions;

namespace ExampleNamespace
{
    [Cmdlet(VerbsCommon.Get, "RegexMatch")]
    public class Example : PSCmdlet
    {
        [ValidatePath]
        [Parameter(Position = 0, Mandatory = true)]
        public string LiteralPath { get; set; }

        [Parameter(Position = 1, Mandatory = true)]
        public string Pattern { get; set; }

        public override void ProcessRecord()
        {
            string content = File.ReadAllText(this.LiteralPath);
            Regex regex = new Regex(this.Pattern);
            WriteObject(regex.IsMatch(content));
        }
    }
}
```

### PowerShell
Here is an example in PowerShell:
```powershell
function Get-RegexMatch
{
    [CmdletBinding()]
    param (
        [Paremeter(Position = 0, Mandatory = $true)]
        [ValidatePath]
        [string] $filePath
        [Parameter(Position = 1, Mandatory = $true)]
        [string] $regex
    )
    [System.Text.RegularExpressions.Regex] $regexPattern = [System.Text.RegularExpressions.Regex]::new($regex)
    Write-Output -InputObject $regexPattern.IsMatch((Get-Content -LiteralPath $filePath))
}
```

