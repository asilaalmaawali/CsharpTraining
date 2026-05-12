using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Principal;
using System.Transactions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // System Setup  -- declare variables
            Console.WriteLine("=== SYSTEM SETUP  —  Enter Account &Customer Data ===");
            Console.WriteLine("--- Account Profile --");
            int accountNumber = 0;
            Console.WriteLine("1)  Account Number ");
            string holderName;
            Console.WriteLine("2)  Holder Name ");
            double balance = 0.000;
            Console.WriteLine("3)  Balance ");
            bool isActive = false;
            Console.WriteLine("4)  Account Active  ");
            char accountType;
            Console.WriteLine("5)  Account Type  ");
            Console.WriteLine("--- Customer Profile ---");
            bool isEmployed = false;
            Console.WriteLine("6)  Employed  ");
            double salary = 0.000;
            Console.WriteLine("7)  Monthly Salary  ");
            int creditScore = 0;
            Console.WriteLine(" 8)  Credit Score  ");
            int age = 0;
            Console.WriteLine(" 9)  Age  ");
            Console.WriteLine("---Transaction Data ---");
            double deposit = 0.000;
            Console.WriteLine("10) Last Deposit Amount  ");
            double withdrawal = 0.000;
            Console.WriteLine("11) Last Withdrawal ");
            double annualRate = 0.000;
            Console.WriteLine("12) Annual Interest Rate ");
            double avgBalance = 0.000;
            Console.WriteLine("13) Avg Monthly Balance ");

            Console.WriteLine("0)  Setup complete — launch Main Menu");
            Console.WriteLine("Select option:  ");
            int option= int.Parse(Console.ReadLine());

            while (option != 0) {          // i used while != 0 , so if not equal to 0 it will not go out , if equal =0 they move to Main menu

                switch (option)
                {
                    case 1:
                        Console.Write("enter account number");
                        accountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Account Number set to:  " + accountNumber);
                        break;

                    case 2:
                        Console.Write(" Enter holder name ");
                        holderName = Console.ReadLine();
                        Console.WriteLine("Holder name set to:  " + holderName);
                        break;

                    case 3:
                        Console.Write(" Enter balance(OMR):  ");
                        balance = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Balance set to:   " + balance + " OMR");
                        break;
                   
                    case 4:
                         Console.Write(" enter 1=active / 0=inactive    ");
                         int ActiveStatus = int.Parse(Console.ReadLine());
                         if (ActiveStatus == 1) {

                          isActive= true;
                          Console.WriteLine(" Your account set to active ");

                                            }
                    else
                    {
                          Console.WriteLine(" Your account set to inactive ");

                                            }

                                    break;

                    case 5:
                        Console.Write(" Enter your Account Type [enter S / C / F] :      ");
                        accountType = char.Parse(Console.ReadLine());
                        Console.WriteLine(" Account Type set to:  " + accountType);

                        break;

                    case 6:
                        Console.Write(" Employed? [enter 1=yes / 0=no] :        ");
                        int EmployedStatus = int.Parse(Console.ReadLine());
                        if (EmployedStatus == 1)
                        {

                            isActive = true;
                            Console.WriteLine(" Employed ");

                        }
                        else
                        {
                            Console.WriteLine(" Not employed ");

                        }

                        break;

                    case 7:
                        
                        Console.Write(" Enter your Monthly Salary :   ");
                        salary = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Monthly salary set to:  " + salary + " OMR");
                        break;

                    case 8:
                        Console.Write(" Enter your creditScore :   ");
                        creditScore = int.Parse(Console.ReadLine());
                        Console.WriteLine(" creditScore set to:  " + creditScore);
                        break;

                    case 9:
                        Console.Write(" Enter your Age :   ");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine(" creditScore set to:  " + age);
                        break;

                    case 10:
                        Console.Write(" Enter your Last Deposit Amount :    ");
                        deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Last Deposit Amount set to:   " + deposit);
                        break;

                    case 11:
                        Console.Write(" Enter your Last withdrawal :  ");
                        withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Last withdrawal Amount set to:   " + withdrawal);
                        break;

                    case 12:
                        Console.Write(" Enter your Annual Interest Rate  :  ");
                        annualRate = double.Parse(Console.ReadLine());
                        Console.WriteLine("  Annual Interest Rate set to:    " + annualRate);
                        break;

                    case 13:
                        Console.Write(" Enter your  Avg Monthly Balance:   ");
                        avgBalance = double.Parse(Console.ReadLine());
                        Console.WriteLine("   Avg Monthly Balance set to:   " + avgBalance);
                        break;


                    default:
                        Console.WriteLine("Invalid option. Please choose 1–13 or 0 to finish.");
                        break;
                }
               Console.WriteLine("Select option:  ");                  // to choose again the options
               option = int.Parse(Console.ReadLine());
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("=== NATIONAL BANK OF OMAN  —  Unified Banking System ===");
            Console.WriteLine("MAIN MENU");
            Console.WriteLine(" 1) ATM Services  ");
            Console.WriteLine(" 2) Account Management   ");
            Console.WriteLine(" 3) Loan Services  ");
            Console.WriteLine(" 4) Currency Exchange  ");
            Console.WriteLine(" 5) Credit Card Portal  ");
            Console.WriteLine(" 6) Branch Services   ");
            Console.WriteLine(" 7) Reports & Admin    ");
            Console.WriteLine(" 8) [BONUS] Full Terminal    ");
            Console.WriteLine(" 0) Exit    ");
            Console.WriteLine(" Select number from Main Menu:  ");
            int Main_Menu = int.Parse(Console.ReadLine());


                switch (Main_Menu) // need to converted
                {
                case 1:                                   // Task 1 in main menu : ATM Welcome & Display
                    int ATM_MainMenu = -1;  // i declare it to -1 to use it in if condition (if  ATM_MainMenu == 0) , becuase if i dont declare any number will be error.
                    Console.WriteLine("=== ATM SERVICES ===");
                    Console.WriteLine("1) Bank Info");
                    Console.WriteLine("2) Branch Info");
                    Console.WriteLine("3) Opening Hours");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Select ATM services option:  ");
                    ATM_MainMenu = int.Parse(Console.ReadLine());
                    
                    while (ATM_MainMenu != 0)
                    {
                        switch (ATM_MainMenu)
                        {

                            case 1:
                                Console.WriteLine("Bank Info");
                                Console.WriteLine("Bank Name: National Bank of Oman");
                                Console.WriteLine("Tagline: “Unlocking Opportunities, As One");
                                Console.WriteLine("Founded: 1973");
                                break;

                            case 2:
                                Console.WriteLine("Branch Info");
                                Console.WriteLine(" branch name: Qurum Branch");
                                Console.WriteLine("city: Muscat");
                                Console.WriteLine("address : Near PDO Area, Qurum, Muscat, Oman");
                                break;

                            case 3:
                                Console.WriteLine(" Opening Hours");
                                Console.WriteLine(" Weekday Opening Hours (Sunday–Thursday): 8:00 AM – 2:00 PM");
                                Console.WriteLine(" Weekend Opening Hours:    Friday: Closed      Saturday: Closed");
                                Console.WriteLine(" ATM Services: Available 24/7 ");
                                break;

                            case 0:
                                Console.WriteLine(" Returning to Main Menu");
                                break;

                            default:
                                Console.WriteLine(" Invalid selection. Please try again");
                                break;


                        }

                        Console.WriteLine("Select ATM services option:  ");
                        ATM_MainMenu = int.Parse(Console.ReadLine());

                    }

                if (ATM_MainMenu == 0)      /* // i used if because i want after i finish the while for (ATM menu) i need to go back for (main menu) ,
                                                 so if its == 0 then i give me the Main menu again , i do again for Main_Menu input to choose any services again */
                    {


                        Console.WriteLine("=== NATIONAL BANK OF OMAN  —  Unified Banking System ===");
                        Console.WriteLine("MAIN MENU");
                        Console.WriteLine(" 1) ATM Services  ");
                        Console.WriteLine(" 2) Account Management   ");
                        Console.WriteLine(" 3) Loan Services  ");
                        Console.WriteLine(" 4) Currency Exchange  ");
                        Console.WriteLine(" 5) Credit Card Portal  ");
                        Console.WriteLine(" 6) Branch Services   ");
                        Console.WriteLine(" 7) Reports & Admin    ");
                        Console.WriteLine(" 8) [BONUS] Full Terminal    ");
                        Console.WriteLine(" 0) Exit    ");
                        Console.WriteLine(" Select number from Main Menu:  ");
                        Main_Menu = int.Parse(Console.ReadLine());
         
                    }
                    else break;


                    break;

             ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case 2: 

                    break;
                case 3:

                    break;
                case 4:

                    break;

                case 5:

                    break;

            }
















                    /*
                    1) ATM Services

        2) Account Management

        3) Loan Services

        4) Currency Exchange     
        →  Tasks  2,  3,  4,  5
        →  Tasks  6,  7,  8
        →  Tasks  9, 10, 11
        →  Tasks 12, 13
          5) Credit Card Portal
          6) Branch Services
          7) Reports & Admin
        →  Tasks 14, 15
        →  Tasks 16, 17, 18
        →  Tasks 19, 20, 21
        */

                }
    }
}
