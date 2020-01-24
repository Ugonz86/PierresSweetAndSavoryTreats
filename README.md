# Pierre's Sweet and Savory Treats _01/24/2020_

## By _**Uriel Gonzalez**_

### Description

A C# and .NET Database Basics Independent Project - This web application uses authentication and a many-to-many relationship with Entity. The application includes three models, all with full CRUD functionality. Only logged in users have create, update and delete functionality. All users have read functionality.

The user can:

1. Add, view, edit, search and delete one or multiple treats.
2. Add, view, edit, search and delete one or multiple flavors.
3. The user can make orders.

## Setup/Installation Requirements

* This application requires MySQL.

1. Clone this repository:

  ```sh
  $git clone https://github.com/Ugonz86/PierresSweetAndSavoryTreats.git
  $cd PierresSweetAndSavoryTreats.Solution/Market
  $dotnet restore
  $dotnet run
  ```

2. Open the App Settings file (PierresSweetAndSavoryTreats/Market/appsettings.json) and ensure that the MySQL username and password matches your MySQL credentials.

## Database Setup

```sh
1. mysql start
2. Access MySql by executing the command: `mysql -uroot -pepicodus`
3. CREATE DATABASE `uriel_gonzalez`
4. USE `uriel_gonzalez`
5. Create Table - Flavors > FlavorId Int() PK, NN,AI + Description LONGTEXT
6. Create Table - Treats > TreatId INT() PK, NN, AI + Name LONGTEXT + Price INT
7. Create Table - FlavorTreat > TreatFlavorId INT() PK, NN, AI + FlavorID INT() + TreatId()
8. Run program with dotnet run (or $ dotnet watch run).

```
OR
* > dotnet restore, dotnet ef migrations add addIdentity, dotnet ef migrations add Authorization, dotnet ef database update

## Known Bugs

* No bugs at this moment.

## Technologies Used

* C# / .NET / ASP.NET Core MVC / HTML / My SQL / Entity

## Support and contact details

_Please contact me with questions and comments: ugonzalez86@gmail.com._

### License

* *MIT License*

Copyright (c) 2020 **_Uriel Gonzalez_**
