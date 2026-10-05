using System;
using System.Collections.Generic;
using System.Text;

namespace Session14_Project3.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
