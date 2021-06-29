using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientInformationAPI.Data;
using PatientInformationAPI.Model;
using PatientInformationAPI.PatientProvider;

namespace PatientInformationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientProvider _patientprovider;

        public PatientsController(IPatientProvider patientprovider)
        {
            _patientprovider = patientprovider;
        }

        // GET: api/Patients
        [HttpGet("patientdetails")]
        public ActionResult<List<Patient>> GetPatientDetails()            //original code
        {
            return _patientprovider.GetPatientsdetails();
        }
        //public IActionResult GetPatientDetails()                              // for unit test
        //{
        //    return Ok(_patientprovider.GetPatientsdetails());
        //}

        // GET: api/Patientsdetail/5
        [HttpGet("{id}")]
        public ActionResult<Patient> GetPatientDetails(int id)               //originalcode
        {
            Patient patient = _patientprovider.GetPatientById(id);
            return patient;


        }
        //public IActionResult GetPatientDetails(int id)                          // for unit test
        //{
        //    return Ok(_patientprovider.GetPatientById(id));
        //}

        // PUT: api/Patientsdetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutPatient(int id, Patient patient)             //original code//unittest
        {

            try
            {
                _patientprovider.UpdatePatientdetail(id, patient);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_patientprovider.PatientdetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

                return NoContent();
            }


            // POST: api/Patientdetail
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost("insertpatient")]
        public ActionResult<Patient> PostPatient(Patient patient)                        //original code
        {
            _patientprovider.AddNewPatient(patient);

            return CreatedAtAction("GetPatientDetails", new { id = patient.PatientID }, patient);
        }
        //public IActionResult PostPatient(Patient patient)                        //unittest
        //{
        //    _patientprovider.AddNewPatient(patient);

        //    return CreatedAtAction("GetPatientDetails", new { id = patient.PatientID }, patient);
        //}

        // DELETE: api/Patients/5
        [HttpDelete("{id}")]
        public IActionResult DeletePatient(int id)              //originalcode //unittest
        {

            _patientprovider.DeletePatientdetail(id);
            return NoContent();
        }



    }
}
