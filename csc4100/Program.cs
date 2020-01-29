using System;

namespace csc4100
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("What is your Name?->");
            string theName = Console.ReadLine();

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("What is your age? or Enter STOP to Stop->");
                string sAge = Console.ReadLine();
                string s2 = "STOP";
                    if (string.Compare(sAge, "STOP") == 0)
                {
                    Console.Write("\n OK, I will Stop");
                    break;
                }
                Console.WriteLine("\n theName={0} and Age={1}", theName, sAge);

                int age = int.Parse(sAge);
                if (age>=16 && age < 195)
                {
                    Console.Write("Yes, you can drive");
                }
                else if (age>=18 && age < 195)
                {
                    Console.Write("Yes, you can vote");
                }
                else if (age>=21 && age < 195)
                {
                    Console.Write("Yes, you can drink");
                }
                else
                {
                    Console.Write("Sorry, you have no right to do anything");
                }
            }
        }
    }
}
