﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SerilogPro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                            //.ConfigureLogging((hostingContext, builder) => builder.AddFile("Logs/app-{Date}.txt"))
                            .UseStartup<Startup>()
                            .Build();
        }
    }
}
