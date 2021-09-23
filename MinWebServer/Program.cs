using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
namespace MinWebServer
{
    class App
    {
        static void Main()
        {
            new WebHostBuilder()
                .UseKestrel()
                .Configure(app => app.Run(context => context.Response.WriteAsync("<h1>Min web server Hello World !</h1>")))
                .Build()
                .Run();
        }
    }
}
