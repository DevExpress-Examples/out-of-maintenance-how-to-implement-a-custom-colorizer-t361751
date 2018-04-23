#Region "#CustomColorizerImplementation"
Imports DevExpress.TreeMap
Imports DevExpress.XtraTreeMap
Imports System
Imports System.Drawing

Namespace CustomColorizerSample
    Friend Class CustomColorizer
        Implements ITreeMapColorizer


        Private palette_Renamed As Palette = Palette.Office2016Palette

        Public Property Palette() As Palette
            Get
                Return palette_Renamed
            End Get
            Set(ByVal value As Palette)
                If palette_Renamed.Equals(value) Then
                    Return
                End If
                palette_Renamed = value
                RaiseColorizerChanged()
            End Set
        End Property

        Public Event ColorizerChanged As ColorizerChangedEventHandler Implements ITreeMapColorizer.ColorizerChanged

        Public Function GetItemColor(ByVal item As ITreeMapItem, ByVal group As TreeMapItemGroupInfo) As Color Implements ITreeMapColorizer.GetItemColor
            If item.Children.Count = 0 Then
                Dim itemColor As Color = Palette(group.ItemIndex Mod Palette.Count)
                Dim itemWeight As Double = (item.Value - group.MinValue) / (group.MaxValue - group.MinValue)
                If Double.IsNaN(itemWeight) Then
                    itemWeight = 1
                End If

                Return Color.FromArgb(CInt((itemWeight * 255)), itemColor.R, itemColor.G, itemColor.B)
            Else
                Return Palette(Palette.Count - 1 - (group.GroupIndex + group.GroupLevel + group.ItemIndex) Mod Palette.Count)
            End If

        End Function

        Private Sub RaiseColorizerChanged()
            If ColorizerChangedEvent Is Nothing Then
                Return
            End If
            ColorizerChangedEvent.Invoke(Me, New ColorizerChangedEventArgs())
        End Sub
    End Class
End Namespace
#End Region ' #CustomColorizerImplementation