using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Support;
using FAQ;
using System.IO;


namespace HelpDeskCheckOut
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MainMenu.MainDisplayMessage();
            MainMenu.MainMenuDisplay();
            
            var s = Console.ReadLine();
            int number;
            if (int.TryParse(s, out number))
            {
                MainMenu.GetMainMenuOption(number);
            }
            Console.ReadLine();

        }

    }
}
