using System;

namespace Reverseword
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            Console.WriteLine(Revsentence(str));
        } 
        static string Revsentence(string str1)
        {
            string empstr = string.Empty;
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                empstr += str1[i];
            }
            var buildtostr = empstr.ToString();//String builder bir string deyil.Ondan string almaq uchun ToStrin()-den istifade edirik
            string[] newarr = buildtostr.Split(" ");
            foreach (string item in newarr)
            {
                //Console.WriteLine(item);
            }
            string temp = newarr[0];
            newarr[0] = newarr[1];
            newarr[1] = temp;
            string newstr = newarr[0] + " " + temp;
            return newstr;
        }
    }
}
