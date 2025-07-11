using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace BadamOS
{
    public class UI
    {
        public static void DefaultLook()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("================================================================================");
            Console.WriteLine("BadamOS Booted Successfully: " + Variables.Version);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(Variables.WelcomeText);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

        }
        public static void NextLineRestore() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("================================================================================");
        }
        public static void Endline()
        {
            Console.WriteLine("================================================================================");
        }
        public static void RunMessage()
        {
            Console.WriteLine("BadamOS UI Boot Successfully : " + Variables.Version);
        }
        
public class Element
        {
            public static Dictionary<string, string> ElementTypes = new Dictionary<string, string>()
    {
        {"Text", "--"},
        {"Button", "[]"},
        {"Input", "||"},
        {"Frame", "{}"}
    };

            public string Type = "";
            public string Text = "";

            public string Content
            {
                get
                {
                    if (ElementTypes.ContainsKey(Type))
                    {
                        string symbols = ElementTypes[Type];
                        return symbols[0] + Text + symbols[1];
                    }
                    return Text;
                }
            }
        }


        public static class App
        {
            public static string Content = "";

            public static void Provide(Element element)
            {
                Content += element.Content + "\n";
            }

            public static void ShowContent()
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                
                Console.WriteLine("================================================================================");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Content);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("================================================================================");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
