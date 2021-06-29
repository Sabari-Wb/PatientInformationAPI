using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInformationAPI.Model
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        

        [DataType(DataType.Date)]
        public DateTime Dateofbirth { get; set; }
        public string ContactNumber { get; set; }
        public Patient()
        {

        }
       
        public Patient (int patientId,string firstname,string lastname,string sex,int age,DateTime dob,string contactnumber)
        {
            PatientID = patientId;
            FirstName = firstname;
            LastName = lastname;
            Sex = sex;
            Age = age;
            Dateofbirth = dob;
            ContactNumber = contactnumber;
        }
    }
}
