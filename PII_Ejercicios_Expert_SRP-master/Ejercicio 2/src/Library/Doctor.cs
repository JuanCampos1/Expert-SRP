using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private string DoctorName;

        public string doctorName
        {
            get
            {
                return this.DoctorName;
            }
        }
        public Doctor(string doctorName)
        {
            this.DoctorName = doctorName;
            Boolean isValid = true;
            StringBuilder stringBuilder = new StringBuilder("Registering doctor...\n");
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to register doctor, Doctor name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.DoctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }
        }
    }
}