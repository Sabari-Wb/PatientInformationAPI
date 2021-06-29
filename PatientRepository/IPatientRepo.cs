using PatientInformationAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInformationAPI.PatientRepository
{
    public interface IPatientRepo
    {
        public List<Patient> GetPatientsdetails();
        public Patient GetPatientById(int id);
        public Patient AddNewPatient(Patient p);
        public void DeletePatientdetail(int id);
       
        public Patient UpdatePatientdetail(int id, Patient p);
        public bool PatientdetailExists(int id);
    }
}
