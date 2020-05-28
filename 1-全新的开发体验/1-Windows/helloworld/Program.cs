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
                .ConfigureWebHost(webHostBuilder => webHostBuilder
                    .UseKestrel()
                    .UseUrls("http://0.0.0.0:3721", "https://0.0.0.0:9527")
                    .Configure(applicationBuilder => applicationBuilder.Run(
                        context => context.Response.WriteAsync("Hello world!"))))
                .Build()
                .Run();
        }
    }
}