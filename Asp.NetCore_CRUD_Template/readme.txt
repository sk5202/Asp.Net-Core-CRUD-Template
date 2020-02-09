This is demo template of asp.net core application.

1) Go appsetting.json file and replace with your orignal connection string database name must be new.

    Server=yourservername;Database=aspnetcoregamedb;User ID=sa;Password=yourserverpassword;MultipleActiveResultSets=True;

2) In this template we are creating database using code first migration.

    Add below two command at package manager console respectively
      
         add-migration game
         Update-database

3) Run your application