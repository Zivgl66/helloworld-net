// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Get the version of the assembly.
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            Console.WriteLine($"Version: {version}");
        }
    }
}
