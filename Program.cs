using System;
using System.Threading.Channels;


//AUTHOR: BONGANI MAGWA
namespace CastingCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            foreach (char character in name)
            {
                if (char.IsLetter(character))
                {
                    Console.WriteLine("proceede");
                } else if (char.IsDigit(character))
                {
                    Console.WriteLine("invalid name: " + character);
                }

            }
            Console.Write("Enter Your years of experience: ");
            
            int expwerience  = Convert.ToInt32(Console.ReadLine());
            if(expwerience > 5)
            {
                Console.WriteLine("START YOUR SIDE HUSTLE");
            } else
            {
                Console.WriteLine("KEEP WORKING HARD!!!!!");
            }
            Console.WriteLine("Hi " + name + " you're " + expwerience + " OF EXPERIENCE GREATE WORK BRO!");
            Console.ReadLine();
        }
    }
}