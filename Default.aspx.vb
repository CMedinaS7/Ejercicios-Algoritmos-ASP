
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s, uc, d As Single


        If txtuc.Text = "" Or Not IsNumeric(txtuc.Text) Then
            MsgBox("Ingrese unidad cambiaria")
            txtuc.Text = ""
            txtuc.Focus()
        Else
            If txts.Text = "" Or Not IsNumeric(txts.Text) Then
                MsgBox("Ingrese cantidad en soles")
                txts.Text = ""
                txts.Focus()
            Else
                If txtuc.Text = 0 Then
                    MsgBox("UNIDAD CAMBIARIA NO VALIDA")
                    txtuc.Text = ""
                    txtuc.Focus()
                Else
                    s = txts.Text
                    uc = txtuc.Text

                    If (uc < 0) Then
                        MsgBox("UNIDAD CAMBIARIA NO VALIDA")
                        txtuc.Text = ""
                        txtuc.Focus()

                    Else
                        If (s < 0) Then
                            MsgBox("CANTIDAD EN SOLES NO VALIDA")
                            txts.Text = ""
                            txts.Focus()

                        Else

                            d = s / uc
                            txtd.Text = Single.Parse(d)
                        End If
                    End If
                End If
            End If

        End If


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        txts.Text = ""
        txtuc.Text = ""
        txtd.Text = ""
        txtuc.Focus()
    End Sub
End Class
