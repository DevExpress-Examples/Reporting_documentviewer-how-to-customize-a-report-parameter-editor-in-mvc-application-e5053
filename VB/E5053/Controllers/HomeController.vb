Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports E5053.Reports

Namespace E5053.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function DocumentViewerPartial() As ActionResult
			Dim report As New ProductsReport()
			Return PartialView("_DocumentViewerPartial", report)
		End Function

		Public Function DocumentViewerPartialExport() As ActionResult
			Dim report As New ProductsReport()
			Return DocumentViewerExtension.ExportTo(report)
		End Function
	End Class
End Namespace