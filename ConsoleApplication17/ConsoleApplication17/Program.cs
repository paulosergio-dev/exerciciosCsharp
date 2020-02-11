using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "one,two,three";

            string s2 = "one";
            s2 += ",two";
            s2 += ",three";

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("one");
            sb.Append(",two");
            sb.Append(",three");

            //s2.EndsWith("ree");
            //s2.Equals("");
            //s2.IndexOf("two");
            //sb.ToString().
            //s2.Insert(4, "OK");
            //s2.Length;
            //s2.Remove(4, 3);
            //s2.Replace("two", "one");
            string[] s3 = s2.Split(',');

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}