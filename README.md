# WebApplication1<br>Explaining the code and the concepts of ASP.NET Core MVC.

## Tools used:
- Visual Studio 2022
- Microsoft SQl Server

## Folders:
- **Controllers**: Contains all controller files.
- **Data**: Contains 'ApplicationDBContext.cs' file represents a class that inherits from the EntityFrameworkCore class and connects to database and manages database interactions.
- **Migrations**: All databse migrations after database modifications.
- **Properties**: Contains 'launchSettings.json' file for configuring server settings.
- **Views**: Contains a folder for saving each controller views.(e.x. Home controller has a Home folder to contain different views for it). Contains a Shared folder for saving base views that are used in most of the pages  of our website.
- **wwwroot**: Contains css, js, and lib folders for styling the pages(aka views).

## Steps for building an ASP.NET core MVC project:

### Prerequisites:
- Download [Visual Studio](https://visualstudio.microsoft.com/downloads/).
- Download [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- Download [SQL Server Management Studio](https://aka.ms/ssmsfullsetup)

### Setup:
#### -  Visual Studio:
1. Open Visual Studio.
2. On the welcome page, click on "Create a new project". *(Make sure you download ASP.NET package from VS installer)*
3. Search for ASP.NET Core and choose the project template with the name: "ASP.NET Core Web App (Model-View-Controller)".
4. Type in the solution and project name, then click Next and continue with the defualts. *(You can think of solutions as a folder for containing different projects within the same category)*
#### -  SQL Server Management Studio:
1. Open SQL Server Management Studio.
2. On startup, a window pops up with title "SQL Server". By default, it should find the SQL server you installed. Click "Connect" and you are set up.<br>
*Note: If window does not show up and you are welcomed with an empty screen, click on File then click "Connect Object Explorer"*

### Building the Application:
Model-View-Controller(MVC) web applications separate the different parts of an application into 3 parts. <br>
- Models are classes (C# classes in asp.net applications) that represent tables in our database. There are two types of working with the database in these kinds of projects, code-first and database-first. Code-first allows to build the database tables without writing sql code all in the language of the framework being used(in this case C#). After the model is created, migrations are applied then these migrations update the database with tables represented by the models.
- Views are the pages of the website. Views are files with .cshtml extensions that allow you to use C# variables inside html. Specific views are rendered depending on the controller and actions within each controller.
- Controllers, as their name suggests, control what the user sees. Routes within the website are created depending on the controller name. Controllers interacts with the database and displays the appropriate data to the user within the view of the same name. Actions are different actions that may occur within a controller such as creating a new category in your website.
