using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Привет, привет мир Май! май труд ".ToLower();
            var result = str.Split(new[] { ' ', '.', ',', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key);
            foreach (var item in result) Console.Write(item + " ");
            Console.ReadLine();
        }
    }
}
