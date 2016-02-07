
Partial Class Default8
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim es, a, b, c, d, f, g As Single
        If txtp1.Text = "" Or Not IsNumeric(txtp1.Text) Or (Val(txtp1.Text) < 0) Then
            MsgBox("Por favor Ingrese Monto [Persona 1]")
            txtp1.Text = ""
            txtp1.Focus()
        Else
            If txtp2.Text = "" Or Not IsNumeric(txtp2.Text) Or (Val(txtp2.Text) < 0) Then
                MsgBox("Por favor Ingrese Monto [Persona 2]")
                txtp2.Text = ""
                txtp2.Focus()
            Else
                If txtp3.Text = "" Or Not IsNumeric(txtp3.Text) Or (Val(txtp3.Text) < 0) Then
                    MsgBox("Por favor Ingrese Monto [Persona 3]")
                    txtp3.Text = ""
                    txtp3.Focus()
                Else
                    a = txtp1.Text
                    b = txtp2.Text
                    c = txtp3.Text

                    g = a + b + c
                    d = (a * 100) / g
                    es = (b * 100) / g
                    f = (c * 100) / g
                    txtpp1.Text = Single.Parse(d) & " %"
                    txtpp2.Text = Single.Parse(es) & " %"
                    txtpp3.Text = Single.Parse(f) & " %"
                End If
            End If
        End If          
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtpp1.Enabled = False
        txtpp2.Enabled = False
        txtpp3.Enabled = False
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtp1.Text = ""
        txtp2.Text = ""
        txtp3.Text = ""
        txtpp1.Text = ""
        txtpp2.Text = ""
        txtpp3.Text = ""
        txtp1.Focus()
    End Sub
End Class
