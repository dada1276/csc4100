using System;

namespace Intro2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] myList = new int[10];

            for (int i=0; i<10; i++)
            {
                Console.Write("\n i={0}", i);
                myList[i] = i*i;
            }
        }
    }
}
