using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, password;
            Console.WriteLine("login: ");
            login = Console.ReadLine();
            Console.WriteLine("password: ");
            password = Console.ReadLine();
            if (login == "admin" && password == "pass1234")
            {
                Console.WriteLine("welcome,admin!");
            }
            else
            {
                Console.WriteLine("login failed.try again.");
            }
            

        }
    }
}
