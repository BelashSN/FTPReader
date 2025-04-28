'--------=====-------- Подключение библиотек --------=====-------
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions


'--------=====-------- Описание класса формы --------=====-------
Public Class FormMain
    Dim AutoStart As Boolean = False
    Dim NoLogFile As Boolean = False
    Dim DirsList = New List(Of String)()

    '--------=====-------- Описание класса формы --------=====-------
    Protected Overrides Sub SetVisibleCore(ByVal value As Boolean)
        Dim CommandArgs = Environment.GetCommandLineArgs()
        '------------------- Если команда содержит ключи 
        If CommandArgs.Count > 1 Then
            AutoStart = True
            '------------------- Цикл чтения входящих ключей
            For Each arg As String In CommandArgs
                Dim CurentArg As String = Microsoft.VisualBasic.Strings.Left(arg, 2)
                '-------------------
                If CurentArg = "-r" Then
                    CheckBoxR.Checked = True
                ElseIf CurentArg = "-d" Then
                    CheckBoxD.Checked = True
                ElseIf CurentArg = "-t" Then
                    CheckBoxT.Checked = True
                ElseIf CurentArg = "-g" Then
                    CheckBoxG.Checked = True
                ElseIf CurentArg = "-i" Then
                    CheckBoxI.Checked = True
                ElseIf CurentArg = "-h" Then
                    TextBoxH.Text = arg.Trim.Replace("-h", "").Replace("ftp:/", "").Replace("/", "").Replace("""", "")
                ElseIf CurentArg = "-u" Then
                    Dim CurrentKey = arg.Trim.Replace("-u", "").Replace("""", "")
                    TextBoxU.Text = Microsoft.VisualBasic.Strings.Left(CurrentKey, InStr(CurrentKey, "@") - 1)
                    TextBoxW.Text = CurrentKey.Replace(TextBoxU.Text & "@", "")
                ElseIf CurentArg = "-p" Then
                    Dim CurrentKey = arg.Trim.Replace("-p", "").Replace("""", "").Replace("\\", "\").Replace("//", "\").Replace("/", "\")
                    TextBoxP.Text = IIf(CurrentKey = "", "C:\", IIf(Microsoft.VisualBasic.Strings.Right(CurrentKey, 1) = "\",
                        Replace(CurrentKey & ":~:", "\:~:", ""), CurrentKey))
                ElseIf CurentArg = "-c" Then
                    Dim CurrentKey = arg.Trim.Replace("-c", "").Replace("""", "").Replace("//", "\").Replace("/", "\")
                    TextBoxC.Text = IIf(CurrentKey = "", "C:\", IIf(Microsoft.VisualBasic.Strings.Right(CurrentKey, 1) = "\",
                        Replace(CurrentKey & ":~:", "\:~:", ""), CurrentKey))
                ElseIf CurentArg = "-l" Then
                    Dim CurrentKey = arg.Trim.Replace("-l", "").Replace("""", "").Replace("//", "\").Replace("/", "\")
                    TextBoxL.Text = IIf(CurrentKey = "", "C:\", IIf(Microsoft.VisualBasic.Strings.Right(CurrentKey, 1) = "\",
                         Replace(CurrentKey & ":~:", "\:~:", ""), CurrentKey))
                ElseIf CurentArg = "-m" Then
                    TextBoxM.Text = arg.Trim.Replace("-m", "").Replace("""", "")
                End If
            Next arg
        End If
        '-------------------
        If Not Me.IsHandleCreated Then
            Me.CreateHandle()
            value = Not CheckBoxI.Checked
        End If
        '-------------------
        MyBase.SetVisibleCore(Not CheckBoxI.Checked)
        '-------------------
        If AutoStart And CheckBoxI.Checked Then
            ToolButtonStart_Click(Nothing, Nothing)
        End If
    End Sub

    '--------=====-------- Выбор папки копирования и лога --------=====-------
    Private Sub ButtonDir_Click(sender As Object, e As EventArgs) Handles ButtonLog.Click, ButtonCopy.Click
        '-------------------
        Dim CurrentBox As TextBox = IIf(sender.Name.ToString.Trim = "ButtonCopy", TextBoxC, TextBoxL)
        Dim FBDialog As New FolderBrowserDialog With {.SelectedPath = CurrentBox.Text.ToString.Trim.Replace("""", "")}
        '-------------------
        If FBDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            CurrentBox.Text = """" & FBDialog.SelectedPath & """"
        End If
    End Sub

    '--------=====-------- Отображение подсказки при наведении мыши --------=====-------
    Private Sub Elements_MouseHover(sender As Object, e As EventArgs) Handles LabelH.MouseHover, TextBoxH.MouseHover _
        , LabelU.MouseHover, TextBoxU.MouseHover, TextBoxW.MouseHover, LabelW.MouseHover, TextBoxM.MouseHover, LabelM.MouseHover _
        , TextBoxL.MouseHover, TextBoxC.MouseHover, LabelP.MouseHover, LabelL.MouseHover, LabelC.MouseHover, CheckBoxR.MouseHover _
        , CheckBoxI.MouseHover, CheckBoxG.MouseHover, CheckBoxD.MouseHover, ComboBoxP.MouseHover, TextBoxP.MouseHover _
        , ButtonLog.MouseHover, ButtonCopy.MouseHover, ButtonClearList.MouseHover, CheckBoxT.MouseHover
        '-------------------
        TextBoxTip.Text = sender.tag.ToString
    End Sub

    '--------=====-------- Очистка подсказки при отводе мыши --------=====-------
    Private Sub Elements_MouseLeave(sender As Object, e As EventArgs) Handles LabelH.MouseLeave, TextBoxH.MouseLeave, TextBoxU.MouseLeave _
        , TextBoxW.MouseLeave, LabelU.MouseLeave, LabelW.MouseLeave, TextBoxM.MouseLeave, LabelM.MouseLeave, TextBoxL.MouseLeave _
        , TextBoxC.MouseLeave, LabelP.MouseLeave, LabelL.MouseLeave, LabelC.MouseLeave, CheckBoxR.MouseLeave, CheckBoxI.MouseLeave _
        , CheckBoxG.MouseLeave, CheckBoxD.MouseLeave, ComboBoxP.MouseLeave, TextBoxP.MouseLeave, ButtonLog.MouseLeave _
        , ButtonCopy.MouseLeave, ButtonClearList.MouseLeave, CheckBoxT.MouseLeave
        '-------------------
        TextBoxTip.Text = ""
    End Sub

    '--------=====-------- При изменении значения на форме --------=====-------
    Private Sub Elements_ChangeVale(sender As Object, e As EventArgs) Handles TextBoxC.TextChanged, TextBoxL.TextChanged, TextBoxM.TextChanged _
        , TextBoxW.TextChanged, TextBoxU.TextChanged, CheckBoxI.CheckedChanged, CheckBoxG.CheckedChanged, CheckBoxD.CheckedChanged _
        , CheckBoxR.CheckedChanged, TextBoxH.TextChanged, TextBoxP.TextChanged, CheckBoxT.CheckedChanged
        '-------------------
        Dim NotComplect = (TextBoxH.Text.Trim = "") Or (TextBoxU.Text.Trim = "") Or (TextBoxW.Text.Trim = "")
        CheckBoxD.Checked = IIf(TextBoxC.Text.Trim = "", False, CheckBoxD.Checked)
        CheckBoxT.Checked = IIf(TextBoxC.Text.Trim = "", False, CheckBoxT.Checked)
        ' --------------
        ToolStatus.BackColor = ToolStatus.BackColor
        ToolStatus.ForeColor = IIf(NotComplect, Color.Red, LabelColorInfo.ForeColor)
        ' --------------
        ToolStatus.Text = IIf(NotComplect, "(Не хватает обязательных параметров...)  ", "") &
            "FTPReader.exe -h" & IIf(TextBoxH.Text.Trim = "", "", TextBoxH.Text.Trim) &
            " -u" & IIf(TextBoxU.Text.Trim = "", "", TextBoxU.Text.Trim) &
            "@" & IIf(TextBoxW.Text.Trim = "", "", "*****") &
            IIf(TextBoxP.Text.Trim = "", "", " -p" & TextBoxP.Text.Trim) &
            IIf(TextBoxM.Text.Trim = "", "", " -m" & TextBoxM.Text.Trim) &
            IIf(TextBoxC.Text.Trim = "", "", " -c" & TextBoxC.Text.Trim) &
            IIf(TextBoxL.Text.Trim = "", "", " -l" & TextBoxL.Text.Trim) &
            IIf(CheckBoxD.Checked, " -d", "") &
            IIf(CheckBoxT.Checked, " -t", "") &
            IIf(CheckBoxR.Checked, " -r", "") &
            IIf(CheckBoxG.Checked, " -g", "") &
            IIf(CheckBoxI.Checked, " -i", "")
    End Sub

    '--------=====-------- Разобрать имя FTP хоста --------=====-------
    Private Function PrepareHostName(HostName) As String
        '-------------------
        PrepareHostName = "ftp://" & HostName.Trim.Replace("ftp:", "").Replace("//", "").Replace(":/", "").Replace("""", "")
    End Function

    '--------=====-------- Подготовка докального пути сохранени файлов --------=====-------
    Private Function PrepareLocalPath(LocalPath As String) As String
        '-------------------
        If LocalPath.Trim = "" Then
            PrepareLocalPath = "C:\"
        Else
            Dim NewPath As String = LocalPath.Trim
            Dim IsNet As Boolean = (Microsoft.VisualBasic.Strings.Left(NewPath, 2) = "\\")
            NewPath = NewPath.Replace("\\", "\").Replace("//", "\").Replace("/", "\").Replace("""", "")
            NewPath = IIf(Microsoft.VisualBasic.Strings.Right(NewPath, 1) = "\", NewPath, NewPath & "\")
            If IsNet Then
                NewPath = ("::::" & NewPath).Replace("::::\", "\\")
            End If
            PrepareLocalPath = NewPath
        End If
    End Function

    '--------=====-------- Подготовка удаленного пути FTP --------=====-------
    Private Function PrepareFTPPath(FTPPath As String) As String
        '-------------------
        If FTPPath.Trim = "" Then
            PrepareFTPPath = "/"
        Else
            Dim NewPath As String = FTPPath.Trim.Replace("\\", "/").Replace("//", "/").Replace("\", "/").Replace("""", "")
            NewPath = IIf(Microsoft.VisualBasic.Strings.Right(NewPath, 1) = "/", NewPath, NewPath & "/")
            NewPath = IIf(Microsoft.VisualBasic.Strings.Left(NewPath, 1) = "/", NewPath, "/" & NewPath)
            PrepareFTPPath = NewPath
        End If
    End Function

    '--------=====-------- Получение списка файлов в папке FPT --------=====-------
    Private Function GetDirList(HostName As String, FTPDir As String, Credentials As NetworkCredential) As List(Of String)
        '-------------------
        GetDirList = New List(Of String)()
        Dim DirStrim As IO.StreamReader
        Dim DirRequest As FtpWebRequest
        '-------------------
        Try
            DirRequest = FtpWebRequest.Create(HostName & FTPDir)
            DirRequest.UsePassive = True
            DirRequest.Credentials = Credentials
            DirRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails
            '-------------------
            DirStrim = New IO.StreamReader(DirRequest.GetResponse().GetResponseStream())
            Dim TextArray = DirStrim.ReadToEnd.Split(vbCrLf)
            DirRequest.GetResponse().GetResponseStream().Close()
            '-------------------
            For Each CurrentText In TextArray
                If InStr(CurrentText.Trim.ToUpper, "<DIR>") > 0 Then
                    GetDirList.Add(CurrentText.Replace(vbCrLf, "").Trim)
                End If
            Next
            '-------------------
            DirStrim.Close()
        Catch ex As Exception
        Finally
        End Try
    End Function

    '--------=====-------- Получение дерева файлов на источнике FTP --------=====-------
    Private Sub Fill_ComboBoxP(DirsList As List(Of String), CurrentDir As String)
        '-------------------
        ToolStatus.ForeColor = Color.Red
        ToolStatus.Text = "Ожидайте! Идет построение дерева папок на FTP: " & CurrentDir
        Refresh()
        '-------------------
        Dim FtpCredentials = New NetworkCredential(TextBoxU.Text.Trim, TextBoxW.Text.Trim)
        '-------------------
        Dim FtpRequest As FtpWebRequest
        Dim FtpStrim As IO.StreamReader
        '-------------------
        Dim RealFDir As String = PrepareFTPPath(CurrentDir)
        Dim RealHost As String = PrepareHostName(TextBoxH.Text)
        '-------------------
        Dim DirList = GetDirList(RealHost, RealFDir, FtpCredentials)
        '-------------------
        Try
            FtpRequest = FtpWebRequest.Create(RealHost & RealFDir)
            FtpRequest.UsePassive = True
            FtpRequest.Credentials = FtpCredentials
            FtpRequest.Method = WebRequestMethods.Ftp.ListDirectory
            '-------------------
            FtpStrim = New IO.StreamReader(FtpRequest.GetResponse().GetResponseStream())
            Dim TextArray = FtpStrim.ReadToEnd.Split(vbCrLf)
            FtpRequest.GetResponse().GetResponseStream().Close()
            '-------------------
            For Each CurrentText In TextArray
                Dim FileName = CurrentText.Replace(vbCrLf, "").Trim
                '-------------------
                Dim ItsDir As Boolean = False
                If FileName.Trim <> "" Then
                    For Each DirStr In DirList
                        If InStr(DirStr.ToString.Trim, FileName) > 0 Then
                            ItsDir = True
                            Exit For
                        End If
                    Next
                    '-------------------
                    If ItsDir Then
                        DirsList.Add("""" & RealFDir & FileName & """")
                        Fill_ComboBoxP(DirsList, RealFDir & FileName)
                    End If
                End If
            Next
            '-------------------
            FtpStrim.Close()
        Catch ex As Exception
        Finally
        End Try
    End Sub

    '--------=====-------- Проверка автоподбора пути на источнике --------=====-------
    Private Sub ComboBoxP_Click(sender As Object, e As EventArgs) Handles ComboBoxP.Click
        '-------------------
        Dim NotParam = (TextBoxH.Text.Trim = "") Or (TextBoxU.Text.Trim = "") Or (TextBoxW.Text.Trim = "")
        '-------------------
        If NotParam Then
            MsgBox("Не все обязательные параметры установлены." & vbCrLf &
            "Автоподбор папки на сервере FTP - невозможен", vbOK, "Подбор папки на сервере FTP")
            Exit Sub
        End If
        '-------------------
        If DirsList.Count = 0 Then
            ComboBoxP.Items.Clear()
            Fill_ComboBoxP(DirsList, "")
            Elements_ChangeVale(sender, e)
            '-------------------
            For Each CurrentItem In DirsList
                ComboBoxP.Items.Add(CurrentItem)
            Next
        End If
    End Sub

    '--------=====-------- Очистка выбранного пути FTP --------=====-------
    Private Sub ButtonClearList_Click(sender As Object, e As EventArgs) Handles ButtonClearList.Click
        '-------------------
        DirsList.Clear()
        ComboBoxP.Items.Clear()
    End Sub

    '--------=====-------- Установка пути FTP по выбранной из списка папке --------=====-------
    Private Sub ComboBoxP_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxP.TextChanged
        '-------------------
        TextBoxP.Text = ComboBoxP.Text
    End Sub

    '--------=====-------- При загрузке приложения --------=====-------
    Private Sub FormFTPReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-------------------
        TextBoxTip.BackColor = ToolStatus.BackColor
        TextBoxTip.ForeColor = LabelColorInfo.ForeColor
        ' -------------- Установка текста справки
        TextBoxH.Tag = "        " &
        "Имя хоста FTP сервера (host). Ключ: -h   Пример: 127.0.0.1:21  (-h127.0.0.1:21)
            -----
            Используется для установки имени FTP сервера (и номера порта через "":"")
            Номер порта не обязателен. По умолчанию: 21
            Имя хоста задается без ""ftp:\\""
            Параметр обязателен!!!"
        LabelH.Tag = TextBoxH.Tag
        ' --------------
        TextBoxU.Tag = "        " &
        "Имя пользователя (user). Ключ: -u (первая часть)   Пример: Login  (-uLogin@Password)
            -----
            Используется для установки имени пользователя обращения к FTP серверу
            Параметр обязателен!!!"
        LabelU.Tag = TextBoxH.Tag
        ' --------------
        TextBoxW.Tag = "        " &
        "Имя пользователя (user). Ключ: -u (вторая часть)   Пример: Password  (-uLogin@Password)
            -----
            Используется для установки пароля обращения к FTP серверу
            Параметр обязателен!!!"
        LabelW.Tag = TextBoxH.Tag
        ' --------------
        ComboBoxP.Tag = "        " &
        "Папка на FTP (path). Ключ: -p   Пример: /Folder/New Folder  (-p""/Folder/New Folder"")
            -----
            Используется для установки папки чтения на FTP сервере
            Не обязателен. По умолчанию корневая папака FTP: ""/""
            При наличии прпобелов в именах путь берется в кавычки
            Путь задается без завершающего слеш: ""/""
            Путь на сервере должен существовать"
        LabelP.Tag = ComboBoxP.Tag
        TextBoxP.Tag = ComboBoxP.Tag
        ' --------------
        TextBoxC.Tag = "        " &
        "Локальная папака (copy). Ключ: -c   Пример: \Мои документы\FromFTP  (-c""\Мои документы\FromFTP"")
            -----
            Используется для установки пути копирования с FTP сервера
            Не обязателен. При отсутствии копирование не производится
            При наличии прпобелов в именах путь берется в кавычки
            Путь задается без завершающего слеш: ""\"""
        LabelC.Tag = TextBoxC.Tag
        ' --------------
        TextBoxL.Tag = "        " &
        "Локальная папака (log). Ключ: -l   Пример: \Мои документы\Logs  (-l""\Мои документы\Logs"")
            -----
            Используется для установки пути создания лога работы программы
            Не обязателен. При отсутствии логи программы не создаются
            При наличии прпобелов в именах путь берется в кавычки
            Путь задается без завершающего слеш: ""\"""
        LabelL.Tag = TextBoxL.Tag
        ' --------------
        TextBoxM.Tag = "        " &
        "Маска файлов (mask). Ключ: -m  Пример: *.xls  (-m*.xls)
            -----
            Используется для установки маски выбора файлов на FTP
            Не обязателен. По умолчанию все файлы: *"
        LabelM.Tag = TextBoxM.Tag
        ' --------------
        CheckBoxR.Tag = "        " &
        "Удалять файлы в папке FTP (remove). Ключ: -r   (без параметров)
            -----
            Используется для удаления файлов на FTP сервере по маске
            Не обязателен. При отсутствии файлы на FTP не удаляются"
        ' --------------
        CheckBoxD.Tag = "        " &
        "Установить дату с FTP (date). Ключ: -d   (без параметров)
            -----
            Используется для установки даты скопированных файлов по дате файлов на FTP
            Без установленного ключа -c (copy) значение ключа -d игнорируется. 
            Не обязателен. При отсутствии даты скопированных файлов не изменяются"
        ' --------------
        CheckBoxT.Tag = "        " &
        "Добавить к имени дату-время файлов с FTP (time). Ключ: -t   (без параметров)
            -----
            Используется для добавления в начало имени даты-времени файлов на FTP
            Без установленного ключа -c (copy) значение ключа -t игнорируется. 
            Не обязателен. При отсутствии имена скопированных файлов не изменяются"
        ' --------------
        CheckBoxG.Tag = "        " &
        "Создавать локальные пути (generate). Ключ: -g   (без параметров)
            -----
            Используется для установки даты скопированных файлов по дате файлов на FTP
            Не обязателен. При отсутствии даты скопированных файлов не изменяются"
        ' --------------
        CheckBoxI.Tag = "        " &
        "Не открывать окно программы (invisible). Ключ: -i   (без параметров)
            -----
            Используется для запрета окрытия окна при работе программы
            Не обязателен. При отсутствии окно будет открыто
            При работе с формой ключ не доступен"
        '-------------------
        Elements_ChangeVale(sender, e)
        '-------------------
        If AutoStart Then
            ToolButtonStart_Click(Nothing, Nothing)
        End If
    End Sub

    '--------=====-------- Завершение работы приложения --------=====-------
    Private Sub FinallizeWork(ExitCode As Integer)
        '-------------------
        If (Not NoLogFile) And (TextBoxL.Text.Trim <> "") Then
            Dim LogPath As String = PrepareLocalPath(TextBoxL.Text.Trim) &
                "-FTPMasterLog=" & Format(Now, "yyy-MM-dd=HH-mm-ss") & ".log"
            File.WriteAllText(LogPath, TextBoxResult.Text)
        End If
        '-------------------
        System.Environment.ExitCode = ExitCode
        '-------------------
        If CheckBoxI.Checked Then
            Application.Exit()
        End If
    End Sub

    '--------=====-------- Выполнение выьранных команд --------=====-------
    Private Sub ToolButtonStart_Click(sender As Object, e As EventArgs) Handles ToolButtonStart.Click
        Dim OnlyDir As Boolean = (Not CheckBoxR.Checked) And (TextBoxC.Text.Trim = "")
        TabControlForm.SelectTab(1)
        '-------------------
        Elements_ChangeVale(sender, e)
        TextBoxResult.Text = ToolStatus.Text.Trim.Replace("(Не хватает обязательных параметров...)  ", "") &
        vbCrLf & "==========================="
        '-------------------
        Dim FileCount As Integer = 0
        Dim RealLDir As String = ""
        Dim RealHost As String = PrepareHostName(TextBoxH.Text)
        Dim RealFDir As String = PrepareFTPPath(TextBoxP.Text)
        '-------------------
        RealLDir = PrepareLocalPath(TextBoxL.Text)
        '-------------------
        If TextBoxL.Text.Trim <> "" Then
            If Directory.Exists(RealLDir) Then
                NoLogFile = False
                TextBoxResult.Text = TextBoxResult.Text &
                vbCrLf & Now.ToString & "  Проверка пути сохранения лога (ключ -l)  - OK" &
                vbCrLf & "  Установлен путь сохранения лога - " & RealLDir
            ElseIf CheckBoxG.Checked Then
                Try
                    NoLogFile = False
                    Directory.CreateDirectory(RealLDir)
                    TextBoxResult.Text = TextBoxResult.Text &
                    vbCrLf & Now.ToString & "  Создание (ключ -g) пути сохранения лога (ключ -l)  - OK" &
                    vbCrLf & "  Установлен путь сохранения лога - " & RealLDir
                Catch ex As Exception
                    NoLogFile = True
                    TextBoxResult.Text = TextBoxResult.Text &
                    vbCrLf & Now.ToString & "  Создание (ключ -g) пути сохранения лога (ключ -l)" &
                    vbCrLf & "   - g " & RealLDir &
                    vbCrLf & "   - " & ex.Message.Trim &
                    vbCrLf & "===========================" &
                    vbCrLf & "При создании локальных путей обнаружены ошибки. Выполнение прервано..."
                    '-------------------
                    FinallizeWork(5)
                    Exit Sub
                End Try
            Else
                NoLogFile = True
                TextBoxResult.Text = TextBoxResult.Text &
                vbCrLf & Now.ToString & "  Проверка пути сохранения лога (ключ -l)" &
                vbCrLf & "   -  Путь сохранения лога не существует: " & RealLDir &
                vbCrLf & "===========================" &
                vbCrLf & "При проверке локальных путей обнаружены ошибки. Выполнение прервано..."
                '-------------------
                FinallizeWork(5)
                Exit Sub
            End If
        End If
        '-------------------
        RealLDir = PrepareLocalPath(TextBoxC.Text)
        '-------------------
        If TextBoxC.Text.Trim <> "" Then
            If Directory.Exists(RealLDir) Then
                TextBoxResult.Text = TextBoxResult.Text &
                vbCrLf & Now.ToString & "  Проверка пути сохранения файлов (ключ -c)  - OK" &
                vbCrLf & "  Установлен путь сохранения файлов - " & RealLDir
            ElseIf CheckBoxG.Checked Then
                Try
                    Directory.CreateDirectory(RealLDir)
                    TextBoxResult.Text = TextBoxResult.Text &
                    vbCrLf & Now.ToString & "  Создание (ключ -g) пути сохранения файлов (ключ -c)  - OK" &
                    vbCrLf & "  Установлен путь сохранения файлов - " & RealLDir
                Catch ex As Exception
                    TextBoxResult.Text = TextBoxResult.Text &
                    vbCrLf & Now.ToString & "  Создание (ключ -g) пути сохранения файлов (ключ -c)" &
                    vbCrLf & "   - g " & RealLDir &
                    vbCrLf & "   - " & ex.Message.Trim &
                    vbCrLf & "===========================" &
                    vbCrLf & "При создании локальных путей обнаружены ошибки. Выполнение прервано..."
                    '-------------------
                    FinallizeWork(5)
                    Exit Sub
                End Try
            Else
                TextBoxResult.Text = TextBoxResult.Text &
                vbCrLf & Now.ToString & "  Проверка пути сохранения файлов (ключ -c)" &
                vbCrLf & "   -  Путь сохранения файлов не существует: " & RealLDir &
                vbCrLf & "===========================" &
                vbCrLf & "При проверке локальных путей обнаружены ошибки. Выполнение прервано..."
                '-------------------
                FinallizeWork(5)
                Exit Sub
            End If
        End If
        '------------------- 
        RealLDir = PrepareLocalPath(TextBoxC.Text)
        FileCount = TextBoxResult.Text.Split(vbCrLf).Count
        '-------------------
        TextBoxResult.Text = TextBoxResult.Text & vbCrLf & Now.ToString & "  Проверка обязательных параметров "
        TextBoxResult.Text = IIf(TextBoxH.Text.Trim = "", TextBoxResult.Text & vbCrLf & "   -  Не указаны имя/порт хоста", TextBoxResult.Text)
        TextBoxResult.Text = IIf(TextBoxU.Text.Trim = "", TextBoxResult.Text & vbCrLf & "   -  Не указан логин пользователя", TextBoxResult.Text)
        TextBoxResult.Text = IIf(TextBoxW.Text.Trim = "", TextBoxResult.Text & vbCrLf & "   -  Не указан пароль пользователя", TextBoxResult.Text)
        '-------------------
        If TextBoxResult.Text.Split(vbCrLf).Count > FileCount + 1 Then
            TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "===========================" &
            vbCrLf & "При проверке параметров обнаружены ошибки. Выполнение прервано..."
            '-------------------
            FinallizeWork(4)
            Exit Sub
        Else
            FileCount = 0
            TextBoxResult.Text = TextBoxResult.Text & "  - OK"
        End If
        '-------------------
        Dim TextArray As Array
        Dim FtpRequest As FtpWebRequest
        Dim FtpStrim As IO.StreamReader
        Dim DirList As List(Of String)
        '-------------------
        FileCount = 0
        '-------------------
        Try
            TextBoxResult.Text = TextBoxResult.Text &
            vbCrLf & "  Установлен стартовый каталог на сервере FTP - " & RealFDir &
            vbCrLf & Now.ToString & "  Попытка соединения с сервером: " & TextBoxH.Text.Trim
            '-------------------
            FtpRequest = FtpWebRequest.Create(RealHost & RealFDir)
            FtpRequest.UsePassive = True
            FtpRequest.Credentials = New NetworkCredential(TextBoxU.Text.Trim, TextBoxW.Text.Trim)
            FtpRequest.Method = WebRequestMethods.Ftp.ListDirectory
            '-------------------
            DirList = GetDirList(PrepareHostName(TextBoxH.Text), PrepareFTPPath(TextBoxP.Text), FtpRequest.Credentials)
            '-------------------
            FtpStrim = New IO.StreamReader(FtpRequest.GetResponse().GetResponseStream())
            TextArray = FtpStrim.ReadToEnd.Split(vbCrLf)
            FtpRequest.GetResponse().GetResponseStream().Close()
            '-------------------
            TextBoxResult.Text = TextBoxResult.Text & "  - OK"
            Refresh()
        Catch ex As Exception
            TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   -  " & ex.Message &
            vbCrLf & "===========================" &
            vbCrLf & "При соединении с сервером FTP обнаружены ошибки. Выполнение прервано..."
            '-------------------
            FinallizeWork(3)
            Exit Sub
        End Try
        '-------------------
        TextBoxResult.SelectionStart = TextBoxResult.TextLength - 1
        TextBoxResult.ScrollToCaret()
        '-------------------
        Dim FileMask = TextBoxM.Text.Trim
        Dim UseMask As Boolean = (FileMask <> "")
        TextBoxResult.Text = TextBoxResult.Text &
        vbCrLf & IIf(UseMask _
        , "  Установлена маска поиска файлов на сервере FTP - " & FileMask _
        , "  Маска поиска файлов на сервере FTP не установлена...")
        TextBoxResult.Text = TextBoxResult.Text &
        vbCrLf & Now.ToString & IIf(OnlyDir _
        , "  Ключи -c или -r отсутсвуют. Чтение содержимого папки FTP  - OK" _
        , "  Обработка содержимого папки FTP по выбранным ключам:" &
        IIf(TextBoxC.Text.Trim <> "", " -c", "") &
        IIf(CheckBoxD.Checked And (TextBoxC.Text.Trim <> ""), " -d", "") &
        IIf(CheckBoxR.Checked, " -r", "")) &
        vbCrLf & "==========================="
        '-------------------
        TextBoxResult.SelectionStart = TextBoxResult.TextLength - 1
        TextBoxResult.ScrollToCaret()
        '-------------------
        Dim CopyCount As Integer = 0
        Dim SkipCount As Integer = 0
        Dim BugsCount As Integer = 0
        Dim FileName As String = ""
        '------------------- 
        If OnlyDir Then
            TextBoxResult.Text = TextBoxResult.Text &
            vbCrLf & "  Date time".PadRight(27) & "Size".PadRight(20) & "Name" &
            vbCrLf & "---------------------------------------------------"
        End If
        '-------------------
        For Each CurrentText In TextArray
            Dim DateTimestamp As FtpWebResponse
            Dim FileSize As FtpWebResponse
            '-------------------
            TextBoxResult.SelectionStart = TextBoxResult.TextLength - 1
            TextBoxResult.ScrollToCaret()
            '-------------------
            FileName = CurrentText.Replace(vbCrLf, "").Trim
            If FileName.Trim = "" Then
                Continue For
            End If
            '-------------------
            Try
                If Not OnlyDir Then
                    FileCount = FileCount + 1
                    TextBoxResult.Text = TextBoxResult.Text &
                    IIf(FileCount <= 1, "", vbCrLf & "--------------------   " & Now.ToString) & vbCrLf & FileName
                End If
                '-------------------
                If UseMask Then
                    Dim Regex As New Regex("^" & FileMask.ToUpper.Replace(".", "\.").Replace("*", ".*").Replace("?", "\w") & "$")
                    If Regex.Matches(FileName.ToUpper).Count = 0 Then
                        If Not OnlyDir Then
                            SkipCount = SkipCount + 1
                            TextBoxResult.Text = TextBoxResult.Text &
                            vbCrLf & "  - Пропущен по несоответсвию маске: " & FileMask
                        End If
                        '-------------------
                        Continue For
                    End If
                End If
                '-------------------
                TextBoxResult.SelectionStart = TextBoxResult.TextLength
                TextBoxResult.ScrollToCaret()
                '-------------------
                If OnlyDir Then
                    FileCount = FileCount + 1
                End If
                '-------------------
                Dim ItsDir As Boolean = False
                For Each DirStr In DirList
                    ItsDir = ItsDir Or (InStr(DirStr.ToString.Trim, FileName) > 0)
                Next
                '-------------------
                If ItsDir Then
                    If OnlyDir Then
                        TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "  " & "<DIR>".PadRight(25) & "<DIR>".PadRight(20) & FileName
                    Else
                        SkipCount = SkipCount + 1
                        TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "  - Пропущена папка <DIR>..."
                    End If
                    '-------------------
                    Continue For
                Else
                    Dim FtpData As FtpWebRequest = FtpWebRequest.Create(RealHost & RealFDir & FileName)
                    FtpData.Method = WebRequestMethods.Ftp.GetDateTimestamp
                    FtpData.Credentials = FtpRequest.Credentials
                    FtpData.UsePassive = True
                    DateTimestamp = CType(FtpData.GetResponse(), FtpWebResponse)
                    '-------------------
                    FtpData.GetResponse().Close()
                    '-------------------
                    FtpData = FtpWebRequest.Create(RealHost & RealFDir & FileName)
                    FtpData.Method = WebRequestMethods.Ftp.GetFileSize
                    FtpData.Credentials = FtpRequest.Credentials
                    FtpData.UsePassive = True
                    FileSize = CType(FtpData.GetResponse(), FtpWebResponse)
                    '-------------------
                    FtpData.GetResponse().Close()
                    '-------------------
                    If OnlyDir Then
                        TextBoxResult.Text = TextBoxResult.Text &
                        vbCrLf & "  " & DateTimestamp.LastModified.ToString.PadRight(25).PadRight(25) &
                        ((Math.Round(FileSize.ContentLength / 1048576, 4)) & " mb").PadRight(20) & FileName
                        '-------------------
                        Continue For
                    Else
                        TextBoxResult.Text = TextBoxResult.Text &
                        vbCrLf & "   FTP Дата: " & DateTimestamp.LastModified.ToString.PadRight(18) &
                        "   Размер: " & (Math.Round(FileSize.ContentLength / 1048576, 4)) & " mb"
                        Refresh()
                    End If
                End If
                Refresh()
            Catch ex As Exception
                TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "    - Ошибка чтения файла: " & ex.Message
                BugsCount = BugsCount + 1
                Continue For
            End Try
            '-------------------
            TextBoxResult.SelectionStart = TextBoxResult.TextLength
            TextBoxResult.ScrollToCaret()
            '-------------------
            Dim AddName As String = ""
            Dim Success As Boolean = False
            '-------------------
            If TextBoxC.Text.Trim <> "" Then
                If FileSize.ContentLength <= 0 Then
                    TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   -c: Пропущено копирование файла размером: 0 b"
                    SkipCount = SkipCount + 1
                    Continue For
                End If
                '-------------------
                Try
                    If CheckBoxT.Checked Then
                        AddName = Format(DateTimestamp.LastModified, "yyyyMMddHHmmss") & "_"
                        TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   Ключ -t: Добавление даты-времени к имени файла: " & AddName & FileName
                    Else
                        TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   -t: Ключ не установлен. Добавление даты-времени к имени файла не производится."
                    End If
                    '-------------------
                    TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   Ключ -c: Копирование файла в: " & RealLDir
                    '-------------------
                    Dim FtpData As FtpWebRequest = FtpWebRequest.Create(RealHost & RealFDir & FileName)
                    FtpData.Method = WebRequestMethods.Ftp.DownloadFile
                    FtpData.Credentials = FtpRequest.Credentials
                    FtpData.UsePassive = True
                    FtpData.UseBinary = True
                    '-------------------
                    Dim FileData As FtpWebResponse = CType(FtpData.GetResponse(), FtpWebResponse)
                    Dim ftpStream As Stream = FileData.GetResponseStream()
                    '-------------------
                    Using LocStream As Stream = File.Create(RealLDir & AddName & FileName)
                        Dim buffer As Byte() = New Byte(10240 - 1) {}
                        Dim read As Integer
                        Do
                            read = ftpStream.Read(buffer, 0, buffer.Length)
                            If read > 0 Then
                                LocStream.Write(buffer, 0, read)
                            End If
                        Loop While read > 0
                    End Using
                    '-------------------
                    ftpStream.Close()
                    FtpData.GetResponse().Close()
                    '-------------------
                    Success = True
                    TextBoxResult.Text = TextBoxResult.Text & "  - OK"
                Catch ex As Exception
                    TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "    - Ошибка копирования файла: " & ex.Message
                    BugsCount = BugsCount + 1
                    Continue For
                End Try
            Else
                TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   -c: Ключ не установлен. Копирование файла не производится."
            End If
            '-------------------
            TextBoxResult.SelectionStart = TextBoxResult.TextLength
            TextBoxResult.ScrollToCaret()
            '-------------------
            If CheckBoxD.Checked And (TextBoxC.Text.Trim <> "") Then
                Try
                    TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   Ключ -d: Изменение даты файла на: " & DateTimestamp.LastModified
                    '-------------------
                    File.SetCreationTime(RealLDir & AddName & FileName, DateTimestamp.LastModified)
                    File.SetLastWriteTime(RealLDir & AddName & FileName, DateTimestamp.LastModified)
                    '-------------------
                    TextBoxResult.Text = TextBoxResult.Text & "  - OK"
                Catch ex As Exception
                    TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "    - Ошибка изменения даты файла: " & ex.Message
                    BugsCount = BugsCount + 1
                    Continue For
                End Try
            Else
                TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   -d: Ключ не установлен. Изменение даты файла не производится."
            End If
            '-------------------
            TextBoxResult.SelectionStart = TextBoxResult.TextLength
            TextBoxResult.ScrollToCaret()
            '-------------------
            If CheckBoxR.Checked Then
                If FileSize.ContentLength <= 0 Then
                    TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   -r: Пропущено удаление файла размером: 0 b"
                    SkipCount = SkipCount + 1
                    Continue For
                End If
                '-------------------
                Try
                    TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   Ключ -r: Удаление файла на сервере."
                    '-------------------
                    Dim FtpData As FtpWebRequest = FtpWebRequest.Create(RealHost & RealFDir & FileName)
                    FtpData.Method = WebRequestMethods.Ftp.DeleteFile
                    FtpData.Credentials = FtpRequest.Credentials
                    FtpData.UsePassive = True
                    '-------------------
                    Dim Response As FtpWebResponse = CType(FtpData.GetResponse(), FtpWebResponse)
                    '-------------------
                    FtpData.GetResponse().Close()
                    '-------------------
                    Success = True
                    TextBoxResult.Text = TextBoxResult.Text & "  - OK"
                Catch ex As Exception
                    TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "    - Ошибка удаления файла: " & ex.Message
                    BugsCount = BugsCount + 1
                    Continue For
                End Try
            Else
                TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "   -r: Ключ не установлен. Удаление файла на сервере не производится."
            End If
            '-------------------
            CopyCount = CopyCount + IIf(Success, 1, 0)
        Next
        '-------------------
        TextBoxResult.SelectionStart = TextBoxResult.TextLength
        TextBoxResult.ScrollToCaret()
        '-------------------
        If OnlyDir Then
            TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "===========================" &
                vbCrLf & Now.ToString & "  Чтение содержимого папки FTP завершено  - OK" &
                vbCrLf & "  Всего c учетом маски прочитано файлов (папок): " & FileCount.ToString
        Else
            TextBoxResult.Text = TextBoxResult.Text & vbCrLf & "===========================" &
                vbCrLf & Now.ToString & "  обработка содержимого папки FTP завершена  - OK" &
                vbCrLf & "  Всего обработано файлов (папок): " & FileCount.ToString &
                vbCrLf & "  Всего пропущено файлов (папок): " & SkipCount.ToString &
                vbCrLf & "  Всего скопировано (удалено): " & CopyCount.ToString &
                vbCrLf & "  Всего ошибок: " & BugsCount.ToString
        End If
        Refresh()
        '-------------------
        Dim ExitCode As Integer = 0
        ExitCode = IIf(FileCount - SkipCount <= 0, 1, ExitCode)
        ExitCode = IIf(BugsCount > 0, 2, ExitCode)
        '-------------------
        TextBoxResult.SelectionStart = TextBoxResult.TextLength
        TextBoxResult.ScrollToCaret()
        '-------------------
        FinallizeWork(ExitCode)
    End Sub

End Class

