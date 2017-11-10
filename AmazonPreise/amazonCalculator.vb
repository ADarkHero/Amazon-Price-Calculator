Public Class amazonCalculator
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kekInput.Text = "1"
        shippingInput.Text = "4,9"
        shippingInput.Text = "4,9"
        shippingInput.Text = "4,9"
        shippingInput.Text = "4,9"
        feeInput.Text = "12"
        taxInput.Text = "19"
        multiplyInput.Text = "1"
        addInput.Text = "0"
        profitMultiplyInput.Text = "8"
        profitAddInput.Text = "0"

        Me.AcceptButton = calculateAmazon
        calculateAmazon.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    ' Always on top function
    Private Sub alwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles alwaysOnTop.CheckedChanged
        If (alwaysOnTop.Checked) Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    ' Starts the calculations and writes them into the text boxes
    Private Sub calculateAmazon_Click(sender As Object, e As EventArgs) Handles calculateAmazon.Click

        amazonOutput.Text = calculatePrice(False)
        amazonProfitOutput.Text = calculatePrice(True)

    End Sub

    ' Does the calculations
    Private Function calculatePrice(profit As Boolean) As String
        ' Read minimal netto price
        Dim kek As Double = Convert.ToDouble(kekInput.Text)
        Dim multiply As Double = Convert.ToDouble(multiplyInput.Text)
        Dim add As Double = Convert.ToDouble(addInput.Text)
        kek = kek * multiply + add
        If profit Then
            kek = kek * (1 + Convert.ToDouble(profitMultiplyInput.Text / 100)) + Convert.ToDouble(profitAddInput.Text)
        End If


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

        Return Math.Round(i, 2).ToString("0.00")
    End Function

    Private Sub btnNetPrice_Click(sender As Object, e As EventArgs) Handles btnNetPrice.Click
        MessageBox.Show("What is your net price?
You can modify your base price, if you put a value into the multiplication / addition boxes. 

For example: 
    This is useful if you have your price for one unit, but you sell it in a pack of 12 units. You can just put a 12 in the multiplication field and don't have to do additional math.", "Net price",
           MessageBoxButtons.OK)
    End Sub

    Private Sub btnShipping_Click(sender As Object, e As EventArgs) Handles btnShipping.Click
        MessageBox.Show("How much do you charge for shipping?", "Shipping",
           MessageBoxButtons.OK)
    End Sub

    Private Sub btnAmazonFee_Click(sender As Object, e As EventArgs) Handles btnAmazonFee.Click
        MessageBox.Show("How big are the fees (in percent), Amazon charges?", "Fee",
           MessageBoxButtons.OK)
    End Sub

    Private Sub btnTax_Click(sender As Object, e As EventArgs) Handles btnTax.Click
        MessageBox.Show("How much tax (in percent) is charged for the product?", "Tax",
           MessageBoxButtons.OK)
    End Sub

    Private Sub btnProfit_Click(sender As Object, e As EventArgs) Handles btnProfit.Click
        MessageBox.Show("How much profit do you want to make, based on your netto price? The multiplication is calculated before the addition.

For example: 
    Netto price -> 10€ | Profit* -> 8%
    You would make 80 cents when the item is sold.

    Netto price -> 10€ | Profit* -> 8% | Profit+ -> 0,40
    You would make €1,20 when the item is sold.", "Profit",
           MessageBoxButtons.OK)
    End Sub

    Private Sub btnMinimal_Click(sender As Object, e As EventArgs) Handles btnMinimal.Click
        MessageBox.Show("Don't sell your product under this price, you will lose money.", "Minimal price",
           MessageBoxButtons.OK)
    End Sub

    Private Sub btnWithProfit_Click(sender As Object, e As EventArgs) Handles btnWithProfit.Click
        MessageBox.Show("Sell your product at this price, if the competition is not to big.", "Sell with profit",
                   MessageBoxButtons.OK)
    End Sub
End Class
