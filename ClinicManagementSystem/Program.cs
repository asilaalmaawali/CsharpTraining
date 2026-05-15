using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClinicManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //-----------------------------------Sustem Storage------------------------------- to declare variables

            // Capacity constants 
            const int MAX_PATIENTS = 3;
            const int MAX_DOCTORS = 2;
            const int MAX_APPOINTMENTS = 3;

            // Patient slots 
            string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;
            string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;
            string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;
            int patientCount = 0;

            // Doctor slots 
            string d1Name = ""; string d1Spec = ""; double d1Fee = 0; bool d1Active = false;
            string d2Name = ""; string d2Spec = ""; double d2Fee = 0; bool d2Active = false;
            int doctorCount = 0;

            // Appointment slots 
            string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; string a1Status = ""; bool a1Active = false;
            string a2Patient = ""; string a2Doctor = ""; string a2Date = ""; string a2Status = ""; bool a2Active = false;
            string a3Patient = ""; string a3Doctor = ""; string a3Date = ""; string a3Status = ""; bool a3Active = false;
            int appointmentCount = 0;

            //// for exit from menu
            bool exit = false;

            // for choice option for (main menu)
            int choice;
            // for option in Patient Management Sub-Menu
            int option;

            // for option in Doctor Management Sub-Menu
            int DoctorMenu_option;

            // for option in Appointment Management Sub-Menu
            int APPOINTMENTMenu_option;

            // declare name 
            string name ="";

            //declare age
            int age;
            //declare phone
            string phone ="";

            // declare counter for loop
            int counter =1;


            /////////////////////////////////////////////////////////////////////////////////
            //-- Main Menu --//




            while (exit == false)
            {
                Console.Clear();
                Console.WriteLine("===CLINIC MANAGEMENT SYSTEM===");
                Console.WriteLine("1.Patient Managements ");
                Console.WriteLine("2.Doctor Management   ");
                Console.WriteLine("3.Appointment Management ");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Enter your choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    ///////////////------------------------------------5.1  Patient Operations :---------------------------------------------------////////////////////
                    case 1:                                               // Patient Management Sub-Menu
                       

                        while (exit == false)
                        {
                            //Console.Clear();            i take it off , because with this code , the error message not displayed for wrong Age 
                            Console.WriteLine("===PATIENT MANAGEMENT==="); 
                            Console.WriteLine("1.Add New Patient ");
                            Console.WriteLine("2.Display All Patients");
                            Console.WriteLine("3.Update Patient Phone");
                            Console.WriteLine("4.Delete Patient");
                            Console.WriteLine("0.Back to Main Menu");
                            Console.WriteLine("Enter your option:");
                            option = int.Parse(Console.ReadLine());

                            switch (option)
                            {

                                case 1:                                          //1.Add New Patient
                                    
                                    if (patientCount == MAX_PATIENTS)
                                    {
                                        Console.WriteLine("Clinic is full. Cannot add more patients.");
                                        break;
                                    }
                                 

                                    Console.WriteLine("===Add New Patient===");
                                    Console.WriteLine("Enter Patient name");
                                    name = Console.ReadLine();

                                    if (name == "")
                                    {
                                        Console.WriteLine("error");
                                        break;
                                    }
                                                                  


                                    Console.WriteLine("Enter Patient Age");

                                    age = int.Parse(Console.ReadLine());

                                    if (age < 1 || age > 120)
                                    {
                                        Console.WriteLine("Error: Invalid Age");
                                        break;
                                    }

                                    Console.WriteLine("Enter Patient Phone");

                                    phone = Console.ReadLine();

                                    if (p1Active==false)
                                    {
                                        p1Name = name; p1Age = age; p1Phone = phone; p1Active = true;     // here to check there is a patient already
                                    }
                                    else if (p2Active == false)
                                    {
                                        p2Name = name; p2Age = age; p2Phone = phone; p2Active = true;
                                    }
                                    else if (p3Active == false)
                                    {
                                        p3Name = name; p3Age = age; p3Phone = phone; p3Active = true;
                                    }

                                    patientCount++;
                                    Console.WriteLine("Patient Added");

                                  
                                    break;

                                case 2:                                         //2.Display All Patients
                                    Console.WriteLine("===Display All Patients===");
                                    if (patientCount == 0) {
                                        Console.WriteLine("No patients registered.");
                                        break;
                                    }

                                    if (p1Active)                                        // if the patient available , they will displayed the info
                                    {
                                            Console.WriteLine("Patient #1 " + "Name: " + p1Name); 
                                            Console.WriteLine("Age: " + p1Age);
                                            Console.WriteLine("Phone: " + p1Phone);

                                        counter++;                // Each time a patient is printed, the counter increases by 1. Then will go for the next patient
                                    }

                                    if (p2Active)
                                    {
                                        Console.WriteLine("Patient #2 " + "Name: " + p2Name);
                                        Console.WriteLine("Age: " + p2Age);
                                        Console.WriteLine("Phone: " + p2Phone);
                                        counter++;
                                    }


                                    if (p3Active)
                                    {
                                        
                                        Console.WriteLine("Patient #3" + "Name: " + p2Name);
                                        Console.WriteLine("Name: " + p3Name);
                                        Console.WriteLine("Age: " + p3Age);
                                        Console.WriteLine("Phone: " + p3Phone);
                                        counter++;                    
                                    }
                                    break;

                                case 3:                                        //3.Update Patient Phone
                                    Console.WriteLine("===Update Patient Phone===");
                                    Console.WriteLine("Enter Patient name");
                                    name = Console.ReadLine();         

                                   // Use if-else: if (p1Active && p1Name == name) → read new phone → p1Phone = newPhone → print

                                    if (p1Active && p1Name == name)    // here to check the name = p1name and available to set new phone
                                    {
                                        Console.WriteLine("Enter Patient new phone");
                                        phone = Console.ReadLine();

                                        p1Phone = phone;

                                        Console.WriteLine("Updated.");
                                    }
                                    else if (p2Active && p1Name == name)
                                    {

                                        Console.WriteLine("Enter Patient new phone");
                                        phone = Console.ReadLine();

                                        p2Phone = phone;

                                        Console.WriteLine("Updated.");

                                    }
                                    else if(p2Active && p1Name == name)
                                    {


                                        Console.WriteLine("Enter Patient new phone");
                                        phone = Console.ReadLine();

                                        p3Phone = phone;

                                        Console.WriteLine("Updated.");


                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");   // if we do wrong name or name of patient not in the records , this error message will appear
                                    }

                                        break;

                                case 4:                                       //4.Delete Patient

                                    Console.WriteLine("===Delete Patient===");
                                    Console.WriteLine("Enter Patient name");
                                    name = Console.ReadLine();



                                    if (p1Active && p1Name == name)
                                    {
                                        p1Active = false;      
                                        p1Name = "";                             // i set all the variables as default 
                                        p1Age = 0;
                                        p1Phone = "";

                                        patientCount--;           // here i use decrement so every time Subtract from Patient 

                                        Console.WriteLine("Patient deleted.");

                                    }
                                    else if (p2Active && p2Name == name)
                                    {
                                        p2Active = false;                           
                                        p2Name = "";
                                        p2Age = 0; 
                                        p2Phone = "";

                                        patientCount--;

                                        Console.WriteLine("Patient deleted.");

                                    }
                                    else if (p3Active && p3Name == name)
                                    {
                                        p3Active = false;
                                        p3Name = "";
                                        p3Age = 0;
                                        p3Phone = "";

                                        patientCount--;

                                        Console.WriteLine("Patient deleted.");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }
                                    












                                    break;

                                case 0:
                                    exit = bool.Parse(Console.ReadLine());
                                    exit = true;
                                    break;

                                default:
                                    Console.WriteLine("Invalid option");
                                    break;

                            }
                            
                        }

                        break;
                               
                    case 2:      //  Doctor Management Sub-Menu


                        while (exit == false)
                        {
                            Console.Clear();
                            Console.WriteLine("===DOCTOR MANAGEMENT===");
                            Console.WriteLine("1. Add New Doctor ");
                            Console.WriteLine("2. Display All Doctors");
                            Console.WriteLine("3. Update Consultation Fee");
                            Console.WriteLine("4. Delete Doctor ");
                            Console.WriteLine("0. Back to Main Menu");
                            Console.WriteLine("Enter your option:");
                            DoctorMenu_option = int.Parse(Console.ReadLine());

                            switch (DoctorMenu_option)
                            {

                                case 1:                                          //1. Add New Doctor

                                    break;

                                case 2:                                         //2. Display All Doctors
                                    break;

                                case 3:                                        //3. Update Consultation Fee
                                    break;

                                case 4:                                       //4. Delete Doctor
                                    break;

                                case 0:                                       //  0. Back to Main Menu
                                    exit = bool.Parse(Console.ReadLine());
                                    exit = true;
                                    break;

                                default:                                      // for any another number not their in cases value
                                    Console.WriteLine("Invalid option");
                                    break;

                            }

                        }

                        break;

                    case 3:                                               // Appointment Management Sub-Menu


                        while (exit == false)
                        {
                            Console.Clear();
                            Console.WriteLine("===APPOINTMENT MANAGEMENT===");
                            Console.WriteLine("1. Book New Appointment  ");
                            Console.WriteLine("2. Display All Appointments ");
                            Console.WriteLine("3. Update Appointment Status ");
                            Console.WriteLine("4.Cancel Appointment");
                            Console.WriteLine("0. Back to Main Menu");
                            Console.WriteLine("Enter your option:");
                            APPOINTMENTMenu_option = int.Parse(Console.ReadLine());

                            switch (APPOINTMENTMenu_option)
                            {

                                case 1:                                          //1. Book New Appointment  

                                    break;

                                case 2:                                         //2. Display All Appointments 
                                    break;

                                case 3:                                        //3. Update Appointment Status
                                    break;

                                case 4:                                       //4. 4.Cancel Appointment
                                    break;

                                case 0:                                       //  0. Back to Main Menu
                                    exit = bool.Parse(Console.ReadLine());
                                    exit = true;
                                    break;

                                default:                                      // for any another number not their in cases value
                                    Console.WriteLine("Invalid option");
                                    break;

                            }

                        }


                        break;

                    case 0:                                               // Exit
                        exit = bool.Parse(Console.ReadLine());
                        exit = true;
                        break;


                }

            }






        }
    }
}
