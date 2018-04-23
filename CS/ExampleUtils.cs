using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraScheduler;

namespace SchedulerFilterReminders
{
    public static class ExampleUtils
    {
        public static DateTime baseTime = DateTime.Today.AddDays(-1);
        public static string[] Users = new string[] { "Peter Dolan", "Ryan Fischer", "Andrew Miller" };

        public static void GenerateSampleResources(SchedulerStorage storage)
        {
            ResourceCollection resources = storage.Resources.Items;
            storage.BeginUpdate();
            try {
                for (int i = 0; i < ExampleUtils.Users.Length; i++) {
                    Resource resource = storage.CreateResource(i + 1);

                    resource.Caption = ExampleUtils.Users[i];
                    resources.Add(resource);
                }
            }
            finally {
                storage.EndUpdate();
            }
        }

        public static void GenerateSampleAppointments(SchedulerStorage storage)
        {
            AppointmentCollection appointments = storage.Appointments.Items;
            storage.BeginUpdate();
            try {
                for (int i = 0; i < ExampleUtils.Users.Length; i++) {
                    Appointment appointment = storage.CreateAppointment(AppointmentType.Normal);

                    appointment.Start = baseTime.AddHours((i + 1) * 2);
                    appointment.Duration = TimeSpan.FromHours(1);
                    appointment.Subject = ExampleUtils.Users[i] + "'s Appointment";
                    appointment.Location = "Office";
                    appointment.ResourceId = i + 1;
                    appointment.HasReminder = true;
                    appointment.Reminder.TimeBeforeStart = TimeSpan.FromMinutes(10);

                    appointments.Add(appointment);
                }
            }
            finally {
                storage.EndUpdate();
            }
        }
    }
}
