
Imports System.Data.OleDb

Public Class shipping
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Data As String = Request.QueryString("Data")
        TextBox3.Text = Data
        Dim con As New OleDbConnection("Provider=MSDAORA.1;user id=scott;password=tiger") 'micrpsoft.ace.oledb.12.Public qry As String = "select * from student"
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New System.Data.DataTable
        Dim qry As String = "select address from signup where email='" + Data + "' "
        da = New OleDbDataAdapter(qry, con)
        con.Open()
        da.Fill(ds)
        con.Close()
        dt = ds.Tables(0)
        TextBox5.Text = ds.Tables(0).Rows(0).Item(0)

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = "provider=MSDAORA.1;Password=tiger; User ID=scott;persist security info=true"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "insert into shipping  values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & DropDownList1.SelectedItem.Value & "','" & DropDownList2.SelectedItem.Value & "','" & TextBox6.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        Response.Write("<script language=javascript>alert('!! Your Product Successfully Ordered !! Product Is  Deliver in 4 to 5 Business Days !!');window.location='homepage.aspx'</script>")

    End Sub
End Class