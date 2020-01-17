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

Imports System.Xml.Serialization

<Serializable>
Public Class SoundBoard
    <XmlIgnore()>
    Public Property presetsDic As New Dictionary(Of String, Preset)
    Public Property presets As New List(Of Preset)
    Public Sub New()
    End Sub
End Class

<Serializable>
Public Class Preset
    Public Property name As String = String.Empty
    Public Property sounds As New List(Of Sound)
    Public Sub New()
    End Sub
End Class

<Serializable>
Public Class Sound
    Public Property volume As Integer = 100
    Public Property name As String = String.Empty
    Public Property path As String = String.Empty
    Public Property key As String = String.Empty
    Public Property count As Integer = 1
    Public Sub New()
    End Sub
End Class