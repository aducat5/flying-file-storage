# Welcome to the test-case for Flying Monkey!

This app contains three main parts;
- Backend .NET Core API Project is located in *FileViewer.Web.Api* folder.
- Frontend ANgular Project is located in *fileviewer-web-client* folder.
- Database MongoDB is located on atlas cloud service of mongoDB. (connection string is located in *FileViewer.Web.Api\appsettings.json*)

# Requirements
  - dotnet runtime for API project
  - angular cli for Angular project
  - an internet connection for db

- clone the project


# To run the Frontend Angular Project,
 - open a terminal
 - cd *fileviewer-web-client*
 - ng serve --open

# To run the Backend .NET Core API Project,
  
  ## If you have visual studio  
  - find and open the solution(.sln file) in *FileViewer.Web.Api* folder folder
  - hit f5 to run the project

  ## If you want to use terminal
  - open a terminal
  - cd *FileViewer.Web.Api*
  - dotnet publish
  - dotnet .\FileViewer.Web.Api\bin\Debug\net5.0\publish\FileViewer.Web.Api.dll


## If you want to self-host the DB,
 - dummy data that i used is located in *sampleData* folder.
 - just import the .json file to a mongoDB
 - update the connection string located in *FileViewer.Web.Api\appsettings.json* 
