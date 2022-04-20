using System.Text.RegularExpressions;

namespace DrawTableInConsole.Uliti.Common
{
    public static class Vadilator
    {
        // method vadiate email with rex
        public static bool IsEmail(string email)
        {
            return new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(email);
        }
        // method vadiate phone number with rex
        public static bool IsPhoneNumber(string phoneNumber)
        {
            return new Regex(@"^[0-9]{10,11}$").IsMatch(phoneNumber);
        }
       
    }
}