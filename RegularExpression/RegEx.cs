using System;
using System.Text.RegularExpressions;

namespace BridgeLabzApp.RegularExpression
{
    public class RegEx
    {
        public static void Main(string[] args)
        {
            
            string pattern = "Gaurav";
            string pattern1 = @"(^|\s)Gaurav(\s|$)";

            Console.WriteLine("Name Match: " + Regex.IsMatch("Gaurav Gupta", pattern));


            //email
            string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            string email = "gauravgupta@gmail.com";
            Console.WriteLine("Email Match: " + Regex.IsMatch(email, emailPattern));


            //phone number
            string phonePattern = @"^(\+91[-\s]?)?[6-9]\d{9}$";

            string phone = "+91 9876543210";
            Console.WriteLine("Phone Match: " + Regex.IsMatch(phone, phonePattern));
        }
    }
}
