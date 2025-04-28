Imports System.Data.OleDb

Public Class frmWorker
    Public listWorkersForm As frmListWorkers

    Public Sub New(parentForm As frmListWorkers)
        InitializeComponent()
        listWorkersForm = parentForm
    End Sub

    Dim num As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SecondName As String = TextBox1.Text
        Dim Name As String = TextBox2.Text
        Dim LastName As String = TextBox3.Text
        Dim FIO As String = TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text
        Dim paspSeria As String = TextBox4.Text
        Dim paspNum As String = TextBox5.Text
        Dim numCard As String = TextBox6.Text
        Dim srokCard As String = TextBox7.Text
        If RadioButton1.Checked = True Then
            num = True
        ElseIf RadioButton2.Checked = True Then
            num = False
        End If
        If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Or TextBox3.Text.Length = 0 Or
           TextBox4.Text.Length = 0 Or TextBox5.Text.Length = 0 Or TextBox6.Text.Length = 0 Or
           TextBox7.Text.Length = 0 Or num = 2 Then
            MsgBox("Вы не указали всю информацию!")
        Else
            Dim newWorker As New Worker(SecondName, Name, LastName, num, paspSeria, paspNum, numCard, srokCard)
            newWorker.AddWorker(newWorker)
            num = 2
        End If
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class