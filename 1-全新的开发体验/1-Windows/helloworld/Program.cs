using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webHostBuilder => webHostBuilder
                    .Configure(applicationBuilder => applicationBuilder.Run(
                        context => context.Response.WriteAsync("Hello world!"))))
                .Build()
                .Run();
        }
    }
}