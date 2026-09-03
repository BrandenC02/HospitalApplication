
namespace Hospital
{

    public class ExistingPatient : Patient
    {
        //Attributes
        string AssignedNurse;

        //Constructor
        public ExistingPatient(string name, string phone, string insurance, string condition, int SSN, int Rooomnumber, string AssignedNurse) : base(name, phone, insurance, condition, SSN)
        {
            setAssignedNurse(AssignedNurse);
        }

        public void existingpatientinfo()
        {
            patientinfo();
            Console.WriteLine("Assigned Nurse: " + getAssignedNurse());
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
    }
    
}