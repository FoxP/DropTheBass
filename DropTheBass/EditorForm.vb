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

Imports System.IO

Public Class EditorForm

    Private Sub EditorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Me.Tag Is Nothing Then
            Me.Text = "Settings for button " & Me.Tag.Name.ToString
            If Not MainForm.cbPresets.Text = String.Empty Then
                If config.presetsDic.ContainsKey(MainForm.cbPresets.Text) Then
                    Dim s As Sound = config.presetsDic(MainForm.cbPresets.Text).sounds.Item(Me.Tag.Name - 1)
                    If s.path.Trim <> String.Empty Then
                        tbSoundPath.Text = s.path
                    Else
                        tbSoundPath.Text = String.Empty
                    End If
                    If s.key.Trim <> String.Empty Then
                        lbHotkey.Text = s.key
                    Else
                        lbHotkey.Text = "None"
                    End If
                    TrackBarMain.Value = s.volume
                    lbVolume.Text = s.volume.ToString & "%"
                    If s.count = 0 Then
                        cbLoop.Checked = True
                        nudLoop.Enabled = False
                        nudLoop.Minimum = 0
                    Else
                        cbLoop.Checked = False
                        nudLoop.Enabled = True
                        nudLoop.Minimum = 1
                    End If
                    nudLoop.Value = s.count
                Else
                    MessageBox.Show("Oops, can't find preset : " & """" & MainForm.cbPresets.Text & """" & ".", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Oops, no preset selected.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Oops, no button selected.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbGetSoundPath_Click(sender As Object, e As EventArgs) Handles cbGetSoundPath.Click
        tbSoundPath.Text = getFileFromDialog()
    End Sub

    Private Sub button_DragDrop(sender As Object, e As DragEventArgs) Handles cbGetSoundPath.DragDrop, tbSoundPath.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        If Not files.Count = 0 Then
            If Not files.Count > 1 Then
                Dim sFilePath As String = files(0)
                If File.Exists(sFilePath) Then
                    tbSoundPath.Text = sFilePath
                Else
                    MessageBox.Show("Oops, invalid file path :" & vbNewLine & vbNewLine & sFilePath, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Oops, can't add more than one sound for a button.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            'Oops
        End If
    End Sub

    Private Sub button_DragEnter(sender As Object, e As DragEventArgs) Handles cbGetSoundPath.DragEnter, tbSoundPath.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub tbHotkey_KeyDown(sender As Object, e As KeyEventArgs) Handles tbHotkey.KeyDown
        e.SuppressKeyPress = True
        lbHotkey.Text = e.KeyData.ToString
        'Dim Key As Keys
        '[Enum].TryParse(e.KeyCode, Key)
        'lb.Text = lb.Text & ";" & Key.ToString
    End Sub

    Private Sub cbOK_Click(sender As Object, e As EventArgs) Handles cbOK.Click
        If Not Me.Tag Is Nothing Then
            If Not MainForm.cbPresets.Text = String.Empty Then
                If config.presetsDic.ContainsKey(MainForm.cbPresets.Text) Then
                    Dim s As Sound = config.presetsDic(MainForm.cbPresets.Text).sounds.Item(Me.Tag.Name - 1)
                    s.path = tbSoundPath.Text
                    If lbHotkey.Text = "None" Then
                        s.key = String.Empty
                    Else
                        s.key = lbHotkey.Text
                    End If
                    s.volume = TrackBarMain.Value
                    s.count = nudLoop.Value
                    Me.Tag = Nothing
                    Me.Close()
                    Call MainForm.updateButtonsList()
                Else
                    MessageBox.Show("Oops, can't find preset : " & """" & MainForm.cbPresets.Text & """" & ".", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Oops, no preset selected.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Oops, no button selected.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbCancel_Click(sender As Object, e As EventArgs) Handles cbCancel.Click
        Me.Close()
        Me.Tag = Nothing
    End Sub

    Private Sub cbPlaySound_Click(sender As Object, e As EventArgs) Handles cbPlaySound.Click
        Dim s As New Sound
        s.path = tbSoundPath.Text
        s.volume = TrackBarMain.Value
        If Not MainForm.cbOverlap.Checked Then
            Call stopSound()
        End If
        Call playSound(s)
    End Sub

    Private Sub EditorForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tbSoundPath.Select()
        tbSoundPath.SelectionStart = tbSoundPath.Text.Length
        tbSoundPath.DeselectAll()
    End Sub

    Private Sub TrackBarMain_ValueChanged(sender As Object, e As EventArgs) Handles TrackBarMain.ValueChanged
        lbVolume.Text = TrackBarMain.Value.ToString & "%"
    End Sub

    Private Sub cbDelete_Click(sender As Object, e As EventArgs) Handles cbDelete.Click
        lbHotkey.Text = "None"
    End Sub

    Private Sub cbLoop_CheckedChanged(sender As Object, e As EventArgs) Handles cbLoop.CheckedChanged
        If cbLoop.Checked Then
            nudLoop.Enabled = False
            nudLoop.Minimum = 0
            nudLoop.Value = 0
        Else
            nudLoop.Enabled = True
            nudLoop.Minimum = 1
            nudLoop.Value = 1
        End If
    End Sub

End Class