using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FAQ;

namespace HelpDeskCheckOut
{
    public class MainMenu
    {
        public static void MainDisplayMessage()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("********************** Welcome to the Help Desk Kiosk *************************");
            Console.WriteLine("");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue:");
            Console.ReadLine();
        }

        public static void MainMenuDisplay()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("************** Here you can choose from the following menu. *******************");
            Console.WriteLine("");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("1: Check out MiFI hotspot.");
            Console.WriteLine("");
            Console.WriteLine("2: Checkout Cellphone");
            Console.WriteLine("");
            Console.WriteLine("3: Check out Laptop");
            Console.WriteLine("");
            Console.WriteLine("4: Conference Room Reservations");
            Console.WriteLine("");
            Console.WriteLine("5: Frequently Asked Questions");
            Console.WriteLine("");
            Console.WriteLine("6: Technical Support");
            Console.WriteLine("");
            Console.WriteLine("7: *** Advanced Users Only ***");
            Console.WriteLine("");
            Console.WriteLine("8: Exit");
        }
        public static bool CheckOption(int option)
        {

            return (option > 0 && option < 8);
        }

        public static int GetMainMenuOption(int option)
        {
            do
            {
                Console.Write("Please enter your choice <1....8>: ");

                if (CheckOption(option))
                {
                    Console.WriteLine("\nERROR! Option must be either 1, 2, 3, 4, 5, 6, 7 or 8");
                    MainMenuDisplay();
                }
                else if (option == 1)
                {
                    Console.WriteLine("1: Check out MiFI hotspot.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    MainMenuDisplay();
                }
                else if (option == 2)
                {
                    Console.WriteLine("2: Checkout Cellphone");
                    Console.WriteLine("");
                                       
                    Console.ReadLine();
                    MainMenuDisplay();
                }
                else if (option == 3)
                {
                    Console.WriteLine("3: Check out Laptop");
                    Console.WriteLine("");
                    Console.ReadLine();
                    MainMenuDisplay();
                }
                else if (option == 4)
                {
                    Console.WriteLine("4: Conference Room Reservations");
                    Console.WriteLine("");

                    Console.ReadLine();
                    MainMenuDisplay();
                }
                else if (option == 5)
                {
                    Console.WriteLine("5: Frequently Asked Questions");
                    Console.WriteLine("");
                    Console.ReadLine();

                    Questions.DisplayMessage();
                    Questions.DisplayMenu();
                    Console.ReadLine();
                    var s = Console.ReadLine();
                    int number;
                    if (int.TryParse(s, out number))
                    {
                        Questions.GetMenuOption(number);
                    }
                    MainMenuDisplay();
                }
                else if (option == 6)
                {
                    Console.WriteLine("6: Technical Support");
                    Console.WriteLine("");
                    Console.ReadLine();
                    MainMenuDisplay();
                }
                else if (option == 7)
                {
                    Console.WriteLine("7: *** Advanced Users Only ***");
                    Console.WriteLine("");
                    Console.ReadLine();
                    MainMenuDisplay();
                }
                else if (option == 8)
                {
                    return option;
                }
            } while (CheckOption(option));
            
            return option;

;
    }

    }

}
