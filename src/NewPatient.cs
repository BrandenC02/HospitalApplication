using System.Collections.Generic;

namespace Hospital
{
   
    public class NewPatient : Patient
    {
        string AssignNurse;
        int Roomnumber;

        Dictionary<string, bool> AvailableNurses = new()
        {
            { "Nurse Beth", true },
            { "Nurse Joy", false },
            { "Nurse Alice", false },
            { "Nurse Bob", false },
            { "Nurse Carol", false },
            { "Nurse Dave", true },
            { "Nurse Eve", true },
            { "Nurse Frank", true },
            
        };
        


        //Constructor
        public NewPatient(string name, string phone, string insurance, string condition, int SSN) : base(name, phone, insurance, condition, SSN)
        {
            setAssignNurse();
            setRoomNumber();
        }

        public void newpatientinfo()
        {
            patientinfo();
            Console.WriteLine("Assigned Nurse: " + getAssignNurse());
            Console.WriteLine("Room Number: " + getRoomNumber());
        }

        public string getAssignNurse()
        {
            return AssignNurse;
        }

        public void setAssignNurse()
        {
            foreach (var nurse in AvailableNurses)
            {
                if (nurse.Value == true)
                {
                    AssignNurse = nurse.Key;
                    AvailableNurses[nurse.Key] = false; // Mark the nurse as unavailable
                    break;
                }
            }
        }

        public int getRoomNumber()
        {
            return Roomnumber;
        }
        public void setRoomNumber()
        {
            Random random = new Random();
            Roomnumber = random.Next(100, 999);
        }

    }
}