


using System.Collections;

namespace Hospital
{
    public class WaitingRoom
    {
        public static void Main(string[] args)
        {
            
            ArrayList Patients = new ArrayList();
            String input;

            ExistingPatient patient1 = new ExistingPatient("John", "555-1234", "Blue Cross", "Flu", 123456789, 101, "Nurse Joy");
            ExistingPatient patient2 = new ExistingPatient("Jane", "555-5678", "Aetna", "Cold", 987654321, 150, "Nurse Alice");
            ExistingPatient patient3 = new ExistingPatient("Bob", "555-9876", "Cigna", "Headache", 456789123, 330, "Nurse Bob");
            ExistingPatient patient4 = new ExistingPatient("Alice", "555-6543", "UnitedHealthcare", "Stomachache", 789123456, 275, "Nurse Carol");
            
            Console.WriteLine("End");
            
            Patients.Add(patient1);
            Patients.Add(patient2);
            Patients.Add(patient3);
            Patients.Add(patient4);
            
            Console.WriteLine("Checking in or Visiting:");
            input = Console.ReadLine();

            if (input == "Checking in")
            {
                Console.WriteLine("Enter Patient Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Patient Phone:");
                string phone = Console.ReadLine();
                Console.WriteLine("Enter Patient Insurance:");
                string insurance = Console.ReadLine();
                Console.WriteLine("Enter Patient Condition:");
                string condition = Console.ReadLine();
                Console.WriteLine("Enter Patient SSN:");
                int SSN = Convert.ToInt32(Console.ReadLine());

                NewPatient newPatient = new NewPatient(name, phone, insurance, condition, SSN);
                Patients.Add(newPatient);
                
            }
            else if (input == "visiting")
            {
                Console.WriteLine("Enter Patient Name:");
                string name = Console.ReadLine();

                foreach (var patient in Patients)
                {
                    if (patient is ExistingPatient existingPatient && existingPatient.getName() == name)
                    {
                        existingPatient.existingpatientinfo();
                        break;
                    }
                    else if (patient is NewPatient newPatient && newPatient.getName() == name)
                    {
                        newPatient.newpatientinfo();
                        break;
                    }
                }
            }

        }
    }
}