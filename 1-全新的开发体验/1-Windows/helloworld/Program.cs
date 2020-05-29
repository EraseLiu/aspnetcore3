using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webHostBuilder => webHostBuilder
                    .ConfigureServices(collection => collection
                        .AddRouting()
                        .AddControllersWithViews())
                    .Configure(applicationBuilder => applicationBuilder
                        .UseRouting()
                        .UseEndpoints(builder => builder.MapControllers())))
                .Build()
                .Run();
        }
    }
    
    public class HelloController : Controller
    {
        [HttpGet("/hello/{name}")]
        public IActionResult SayHello(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }

}