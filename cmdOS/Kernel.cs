using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace cmdOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Hello User! thank for using cmdOS, this is a basic command OS!");
        }

        protected override void Run()
        {
            
            var input = Console.ReadLine();
            // var version == "0.1.2";
            // Console.Write("Type here: ");

            if (input == "help")
            {
                Console.WriteLine("-----COMMAND TO USING:--------------");
                Console.WriteLine("help: Display this text");
                Console.WriteLine("about: About the OS and version");
                Console.WriteLine("hi: Hi for my os! :) (Joke Command)");
                Console.WriteLine("cls or clear: clean all line command");
                Console.WriteLine("-----SYSTEM COMMAND-----------------");
                Console.WriteLine("system info or sys info: Display info of the system cmdOS");
                Console.WriteLine("credits: Give you a list of member who make this cmdOS!");
                Console.WriteLine("-----UPDATE LOG---------------------");
                Console.WriteLine("update log list: list of the log was change on cmdOS");
            }
            if (input == "update log list")
            {
                Console.Clear();
                Console.WriteLine("UPDATE LOG: VERSION " + "0.1.2");
                Console.WriteLine("Add New command");
                Console.WriteLine("Remove The cmdOS Boot");
                Console.WriteLine("");
                Console.WriteLine("That all, this just a little update");
            }
            if (input == "about")
            {
                Console.WriteLine("cmdOS: version " + "0.1.2");
                Console.WriteLine("For the first using, please type 'help' for more command to use!");
            }
            if (input == "hi")
            {
                Console.WriteLine("Hello, wellcome to my OS!");
            }
            if (input == "cls")
            {
                Console.Clear();
            }
            if (input == "clear")
            {
                Console.Clear();
            }
            if (input == "system info")
            {
                Console.Clear();
                Console.WriteLine("System Info: cmdOS");
                Console.WriteLine("Version: " + "0.1.2");
            }
            if (input == "sys info")
            {
                Console.Clear();
                Console.WriteLine("System Info: cmdOS");
                Console.WriteLine("Version: " + "0.1.2");
            }
            if (input == "credits")
            {
                Console.WriteLine("Huy1234TH: Creator of cmdOS");
            }
        }
    }
}
