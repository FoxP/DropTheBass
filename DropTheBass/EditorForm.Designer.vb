<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorForm))
        Me.gbHotkey = New System.Windows.Forms.GroupBox()
        Me.tbHotkey = New System.Windows.Forms.TextBox()
        Me.lbHotkey = New System.Windows.Forms.Label()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.gbSound = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelTop = New System.Windows.Forms.TableLayoutPanel()
        Me.cbPlaySound = New System.Windows.Forms.Button()
        Me.tbSoundPath = New System.Windows.Forms.TextBox()
        Me.cbGetSoundPath = New System.Windows.Forms.Button()
        Me.cbOK = New System.Windows.Forms.Button()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.cbCancel = New System.Windows.Forms.Button()
        Me.gbHotkey.SuspendLayout()
        Me.gbSound.SuspendLayout()
        Me.TableLayoutPanelTop.SuspendLayout()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.TableLayoutPanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbHotkey
        '
        Me.gbHotkey.Controls.Add(Me.tbHotkey)
        Me.gbHotkey.Controls.Add(Me.lbHotkey)
        Me.gbHotkey.Controls.Add(Me.lbInfo)
        Me.gbHotkey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbHotkey.Location = New System.Drawing.Point(6, 60)
        Me.gbHotkey.Margin = New System.Windows.Forms.Padding(6, 0, 6, 6)
        Me.gbHotkey.Name = "gbHotkey"
        Me.gbHotkey.Padding = New System.Windows.Forms.Padding(3, 3, 9, 3)
        Me.gbHotkey.Size = New System.Drawing.Size(622, 46)
        Me.gbHotkey.TabIndex = 3
        Me.gbHotkey.TabStop = False
        Me.gbHotkey.Text = " Hotkey : "
        '
        'tbHotkey
        '
        Me.tbHotkey.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbHotkey.Location = New System.Drawing.Point(459, 16)
        Me.tbHotkey.Name = "tbHotkey"
        Me.tbHotkey.Size = New System.Drawing.Size(154, 20)
        Me.tbHotkey.TabIndex = 3
        '
        'lbHotkey
        '
        Me.lbHotkey.AutoSize = True
        Me.lbHotkey.Location = New System.Drawing.Point(90, 19)
        Me.lbHotkey.Name = "lbHotkey"
        Me.lbHotkey.Size = New System.Drawing.Size(33, 13)
        Me.lbHotkey.TabIndex = 2
        Me.lbHotkey.Text = "None"
        '
        'lbInfo
        '
        Me.lbInfo.AutoSize = True
        Me.lbInfo.Location = New System.Drawing.Point(10, 19)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(84, 13)
        Me.lbInfo.TabIndex = 1
        Me.lbInfo.Text = "Current Hotkey :"
        '
        'gbSound
        '
        Me.gbSound.Controls.Add(Me.TableLayoutPanelTop)
        Me.gbSound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbSound.Location = New System.Drawing.Point(6, 6)
        Me.gbSound.Margin = New System.Windows.Forms.Padding(6)
        Me.gbSound.Name = "gbSound"
        Me.gbSound.Padding = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.gbSound.Size = New System.Drawing.Size(622, 48)
        Me.gbSound.TabIndex = 0
        Me.gbSound.TabStop = False
        Me.gbSound.Text = " Sound : "
        '
        'TableLayoutPanelTop
        '
        Me.TableLayoutPanelTop.ColumnCount = 3
        Me.TableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelTop.Controls.Add(Me.cbPlaySound, 2, 0)
        Me.TableLayoutPanelTop.Controls.Add(Me.tbSoundPath, 0, 0)
        Me.TableLayoutPanelTop.Controls.Add(Me.cbGetSoundPath, 1, 0)
        Me.TableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelTop.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanelTop.Name = "TableLayoutPanelTop"
        Me.TableLayoutPanelTop.RowCount = 1
        Me.TableLayoutPanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTop.Size = New System.Drawing.Size(614, 29)
        Me.TableLayoutPanelTop.TabIndex = 0
        '
        'cbPlaySound
        '
        Me.cbPlaySound.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPlaySound.Location = New System.Drawing.Point(537, 3)
        Me.cbPlaySound.Name = "cbPlaySound"
        Me.cbPlaySound.Size = New System.Drawing.Size(74, 22)
        Me.cbPlaySound.TabIndex = 2
        Me.cbPlaySound.Text = "Play"
        Me.cbPlaySound.UseVisualStyleBackColor = True
        '
        'tbSoundPath
        '
        Me.tbSoundPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSoundPath.Location = New System.Drawing.Point(8, 4)
        Me.tbSoundPath.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbSoundPath.Name = "tbSoundPath"
        Me.tbSoundPath.Size = New System.Drawing.Size(443, 20)
        Me.tbSoundPath.TabIndex = 0
        '
        'cbGetSoundPath
        '
        Me.cbGetSoundPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGetSoundPath.Location = New System.Drawing.Point(457, 3)
        Me.cbGetSoundPath.Name = "cbGetSoundPath"
        Me.cbGetSoundPath.Size = New System.Drawing.Size(74, 22)
        Me.cbGetSoundPath.TabIndex = 1
        Me.cbGetSoundPath.Text = "Browse"
        Me.cbGetSoundPath.UseVisualStyleBackColor = True
        '
        'cbOK
        '
        Me.cbOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOK.Location = New System.Drawing.Point(471, 0)
        Me.cbOK.Margin = New System.Windows.Forms.Padding(3, 0, 2, 3)
        Me.cbOK.Name = "cbOK"
        Me.cbOK.Size = New System.Drawing.Size(75, 23)
        Me.cbOK.TabIndex = 4
        Me.cbOK.Text = "OK"
        Me.cbOK.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.ColumnCount = 1
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.gbSound, 0, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.gbHotkey, 0, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanelBottom, 0, 2)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 3
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(634, 141)
        Me.TableLayoutPanelMain.TabIndex = 9
        '
        'TableLayoutPanelBottom
        '
        Me.TableLayoutPanelBottom.ColumnCount = 3
        Me.TableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelBottom.Controls.Add(Me.cbCancel, 2, 0)
        Me.TableLayoutPanelBottom.Controls.Add(Me.cbOK, 1, 0)
        Me.TableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelBottom.Location = New System.Drawing.Point(3, 112)
        Me.TableLayoutPanelBottom.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.TableLayoutPanelBottom.Name = "TableLayoutPanelBottom"
        Me.TableLayoutPanelBottom.RowCount = 1
        Me.TableLayoutPanelBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelBottom.Size = New System.Drawing.Size(628, 27)
        Me.TableLayoutPanelBottom.TabIndex = 4
        '
        'cbCancel
        '
        Me.cbCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cbCancel.Location = New System.Drawing.Point(552, 0)
        Me.cbCancel.Margin = New System.Windows.Forms.Padding(4, 0, 2, 3)
        Me.cbCancel.Name = "cbCancel"
        Me.cbCancel.Size = New System.Drawing.Size(74, 23)
        Me.cbCancel.TabIndex = 5
        Me.cbCancel.Text = "Cancel"
        Me.cbCancel.UseVisualStyleBackColor = True
        '
        'EditorForm
        '
        Me.AcceptButton = Me.cbOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cbCancel
        Me.ClientSize = New System.Drawing.Size(634, 141)
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000000016, 180)
        Me.MinimumSize = New System.Drawing.Size(500, 180)
        Me.Name = "EditorForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EditorForm"
        Me.gbHotkey.ResumeLayout(False)
        Me.gbHotkey.PerformLayout()
        Me.gbSound.ResumeLayout(False)
        Me.TableLayoutPanelTop.ResumeLayout(False)
        Me.TableLayoutPanelTop.PerformLayout()
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanelBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbHotkey As GroupBox
    Friend WithEvents lbInfo As Label
    Friend WithEvents gbSound As GroupBox
    Friend WithEvents tbSoundPath As TextBox
    Friend WithEvents cbPlaySound As Button
    Friend WithEvents cbGetSoundPath As Button
    Friend WithEvents lbHotkey As Label
    Friend WithEvents cbOK As Button
    Friend WithEvents tbHotkey As TextBox
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanelBottom As TableLayoutPanel
    Friend WithEvents cbCancel As Button
    Friend WithEvents TableLayoutPanelTop As TableLayoutPanel
End Class
