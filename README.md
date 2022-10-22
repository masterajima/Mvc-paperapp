Program Name: PaperWebApp
Program Author: Ajima Master
Student ID: 0771451
Date Started: 2022-10-08


----- Commands You Will Need To Build This Project -----

1. Install-Package Microsoft.EntityFrameworkCore.SqlServer --Version 3.1
2. add-migration PaperrApp -Context PaperAppContext
3. update-database -Context PaperAppContext


-- 9:10PM --
created the ZipperApp
commented out ssl port so this project will work at school
added a controller called HelloWorldController.cs 

-- 9:25PM -- 
time to create a view
view created
   -->Views/HelloWorld/Welcome.cshtml
   view created for the HelloWorldController
    **testing results: successful**
time to add a paper model

problem: cannot install EFCore
solution: --Version extension
         --Version 3.1.0 solved my issue

-- 10:25PM --
successfully added the zipper model
now time to *scaffold*


-- 12:51AM --
-- the date is now 2022-10-09, and after a long reset, we finally have a successful scaffold!
  -> problem: i forgot to add the connection string for PaperAppContext in appsettings.json
  -> problem: was making a typo in the Startup.ConfigureServices method
  -> problem: was not making use of the -Context extension in my package manager console to choose which context i wanted to work with
            -> -Context PaperAppContext    solved my problem

Date Modified: 2022-10-09

-- 8:35PM --

time to add database
database created 
SeedData.cs class created in Models folder
SeedData has 10 products and their properties
have to run to see if seeding data was successful
        -> add-migration ZipperApp -Context PaperAppContext
        -> seeding: successful

-- 10:00PM --
upload progress to gitHub
time to add Search functionality!
- search by name first
   ->completed
     ->test result: success

- search by category next
    -> success!

Date Modified: 2022-10-10

-- 3:00PM --
I debug index.chhtml for model object, so I will add that next
    -> success! users can now edit product ratings

-- 3:15PM --
time for validation
    -> validation successfully added

Time for the fun part!! Adding Styles!!

-- 7:45PM --
added link to my paper page to the home screen of my web app
instead of products displaying in a table, they now display in divs!!
these divs contain all information of the product, and are displayed 3 in a row
the footer is now dimgrey

-- GOALS FOR NEXT DAY OF DEVELOPMENT --
- pick a cool font
- change background colour of header
- find some pictures of zip paper or gift paper
- maybe some cool card animation for content
- about gifts (About Us)
    -> display in sections
    -> hard coded 

Date Modified: 2022-10-11

-- 8:35AM --

Links for paper pictures 
https://www.bing.com/images/search?view=detailV2&ccid=trDnBmXp&id=1FED910E8B10FFACCE356B69E9B4940718055502&thid=OIP.trDnBmXpL_SAl5HW5EeizwHaFn&mediaurl=https%3a%2f%2fwww.paperpapers.com%2fnews%2fwp-content%2fuploads%2f2018%2f06%2f61qSdyDYbZL._SL1185_.jpg&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.b6b0e70665e92ff4809791d6e447a2cf%3frik%3dAlUFGAeUtOlpaw%26pid%3dImgRaw%26r%3d0&exph=899&expw=1185&q=paper&simid=608032572081444944&FORM=IRPRST&ck=75A6265821E42FEE5F78D7FBD830F111&selectedIndex=6&ajaxhist=0&ajaxserp=0

i have added the gift card and the paper types to the About Us page


Date Modified: 2022-10-12

-- 9:00PM --

added some content to my homepage
fixed my about us page layout 
made a mobile view for the About Us page


Date Modified: 2022-10-13

-- 10:00AM --
lets add product images!!
product images are seeded into database only! users cannot create product with images. maybe another project

-- 10:15PM -- 
I have changed the view for the home page once again.

-- 10:30PM --
Time to add the last round of styles

Date Modiefied: 2022-10-14
-- 1:37AM --
got a little carried away with the styles...we now have a desktop, tablet and mobile view!!
         -> breakpoints: 810px, 650px
there may be some last minute styles added later...who knows.. 
