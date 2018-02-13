Imports CodeConvert
Imports FastColoredTextBoxNS
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms


Public Class Form1


    'Coded By : X-SLAYER
    '
    'Feel Free To Support Me With a Donation :
    'https://goo.gl/IqcyTd
    'BTC:
    '1PqKXtkpfejYe2tdsMTL1KopxRZECtT7qx



    Private Sub SavecsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavecsToolStripMenuItem.Click

        If Not (TXTC.Text = Nothing) Then

            Dim Sv As New SaveFileDialog

            Sv.Filter = "C# Files (*.cs)|*.cs"

            If (Sv.ShowDialog = DialogResult.OK) Then

                Dim fileName As String = Sv.FileName

                If Not File.Exists(fileName) Then

                    Dim text As String = Me.TXTC.Text

                    File.WriteAllText(fileName, [text])

                End If

            End If

        Else

            MsgBox("Nothing To Save", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub SavevbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavevbToolStripMenuItem.Click
        If Not (TXTVB.Text = Nothing) Then

            Dim Sv As New SaveFileDialog

            Sv.Filter = "VB.NET Files (*.vb)|*.vb"

            If (Sv.ShowDialog = DialogResult.OK) Then

                Dim fileName As String = Sv.FileName

                If Not File.Exists(fileName) Then

                    Dim text As String = Me.TXTVB.Text

                    File.WriteAllText(fileName, [text])

                End If

            End If

        Else

            MsgBox("Nothing To Save", MsgBoxStyle.Exclamation)

        End If
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXTC.Clear()
        TXTVB.Clear()
    End Sub

    Private Sub CCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CCodeToolStripMenuItem.Click
        Dim open As New OpenFileDialog

        open.Filter = "C# Codes (*.cs)|*.cs"

        If open.ShowDialog = Windows.Forms.DialogResult.OK Then

            TXTC.Text = File.ReadAllText(open.FileName)

        End If
    End Sub

    Private Sub VBNETCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VBNETCodeToolStripMenuItem.Click
        Dim open As New OpenFileDialog

        open.Filter = "VB.NET Codes (*.vb)|*.vb"

        If open.ShowDialog = Windows.Forms.DialogResult.OK Then

            TXTVB.Text = File.ReadAllText(open.FileName)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        '_______________________________________C#==>VB.NET__________________________________________________
        If Me.csR.Checked Then
            If Not TXTC.Text = Nothing Then
                Try
                    Me.TXTVB.Text = ConversionLoader.ConvertCSharpToVB(Me.TXTC.Text) 'Converting From C# To VB.NET
                Catch ex As Exception
                    MsgBox("ERROR:" & ex.Message)
                End Try
            Else
                Interaction.MsgBox("No Code To Convert", MsgBoxStyle.Critical, Nothing)
            End If


            '_______________________________________VB.NET==>C#__________________________________________________

        ElseIf Me.vbR.Checked Then
            If Not TXTVB.Text = Nothing Then
                Try
                    Me.TXTC.Text = ConversionLoader.ConvertVBToCSharp(Me.TXTVB.Text) 'Converting From VB.NET To C#
                Catch ex2 As Exception
                    MsgBox("EROOR:" & ex2.Message)
                End Try
            Else
                Interaction.MsgBox("No Code To Convert", MsgBoxStyle.Critical, Nothing)
            End If
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Coded By : X-SLAYER" & Chr(13) & "+++++++++++++++++" & Chr(13) & "Iheb Briki", MsgBoxStyle.Information)
    End Sub
End Class
