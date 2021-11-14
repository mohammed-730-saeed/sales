Imports System.Data.SqlClient
Module Connection_mod
    Public ConStr As String = "Data Source=(localdb)\ProjectsV13;Initial Catalog = MyNew_Sales_DB;integrated security=true"
    Public Con As New SqlClient.SqlConnection(ConStr)

End Module
