Public Class contact
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = "provider=MSDAORA.1;Password=tiger; User ID=scott;persist security info=true"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "insert into feedback  values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        Response.Write("<script language=javascript>alert('!! Thanks for Ur Valuable Feedback !!')</script>")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class