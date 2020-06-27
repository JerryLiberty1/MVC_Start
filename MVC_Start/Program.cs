using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MVC_Start
{
  public class Program
  {
    public static void Main(string[] args)
    {
      BuildWebHost(args).Run();
            Console.WriteLine("Jerry is smart person who loves cookies"); //Comments by Manoj
            Console.WriteLine("Jerry is great"); //Comments by Manoj
            Console.WriteLine("Jerry is great and loves cookies and yogurt");




        }

        public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
  }
}
