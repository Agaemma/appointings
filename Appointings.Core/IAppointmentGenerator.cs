using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Appointings.Core
{
   public interface IAppointmentGenerator
    {
        List<DTO.Appointments.Appointment> GenerateList();
        Task<List<DTO.Appointments.Appointment>> GenerateListAsync();
    }
}
