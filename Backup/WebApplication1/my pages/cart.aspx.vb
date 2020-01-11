Imports System.Data.OleDb

Public Class test
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim data As String = Request.QueryString("Data")
        Label1.Text = data
        Dim con As New OleDbConnection("Provider=MSDAORA.1;user id=scott;password=tiger") 'micrpsoft.ace.oledb.12.Public qry As String = "select * from student"
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New System.Data.DataTable
        Dim qry As String = "select price,mobimg,specification from mobile where mobid='" + data + "' "
            da = New OleDbDataAdapter(qry, con)
            con.Open()
            da.Fill(ds)
            con.Close()
            dt = ds.Tables(0)
        Label2.Text = ds.Tables(0).Rows(0).Item(0)
            ImageButton1.ImageUrl = ds.Tables(0).Rows(0).Item(1)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(2)


    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = "provider=MSDAORA.1;Password=tiger; User ID=scott;persist security info=true"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "insert into cart values('" & Label1.Text & "','" & DropDownList1.SelectedItem.Value & "','" & Label2.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        Response.Write("<script language=javascript>alert('!! PRODUCT IS SUCCESSFULLY ADDET TO CART !!')</script>")
    End Sub
End Class