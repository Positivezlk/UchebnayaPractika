Imports System.Reflection.Emit
Public Class Form2
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Label1.Text = "Эта программа упростит учет биржы труда." & vbCrLf & "Данная программа выполнена разработчиками: Дарья и Варвара" & vbCrLf & "Версия: v1.0.0"
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Hide()
    End Sub
End Class