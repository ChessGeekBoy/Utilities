[string] $testsPath = "$PSScriptRoot/../../../tests" 
[string[]] $testFileNames = (Get-ChildItem -Path $testsPath -Force -Filter "*.ps1").Name

foreach ($testFileName in $testFileNames) {
    [string] $testFilePath = Join-Path -Path $testsPath $testFileNames
    Start-Job -FilePath $testFilePath
}