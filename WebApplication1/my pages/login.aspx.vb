Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Call cn("select * from signup where EMAIL='" + TextBox1.Text + "' and PASS='" + TextBox2.Text + "'")
        dt = ds.Tables(0)

        If dt.Rows.Count Then
            ' Response.Redirect("~/my pages/WebForm2.aspx")
            Response.Redirect("WebForm2.aspx?Data=" & Server.UrlEncode(TextBox1.Text))

        Else
            Response.Write("<script language=javascript>alert('!! incorrect username/password !!')</script>")

        End If
        Dim a As Integer
        If (Page.IsValid) Then
            a = 1
        End If


    End Sub
End Class