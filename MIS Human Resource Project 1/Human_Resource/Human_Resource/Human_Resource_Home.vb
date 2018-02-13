Public Class Human_Resource_Home
    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_emp_Click(sender As Object, e As EventArgs) Handles btn_emp.Click
        Personnel_Details.Show()
    End Sub

    Private Sub btn_sal_Click(sender As Object, e As EventArgs) Handles btn_sal.Click
        Salary_Details.Show()
    End Sub

    Private Sub btn_att_Click(sender As Object, e As EventArgs) Handles btn_att.Click
        Attendance.Show()
    End Sub

    Private Sub btn_rep_Click(sender As Object, e As EventArgs) Handles btn_rep.Click
        Reports.Show()
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        View_Employees.Show()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Create_Account.Show()
    End Sub

    Private Sub btn_sett_Click(sender As Object, e As EventArgs) Handles btn_sett.Click
        Settings.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub Human_Resource_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class