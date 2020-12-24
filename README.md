# BookListRazor

- Whenever there is any change in cshtml file, the changes doesnot reflect in the browser until the solution is restarted.
  - To overcome this issue, Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation nuget package was installed.

- Installed the following nuget package for using Entity framework.
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools

- Used the following scripts to do initial migration using package manager console.
  - To create migration script - add-migration AddBookToDB
  - To execute the script - update-database

- Client side valiation should be implemented along with server side validation.
  - By using '_ValidationScriptsPartial' in the cshtml file you want to implement client side validation 
