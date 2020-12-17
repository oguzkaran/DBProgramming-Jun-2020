using CSD.AppointmentApplication.Data;
using CSD.AppointmentApplication.Entity;
using System.Collections.Generic;
using System.Linq;

namespace CSD.AppointmentApplication.Repository
{
    public class AppointmentRepository
    {
        private readonly AppointmentDbContext m_appointmentDbContext = new AppointmentDbContext();        

        public Appointment Save(Appointment appointment)
        {
            m_appointmentDbContext.Appointments.Add(appointment);
            m_appointmentDbContext.SaveChanges();

            return appointment;
        }

        public List<Appointment> GetAppointmentsByClientId(int clientId)
            => m_appointmentDbContext.Appointments.Where(a => a.ClientId == clientId).ToList();        
    }
}
