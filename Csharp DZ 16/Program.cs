using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Csharp_DZ_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2
             string pattern = @"^[0-9]*[.,][0-9]+$";
            var array = new[] {"3","1","4.5","3.12"};
            var regex = new Regex(pattern);
            foreach (var element in array)
            {
                Console.WriteLine(
                regex.IsMatch(element)? $"{element} - this is a fractional number " : $"{element} - it is not a fractional number");
            }
            Console.WriteLine(new string('~', 50));
            // 5
            // Email
            string pattern1 = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            var regex1 = new Regex(pattern1);
            if (regex1.IsMatch(email))
            {
                Console.WriteLine("Its correct email. Good!");
            }
            else
            {
                Console.WriteLine("Its incorrect email. Bad!");
            }
            // Password
            string pattern2 = @"^/.*([a-z]+[A-Z]+[0-9]+|[a-z]+[0-9]+[A-Z]+|[A-Z]+[a-z]+[0-9]+|[A-Z]+[0-9]+[a-z]+|[0-9]+[a-z]+[A-Z]+|[0-9]+[A-Z]+[a-z]+).*/";
            Console.Write("Enter password: ");
            string pass = Console.ReadLine();
            var regex2 = new Regex(pattern1);
            if (regex2.IsMatch(pass))
            {
                Console.WriteLine("Its correct password. Good!");
            }
            else
            {
                Console.WriteLine("Its incorrect password. Bad!");
            }
            // 6
            Console.WriteLine(new string('~', 50));
            string pattern3 = @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$";
            Console.Write("Enter date (2002/12/31): ");
            string date = Console.ReadLine();
            var regex3 = new Regex(pattern1);
            if (regex3.IsMatch(date))
            {
                Console.WriteLine("Its correct password. Good!");
            }
            else
            {
                Console.WriteLine("Its incorrect password. Bad!");
            }


        }
    }
}
