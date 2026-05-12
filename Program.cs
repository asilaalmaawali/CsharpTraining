using System.Diagnostics.Metrics;
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

            while (option != 0) {

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
               Console.WriteLine("Select option:  ");
               option = int.Parse(Console.ReadLine());
            }

        }
    }
}
