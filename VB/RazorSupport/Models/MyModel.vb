Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace RazorSupport.Models
	Public Class MyModel
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateOrderDate As DateTime
		Public Property OrderDate() As DateTime
			Get
				Return privateOrderDate
			End Get
			Set(ByVal value As DateTime)
				privateOrderDate = value
			End Set
		End Property
	End Class
End Namespace