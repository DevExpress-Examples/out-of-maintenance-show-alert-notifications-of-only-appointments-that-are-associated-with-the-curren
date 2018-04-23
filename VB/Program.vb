Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace SchedulerFilterReminders
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            Dim loginForm As New LoginForm()
            If loginForm.ShowDialog() = DialogResult.OK Then
                Dim mainForm As New MainForm()
                mainForm.CurrentUserId = loginForm.SelectedUserId
                loginForm.Dispose()
                Application.Run(mainForm)
            End If
        End Sub
    End Class
End Namespace