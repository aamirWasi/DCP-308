using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                string input = Console.ReadLine();
                string[] numbers = Regex.Split(input, @"\D+");
                foreach (string value in numbers)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        if (input.Contains("Shuvo nobo borsho"))
                        {
                            int i = int.Parse(value);
                            int yr = i + 650;
                            string pattern = @"\bShuvo nobo borsho \b" + i;
                            string replace = "Shuva naya barsha " + yr;
                            string res = Regex.Replace(input, pattern, replace);
                            Console.WriteLine($"{res}");
                        }
                        else if (input.Contains("Shuva naya barsha"))
                        {
                            int i = int.Parse(value);
                            int yr = i - 650;
                            string pattern = @"\bShuva naya barsha \b" + i;
                            string replace = "Shuvo nobo borsho " + yr;
                            string res = Regex.Replace(input, pattern, replace);
                            Console.WriteLine($"{res}");
                        }
                    }
                }
            }
        }
    }
}
