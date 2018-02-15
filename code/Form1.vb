Public Class frmBand
    Dim BTS = "V - Vocals" & vbNewLine & "Jungkook - Vocals" & vbNewLine & "Jimin - Vocals" & vbNewLine & "Suga - Rapper" & vbNewLine & "Jin - Vocals" & vbNewLine & "RM - Rapper" & vbNewLine & "J-Hope - Rapper"
    Dim BAND2 = "Tyler Joseph - Piano" & vbNewLine & "Josh Dun - Drums" & vbNewLine & "Chris Salih - Drums" & vbNewLine & "Nick Thomas - Bass Guitar"
    Dim FOB = "Pete Wentz - Bass Guitar" & vbNewLine & "Patrick Stump - Guitar" & vbNewLine & "Andy Hurley" & vbNewLine & "Joe Trohman - Guitar" & vbNewLine & "Mike - Drums" & vbNewLine & "Ben Rose - Drums" & vbNewLine & "Brandon - Guitar" & vbNewLine & "T.J - Guitar"
    Dim GRNDY = "Billie - Piano" & vbNewLine & "Tre - Drums" & vbNewLine & "Mike - Bass Guitar" & vbNewLine & "Raj - Drums" & vbNewLine & "John - Drums" & vbNewLine & "Aaron - Drums" & vbNewLine & "Dave - Drums" & vbNewLine & "Sean - Guitar"
    Dim FB = "Sehun - Vocals" & vbNewLine & "Chanyeol - Vocals" & vbNewLine & "Baekhyun - Lead Vocals" & vbNewLine & "Kai - Vocals" & vbNewLine & "Yixing - Vocals" & vbNewLine & "Suho - Lead Vocals" & vbNewLine & "Xiumin - Vocals" & vbNewLine & "Chen - Lead Vocals" & vbNewLine & "Kris Wu - Lead Rapper" & vbNewLine & "Tao - Vocals"

    Private Sub radBand1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBand1.CheckedChanged
        Me.lblResponse.Text = BTS
    End Sub

    Private Sub radBand2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBand2.CheckedChanged
        Me.lblResponse.Text = BAND2

    End Sub


    Private Sub radBand4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBand4.CheckedChanged
        Me.lblResponse.Text = FOB
    End Sub


    Private Sub radBand3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lblResponse.Text = GRNDY
    End Sub


    Private Sub radBand5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBand5.CheckedChanged
        Me.lblResponse.Text = FB
    End Sub

    Private Sub radClear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radClear.CheckedChanged
        Me.lblResponse.Text = " "
    End Sub
End Class
