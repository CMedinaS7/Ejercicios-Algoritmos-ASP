
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim a As Integer
        Dim b As Single
        If txte.Text = "" Or Not IsNumeric(txte.Text) Then
            MsgBox("Por favor Ingrese Edad")
            txte.Text = ""
            txte.Focus()
        Else
            a = txte.Text
            If a > 0 And a <= 100 Then
                b = (220 - a) / 10
                txtp.Text = Single.Parse(b)
            Else
                MsgBox("La edad ingresada debe ser entre [1-100]")
                txte.Text = ""
                txte.Focus()
            End If
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        txte.Text = ""
        txtp.Text = ""
        txte.Focus()
    End Sub
End Class
