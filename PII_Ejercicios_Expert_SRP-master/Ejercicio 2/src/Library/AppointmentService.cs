using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /*La clase create appointment no tiene la responsabilidad de conocer los datos del paciente ni del
        doctor por eso se crean 2 clases Patient y Doctor con la responsabilidad de conocer los datos*/
        public static string CreateAppointment(Patient patient, DateTime date, string appoinmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }
        
            
            if (string.IsNullOrEmpty(doctor.doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.name))
            {
                stringBuilder.Append("Unable to schedule appointment, patient name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, patient phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.id))
            {
                stringBuilder.Append("Unable to schedule appointment, patient id is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
