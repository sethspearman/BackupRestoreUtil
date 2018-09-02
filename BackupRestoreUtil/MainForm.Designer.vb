<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BackupTab = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RestoreTab = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboFiles = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ScriptsTab = New System.Windows.Forms.TabPage()
        Me.chkRenameAfterRun = New System.Windows.Forms.CheckBox()
        Me.chkDoNotepad = New System.Windows.Forms.CheckBox()
        Me.txtScriptResults = New System.Windows.Forms.TextBox()
        Me.btnExecuteScript = New System.Windows.Forms.Button()
        Me.cboScriptSelector = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.BackupTab.SuspendLayout()
        Me.RestoreTab.SuspendLayout()
        Me.ScriptsTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BackupTab)
        Me.TabControl1.Controls.Add(Me.RestoreTab)
        Me.TabControl1.Controls.Add(Me.ScriptsTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(524, 352)
        Me.TabControl1.TabIndex = 0
        '
        'BackupTab
        '
        Me.BackupTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackupTab.Controls.Add(Me.Label6)
        Me.BackupTab.Controls.Add(Me.txtFileName)
        Me.BackupTab.Controls.Add(Me.Label3)
        Me.BackupTab.Controls.Add(Me.Label1)
        Me.BackupTab.Controls.Add(Me.Button1)
        Me.BackupTab.Controls.Add(Me.Label2)
        Me.BackupTab.Location = New System.Drawing.Point(4, 22)
        Me.BackupTab.Name = "BackupTab"
        Me.BackupTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BackupTab.Size = New System.Drawing.Size(516, 326)
        Me.BackupTab.TabIndex = 0
        Me.BackupTab.Text = "Backup"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Enter A Filename:"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(177, 122)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(174, 20)
        Me.txtFileName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 91)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "clear on start"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(116, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Backup File was created at:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Do Backup Now"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.CausesValidation = False
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(3)
        Me.Label2.Size = New System.Drawing.Size(510, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Use this page to backup eScore."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RestoreTab
        '
        Me.RestoreTab.BackColor = System.Drawing.Color.Red
        Me.RestoreTab.Controls.Add(Me.Label8)
        Me.RestoreTab.Controls.Add(Me.Label7)
        Me.RestoreTab.Controls.Add(Me.btnRestore)
        Me.RestoreTab.Controls.Add(Me.Label5)
        Me.RestoreTab.Controls.Add(Me.cboFiles)
        Me.RestoreTab.Controls.Add(Me.Label4)
        Me.RestoreTab.Location = New System.Drawing.Point(4, 22)
        Me.RestoreTab.Name = "RestoreTab"
        Me.RestoreTab.Padding = New System.Windows.Forms.Padding(3)
        Me.RestoreTab.Size = New System.Drawing.Size(516, 326)
        Me.RestoreTab.TabIndex = 1
        Me.RestoreTab.Text = "Restore"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(51, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(457, 70)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "clear on start"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(71, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Backup File was created at:"
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(127, 170)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(231, 47)
        Me.btnRestore.TabIndex = 5
        Me.btnRestore.Text = "Do Restore Now!"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(71, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(311, 60)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "The following files were found..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The most recent backup is already loaded. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ch" & _
    "oose a different one if this is not correct."
        '
        'cboFiles
        '
        Me.cboFiles.FormattingEnabled = True
        Me.cboFiles.Location = New System.Drawing.Point(51, 143)
        Me.cboFiles.Name = "cboFiles"
        Me.cboFiles.Size = New System.Drawing.Size(394, 21)
        Me.cboFiles.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.CausesValidation = False
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(3)
        Me.Label4.Size = New System.Drawing.Size(510, 68)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Use this page to restore eScore." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CAUTION:  Restoring your database overwrites an" & _
    "y existing data!!  Do not proceed unless you are sure!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ScriptsTab
        '
        Me.ScriptsTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ScriptsTab.Controls.Add(Me.chkRenameAfterRun)
        Me.ScriptsTab.Controls.Add(Me.chkDoNotepad)
        Me.ScriptsTab.Controls.Add(Me.txtScriptResults)
        Me.ScriptsTab.Controls.Add(Me.btnExecuteScript)
        Me.ScriptsTab.Controls.Add(Me.cboScriptSelector)
        Me.ScriptsTab.Controls.Add(Me.Label10)
        Me.ScriptsTab.Controls.Add(Me.Label9)
        Me.ScriptsTab.Location = New System.Drawing.Point(4, 22)
        Me.ScriptsTab.Name = "ScriptsTab"
        Me.ScriptsTab.Size = New System.Drawing.Size(516, 326)
        Me.ScriptsTab.TabIndex = 2
        Me.ScriptsTab.Text = "Run a script"
        '
        'chkRenameAfterRun
        '
        Me.chkRenameAfterRun.AutoSize = True
        Me.chkRenameAfterRun.Checked = True
        Me.chkRenameAfterRun.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRenameAfterRun.Location = New System.Drawing.Point(339, 159)
        Me.chkRenameAfterRun.Name = "chkRenameAfterRun"
        Me.chkRenameAfterRun.Size = New System.Drawing.Size(108, 17)
        Me.chkRenameAfterRun.TabIndex = 10
        Me.chkRenameAfterRun.Text = "Rename after run"
        Me.chkRenameAfterRun.UseVisualStyleBackColor = True
        '
        'chkDoNotepad
        '
        Me.chkDoNotepad.AutoSize = True
        Me.chkDoNotepad.Location = New System.Drawing.Point(339, 136)
        Me.chkDoNotepad.Name = "chkDoNotepad"
        Me.chkDoNotepad.Size = New System.Drawing.Size(143, 17)
        Me.chkDoNotepad.TabIndex = 9
        Me.chkDoNotepad.Text = "Open results in Notepad."
        Me.chkDoNotepad.UseVisualStyleBackColor = True
        '
        'txtScriptResults
        '
        Me.txtScriptResults.Location = New System.Drawing.Point(8, 196)
        Me.txtScriptResults.Multiline = True
        Me.txtScriptResults.Name = "txtScriptResults"
        Me.txtScriptResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScriptResults.Size = New System.Drawing.Size(500, 122)
        Me.txtScriptResults.TabIndex = 8
        '
        'btnExecuteScript
        '
        Me.btnExecuteScript.Enabled = False
        Me.btnExecuteScript.Location = New System.Drawing.Point(92, 136)
        Me.btnExecuteScript.Name = "btnExecuteScript"
        Me.btnExecuteScript.Size = New System.Drawing.Size(231, 47)
        Me.btnExecuteScript.TabIndex = 7
        Me.btnExecuteScript.Text = "Execute"
        Me.btnExecuteScript.UseVisualStyleBackColor = True
        '
        'cboScriptSelector
        '
        Me.cboScriptSelector.FormattingEnabled = True
        Me.cboScriptSelector.Location = New System.Drawing.Point(50, 109)
        Me.cboScriptSelector.Name = "cboScriptSelector"
        Me.cboScriptSelector.Size = New System.Drawing.Size(394, 21)
        Me.cboScriptSelector.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(88, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(338, 60)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "The following scripts were found..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Select a script from the drop down list and " & _
    "click" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Execute to run it."
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Green
        Me.Label9.CausesValidation = False
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(3)
        Me.Label9.Size = New System.Drawing.Size(516, 26)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Use this page to run sql scripts"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 352)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MainForm"
        Me.Text = "Backup/Restore Utility"
        Me.TabControl1.ResumeLayout(False)
        Me.BackupTab.ResumeLayout(False)
        Me.BackupTab.PerformLayout()
        Me.RestoreTab.ResumeLayout(False)
        Me.RestoreTab.PerformLayout()
        Me.ScriptsTab.ResumeLayout(False)
        Me.ScriptsTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents BackupTab As System.Windows.Forms.TabPage
    Friend WithEvents RestoreTab As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboFiles As System.Windows.Forms.ComboBox
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents ScriptsTab As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtScriptResults As System.Windows.Forms.TextBox
    Friend WithEvents btnExecuteScript As System.Windows.Forms.Button
    Friend WithEvents cboScriptSelector As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkDoNotepad As System.Windows.Forms.CheckBox
    Friend WithEvents chkRenameAfterRun As System.Windows.Forms.CheckBox
End Class
