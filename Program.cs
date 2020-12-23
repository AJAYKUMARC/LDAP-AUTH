using System;

namespace LDAPAuth
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth auth = new Auth();
            auth.ValidateUser("ajay","ajay@123");
            Console.WriteLine("Hello World!");
        }
    }
}
