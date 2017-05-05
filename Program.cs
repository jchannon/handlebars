using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HandlebarsDotNet;
using Microsoft.AspNetCore.Hosting;

namespace handlebars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string source =
                               @"<div class=""entry"">
                                <h1>{{title}}</h1>
                                <div class=""body"">
                                    {{body}}
                                </div>
                                </div>";

            var template = Handlebars.Compile(source);

            var data = new
            {
                title = "My new post",
                body = "This is my first post!"
            };

            var result = template(data);

            Console.WriteLine(result);

            // var host = new WebHostBuilder()
            //     .UseKestrel()
            //     .UseContentRoot(Directory.GetCurrentDirectory())
            //     .UseKestrel()
            //     .UseStartup<Startup>()
            //     .Build();

            // host.Run();
        }
    }
}
