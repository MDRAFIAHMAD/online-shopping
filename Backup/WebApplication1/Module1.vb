Imports System.Data.OleDb 'it will require
Imports System.Data 'it will require
Imports System.Web.UI.WebControls.ListItem
Imports System.Object
Module Module1
    Public con As New OleDbConnection("Provider=MSDAORA.1;user id=scott;password=tiger") 'micrpsoft.ace.oledb.12.Public qry As String = "select * from student"
    Public da As OleDbDataAdapter
    Public ds As New DataSet
    Public dt As New System.Data.DataTable
    Public Sub cn(ByVal sqlval As String)
        Dim qry As String = sqlval
        ds.Clear()
        da = New OleDbDataAdapter(qry, con)
        con.Open()
        da.Fill(ds)
        con.Close()
    End Sub
    Public Function exeqry(ByVal sqlval As String) As Integer
        Dim qry As String = sqlval
        Dim mycommand As New OleDbCommand(qry, con)
        con.Open()
        Dim k As Integer = mycommand.ExecuteNonQuery
        con.Close()
        Return k
    End Function
    Public Sub conclose()
        con.Close()
    End Sub
End Module
