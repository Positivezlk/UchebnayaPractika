Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Data.OleDb

Public Class Worker

    Private strFam As String
    Private strName As String
    Private strOtch As String
    Private bolSex As Boolean
    Private strSeria As String
    Private strNumber As String
    Private strCardNumber As String
    Private strCardDate As String

    Public Property Familia As String
        Get
            Return strFam
        End Get
        Set(value As String)
            strFam = value
        End Set
    End Property

    Public Property Imya As String
        Get
            Return strName
        End Get
        Set(value As String)
            strName = value
        End Set
    End Property

    Public Property Otchestvo As String
        Get
            Return strOtch
        End Get
        Set(value As String)
            strOtch = value
        End Set
    End Property

    Public Property Sex As Boolean
        Get
            Return bolSex
        End Get
        Set(value As Boolean)
            bolSex = value
        End Set
    End Property

    Public Property PassportSeria As String
        Get
            Return strSeria
        End Get
        Set(value As String)
            strSeria = value
        End Set
    End Property

    Public Property PassportNumber As String
        Get
            Return strNumber
        End Get
        Set(value As String)
            strNumber = value
        End Set
    End Property

    Public Property CardNumber As String
        Get
            Return strCardNumber
        End Get
        Set(value As String)
            strCardNumber = value
        End Set
    End Property

    Public Property CardDate As String
        Get
            Return strCardDate
        End Get
        Set(value As String)
            strCardDate = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(fam As String, name As String, otch As String, sex As Boolean, seria As String, number As String, cardNumber As String, cardDate As String)
        strFam = fam
        strName = name
        strOtch = otch
        bolSex = sex
        strSeria = seria
        strNumber = number
        strCardNumber = cardNumber
        strCardDate = cardDate
    End Sub

    Public Sub AddWorker(ByVal worker As Worker)
        Dim dbPath As String = "C:\Отдел по купле-продажи недвижимости ОАО «Биржа труда»\Workers.accdb"
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim sql As String = "INSERT INTO Workers (FIO, PaspSeries, PaspNumber, CardNumber, CardDate, SecondName, FirstName, LastName, isMale) " &
                           "VALUES (@FIO, @PaspSeries, @PaspNumber, @CardNumber, @CardDate, @SecondName, @FirstName, @LastName, @isMale)"
            Dim command As New OleDbCommand(sql, connection)

            command.Parameters.AddWithValue("@FIO", worker.Familia & " " & worker.Imya & " " & worker.Otchestvo)
            command.Parameters.AddWithValue("@PaspSeries", worker.PassportSeria)
            command.Parameters.AddWithValue("@PaspNumber", worker.PassportNumber)
            command.Parameters.AddWithValue("@CardNumber", worker.CardNumber)
            command.Parameters.AddWithValue("@CardDate", worker.CardDate)
            command.Parameters.AddWithValue("@SecondName", worker.Familia)
            command.Parameters.AddWithValue("@FirstName", worker.Imya)
            command.Parameters.AddWithValue("@LastName", worker.Otchestvo)
            command.Parameters.AddWithValue("@isMale", worker.Sex)

            command.ExecuteNonQuery()
        End Using
    End Sub


    Public Sub EditWorker(ByVal worker As Worker, ByVal oldFIO As String)
        Dim dbPath As String = "C:\Отдел по купле-продажи недвижимости ОАО «Биржа труда»\Workers.accdb"
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim sql As String = "UPDATE Workers SET FIO = @newFIO, SecondName = @newSecondName, FirstName = @newFirstName, LastName = @newLastName, " &
                       "PaspSeries = @newPaspSeries, PaspNumber = @newPaspNumber, CardNumber = @newCardNumber, CardDate = @newCardDate " &
                       "WHERE FIO = @oldFIO"

            Dim command As New OleDbCommand(sql, connection)

            command.Parameters.AddWithValue("@newFIO", worker.Familia & " " & worker.Imya & " " & worker.Otchestvo)
            command.Parameters.AddWithValue("@newSecondName", worker.Familia)
            command.Parameters.AddWithValue("@newFirstName", worker.Imya)
            command.Parameters.AddWithValue("@newLastName", worker.Otchestvo)
            command.Parameters.AddWithValue("@newPaspSeries", worker.PassportSeria)
            command.Parameters.AddWithValue("@newPaspNumber", worker.PassportNumber)
            command.Parameters.AddWithValue("@newCardNumber", worker.CardNumber)
            command.Parameters.AddWithValue("@newCardDate", worker.CardDate)
            command.Parameters.AddWithValue("@oldFIO", oldFIO)

            command.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub RemoveWorker(ByVal FIO As String)
        Dim dbPath As String = "C:\Отдел по купле-продажи недвижимости ОАО «Биржа труда»\Workers.accdb"
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim sql As String = "DELETE FROM Workers WHERE FIO = @FIO"
            Dim command As New OleDbCommand(sql, connection)
            command.Parameters.AddWithValue("@FIO", FIO)
            command.ExecuteNonQuery()
        End Using
    End Sub

End Class
