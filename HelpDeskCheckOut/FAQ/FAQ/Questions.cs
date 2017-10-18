using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FAQ
{
    public class Questions
    {
        const int LOWER_BOUND = 1;
        const int EXIT = 11;

        public static void DisplayMessage()
        {

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("************* Welcome to the Frequently Asked Questions Section ****************");
            Console.WriteLine("");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("Here are a list of the ten most asked questions that users can solve on their own!!");
            Console.WriteLine("");
            
            
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Question 1: How Do I Keep My Laptop’s Battery In Good Health?");
            Console.WriteLine("");
            Console.WriteLine("Question 2: What do Viruses, Trojans, and Other Malware Actually Do?");
            Console.WriteLine("");
            Console.WriteLine("Question 3: What’s Wrong with Using Public Wi-Fi?");
            Console.WriteLine("");
            Console.WriteLine("Question 4: Do I Really Need to “Eject” USB Drives?");
            Console.WriteLine("");
            Console.WriteLine("Question 5: How Can I Tell if an Email Is Spam?");
            Console.WriteLine("");
            Console.WriteLine("Question 6: Why Are Cables So Gosh Darn Expensive?");
            Console.WriteLine("");
            Console.WriteLine("Question 7: What Happens When a Site I Use Gets “Hacked?”");
            Console.WriteLine("");
            Console.WriteLine("Question 8: Why Do I Need to Keep Resetting My Router?");
            Console.WriteLine("");
            Console.WriteLine("Question 9: Will I Get Caught If I Download a Movie on BitTorrent?");
            Console.WriteLine("");
            Console.WriteLine("Question 10: Do I Really Need to Care About My Privacy Online?");
            Console.WriteLine("");
            Console.WriteLine("Exit 11");
        }


        public static bool CheckOption(int option)
        {

            return (option > 0 && option < 12);
        }

        public static int GetMenuOption(int option)
        {        
            do
            {
                Console.Write("Please enter your choice <1....11>: ");

                if (CheckOption(option))
                {
                    Console.WriteLine("\nERROR! Option must be either 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, or 11");
                    DisplayMenu();
                }
                else if (option == 1)
                {
                    Console.WriteLine("Question 1: How Do I Keep My Laptop’s Battery In Good Health?");
                    Console.WriteLine("");
                    string line;
                    string file = "Battery In Good Health.txt";
                    StreamReader myfile = new StreamReader(file);

                    while (myfile.EndOfStream == false)
                    {
                        line = myfile.ReadLine();
                        Console.WriteLine(line);

                    }
                    Console.ReadLine();
                    myfile.Close();
                    DisplayMenu();


                }
                else if (option == 2)
                {
                    Console.WriteLine("Question 2: What do Viruses, Trojans, and Other Malware Actually Do");
                    Console.WriteLine("");
                    string line;
                    string file = "What do Viruses, Trojans, and Other Malware Actually Do.txt";
                    StreamReader myfile = new StreamReader(file);

                    while (myfile.EndOfStream == false)
                    {
                        line = myfile.ReadLine();
                        Console.WriteLine(line);

                    }
                    Console.ReadLine();
                    myfile.Close();
                    DisplayMenu();

                }
                else if (option == 3)
                {
                    Console.WriteLine("Question 3: What’s Wrong with Using Public Wi-Fi?");
                    Console.WriteLine("");
                    string line;
                    string file = "What’s Wrong with Using Public Wi-Fi.txt";
                    StreamReader myfile = new StreamReader(file);

                    while (myfile.EndOfStream == false)
                    {
                        line = myfile.ReadLine();
                        Console.WriteLine(line);

                    }
                    Console.ReadLine();
                    myfile.Close();
                    DisplayMenu();
                }
                else if (option == 4)
                {
                    Console.WriteLine("Question 4: Do I Really Need to “Eject” USB Drives?");
                    Console.WriteLine("");
                    string line;
                    string file = "Do I Really Need to “Eject” USB Drives.txt";
                    StreamReader myfile = new StreamReader(file);

                    while (myfile.EndOfStream == false)
                    {
                        line = myfile.ReadLine();
                        Console.WriteLine(line);

                    }
                    Console.ReadLine();
                    myfile.Close();
                    DisplayMenu();
                }
                else if (option == 5)
                {
                    Console.WriteLine("Question 5: How Can I Tell if an Email Is Spam?");
                    Console.WriteLine("");
                    string line;
                    string file = "How Can I Tell if an Email Is Spam.txt";
                    StreamReader myfile = new StreamReader(file);

                    while (myfile.EndOfStream == false)
                    {
                        line = myfile.ReadLine();
                        Console.WriteLine(line);

                    }
                    Console.ReadLine();
                    myfile.Close();
                    DisplayMenu();
                }
                else if (option == 6)
                {
                    Console.WriteLine("Question 6: Why Are Cables So Gosh Darn Expensive?");
                    Console.WriteLine("");
                    string line;
                    string file = "Why Are Cables So Gosh Darn Expensive.txt";
                    StreamReader myfile = new StreamReader(file);

                    while (myfile.EndOfStream == false)
                    {
                        line = myfile.ReadLine();
                        Console.WriteLine(line);

                    }
                    Console.ReadLine();
                    myfile.Close();
                    DisplayMenu();
                }
                else if (option == 7)
                {
                    Console.WriteLine("Question 7: What Happens When a Site I Use Gets “Hacked?”");
                    Console.WriteLine("");
                    string line;
                    string file = "What Happens When a Site I Use Gets Hacked.txt";
                    StreamReader myfile = new StreamReader(file);

                    while (myfile.EndOfStream == false)
                    {
                        line = myfile.ReadLine();
                        Console.WriteLine(line);

                    }
                    Console.ReadLine();
                    myfile.Close();
                    DisplayMenu();
                }
                else if (option == 8)
                {
                    Console.WriteLine("Question 8: Why Do I Need to Keep Resetting My Router?");
                    Console.WriteLine("");
                    string line;
                    string file = "Why Do I Need to Keep Resetting My Router.txt";
                    StreamReader myfile = new StreamReader(file);

                    while (myfile.EndOfStream == false)
                    {
                        line = myfile.ReadLine();
                        Console.WriteLine(line);

                    }
                    Console.ReadLine();
                    myfile.Close();
                    DisplayMenu();
                }
                else if (option == 9)
                {
                    Console.WriteLine("Question 9: Will I Get Caught If I Download a Movie on BitTorrent?");
                    Console.WriteLine("");
                    string line;
                    string file = "Will I Get Caught If I Download a Movie on BitTorrent.txt";
                    StreamReader myfile = new StreamReader(file);

                    while (myfile.EndOfStream == false)
                    {
                        line = myfile.ReadLine();
                        Console.WriteLine(line);

                    }
                    Console.ReadLine();
                    myfile.Close();
                    DisplayMenu();
                }
                else if (option == 10)
                {
                    Console.WriteLine("Question 10: Do I Really Need to Care About My Privacy Online?");
                    Console.WriteLine("");
                    string line;
                    string file = "Do I Really Need to Care About My Privacy Online.txt";
                    StreamReader myfile = new StreamReader(file);

                    while (myfile.EndOfStream == false)
                    {
                        line = myfile.ReadLine();
                        Console.WriteLine(line);

                    }
                    Console.ReadLine();
                    myfile.Close();
                    DisplayMenu();
                }
                else if (option == 11)
                {
                    return option;
                }
                } while (CheckOption(option));

            return option;
         }

    }
}
