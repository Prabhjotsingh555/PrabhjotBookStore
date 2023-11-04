﻿Starting time = 11-04-2023 1123
Program name = PrabhjotBookStore
Program Purpose = Making a MVC project advanced
Program author = Prabhjot Singh

-------START STEP 1.1 REVIEW-------

1. First I ceatre new project
2. Filter the search by choosing c# language ande platform > web
3. Then name the project (PrabhjotBookStore) choose path and place in same folder file as in project
4. Then choose version 5.0
5. Choose individual account type Authentication
6. And create
7. Then click on git and make new clone respository 
8. Write the desciption
9. Done.
10. Then create readme md file
11. Then create readme text file
12. Then comment the local host line  7 inside > Properties > launchSettings.json
13. Comment the 35th line in startup file
Test it = IT WORKED
14. Commint to Github

-------COMPLETED STEP 1.1 REVIEW-------

-------START STEP 1.2 DEBUGGING-------

Starting time = 11-04-2023 1130

Test it = IT WORKED

-------COMPLETED STEP 1.2 DEBUGGING-------

Starting time = 11-04-2023 1132

1. Rename the original Bootstrap files to Bootstrap_o
2. Added new files wwwroot > lib > bootstrap > dist > css
 Test it = IT WORKED
3. Rename the original site.css file to site_o.css
4. Add new site.css file
5. Update the navbar-light to navbar dark and bg-white to bg-primary and footer
 Test it = IT WORKED
6. Update _Layout.cshtml file
 Test it = IT WORKED
7. Adde the additional stylesheets and scripts to _Layout.cshtml file
8. Add dropdown menu and items 
Test it = IT WORKED 
9. Commint to Github

-------COMPLETED STEP 1.3 BOOTSTRAP-------

-------START STEP 1.4 Add Projects & Modify-------

Starting time = 11-04-2023 1145

1. Added new project PrabhjotBooks.DataAccess
2. Added new project PrabhjotBooks.Models
3. Added new project PrabhjotBooks.Utility
4. Move Data folder in PrabhjotBooks.DataAccess from PrabhjotBookStore
5. Installed Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages
6. Delete the migration folder
7. Install Identity.EntityFrameworkCore
8. Delete the class1.cs file from the all new three project
 Test it = IT NOT WORKED																			  ..........ERROR..........
9. Error was type or namespace Data does not exist in the PrabhjotBookStore
10. to solve this isssue I add references to PrabhjotBooks.DataAccess
 Test it = IT WORKED
11. Move model folder to new project PrabhjotSinghBooks.Models project
12. Adding referance to all projects
13. Rename the Model folder to ViewModel
14. Change the namespace of errorViewModels.c file
 Test it = IT NOT WORKED																			  ..........ERROR..........
15. Error was The type or namespace name 'ErrorViewModel' could not be found PrabhjotBookStore
16. To solve this isssue I used using PrabhjotBookStore.Models.ViewModels;
 Test it = IT NOT WORKED																			  ..........ERROR..........
 Severity	Code	Description	Project	File	Line	Suppression State
17. The type or namespace name 'ErrorViewModel' PrabhjotBookStore
18. Again to solve this isssue I used using PrabhjotBookStore.Models.ViewModels; in Error.cshtml.g.cs file
 Test it = IT NOT WORKED
19. Added class Sd.cs to new project PrabhjotSinghBooks.Utility
20. Modify the properties of the Sd.cs class 
21. Adding referance to all projects
22. Add new (Customer) Area to Area
23. Change the route in startup file
24. Move the HomeController.cs to Area > Customer > Contollers
25. Delete the Data and Models foldes from the Area > Customer
26. Edit the HomeController.cs
27. Move the Home folder to Area's View 
 Test it = IT NOT WORKED																			  ..........ERROR..........
28. The same error i faced The type or namespace name 'ErrorViewModel' could not be found PrabhjotBookStore
29. Actually I forget to add @model PrabhjotBookStore.Models.ViewModels.ErrorViewModel in Error.cshtml file so i add it
Test it = IT WORKED 
30. Copy ViewImport and _ViewStart to Area's Home
31. Modify the _ViewStart.cshtml
32. Added new Admin area in  Area
33. Added proper view in Area's View