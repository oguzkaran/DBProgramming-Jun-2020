using System;
using System.Collections.Generic;

#nullable disable

namespace CSD.AppointmentApplication.Entity
{
    public partial class Client
    {
        public Client()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
