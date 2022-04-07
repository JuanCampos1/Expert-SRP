using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        private string Name;
        private string Id;
        private string PhoneNumber;

        public string name
        {
            get
            {
                return this.Name;
            }
        }
        public string id
        {
            get
            {
                return this.Id;
            }
        }

        public string phoneNumber
        {
            get
            {
                return this.PhoneNumber;
            }
        }
        public Patient(string name, string id, string phoneNumber)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            StringBuilder stringBuilder = new StringBuilder("Registering patient...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to register patient, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to register patient, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to register patient, Phone number is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Patient Registered");
            }
        }
    }
}