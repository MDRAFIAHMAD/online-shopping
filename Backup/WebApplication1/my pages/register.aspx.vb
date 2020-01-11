Public Class register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        

    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = "provider=MSDAORA.1;Password=tiger; User ID=scott;persist security info=true"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "insert into signup values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + RadioButtonList1.SelectedItem.Value + "','" + DropDownList1.SelectedItem.Value + "')"
        cmd.ExecuteNonQuery()
        con.Close()
        Response.Write("<script language=javascript>alert('!! Register Successfully !!')</script>")
        conclose()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
    End Sub
End Class