<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        fileMenu = New ToolStripMenuItem()
        fileMenuOpen = New ToolStripMenuItem()
        fileMenuSave = New ToolStripMenuItem()
        fileMenuExit = New ToolStripMenuItem()
        ИмпортToolStripMenuItem = New ToolStripMenuItem()
        editMenu = New ToolStripMenuItem()
        viewMenu = New ToolStripMenuItem()
        menuViewToolbars = New ToolStripMenuItem()
        menuViewToolbarsStandart = New ToolStripMenuItem()
        menuViewStatusStrip = New ToolStripMenuItem()
        formatMenu = New ToolStripMenuItem()
        formatMenuFont = New ToolStripMenuItem()
        formatMenuColor = New ToolStripMenuItem()
        directoriesMenu = New ToolStripMenuItem()
        СотрудникиToolStripMenuItem = New ToolStripMenuItem()
        helpMenu = New ToolStripMenuItem()
        ОПрограммеToolStripMenuItem = New ToolStripMenuItem()
        BottomToolStripPanel = New ToolStripPanel()
        TopToolStripPanel = New ToolStripPanel()
        RightToolStripPanel = New ToolStripPanel()
        LeftToolStripPanel = New ToolStripPanel()
        ContentPanel = New ToolStripContentPanel()
        ToolStripButton1 = New ToolStripButton()
        ToolStripButton2 = New ToolStripButton()
        ToolStripButton3 = New ToolStripButton()
        ToolStripButton4 = New ToolStripButton()
        ToolStripButton5 = New ToolStripButton()
        ToolStrip1 = New ToolStrip()
        statusStrip1 = New StatusStrip()
        dateTimeLabel = New ToolStripStatusLabel()
        usernameLabel = New ToolStripStatusLabel()
        progressBarLabel = New ToolStripProgressBar()
        ToolStripContainer1 = New ToolStripContainer()
        Timer = New Timer(components)
        ColorDialog = New ColorDialog()
        FontDialog = New FontDialog()
        OpenFileDialog = New OpenFileDialog()
        SaveFileDialog = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        statusStrip1.SuspendLayout()
        ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        ToolStripContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {fileMenu, editMenu, viewMenu, formatMenu, directoriesMenu, helpMenu})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(861, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' fileMenu
        ' 
        fileMenu.DropDownItems.AddRange(New ToolStripItem() {fileMenuOpen, fileMenuSave, fileMenuExit, ИмпортToolStripMenuItem})
        fileMenu.Name = "fileMenu"
        fileMenu.ShortcutKeys = Keys.Control Or Keys.F
        fileMenu.Size = New Size(59, 24)
        fileMenu.Text = "Файл"
        ' 
        ' fileMenuOpen
        ' 
        fileMenuOpen.Name = "fileMenuOpen"
        fileMenuOpen.ShortcutKeys = Keys.Control Or Keys.O
        fileMenuOpen.Size = New Size(216, 26)
        fileMenuOpen.Text = "Открыть"
        ' 
        ' fileMenuSave
        ' 
        fileMenuSave.Name = "fileMenuSave"
        fileMenuSave.ShortcutKeys = Keys.Control Or Keys.S
        fileMenuSave.Size = New Size(216, 26)
        fileMenuSave.Text = "Сохранить"
        ' 
        ' fileMenuExit
        ' 
        fileMenuExit.Name = "fileMenuExit"
        fileMenuExit.ShortcutKeys = Keys.Alt Or Keys.F4
        fileMenuExit.Size = New Size(216, 26)
        fileMenuExit.Text = "Выход"
        ' 
        ' ИмпортToolStripMenuItem
        ' 
        ИмпортToolStripMenuItem.Name = "ИмпортToolStripMenuItem"
        ИмпортToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F1"
        ИмпортToolStripMenuItem.Size = New Size(216, 26)
        ИмпортToolStripMenuItem.Text = "Импорт"
        ' 
        ' editMenu
        ' 
        editMenu.Name = "editMenu"
        editMenu.ShortcutKeys = Keys.Control Or Keys.E
        editMenu.Size = New Size(74, 24)
        editMenu.Text = "Правка"
        ' 
        ' viewMenu
        ' 
        viewMenu.DropDownItems.AddRange(New ToolStripItem() {menuViewToolbars, menuViewStatusStrip})
        viewMenu.Name = "viewMenu"
        viewMenu.ShortcutKeys = Keys.Control Or Keys.V
        viewMenu.Size = New Size(49, 24)
        viewMenu.Text = "Вид"
        ' 
        ' menuViewToolbars
        ' 
        menuViewToolbars.DropDownItems.AddRange(New ToolStripItem() {menuViewToolbarsStandart})
        menuViewToolbars.Name = "menuViewToolbars"
        menuViewToolbars.Size = New Size(247, 26)
        menuViewToolbars.Text = "Панели инструментов"
        ' 
        ' menuViewToolbarsStandart
        ' 
        menuViewToolbarsStandart.Checked = True
        menuViewToolbarsStandart.CheckState = CheckState.Checked
        menuViewToolbarsStandart.Name = "menuViewToolbarsStandart"
        menuViewToolbarsStandart.Size = New Size(180, 26)
        menuViewToolbarsStandart.Text = "Стандартная"
        ' 
        ' menuViewStatusStrip
        ' 
        menuViewStatusStrip.Checked = True
        menuViewStatusStrip.CheckState = CheckState.Checked
        menuViewStatusStrip.Name = "menuViewStatusStrip"
        menuViewStatusStrip.Size = New Size(247, 26)
        menuViewStatusStrip.Text = "Строка состояния"
        ' 
        ' formatMenu
        ' 
        formatMenu.DropDownItems.AddRange(New ToolStripItem() {formatMenuFont, formatMenuColor})
        formatMenu.Name = "formatMenu"
        formatMenu.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.F
        formatMenu.Size = New Size(77, 24)
        formatMenu.Text = "Формат"
        ' 
        ' formatMenuFont
        ' 
        formatMenuFont.Name = "formatMenuFont"
        formatMenuFont.Size = New Size(140, 26)
        formatMenuFont.Text = "Шрифт"
        ' 
        ' formatMenuColor
        ' 
        formatMenuColor.Name = "formatMenuColor"
        formatMenuColor.Size = New Size(140, 26)
        formatMenuColor.Text = "Цвет"
        ' 
        ' directoriesMenu
        ' 
        directoriesMenu.DropDownItems.AddRange(New ToolStripItem() {СотрудникиToolStripMenuItem})
        directoriesMenu.Name = "directoriesMenu"
        directoriesMenu.ShortcutKeys = Keys.Control Or Keys.D
        directoriesMenu.Size = New Size(117, 24)
        directoriesMenu.Text = "Справочники"
        ' 
        ' СотрудникиToolStripMenuItem
        ' 
        СотрудникиToolStripMenuItem.Name = "СотрудникиToolStripMenuItem"
        СотрудникиToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+W"
        СотрудникиToolStripMenuItem.Size = New Size(230, 26)
        СотрудникиToolStripMenuItem.Text = "Сотрудники"
        ' 
        ' helpMenu
        ' 
        helpMenu.DropDownItems.AddRange(New ToolStripItem() {ОПрограммеToolStripMenuItem})
        helpMenu.Name = "helpMenu"
        helpMenu.ShortcutKeys = Keys.Control Or Keys.H
        helpMenu.Size = New Size(81, 24)
        helpMenu.Text = "Справка"
        ' 
        ' ОПрограммеToolStripMenuItem
        ' 
        ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        ОПрограммеToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Q"
        ОПрограммеToolStripMenuItem.Size = New Size(249, 26)
        ОПрограммеToolStripMenuItem.Text = "О программе..."
        ' 
        ' BottomToolStripPanel
        ' 
        BottomToolStripPanel.Location = New Point(0, 0)
        BottomToolStripPanel.Name = "BottomToolStripPanel"
        BottomToolStripPanel.Orientation = Orientation.Horizontal
        BottomToolStripPanel.RowMargin = New Padding(4, 0, 0, 0)
        BottomToolStripPanel.Size = New Size(0, 0)
        ' 
        ' TopToolStripPanel
        ' 
        TopToolStripPanel.Location = New Point(0, 0)
        TopToolStripPanel.Name = "TopToolStripPanel"
        TopToolStripPanel.Orientation = Orientation.Horizontal
        TopToolStripPanel.RowMargin = New Padding(4, 0, 0, 0)
        TopToolStripPanel.Size = New Size(0, 0)
        ' 
        ' RightToolStripPanel
        ' 
        RightToolStripPanel.Location = New Point(0, 0)
        RightToolStripPanel.Name = "RightToolStripPanel"
        RightToolStripPanel.Orientation = Orientation.Horizontal
        RightToolStripPanel.RowMargin = New Padding(4, 0, 0, 0)
        RightToolStripPanel.Size = New Size(0, 0)
        ' 
        ' LeftToolStripPanel
        ' 
        LeftToolStripPanel.Location = New Point(0, 0)
        LeftToolStripPanel.Name = "LeftToolStripPanel"
        LeftToolStripPanel.Orientation = Orientation.Horizontal
        LeftToolStripPanel.RowMargin = New Padding(4, 0, 0, 0)
        LeftToolStripPanel.Size = New Size(0, 0)
        ' 
        ' ContentPanel
        ' 
        ContentPanel.Size = New Size(188, 1)
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(29, 24)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(29, 24)
        ToolStripButton2.Text = "ToolStripButton2"
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(29, 24)
        ToolStripButton3.Text = "ToolStripButton3"
        ' 
        ' ToolStripButton4
        ' 
        ToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), Image)
        ToolStripButton4.ImageTransparentColor = Color.Magenta
        ToolStripButton4.Name = "ToolStripButton4"
        ToolStripButton4.Size = New Size(29, 24)
        ToolStripButton4.Text = "ToolStripButton4"
        ' 
        ' ToolStripButton5
        ' 
        ToolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), Image)
        ToolStripButton5.ImageTransparentColor = Color.Magenta
        ToolStripButton5.Name = "ToolStripButton5"
        ToolStripButton5.Size = New Size(29, 24)
        ToolStripButton5.Text = "ToolStripButton5"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripButton4, ToolStripButton5})
        ToolStrip1.Location = New Point(0, 28)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(861, 27)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' statusStrip1
        ' 
        statusStrip1.Dock = DockStyle.None
        statusStrip1.ImageScalingSize = New Size(20, 20)
        statusStrip1.Items.AddRange(New ToolStripItem() {dateTimeLabel, usernameLabel, progressBarLabel})
        statusStrip1.Location = New Point(0, 0)
        statusStrip1.Name = "statusStrip1"
        statusStrip1.Size = New Size(837, 26)
        statusStrip1.TabIndex = 2
        statusStrip1.Text = "StatusStrip1"
        ' 
        ' dateTimeLabel
        ' 
        dateTimeLabel.Name = "dateTimeLabel"
        dateTimeLabel.Size = New Size(153, 20)
        dateTimeLabel.Text = "ToolStripStatusLabel1"
        ' 
        ' usernameLabel
        ' 
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(153, 20)
        usernameLabel.Text = "ToolStripStatusLabel1"
        ' 
        ' progressBarLabel
        ' 
        progressBarLabel.Name = "progressBarLabel"
        progressBarLabel.Size = New Size(100, 18)
        ' 
        ' ToolStripContainer1
        ' 
        ' 
        ' ToolStripContainer1.BottomToolStripPanel
        ' 
        ToolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1)
        ' 
        ' ToolStripContainer1.ContentPanel
        ' 
        ToolStripContainer1.ContentPanel.Size = New Size(837, 0)
        ToolStripContainer1.Location = New Point(12, 632)
        ToolStripContainer1.Name = "ToolStripContainer1"
        ToolStripContainer1.Size = New Size(837, 25)
        ToolStripContainer1.TabIndex = 3
        ToolStripContainer1.Text = "ToolStripContainer1"
        ' 
        ' Timer
        ' 
        ' 
        ' OpenFileDialog
        ' 
        OpenFileDialog.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(861, 669)
        Controls.Add(ToolStripContainer1)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Отдел кадров"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        statusStrip1.ResumeLayout(False)
        statusStrip1.PerformLayout()
        ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        ToolStripContainer1.ResumeLayout(False)
        ToolStripContainer1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents statusStrip1 As StatusStrip
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Timer As Timer
    Friend WithEvents fileMenu As ToolStripMenuItem
    Friend WithEvents fileMenuOpen As ToolStripMenuItem
    Friend WithEvents fileMenuSave As ToolStripMenuItem
    Friend WithEvents editMenu As ToolStripMenuItem
    Friend WithEvents viewMenu As ToolStripMenuItem
    Friend WithEvents menuViewToolbars As ToolStripMenuItem
    Friend WithEvents menuViewToolbarsStandart As ToolStripMenuItem
    Friend WithEvents formatMenu As ToolStripMenuItem
    Friend WithEvents directoriesMenu As ToolStripMenuItem
    Friend WithEvents helpMenu As ToolStripMenuItem
    Friend WithEvents dateTimeLabel As ToolStripStatusLabel
    Friend WithEvents usernameLabel As ToolStripStatusLabel
    Friend WithEvents progressBarLabel As ToolStripProgressBar
    Friend WithEvents menuViewStatusStrip As ToolStripMenuItem
    Friend WithEvents formatMenuFont As ToolStripMenuItem
    Friend WithEvents formatMenuColor As ToolStripMenuItem
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents FontDialog As FontDialog
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents fileMenuExit As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ИмпортToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СотрудникиToolStripMenuItem As ToolStripMenuItem

End Class
