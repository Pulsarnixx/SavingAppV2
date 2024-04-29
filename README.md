# SavingAppV2

## NuGet Dependencies
- Microsoft.AspNetCore.Components.WebAssembly.Server      8.0.3
- Microsoft.AspNetCore.Components.WebAssembly             8.0.3 
- Microsoft.EntityFrameworkCore                           8.0.4  
- Microsoft.EntityFrameworkCore.Design                    8.0.4
- MySql.EntityFrameworkCore                               8.0.0
- Pomelo.EntityFrameworkCore.MySql                        8.0.2
- Microsoft.NET.ILLink.Tasks                              8.0.3
- Microsoft.NET.Sdk.WebAssembly.Pack                      8.0.3
- Radzen.Blazor                                           4.30.3

## Before use

- go to https://dev.mysql.com/downloads/installer/ and install MySQL database
- remember your User and Password for your localhost server

## Usage

```bash
#Prepare db settings
cd Webapp
#modify app appsettings using your localhost UserID and Password

#Update db
cd ../Shared
dotnet ef database update -s ../Webapp

#Run project
#if dotnet run doesn't help - press F5 in Webapp file using VScode
cd ../Webapp
dotnet run
```
