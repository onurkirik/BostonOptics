# BostonOptics (E-Commerce)
A Sample N-layered .NET Core Project Demonstrating Clean Architecture 
and the Generic Repository Pattern. 

## Migrations

### Infrastructure
Firstly, set the project "Web" as startup project.
Secondly, choose Infrastructure on Package Manager Console.
```
Add-Migration InitialCreate -context ShopContext -o Data/Migrations  
Update-Database -context ShopContext
```

## Packages Installed
### Infrastructure
```
Install-Package Microsoft.EntityFrameworkCore -v 6.0.14
Install-Package Microsoft.EntityFrameworkCore.Tools -v 6.0.14
Install-Package Npqsql.EntityFramework.PostgreSQL -v 6.0.8

```

### ApplicationCore

```
Install-Package Ardalis.Specification -v 6.1.0
```

## Useful Links
### Documantation
https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/

### Github
https://github.com/dotnet-architecture/eShopOnWeb

### E-book
https://aka.ms/webappebook
