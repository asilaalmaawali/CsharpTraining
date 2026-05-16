using System.ComponentModel.Design;
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

            // declare name (patient name input)
            string name ="";

            //declare age
            int age;
            //declare phone
            string phone ="";

            // declare counter for display
            int displayNum = 1;  

            // declare specialization
            string specialization ="";

            // declare fee
            double fee;

            //declare for doctor name input
            string dname = "";
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

                                    displayNum = 1;   // here i reset the counter every time , because i want everytime i displayed either i delete one patient the count of patient be re-order
                                    if (p1Active)                                        // if the patient available , they will displayed the info
                                    {
                                            Console.WriteLine("Patient #" + displayNum);  // here to count the patient 
                                            Console.WriteLine("Name: " + p1Name); 
                                            Console.WriteLine("Age: " + p1Age);
                                            Console.WriteLine("Phone: " + p1Phone);
                                        displayNum++;  
                                                     // Each time a patient is printed, the counter increases by 1. Then will go for the next patient
                                    }

                                    if (p2Active)
                                    {
                                        Console.WriteLine("Patient #" + displayNum);
                                        Console.WriteLine("Name: " + p2Name);
                                        Console.WriteLine("Age: " + p2Age);
                                        Console.WriteLine("Phone: " + p2Phone);
                                        displayNum++;
                                    }
                                    


                                    if (p3Active)
                                    {
                                        Console.WriteLine("Patient #" + displayNum);
                                        Console.WriteLine("Name: " + p3Name);
                                        Console.WriteLine("Age: " + p3Age);
                                        Console.WriteLine("Phone: " + p3Phone);
                                        displayNum++;           
                                    }

                                    break;

                                case 3:                                        //3.Update Patient Phone
                                    Console.WriteLine("===Update Patient Phone===");
                                    Console.WriteLine("Enter Patient name");
                                    name = Console.ReadLine();         

                                  
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

                                        displayNum--;           // here i use decrement so every time Subtract from Patient 

                                        Console.WriteLine("Patient deleted.");

                                    }
                                    else if (p2Active && p2Name == name)
                                    {
                                        p2Active = false;                           
                                        p2Name = "";
                                        p2Age = 0; 
                                        p2Phone = "";

                                        displayNum--;

                                        Console.WriteLine("Patient deleted.");

                                    }
                                    else if (p3Active && p3Name == name)
                                    {
                                        p3Active = false;
                                        p3Name = "";
                                        p3Age = 0;
                                        p3Phone = "";

                                        displayNum--;

                                        Console.WriteLine("Patient deleted.");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }
  
                                    break;

                                case 0:
                                    exit = true;
                                    exit = bool.Parse(Console.ReadLine());
                                    
                                    break;

                                default:
                                    Console.WriteLine("Invalid option");
                                    break;

                            }

                            //Console.WriteLine("Enter your option:");
                            //option = int.Parse(Console.ReadLine());

                            //if (option == 0)
                            //{

                               
                            //    Console.WriteLine("===CLINIC MANAGEMENT SYSTEM===");
                            //    Console.WriteLine("1.Patient Managements ");
                            //    Console.WriteLine("2.Doctor Management   ");
                            //    Console.WriteLine("3.Appointment Management ");
                            //    Console.WriteLine("0.Exit");
                            //    Console.WriteLine("Enter your choice:");
                            //    choice = int.Parse(Console.ReadLine());

                            //}
                         
                            

                        }

                        break;
                    /////////////////--------------------------------------5.2  Doctor Operations-------------------------------//////////////////////////////////
                    case 2:  //Doctor Management Sub-Menu


                        while (exit == false)
                        {

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
                                    Console.WriteLine("===Add New Doctor===");
                                    if (doctorCount == MAX_PATIENTS)
                                    {
                                        Console.WriteLine("No available doctor slots.");
                                        break;
                                    }

                                    Console.WriteLine("Enter Doctor name :  ");
                                    dname = Console.ReadLine();
                                    Console.WriteLine("Enter Doctor specialization :  ");
                                    specialization = Console.ReadLine();

                                    if (dname == "" && specialization == "")
                                    {

                                        Console.WriteLine("cannot be empty");

                                    }

                                    Console.WriteLine("Enter Fee :  ");
                                    fee = double.Parse(Console.ReadLine());


                                    if (fee < 0)
                                    {
                                        Console.WriteLine("Error");
                                        break;

                                    }

                                    if (d1Active == false)
                                    {
                                        d1Name = dname; d1Spec = specialization; d1Fee = fee; d1Active = true;     // here to check there is a Doctor already
                                    }
                                    else if (d2Active == false)
                                    {
                                        d2Name = dname; d2Spec = specialization; d2Fee = fee; d2Active = true;
                                    }


                                    doctorCount++;
                                    Console.WriteLine("Doctor Added successfully.");


                                    break;

                                case 2:                                       //2. Display All Doctors

                                    Console.WriteLine("===Display All Doctors===");


                                    if (doctorCount == 0)
                                    {                                    // if doctor count 0 , there no doctor registered

                                        Console.WriteLine(" No doctors registered.");
                                        break;
                                    }

                                    displayNum = 1;

                                    if (d1Active)                                        // if the doctor available , they will displayed the info
                                    {
                                        Console.WriteLine("Dcotor #" + displayNum);
                                        Console.WriteLine("Name: " + d1Name);
                                        Console.WriteLine("specialization : " + d1Spec);
                                        Console.WriteLine("fee: " + d1Fee);

                                        displayNum++;                // Each time a doctor is printed, the counter increases by 1. Then will go for the next doctor
                                    }

                                    if (d2Active)
                                    {
                                        Console.WriteLine("Dcotor #" + displayNum);
                                        Console.WriteLine("Name: " + d2Name);
                                        Console.WriteLine("specialization : " + d2Spec);
                                        Console.WriteLine("fee: " + d2Fee);
                                        displayNum++;
                                    }

                                    break;

                                case 3:                                        //3. Update Consultation Fee

                                    Console.WriteLine("===Update Consultation Fee===");
                                    Console.WriteLine("Enter Doctor name ");
                                    dname = Console.ReadLine();


                                    if (d1Active && d1Name == dname)
                                    // here to check the dname= d1name and avaialable to set new fee
                                    {
                                        Console.WriteLine("Enter Doctor new fee");
                                        fee = double.Parse(Console.ReadLine());

                                        d1Fee = fee;


                                        if (fee < 0)
                                        {
                                            Console.WriteLine("Error: Invalid fee");
                                            break;
                                        }

                                        d1Fee = fee;

                                        Console.WriteLine("Fee updated.");
                                    }
                                    else if (d1Active && d1Name == dname)
                                    {

                                        Console.WriteLine("Enter new fee:");
                                        fee = Convert.ToDouble(Console.ReadLine());

                                        if (fee < 0)
                                        {
                                            Console.WriteLine("Error: Invalid fee");
                                            break;
                                        }

                                        d2Fee = fee;

                                        Console.WriteLine("Fee updated.");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Doctor not found.");
                                    }


                                    break;

                                case 4:                                       //4. Delete Doctor

                                    Console.WriteLine("===Delete Doctor");
                                    Console.WriteLine("Enter Doctor name");
                                    dname = Console.ReadLine();



                                    if (d1Active && d1Name == dname)
                                    {
                                        d1Active = false;
                                        d1Name = "";                             // i set all the variables as default 
                                        d1Fee = 0.00;


                                        displayNum--;           // here i use decrement so every time Subtract from doctor

                                        Console.WriteLine("Patient deleted.");

                                    }
                                    else if (d2Active && d2Name == dname)
                                    {
                                        d2Active = false;
                                        d2Name = "";
                                        d2Fee = 0.00;


                                        displayNum--;

                                        Console.WriteLine("Patient deleted.");

                                    }
                                        break;


                                case 0:                               //0. Back to Main Menu

                                            exit = bool.Parse(Console.ReadLine());
                                            exit = true;
                                            break;

                                        default:                                      // for any another number not their in cases value
                                            Console.WriteLine("Invalid option");
                                            break;


                            }
                        }
                                    break;

                    ////////////////////////////---------------------5.3  Appointment Operations ----------------------------///////////////////////
                    case 3:                                               // Appointment Management Sub-Menu


                        while (exit == false)
                        {
                            
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


                                    if (appointmentCount == MAX_APPOINTMENTS)
                                    {

                                        Console.WriteLine("No available appointment slots");
                                        break;
                                    }

                                    if (patientCount == 0 || doctorCount == 0)
                                    {
                                        Console.WriteLine("Please add patients and doctors first.");
                                        break;
                                    }

                                    Console.WriteLine("===Active Patients===");   // to list active patient

                                    if (p1Active)
                                    {
                                        Console.WriteLine("1. " + p1Name);
                                    }

                                    if (p2Active)
                                    {
                                        Console.WriteLine("2. " + p2Name);
                                    }

                                    if (p3Active)
                                    {
                                        Console.WriteLine("3. " + p3Name);
                                    }

                                    Console.WriteLine("Choose patient number:");
                                    int pchoice = int.Parse(Console.ReadLine()); // patient number 

                                    if ((pchoice == 1 && p1Active) ||
                                        (pchoice == 2 && p2Active) ||
                                        (pchoice == 3 && p3Active))
                                    {
                                        Console.WriteLine("Valid patient selected.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice.");
                                    }

                                    string chosenPatient = "";        //Store the chosen patient name into a temporary string variable


                                    if (pchoice == 1 && p1Active)         // if choice == active patient so (chosenPatient) temporary to store name = patient name
                                    {
                                        chosenPatient = p1Name;
                                    }
                                    else if (pchoice == 2 && p2Active)
                                    {
                                        chosenPatient = p2Name;
                                    }
                                    else if (pchoice == 3 && p3Active)
                                    {
                                        chosenPatient = p3Name;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice.");
                                    }

                                    Console.WriteLine("===Active Doctors===");

                                    if (d1Active)
                                    {
                                        Console.WriteLine("1. " + d1Name);
                                    }

                                    if (d2Active)
                                    {
                                        Console.WriteLine("2. " + d2Name);
                                    }

                                    Console.WriteLine("Choose patient number:");
                                    int dchoice = int.Parse(Console.ReadLine()); // Doctor number 

                                    if ((pchoice == 1 && p1Active) ||
                                        (pchoice == 2 && p2Active) ||
                                        (pchoice == 3 && p3Active))
                                    {
                                        Console.WriteLine("Valid patient selected.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice.");
                                    }


                                    string chosenDoctor = "";   //Store the chosen patient name into a temporary string variable


                                    if (dchoice == 1 && d1Active)        // if choice == active patient so (chosenPatient) temporary to store name = patient name
                                    {
                                        chosenPatient = d1Name;
                                    }
                                    else if (dchoice == 2 && d1Active)
                                    {
                                        chosenPatient = d1Name;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice.");
                                    }

                                    Console.WriteLine("Enter appointment date in this format (DD/MM/YYYY)):  ");
                                    string appointmentDate = Console.ReadLine();  // we can use (date) data type but here the requirement is (string)


                                    if (a1Active && a1Patient == chosenPatient && a1Doctor == chosenDoctor && a1Date == appointmentDate)
                                    {

                                        Console.WriteLine("Duplicate appointment.");
                                        break;
                                    }
                                    else if (a2Active && a2Patient == chosenPatient && a2Doctor == chosenDoctor && a2Date == appointmentDate)
                                    {
                                        Console.WriteLine("Duplicate appointment.");
                                        break;
                                    }
                                    else if(a3Active && a3Patient == chosenPatient && a3Doctor == chosenDoctor && a3Date == appointmentDate)
                                    {
                                        Console.WriteLine("Duplicate appointment.");
                                        break;

                                    }

                                    if (a1Active == false )         // check that appoinment available
                                    {
                                        a1Patient = chosenPatient;
                                        a1Doctor = chosenDoctor;
                                        a1Date = appointmentDate;
                                        a1Status = "Scheduled";
                                        a1Active = true;

                                        Console.WriteLine("Appointment booked ");
                                    }
                                    else if (a2Active==false )
                                    {
                                        a2Patient = chosenPatient;
                                        a2Doctor = chosenDoctor;
                                        a2Date = appointmentDate;
                                        a2Status = "Scheduled";
                                        a2Active = true;

                                        Console.WriteLine("Appointment booked ");
                                    }
                                    else if (a3Active==false)
                                    {
                                        a3Patient = chosenPatient;
                                        a3Doctor = chosenDoctor;
                                        a3Date = appointmentDate;
                                        a3Status = "Scheduled";
                                        a3Active = true;

                                        Console.WriteLine("Appointment booked ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No free appointment slots.");
                                    }
                                    

                                    appointmentCount++;
                                    Console.WriteLine("Appointment booked.");

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
