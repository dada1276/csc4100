using System;

namespace HW1_1 {
    class Program {
        static string Encipher(string value, int shift)
        {
            shift %= 26;
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (letter == ' ')
                    continue;
                letter = (char)(letter + shift);
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        public static string Decipher(string input, int key) {
            return Encipher(input, 26 - key);
        }


        static void Main(string[] args) {

            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            int key = -5;
            Console.Write("Enter ENCODE or DECODE or STOP ->> ");
            string code = Convert.ToString(Console.ReadLine());
            if (code == "STOP")
            {
                System.Environment.Exit(0);
            } else { 

            Console.WriteLine("\n- - ->>>DECODING STRING - - - - - ->>>>>>");
            Console.WriteLine("- - - - - - Result - - - - - - - ");

            
            string cipherText = Encipher(UserString, key);
            Console.WriteLine("\nDecode String = " + cipherText);
            Console.Write("\n");

            
            string t = Decipher(cipherText, key);
            Console.WriteLine("Orginal String = " + t);
            Console.WriteLine("\nTop Secret: Agent DA's Message Decorder!");


            Console.ReadKey();
            }
        }
    }
}
