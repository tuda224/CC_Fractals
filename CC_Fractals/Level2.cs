using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CC_Fractals
{
    public static class Level2
    {
        public static void Run()
        {
            var input = ReadInput();
            var splittedInput = input.Split(' ');

            var type = splittedInput[0];
            var length = double.Parse(splittedInput[1].Split('=')[1]);
            var iterations = double.Parse(splittedInput[2].Split('=')[1]);

            double result = 0.0;
            if (type.Equals("tri"))
            {
                result = ((3.0 * (length)) * Math.Pow(4.0 / 3.0, iterations));
                Console.WriteLine(Math.Round(result));
            }
            else if (type.Equals("sq"))
            {
                result = ((4.0 * (length)) * Math.Pow(5.0 / 3.0, iterations));
                Console.WriteLine(Math.Round(result));
            }
        }

        private static string ReadInput()
        {
            Console.WriteLine("Provide path to input file:");
            var filePath = Console.ReadLine();
            var input = File.ReadAllText(filePath);
            return input;
        }
    }
}