using System;
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
            for(int t = 0; t < T; t++)
            {
                string input = Console.ReadLine();
                if (input.StartsWith("016") || input.StartsWith("88016"))
                {
                    Console.WriteLine($"{8801672994777} {"Airtel"}");
                }
                else if (input.StartsWith("018") || input.StartsWith("88018"))
                {
                    Console.WriteLine($"{88018} {"Robi"}");
                }
                else if (input.StartsWith("011") || input.StartsWith("88011"))
                {
                    Console.WriteLine($"{8801159213388} {"Citycell"}");
                }
                else if (input.StartsWith("015") || input.StartsWith("88015"))
                {
                    Console.WriteLine($"{01500000000} {"Teletalk"}");
                }
                else if (input.StartsWith("017") || input.StartsWith("88017"))
                {
                    Console.WriteLine($"{8801794061678} {"Grameenphone"}");
                }
                else if (input.StartsWith("019") || input.StartsWith("88019"))
                {
                    Console.WriteLine($"{8801978654333} {"Banglalink"}");
                }
            }
        }
    }
}
