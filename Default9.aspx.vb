
Partial Class Default9
    Inherits System.Web.UI.Page

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a, b, c, d, m, n, p As Integer
        If txtem.Text = "" Or Not IsNumeric(txtem.Text) Or (Val(txtem.Text) < 0) Or (Val(txtem.Text) > 20) Then
            MsgBox("Por favor Ingrese Nota de Examen [MATEMATICA]")
            txtem.Text = ""
            txtem.Focus()
        Else
            If txttm1.Text = "" Or Not IsNumeric(txttm1.Text) Or (Val(txttm1.Text) < 0) Or (Val(txttm1.Text) > 20) Then

                MsgBox("Por favor Ingrese Nota de tarea 1 [MATEMATICA]")
                txttm1.Text = ""
                txttm1.Focus()
            Else
                If txttm2.Text = "" Or Not IsNumeric(txttm2.Text) Or (Val(txttm2.Text) < 0) Or (Val(txttm2.Text) > 20) Then
                    MsgBox("Por favor Ingrese Nota de tarea 2 [MATEMATICA]")
                    txttm2.Text = ""
                    txttm2.Focus()
                Else
                    If txttm3.Text = "" Or Not IsNumeric(txttm3.Text) Or (Val(txttm3.Text) < 0) Or (Val(txttm3.Text) > 20) Then
                        MsgBox("Por favor Ingrese Nota de tarea 3 [MATEMATICA]")
                        txttm3.Text = ""
                        txttm3.Focus()
                    Else
                        a = txtem.Text
                        b = txttm1.Text
                        c = txttm2.Text
                        d = txttm3.Text
                        m = a * 0.9
                        n = ((b + c + d) / 3) * 0.1
                        p = m + n
                        txtpm.Text = Integer.Parse(p)
                    End If
                End If
            End If
        End If
       
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, m, n, z As Integer
        If txtef.Text = "" Or Not IsNumeric(txtef.Text) Or (Val(txtef.Text) < 0) Or (Val(txtef.Text) > 20) Then
            MsgBox("Por favor Ingrese Nota de Examen [FISICA]")
            txtef.Text = ""
            txtef.Focus()
        Else
            If txttf1.Text = "" Or Not IsNumeric(txttf1.Text) Or (Val(txttf1.Text) < 0) Or (Val(txttf1.Text) > 20) Then
                MsgBox("Por favor Ingrese Nota de tarea 1 [FISICA]")
                txttf1.Text = ""
                txttf1.Focus()
            Else
                If txttf2.Text = "" Or Not IsNumeric(txttf2.Text) Or (Val(txttf2.Text) < 0) Or (Val(txttf2.Text) > 20) Then
                    MsgBox("Por favor Ingrese Nota de tarea 2 [FISICA]")
                    txttf2.Text = ""
                    txttf2.Focus()
                Else
                    a = txtef.Text
                    b = txttf1.Text
                    c = txttf2.Text

                    m = a * 0.8
                    n = ((b + c) / 2) * 0.2
                    z = m + n
                    txtpf.Text = Integer.Parse(z)
                End If
            End If
        End If
               
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a, b, c, d, m, n, p As Integer
        If txteq.Text = "" Or Not IsNumeric(txteq.Text) Or (Val(txteq.Text) < 0) Or (Val(txteq.Text) > 20) Then
            MsgBox("Por favor Ingrese Nota de Examen [QUIMICA]")
            txteq.Text = ""
            txteq.Focus()
        Else
            If txttq1.Text = "" Or Not IsNumeric(txttq1.Text) Or (Val(txttq1.Text) < 0) Or (Val(txttq1.Text) > 20) Then
                MsgBox("Por favor Ingrese Nota de tarea 1 [QUIMICA]")
                txttq1.Text = ""
                txttq1.Focus()
            Else
                If txttq2.Text = "" Or Not IsNumeric(txttq2.Text) Or (Val(txttq2.Text) < 0) Or (Val(txttq2.Text) > 20) Then
                    MsgBox("Por favor Ingrese Nota de tarea 2 [QUIMICA]")
                    txttq2.Text = ""
                    txttq2.Focus()
                Else
                    If txttq3.Text = "" Or Not IsNumeric(txttq3.Text) Or (Val(txttq3.Text) < 0) Or (Val(txttq3.Text) > 20) Then
                        MsgBox("Por favor Ingrese Nota de tarea 3 [QUIMICA]")
                        txttq3.Text = ""
                        txttq3.Focus()
                    Else
                        a = txteq.Text
                        b = txttq1.Text
                        c = txttq2.Text
                        d = txttq3.Text

                        m = a * 0.85
                        n = ((b + c + d) / 3) * 0.15
                        p = m + n
                        txtpq.Text = Single.Parse(p)
                    End If
                End If
            End If
        End If
                    
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtem.Text = ""
        txttm1.Text = ""
        txttm2.Text = ""
        txttm3.Text = ""
        txtpm.Text = ""
        txtem.Focus()
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtef.Text = ""
        txttf1.Text = ""
        txttf2.Text = ""
        txtpf.Text = ""
        txtef.Focus()
    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        txteq.Text = ""
        txttq1.Text = ""
        txttq2.Text = ""
        txttq3.Text = ""
        txtpq.Text = ""
        txteq.Focus()
    End Sub

    Protected Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim a As Single

        a = (Val(txtpm.Text) + Val(txtpf.Text) + Val(txtpq.Text)) / 3
        txtpg.Text = Int(Single.Parse(a))



    End Sub
End Class
