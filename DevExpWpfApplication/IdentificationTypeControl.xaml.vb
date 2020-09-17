Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Windows

Public Class IdentificationTypeControl
    Public Sub New()
        Dim list = New BindingList(Of IdentityEntity)()
        InitializeComponent()


        For i As Integer = 0 To 4
            list.Add(New IdentityEntity() With {.IdentityType = "IdentityType " & i, .IdentityNumber = "IdentityNumber " & i})
        Next i
        gridControl1.ItemsSource = list
    End Sub
End Class

Public Class IdentityEntity
    Private mIdentityType As String
    Private mIdentityNumber As String
    Public Property IdentityType As String
        Get
            Return mIdentityType
        End Get
        Set(ByVal value As String)
            mIdentityType = value
        End Set
    End Property
    Public Property IdentityNumber As String
        Get
            Return mIdentityNumber
        End Get
        Set(ByVal value As String)
            mIdentityNumber = value
        End Set
    End Property

End Class

