using System;
using System.Collections.Generic;
using System.Text;

namespace Session14_Project3.Entities
{
    public class Appointment
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;
        public DateTime AppointmentDate { get; set; }

    }
}
