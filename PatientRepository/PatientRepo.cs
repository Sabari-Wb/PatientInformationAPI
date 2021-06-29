using Microsoft.EntityFrameworkCore;
using PatientInformationAPI.Data;
using PatientInformationAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInformationAPI.PatientRepository
{
    public class PatientRepo : IPatientRepo
    {
        private readonly PatientInformationContext _patientinformationcontext;
        public PatientRepo(PatientInformationContext patientinformationcontext)
        {
            _patientinformationcontext = patientinformationcontext;
        }
        public Patient AddNewPatient(Patient p)
        {
           _patientinformationcontext.Patient.Add(p);
          _patientinformationcontext.SaveChanges();
           return p;
        }

        public void DeletePatientdetail(int id)
        {
            Patient p = _patientinformationcontext.Patient.Find(id);
            _patientinformationcontext.Patient.Remove(p);
            _patientinformationcontext.SaveChanges();
        }
       
        public Patient GetPatientById(int id)
        {
            return _patientinformationcontext.Patient.Find(id);
        }

        public List<Patient> GetPatientsdetails()
        {
            return _patientinformationcontext.Patient.ToList();
        }

        public bool PatientdetailExists(int id)
        {
            return _patientinformationcontext.Patient.Any(e => e.PatientID == id);
        }

        public Patient UpdatePatientdetail(int id, Patient patient)
        {
            _patientinformationcontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _patientinformationcontext.Entry(patient).State = EntityState.Modified;
            _patientinformationcontext.SaveChanges();
            return patient;
        }
    }
}
