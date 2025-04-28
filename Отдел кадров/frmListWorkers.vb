Imports System.Data.OleDb
Imports System.Net.Sockets
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Security.Authentication.ExtendedProtection
Imports System.Text.Json
Imports PR7.Form1

Public Class frmListWorkers
    Private workerForm As New frmWorker(Me)

    Public mainForm As Form1

    Public Sub New(mainFormInstance As Form1)
        InitializeComponent()
        mainForm = mainFormInstance
    End Sub

    Private Sub frmListWorkers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWorkersFromDatabase()
        workerForm.Show()
        workerForm.Hide()
    End Sub

    Private Sub LoadWorkersFromDatabase()
        TreeView1.Nodes.Clear()
        Dim rootNode As New TreeNode("Работники")
        TreeView1.Nodes.Add(rootNode)

        Dim dbPath As String = "C:\Отдел по купле-продажи недвижимости ОАО «Биржа труда»\Workers.accdb"
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim sql As String = "SELECT FIO, isMale FROM Workers"
            Dim command As New OleDbCommand(sql, connection)

            Using reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim node As New TreeNode(reader("FIO").ToString())
                    If reader("isMale") = True Then
                        node.ImageKey = "male"
                    Else
                        node.ImageKey = "female"
                    End If
                    rootNode.Nodes.Add(node)
                End While
            End Using
        End Using

        ' Добавьте изображения в ImageList TreeView
        TreeView1.ImageList = New ImageList()
        TreeView1.ImageList.Images.Add("male", Image.FromFile("C:\Отдел по купле-продажи недвижимости ОАО «Биржа труда»\images\male.png"))
        TreeView1.ImageList.Images.Add("female", Image.FromFile("C:\Отдел по купле-продажи недвижимости ОАО «Биржа труда»\images\female.png"))
        TreeView1.ImageList.Images.Add("edit", Image.FromFile("C:\Отдел по купле-продажи недвижимости ОАО «Биржа труда»\images\pencil.png"))

        ' Подсчет количества сотрудников (дочерних узлов)
        Dim numberOfEmployees As Integer = rootNode.Nodes.Count
        Label1.Text = "Количество сотрудников: " & numberOfEmployees
    End Sub


    Private Sub AddEmployee_Click(sender As Object, e As EventArgs) Handles Button2.Click
        workerForm.Show()
    End Sub


    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim selectedFio As String = e.Node.Text

        Dim dbPath As String = "C:\Отдел по купле-продажи недвижимости ОАО «Биржа труда»\Workers.accdb"
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim sql As String = "SELECT * FROM Workers WHERE FIO = @FIO"
            Dim command As New OleDbCommand(sql, connection)
            command.Parameters.AddWithValue("@FIO", selectedFio)

            Using reader As OleDbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    TextBox1.Text = reader("SecondName").ToString()
                    TextBox2.Text = reader("FirstName").ToString()
                    TextBox3.Text = reader("LastName").ToString()
                    TextBox4.Text = reader("PaspSeries").ToString()
                    TextBox5.Text = reader("PaspNumber").ToString()
                    TextBox7.Text = reader("CardNumber").ToString()
                    TextBox8.Text = reader("CardDate").ToString()
                End If
            End Using
        End Using
        e.Node.SelectedImageKey = "edit"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim selectedNode As TreeNode = TreeView1.SelectedNode
        If selectedNode Is Nothing Then
            MsgBox("Выберите сотрудника для редактирования!")
            Return
        End If

        Dim newFIO As String = TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text
        Dim newSecondName As String = TextBox1.Text
        Dim newFirstName As String = TextBox2.Text
        Dim newLastName As String = TextBox3.Text
        Dim newPaspSeries As String = TextBox4.Text
        Dim newPaspNumber As String = TextBox5.Text
        Dim newCardNumber As String = TextBox7.Text
        Dim newCardDate As String = TextBox8.Text

        Dim num As Boolean
        If selectedNode.ImageKey = "male" Then
            num = True
        Else
            num = False
        End If
        Dim oldFIO As String = selectedNode.Text
        Dim newWorker As New Worker(newSecondName, newFirstName, newLastName, num, newPaspSeries, newPaspNumber, newCardNumber, newCardDate)
        newWorker.EditWorker(newWorker, oldFIO)
        selectedNode.Text = newFIO
        MessageBox.Show("Данные изменены успешно!", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectedNode As TreeNode = TreeView1.SelectedNode
        If selectedNode Is Nothing Then
            MsgBox("Выберите сотрудника для удаления!")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Вы уверены, что хотите удалить этого сотрудника?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim FIO As String = selectedNode.Text

            Dim worker As New Worker()
            worker.RemoveWorker(FIO)
            TreeView1.Nodes.Remove(selectedNode)
        End If
    End Sub


    Dim LockCount1 As Integer = 0
    Dim LockCount2 As Integer = 0
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If LockCount1 = 0 Then
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox5.ReadOnly = True
            LockCount1 += 1
        Else
            TextBox1.ReadOnly = False
            TextBox2.ReadOnly = False
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
            TextBox5.ReadOnly = False
            LockCount1 += -1
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If LockCount2 = 0 Then
            TextBox6.ReadOnly = True
            TextBox7.ReadOnly = True
            TextBox8.ReadOnly = True
            LockCount2 += 1
        Else
            TextBox6.ReadOnly = False
            TextBox7.ReadOnly = False
            TextBox8.ReadOnly = False
            LockCount2 += -1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub
End Class

