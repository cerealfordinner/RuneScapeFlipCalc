using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ask
    {
        public string AskString(string text)
        {
            Console.WriteLine(text);
            return (Console.ReadLine());
        }
    }
}
