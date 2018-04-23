Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace SchedulerFilterReminders
    Partial Public Class MainForm
        Inherits Form


        Private currentUserId_Renamed As Integer
        Public Property CurrentUserId() As Integer
            Get
                Return currentUserId_Renamed
            End Get
            Set(ByVal value As Integer)
                currentUserId_Renamed = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()

            ' To trigger an alert in five seconds
            schedulerStorage1.RemindersCheckInterval = 5000

            schedulerControl1.Start = ExampleUtils.baseTime
            schedulerControl1.GroupType = SchedulerGroupType.Resource

            ExampleUtils.GenerateSampleResources(schedulerStorage1)
            ExampleUtils.GenerateSampleAppointments(schedulerStorage1)
        End Sub

        Private Sub schedulerStorage1_ReminderAlert(ByVal sender As Object, ByVal e As ReminderEventArgs) Handles schedulerStorage1.ReminderAlert
            For i As Integer = 0 To e.AlertNotifications.Count - 1
                Dim reminderAlertNotification As ReminderAlertNotification = e.AlertNotifications(i)

                reminderAlertNotification.Ignore = Not reminderAlertNotification.ActualAppointment.ResourceId.Equals(currentUserId_Renamed)
                reminderAlertNotification.Handled = True
            Next i
        End Sub
    End Class
End Namespace