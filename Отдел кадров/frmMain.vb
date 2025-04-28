Imports System.Threading
Public Class Form1
    Public UserName As String = Environ("USERNAME")
    Dim result As Integer
    Public listWorkersForm As frmListWorkers
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listWorkersForm = New frmListWorkers(Me)
        Dim childForm As New FrmLogin()
        childForm.Show()
        MenuStrip1.Visible = False
        ToolStrip1.Visible = False
        statusStrip1.Visible = False
    End Sub
    Public Function BeginClock()
        Dim trd As Thread = New Thread(AddressOf UpdateClock)
        trd.IsBackground = True
        trd.Start()
    End Function
    Public Function UpdateClock()
        While True
            dateTimeLabel.Text = Format(Now, "dd-mm-yyyy hh:mm:ss")
            Thread.Sleep(1000)
        End While
    End Function

    Private Sub fileMenuOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fileMenuOpen.Click
        Dim OpenFileDialog As New OpenFileDialog
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            Dim fileName = OpenFileDialog.FileName
            MessageBox.Show("Выбран файл: " & fileName)
        End If
    End Sub

    Private Sub fileMenuSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fileMenuSave.Click
        Dim SaveFileDialog As New SaveFileDialog()
        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = SaveFileDialog.FileName
            MessageBox.Show("Путь сохранения: " & fileName)
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer.Tick
        Me.dateTimeLabel.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")
    End Sub

    Private Sub menuViewToolbarsStandart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuViewToolbarsStandart.Click
        Me.ToolStrip1.Visible = Not Me.ToolStrip1.Visible
        Me.menuViewToolbarsStandart.Checked = Me.ToolStrip1.Visible
    End Sub

    Private Sub menuViewStatusStripe_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuViewStatusStrip.Click
        Me.statusStrip1.Visible = Not Me.statusStrip1.Visible
        Me.menuViewStatusStrip.Checked = Me.statusStrip1.Visible
    End Sub

    Private Sub formatMenuFont_Click(ByVal sender As Object, ByVal e As EventArgs) Handles formatMenuFont.Click
        If Me.FontDialog.ShowDialog() = DialogResult.OK Then
            Me.Font = Me.FontDialog.Font
        End If
    End Sub
    Private Sub formatMenuColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles formatMenuColor.Click
        If Me.ColorDialog.ShowDialog() = DialogResult.OK Then
            Me.ForeColor = Me.ColorDialog.Color
        End If
    End Sub

    Private Sub fileMenuExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fileMenuExit.Click
        Dim result As DialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        Dim childForm As New Form2()
        childForm.Show()
    End Sub
    Private Sub ИмпортToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИмпортToolStripMenuItem.Click
        Dim childForm As New FrmImport()
        childForm.Show()
    End Sub
    Private Sub СотрудникиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СотрудникиToolStripMenuItem.Click
        Dim listWorkersForm As New frmListWorkers(Me) ' Передаем 'Me' (ссылку на frmMain)
        listWorkersForm.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim workerForm As New frmWorker(listWorkersForm) ' Передаем ссылку на frmListWorkers
        workerForm.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim listWorkersForm As New frmListWorkers(Me) ' Передаем 'Me' (ссылку на frmMain)
        listWorkersForm.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim listWorkersForm As New frmListWorkers(Me) ' Передаем 'Me' (ссылку на frmMain)
        listWorkersForm.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim listWorkersForm As New frmListWorkers(Me) ' Передаем 'Me' (ссылку на frmMain)
        listWorkersForm.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Me.Close()
    End Sub
End Class
