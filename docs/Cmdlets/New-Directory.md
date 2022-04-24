# New-Directory
This cmdlet creates a new directory at a specified path. While this can already be done through the use of PowerShell's `New-Item` cmdlet, this is a shorter, and, not to mention, more readable alternative. It shortens
```powershell
New-Item -Path "C:\Example" -Name "Example" -ItemType "Directory"
```
to this:
```powershell
New-Directory -Path "C:\Example" -Name "Example"
```