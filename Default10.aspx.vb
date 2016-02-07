
Partial Class Default10
    Inherits System.Web.UI.Page

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a, b, c, p As Integer
        If txtn1.Text = "" Or Not IsNumeric(txtn1.Text) Or (Val(txtn1.Text) < 0) Or (Val(txtn1.Text) > 20) Then
            MsgBox("Por favor Ingrese Nota 1")
            txtn1.Text = ""
            txtn1.Focus()
        Else
            If txtn2.Text = "" Or Not IsNumeric(txtn2.Text) Or (Val(txtn2.Text) < 0) Or (Val(txtn2.Text) > 20) Then
                MsgBox("Por favor Ingrese Nota 2")
                txtn2.Text = ""
                txtn2.Focus()
            Else
                If txtn3.Text = "" Or Not IsNumeric(txtn3.Text) Or (Val(txtn3.Text) < 0) Or (Val(txtn3.Text) > 20) Then
                    MsgBox("Por favor Ingrese Nota 3")
                    txtn3.Text = ""
                    txtn3.Focus()
                Else
                    a = txtn1.Text
                    b = txtn2.Text
                    c = txtn3.Text
                    p = (a * 0.5) + (b * 0.3) + (c * 0.2)
                    txtp.Text = Integer.Parse(p)
                End If
            End If
        End If
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtn1.Text = ""
        txtn2.Text = ""
        txtn3.Text = ""
        txtp.Text = ""
        txtn1.Focus()
    End Sub
End Class
