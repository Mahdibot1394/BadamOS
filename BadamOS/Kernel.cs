using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using BadamOS;
using Cosmos.Common;
using Cosmos.Core;
using Cosmos.Core.IOGroup;
using Cosmos.Debug;
using Cosmos.HAL;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using Cosmos.System.FileSystem;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;
using System.IO.Enumeration;
namespace BadamOS
{
    
    public class Kernel : Sys.Kernel
    {
        public CosmosVFS fs = new CosmosVFS();

        protected override void BeforeRun()
        {
            VFSManager.RegisterVFS(fs);
            Console.WriteLine("BadamOS Booted ...");
            Console.WriteLine("Go>"); Console.ReadLine();
            Commands.clear();

        }

        protected override void Run()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            var input = Console.ReadLine();
            switch (input)
            {
                default:
                    Commands.invalid(); break;
                case "help":
                    Commands.help(); break;
                case "clear":
                    Commands.clear(); break;
                case "version":
                    Commands.version(); break;
                case "about":
                    Commands.about(); break;
                case "poweroff": 
                    Commands.poweroff(); break;
                case "reboot":
                    Commands.reboot(); break;
                case "makebadamfile":
                    var available_space = fs.GetAvailableFreeSpace(@"0:\");
                    Console.WriteLine("Available Free Space: " + available_space);
                    var fs_type = fs.GetFileSystemType(@"0:\");
                    Console.WriteLine("File System Type: " + fs_type);
                    var files_list = Directory.GetFiles(@"0:\");
                    try
                    {

                        Console.Write("FileName");
                        var FileName = Console.ReadLine();
                        var file_stream = File.Create(@"0:\" + FileName);
                        foreach (var file in files_list)
                        {
                            Console.WriteLine(file);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case "makebadambotoxt":
                    Console.WriteLine("Badam OS - Nano Editor Test");
                    Apps.Botoxt.Run();
                    break;
                case "": 
                    break;

            }

        }

    }
}
