Imports System.Web.Mvc

Namespace Controllers
    Public Class UserController
        Inherits Controller

        ' GET: User
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace