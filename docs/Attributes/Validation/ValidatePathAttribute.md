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
public class Example
{
    [ValidatePath]
    public string DataPath { get; set; }
}
```

### F#
Here is an example in F#:
```fsharp
type GetRegexMatchCommand(filePath: string) =
    [<ValidatePath>]

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
    )
}
```

