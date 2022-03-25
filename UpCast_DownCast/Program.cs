using System;
using UpCast_DownCast.Models;
namespace UpCast_DownCast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius celcius = new Celsius(25);
            Kelvin kelvin = celcius;
            Console.WriteLine((kelvin.Degree)+" K");
        }
    }
}
