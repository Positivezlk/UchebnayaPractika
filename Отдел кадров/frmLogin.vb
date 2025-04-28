Public Class FrmLogin
    Dim click As Integer = 0

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Label2.Visible = True
        TextBox2.Visible = True
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If click = 0 Then
            TextBox2.PasswordChar = ControlChars.NullChar
            click += 1
        ElseIf click = 1 Then
            TextBox2.PasswordChar = "*"
            click -= 1
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label2.Visible = False
            TextBox2.Visible = False
            PictureBox1.Visible = False
        Else
            Label2.Visible = True
            TextBox2.Visible = True
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            If TextBox1.Text = "админ" Then
                LetIn()
                Me.Hide()
            Else
                TextBox1.Text = ""
                MsgBox("Имя пользователя введено неверно", vbOK, "Ошибка")
            End If
        Else
            If TextBox1.Text = "админ" And TextBox2.Text = "password" Then
                LetIn()
                Me.Hide()
            Else
                TextBox1.Text = ""
                TextBox2.Text = ""
                MsgBox("Имя пользователя или пароль введены неверно", vbOK, "Ошибка")
            End If
        End If

    End Sub

    Public Function LetIn()
        Form1.MenuStrip1.Visible = True
        Form1.ToolStrip1.Visible = True
        Form1.statusStrip1.Visible = True
        CheckForIllegalCrossThreadCalls = False
        Form1.BeginClock()
    End Function
End Class
