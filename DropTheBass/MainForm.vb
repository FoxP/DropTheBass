'-----------------------------------------------------------------------------------------------------------------------------------------------
'
'	This program is free software; you can redistribute it and/or
'	modify it under the terms of the GNU General Public License
'	as published by the Free Software Foundation; either version 2
'	of the License, or (at your option) any later version.
'
'	This program is distributed in the hope that it will be useful,
'	but WITHOUT ANY WARRANTY; without even the implied warranty of
'	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'	GNU General Public License for more details.
'
'	You should have received a copy of the GNU General Public License
'	along with this program; if not, write to the Free Software Foundation,
'	Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.
'
'	Name :
'				DropTheBass
'	Author :
'				Paul RENARD
'
'-----------------------------------------------------------------------------------------------------------------------------------------------

Imports System.Configuration
Imports System.IO

Public Class MainForm

    Private WithEvents kbHook As New KeyboardHook

    Public sConfigFilePath As String
    Public dontRunHandler As Boolean

    'TODO :
    'adjust volume gain for each button
    'set custom name for buttons
    'add tooltips
    'add drag & drop between buttons
    'add drag & drop for files : on buttons + EditorForm
    'add "Stop all sounds" button
    'better sizing for MainForm
    'fix keyboardhook bug for hotkeys combo
    'create setup / installer
    'better README for git

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = My.Application.Info.AssemblyName & " v" & My.Application.Info.Version.ToString

        'Delete / check for corrupted "user.config" file
        Try
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
        Catch exception As ConfigurationErrorsException
            File.Delete(exception.Filename)
        End Try

        sConfigFilePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & Path.DirectorySeparatorChar & My.Application.Info.AssemblyName & Path.DirectorySeparatorChar & "config.xml"
        Call loadSettings(sConfigFilePath, True)

        If Not My.Settings.sPresetName = String.Empty Then
            cbPresets.Text = My.Settings.sPresetName
        End If
        If Not My.Settings.iHeight < Me.MinimumSize.Height Then
            Me.Height = My.Settings.iHeight
        End If
        If Not My.Settings.iWidth < Me.MinimumSize.Width Then
            Me.Width = My.Settings.iWidth
        End If
        cbHotkeys.Checked = My.Settings.bHotkeys

    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call saveSettings(sConfigFilePath)
        My.Settings.iHeight = Me.Height
        My.Settings.iWidth = Me.Width
        My.Settings.sPresetName = cbPresets.Text
        My.Settings.bHotkeys = cbHotkeys.Checked
    End Sub

    Private Sub nudButtons_ValueChanged(sender As Object, e As EventArgs) Handles nudButtons.ValueChanged
        If Not dontRunHandler Then
            If Not cbPresets.Text = String.Empty Then
                If config.presetsDic.ContainsKey(cbPresets.Text) Then
                    If config.presetsDic(cbPresets.Text).sounds.Count < nudButtons.Value Then
                        Debug.Print("+")
                        While nudButtons.Value <> config.presetsDic(cbPresets.Text).sounds.Count
                            Dim s As New Sound
                            s.name = (config.presetsDic(cbPresets.Text).sounds.Count + 1).ToString
                            config.presetsDic(cbPresets.Text).sounds.Add(s)
                        End While
                        Call updateButtonsList()
                    Else
                        Debug.Print("-")
                        While nudButtons.Value <> config.presetsDic(cbPresets.Text).sounds.Count
                            config.presetsDic(cbPresets.Text).sounds.RemoveAt(config.presetsDic(cbPresets.Text).sounds.Count - 1)
                        End While
                        Call updateButtonsList()
                    End If
                Else
                    nudButtons.ReadOnly = True
                    nudButtons.Increment = 0
                    nudButtons.ReadOnly = True
                    nudButtons.Increment = 0
                    MessageBox.Show("Oops, can't find preset : " & """" & cbPresets.Text & """" & ".", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                nudButtons.ReadOnly = True
                nudButtons.Increment = 0
                nudButtons.ReadOnly = True
                nudButtons.Increment = 0
                MessageBox.Show("Oops, no preset selected.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        Debug.Print(Key.ToString)
        If Not cbHotkeys.Checked Then
            If Not cbPresets.Text = String.Empty Then
                If config.presetsDic.ContainsKey(cbPresets.Text) Then
                    For Each s As Sound In config.presetsDic(cbPresets.Text).sounds
                        If s.key = Key.ToString Then
                            Call playSound(s.path)
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    'Private Sub kbHook_KeyUp(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyUp
    '    Debug.WriteLine(Key)
    'End Sub

    Private Sub cbPresets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPresets.SelectedIndexChanged
        Call updateButtonsList()
        Call updateButtonsCount()
    End Sub

    Private Sub cbAddPreset_Click(sender As Object, e As EventArgs) Handles cbAddPreset.Click
        Dim sPresetName As String = InputBox("Please input a name for your preset :", My.Application.Info.AssemblyName, String.Empty)
        If sPresetName.Trim <> String.Empty Then
            If Not config.presetsDic.ContainsKey(sPresetName) Then
                Dim p As New Preset
                p.name = sPresetName
                config.presetsDic.Add(sPresetName, p)
                Call updatePresetsList()
                cbPresets.Text = sPresetName
            Else
                MessageBox.Show("Oops, preset with same name already exists.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Oops, empty name.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbRemove_Click(sender As Object, e As EventArgs) Handles cbRemove.Click
        If Not cbPresets.Text = String.Empty Then
            If config.presetsDic.ContainsKey(cbPresets.Text) Then
                If MessageBox.Show("Do you really want to delete preset : " & """" & cbPresets.Text & """" & " ?", My.Application.Info.AssemblyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    config.presetsDic.Remove(cbPresets.Text)
                    Call updatePresetsList()
                End If
            Else
                MessageBox.Show("Oops, can't delete preset : " & """" & cbPresets.Text & """" & ".", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Oops, no preset selected.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbRename_Click(sender As Object, e As EventArgs) Handles cbRename.Click
        If Not cbPresets.Text = String.Empty Then
            If config.presetsDic.ContainsKey(cbPresets.Text) Then
                Dim sPresetName As String = InputBox("Please input a new name for selected preset :", My.Application.Info.AssemblyName, String.Empty)
                If sPresetName.Trim <> String.Empty Then
                    If Not config.presetsDic.ContainsKey(sPresetName) Then
                        config.presetsDic(cbPresets.Text).name = sPresetName
                        config.presetsDic.Add(sPresetName, config.presetsDic(cbPresets.Text))
                        config.presetsDic.Remove(cbPresets.Text)
                        Call updatePresetsList()
                        cbPresets.Text = sPresetName
                    Else
                        MessageBox.Show("Oops, preset with same name already exists.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Oops, empty name.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Oops, can't find preset : " & """" & cbPresets.Text & """" & ".", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Oops, no preset selected.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbImport_Click(sender As Object, e As EventArgs) Handles cbImport.Click
        If MessageBox.Show("Do you really want to import presets from a XML file ?" & vbNewLine & "WARNING : It will OVERWRITE all your existing presets. " & vbNewLine & "If you want to keep them, use the " & """" & "Export" & """" & " feature first.", My.Application.Info.AssemblyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sTempConfigFilePath As String = getFileFromDialog("Select a XML file", "XML files (*.xml)|*.xml")
            If sTempConfigFilePath.Trim <> String.Empty Then
                Call loadSettings(sTempConfigFilePath, False)
            End If
        End If
    End Sub

    Private Sub cbExport_Click(sender As Object, e As EventArgs) Handles cbExport.Click
        Dim sTempConfigFilePath As String = setFileFromDialog("Select a XML file", "XML files (*.xml)|*.xml", My.Application.Info.AssemblyName & "_" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"))
        If sTempConfigFilePath.Trim <> String.Empty Then
            Call saveSettings(sTempConfigFilePath)
        End If
    End Sub

    'Prevent mouse wheel from incrementing NumericUpDown control
    Private Sub nudButtons_MouseWheel(sender As Object, e As MouseEventArgs) Handles nudButtons.MouseWheel
        Dim MW As HandledMouseEventArgs = CType(e, HandledMouseEventArgs)
        MW.Handled = True
    End Sub

    Private Sub updatePresetsList()
        cbPresets.DataSource = Nothing
        cbPresets.DataSource = config.presetsDic.ToList()
        cbPresets.DisplayMember = "Key"
    End Sub

    Public Sub updateButtonsList()
        FlowLayoutPanelMain.Controls.Clear()
        If Not cbPresets.Text = String.Empty Then
            If config.presetsDic.ContainsKey(cbPresets.Text) Then
                For Each s As Sound In config.presetsDic(cbPresets.Text).sounds
                    Dim b As New Button
                    b.Name = s.name
                    If s.path.Trim <> String.Empty Then
                        b.Text = Path.GetFileNameWithoutExtension(s.path) & If(s.key.Trim <> String.Empty, vbNewLine & s.key, "")
                    Else
#If DEBUG Then
                    b.Text = s.name
#Else
                        b.Text = "(No sound file)"
#End If
                    End If
                    b.Height = 50
                    b.Width = 225
                    AddHandler b.MouseUp, AddressOf editButton
                    FlowLayoutPanelMain.Controls.Add(b)
                Next
            End If
        End If
    End Sub

    Private Sub updateButtonsCount()
        dontRunHandler = True
        If Not cbPresets.Text = String.Empty Then
            If config.presetsDic.ContainsKey(cbPresets.Text) Then
                nudButtons.Value = config.presetsDic(cbPresets.Text).sounds.Count
                nudButtons.Enabled = True
            End If
        Else
            nudButtons.Value = 0
            nudButtons.Enabled = False
        End If
        dontRunHandler = False
    End Sub

    Private Sub loadSettings(ByVal sConfigFilePath As String, ByVal bSilent As Boolean)
        If File.Exists(sConfigFilePath) Then
            Try
                Call XMLFileToObj(sConfigFilePath, config)
            Catch ex As Exception
                MessageBox.Show("Oops, can't load settings :" & vbNewLine & vbNewLine & ex.ToString, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            'Faster / easier to use a dictionary, but not serializable
            For Each p As Preset In config.presets
                If Not config.presetsDic.ContainsKey(p.name) Then
                    config.presetsDic.Add(p.name, p)
                End If
            Next
            Call updatePresetsList()
        Else
            If Not bSilent Then
                MessageBox.Show("Oops, can't access to :" & vbNewLine & vbNewLine & sConfigFilePath, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub saveSettings(ByVal sConfigFilePath As String)
        'Faster / easier to use a dictionary, but not serializable
        config.presets = config.presetsDic.Values.ToList
        Try
            Call ObjToXMLFile(config, sConfigFilePath)
        Catch ex As Exception
            MessageBox.Show("Oops, can't save settings :" & vbNewLine & vbNewLine & ex.ToString, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub editButton(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            EditorForm.Tag = sender
            EditorForm.ShowDialog()
        ElseIf e.Button = MouseButtons.Left Then
            If Not cbPresets.Text = String.Empty Then
                If config.presetsDic.ContainsKey(cbPresets.Text) Then
                    Dim s As Sound = config.presetsDic(cbPresets.Text).sounds.Item(sender.Name - 1)
                    Call playSound(s.path)
                End If
            Else
                MessageBox.Show("Oops, can't find preset : " & """" & cbPresets.Text & """" & ".", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Oops, no preset selected.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbAbout_Click(sender As Object, e As EventArgs) Handles cbAbout.Click
        ABOUT.ShowDialog()
    End Sub

End Class

