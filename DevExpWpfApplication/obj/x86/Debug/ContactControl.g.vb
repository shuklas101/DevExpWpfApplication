﻿#ExternalChecksum("..\..\..\ContactControl.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","9AAE0596CAC0CC07197CF3226EEA0DC8")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.235
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Grid.LookUp
Imports DevExpress.Xpf.Grid.TreeList
Imports DevExpress.Xpf.LayoutControl
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''ContactControl
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated(),  _
 System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
Partial Public Class ContactControl
    Inherits System.Windows.Controls.UserControl
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\ContactControl.xaml",11)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ContactLayoutControl As DevExpress.Xpf.LayoutControl.LayoutControl
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\ContactControl.xaml",12)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ContactLayoutGroup As DevExpress.Xpf.LayoutControl.LayoutGroup
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\ContactControl.xaml",13)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ContactGridControl As DevExpress.Xpf.Grid.GridControl
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\ContactControl.xaml",15)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TableView1 As DevExpress.Xpf.Grid.TableView
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\ContactControl.xaml",19)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents addNewRowButton As System.Windows.Controls.Button
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/DevExpWpfApplication;component/contactcontrol.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\ContactControl.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.ContactLayoutControl = CType(target,DevExpress.Xpf.LayoutControl.LayoutControl)
            Return
        End If
        If (connectionId = 2) Then
            Me.ContactLayoutGroup = CType(target,DevExpress.Xpf.LayoutControl.LayoutGroup)
            Return
        End If
        If (connectionId = 3) Then
            Me.ContactGridControl = CType(target,DevExpress.Xpf.Grid.GridControl)
            Return
        End If
        If (connectionId = 4) Then
            Me.TableView1 = CType(target,DevExpress.Xpf.Grid.TableView)
            Return
        End If
        If (connectionId = 5) Then
            Me.addNewRowButton = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\ContactControl.xaml",19)
            AddHandler Me.addNewRowButton.Click, New System.Windows.RoutedEventHandler(AddressOf Me.addNewRowButton_Click)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

