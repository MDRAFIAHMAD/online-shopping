Public Class main
    Inherits System.Web.UI.MasterPage

    Protected Sub OnMenuItemDataBound(ByVal sender As Object, ByVal e As MenuEventArgs)
        If SiteMap.CurrentNode IsNot Nothing Then
            If e.Item.Text = SiteMap.CurrentNode.Title Then
                If e.Item.Parent IsNot Nothing Then
                    e.Item.Parent.Selected = True
                Else
                    e.Item.Selected = True
                End If
            End If
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class