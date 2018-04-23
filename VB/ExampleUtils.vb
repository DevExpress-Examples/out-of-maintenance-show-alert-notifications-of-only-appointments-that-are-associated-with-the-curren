Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraScheduler

Namespace SchedulerFilterReminders
    Public NotInheritable Class ExampleUtils

        Private Sub New()
        End Sub

        Public Shared baseTime As Date = Date.Today.AddDays(-1)
        Public Shared Users() As String = { "Peter Dolan", "Ryan Fischer", "Andrew Miller" }

        Public Shared Sub GenerateSampleResources(ByVal storage As SchedulerStorage)
            Dim resources As ResourceCollection = storage.Resources.Items
            storage.BeginUpdate()
            Try
                For i As Integer = 0 To ExampleUtils.Users.Length - 1
                    Dim resource As Resource = storage.CreateResource(i + 1)

                    resource.Caption = ExampleUtils.Users(i)
                    resources.Add(resource)
                Next i
            Finally
                storage.EndUpdate()
            End Try
        End Sub

        Public Shared Sub GenerateSampleAppointments(ByVal storage As SchedulerStorage)
            Dim appointments As AppointmentCollection = storage.Appointments.Items
            storage.BeginUpdate()
            Try
                For i As Integer = 0 To ExampleUtils.Users.Length - 1
                    Dim appointment As Appointment = storage.CreateAppointment(AppointmentType.Normal)

                    appointment.Start = baseTime.AddHours((i + 1) * 2)
                    appointment.Duration = TimeSpan.FromHours(1)
                    appointment.Subject = ExampleUtils.Users(i) & "'s Appointment"
                    appointment.Location = "Office"
                    appointment.ResourceId = i + 1
                    appointment.HasReminder = True
                    appointment.Reminder.TimeBeforeStart = TimeSpan.FromMinutes(10)

                    appointments.Add(appointment)
                Next i
            Finally
                storage.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
