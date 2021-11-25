using System;

namespace DotnetScriptHelpers
{
    public class OutputHelper
    {
        public static void Success(string text)
        {
            WriteLine(text, ConsoleColor.Green);
        }
        
        public static void Error(string text)
        {
            WriteLine(text, ConsoleColor.Red);
        }

        public static void Warning(string text)
        {
            WriteLine(text, ConsoleColor.DarkYellow);
        }


        public static void Info(string text)
        {
            WriteLine(text, ConsoleColor.DarkCyan);
        }
        
        public static void WriteLine(string text, ConsoleColor? color = null)
        {
            if (color == null)
            {
                Console.WriteLine(text);
                return;
            }

            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color.Value;
            Console.WriteLine(text);
            Console.ForegroundColor = oldColor;
        }
    }
}