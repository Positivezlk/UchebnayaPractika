Public Class FrmImport
    Private Sub FrmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = folderBrowserDialog.SelectedPath
        End If
    End Sub
End Class