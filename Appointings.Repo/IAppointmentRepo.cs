using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Appointings.Repo
{
    public interface IAppointmentRepo
    {
        Task<IList<Model.Appointments.Appointment>> GetAppointmentsAsync();
        IList<Model.Appointments.Appointment>> GetAppointments();
    }
}
