Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p, v, t, m, m1, r As Single
        If txtp.Text = "" Or Not IsNumeric(txtp.Text) Then
            MsgBox("Ingrese Presión")
            txtp.Text = ""
            txtp.Focus()
        Else
            If txtv.Text = "" Or Not IsNumeric(txtv.Text) Then
                MsgBox("Ingrese Volumen")
                txtv.Text = ""
                txtv.Focus()
            Else
                If txtt.Text = "" Or Not IsNumeric(txtt.Text) Then
                    MsgBox("Ingrese Temperatura")
                    txtt.Text = ""
                    txtt.Focus()
                Else
                    p = txtp.Text
                    v = txtv.Text
                    t = txtt.Text
                    If v < 0 Then
                        MsgBox("VOLUMEN NO VALIDO")
                        txtv.Text = ""
                        txtv.Focus()
                    Else
                        m = p * v
                        m1 = 0.37 * (t + 460)
                        If m1 < 0 Then
                            txtm.Text = "IMPOSIBLE CALULAR MASA"
                        Else
                            r = m / m1
                            txtm.Text = Single.Parse(r)
                End If
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtp.Text = ""
        txtv.Text = ""
        txtt.Text = ""
        txtp.Focus()
    End Sub
End Class
