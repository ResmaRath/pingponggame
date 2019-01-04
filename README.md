
# pingponggame
This a MVC project for pingpong player <br>
<br>
Technologies used: <br>
  Tools : VS 2017, MS SQL Server 17.9.1
  <br>
  MVC with Razor views. Enity Framework, Bootstrap, JS and CSS.
  <br>
  
  # How to run it? 
   Clone the project. 
  <br>
  Open Visual Studio
  <br>
 Tools -> Nuget Package Manager -> Package Manager Console  - run the following commands to create the database.
  <br>
 Add-Migration Initial
 <br> 
 The Add-Migration command generates code to create the initial database schema.
  <br>
 Update-Database
 <br>
 If you are doing from console, run the following command
 <br>
 dotnet ef migrations add Initial
 <br>
dotnet ef database update
<br>
<br>
Once its all done. Run the application. 

