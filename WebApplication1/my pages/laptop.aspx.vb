Imports System.Data.OleDb 'it will require
Imports System.Data 'it will require
Imports System.Web.UI.WebControls.ListItem
Imports System.Object
Public Class laptop
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim con As New OleDbConnection("Provider=MSDAORA.1;user id=scott;password=tiger") 'micrpsoft.ace.oledb.12.Public qry As String = "select * from student"
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New System.Data.DataTable
        Dim qry As String = "select * from laptop"
        da = New OleDbDataAdapter(qry, con)
        con.Open()
        da.Fill(ds)
        con.Close()
        dt = ds.Tables(0)
        Label21.Text = dt.Rows(0).Item(0)
        ImageButton21.ImageUrl = dt.Rows(0).Item(1)
        Label22.Text = dt.Rows(1).Item(0)
        ImageButton22.ImageUrl = dt.Rows(1).Item(1)
        Label23.Text = dt.Rows(2).Item(0)
        ImageButton23.ImageUrl = dt.Rows(2).Item(1)
        Label24.Text = dt.Rows(3).Item(0)
        ImageButton24.ImageUrl = dt.Rows(3).Item(1)
        Label25.Text = dt.Rows(4).Item(0)
        ImageButton25.ImageUrl = dt.Rows(4).Item(1)
        Label26.Text = dt.Rows(5).Item(0)
        ImageButton26.ImageUrl = dt.Rows(5).Item(1)
        Label27.Text = dt.Rows(6).Item(0)
        ImageButton27.ImageUrl = dt.Rows(6).Item(1)
        Label28.Text = dt.Rows(7).Item(0)
        ImageButton28.ImageUrl = dt.Rows(7).Item(1)
        Label29.Text = dt.Rows(8).Item(0)
        ImageButton29.ImageUrl = dt.Rows(8).Item(1)
        Label30.Text = dt.Rows(9).Item(0)
        ImageButton30.ImageUrl = dt.Rows(9).Item(1)
        Label31.Text = dt.Rows(10).Item(0)
        ImageButton31.ImageUrl = dt.Rows(10).Item(1)
        Label32.Text = dt.Rows(11).Item(0)
        ImageButton32.ImageUrl = dt.Rows(11).Item(1)
        Label33.Text = dt.Rows(12).Item(0)
        ImageButton33.ImageUrl = dt.Rows(12).Item(1)
        Label34.Text = dt.Rows(13).Item(0)
        ImageButton34.ImageUrl = dt.Rows(13).Item(1)
        Label35.Text = dt.Rows(14).Item(0)
        ImageButton35.ImageUrl = dt.Rows(14).Item(1)
        Label36.Text = dt.Rows(15).Item(0)
        ImageButton36.ImageUrl = dt.Rows(15).Item(1)
        Label37.Text = dt.Rows(16).Item(0)
        ImageButton37.ImageUrl = dt.Rows(16).Item(1)
        Label38.Text = dt.Rows(17).Item(0)
        ImageButton38.ImageUrl = dt.Rows(17).Item(1)
        Label39.Text = dt.Rows(18).Item(0)
        ImageButton39.ImageUrl = dt.Rows(18).Item(1)
        Label40.Text = dt.Rows(19).Item(0)
        ImageButton40.ImageUrl = dt.Rows(19).Item(1)




    End Sub

    Protected Sub RadioButtonList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList2.SelectedIndexChanged
        If RadioButtonList2.SelectedIndex = 0 Then
            Dim con As New OleDbConnection("Provider=MSDAORA.1;user id=scott;password=tiger")
            Dim da As OleDbDataAdapter
            Dim ds As New DataSet
            Dim dt As New System.Data.DataTable
            Dim qry As String = "select * from laptop order by price desc"
            da = New OleDbDataAdapter(qry, con)
            con.Open()
            da.Fill(ds)
            con.Close()
            dt = ds.Tables(0)
            'Call cn("select * from laptop order by price desc")
            'dt = ds.Tables(0)
            Label21.Text = dt.Rows(0).Item(0)
            ImageButton21.ImageUrl = dt.Rows(0).Item(1)
            Label22.Text = dt.Rows(1).Item(0)
            ImageButton22.ImageUrl = dt.Rows(1).Item(1)
            Label23.Text = dt.Rows(2).Item(0)
            ImageButton23.ImageUrl = dt.Rows(2).Item(1)
            Label24.Text = dt.Rows(3).Item(0)
            ImageButton24.ImageUrl = dt.Rows(3).Item(1)
            Label25.Text = dt.Rows(4).Item(0)
            ImageButton25.ImageUrl = dt.Rows(4).Item(1)
            Label26.Text = dt.Rows(5).Item(0)
            ImageButton26.ImageUrl = dt.Rows(5).Item(1)
            Label27.Text = dt.Rows(6).Item(0)
            ImageButton27.ImageUrl = dt.Rows(6).Item(1)
            Label28.Text = dt.Rows(7).Item(0)
            ImageButton28.ImageUrl = dt.Rows(7).Item(1)
            Label29.Text = dt.Rows(8).Item(0)
            ImageButton29.ImageUrl = dt.Rows(8).Item(1)
            Label30.Text = dt.Rows(9).Item(0)
            ImageButton30.ImageUrl = dt.Rows(9).Item(1)
            Label31.Text = dt.Rows(10).Item(0)
            ImageButton31.ImageUrl = dt.Rows(10).Item(1)
            Label32.Text = dt.Rows(11).Item(0)
            ImageButton32.ImageUrl = dt.Rows(11).Item(1)
            Label33.Text = dt.Rows(12).Item(0)
            ImageButton33.ImageUrl = dt.Rows(12).Item(1)
            Label34.Text = dt.Rows(13).Item(0)
            ImageButton34.ImageUrl = dt.Rows(13).Item(1)
            Label35.Text = dt.Rows(14).Item(0)
            ImageButton35.ImageUrl = dt.Rows(14).Item(1)
            Label36.Text = dt.Rows(15).Item(0)
            ImageButton36.ImageUrl = dt.Rows(15).Item(1)
            Label37.Text = dt.Rows(16).Item(0)
            ImageButton37.ImageUrl = dt.Rows(16).Item(1)
            Label38.Text = dt.Rows(17).Item(0)
            ImageButton38.ImageUrl = dt.Rows(17).Item(1)
            Label39.Text = dt.Rows(18).Item(0)
            ImageButton39.ImageUrl = dt.Rows(18).Item(1)
            Label40.Text = dt.Rows(19).Item(0)
            ImageButton40.ImageUrl = dt.Rows(19).Item(1)
        ElseIf RadioButtonList2.SelectedIndex = 1 Then

            Dim con As New OleDbConnection("Provider=MSDAORA.1;user id=scott;password=tiger")
            Dim da As OleDbDataAdapter
            Dim ds As New DataSet
            Dim dt As New System.Data.DataTable
            Dim qry As String = "select * from laptop order by price asc"
            da = New OleDbDataAdapter(qry, con)
            con.Open()
            da.Fill(ds)
            con.Close()
            dt = ds.Tables(0)
            Label21.Text = dt.Rows(0).Item(0)
            ImageButton21.ImageUrl = dt.Rows(0).Item(1)
            Label22.Text = dt.Rows(1).Item(0)
            ImageButton22.ImageUrl = dt.Rows(1).Item(1)
            Label23.Text = dt.Rows(2).Item(0)
            ImageButton23.ImageUrl = dt.Rows(2).Item(1)
            Label24.Text = dt.Rows(3).Item(0)
            ImageButton24.ImageUrl = dt.Rows(3).Item(1)
            Label25.Text = dt.Rows(4).Item(0)
            ImageButton25.ImageUrl = dt.Rows(4).Item(1)
            Label26.Text = dt.Rows(5).Item(0)
            ImageButton26.ImageUrl = dt.Rows(5).Item(1)
            Label27.Text = dt.Rows(6).Item(0)
            ImageButton27.ImageUrl = dt.Rows(6).Item(1)
            Label28.Text = dt.Rows(7).Item(0)
            ImageButton28.ImageUrl = dt.Rows(7).Item(1)
            Label29.Text = dt.Rows(8).Item(0)
            ImageButton29.ImageUrl = dt.Rows(8).Item(1)
            Label30.Text = dt.Rows(9).Item(0)
            ImageButton30.ImageUrl = dt.Rows(9).Item(1)
            Label31.Text = dt.Rows(10).Item(0)
            ImageButton31.ImageUrl = dt.Rows(10).Item(1)
            Label32.Text = dt.Rows(11).Item(0)
            ImageButton32.ImageUrl = dt.Rows(11).Item(1)
            Label33.Text = dt.Rows(12).Item(0)
            ImageButton33.ImageUrl = dt.Rows(12).Item(1)
            Label34.Text = dt.Rows(13).Item(0)
            ImageButton34.ImageUrl = dt.Rows(13).Item(1)
            Label35.Text = dt.Rows(14).Item(0)
            ImageButton35.ImageUrl = dt.Rows(14).Item(1)
            Label36.Text = dt.Rows(15).Item(0)
            ImageButton36.ImageUrl = dt.Rows(15).Item(1)
            Label37.Text = dt.Rows(16).Item(0)
            ImageButton37.ImageUrl = dt.Rows(16).Item(1)
            Label38.Text = dt.Rows(17).Item(0)
            ImageButton38.ImageUrl = dt.Rows(17).Item(1)
            Label39.Text = dt.Rows(18).Item(0)
            ImageButton39.ImageUrl = dt.Rows(18).Item(1)
            Label40.Text = dt.Rows(19).Item(0)
            ImageButton40.ImageUrl = dt.Rows(19).Item(1)
        End If
    End Sub

    Protected Sub ImageButton21_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton21.Click

    End Sub

    Protected Sub Button21_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button21.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label26.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label29.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label21.Text))

        End If
    End Sub
    Protected Sub Button22_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button22.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label31.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label38.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label22.Text))

        End If
    End Sub
    Protected Sub Button23_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button23.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label34.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label36.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label23.Text))

        End If
    End Sub
    Protected Sub Button24_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button24.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label22.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label23.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label24.Text))

        End If
    End Sub
    Protected Sub Button25_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button25.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label27.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label30.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label25.Text))

        End If
    End Sub
    Protected Sub Button26_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button26.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label21.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label37.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label26.Text))

        End If
    End Sub
    Protected Sub Button27_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button27.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label33.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label39.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label27.Text))

        End If
    End Sub
    Protected Sub Button28_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button28.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label40.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label25.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label28.Text))

        End If
    End Sub
    Protected Sub Button29_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button29.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label28.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label35.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label29.Text))

        End If
    End Sub
    Protected Sub Button30_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button30.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label32.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label24.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label30.Text))

        End If
    End Sub
    Protected Sub Button31_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button31.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label24.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label28.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label31.Text))

        End If
    End Sub
    Protected Sub Button32_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button32.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label35.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label32.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label32.Text))

        End If
    End Sub
    Protected Sub Button33_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button33.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label25.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label40.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label33.Text))

        End If
    End Sub
    Protected Sub Button34_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button34.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label39.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label33.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label34.Text))

        End If
    End Sub
    Protected Sub Button35_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button35.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label37.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label21.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label35.Text))

        End If
    End Sub
    Protected Sub Button36_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button36.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label30.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label27.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label36.Text))

        End If
    End Sub
    Protected Sub Button37_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button37.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label23.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label22.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label37.Text))

        End If
    End Sub
    Protected Sub Button38_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button38.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label36.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label31.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label38.Text))

        End If
    End Sub
    Protected Sub Button39_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button39.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label38.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label34.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label39.Text))

        End If
    End Sub
    Protected Sub Button40_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button40.Click
        If RadioButtonList2.SelectedIndex = 0 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label29.Text))
        ElseIf RadioButtonList2.SelectedIndex = 1 Then
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label26.Text))
        Else
            Response.Redirect("cart1.aspx?Data=" & Server.UrlEncode(Label40.Text))

        End If
    End Sub
End Class