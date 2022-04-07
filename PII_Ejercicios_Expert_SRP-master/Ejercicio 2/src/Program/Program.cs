using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("Steven Jhonson", "986782342", "5555-5555-5555");
            Doctor doctor1 = new Doctor("Armand");
            string appointmentResult = AppointmentService.CreateAppointment(patient1, DateTime.Now, "Wall Street", doctor1);
            Console.WriteLine(appointmentResult);

            Patient patient2 = new Patient("Ralf Manson", "", "5555-555-555");
            Doctor doctor2 = new Doctor("");
            string appointmentResult2 = AppointmentService.CreateAppointment(patient2, DateTime.Now, "Queen Street", doctor2);
            Console.WriteLine(appointmentResult2);
        }
    }
}
