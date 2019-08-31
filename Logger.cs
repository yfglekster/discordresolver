using System;
using System.Collections.Generic;
using System.Drawing;

namespace discordresolver
{
    class Logger
    {
        static string logger_name = "discordresolver";

        static string get_time()
        {
            return DateTime.Now.ToString("h:mm:ss ");
        }

        static void print(string format, Color color)
        {
            Colorful.Console.Write(format, color);
        }

        static void rainbow_print(List<char> format, Color start_color, Color end_color)
        {
            Colorful.Console.WriteWithGradient(format, start_color, end_color, 14);
        }

        public void info(string format)
        {
            print(get_time(), Color.White);
            print("[", Color.White);
            print(logger_name, Color.Magenta);
            print("] ", Color.White);
            print("INFO ", Color.Green);
            print(format, Color.White);
            print("\n", Color.White);
        }

        public void debug(string format)
        {
            print(get_time(), Color.White);
            print("[", Color.White);
            print(logger_name, Color.Magenta);
            print("] ", Color.White);
            print("DEBUG ", Color.Yellow);
            print(format, Color.White);
            print("\n", Color.White);
        }

        public void error(string format)
        {
            print(get_time(), Color.White);
            print("[", Color.White);
            print(logger_name, Color.Magenta);
            print("] ", Color.White);
            print("ERROR ", Color.Red);
            print(format, Color.White);
            print("\n", Color.White);
        }

        public void custom(string format, string custom, Color custom_color)
        {
            print(get_time(), Color.White);
            print("[", Color.White);
            print(logger_name, Color.Magenta);
            print("] ", Color.White);
            print($"{custom} ", custom_color);
            print(format, Color.White);
            print("\n", Color.White);
        }

        public void rainbow(string format, Color start_color, Color end_color)
        {
            List<char> chars = new List<char>();
            chars.AddRange(format);
            print(get_time(), Color.White);
            print("[", Color.White);
            print(logger_name, Color.Magenta);
            print("] ", Color.White);
            rainbow_print(chars, start_color, end_color);
            print("\n", Color.White);
        }
    }
}
