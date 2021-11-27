using System;

namespace DotnetScriptHelpers
{
    public class OutputHelper
    {
        public static void WriteSuccess(string text)
        {
            WriteLine(text, ConsoleColor.Green);
        }

        public static void WriteError(string text)
        {
            WriteLine(text, ConsoleColor.Red);
        }

        public static void WriteWarning(string text)
        {
            WriteLine(text, ConsoleColor.DarkYellow);
        }


        public static void WriteInfo(string text)
        {
            WriteLine(text, ConsoleColor.DarkCyan);
        }
        
        public static int ReturnSuccess(string text)
        {
            WriteLine(text, ConsoleColor.Green);
            return 0;
        }
        
        public static int ReturnError(string text)
        {
            WriteLine(text, ConsoleColor.Red);
            return 1;
        }
        
        public static int ReturnWarning(string text)
        {
            WriteLine(text, ConsoleColor.DarkYellow);
            return 0;
        }


        public static int ReturnInfo(string text)
        {
            WriteLine(text, ConsoleColor.DarkCyan);
            return 0;
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