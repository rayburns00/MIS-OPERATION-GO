Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class Main_Form

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If (sliding_panel.Width = 295) Then
            sliding_panel.Width = 52
            BunifuCustomLabel2.Hide()
            BunifuCustomLabel3.Hide()
            BunifuSeparator1.Hide()
            BunifuSeparator2.Hide()
        Else
            sliding_panel.Width = 295
            BunifuCustomLabel2.Show()
            BunifuCustomLabel3.Show()
            BunifuSeparator1.Show()
            BunifuSeparator2.Show()
        End If
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        End
        Me.Close()
    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.Amber700, TextShade.WHITE)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Now, "h : mm : ss")
    End Sub
End Class
