<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.cbPresets = New System.Windows.Forms.ComboBox()
        Me.nudButtons = New System.Windows.Forms.NumericUpDown()
        Me.cbAddPreset = New System.Windows.Forms.Button()
        Me.cbRemove = New System.Windows.Forms.Button()
        Me.FlowLayoutPanelMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.cbRename = New System.Windows.Forms.Button()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.lbPreset = New System.Windows.Forms.Label()
        Me.lbButtons = New System.Windows.Forms.Label()
        Me.cbExport = New System.Windows.Forms.Button()
        Me.cbImport = New System.Windows.Forms.Button()
        Me.TableLayoutPanelBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.cbOverlap = New System.Windows.Forms.CheckBox()
        Me.cbAbout = New System.Windows.Forms.Button()
        Me.cbHotkeys = New System.Windows.Forms.CheckBox()
        Me.cbStop = New System.Windows.Forms.Button()
        Me.cbStartup = New System.Windows.Forms.CheckBox()
        CType(Me.nudButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.TableLayoutPanelHeader.SuspendLayout()
        Me.TableLayoutPanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbPresets
        '
        Me.cbPresets.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPresets.FormattingEnabled = True
        Me.cbPresets.Location = New System.Drawing.Point(63, 6)
        Me.cbPresets.Name = "cbPresets"
        Me.cbPresets.Size = New System.Drawing.Size(138, 21)
        Me.cbPresets.Sorted = True
        Me.cbPresets.TabIndex = 0
        '
        'nudButtons
        '
        Me.nudButtons.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudButtons.Enabled = False
        Me.nudButtons.Location = New System.Drawing.Point(627, 7)
        Me.nudButtons.Name = "nudButtons"
        Me.nudButtons.Size = New System.Drawing.Size(66, 20)
        Me.nudButtons.TabIndex = 6
        '
        'cbAddPreset
        '
        Me.cbAddPreset.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAddPreset.Location = New System.Drawing.Point(207, 5)
        Me.cbAddPreset.Name = "cbAddPreset"
        Me.cbAddPreset.Size = New System.Drawing.Size(66, 23)
        Me.cbAddPreset.TabIndex = 1
        Me.cbAddPreset.Text = "Add"
        Me.cbAddPreset.UseVisualStyleBackColor = True
        '
        'cbRemove
        '
        Me.cbRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRemove.Location = New System.Drawing.Point(279, 5)
        Me.cbRemove.Name = "cbRemove"
        Me.cbRemove.Size = New System.Drawing.Size(66, 23)
        Me.cbRemove.TabIndex = 2
        Me.cbRemove.Text = "Remove"
        Me.cbRemove.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelMain
        '
        Me.FlowLayoutPanelMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanelMain.AutoSize = True
        Me.FlowLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanelMain.Location = New System.Drawing.Point(352, 45)
        Me.FlowLayoutPanelMain.Name = "FlowLayoutPanelMain"
        Me.FlowLayoutPanelMain.Size = New System.Drawing.Size(0, 351)
        Me.FlowLayoutPanelMain.TabIndex = 7
        '
        'cbRename
        '
        Me.cbRename.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRename.Location = New System.Drawing.Point(351, 5)
        Me.cbRename.Name = "cbRename"
        Me.cbRename.Size = New System.Drawing.Size(66, 23)
        Me.cbRename.TabIndex = 3
        Me.cbRename.Text = "Rename"
        Me.cbRename.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanelMain.ColumnCount = 1
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanelHeader, 0, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.FlowLayoutPanelMain, 0, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanelBottom, 0, 2)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 3
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(704, 441)
        Me.TableLayoutPanelMain.TabIndex = 0
        '
        'TableLayoutPanelHeader
        '
        Me.TableLayoutPanelHeader.ColumnCount = 9
        Me.TableLayoutPanelHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanelHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanelHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanelHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanelHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanelHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanelHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelHeader.Controls.Add(Me.cbAddPreset, 2, 0)
        Me.TableLayoutPanelHeader.Controls.Add(Me.nudButtons, 8, 0)
        Me.TableLayoutPanelHeader.Controls.Add(Me.lbPreset, 0, 0)
        Me.TableLayoutPanelHeader.Controls.Add(Me.lbButtons, 7, 0)
        Me.TableLayoutPanelHeader.Controls.Add(Me.cbPresets, 1, 0)
        Me.TableLayoutPanelHeader.Controls.Add(Me.cbExport, 6, 0)
        Me.TableLayoutPanelHeader.Controls.Add(Me.cbRemove, 3, 0)
        Me.TableLayoutPanelHeader.Controls.Add(Me.cbImport, 5, 0)
        Me.TableLayoutPanelHeader.Controls.Add(Me.cbRename, 4, 0)
        Me.TableLayoutPanelHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelHeader.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanelHeader.Name = "TableLayoutPanelHeader"
        Me.TableLayoutPanelHeader.RowCount = 1
        Me.TableLayoutPanelHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelHeader.Size = New System.Drawing.Size(696, 34)
        Me.TableLayoutPanelHeader.TabIndex = 0
        '
        'lbPreset
        '
        Me.lbPreset.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPreset.AutoSize = True
        Me.lbPreset.Location = New System.Drawing.Point(3, 10)
        Me.lbPreset.Name = "lbPreset"
        Me.lbPreset.Size = New System.Drawing.Size(54, 13)
        Me.lbPreset.TabIndex = 9
        Me.lbPreset.Text = "Presets : "
        '
        'lbButtons
        '
        Me.lbButtons.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbButtons.AutoSize = True
        Me.lbButtons.Location = New System.Drawing.Point(567, 10)
        Me.lbButtons.Name = "lbButtons"
        Me.lbButtons.Size = New System.Drawing.Size(54, 13)
        Me.lbButtons.TabIndex = 10
        Me.lbButtons.Text = "Buttons : "
        '
        'cbExport
        '
        Me.cbExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbExport.Location = New System.Drawing.Point(495, 5)
        Me.cbExport.Name = "cbExport"
        Me.cbExport.Size = New System.Drawing.Size(66, 23)
        Me.cbExport.TabIndex = 5
        Me.cbExport.Text = "Export"
        Me.cbExport.UseVisualStyleBackColor = True
        '
        'cbImport
        '
        Me.cbImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbImport.Location = New System.Drawing.Point(423, 5)
        Me.cbImport.Name = "cbImport"
        Me.cbImport.Size = New System.Drawing.Size(66, 23)
        Me.cbImport.TabIndex = 4
        Me.cbImport.Text = "Import"
        Me.cbImport.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelBottom
        '
        Me.TableLayoutPanelBottom.ColumnCount = 5
        Me.TableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanelBottom.Controls.Add(Me.cbStartup, 0, 0)
        Me.TableLayoutPanelBottom.Controls.Add(Me.cbAbout, 4, 0)
        Me.TableLayoutPanelBottom.Controls.Add(Me.cbHotkeys, 3, 0)
        Me.TableLayoutPanelBottom.Controls.Add(Me.cbStop, 0, 0)
        Me.TableLayoutPanelBottom.Controls.Add(Me.cbOverlap, 2, 0)
        Me.TableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelBottom.Location = New System.Drawing.Point(4, 403)
        Me.TableLayoutPanelBottom.Name = "TableLayoutPanelBottom"
        Me.TableLayoutPanelBottom.RowCount = 1
        Me.TableLayoutPanelBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelBottom.Size = New System.Drawing.Size(696, 34)
        Me.TableLayoutPanelBottom.TabIndex = 8
        '
        'cbOverlap
        '
        Me.cbOverlap.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOverlap.AutoSize = True
        Me.cbOverlap.Location = New System.Drawing.Point(404, 9)
        Me.cbOverlap.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.cbOverlap.Name = "cbOverlap"
        Me.cbOverlap.Size = New System.Drawing.Size(104, 17)
        Me.cbOverlap.TabIndex = 10
        Me.cbOverlap.Text = "Overlap sounds"
        Me.cbOverlap.UseVisualStyleBackColor = True
        '
        'cbAbout
        '
        Me.cbAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAbout.Location = New System.Drawing.Point(624, 5)
        Me.cbAbout.Name = "cbAbout"
        Me.cbAbout.Size = New System.Drawing.Size(69, 23)
        Me.cbAbout.TabIndex = 12
        Me.cbAbout.Text = "?"
        Me.cbAbout.UseVisualStyleBackColor = True
        '
        'cbHotkeys
        '
        Me.cbHotkeys.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbHotkeys.AutoSize = True
        Me.cbHotkeys.Location = New System.Drawing.Point(514, 9)
        Me.cbHotkeys.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.cbHotkeys.Name = "cbHotkeys"
        Me.cbHotkeys.Size = New System.Drawing.Size(104, 17)
        Me.cbHotkeys.TabIndex = 11
        Me.cbHotkeys.Text = "Disable hotkeys"
        Me.cbHotkeys.UseVisualStyleBackColor = True
        '
        'cbStop
        '
        Me.cbStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbStop.Location = New System.Drawing.Point(3, 5)
        Me.cbStop.Name = "cbStop"
        Me.cbStop.Size = New System.Drawing.Size(285, 23)
        Me.cbStop.TabIndex = 8
        Me.cbStop.Text = "Stop all sounds"
        Me.cbStop.UseVisualStyleBackColor = True
        '
        'cbStartup
        '
        Me.cbStartup.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbStartup.AutoSize = True
        Me.cbStartup.Location = New System.Drawing.Point(294, 9)
        Me.cbStartup.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.cbStartup.Name = "cbStartup"
        Me.cbStartup.Size = New System.Drawing.Size(104, 17)
        Me.cbStartup.TabIndex = 9
        Me.cbStartup.Text = "Run at startup"
        Me.cbStartup.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(720, 240)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.nudButtons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanelMain.PerformLayout()
        Me.TableLayoutPanelHeader.ResumeLayout(False)
        Me.TableLayoutPanelHeader.PerformLayout()
        Me.TableLayoutPanelBottom.ResumeLayout(False)
        Me.TableLayoutPanelBottom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbPresets As ComboBox
    Friend WithEvents nudButtons As NumericUpDown
    Friend WithEvents cbAddPreset As Button
    Friend WithEvents cbRemove As Button
    Friend WithEvents FlowLayoutPanelMain As FlowLayoutPanel
    Friend WithEvents cbRename As Button
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanelHeader As TableLayoutPanel
    Friend WithEvents lbPreset As Label
    Friend WithEvents lbButtons As Label
    Friend WithEvents cbExport As Button
    Friend WithEvents cbImport As Button
    Friend WithEvents cbHotkeys As CheckBox
    Friend WithEvents TableLayoutPanelBottom As TableLayoutPanel
    Friend WithEvents cbAbout As Button
    Friend WithEvents cbStop As Button
    Friend WithEvents cbOverlap As CheckBox
    Friend WithEvents cbStartup As CheckBox
End Class
