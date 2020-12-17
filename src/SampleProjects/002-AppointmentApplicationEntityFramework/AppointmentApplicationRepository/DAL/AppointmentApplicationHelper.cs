using CSD.AppointmentApplication.Entity;
using CSD.AppointmentApplication.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSD.AppointmentApplication.DAL
{
    public class AppointmentApplicationHelper
    {
        private readonly ClientRepository m_clientRepository = new ClientRepository(); // Burada dependency injection kullanılabilir
        private readonly AppointmentRepository m_appointmentRepository = new AppointmentRepository();

        public Client SaveClient(Client client)
        {
            try
            {
                return m_clientRepository.Save(client);
            }
            catch (Exception ex) {
                throw new AggregateException("SaveClient", ex);
            }
        }

        public Appointment SaveAppointment(Appointment appointment)
        {
            try
            {
                return m_appointmentRepository.Save(appointment);
            }
            catch (Exception ex)
            {
                throw new AggregateException("SaveAppointment", ex);
            }
        }

        public List<Appointment> GetAppointmetsByClientId(int clientId)
        {
            try
            {
                return m_appointmentRepository.GetAppointmentsByClientId(clientId);
            }
            catch (Exception ex)
            {
                throw new AggregateException("GetAppointmetsByClientId", ex);
            }
        }

        public List<Client> GetAllClients()
        {
            try
            {
                return m_clientRepository.All;
            }
            catch (Exception ex)
            {
                throw new AggregateException("GetAllClients", ex);
            }
        }
    }
}
