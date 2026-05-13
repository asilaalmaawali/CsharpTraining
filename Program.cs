using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
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

            //System Setup  --declare variables
            Console.WriteLine("=== SYSTEM SETUP  —  Enter Account &Customer Data ===");
            Console.WriteLine("--- Account Profile --");
            int accountNumber = 0;
            Console.WriteLine("1)  Account Number ");
            string holderName = string.Empty;
            Console.WriteLine("2)  Holder Name ");
            double balance = 0.000;
            Console.WriteLine("3)  Balance ");
            bool isActive = false;
            Console.WriteLine("4)  Account Active  ");
            char accountType = 'A';
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
            int option = int.Parse(Console.ReadLine());

            while (option != 0)
            {          // i used while != 0 , so if not equal to 0 it will not go out , if equal =0 they move to Main menu

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
                        if (ActiveStatus == 1)
                        {

                            isActive = true;
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
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

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

                case 1:
                    //Task 1 in main menu : 1 - ATM Welcome & Display


                    /*Console.WriteLine("=== ATM SERVICES ===");
                    Console.WriteLine("1) Bank Info");
                    Console.WriteLine("2) View Account Data");
                    Console.WriteLine("3) Authenticate");                             // i want to do the ATM Menu later 
                    Console.WriteLine("4) Print Receipt");                // if condiditon or switch inside main switch then the ATM services be inside it
                    Console.WriteLine("Select ATM services option:  ");
                    int ATM_MainMenu = int.Parse(Console.ReadLine());

                    if (ATM_SubMenu_BankInfo == 1) { }*/

                    int ATM_SubMenu_BankInfo = -1;  // i declare it to -1 to use it in if condition (if  ATM_SubMenu_BankInfo == 0) , becuase if i dont declare any number will be error.
                    Console.WriteLine("=== ATM SERVICES ===");
                    Console.WriteLine("1) Bank Info");
                    Console.WriteLine("2) Branch Info");
                    Console.WriteLine("3) Opening Hours");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Select ATM services option:  ");
                    ATM_SubMenu_BankInfo = int.Parse(Console.ReadLine());

                    while (ATM_SubMenu_BankInfo != 0)
                    {
                        switch (ATM_SubMenu_BankInfo)
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
                        ATM_SubMenu_BankInfo = int.Parse(Console.ReadLine());

                    }

                    if (ATM_SubMenu_BankInfo == 0)      /* // i used if because i want after i finish the while for (ATM menu) i need to go back for (main menu) ,
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

                    int ViewAccountData = -1;
                    Console.WriteLine("=== VIEW ACCOUNT DATA ===");      // Task3 - Account Data Viewer
                    Console.WriteLine("Data loaded from system setup");
      
                    while (ViewAccountData != 0)
                    {
                        switch (ViewAccountData) {

                            case 1:

                                Console.WriteLine("1) Account Number :  " + accountNumber );
                                break;

                            case 2:
                               Console.WriteLine("2) Holder Name:  " + holderName);
                                break;

                            case 3:
                                Console.WriteLine("3) Balance :  " + balance);
                                break;

                            case 4:
                               Console.WriteLine("4) Account Status:  " + isActive);  // Account status
                                break;

                            case 5:
                               Console.WriteLine("Account Type:  " + accountType);
                                break;


                            default:
                                Console.WriteLine("Field not available");
                     
                                    break;
                        }

                        Console.WriteLine(" Select number from Main Menu:  ");
                        ViewAccountData = int.Parse(Console.ReadLine());
                        // may be i will need to do something to come back
                    }

                    break;

                case 3:                                                                                           // Task 4 : ATM PIN Validation

                    int ATM_SubMenu_AUTHENTICATION = -1;
                    const string CORRECT_PIN = "4821";  // 
                    const int MAX_ATTEMPTS = 3;

     
                    Console.WriteLine("=== AUTHENTICATION ===");
                    Console.WriteLine("1) Enter your PIN");
                    Console.WriteLine("2) Forgot PIN");
                    Console.WriteLine("0) Back");
                    ATM_SubMenu_AUTHENTICATION = int.Parse(Console.ReadLine());


                    while (ATM_SubMenu_AUTHENTICATION != 0)
                    {
                        switch (ATM_SubMenu_AUTHENTICATION)
                        {

                            case 1:

                                Console.WriteLine("Enter your PIN");

                                string pin = "";

                                ConsoleKeyInfo key;  // key for write charecter for pin
                                do
                                {
                                    //Waits for the user to press one key. true: don't display it
                                    key = Console.ReadKey(true);
                                    //KeyChar:  letters / numbers
                                    // to not accept other than numbers and letters
                                    if (char.IsLetterOrDigit(key.KeyChar))
                                    {
                                        pin += key.KeyChar;
                                        Console.Write("*");
                                    }

                                    /*
                                    Keep repeating until the user presses Enter
                                    key.Key = The key the user pressed. key.key to detect the special char like enter
                                    Represents the Enter key
                                    */
                                } while (key.Key != ConsoleKey.Enter);


                                if (pin == CORRECT_PIN)
                                {
                                    Console.WriteLine("'Access granted. Welcome,  " + holderName);

                                }
                                else if (pin.Length != 4)
                                {
                                    Console.WriteLine("Invalid PIN format.");
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect PIN.");
                                }


                                break;

                            case 2:

                                Console.WriteLine("Please visit the nearest branch with your National ID.");

                                break;
                        }

                        Console.WriteLine(" Select number:  ");
                        ATM_SubMenu_AUTHENTICATION = int.Parse(Console.ReadLine());
                        // may be i will need to do something to come back
                    }

                      break;

                case 4:                                        // Task 5: ATM Receipt Printer


                    int Print_Receipt = -1;

                    Console.WriteLine("=== PRINT RECEIPT ===");
                    Console.WriteLine("1) Short Receipt");
                    Console.WriteLine("2) Detailed Receipt");
                    Console.WriteLine("3) Balance Only");
                    Console.WriteLine("0) Back");
                    Console.WriteLine("Select type of Receipt:  ");
                    Print_Receipt = int.Parse(Console.ReadLine());



                    while (Print_Receipt != 0)
                    {

                        switch (Print_Receipt)
                        {
                               
                            case 1:
                                //  Case 1: holderName + masked accountNumber (****last4digits) + balance 3 dp.


                                string maskedAccount = "****" + (accountNumber % 10000);  // here to view first (4 number) from accountNumber **** , % 10000 to view last 4 number

                                Console.WriteLine("--Short Receipt--");
                                Console.WriteLine("Holder Name: " + holderName);
                                Console.WriteLine("Account Number: " + maskedAccount);
                                Console.WriteLine("Balance: " + balance.ToString("F3")); // Convert the balance number into text with 3 numbers after the decimal point.

                                break;

                            case 2:

                                Console.WriteLine("Account Number is :  " + accountNumber);
                                Console.WriteLine("Holder name is :  " + holderName);
                                Console.WriteLine("Balance: " + balance.ToString("F3")); // we do same case 1
                                Console.WriteLine("Account Type is :  " + isActive);
                                Console.WriteLine("Account Type is :  " + accountType);
                                Console.WriteLine("Account Type is :  " + isEmployed);
                                Console.WriteLine("Monthly salary is :  " + salary + " OMR");
                                Console.WriteLine("creditScore is :  " + creditScore);
                                Console.WriteLine("creditScore is :  " + age);
                                Console.WriteLine("Last Deposit Amount is:   " + deposit);
                                Console.WriteLine("Last withdrawal Amount is :   " + withdrawal);
                                Console.WriteLine("Annual Interest Rate is :    " + annualRate);
                                Console.WriteLine("Avg Monthly Balance is :   " + avgBalance);

                                break;

                            case 3:
                                Console.WriteLine("Balance: " + balance.ToString("F3") + " OMR");
                                break;


                            default:
                                Console.WriteLine("Invalid receipt format");
                                break;

                        }

                     Console.WriteLine("Select type of Receipt:  ");
                     Print_Receipt = int.Parse(Console.ReadLine());
                        // may be i will need to do something to come back
                      
                    }

                    // here i will do if condition = 0 go back to ATM menu


                    if (Print_Receipt == 0)

                    {

                        Console.WriteLine("=== ATM SERVICES ===");
                        Console.WriteLine("1) Bank Info");
                        Console.WriteLine("2) View Account Data");
                        Console.WriteLine("3) Authenticate");
                        Console.WriteLine("4) Print Receipt");
                        Console.WriteLine("Select ATM services option:  ");
                        int ATM_MainMenu = int.Parse(Console.ReadLine());

                    }
                    else break;

                    break;


            }

                }
    }
}
