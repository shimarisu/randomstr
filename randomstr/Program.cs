using System;
using randomstr;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            String chars = "ABCDEFGHIJKLIMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/!$%&'()=~|@`[]{}*+<>?_;:,.\\";
            char[] charArray = chars.ToCharArray();
            String randomStr = "";
            int size = 32;
            Random cRondom = new System.Random();
            for (int i = 0; i < size; i++)
            {
                int len = chars.Length;
                int rndNum = cRondom.Next(len);
                randomStr = randomStr + charArray[rndNum];
            }
            Console.WriteLine(randomStr);

            int sizetype = sizeof(Char);
            Console.WriteLine(sizetype);
            Console.WriteLine("Size of Char: {0}",sizetype);
            Crow c1 = new Crow();
            c1.Sing();
        }
    }
}
