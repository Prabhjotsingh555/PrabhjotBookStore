﻿Starting time = 11-04-2023 1123
Program name = PrabhjotBookStore
Program Purpose = Making a MVC project advanced
Program author = Prabhjot Singh

I am making this again because my previous one is not working when i clone it my three project not found
and i solve this by not selecting place solution and repository in same loctaion.

-------PART 1-------

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
34. Delete the Data and Models foldes from the Area's Admin
35. Delete the empty Controller from prabhjotbookStore
Test it = IT WORKED
36. Commint to Github

Completed time 11-04-2023 0100

-------COMPLETED STEP 1.4 Add Projects & Modify-------

-------PART 2-------

-------START STEP 2.1 Create the DB-------

﻿Starting time = 11-04-2023 0107

1. Update the appsetting.json 
2. Add migration but it failed
 NOT WORKED																		                       ..........ERROR..........
3. Actually not choosed the correct project which was(prabhjotBooks.DataAccess)
 NOW IT WORKED
4. The migration entry (20231104171407_DefaultIdentityMigration.cs)                                 <=================
5. Update the database
6. Add new class Category.cs in PrabhjotBooks.Models
7. Modify the Category.cs in PrabhjotBooks.Models
8. Add migration CategoryToDb
9. Update the ApplicationdbContext file and give reference
10. Re-run the migration CategoryToDb
 NOT WORKED																		                       ..........ERROR..........
11. Error was CategoryToDb is used by existing migration
12. To solve this issue i delete the previous CategoryToDb migration file and re-run command
13. The category migration entry (20231104174021_CategoryToDb.cs)                                   <=================
 NOW IT WORKED
 Test it = IT WORKED
14. Commint to Github

-------COMPLETED STEP 2.1 Create the DB-------

-------START STEP 2.2 Repository-------

1. Add new folder Repository in PrabhjotBooks.DataAccess
2. Add new folder IRepository inside Repository in Prabhjotbooks.DataAccess
3. Update PrabhjotBookStore.csproj
4. Added new class (IRepository.cs) in IRepository folder 
5. Modify the class IRepository.cs
6. Added new class (Repository.cs) in Repository folder 
7. Modify the class Repository.cs
8. Added new class (ICategoryRepository.cs) in IRepository folder 
9. Added new class (CategoryRepository.cs) in Repository folder 
10. Modify the class ICategoryRepository.cs
11. Modify the class CategoryRepository.cs
 Test it = IT WORKED
12. Commint to Github
13. Added new interface (ISP_Call.cs) in IRepository folder 
14. Modify the interface ISP_Call.cs by installing latest Dapper
15. Added new class (SP_Call.cs) in Repository folder 
16. Modify the class (SP_Call.cs) in Repository folder
17. Update the class (SP_Call.cs) in Repository folder
18. Added new interface (IUnitOfWork.cs) in IRepository folder 
19. Modify the new interface (IUnitOfWork.cs) in IRepository folder 
20. Added new class (UnitOfWork.cs) in Repository folder 
21. Modify the class (UnitOfWork.cs) in Repository folder

﻿Starting time = 11-06-2023 0439

22. Trying to add services.AddScoped<IUnitOfWork, UnitOfWork>(); in startup.cs file
 NOT WORKED																		                                                          ..........ERROR..........
23. The type or namespace name 'IUnitOfWork' could not be found (are you missing a using directive or an assembly reference?)
24. To solve thias issue i apply both references using PrabhjotBooks.DataAccess.Repository;,  using PrabhjotBooks.DataAccess.Repository.IRepository;
 NOT WORKED																		                                                          ..........BIG ERROR..........
25. 	'IUnitOfWork' is inaccessible due to its protection leveland
26. The type 'PrabhjotBooks.DataAccess.Repository.UnitOfWork' cannot be used as type parameter 'TImplementation' 
    in the generic type or method 'ServiceCollectionServiceExtensions.AddScoped<TService, TImplementation>(IServiceCollection)'. 
    There is no implicit reference conversion from 'PrabhjotBooks.DataAccess.Repository.UnitOfWork' to 
    'PrabhjotBooks.DataAccess.Repository.IRepository.IUnitOfWork'.	
27. To solve this issue I make public interface in IUnitOfWork and
28. I put : IUnitOfWork in UnitofWork and implement interface
 NOW IT WORKED
  Test it = IT WORKED
29. Commint to Github

-------COMPLETED STEP 2.2 Repository-------

-------START STEP 2.3 Category CRUD-------

1. Added new controller (CategoryControllers) in Admin' Contollers
2. Modify the CategoryControllers file
3. Added new folder category in Admin's View
4. Added New view Index.cshtml in new Category folder
5. Modify the new Index.cshtml
6. Adding category option in conten-management dropdown menu
7. Adding icons in index.cshtml file
8. Adding new js file in wwroot folder
9. Modify the _layoutschtml file
10. Added Delete and View button in index.cshtml
11. Add new razor view (Upsert) in Admin's Category
12. Add new razor view (_CreateAndBackToListButton) in Admin's Category
13. Add new razor view (_EditAndBackToListButton) in Admin's Category
14. Modify the _CreateAndBackToListButton and _EditAndBackToListButton
15. Modify the index.cshtml file
16. Modify the CategoryControllers file
17. Add the delete functionin in js file and update both readmes
  Test it = IT NOT WORKED
18. Try to add data in tablee but it no add							                                                          ..........BIG ERROR..........
19. The error was DataTables warning: teble id = tbldata- Ajax error. 
20. I solve this issue by updating database and re write the category.js code also by rechecking all files
  Test it = IT WORKED
29. Commint to Github

-------COMPLETED STEP 2.3 Category CRUD-------

-------PART 3-------

-------START STEP 3.1 Cover Type CRUD-------

﻿Starting time = 11-16-2023 1244

1. Added new class CoverType.cs to model project
2. Create CovertypeRepository class and ICoverTypeRepository interface
3. Added covertype to UnitOfWork class and IUnitOfWork interface
4. Add migration (20231116214144_CoverTypeDefault.cs)                                 <=================
5. update database
6. Create new folder covertype
7. Added Index and upsert view 
8. Update _Layout.cshtml file
9. Create new js file and link it
  Test it = IT WORKED
10. Commint to Github

-------COMPLETED STEP 3.1 Cover Type CRUD-------

-------START STEP 3.2 Product CRUD-------

﻿Starting time = 11-16-2023 0518

1. Added new class Product.cs
2. Modify Product class
3. Adding migration															                           ..........ERROR..........
4. Migration is empty
5. To solve this issue i add references and re add migratiom
 It Worked
6. Migration Entry (20231116225423_addProductToDo.cs)                                <=================
7. Add references
8. Another migration entry (20231116225701_addValidationToProduct.cs)                <=================
9. Create ProductRepository class and IProductRepository interface
10. Added covertype to UnitOfWork class and IUnitOfWork interface
11. Modify the ProductRepository
  Test it = IT WORKED
12. Commint to Github

-------COMPLETED STEP 3.2 Cover Type CRUD-------