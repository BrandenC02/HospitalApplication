
namespace Hospital
{
    public class Patient
    {
        //Attributes
        string name, phone, insurance, condition;
        int SSN, Rooomnumber;

        //Constructor
        public Patient(string name, string phone, string insurance, string condition, int SSN)
        {
            setName(name);
            setPhone(phone);
            setInsurance(insurance);
            setCondition(condition);
            setSSN(SSN);
            setRoomNumber();
        }

        //Method to display patient information
        public void patientinfo()
        {
            Console.WriteLine("Patient Name: " + getName());
            Console.WriteLine("Patient Phone: " + getPhone());
            Console.WriteLine("Patient Insurance: " + getInsurance());
            Console.WriteLine("Patient Condition: " + getCondition());
            Console.WriteLine("Patient SSN: " + getSSN());
            Console.WriteLine("Patient Room Number: " + getRoomNumber());
        }


        //Getters and Setters
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getPhone()
        {
            return phone;
        }
        public void setPhone(string phone)
        {
            this.phone = phone;
        }
        public string getInsurance()
        {
            return insurance;
        }
        public void setInsurance(string insurance)
        {
            this.insurance = insurance;
        }
        public string getCondition()
        {
            return condition;
        }
        public void setCondition(string condition)
        {
            this.condition = condition;
        }
        public int getSSN()
        {
            return SSN;
        }
        public void setSSN(int SSN)
        {
            this.SSN = SSN;
        }
        public int getRoomNumber()
        {
            return Rooomnumber;
        }
        public void setRoomNumber()
        {
            Random random = new Random();
            Rooomnumber = random.Next(100, 999);
        }

    }
}


