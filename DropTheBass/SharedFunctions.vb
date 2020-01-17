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
Imports System.Threading

Module SharedFunctions

    Sub ObjToXMLFile(ByVal obj As Object, ByVal path As String)
        Dim XWS As New System.Xml.XmlWriterSettings
        XWS.Indent = True
        XWS.IndentChars = vbTab
        Using XW As System.Xml.XmlWriter = System.Xml.XmlWriter.Create(path, XWS)
            Dim X As New System.Xml.Serialization.XmlSerializer(obj.GetType)
            X.Serialize(XW, obj)
        End Using
    End Sub

    Sub XMLFileToObj(ByVal path As String, ByRef obj As Object)
        Dim XRS As New System.Xml.XmlReaderSettings
        Using SR As System.Xml.XmlReader = System.Xml.XmlReader.Create(path, XRS)
            Dim X As New System.Xml.Serialization.XmlSerializer(obj.GetType)
            obj = X.Deserialize(SR)
        End Using
    End Sub

    Function getFileFromDialog(Optional ByVal sDialogTitle As String = "Select a file",
     Optional ByVal sExtensionFilters As String = "All files (*.*)|*.*|All files (*.*)|*.*",
     Optional ByVal bRestoreDirectory As Boolean = True
    ) As String
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = sDialogTitle
        fd.Filter = sExtensionFilters
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Return fd.FileName
        Else
            Return String.Empty
        End If
    End Function

    Function setFileFromDialog(Optional ByVal sDialogTitle As String = "Create a file",
                           Optional ByVal sExtensionFilters As String = "All files (*.*)|*.*|All files (*.*)|*.*",
                           Optional ByVal sFileName As String = "",
                           Optional ByVal bRestoreDirectory As Boolean = True
                          ) As String
        Dim fd As SaveFileDialog = New SaveFileDialog()

        fd.Title = sDialogTitle
        fd.Filter = sExtensionFilters
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        fd.FileName = sFileName

        If fd.ShowDialog() = DialogResult.OK Then
            Return fd.FileName
        Else
            Return String.Empty
        End If
    End Function

    Sub RunCmdCommand(ByVal exe As String, Optional ByVal args As String = "", Optional ByVal isVisible As Boolean = True, Optional ByVal workingDirectoryPath As String = "", Optional ByVal environmentVar As Dictionary(Of String, String) = Nothing)
        Dim p = New Process()
        If Not isVisible Then
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            p.StartInfo.CreateNoWindow = True
        End If
        p.StartInfo.FileName = exe
        If Not args = String.Empty Then
            p.StartInfo.Arguments = args
        End If
        p.StartInfo.UseShellExecute = False
        If Not environmentVar Is Nothing Then
            For Each k As String In environmentVar.Keys
                p.StartInfo.EnvironmentVariables(k) = environmentVar(k)
            Next
        End If
        If Not workingDirectoryPath = String.Empty Then
            p.StartInfo.WorkingDirectory = workingDirectoryPath
        End If
        p.Start()
        p.PriorityClass = ProcessPriorityClass.RealTime
    End Sub

    Public Sub playSound(ByVal s As Sound)
        Dim t As New Thread(Sub()
                                If Not s.path.Trim = String.Empty Then
                                    If File.Exists(s.path) Then
                                        Dim sFFplayPath As String = Path.Combine(My.Application.Info.DirectoryPath, "ffmpeg") & Path.DirectorySeparatorChar & "ffplay_DTB.exe"
                                        If File.Exists(sFFplayPath) Then
                                            Dim environmentVar As New Dictionary(Of String, String)
                                            environmentVar.Add("SDL_AUDIODRIVER", "directsound")
                                            Call RunCmdCommand(sFFplayPath, "-nodisp -hide_banner -nostats -loglevel panic -autoexit -loop " & s.count & " -volume " & s.volume.ToString & " " & Convert.ToChar(34) & s.path & Convert.ToChar(34), False, Path.Combine(My.Application.Info.DirectoryPath, "ffmpeg"), environmentVar)
                                        Else
                                            MessageBox.Show("Oops, can't find FFplay :" & vbNewLine & vbNewLine & sFFplayPath, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        End If
                                    Else
                                        MessageBox.Show("Oops, can't access to :" & vbNewLine & vbNewLine & s.path, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                Else
                                    MessageBox.Show("Oops, empty sound path.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End Sub)
        t.Priority = ThreadPriority.Highest
        t.Start()
    End Sub

    Public Sub stopSound()
        'Ugly
        For Each p As Process In Process.GetProcessesByName("ffplay_DTB")
            Try
                p.Kill()
                p.WaitForExit()
            Catch ex As Exception
                'Oops
            End Try
        Next
    End Sub

End Module
