using RusCheckersLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Drawing;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> points = new List<int>();
            points.Add(22);
            points.Add(33);
            points.Add(33);
            string msg = JsonSerializer.Serialize(points);
            Console.WriteLine(msg);
            List<int> poits2 = JsonSerializer.Deserialize<List<int>>(msg);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
