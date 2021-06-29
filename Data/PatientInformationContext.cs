using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PatientInformationAPI.Model;

namespace PatientInformationAPI.Data
{
    public class PatientInformationContext : DbContext
    {
        public PatientInformationContext()
        {

        }
        public PatientInformationContext (DbContextOptions<PatientInformationContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<PatientInformationAPI.Model.Patient> Patient { get; set; }
    }
}
