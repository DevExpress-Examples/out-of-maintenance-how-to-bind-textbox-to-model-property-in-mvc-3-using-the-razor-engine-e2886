Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports RazorSupport.Models
Imports DevExpress.Web.Mvc

Namespace RazorSupport.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			ViewBag.Message = "Fill the form:"

			Return TextBox()
		End Function
		Public Function TextBox() As ActionResult
			Return View("TextBox", New MyModel() With {.OrderDate = DateTime.Now, .Name = "Test"})
		End Function

		<HttpPost> _
		Public Function PostValues(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal model As MyModel) As ActionResult
			ViewBag.Message = String.Format("Values from {0} were posted", model.Name)
			Return View("TextBox", model)
		End Function
	End Class
End Namespace
