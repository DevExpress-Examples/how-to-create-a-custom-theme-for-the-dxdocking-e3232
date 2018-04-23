Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core

Namespace CustomDockingSLTheme
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			Dim theme As New Theme("CustomTheme") With {.IsStandard = False, .FullName = "Custom Theme for the DXDocking"}
			ThemeManager.ApplicationTheme = theme
			InitializeComponent()
		End Sub

	End Class


End Namespace
