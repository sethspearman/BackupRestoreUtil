'Copyright (c) 2010, SpearSoft LLC
'All rights reserved.

'Redistribution and use in source and binary forms, with or without
'modification, are permitted provided that the following conditions are met:
'    * Redistributions of source code must retain the above copyright
'      notice, this list of conditions and the following disclaimer.
'    * Redistributions in binary form must reproduce the above copyright
'      notice, this list of conditions and the following disclaimer in the
'      documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
'ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
'WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
'DISCLAIMED. IN NO EVENT SHALL SpearSoft LLC BE LIABLE FOR ANY
'DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
'(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
'ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
'(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
'SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.


Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text

Public Class MainForm
    Private _dbName As String = ConfigurationManager.AppSettings("dbName")
    Private _folderPath As String = ConfigurationManager.AppSettings("backupFolder") 'System.IO.Path.GetPathRoot(System.Windows.Forms.Application.ExecutablePath)
    Private _scriptsPath As String = ConfigurationManager.AppSettings("scriptsFolder") 'System.IO.Path.GetPathRoot(System.Windows.Forms.Application.ExecutablePath)
    Private _connectionString As String = ConfigurationManager.AppSettings("connectionString")

    'Hard coded values
    Private _serverName As String = ConfigurationManager.AppSettings("serverName")
    Private _user As String = ConfigurationManager.AppSettings("user")
    Private _pwd As String = ConfigurationManager.AppSettings("password")

    Private _doClose As Boolean = False

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String = "BACKUP DATABASE {0} TO DISK = '{1}' WITH INIT"

        'construct/create the path

        Dim filePath As String = String.Empty
        If Me.txtFileName.Text.Length = 0 Then
            filePath = Path.Combine(_folderPath, Now.ToString("yy-MM-dd_HHmm") & ".BAK")
        Else
            filePath = Path.Combine(_folderPath, String.Format("{0}.BAK", Me.txtFileName.Text))
        End If

        sql = String.Format(sql, _dbName, filePath)

        Try
            Using cn As New SqlConnection(_connectionString)
                cn.Open()
                Using cmd As New SqlCommand(sql, cn)
                    cmd.CommandTimeout = 120
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Label1.Text = "Backup File was created at:  "
            Label3.Text = filePath

        Catch ex As Exception
            Label1.Text = "AN ERROR OCCURRED:  "
            Label3.Text = ex.Message
        End Try

    End Sub

    Public Sub New()
        Try


            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

            Me.Text = String.Format("eScore Backup/Restore Utility {0}", My.Application.Info.Version.ToString)

            Me.Label3.Text = String.Empty
            Me.Label1.Text = String.Empty
            Me.Label7.Text = String.Empty
            Me.Label8.Text = String.Empty

            '" Optional Configuration Settings "
            If String.IsNullOrEmpty(_dbName) Then _dbName = "eScore"
            If String.IsNullOrEmpty(_folderPath) Then _folderPath = "SQL_Backups"
            If String.IsNullOrEmpty(_serverName) Then _serverName = ".\SQLExpress"
            If String.IsNullOrEmpty(_scriptsPath) Then _scriptsPath = "SQL_Scripts"
            If String.IsNullOrEmpty(_user) Then _user = "my_db_user_with_dbo_rights"
            If String.IsNullOrEmpty(_pwd) Then _pwd = "my_db_user_with_dbo_rights_password"

            If String.IsNullOrEmpty(_connectionString) Then
                _connectionString = "Data Source={0};Initial Catalog={1};User Id={2};Password={3};"
            End If

            _connectionString = String.Format(_connectionString, _serverName, _dbName, _user, _pwd)

            _folderPath = Path.Combine(System.IO.Path.GetPathRoot(System.Windows.Forms.Application.ExecutablePath), _folderPath)
            _scriptsPath = Path.Combine(System.IO.Path.GetPathRoot(System.Windows.Forms.Application.ExecutablePath), _scriptsPath)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "An error occurred")
        End Try

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            LoadFileList()
        ElseIf TabControl1.SelectedIndex = 2 Then
            LoadScriptsFileList()
        End If
    End Sub

    Private Sub LoadFileList()
        Dim curFile As String = String.Empty
        Dim selectedFile As String = String.Empty
        Dim selectedDate As DateTime = DateTime.MaxValue
        Dim selectedIdx As Integer = 0

        Dim idx As Integer = 0

        cboFiles.Items.Clear()

        For Each backupFile As String In My.Computer.FileSystem.GetFiles(_folderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.BAK")
            cboFiles.Items.Add(Path.GetFileName(backupFile))
            If selectedFile = String.Empty Then
                'first time through loop
                selectedFile = backupFile
                selectedDate = File.GetLastWriteTime(Path.Combine(_folderPath, backupFile))
            Else
                If File.GetCreationTime(Path.Combine(_folderPath, backupFile)) > selectedDate Then
                    selectedFile = backupFile
                    selectedDate = File.GetLastWriteTime(Path.Combine(_folderPath, backupFile))
                    selectedIdx = idx
                End If
            End If

            idx += 1
        Next

        Me.cboFiles.SelectedIndex = selectedIdx
    End Sub
    Private Sub LoadScriptsFileList()
        Dim curFile As String = String.Empty
        Dim selectedFile As String = String.Empty
        Dim selectedDate As DateTime = DateTime.MaxValue
        Dim selectedIdx As Integer = 0

        Dim idx As Integer = 0

        Me.btnExecuteScript.Enabled = False

        cboScriptSelector.Items.Clear()
        cboScriptSelector.Text = Nothing


        For Each scriptFile As String In My.Computer.FileSystem.GetFiles(_scriptsPath, FileIO.SearchOption.SearchTopLevelOnly, "*.sql")
            cboScriptSelector.Items.Add(Path.GetFileName(scriptFile))
        Next

    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        If MsgBox("Are you sure...this action cannot be undone.", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If MsgBox("FINAL CONFIRMATION!!", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                DoRestore()
            End If
        End If
    End Sub

    Private Sub DoRestore()
        Try
            Dim sql As String = String.Format("USE MASTER; SELECT TOP 1 filename FROM sysdatabases WHERE [name]='{0}'; ", _dbName)

            Dim physicalPath As String = String.Empty

            'get physical path of eScore DB files
            Using cn As New SqlConnection(_connectionString)
                cn.Open()
                Using cmd As New SqlCommand(sql, cn)
                    cmd.CommandTimeout = 120
                    physicalPath = cmd.ExecuteScalar().ToString()
                End Using
            End Using

            physicalPath = Path.GetDirectoryName(physicalPath)

            sql = String.Format("USE master; EXEC asp_KillDBConnections '" & _dbName & "'; RESTORE DATABASE {0} FROM DISK = '{1}' WITH REPLACE, MOVE '{0}' TO '{2}\{0}.mdf', MOVE '{0}_log' TO '{2}\{0}_log.ldf'", _dbName, Path.Combine(_folderPath, Me.cboFiles.SelectedItem), physicalPath)

            'must be admin and use trusted connection to succeed with restore.  
            'add a stored proc to kill a db connection.
            'OR add eScoreAdmin to the sysadmin server role.
            'Using cn As New SqlConnection("Data Source=" & _serverName & ";Initial Catalog=" & _dbName & ";Integrated Security=SSPI;")
            Using cn As New SqlConnection(_connectionString)
                cn.Open()
                Using cmd As New SqlCommand(sql, cn)
                    cmd.CommandTimeout = 120
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            sql = "USE eScore; ALTER USER eScoreAdmin WITH LOGIN=eScoreAdmin; ALTER USER eScoreUser WITH LOGIN=eScoreUser;"
            Using cn As New SqlConnection(_connectionString)
                cn.Open()
                Using cmd As New SqlCommand(sql, cn)
                    cmd.CommandTimeout = 120
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Label7.Text = "Restore successful from file "
            Label8.Text = Path.Combine(_folderPath, cboFiles.SelectedItem)

        Catch ex As Exception
            Label7.Text = "AN ERROR OCCURRED:  "
            Label8.Text = ex.Message
        End Try

    End Sub

    Private Shared Function TrimString(ByVal myString As String) As String


        Dim chArr() As Char = {"|", "\", "/", "*", ":", "?", "<", ">", Chr(34)}

        For Each c As Char In chArr
            myString = myString.Replace(c, String.Empty)
        Next

        Return myString

    End Function

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _doClose Then Me.Close()
    End Sub

    Private Sub btnExecuteScript_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecuteScript.Click

        If Me.cboScriptSelector.Items.Count > 0 AndAlso Me.cboScriptSelector.SelectedIndex > -1 Then

            If MsgBox(String.Format("You should be very sure about running a script before doing it.  {0}{0}Many scripts change data and cannot be undone.  {0}{0}MANY scripts should ONLY BE RUN ONCE.  {0}{0}If you have already run this script you should not run it again. {0}{0}{0}Are you sure you want to run the script?", Environment.NewLine()), MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                Dim scriptFile As String = Path.Combine(_scriptsPath, Me.cboScriptSelector.SelectedItem.ToString)

                ExecuteScript(scriptFile)

            End If



        End If
    End Sub

    Private Sub ExecuteScript(ByVal scriptPath As String)

        Dim tempFile As String = Path.GetTempFileName()

        Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
        startInfo.CreateNoWindow = True
        startInfo.UseShellExecute = True
        startInfo.FileName = "sqlcmd.exe"
        startInfo.Arguments = String.Format("-S{0} -U{1} -P{2} -d{3} -i""{4}"" -o""{5}""", _serverName, _user, _pwd, _dbName, scriptPath, tempFile)

        Try
            Using sqlcmd As Process = Process.Start(startInfo)
                sqlcmd.WaitForExit()
            End Using

            Dim results As String() = File.ReadAllLines(tempFile)

            For Each result As String In results
                Me.txtScriptResults.AppendText(result & Environment.NewLine)
            Next

            If chkDoNotepad.Checked Then
                Using notepad As Process = New Process()
                    notepad.StartInfo.FileName = "notepad.exe"
                    notepad.StartInfo.Arguments = tempFile
                    notepad.Start()
                End Using
            End If

            If chkRenameAfterRun.Checked Then
                Dim fi As New FileInfo(scriptPath)
                fi.MoveTo(String.Format("{0}.RAN-ON-{1:yy-MM-dd_HHmm}", scriptPath, Now))

                fi = Nothing

                LoadScriptsFileList()

            End If

        Catch ex As Exception
            Me.txtScriptResults.AppendText("AN ERROR OCCURRED:  ")
            Me.txtScriptResults.AppendText(ex.Message)
        End Try
    End Sub

    Private Sub cboScriptSelector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboScriptSelector.SelectedIndexChanged
        Me.btnExecuteScript.Enabled = True
    End Sub
End Class