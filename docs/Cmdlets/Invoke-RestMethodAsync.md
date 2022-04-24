# Invoke-RestMethodAsync

## Description
Sends an asynchronous HTTP/HTTPS request to a RESTful Web service.

## Syntax
### Default
```powershell
Invoke-RestMethodAsync [-Method <HttpMethod>] [-Uri <Uri>]
```
### HttpContent
```powershell
Invoke-RestMethodAsync [-Method <HttpMethod>] [-Uri <Uri>] [-HttpContent <HttpContent>]
```


## Examples
This example sends an HTTP GET request to the [Microsoft Docs Hierarchy REST API](https://www.docs.microsoft.com/api/hierarchy):
```powershell
Import-Module -Name "Utilities"
[string] $requestUri = "https://www.docs.microsoft.com/api/hierarchy"
Invoke-RestMethodAsync -Method HttpMethod::Get -Uri $requestUri
```