using System;
using System.Collections.Generic;
using System.Text;

namespace CSD.AppointmentApplication.Entity
{
    public partial class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }        
    }
}
