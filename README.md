# MEalAPI

This repo contains the source code for the back-end ASP.NET Core API for the
MEal meal-planning web application.

## Getting Started
1. Install Visual Studio Community (>=2022). Ensure to add the Database and
   Javascript add-ons.
2. Clone the repos locally.
3. Create a new Solution and add both the the MEalAPI csproj and the MEalClient
   esproj to it.
4. Install the project dependencies using either dotnet via powershell or the
   Visual Studio package wizard or CLI.
	* Follow the steps at [Install EF Core](https://docs.microsoft.com/en-us/ef/core/get-started/overview/install)
	  to install the ef core tools.
5. Install PostgreSQL v14 and create a new connection in DataGrip using the
   connection details in `Program.cs`.
6. Apply the latest database migration by running `dotnet ef database update`.
7. Copy `SeedData/meal_seed_data.sql` into a new DataGrip console session and
   run to add the seed data to the database.