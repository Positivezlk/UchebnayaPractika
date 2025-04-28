<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListWorkers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListWorkers))
        Dim TreeNode1 As TreeNode = New TreeNode("Работники")
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        TextBox6 = New TextBox()
        Label14 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        TreeView1 = New TreeView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(326, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 20)
        Label2.TabIndex = 2
        Label2.Text = "Персональные данные"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(326, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 3
        Label3.Text = "Фамилия"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(326, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 20)
        Label4.TabIndex = 4
        Label4.Text = "Имя"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(326, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 5
        Label5.Text = "Отчество"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(418, 100)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(338, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(418, 144)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(338, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(418, 190)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(338, 27)
        TextBox3.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(382, 261)
        Label6.Name = "Label6"
        Label6.Size = New Size(153, 20)
        Label6.TabIndex = 9
        Label6.Text = "Паспортные данные"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(416, 314)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 20)
        Label7.TabIndex = 10
        Label7.Text = "Серия"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(582, 314)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 20)
        Label8.TabIndex = 11
        Label8.Text = "Номер"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(474, 314)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(90, 27)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(645, 314)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(111, 27)
        TextBox5.TabIndex = 13
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(326, 368)
        Label9.Name = "Label9"
        Label9.Size = New Size(131, 20)
        Label9.TabIndex = 14
        Label9.Text = "Банковская карта"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(337, 402)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 20)
        Label10.TabIndex = 15
        Label10.Text = "Номер счета"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(337, 446)
        Label11.Name = "Label11"
        Label11.Size = New Size(110, 20)
        Label11.TabIndex = 16
        Label11.Text = "Срок действия"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(474, 402)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(282, 27)
        TextBox7.TabIndex = 18
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(474, 443)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(282, 27)
        TextBox8.TabIndex = 19
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(326, 526)
        Label12.Name = "Label12"
        Label12.Size = New Size(86, 20)
        Label12.TabIndex = 20
        Label12.Text = "Начислено"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(371, 599)
        Label13.Name = "Label13"
        Label13.Size = New Size(227, 20)
        Label13.TabIndex = 21
        Label13.Text = "Сумма последнего начисления"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(604, 599)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(111, 27)
        TextBox6.TabIndex = 22
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(719, 602)
        Label14.Name = "Label14"
        Label14.Size = New Size(37, 20)
        Label14.TabIndex = 23
        Label14.Text = "руб."
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(604, 564)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 29)
        Button1.TabIndex = 24
        Button1.Text = "Все начисления"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(12, 666)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 30)
        Button2.TabIndex = 25
        Button2.Text = "Добавить"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleRight
        Button3.Location = New Point(131, 666)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 26
        Button3.Text = "Удалить"
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(630, 667)
        Button4.Name = "Button4"
        Button4.Size = New Size(126, 29)
        Button4.TabIndex = 27
        Button4.Text = "Выход"
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(505, 667)
        Button5.Name = "Button5"
        Button5.Size = New Size(119, 29)
        Button5.TabIndex = 28
        Button5.Text = "Сохранить"
        Button5.TextImageRelation = TextImageRelation.ImageBeforeText
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.Location = New Point(279, 181)
        Button6.Name = "Button6"
        Button6.Size = New Size(28, 29)
        Button6.TabIndex = 29
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.Location = New Point(279, 398)
        Button7.Name = "Button7"
        Button7.Size = New Size(28, 29)
        Button7.TabIndex = 30
        Button7.TextImageRelation = TextImageRelation.TextAboveImage
        Button7.UseVisualStyleBackColor = True
        ' 
        ' TreeView1
        ' 
        TreeView1.Location = New Point(17, 46)
        TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Узел0"
        TreeNode1.Text = "Работники"
        TreeView1.Nodes.AddRange(New TreeNode() {TreeNode1})
        TreeView1.Size = New Size(246, 614)
        TreeView1.TabIndex = 31
        ' 
        ' frmListWorkers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 699)
        Controls.Add(TreeView1)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label14)
        Controls.Add(TextBox6)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmListWorkers"
        Text = "Сотрудники"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TreeView1 As TreeView
End Class
