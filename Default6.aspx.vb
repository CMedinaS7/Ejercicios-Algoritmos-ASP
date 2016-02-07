
Partial Class Default6
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b As Single
        If txtp.Text = "" Or Not IsNumeric(txtp.Text) Then
            MsgBox("Por favor Ingrese el Precio del producto")
            txtp.Text = ""
            txtp.Focus()
        Else
            a = txtp.Text
            If a < 0 Then
                MsgBox("Precio del Producto invalido")
                txtp.Text = ""
                txtp.Focus()
            Else
                b = a * 1.3
                txtg.Text = Single.Parse(b)
            End If
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtp.Text = ""
        txtg.Text = ""
        txtp.Focus()

    End Sub
End Class
