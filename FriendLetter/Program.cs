using Microsoft.AspNetCore.Builder; // access tools to create/configure a web app to host
using Microsoft.Extensions.DependencyInjection; // access tools to add services to the app, dependency is a class used within another class, injection of the new dependencies where they are needed throughout the web app 

namespace FriendLetter
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args); // create a new instance of the WebApplicationBuilder class

      builder.Services.AddControllersWithViews(); // add the MVC service to the app

      WebApplication app = builder.Build(); // creates and returns our web app host

      app.UseRouting(); // specifies we want our host to match the website URL to routes that we create within our app

      app.MapControllerRoute( // establishes a convention for our routes to follow -- the default pattern
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run(); // tells our app to listen for HTTP requests and respond to them with our routes, run the Host!
    }
  }
}