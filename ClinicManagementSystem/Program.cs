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
            /////////////////////////////////////////////////////////////////////////////////
            //-- Main Menu --//




            while (exit == false)
            {
                Console.Clear();
                Console.WriteLine("===CLINIC MANAGEMENT SYSTEM===");
                Console.WriteLine("1.Patient Management ");
                Console.WriteLine("2.Doctor Management   ");
                Console.WriteLine("3.Appointment Management ");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Enter your choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:                                               // Patient Management Sub-Menu

                        while (exit == false)
                        {
                            Console.Clear();
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

                                    break;

                                case 2:                                         //2.Display All Patients
                                    break;

                                case 3:                                        //3.Update Patient Phone
                                    break;

                                case 4:                                       //4.Delete Patient
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
