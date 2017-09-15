﻿Public Class amazonCalculator
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kekInput.Text = "1"
        shippingInput.Text = "3,9"
        feeInput.Text = "12"
        taxInput.Text = "19"
        multiplyInput.Text = "1"
        addInput.Text = "0"

        Me.AcceptButton = calculateAmazon
        calculateAmazon.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub alwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles alwaysOnTop.CheckedChanged
        If (alwaysOnTop.Checked) Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub calculateAmazon_Click(sender As Object, e As EventArgs) Handles calculateAmazon.Click

        ' Read minimal netto price
        Dim kek As Double = Convert.ToDouble(kekInput.Text)
        Dim multiply As Double = Convert.ToDouble(multiplyInput.Text)
        Dim add As Double = Convert.ToDouble(addInput.Text)
        kek = kek * multiply + add


        ' Values to calculate
        Dim shipping As Double = Convert.ToDouble(shippingInput.Text)
        Dim fee As Double = Convert.ToDouble(feeInput.Text) / 100
        Dim tax As Double = Convert.ToDouble(taxInput.Text) / 100

        Dim kekGross As Double = kek + kek * tax                    ' Gross value
        Dim kekFee As Double = (kekGross + shipping) * fee          ' Amazon fees
        Dim kekGrossFee As Double = kekGross + kekFee               ' Gross value + fees
        Dim kekFeeNew As Double = (kekGrossFee + shipping) * fee

        Dim i As Double = kekGrossFee + kekFee - kekFeeNew  
        Dim ifee As Double = (i + shipping) * fee
        Dim iRest As Double = i - ifee

        For value As Integer = 0 To 10                              ' Do some magic
            i = i - iRest
            ifee = (i + shipping) * fee
            iRest = i - ifee - kekGross
        Next

        amazonOutput.Text = i

    End Sub


End Class
