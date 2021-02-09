using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CC_Fractals
{
    public static class Level1
    {
        public static void Run()
        {
            var input = ReadInput();
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