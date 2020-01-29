using System;


namespace hw_test
{
    class Program
    {
        static string Encrypt(string value, int shift)
        {
            shift %= 26;
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shift);
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                // Store.
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        static string Decrypt(string value, int shift)
        {
            return Encrypt(value, 26 - shift);
        }


        static void Main(string[] args)
        {
            bool Continue = true;

            Console.WriteLine("      Ceasar Cipher");
            Console.WriteLine("-------------------------\n");

            while (Continue)
            {
                try
                {
                    Console.WriteLine("\nType a string to encrypt:");
                    string UserString = Console.ReadLine();

                    Console.Write("\nShift: ");
                    int key = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nEncrypted Data: ");

                    string cipherText = Encrypt(UserString, key);
                    Console.WriteLine(cipherText);
                    Console.Write("\n");

                    Console.WriteLine("Decrypted Data:");

                    string t = Decrypt(cipherText, key);
                    Console.WriteLine(t);

                    Console.WriteLine("\nDo you want to continue?");
                    Console.WriteLine("Type in Yes to continue or press any other key and then press enter to quit:");
                    string response = Console.ReadLine();
                    Continue = (response == "Yes");

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You entered a bad operation, try another one");
                }
            }

        }
    }
}
