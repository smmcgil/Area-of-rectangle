using System;
using System.Text.RegularExpressions;

namespace ArrayChallenge
{
    class Program
    {
        static void Main()
        {
            string[] strArr = new string[4];
            int idx = 4;
            Console.WriteLine($"Input 4 coordinates to identify the area of a rectangle on a coordinate plane.");
            for (int i = 0; i < 4; i++)
            {

                Console.WriteLine($"Please input {idx} more coordinates with a space between them.");

                string input = Console.ReadLine();

                    strArr[i] = input;

                    idx--;
 

                
                
            }
            ArrayChallenge(strArr);
        }

        static void ArrayChallenge(string[] strArr)
        {
            List<int> x = new List<int>();
            List<int> y = new List<int>();

            foreach (string str in strArr)
            {
                string[] parts = str.Split(' ');
                int convertX = int.Parse(parts[0].Trim('(', ')'));
                int convertY = int.Parse(parts[1].Trim('(', ')'));
                x.Add(convertX);
                y.Add(convertY);
            }
            int xmin = x.Min();
            int xmax = x.Max();
            int ymin = y.Min();
            int ymax = y.Max();

            int xresult = Math.Abs(xmin - xmax);
            int yresult = Math.Abs(ymin - ymax);

            Console.WriteLine($"The area of the rectangle is {xresult * yresult}.");
            Main();

        }
    }
    }