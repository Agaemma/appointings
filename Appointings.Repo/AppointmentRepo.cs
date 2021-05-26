using System.Collections.Generic;
using System.Threading.Tasks;


namespace Appointings.Repo
{
    public class AppointmentRepo : IAppointmentRepo
    {
        public async Task<IList<Model.Appointments.Appointment>> GetAppointmentsAsync()
        {
            List<Model.Appointments.Appointment> appointments = new List<Model.Appointments.Appointment>();
            Model.Appointments.Appointment appointment = new Model.Appointments.Appointment()
            {
                Treat = "Cut",
                Customer = "John Doe",
            };

            Model.Appointments.Appointment appointment2 = new Model.Appointments.Appointment()
            {
                Treat = "Dye",
                Customer = "Merlin Monroe",
            };

            appointment.Add(appointment);
            appointment2.Add(appointment);

            return appointments;
        }
    }
}
