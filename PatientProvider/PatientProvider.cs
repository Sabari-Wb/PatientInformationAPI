using PatientInformationAPI.Model;
using PatientInformationAPI.PatientRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInformationAPI.PatientProvider
{
    public class PatientProvider : IPatientProvider
    {
        private readonly IPatientRepo _patientrepo;


        public PatientProvider(IPatientRepo patientrepo)
        {

            _patientrepo = patientrepo;
        }
        public Patient AddNewPatient(Patient p)
        {
            _patientrepo.AddNewPatient(p);
            return p;
        }

        public void DeletePatientdetail(int id)
        {

            _patientrepo.DeletePatientdetail(id);
            

        }




        public Patient GetPatientById(int id)
        {
          return _patientrepo.GetPatientById(id);
        }

        public List<Patient> GetPatientsdetails()
        {
            return _patientrepo.GetPatientsdetails();
        }

        public bool PatientdetailExists(int id)
        {
            return _patientrepo.PatientdetailExists(id);
        }

        public Patient UpdatePatientdetail(int id, Patient patient)
        {
            return _patientrepo.UpdatePatientdetail(id, patient);
            
        }
    }
}
