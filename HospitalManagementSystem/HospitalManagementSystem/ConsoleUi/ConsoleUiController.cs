using HospitalManagementSystem.Data;
using HospitalManagementSystem.Entities;
using HospitalManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.ConsoleUi
{
    public class ConsoleUiController
    {
        //Appointment appt = new();
        public CrudOperations operations = new();
        public void userInterface(DataContext context)
        {
            do
            {
                Console.WriteLine("\t\t\tHOSPITAL MANAGEMENT SYSTEM");
                Console.WriteLine("\t\t\t_____________________________");
                Console.WriteLine("Select a service based on the number");
                Console.WriteLine("\t\t 1. Book an Appointment");
                Console.WriteLine("\t\t 2. Find A Patient By Name");
                Console.WriteLine("\t\t 3. Find A Patient By Id");
                Console.WriteLine("\t\t 4. See Available Rooms/Wards");
                string? userChoice = Console.ReadLine();
                var validOptions = new List<string>() { "1", "2", "3", "4", };

                try
                {
                    isValidOption(userChoice, validOptions);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine("reached here");
                int.TryParse(userChoice, out int choice);
                redirectUser(choice, context);
            }while(true);
            

        }

        //This is a method that is used to check if the users input is one of the available options
        public  void isValidOption(string option, List<string>? validOptions)
        {
            if (validOptions != null && validOptions.Contains(option))
            {
                   
                    Console.WriteLine("\t---------Fetching your data-----------");
                    
            }
            else
            {
                    throw new Exception("\t-----------INVALID OPTION---------------");
                
            }

        }


        //After we have checked that indeed the users input is one of the available choices
        //we should redirect them according to their choice input number 
        //Thats what this function is intended to accomplish

        public void redirectUser(int choice, DataContext context)
        {
            switch (choice)
            {
                case 1:
                    CreateAppointment(context);
                    break;
                default:
                    break;
            }
        }

        public void CreateAppointment(DataContext context)
        {
            do
            {
                Console.WriteLine("Create new appointment");
                Console.WriteLine("Enter a subject");
                string? apptId = Console.ReadLine();
                Console.WriteLine("Enter a Description");
                string? apptDate = Console.ReadLine();
                Console.WriteLine("Enter a Price");
                string? apptTime = Console.ReadLine();
                var inputs = new List<string>() { apptId, apptDate, apptTime };
                //we might need to try catch later for defense cases
                int.TryParse(apptId, out int id);
                int.TryParse(apptDate, out int date);
                int.TryParse(apptTime, out int time);


                var appt = new Appointment() { AppointmentId = id, AppointmentDate = date, AppointmentTime = time };
                bool isSuccessful = operations.CreateAppointment(appt, context);
                Console.WriteLine(isSuccessful ? "---- Appointment created successfully ---- \n" : "----- something went wrong ----- \n");
                break;
            } while (true);
        }


    }

       
       


}

