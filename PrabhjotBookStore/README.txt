﻿﻿Starting time = 11-04-2023 1123
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

1120

10. Then create readme md file
11. Then create readme text file

1126

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

1133

2. Added new files wwwroot > lib > bootstrap > dist > css
 Test it = IT WORKED
3. Rename the original site.css file to site_o.css
4. Add new site.css file

1137

5. Update the navbar-light to navbar dark and bg-white to bg-primary and footer
 Test it = IT WORKED

 1138

6. Update _Layout.cshtml file
 Test it = IT WORKED

 1141

7. Adde the additional stylesheets and scripts to _Layout.cshtml file

1142

8. Add dropdown menu and items 
Test it = IT WORKED 
9. Commint to Github

-------COMPLETED STEP 1.3 BOOTSTRAP-------

-------START STEP 1.4 Add Projects & Modify-------

Starting time = 11-04-2023 1145

1. Added new project PrabhjotBooks.DataAccess

1148

2. Added new project PrabhjotBooks.Models

1149

3. Added new project PrabhjotBooks.Utility

1151

4. Move Data folder in PrabhjotBooks.DataAccess from PrabhjotBookStore

1155

5. Installed Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages

1156

6. Delete the migration folder

1158

7. Install Identity.EntityFrameworkCore

1200

8. Delete the class1.cs file from the all new three project
 Test it = IT NOT WORKED																			  ..........ERROR..........
9. Error was type or namespace Data does not exist in the PrabhjotBookStore
10. to solve this isssue I add references to PrabhjotBooks.DataAccess
 Test it = IT WORKED
11. Move model folder to new project PrabhjotSinghBooks.Models project

1208


12. Adding referance to all projects

1214

13. Rename the Model folder to ViewModel

1216

14. Change the namespace of errorViewModels.c file
 Test it = IT NOT WORKED																			  ..........ERROR..........

 1224

15. Error was The type or namespace name 'ErrorViewModel' could not be found PrabhjotBookStore
16. To solve this isssue I used using PrabhjotBookStore.Models.ViewModels;
 Test it = IT NOT WORKED																			  ..........ERROR..........
 Severity	Code	Description	Project	File	Line	Suppression State
17. The type or namespace name 'ErrorViewModel' PrabhjotBookStore
18. Again to solve this isssue I used using PrabhjotBookStore.Models.ViewModels; in Error.cshtml.g.cs file
 Test it = IT NOT WORKED

 1226

19. Added class Sd.cs to new project PrabhjotSinghBooks.Utility

1228

20. Modify the properties of the Sd.cs class 
21. Adding referance to all projects

1233

22. Add new (Customer) Area to Area

1235

23. Change the route in startup file

1237

24. Move the HomeController.cs to Area > Customer > Contollers

1238

25. Delete the Data and Models foldes from the Area > Customer

1240

26. Edit the HomeController.cs

1242

27. Move the Home folder to Area's View 
 Test it = IT NOT WORKED																			  ..........ERROR..........
28. The same error i faced The type or namespace name 'ErrorViewModel' could not be found PrabhjotBookStore
29. Actually I forget to add @model PrabhjotBookStore.Models.ViewModels.ErrorViewModel in Error.cshtml file so i add it
Test it = IT WORKED 

1252

30. Copy ViewImport and _ViewStart to Area's Home

1253

31. Modify the _ViewStart.cshtml

1255

32. Added new Admin area in  Area

1257

33. Added proper view in Area's View

1258

34. Delete the Data and Models foldes from the Area's Admin


0101

35. Delete the empty Controller from prabhjotbookStore
Test it = IT WORKED
36. Commint to Github

Completed time 11-04-2023 0100

-------COMPLETED STEP 1.4 Add Projects & Modify-------

-------PART 2-------

-------START STEP 2.1 Create the DB-------

﻿Starting time = 11-04-2023 0107

1. Update the appsetting.json 

0115

2. Add migration but it failed
 NOT WORKED																		                       ..........ERROR..........
3. Actually not choosed the correct project which was(prabhjotBooks.DataAccess)
 NOW IT WORKED
4. The migration entry (20231104171407_DefaultIdentityMigration.cs)                                 <=================

0116

5. Update the database

0127

6. Add new class Category.cs in PrabhjotBooks.Models

0128

7. Modify the Category.cs in PrabhjotBooks.Models

0131

8. Add migration CategoryToDb

0133

9. Update the ApplicationdbContext file and give reference

0148

10. Re-run the migration CategoryToDb
 NOT WORKED																		                       ..........ERROR..........

 0152

11. Error was CategoryToDb is used by existing migration
12. To solve this issue i delete the previous CategoryToDb migration file and re-run command
13. The category migration entry (20231104174021_CategoryToDb.cs)                                   <=================
 NOW IT WORKED
 Test it = IT WORKED
14. Commint to Github

-------COMPLETED STEP 2.1 Create the DB-------

-------START STEP 2.2 Repository-------

﻿Starting time = 11-04-2023 0202

1. Add new folder Repository in PrabhjotBooks.DataAccess

0203

2. Add new folder IRepository inside Repository in Prabhjotbooks.DataAccess

0205

3. Update PrabhjotBookStore.csproj

0207

4. Added new class (IRepository.cs) in IRepository folder

0211

5. Modify the class IRepository.cs

0216

6. Added new class (Repository.cs) in Repository folder 

0227

7. Modify the class Repository.cs

0228

8. Added new class (ICategoryRepository.cs) in IRepository folder 


0229

9. Added new class (CategoryRepository.cs) in Repository folder 

0231

10. Modify the class ICategoryRepository.cs

0233

11. Modify the class CategoryRepository.cs
 Test it = IT WORKED
12. Commint to Github

0236

13. Added new interface (ISP_Call.cs) in IRepository folder 

0241
14. Modify the interface ISP_Call.cs by installing latest Dapper

0249

15. Added new class (SP_Call.cs) in Repository folder 

0251

16. Modify the class (SP_Call.cs) in Repository folder

0252

17. Update the class (SP_Call.cs) in Repository folder

0254

18. Added new interface (IUnitOfWork.cs) in IRepository folder 

0256

19. Modify the new interface (IUnitOfWork.cs) in IRepository folder 
20. Added new class (UnitOfWork.cs) in Repository folder

0301

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

﻿Starting time = 11-06-2023 0452

1. Added new controller (CategoryControllers) in Admin' Contollers

0454

2. Modify the CategoryControllers file

0456

3. Added new folder category in Admin's View

0457

4. Added New view Index.cshtml in new Category folder

0459

5. Modify the new Index.cshtml

0524

6. Adding category option in conten-management dropdown menu

0532

7. Adding icons in index.cshtml file

0535

8. Adding new js file in wwroot folder

1259

9. Modify the _layoutschtml file

﻿Starting time = 11-06-2023 0102

10. Added Delete and View button in index.cshtml

0106

11. Add new razor view (Upsert) in Admin's Category

0108

12. Add new razor view (_CreateAndBackToListButton) in Admin's Category

0110

13. Add new razor view (_EditAndBackToListButton) in Admin's Category

0111

14. Modify the _CreateAndBackToListButton and _EditAndBackToListButton

0121

15. Modify the index.cshtml file

0135

16. Modify the CategoryControllers file

0251

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

1256

2. Create CovertypeRepository class and ICoverTypeRepository interface
3. Added covertype to UnitOfWork class and IUnitOfWork interface

0103

4. Add migration (20231116214144_CoverTypeDefault.cs)                                 <=================
5. update database

0515

6. Create new folder covertype

0516

7. Added Index and upsert view 
8. Update _Layout.cshtml file
9. Create new js file and link it
  Test it = IT WORKED
10. Commint to Github

-------COMPLETED STEP 3.1 Cover Type CRUD-------

-------START STEP 3.2 Product CRUD-------

﻿Starting time = 11-16-2023 0518

1. Added new class Product.cs

0528

2. Modify Product class

0534

3. Adding migration															                           ..........ERROR..........
4. Migration is empty
5. To solve this issue i add references and re add migratiom
 It Worked
6. Migration Entry (20231116225423_addProductToDo.cs)                                <=================
7. Add references

0605

8. Another migration entry (20231116225701_addValidationToProduct.cs)                <=================

0618

9. Create ProductRepository class and IProductRepository interface
10. Added covertype to UnitOfWork class and IUnitOfWork interface

0619

11. Modify the ProductRepository
  Test it = IT WORKED
12. Commint to Github

-------COMPLETED STEP 3.2 Cover Type CRUD-------

-------START STEP 3.2 Product CRUD 2-------

﻿Starting time = 11-16-2023 0626

1. Added new controller ProductController

0644

2. Modify the ProductController

0646

3. Create new class in model project ProductVM

0711

4. Modify the new class ProductVM

0717

5. Created new Folder prduct

0718

6. Added new view in Product folder

0726

7. Modify the index.cshtml view
8. Added new js file

0728

9. Modify the _Layout.cshtml file
  Test it = IT WORKED
10. Commint to Github

-------COMPLETED STEP 3.2 Product CRUD 2-------

-------START STEP 3.2 Product CRUD 3-------

﻿Starting time = 11-16-2023 0728

1. Added Upsert view to Area/Admin/Views

0739

2. MOdify the upsert

0741

3. Cretae a folder (images) and a sub folder (products)
4. Uncomment the code in productcontroller

﻿Starting time = 11-20-2023 1214

5. Added tiny style into upsert.cshtml file

﻿Starting time = 11-21-2023 1103

6. Try to run the program in another pc 
  NOT WORKED							                                                          ..........BIG ERROR..........
7. I run the command update-database i face a error
 Cannot find the object "Products" because it does not exists 
8. So solve this issue i delete the previous both product's migrations and re-run but this my migration 
   is empty so i comment the product code in application db context file,  Unitofwork and in 
   productrepository now
9. Again delete the product migration and re run migration it worked but in migartion i don't have complete code
10. So now I Last time deletet the migratoion  and Uncomment the product code from the three file
11. Re-run the product migration command
  Test it = IT WORKED
12. But I comment the drop table code from the migration file to run the update-database code
  Test it = IT WORKED
13. Uncomment the code from the migration file 
  Test it = IT WORKED
14. Unforunately this solution not work when i try to run this in another pc
  NOT WORKED							                                                          ..........SAME BIG ERROR..........
15. This time I find easy and simple solution
16. I simply delete the validation migration file
  Test it = IT WORKED

﻿Starting time = 11-23-2023 0210

17. Facing an error while creating product 														       ..........ERROR..........
18. Error is = An error occurred while updating the entries. See the inner exception for details.'
19. To solve this issue I notic i write category id instaed of cvertype id in upsert.cshtml file in 84 line
  Test it = IT WORKED

﻿Starting time = 11-23-2023 0406

20. While making record in product i face new error
21. Requested unknown parameter 'price' for row 0, column 2. For more information about this error,          ..........ERROR..........
22. To solve this issue i changed the price name in js to listPrice
  Test it = IT WORKED

 0411

23. For diing new fiels i update the product class
24. Delete the old mgration

 0414

25. Added new migration (20231123211358_addProductToDo)  <================
 
  0419

26. Update the Upsert.cshtml and ProductRepository file

 0422

27. Update the index.cstml file for displaying images on fromt page
28. Update the Homecontroller 

 0444

29. Update the Layout.cshtml page

 ﻿Starting time = 11-27-2023 0401

30. Mistakely I created three extra price fields 
31. To remove this i update the product class
32. Re add migration

0211

33. Added images in the product folder

  ﻿Starting time = 11-29-2023 1159

34. Add the Ddetail view in the Customer > Views > Home

1201

35. Link to Home COntroller

1202

36. Added Edit Button and modify the detail view code

1216

37. Give Style to Detail

  ﻿Starting time = 11-30-2023 1002

38. Modify the code of Detail View

1211

39. Add the Covertype and Category lists in the detail view and delete some images

0201

40. Try to add seedData
41. Make Class AllSeedData (in this class I am adding the 5 records of Category, 5 of Covertype and 3 of Product)
42. Conect it to the startup.cs file

0207

43. Add the migration 

0212

44. Update the database

  ﻿Starting time = 12-04-2023 1206

45. Everything is running good but i have an error
46. Error is when I try to update the database it show error that product name table already exists so 
47. To solve this issue I go to view > Sql server object exploer > (localdb) > Database > my table and delete the product table by manuall

0222

48. Update the text readme
49. Updatr the md readme
50. Check it running properly? No

  ﻿Starting time = 12-05-2023 0124

51. I faced same error table name alreday exists
52. To solve this issue i make a code in migration file migrationBuilder.Sql("DROP TABLE IF EXISTS dbo.Products");
53. Now this will delete the previous table Products and then update database
  Test it = IT WORKED
 Commint to Github

   -------COMPLETED STEP 3.2 Product CRUD 3 and 3.4-------