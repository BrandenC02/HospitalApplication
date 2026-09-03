
namespace Hospital
{

    public class ExistingPatient : Patient
    {
        //Attributes
        string AssignedNurse;
        int Rooomnumber;

        //Constructor
        public ExistingPatient(string name, string phone, string insurance, string condition, int SSN, int Rooomnumber, string AssignedNurse) : base(name, phone, insurance, condition, SSN)
        {
            setAssignedNurse(AssignedNurse);
            setRoomNumber(Rooomnumber);
        }

        public void existingpatientinfo()
        {
            patientinfo();
            Console.WriteLine("Assigned Nurse: " + getAssignedNurse());
            Console.WriteLine("Room Number: " + getRoomNumber());
        }

        //Getters and Setters
        public string getAssignedNurse()
        {
            return AssignedNurse;
        }
        public void setAssignedNurse(string AssignedNurse)
        {
            this.AssignedNurse = AssignedNurse;
        }

        public int getRoomNumber()
        {
            return Rooomnumber;
        }
        public void setRoomNumber(int Rooomnumber)
        {
            this.Rooomnumber = Rooomnumber;
        }

    }
    
}