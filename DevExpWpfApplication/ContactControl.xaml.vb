Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Windows

Public Class ContactControl
    Private list As BindingList(Of ContactEntity)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        list = New BindingList(Of ContactEntity)
        For i As Integer = 0 To 3
            list.Add(New ContactEntity() With {.ContactType = "ContactType" & i, .ContactInformation = "ContactInformation " & i, .EffectiveDate = "EffectiveDate " & i, .Preferred = "preffered " & i})
        Next i
        ContactGridControl.ItemsSource = list
    End Sub

    Private Sub addNewRowButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim newRowWindow As New CreateNewRowWindow()
        newRowWindow.ShowDialog()
        If newRowWindow.DialogResult.Value = True Then
            Dim newRow As New ContactEntity() With
                {.ContactType = newRowWindow.ContactType.Text, .ContactInformation = newRowWindow.ContactInformation.Text, .EffectiveDate = newRowWindow.EffectiveDate.Text, .Preferred = newRowWindow.Preferred.Text}

            list.Add(newRow)

            TableView1.MoveFocusedRow(ContactGridControl.GetRowVisibleIndexByHandle(ContactGridControl.GetRowHandleByVisibleIndex(list.Count - 1)))

            ContactGridControl.Focus()
        End If
    End Sub
End Class

Public Class ContactEntity
    Private mContactType As String
    Public Property ContactType() As String
        Get
            Return mContactType
        End Get
        Set(ByVal value As String)
            mContactType = value
        End Set
    End Property
    Private mContactInformation As String
    Public Property ContactInformation() As String
        Get
            Return mContactInformation
        End Get
        Set(ByVal value As String)
            mContactInformation = value
        End Set
    End Property
    Private mPreferred As String
    Public Property Preferred() As String
        Get
            Return mPreferred
        End Get
        Set(ByVal value As String)
            mPreferred = value
        End Set
    End Property
    Private mEffectiveDate As String
    Public Property EffectiveDate() As String
        Get
            Return mPreferred
        End Get
        Set(ByVal value As String)
            mPreferred = value
        End Set
    End Property
End Class
