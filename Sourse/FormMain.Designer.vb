<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TabControlForm = New System.Windows.Forms.TabControl()
        Me.TabPageParam = New System.Windows.Forms.TabPage()
        Me.LabelColorInfo = New System.Windows.Forms.Label()
        Me.ToolStatus = New System.Windows.Forms.TextBox()
        Me.GroupBoxTip = New System.Windows.Forms.GroupBox()
        Me.TextBoxTip = New System.Windows.Forms.TextBox()
        Me.GroupBoxAddictive = New System.Windows.Forms.GroupBox()
        Me.CheckBoxT = New System.Windows.Forms.CheckBox()
        Me.ButtonClearList = New System.Windows.Forms.Button()
        Me.TextBoxP = New System.Windows.Forms.TextBox()
        Me.LabelP = New System.Windows.Forms.Label()
        Me.CheckBoxR = New System.Windows.Forms.CheckBox()
        Me.CheckBoxI = New System.Windows.Forms.CheckBox()
        Me.CheckBoxG = New System.Windows.Forms.CheckBox()
        Me.CheckBoxD = New System.Windows.Forms.CheckBox()
        Me.ButtonLog = New System.Windows.Forms.Button()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.TextBoxM = New System.Windows.Forms.TextBox()
        Me.TextBoxL = New System.Windows.Forms.TextBox()
        Me.LabelM = New System.Windows.Forms.Label()
        Me.LabelL = New System.Windows.Forms.Label()
        Me.LabelC = New System.Windows.Forms.Label()
        Me.TextBoxC = New System.Windows.Forms.TextBox()
        Me.ComboBoxP = New System.Windows.Forms.ComboBox()
        Me.GroupBoxGeneral = New System.Windows.Forms.GroupBox()
        Me.TextBoxW = New System.Windows.Forms.TextBox()
        Me.TextBoxU = New System.Windows.Forms.TextBox()
        Me.LabelW = New System.Windows.Forms.Label()
        Me.LabelU = New System.Windows.Forms.Label()
        Me.LabelH = New System.Windows.Forms.Label()
        Me.TextBoxH = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolButtonStart = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPageResult = New System.Windows.Forms.TabPage()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.TabPageInfo = New System.Windows.Forms.TabPage()
        Me.TextBoxInfo = New System.Windows.Forms.TextBox()
        Me.ImageTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControlForm.SuspendLayout()
        Me.TabPageParam.SuspendLayout()
        Me.GroupBoxTip.SuspendLayout()
        Me.GroupBoxAddictive.SuspendLayout()
        Me.GroupBoxGeneral.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPageResult.SuspendLayout()
        Me.TabPageInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlForm
        '
        Me.TabControlForm.Controls.Add(Me.TabPageParam)
        Me.TabControlForm.Controls.Add(Me.TabPageResult)
        Me.TabControlForm.Controls.Add(Me.TabPageInfo)
        Me.TabControlForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlForm.ImageList = Me.ImageTabs
        Me.TabControlForm.Location = New System.Drawing.Point(0, 0)
        Me.TabControlForm.Name = "TabControlForm"
        Me.TabControlForm.SelectedIndex = 0
        Me.TabControlForm.Size = New System.Drawing.Size(669, 424)
        Me.TabControlForm.TabIndex = 3
        '
        'TabPageParam
        '
        Me.TabPageParam.Controls.Add(Me.LabelColorInfo)
        Me.TabPageParam.Controls.Add(Me.ToolStatus)
        Me.TabPageParam.Controls.Add(Me.GroupBoxTip)
        Me.TabPageParam.Controls.Add(Me.GroupBoxAddictive)
        Me.TabPageParam.Controls.Add(Me.GroupBoxGeneral)
        Me.TabPageParam.Controls.Add(Me.ToolStrip1)
        Me.TabPageParam.ImageIndex = 0
        Me.TabPageParam.Location = New System.Drawing.Point(4, 23)
        Me.TabPageParam.Name = "TabPageParam"
        Me.TabPageParam.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageParam.Size = New System.Drawing.Size(661, 397)
        Me.TabPageParam.TabIndex = 0
        Me.TabPageParam.Text = "Параметры"
        Me.TabPageParam.UseVisualStyleBackColor = True
        '
        'LabelColorInfo
        '
        Me.LabelColorInfo.AutoSize = True
        Me.LabelColorInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelColorInfo.Location = New System.Drawing.Point(548, 276)
        Me.LabelColorInfo.Name = "LabelColorInfo"
        Me.LabelColorInfo.Size = New System.Drawing.Size(75, 13)
        Me.LabelColorInfo.TabIndex = 6
        Me.LabelColorInfo.Text = "LabelColorInfo"
        Me.LabelColorInfo.Visible = False
        '
        'ToolStatus
        '
        Me.ToolStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStatus.Location = New System.Drawing.Point(112, 7)
        Me.ToolStatus.Name = "ToolStatus"
        Me.ToolStatus.ReadOnly = True
        Me.ToolStatus.Size = New System.Drawing.Size(545, 20)
        Me.ToolStatus.TabIndex = 5
        '
        'GroupBoxTip
        '
        Me.GroupBoxTip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxTip.Controls.Add(Me.TextBoxTip)
        Me.GroupBoxTip.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBoxTip.Location = New System.Drawing.Point(2, 277)
        Me.GroupBoxTip.Name = "GroupBoxTip"
        Me.GroupBoxTip.Size = New System.Drawing.Size(655, 120)
        Me.GroupBoxTip.TabIndex = 3
        Me.GroupBoxTip.TabStop = False
        Me.GroupBoxTip.Text = "Подсказка"
        '
        'TextBoxTip
        '
        Me.TextBoxTip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBoxTip.Location = New System.Drawing.Point(6, 23)
        Me.TextBoxTip.Multiline = True
        Me.TextBoxTip.Name = "TextBoxTip"
        Me.TextBoxTip.ReadOnly = True
        Me.TextBoxTip.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxTip.Size = New System.Drawing.Size(643, 91)
        Me.TextBoxTip.TabIndex = 0
        '
        'GroupBoxAddictive
        '
        Me.GroupBoxAddictive.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxAddictive.Controls.Add(Me.CheckBoxT)
        Me.GroupBoxAddictive.Controls.Add(Me.ButtonClearList)
        Me.GroupBoxAddictive.Controls.Add(Me.TextBoxP)
        Me.GroupBoxAddictive.Controls.Add(Me.LabelP)
        Me.GroupBoxAddictive.Controls.Add(Me.CheckBoxR)
        Me.GroupBoxAddictive.Controls.Add(Me.CheckBoxI)
        Me.GroupBoxAddictive.Controls.Add(Me.CheckBoxG)
        Me.GroupBoxAddictive.Controls.Add(Me.CheckBoxD)
        Me.GroupBoxAddictive.Controls.Add(Me.ButtonLog)
        Me.GroupBoxAddictive.Controls.Add(Me.ButtonCopy)
        Me.GroupBoxAddictive.Controls.Add(Me.TextBoxM)
        Me.GroupBoxAddictive.Controls.Add(Me.TextBoxL)
        Me.GroupBoxAddictive.Controls.Add(Me.LabelM)
        Me.GroupBoxAddictive.Controls.Add(Me.LabelL)
        Me.GroupBoxAddictive.Controls.Add(Me.LabelC)
        Me.GroupBoxAddictive.Controls.Add(Me.TextBoxC)
        Me.GroupBoxAddictive.Controls.Add(Me.ComboBoxP)
        Me.GroupBoxAddictive.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBoxAddictive.Location = New System.Drawing.Point(2, 142)
        Me.GroupBoxAddictive.Name = "GroupBoxAddictive"
        Me.GroupBoxAddictive.Size = New System.Drawing.Size(655, 129)
        Me.GroupBoxAddictive.TabIndex = 2
        Me.GroupBoxAddictive.TabStop = False
        Me.GroupBoxAddictive.Text = "Дополнительные параметры"
        '
        'CheckBoxT
        '
        Me.CheckBoxT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxT.AutoSize = True
        Me.CheckBoxT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxT.Location = New System.Drawing.Point(493, 77)
        Me.CheckBoxT.Name = "CheckBoxT"
        Me.CheckBoxT.Size = New System.Drawing.Size(155, 17)
        Me.CheckBoxT.TabIndex = 21
        Me.CheckBoxT.Text = "Добавить время к имени"
        Me.CheckBoxT.UseVisualStyleBackColor = True
        '
        'ButtonClearList
        '
        Me.ButtonClearList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearList.Location = New System.Drawing.Point(465, 23)
        Me.ButtonClearList.Name = "ButtonClearList"
        Me.ButtonClearList.Size = New System.Drawing.Size(25, 20)
        Me.ButtonClearList.TabIndex = 20
        Me.ButtonClearList.Tag = "Очистить дерво папок, прочитанных на FTP"
        Me.ButtonClearList.Text = " x"
        Me.ButtonClearList.UseVisualStyleBackColor = True
        '
        'TextBoxP
        '
        Me.TextBoxP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxP.Location = New System.Drawing.Point(88, 23)
        Me.TextBoxP.Name = "TextBoxP"
        Me.TextBoxP.Size = New System.Drawing.Size(358, 20)
        Me.TextBoxP.TabIndex = 19
        '
        'LabelP
        '
        Me.LabelP.AutoSize = True
        Me.LabelP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelP.Location = New System.Drawing.Point(6, 27)
        Me.LabelP.Name = "LabelP"
        Me.LabelP.Size = New System.Drawing.Size(72, 13)
        Me.LabelP.TabIndex = 15
        Me.LabelP.Tag = "Пароль пользователя. Ключ: -u (вторая часть)   Пример: -uLogin@Password~-----~Исп" &
    "ользуется для установки пароля пользователя обращения к FTP серверу"
        Me.LabelP.Text = "Путь на FTP:"
        '
        'CheckBoxR
        '
        Me.CheckBoxR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxR.AutoSize = True
        Me.CheckBoxR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxR.Location = New System.Drawing.Point(493, 26)
        Me.CheckBoxR.Name = "CheckBoxR"
        Me.CheckBoxR.Size = New System.Drawing.Size(144, 17)
        Me.CheckBoxR.TabIndex = 14
        Me.CheckBoxR.Text = "Удалять файлы на FTP"
        Me.CheckBoxR.UseVisualStyleBackColor = True
        '
        'CheckBoxI
        '
        Me.CheckBoxI.AutoCheck = False
        Me.CheckBoxI.AutoSize = True
        Me.CheckBoxI.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CheckBoxI.Location = New System.Drawing.Point(232, 102)
        Me.CheckBoxI.Name = "CheckBoxI"
        Me.CheckBoxI.Size = New System.Drawing.Size(232, 17)
        Me.CheckBoxI.TabIndex = 13
        Me.CheckBoxI.Text = "Не открывать окно программы (invisible)"
        Me.CheckBoxI.UseVisualStyleBackColor = True
        '
        'CheckBoxG
        '
        Me.CheckBoxG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxG.AutoSize = True
        Me.CheckBoxG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxG.Location = New System.Drawing.Point(493, 102)
        Me.CheckBoxG.Name = "CheckBoxG"
        Me.CheckBoxG.Size = New System.Drawing.Size(164, 17)
        Me.CheckBoxG.TabIndex = 11
        Me.CheckBoxG.Text = "Создавать локальные пути"
        Me.CheckBoxG.UseVisualStyleBackColor = True
        '
        'CheckBoxD
        '
        Me.CheckBoxD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxD.AutoSize = True
        Me.CheckBoxD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxD.Location = New System.Drawing.Point(493, 52)
        Me.CheckBoxD.Name = "CheckBoxD"
        Me.CheckBoxD.Size = New System.Drawing.Size(143, 17)
        Me.CheckBoxD.TabIndex = 10
        Me.CheckBoxD.Text = "Установить дату с FTP"
        Me.CheckBoxD.UseVisualStyleBackColor = True
        '
        'ButtonLog
        '
        Me.ButtonLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLog.Location = New System.Drawing.Point(465, 74)
        Me.ButtonLog.Name = "ButtonLog"
        Me.ButtonLog.Size = New System.Drawing.Size(25, 20)
        Me.ButtonLog.TabIndex = 9
        Me.ButtonLog.Tag = "Выбрать путь сохранения лога"
        Me.ButtonLog.Text = "..."
        Me.ButtonLog.UseVisualStyleBackColor = True
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCopy.Location = New System.Drawing.Point(465, 49)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(25, 20)
        Me.ButtonCopy.TabIndex = 8
        Me.ButtonCopy.Tag = "Выбрать путь сохранения файлов"
        Me.ButtonCopy.Text = "..."
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'TextBoxM
        '
        Me.TextBoxM.Location = New System.Drawing.Point(88, 100)
        Me.TextBoxM.Name = "TextBoxM"
        Me.TextBoxM.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxM.TabIndex = 7
        '
        'TextBoxL
        '
        Me.TextBoxL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxL.Location = New System.Drawing.Point(88, 74)
        Me.TextBoxL.Name = "TextBoxL"
        Me.TextBoxL.Size = New System.Drawing.Size(375, 20)
        Me.TextBoxL.TabIndex = 5
        '
        'LabelM
        '
        Me.LabelM.AutoSize = True
        Me.LabelM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelM.Location = New System.Drawing.Point(6, 104)
        Me.LabelM.Name = "LabelM"
        Me.LabelM.Size = New System.Drawing.Size(84, 13)
        Me.LabelM.TabIndex = 3
        Me.LabelM.Text = "Маска файлов:"
        '
        'LabelL
        '
        Me.LabelL.AutoSize = True
        Me.LabelL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelL.Location = New System.Drawing.Point(6, 78)
        Me.LabelL.Name = "LabelL"
        Me.LabelL.Size = New System.Drawing.Size(81, 13)
        Me.LabelL.TabIndex = 2
        Me.LabelL.Text = "Создать лог в:"
        '
        'LabelC
        '
        Me.LabelC.AutoSize = True
        Me.LabelC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelC.Location = New System.Drawing.Point(6, 53)
        Me.LabelC.Name = "LabelC"
        Me.LabelC.Size = New System.Drawing.Size(79, 13)
        Me.LabelC.TabIndex = 1
        Me.LabelC.Text = "Копировать в:"
        '
        'TextBoxC
        '
        Me.TextBoxC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxC.Location = New System.Drawing.Point(88, 49)
        Me.TextBoxC.Name = "TextBoxC"
        Me.TextBoxC.Size = New System.Drawing.Size(375, 20)
        Me.TextBoxC.TabIndex = 0
        '
        'ComboBoxP
        '
        Me.ComboBoxP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxP.FormattingEnabled = True
        Me.ComboBoxP.Location = New System.Drawing.Point(88, 23)
        Me.ComboBoxP.Name = "ComboBoxP"
        Me.ComboBoxP.Size = New System.Drawing.Size(375, 21)
        Me.ComboBoxP.TabIndex = 18
        '
        'GroupBoxGeneral
        '
        Me.GroupBoxGeneral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxGeneral.Controls.Add(Me.TextBoxW)
        Me.GroupBoxGeneral.Controls.Add(Me.TextBoxU)
        Me.GroupBoxGeneral.Controls.Add(Me.LabelW)
        Me.GroupBoxGeneral.Controls.Add(Me.LabelU)
        Me.GroupBoxGeneral.Controls.Add(Me.LabelH)
        Me.GroupBoxGeneral.Controls.Add(Me.TextBoxH)
        Me.GroupBoxGeneral.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBoxGeneral.Location = New System.Drawing.Point(2, 33)
        Me.GroupBoxGeneral.Name = "GroupBoxGeneral"
        Me.GroupBoxGeneral.Size = New System.Drawing.Size(655, 104)
        Me.GroupBoxGeneral.TabIndex = 1
        Me.GroupBoxGeneral.TabStop = False
        Me.GroupBoxGeneral.Text = "Обязательные параметры"
        '
        'TextBoxW
        '
        Me.TextBoxW.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxW.Location = New System.Drawing.Point(88, 74)
        Me.TextBoxW.Name = "TextBoxW"
        Me.TextBoxW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxW.Size = New System.Drawing.Size(561, 20)
        Me.TextBoxW.TabIndex = 7
        Me.TextBoxW.Tag = ""
        '
        'TextBoxU
        '
        Me.TextBoxU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxU.Location = New System.Drawing.Point(88, 48)
        Me.TextBoxU.Name = "TextBoxU"
        Me.TextBoxU.Size = New System.Drawing.Size(561, 20)
        Me.TextBoxU.TabIndex = 5
        Me.TextBoxU.Tag = ""
        '
        'LabelW
        '
        Me.LabelW.AutoSize = True
        Me.LabelW.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelW.Location = New System.Drawing.Point(6, 78)
        Me.LabelW.Name = "LabelW"
        Me.LabelW.Size = New System.Drawing.Size(48, 13)
        Me.LabelW.TabIndex = 3
        Me.LabelW.Tag = ""
        Me.LabelW.Text = "Пароль:"
        '
        'LabelU
        '
        Me.LabelU.AutoSize = True
        Me.LabelU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelU.Location = New System.Drawing.Point(6, 52)
        Me.LabelU.Name = "LabelU"
        Me.LabelU.Size = New System.Drawing.Size(41, 13)
        Me.LabelU.TabIndex = 2
        Me.LabelU.Tag = ""
        Me.LabelU.Text = "Логин:"
        '
        'LabelH
        '
        Me.LabelH.AutoSize = True
        Me.LabelH.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelH.Location = New System.Drawing.Point(6, 27)
        Me.LabelH.Name = "LabelH"
        Me.LabelH.Size = New System.Drawing.Size(63, 13)
        Me.LabelH.TabIndex = 1
        Me.LabelH.Tag = ""
        Me.LabelH.Text = "Имя хоста:"
        '
        'TextBoxH
        '
        Me.TextBoxH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxH.Location = New System.Drawing.Point(88, 23)
        Me.TextBoxH.Name = "TextBoxH"
        Me.TextBoxH.Size = New System.Drawing.Size(561, 20)
        Me.TextBoxH.TabIndex = 0
        Me.TextBoxH.Tag = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolButtonStart, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(655, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolButtonStart
        '
        Me.ToolButtonStart.Image = CType(resources.GetObject("ToolButtonStart.Image"), System.Drawing.Image)
        Me.ToolButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolButtonStart.Name = "ToolButtonStart"
        Me.ToolButtonStart.Size = New System.Drawing.Size(89, 22)
        Me.ToolButtonStart.Text = "Выполнить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TabPageResult
        '
        Me.TabPageResult.Controls.Add(Me.TextBoxResult)
        Me.TabPageResult.ImageIndex = 1
        Me.TabPageResult.Location = New System.Drawing.Point(4, 23)
        Me.TabPageResult.Name = "TabPageResult"
        Me.TabPageResult.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageResult.Size = New System.Drawing.Size(661, 397)
        Me.TabPageResult.TabIndex = 1
        Me.TabPageResult.Text = "Результат"
        Me.TabPageResult.UseVisualStyleBackColor = True
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxResult.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBoxResult.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxResult.Multiline = True
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.ReadOnly = True
        Me.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxResult.Size = New System.Drawing.Size(655, 391)
        Me.TextBoxResult.TabIndex = 0
        '
        'TabPageInfo
        '
        Me.TabPageInfo.Controls.Add(Me.TextBoxInfo)
        Me.TabPageInfo.ImageIndex = 2
        Me.TabPageInfo.Location = New System.Drawing.Point(4, 23)
        Me.TabPageInfo.Name = "TabPageInfo"
        Me.TabPageInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInfo.Size = New System.Drawing.Size(661, 397)
        Me.TabPageInfo.TabIndex = 2
        Me.TabPageInfo.Text = "Справка"
        Me.TabPageInfo.UseVisualStyleBackColor = True
        '
        'TextBoxInfo
        '
        Me.TextBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxInfo.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxInfo.Multiline = True
        Me.TextBoxInfo.Name = "TextBoxInfo"
        Me.TextBoxInfo.ReadOnly = True
        Me.TextBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxInfo.Size = New System.Drawing.Size(655, 391)
        Me.TextBoxInfo.TabIndex = 1
        Me.TextBoxInfo.Text = resources.GetString("TextBoxInfo.Text")
        '
        'ImageTabs
        '
        Me.ImageTabs.ImageStream = CType(resources.GetObject("ImageTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageTabs.Images.SetKeyName(0, "settings.png")
        Me.ImageTabs.Images.SetKeyName(1, "result.png")
        Me.ImageTabs.Images.SetKeyName(2, "info.png")
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 424)
        Me.Controls.Add(Me.TabControlForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.Text = "FTP Reader"
        Me.TabControlForm.ResumeLayout(False)
        Me.TabPageParam.ResumeLayout(False)
        Me.TabPageParam.PerformLayout()
        Me.GroupBoxTip.ResumeLayout(False)
        Me.GroupBoxTip.PerformLayout()
        Me.GroupBoxAddictive.ResumeLayout(False)
        Me.GroupBoxAddictive.PerformLayout()
        Me.GroupBoxGeneral.ResumeLayout(False)
        Me.GroupBoxGeneral.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPageResult.ResumeLayout(False)
        Me.TabPageResult.PerformLayout()
        Me.TabPageInfo.ResumeLayout(False)
        Me.TabPageInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlForm As TabControl
    Friend WithEvents TabPageParam As TabPage
    Friend WithEvents LabelColorInfo As Label
    Friend WithEvents ToolStatus As TextBox
    Friend WithEvents GroupBoxTip As GroupBox
    Friend WithEvents TextBoxTip As TextBox
    Friend WithEvents GroupBoxAddictive As GroupBox
    Friend WithEvents ButtonClearList As Button
    Friend WithEvents TextBoxP As TextBox
    Friend WithEvents LabelP As Label
    Friend WithEvents CheckBoxR As CheckBox
    Friend WithEvents CheckBoxI As CheckBox
    Friend WithEvents CheckBoxG As CheckBox
    Friend WithEvents CheckBoxD As CheckBox
    Friend WithEvents ButtonLog As Button
    Friend WithEvents ButtonCopy As Button
    Friend WithEvents TextBoxM As TextBox
    Friend WithEvents TextBoxL As TextBox
    Friend WithEvents LabelM As Label
    Friend WithEvents LabelL As Label
    Friend WithEvents LabelC As Label
    Friend WithEvents TextBoxC As TextBox
    Friend WithEvents ComboBoxP As ComboBox
    Friend WithEvents GroupBoxGeneral As GroupBox
    Friend WithEvents TextBoxW As TextBox
    Friend WithEvents TextBoxU As TextBox
    Friend WithEvents LabelW As Label
    Friend WithEvents LabelU As Label
    Friend WithEvents LabelH As Label
    Friend WithEvents TextBoxH As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolButtonStart As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TabPageResult As TabPage
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents TabPageInfo As TabPage
    Friend WithEvents TextBoxInfo As TextBox
    Friend WithEvents ImageTabs As ImageList
    Friend WithEvents CheckBoxT As CheckBox
End Class
