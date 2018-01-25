using System;

namespace randomstr
{
    class Program
    {
        static void Main(string[] args)
        {
            String chars = "ABCDEFGHIJKLIMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/!$%&'()=~|@`[]{}*+<>?_;:,.\\";
            char[] charArray = chars.ToCharArray();
            String randomStr = "";
            int size = 10;
            Random cRondom = new System.Random();
//            int i;
            for (int i = 0; i < size; i++)
            {
                int len = chars.Length;
                int rndNum = cRondom.Next(len);
                randomStr = randomStr + charArray[rndNum];
            }
            Console.WriteLine(randomStr);
        }
    }
}
