
Partial Class Default7
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim lh, lm, lt, mh, mm, mt, vh, vm, vt, t, tt, sh, sm, ss As Integer
        If txtlh.Text = "" Or Not IsNumeric(txtlh.Text) Or (Val(txtlh.Text) < 0) Or (Val(txtlh.Text) > 23) Then
            MsgBox("Por favor Ingrese Dato [Hora Dia Lunes]")
            txtlh.Text = ""
            txtlh.Focus()
        Else
            If txtlm.Text = "" Or Not IsNumeric(txtlm.Text) Or (Val(txtlm.Text) < 0) Or (Val(txtlm.Text) > 59) Then
                MsgBox("Por favor Ingrese Dato [Minutos Dia Lunes]")
                txtlm.Text = ""
                txtlm.Focus()
            Else
                If txtls.Text = "" Or Not IsNumeric(txtls.Text) Or (Val(txtls.Text) < 0) Or (Val(txtls.Text) > 59) Then
                    MsgBox("Por favor Ingrese Dato [Segundos Dia Lunes]")
                    txtls.Text = ""
                    txtls.Focus()
                Else
                    If txtmh.Text = "" Or Not IsNumeric(txtmh.Text) Or (Val(txtmh.Text) < 0) Or (Val(txtmh.Text) > 23) Then
                        MsgBox("Por favor Ingrese Dato [Hora Dia Miercoles]")
                        txtmh.Text = ""
                        txtmh.Focus()
                    Else
                        If txtmm.Text = "" Or Not IsNumeric(txtmm.Text) Or (Val(txtmm.Text) < 0) Or (Val(txtmm.Text) > 59) Then
                            MsgBox("Por favor Ingrese Dato [Minutos Dia Miercoles]")
                            txtmm.Text = ""
                            txtmm.Focus()
                        Else
                            If txtms.Text = "" Or Not IsNumeric(txtms.Text) Or (Val(txtms.Text) < 0) Or (Val(txtms.Text) > 59) Then
                                MsgBox("Por favor Ingrese Dato [Segundos Dia Miercoles]")
                                txtms.Text = ""
                                txtms.Focus()
                            Else
                                If txtvh.Text = "" Or Not IsNumeric(txtvh.Text) Or (Val(txtvh.Text) < 0) Or (Val(txtvh.Text) > 23) Then
                                    MsgBox("Por favor Ingrese Dato [Hora Dia Viernes]")
                                    txtvh.Text = ""
                                    txtvh.Focus()
                                Else
                                    If txtvm.Text = "" Or Not IsNumeric(txtvm.Text) Or (Val(txtvm.Text) < 0) Or (Val(txtvm.Text) > 59) Then
                                        MsgBox("Por favor Ingrese Dato [Minutos Dia Viernes]")
                                        txtvm.Text = ""
                                        txtvm.Focus()
                                    Else
                                        If txtvs.Text = "" Or Not IsNumeric(txtvs.Text) Or (Val(txtvs.Text) < 0) Or (Val(txtvs.Text) > 59) Then
                                            MsgBox("Por favor Ingrese Dato [Segundos Dia Viernes]")
                                            txtvs.Text = ""
                                            txtvs.Focus()
                                        Else
                                            lh = Val(txtlh.Text) * 3600
                                            lm = Val(txtlm.Text) * 60
                                            lt = Val(txtls.Text) + lh + lm

                                            mh = Val(txtmh.Text) * 3600
                                            mm = Val(txtmm.Text) * 60
                                            mt = Val(txtms.Text) + mh + mm
                                            vh = Val(txtvh.Text) * 3600
                                            vm = Val(txtvm.Text) * 60
                                            vt = Val(txtvs.Text) + vh + vm
                                            t = (lt + mt + vt) / 3
                                            sh = t / 3600
                                            tt = t Mod 3600
                                            sm = tt / 60
                                            ss = tt Mod 60
                                            txtsh.Text = Integer.Parse(sh)
                                            txtsm.Text = Integer.Parse(sm)
                                            txtss.Text = Integer.Parse(ss)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtlh.Text = ""
        txtlm.Text = ""
        txtls.Text = ""
        txtmh.Text = ""
        txtmm.Text = ""
        txtms.Text = ""
        txtvh.Text = ""
        txtvs.Text = ""
        txtsh.Text = ""
        txtvm.Text = ""
        txtsm.Text = ""
        txtss.Text = ""
        txtlh.Focus()
    End Sub
End Class
