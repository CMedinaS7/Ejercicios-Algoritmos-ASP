
Partial Class Default5
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d As Single
        If txtm.Text = "" Or Not IsNumeric(txtm.Text) Then
            MsgBox("Por favor Ingrese Monto de Presupuesto")
            txtm.Text = ""
            txtm.Focus()
        Else
            a = txtm.Text
            If a < 0 Then
                MsgBox("El monto ingresado no es valido")
                txtm.Text = ""
                txtm.Focus()
            Else
                b = a * 0.4
                c = a * 0.3
                d = a * 0.3
                txtg.Text = Single.Parse(b)
                txtt.Text = Single.Parse(c)
                txtp.Text = Single.Parse(d)
        End If
        End If

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtm.Text = ""
        txtg.Text = ""
        txtt.Text = ""
        txtp.Text = ""
        txtm.Focus()
    End Sub
End Class
