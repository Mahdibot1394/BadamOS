using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using BadamOS;
using Cosmos.Common;
using Cosmos.Core;
using Cosmos.Core.IOGroup;
using Cosmos.Debug;
using Cosmos.HAL;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using static BadamOS.UI;
using Sys = Cosmos.System;

namespace BadamOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
             Console.Clear();
             UI.RunMessage();
            UI.DefaultLook();
            Element loginButton = new Element();
            loginButton.Type = "Button";
            loginButton.Text = "Enter";

            App.Provide(loginButton);
            App.ShowContent();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }

        protected override void Run()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            UI.NextLineRestore();
            Console.Write("> ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
            UI.Element app;
            
        }

    }
}