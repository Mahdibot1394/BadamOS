using System;

namespace BadamOS
{
    public class Commands
    {
        public static void clear()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("BadamOS | The Iranian Operating System");
        }
        public static void version()
        {
            Console.WriteLine(Variables.Version);
        }
        public static void about()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(Variables.About);
        }
        public static void help()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("pak/clear : Clear the Screen | noskhe/version : It says the version of system | inchie/about : About this operating system | khamosh/poweroff/shutdown : Goes off the system" +
                "| reboot/dobare/restart");

        }
        public static void poweroff()
        {
            Cosmos.System.Power.Shutdown();
        }
        public static void reboot()
        {
            Cosmos.System.Power.Reboot();
        }
        public static void OpenApp()
        {
            Console.WriteLine("Open? > "); Console.ReadLine();
            Console.Write("Helllo World!");
        }
        public static void invalid()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Command is Invalid . Try Again");
        }

    }
}
