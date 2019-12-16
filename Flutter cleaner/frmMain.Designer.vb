<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtama))
        Me.fldBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.pbLoading = New System.Windows.Forms.ProgressBar()
        Me.lstFolders = New System.Windows.Forms.ListBox()
        Me.lblFolders = New System.Windows.Forms.Label()
        Me.btnCleanAll = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPick
        '
        Me.btnPick.Location = New System.Drawing.Point(347, 7)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(87, 29)
        Me.btnPick.TabIndex = 0
        Me.btnPick.Text = "Pick Folder"
        Me.btnPick.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 12)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(329, 20)
        Me.txtPath.TabIndex = 1
        '
        'pbLoading
        '
        Me.pbLoading.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbLoading.Location = New System.Drawing.Point(0, 268)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(446, 23)
        Me.pbLoading.TabIndex = 2
        '
        'lstFolders
        '
        Me.lstFolders.FormattingEnabled = True
        Me.lstFolders.Location = New System.Drawing.Point(12, 55)
        Me.lstFolders.Name = "lstFolders"
        Me.lstFolders.Size = New System.Drawing.Size(422, 147)
        Me.lstFolders.TabIndex = 3
        '
        'lblFolders
        '
        Me.lblFolders.AutoSize = True
        Me.lblFolders.Location = New System.Drawing.Point(12, 39)
        Me.lblFolders.Name = "lblFolders"
        Me.lblFolders.Size = New System.Drawing.Size(304, 13)
        Me.lblFolders.TabIndex = 4
        Me.lblFolders.Text = "Sub Folder (Double click to run Flutter clean on selected folder)"
        '
        'btnCleanAll
        '
        Me.btnCleanAll.Location = New System.Drawing.Point(12, 209)
        Me.btnCleanAll.Name = "btnCleanAll"
        Me.btnCleanAll.Size = New System.Drawing.Size(422, 29)
        Me.btnCleanAll.TabIndex = 5
        Me.btnCleanAll.Text = "Run Flutter Clean for All Folders"
        Me.btnCleanAll.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInfo.Location = New System.Drawing.Point(0, 252)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(446, 16)
        Me.lblInfo.TabIndex = 6
        Me.lblInfo.Text = "Made with love by Mochamad Nizwar Syafuan"
        '
        'FrmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 291)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnCleanAll)
        Me.Controls.Add(Me.lblFolders)
        Me.Controls.Add(Me.lstFolders)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnPick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmUtama"
        Me.Text = "Flutter Cleaner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fldBrowser As FolderBrowserDialog
    Friend WithEvents btnPick As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents pbLoading As ProgressBar
    Friend WithEvents lstFolders As ListBox
    Friend WithEvents lblFolders As Label
    Friend WithEvents btnCleanAll As Button
    Friend WithEvents lblInfo As Label
End Class
