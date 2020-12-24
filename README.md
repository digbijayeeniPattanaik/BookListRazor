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
  
- Implemented 2 page which can do Create and Edit.
- Implemented Upsert page which can have both create and edit feature as the pages are alike.
  
- The below libraries and css was used in Layout to implement
  - DataTable - This is a gridview which has various feature like Sorting, Searching and Pagination.
  - Toastr - For success and failure messages.
  - Sweetalert for pop ups for Delete funtionality.
  
 ``
    <link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.css" />
    <script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
``
