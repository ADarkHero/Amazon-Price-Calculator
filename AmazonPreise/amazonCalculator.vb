Public Class amazonCalculator
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kekInput.Text = "1"
        shippingInput.Text = "3,9"
        feeInput.Text = "12"
        taxInput.Text = "19"

        Me.AcceptButton = calculateAmazon
        calculateAmazon.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub kekInput_TextChanged(sender As Object, e As EventArgs) Handles kekInput.TextChanged

    End Sub

    Private Sub calculateAmazon_Click(sender As Object, e As EventArgs) Handles calculateAmazon.Click

        'KEK einlesen
        Dim kek As Double = Convert.ToDouble(kekInput.Text)

        'Werte zur Berechnung
        Dim shipping As Double = Convert.ToDouble(shippingInput.Text)
        Dim fee As Double = Convert.ToDouble(feeInput.Text) / 100
        Dim tax As Double = Convert.ToDouble(taxInput.Text) / 100

        Dim kekGross As Double = kek + kek * tax
        Dim kekFee As Double = (kekGross + shipping) * fee
        Dim kekGrossFee As Double = kekGross + kekFee
        Dim kekFeeNew As Double = (kekGrossFee + shipping) * fee

        Dim i As Double = kekGrossFee + kekFee - kekFeeNew
        Dim ifee As Double = (i + shipping) * fee
        Dim iRest As Double = i - ifee

        For value As Integer = 0 To 10
            i = i - iRest
            ifee = (i + shipping) * fee
            iRest = i - ifee - kekGross
        Next

        amazonOutput.Text = i

    End Sub

    Private Sub amazonOutput_TextChanged(sender As Object, e As EventArgs) Handles amazonOutput.TextChanged

    End Sub
End Class
