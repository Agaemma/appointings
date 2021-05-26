using System;
using System.Collections.Generic;
using System.Text;
using Appointings.Repo;
using Appointings.Model.Appointments;

namespace Appointings.Core
{
    public class AppointmentGenerator : IAppointmentGenerator
    {
        private IAppointmentGenerator _appointerRepo;

        public AppointmentGenerator(string domain, IAppointmentGenerator appointmentRepo)
        {
            _domain = domain;
            _appointerRepo = appointmentRepo;
        }

        public List<Appointment> GenerateList()
        {
            var appointemnts = _appointerRepo.GetAppointmentsAsync().Result;
            var appointmentList = _new List<DTO.Appointments.Appointment>();

            Random rand = new Random();

            foreach (Model.Appointemnts.Appointment appointment in appointments)
            {

            }


        }

    }
}
