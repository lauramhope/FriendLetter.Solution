MVC
1. the model = what defines our objects, represents the data
  -Triangle class = the model
2. the view = what users see on the website, the user interface
  -uses a .cshtml extension = supports both html and CS logic
  -Views folder is divided into subdirectories, one for each controller
3. the controller = the mechanism that routes website traffic

ASP.NET Core MVC = framework to build web apps
server-side framework = request-response loop, client and server have back and forth convo

## What Is This?

This is a finished example repo corresponding to the LearnHowToProgram.com walkthrough on creating a very simple web app with ASP.NET Core MVC and C#. The first lesson of this walkthrough is [Constructing and Configuring an ASP.NET Core Project](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/constructing-and-configuring-an-asp-net-core-project).

## How To Run This Project

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called "FriendLetter". 
3. Run `dotnet run`.
4. Open the browser to _http://localhost:5000_.

## Available Routes

* localhost:5000/
* localhost:5000/hello
* localhost:5000/goodbye
* localhost:5000/form
