Imports MaterialSkin


Public Class Collection_Form
    Private Sub Collection_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.ColorScheme = New ColorScheme(Primary.DeepOrange600, Primary.DeepOrange600, Primary.DeepOrange600, Accent.Yellow700, TextShade.WHITE)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        End
    End Sub
End Class
