
Partial Class Default4
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim a, b, c As Single
        If txts.Text = "" Or Not IsNumeric(txts.Text) Then
            MsgBox("Por favor Ingrese Salario")
            txts.Text = ""
            txts.Focus()
        Else
            a = txts.Text
            If a < 0 Then
                MsgBox("Por favor Ingrese Salario Valido")
                txts.Text = ""
                txts.Focus()
            Else
                b = a * 0.25
                c = a + b
                txtd.Text = Single.Parse(b)
                txtn.Text = Single.Parse(c)
        End If
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        txts.Text = ""
        txtd.Text = ""
        txtn.Text = ""
        txts.Focus()
    End Sub
End Class
