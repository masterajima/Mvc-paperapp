Program Name: ZipItWebApp
Program Author: Ajima Master
Student ID: 0771451
Date Started: 2022-10-08


----- Commands You Will Need To Build This Project -----

1. Install-Package Microsoft.EntityFrameworkCore.SqlServer --Version 3.1
2. add-migration ZipperApp -Context ZipperAppContext
3. update-database -Context ZipperAppContext


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
time to add a zipper model

problem: cannot install EFCore
solution: --Version extension
         --Version 3.1.0 solved my issue

-- 10:25PM --
successfully added the zipper model
now time to *scaffold*


-- 12:51AM --
-- the date is now 2022-10-09, and after a long reset, we finally have a successful scaffold!
  -> problem: i forgot to add the connection string for ZipperAppContext in appsettings.json
  -> problem: was making a typo in the Startup.ConfigureServices method
  -> problem: was not making use of the -Context extension in my package manager console to choose which context i wanted to work with
            -> -Context ZipperAppContext    solved my problem

Date Modified: 2022-10-09

-- 8:35PM --

time to add database
database created 
SeedData.cs class created in Models folder
SeedData has 10 products and their properties
have to run to see if seeding data was successful
        -> add-migration ZipperApp -Context ZipperAppContext
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
I forgot to add a rating field, so I will add that next
    -> success! users can now edit product ratings

-- 3:15PM --
time for validation
    -> validation successfully added

Time for the fun part!! Adding Styles!!

-- 7:45PM --
added link to my zippers page to the home screen of my web app
instead of products displaying in a table, they now display in divs!!
these divs contain all information of the product, and are displayed 3 in a row
the footer is now dimgrey

-- GOALS FOR NEXT DAY OF DEVELOPMENT --
- pick a cool font
- change background colour of header
- find some pictures of zippers
- maybe some cool zipper animation for content
- about employees (About Us)
    -> display in sections
    -> hard coded 

Date Modified: 2022-10-11

-- 8:35AM --

Links for employee pictures 
Roy - https://cdn.comedy.co.uk/images/library/people/180x200/t/the_it_crowd_roy.jpg
Maurice Moss - https://cdn.comedy.co.uk/images/library/people/180x200/t/the_it_crowd_moss.jpg
Jen Barber - https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRm7u2nf-llL4Xm54jqrAvl2ZsSGSbSQQG9fA&usqp=CAU

i have added the team shot and the team desciption to the About Us page
i have added my team members and their pictures and job descriptions to the About Us page.

Date Modified: 2022-10-12

-- 9:00PM --

added some content to my homepage
fixed my about us page layout 
made a mobile view for the About Us page

Facotry Image Source Link - https://fshoq.com/free-photos/p/232/abandoned-factory-in-hanover
Home Page Zipper Image Source Link - https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Zipper.svg/1283px-Zipper.svg.png

Date Modified: 2022-10-13

-- 10:00AM --
lets add product images!!
product images are seeded into database only! users cannot create product with images. maybe another project

-- 10:15PM -- 
I have changed the view for the product page once again. Now it matches the style of the emplyee page.

-- 10:30PM --
Time to add the last round of styles

Date Modiefied: 2022-10-14
-- 1:37AM --
got a little carried away with the styles...we now have a desktop, tablet and mobile view!!
         -> breakpoints: 810px, 650px
there may be some last minute styles added later...who knows.. 
