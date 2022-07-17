using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Mail: ");
            string mailAd = Console.ReadLine();

            Console.Write("Password: ");
            string pass = Console.ReadLine();


            Login(mailAd, pass);
        }
        public static void Login(string mail, string password)
        {
            try
            {
                if (mail != Authentification.Mail || password != Authentification.Password)
                {
                    throw new Authentification("Mail ve ya Password sehvdir");
                }
                Console.WriteLine("Giris olundu");
            }
            catch (Exception message)
            {

                Console.WriteLine(message.Message); ;
            }
        }
    }
    public class DivideExceptions : Exception
    {
        public DivideExceptions(string message) : base(message)
        {

        }
    }
    public class CheckNames : Exception
    {
        public CheckNames(string message) : base(message)
        {

        }
    }
    public class Authentification : Exception
    {
        public static string Mail = "ramilrb@code.edu.az";
        public static string Password = "Ramil2002";
        public Authentification(string message) : base(message)
        {

        }

    }
   
}
