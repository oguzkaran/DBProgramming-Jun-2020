using System;
using System.Collections.Generic;

#nullable disable

namespace CSD.AppointmentApplication.Entity
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime Date { get; set; }

        public virtual Client Client { get; set; }
    }
}
