Imports System.Data.OleDb
Imports System.Data
Imports System.Web.UI.WebControls.ListItem
Imports System.Object

Public Class mobile
    Inherits System.Web.UI.Page




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim con As New OleDbConnection("Provider=MSDAORA.1;user id=scott;password=tiger") 'micrpsoft.ace.oledb.12.Public qry As String = "select * from student"
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New System.Data.DataTable
        Dim qry As String = "select * from mobile"
        da = New OleDbDataAdapter(qry, con)
        con.Open()
        da.Fill(ds)
        con.Close()
        dt = ds.Tables(0)
        Label1.Text = dt.Rows(0).Item(0)
        ImageButton1.ImageUrl = dt.Rows(0).Item(1)
        Label2.Text = dt.Rows(1).Item(0)
        ImageButton2.ImageUrl = dt.Rows(1).Item(1)
        Label3.Text = dt.Rows(2).Item(0)
        ImageButton3.ImageUrl = dt.Rows(2).Item(1)
        Label4.Text = dt.Rows(3).Item(0)
        ImageButton4.ImageUrl = dt.Rows(3).Item(1)
        Label5.Text = dt.Rows(4).Item(0)
        ImageButton5.ImageUrl = dt.Rows(4).Item(1)
        Label6.Text = dt.Rows(5).Item(0)
        ImageButton6.ImageUrl = dt.Rows(5).Item(1)
        Label7.Text = dt.Rows(6).Item(0)
        ImageButton7.ImageUrl = dt.Rows(6).Item(1)
        Label8.Text = dt.Rows(7).Item(0)
        ImageButton8.ImageUrl = dt.Rows(7).Item(1)
        Label9.Text = dt.Rows(8).Item(0)
        ImageButton9.ImageUrl = dt.Rows(8).Item(1)
        Label10.Text = dt.Rows(9).Item(0)
        ImageButton10.ImageUrl = dt.Rows(9).Item(1)
        Label11.Text = dt.Rows(10).Item(0)
        ImageButton11.ImageUrl = dt.Rows(10).Item(1)
        Label12.Text = dt.Rows(11).Item(0)
        ImageButton12.ImageUrl = dt.Rows(11).Item(1)
        Label13.Text = dt.Rows(12).Item(0)
        ImageButton13.ImageUrl = dt.Rows(12).Item(1)
        Label14.Text = dt.Rows(13).Item(0)
        ImageButton14.ImageUrl = dt.Rows(13).Item(1)
        Label15.Text = dt.Rows(14).Item(0)
        ImageButton15.ImageUrl = dt.Rows(14).Item(1)
        Label16.Text = dt.Rows(15).Item(0)
        ImageButton16.ImageUrl = dt.Rows(15).Item(1)
        Label17.Text = dt.Rows(16).Item(0)
        ImageButton17.ImageUrl = dt.Rows(16).Item(1)
        Label18.Text = dt.Rows(17).Item(0)
        ImageButton18.ImageUrl = dt.Rows(17).Item(1)
        Label19.Text = dt.Rows(18).Item(0)
        ImageButton19.ImageUrl = dt.Rows(18).Item(1)
        Label20.Text = dt.Rows(19).Item(0)
        ImageButton20.ImageUrl = dt.Rows(19).Item(1)
    End Sub

    Protected Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        If RadioButtonList1.SelectedIndex = 0 Then
            Dim con As New OleDbConnection("Provider=MSDAORA.1;user id=scott;password=tiger") 'micrpsoft.ace.oledb.12.Public qry As String = "select * from student"
            Dim da As OleDbDataAdapter
            Dim ds As New DataSet
            Dim dt As New System.Data.DataTable
            Dim qry As String = "select * from mobile order by price desc"
            da = New OleDbDataAdapter(qry, con)
            con.Open()
            da.Fill(ds)
            con.Close()
            dt = ds.Tables(0)
            'Call cn("select * from mobile order by price desc")
            'dt = ds.Tables(0)
            Label1.Text = dt.Rows(0).Item(0)
            ImageButton1.ImageUrl = dt.Rows(0).Item(1)
            Label2.Text = dt.Rows(1).Item(0)
            ImageButton2.ImageUrl = dt.Rows(1).Item(1)
            Label3.Text = dt.Rows(2).Item(0)
            ImageButton3.ImageUrl = dt.Rows(2).Item(1)
            Label4.Text = dt.Rows(3).Item(0)
            ImageButton4.ImageUrl = dt.Rows(3).Item(1)
            Label5.Text = dt.Rows(4).Item(0)
            ImageButton5.ImageUrl = dt.Rows(4).Item(1)
            Label6.Text = dt.Rows(5).Item(0)
            ImageButton6.ImageUrl = dt.Rows(5).Item(1)
            Label7.Text = dt.Rows(6).Item(0)
            ImageButton7.ImageUrl = dt.Rows(6).Item(1)
            Label8.Text = dt.Rows(7).Item(0)
            ImageButton8.ImageUrl = dt.Rows(7).Item(1)
            Label9.Text = dt.Rows(8).Item(0)
            ImageButton9.ImageUrl = dt.Rows(8).Item(1)
            Label10.Text = dt.Rows(9).Item(0)
            ImageButton10.ImageUrl = dt.Rows(9).Item(1)
            Label11.Text = dt.Rows(10).Item(0)
            ImageButton11.ImageUrl = dt.Rows(10).Item(1)
            Label12.Text = dt.Rows(11).Item(0)
            ImageButton12.ImageUrl = dt.Rows(11).Item(1)
            Label13.Text = dt.Rows(12).Item(0)
            ImageButton13.ImageUrl = dt.Rows(12).Item(1)
            Label14.Text = dt.Rows(13).Item(0)
            ImageButton14.ImageUrl = dt.Rows(13).Item(1)
            Label15.Text = dt.Rows(14).Item(0)
            ImageButton15.ImageUrl = dt.Rows(14).Item(1)
            Label16.Text = dt.Rows(15).Item(0)
            ImageButton16.ImageUrl = dt.Rows(15).Item(1)
            Label17.Text = dt.Rows(16).Item(0)
            ImageButton17.ImageUrl = dt.Rows(16).Item(1)
            Label18.Text = dt.Rows(17).Item(0)
            ImageButton18.ImageUrl = dt.Rows(17).Item(1)
            Label19.Text = dt.Rows(18).Item(0)
            ImageButton19.ImageUrl = dt.Rows(18).Item(1)
            Label20.Text = dt.Rows(19).Item(0)
            ImageButton20.ImageUrl = dt.Rows(19).Item(1)
        ElseIf RadioButtonList1.SelectedIndex = 1 Then

            Dim con As New OleDbConnection("Provider=MSDAORA.1;user id=scott;password=tiger") 'micrpsoft.ace.oledb.12.Public qry As String = "select * from student"
            Dim da As OleDbDataAdapter
            Dim ds As New DataSet
            Dim dt As New System.Data.DataTable
            Dim qry As String = "select * from mobile order by price asc"
            da = New OleDbDataAdapter(qry, con)
            con.Open()
            da.Fill(ds)
            con.Close()
            dt = ds.Tables(0)
            Label1.Text = dt.Rows(0).Item(0)
            ImageButton1.ImageUrl = dt.Rows(0).Item(1)
            Label2.Text = dt.Rows(1).Item(0)
            ImageButton2.ImageUrl = dt.Rows(1).Item(1)
            Label3.Text = dt.Rows(2).Item(0)
            ImageButton3.ImageUrl = dt.Rows(2).Item(1)
            Label4.Text = dt.Rows(3).Item(0)
            ImageButton4.ImageUrl = dt.Rows(3).Item(1)
            Label5.Text = dt.Rows(4).Item(0)
            ImageButton5.ImageUrl = dt.Rows(4).Item(1)
            Label6.Text = dt.Rows(5).Item(0)
            ImageButton6.ImageUrl = dt.Rows(5).Item(1)
            Label7.Text = dt.Rows(6).Item(0)
            ImageButton7.ImageUrl = dt.Rows(6).Item(1)
            Label8.Text = dt.Rows(7).Item(0)
            ImageButton8.ImageUrl = dt.Rows(7).Item(1)
            Label9.Text = dt.Rows(8).Item(0)
            ImageButton9.ImageUrl = dt.Rows(8).Item(1)
            Label10.Text = dt.Rows(9).Item(0)
            ImageButton10.ImageUrl = dt.Rows(9).Item(1)
            Label11.Text = dt.Rows(10).Item(0)
            ImageButton11.ImageUrl = dt.Rows(10).Item(1)
            Label12.Text = dt.Rows(11).Item(0)
            ImageButton12.ImageUrl = dt.Rows(11).Item(1)
            Label13.Text = dt.Rows(12).Item(0)
            ImageButton13.ImageUrl = dt.Rows(12).Item(1)
            Label14.Text = dt.Rows(13).Item(0)
            ImageButton14.ImageUrl = dt.Rows(13).Item(1)
            Label15.Text = dt.Rows(14).Item(0)
            ImageButton15.ImageUrl = dt.Rows(14).Item(1)
            Label16.Text = dt.Rows(15).Item(0)
            ImageButton16.ImageUrl = dt.Rows(15).Item(1)
            Label17.Text = dt.Rows(16).Item(0)
            ImageButton17.ImageUrl = dt.Rows(16).Item(1)
            Label18.Text = dt.Rows(17).Item(0)
            ImageButton18.ImageUrl = dt.Rows(17).Item(1)
            Label19.Text = dt.Rows(18).Item(0)
            ImageButton19.ImageUrl = dt.Rows(18).Item(1)
            Label20.Text = dt.Rows(19).Item(0)
            ImageButton20.ImageUrl = dt.Rows(19).Item(1)
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label13.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label19.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label1.Text))

        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label10.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label20.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label2.Text))

        End If
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label16.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label4.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label3.Text))

        End If
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label6.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label1.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label4.Text))

        End If
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label11.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label17.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label5.Text))

        End If
    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label9.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label7.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label6.Text))

        End If
    End Sub

    Protected Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label2.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label3.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label7.Text))

        End If
    End Sub

    Protected Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label15.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label18.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label8.Text))

        End If
    End Sub

    Protected Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label12.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label5.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label9.Text))

        End If
    End Sub

    Protected Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label14.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label8.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label10.Text))

        End If
    End Sub

    Protected Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button11.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label8.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label14.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label11.Text))

        End If
    End Sub

    Protected Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button12.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label10.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label12.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label12.Text))

        End If
    End Sub

    Protected Sub Button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button13.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label18.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label2.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label13.Text))

        End If
    End Sub

    Protected Sub Button14_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button14.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label3.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label15.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label14.Text))

        End If
    End Sub

    Protected Sub Button15_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button15.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label7.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label9.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label15.Text))

        End If
    End Sub

    Protected Sub Button16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button16.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label17.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label11.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label16.Text))

        End If
    End Sub

    Protected Sub Button17_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button17.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label4.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label6.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label17.Text))

        End If
    End Sub

    Protected Sub Button18_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button18.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label1.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label16.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label18.Text))

        End If
    End Sub

    Protected Sub Button19_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button19.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label20.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label10.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label19.Text))

        End If
    End Sub

    Protected Sub Button20_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button20.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label19.Text))
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label13.Text))
        Else
            Response.Redirect("cart.aspx?Data=" & Server.UrlEncode(Label20.Text))

        End If
    End Sub
End Class


