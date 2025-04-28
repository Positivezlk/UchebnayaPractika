<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImport
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Файл с данными"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(257, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 74)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Способ импорта"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(313, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Добавить копию данных к существующему справочнику"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(252, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Импортировать данные в новый справочник"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 237)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Параметры импорта"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.RadioButton8)
        Me.GroupBox3.Controls.Add(Me.RadioButton7)
        Me.GroupBox3.Controls.Add(Me.RadioButton6)
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Location = New System.Drawing.Point(256, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 165)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Разделители"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(74, 136)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(27, 20)
        Me.TextBox2.TabIndex = 7
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(6, 137)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton8.TabIndex = 6
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Другой"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(6, 114)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton7.TabIndex = 5
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Пробел"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 91)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton6.TabIndex = 4
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Точка (.)"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 68)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton5.TabIndex = 3
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Запятая (,)"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 45)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(120, 17)
        Me.RadioButton4.TabIndex = 2
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Точка с сапятой (;)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 22)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Табуляция"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Имя справочника (куда импортируем)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Имя листа (откуда импортируем)"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(9, 109)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox2.TabIndex = 11
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 191)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(260, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Первая строка содержит заголовок столбцов"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(9, 214)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(297, 17)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Проверять типы данных и структуру перед импортом"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(246, 394)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Импорт"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(344, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Отмена"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 429)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImport"
        Me.Text = "Импорт данных"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
