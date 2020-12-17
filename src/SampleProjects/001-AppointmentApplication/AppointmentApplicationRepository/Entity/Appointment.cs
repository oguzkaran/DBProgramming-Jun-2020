using System;
using System.Collections.Generic;
using System.Text;

namespace CSD.AppointmentApplication.Entity
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
    }
}
