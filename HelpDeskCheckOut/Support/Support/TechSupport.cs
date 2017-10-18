using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support
{
    class TechSupport
    {
        const int LOWER_BOUND = 1;
        const int EXIT = 7;

        public static void DisplayMessage()
        {
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("********************* Welcome to the Technical Support Section *********************");
            Console.WriteLine("");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("Here is information about technical support!");
            Console.WriteLine("");
        }
        public static void DisplayMenu()
        {

            Console.WriteLine("1: Call In");
            Console.WriteLine("");
            Console.WriteLine("2: Managed services");
            Console.WriteLine("");
            Console.WriteLine("3: Self-help");
            Console.WriteLine("");
            Console.WriteLine("4: Multi-tiered technical support");
            Console.WriteLine("");
            Console.WriteLine("5: Remote computer repair");
            Console.WriteLine("");
            Console.WriteLine("6: Scams");
            Console.WriteLine("");
            Console.WriteLine("7: Exit");
        }


        public static bool CheckOption(int option)
        {

            return (option > 0 && option < 12);
        }

        static int GetMenuOption(int lower, int upper)
        {
            int option;
            bool notValidMenuOption = true;

            do
            {
                Console.Write("Please enter your choice <1....7>: ");
                option = int.Parse(Console.ReadLine());

                notValidMenuOption = CheckOption(option);

                if (notValidMenuOption)
                {
                    Console.WriteLine("\nERROR! Option must be either 1, 2, 3, 4, 5, 6, or 7");
                    DisplayMenu();
                }
                else if (option == 1)
                {


                    Console.WriteLine("");
                    Console.WriteLine("Call In");
                    Console.WriteLine("");
                    Console.WriteLine("Call in hours 7:45 am until 4:15 pm");
                    Console.WriteLine("Call in number (208) 426-1000");
                    Console.WriteLine("");

                }
                else if (option == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Managed services");
                    Console.WriteLine("");
                    Console.WriteLine("Managed services means a company will receive a list of well-defined services on an ongoing basis, with well-defined 'response and resolution times' for a fixed rate or a flat fee. This can include things like 24/7 monitoring of servers, 24/7 help desk support for daily computer issues, and on-site visits by a technician when issues cannot be resolved remotely.");
                    Console.WriteLine("");

                }
                else if (option == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Self-help");
                    Console.WriteLine("");
                    Console.WriteLine("Self-help: Almost all tech brands and service providers give free access to a rich library of technical support solutions to users. These are huge databases of step-by-step solutions, however if you visit the support sites for big brands the solutions are more often for their products alone. Another method of getting technical support that’s gained popularity is to follow troubleshooting steps shown in a support video.");
                    Console.WriteLine("");

                }
                else if (option == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Multi-tiered technical support");
                    Console.WriteLine("");
                    Console.WriteLine("Tier 0 (or self-help) is in the form of 'wikis' or FAQs that allow for users to access and resolve information on their own rather than have to contact a local Helpdesk or Service Desk for resolution.");
                    Console.WriteLine("");
                    Console.WriteLine("Tier I (or Level 1, abbreviated as T1 or L1) is the initial support level responsible for basic customer issues. It is synonymous with first-line support, level 1 support, front-end support, support line 1, and various other headings denoting basic level technical support functions.");
                    Console.WriteLine("");
                    Console.WriteLine("Tier II (or Level 2, abbreviated as T2 or L2) is a more in-depth technical support level than Tier I and therefore costs more as the technicians are more experienced and knowledgeable on a particular product or service. It is synonymous with level 2 support, support line 2, administrative level support, and various other headings denoting advanced technical troubleshooting and analysis methods.");
                    Console.WriteLine("");
                    Console.WriteLine("Tier III (or Level 3, abbreviated as T3 or L3) is the highest level of support in a three-tiered technical support model responsible for handling the most difficult or advanced problems. It is synonymous with level 3 support, 3rd line support, back-end support, support line 3, high-end support, and various other headings denoting expert level troubleshooting and analysis methods. These individuals are experts in their fields and are responsible for not only assisting both Tier I and Tier II personnel, but with the research and development of solutions to new or unknown issues. Note that Tier III technicians have the same responsibility as Tier II technicians in reviewing the work order and assessing the time already spent with the customer so that the work is prioritized and time management is sufficiently utilized.");
                    Console.WriteLine("");
                    Console.WriteLine("While not universally used, a fourth level often represents an escalation point beyond the organization. Tier IV (or Level 4, abbreviated as T4 or L4) is generally a hardware or software vendor.");
                    Console.WriteLine("");

                }
                else if (option == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Remote computer repair");
                    Console.WriteLine("");
                    Console.WriteLine("Remote computer repair is a method for troubleshooting software related problems via remote desktop connections.");
                    Console.WriteLine("");

                }
                else if (option == 6)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Scams");
                    Console.WriteLine("");
                    Console.WriteLine("A common scam typically involves a cold caller claiming to be from a technical support department of a company like Microsoft. Such cold calls are often made from call centers based in India to users in English-speaking countries. The scammer will instruct the user to download a remote desktop program and once connected, use social engineering techniques that typically involve Windows components to persuade the victim that they need to pay in order for the computer to be fixed and then proceeds to steal money from the victim's credit card.");
                    Console.WriteLine("");
                    
                    
                }
                else if (option == 7)
                {
                    return option;
                }
            } while (notValidMenuOption);

            return option;
        }
    }
}

