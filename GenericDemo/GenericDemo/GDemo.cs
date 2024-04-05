/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class GDemo
    {
        public void display(int[] ele)
        {
            foreach (int var in ele)
            {
                Console.WriteLine(var + " ");
            }
        }

        public static void display2<T>(T[] ele)
        {
            foreach (T var in ele)
            {
                Console.WriteLine(var + " ");
            }
        }

        public static void Main(string[] args)
        {
            SamplePrgrams sp = new SamplePrgrams();
            int[] ints = { 1, 2, 3 };
            char[] ch = { 'a', 'b', 'c' };
            string[] s = { "harsha", "bc" };

            display2(s);
            sp.display(ints);
        }
    }
}
*/


namespace GenericLargestInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("enter first number");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter third number");
            int third = Convert.ToInt32(Console.ReadLine());

            int largestInt = FindLargest(first, second, third);

            Console.WriteLine($"largest number is {largestInt}");*/

            // float datatype

            /*            Console.WriteLine("enter first number");
                        float first = float.Parse(Console.ReadLine());

                        //float first = Convert.(Console.ReadLine());

                        Console.WriteLine("enter second number");
                        float second = float.Parse(Console.ReadLine());

                        Console.WriteLine("enter third number");
                        float third = float.Parse(Console.ReadLine());

                        float largestInt = FindLargest(first, second, third);

                        Console.WriteLine($"largest number is {largestInt}");*/

            // 
            Console.WriteLine("enter first string");
            string s1= Console.ReadLine();

            Console.WriteLine("enter second string");
            string s2 = Console.ReadLine();

            Console.WriteLine("enter third string");
            string s3 = Console.ReadLine();

            string largestString = FindLargest(s1, s2, s3);

            Console.WriteLine($"largest number is {largestString}");

        }

        static T FindLargest<T>(T first, T second, T third) where T : IComparable<T>
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
             {
                return second;
            }
            else
            {
                return third;
            }


        }
    }
}
