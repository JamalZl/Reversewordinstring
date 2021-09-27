using System;

namespace Reverseword
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            string empstr = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                empstr += str[i];
            }
            Console.WriteLine(Revsentence(empstr));
        } static string Revsentence(string arr1)
        {
            string[] newarr = arr1.Split(" ");
            foreach (string item in newarr)
            {
                //Console.WriteLine(item);
            }
            string temp = newarr[0];
            newarr[0] = newarr[1];
            newarr[1] = temp;
            //Console.WriteLine(newarr[0]);
            //Console.WriteLine(temp);
            string newstr = newarr[0] + " " + temp;
            //Console.WriteLine(newstr);
            //Console.WriteLine(newarr[0]);
            return newstr;
        }

    }
          
}
