Imports MaterialSkin


Public Class Quality_Control
    Private Sub Quality_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.Amber700, TextShade.WHITE)
    End Sub
End Class
