<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class amazonCalculator
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.kekInput = New System.Windows.Forms.TextBox()
        Me.calculateAmazon = New System.Windows.Forms.Button()
        Me.amazonOutput = New System.Windows.Forms.TextBox()
        Me.shippingInput = New System.Windows.Forms.TextBox()
        Me.feeInput = New System.Windows.Forms.TextBox()
        Me.taxInput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'kekInput
        '
        Me.kekInput.Location = New System.Drawing.Point(12, 41)
        Me.kekInput.Name = "kekInput"
        Me.kekInput.Size = New System.Drawing.Size(260, 20)
        Me.kekInput.TabIndex = 0
        '
        'calculateAmazon
        '
        Me.calculateAmazon.Location = New System.Drawing.Point(12, 257)
        Me.calculateAmazon.Name = "calculateAmazon"
        Me.calculateAmazon.Size = New System.Drawing.Size(260, 23)
        Me.calculateAmazon.TabIndex = 4
        Me.calculateAmazon.Text = "Calculate"
        Me.calculateAmazon.UseVisualStyleBackColor = True
        '
        'amazonOutput
        '
        Me.amazonOutput.Location = New System.Drawing.Point(12, 286)
        Me.amazonOutput.Name = "amazonOutput"
        Me.amazonOutput.Size = New System.Drawing.Size(260, 20)
        Me.amazonOutput.TabIndex = 5
        '
        'shippingInput
        '
        Me.shippingInput.Location = New System.Drawing.Point(12, 96)
        Me.shippingInput.Name = "shippingInput"
        Me.shippingInput.Size = New System.Drawing.Size(260, 20)
        Me.shippingInput.TabIndex = 1
        '
        'feeInput
        '
        Me.feeInput.Location = New System.Drawing.Point(12, 151)
        Me.feeInput.Name = "feeInput"
        Me.feeInput.Size = New System.Drawing.Size(260, 20)
        Me.feeInput.TabIndex = 2
        '
        'taxInput
        '
        Me.taxInput.Location = New System.Drawing.Point(12, 206)
        Me.taxInput.Name = "taxInput"
        Me.taxInput.Size = New System.Drawing.Size(260, 20)
        Me.taxInput.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 23)
        Me.Button1.TabIndex = 100
        Me.Button1.Text = "Net price"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(12, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 23)
        Me.Button2.TabIndex = 101
        Me.Button2.Text = "Shipping"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(12, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(260, 23)
        Me.Button3.TabIndex = 102
        Me.Button3.Text = "Amazon Fee"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(12, 177)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(260, 23)
        Me.Button4.TabIndex = 103
        Me.Button4.Text = "Tax"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'amazonCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 319)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.taxInput)
        Me.Controls.Add(Me.feeInput)
        Me.Controls.Add(Me.shippingInput)
        Me.Controls.Add(Me.amazonOutput)
        Me.Controls.Add(Me.calculateAmazon)
        Me.Controls.Add(Me.kekInput)
        Me.Name = "amazonCalculator"
        Me.Text = "Amazon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents kekInput As TextBox
    Friend WithEvents calculateAmazon As Button
    Friend WithEvents amazonOutput As TextBox
    Friend WithEvents shippingInput As TextBox
    Friend WithEvents feeInput As TextBox
    Friend WithEvents taxInput As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
