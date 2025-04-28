<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorker
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorker))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label11 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 20)
        Label1.TabIndex = 0
        Label1.Text = "Персональные данные"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 1
        Label2.Text = "Фамилия"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 2
        Label3.Text = "Имя"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(54, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 3
        Label4.Text = "Отчество"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(96, 269)
        Label5.Name = "Label5"
        Label5.Size = New Size(153, 20)
        Label5.TabIndex = 4
        Label5.Text = "Паспотрные данные"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(113, 311)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 20)
        Label6.TabIndex = 5
        Label6.Text = "Серия"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(362, 310)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 20)
        Label7.TabIndex = 6
        Label7.Text = "Номер"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(33, 474)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 20)
        Label8.TabIndex = 7
        Label8.Text = "Банковская карта"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(54, 519)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 20)
        Label9.TabIndex = 8
        Label9.Text = "Номер счета"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(54, 562)
        Label10.Name = "Label10"
        Label10.Size = New Size(110, 20)
        Label10.TabIndex = 9
        Label10.Text = "Срок действия"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(193, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(490, 27)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(193, 114)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(490, 27)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(193, 160)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(490, 27)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(171, 307)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(166, 27)
        TextBox4.TabIndex = 13
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(421, 307)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(261, 27)
        TextBox5.TabIndex = 14
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(363, 518)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(320, 27)
        TextBox6.TabIndex = 15
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(363, 558)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(320, 27)
        TextBox7.TabIndex = 16
        ' 
        ' Button1
        ' 
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(446, 636)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 29)
        Button1.TabIndex = 17
        Button1.Text = "Добавить"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(589, 636)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 18
        Button2.Text = "Отмена"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(225, 208)
        Label11.Name = "Label11"
        Label11.Size = New Size(37, 20)
        Label11.TabIndex = 19
        Label11.Text = "Пол"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(298, 206)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(93, 24)
        RadioButton1.TabIndex = 20
        RadioButton1.TabStop = True
        RadioButton1.Text = "Мужской"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(428, 206)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(92, 24)
        RadioButton2.TabIndex = 21
        RadioButton2.TabStop = True
        RadioButton2.Text = "Женский"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' frmWorker
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(721, 677)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label11)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmWorker"
        Text = "Добавить сотрудника"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
