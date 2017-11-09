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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(amazonCalculator))
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
        Me.addInput = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.multiplyInput = New System.Windows.Forms.TextBox()
        Me.alwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.profitMultiplyInput = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.profitAddInput = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.amazonProfitOutput = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'kekInput
        '
        Me.kekInput.BackColor = System.Drawing.SystemColors.Window
        Me.kekInput.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kekInput.Location = New System.Drawing.Point(95, 12)
        Me.kekInput.Name = "kekInput"
        Me.kekInput.Size = New System.Drawing.Size(146, 23)
        Me.kekInput.TabIndex = 0
        Me.kekInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calculateAmazon
        '
        Me.calculateAmazon.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateAmazon.Location = New System.Drawing.Point(12, 357)
        Me.calculateAmazon.Name = "calculateAmazon"
        Me.calculateAmazon.Size = New System.Drawing.Size(260, 23)
        Me.calculateAmazon.TabIndex = 8
        Me.calculateAmazon.Text = "Calculate"
        Me.calculateAmazon.UseVisualStyleBackColor = True
        '
        'amazonOutput
        '
        Me.amazonOutput.Location = New System.Drawing.Point(100, 386)
        Me.amazonOutput.Name = "amazonOutput"
        Me.amazonOutput.Size = New System.Drawing.Size(141, 20)
        Me.amazonOutput.TabIndex = 9
        Me.amazonOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'shippingInput
        '
        Me.shippingInput.Location = New System.Drawing.Point(95, 109)
        Me.shippingInput.Name = "shippingInput"
        Me.shippingInput.Size = New System.Drawing.Size(146, 20)
        Me.shippingInput.TabIndex = 3
        Me.shippingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'feeInput
        '
        Me.feeInput.Location = New System.Drawing.Point(95, 164)
        Me.feeInput.Name = "feeInput"
        Me.feeInput.Size = New System.Drawing.Size(146, 20)
        Me.feeInput.TabIndex = 4
        Me.feeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'taxInput
        '
        Me.taxInput.Location = New System.Drawing.Point(95, 219)
        Me.taxInput.Name = "taxInput"
        Me.taxInput.Size = New System.Drawing.Size(146, 20)
        Me.taxInput.TabIndex = 5
        Me.taxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 75)
        Me.Button1.TabIndex = 100
        Me.Button1.TabStop = False
        Me.Button1.Text = "Net price"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 49)
        Me.Button2.TabIndex = 101
        Me.Button2.TabStop = False
        Me.Button2.Text = "Shipping"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 49)
        Me.Button3.TabIndex = 102
        Me.Button3.TabStop = False
        Me.Button3.Text = "Amazon Fee"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 204)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 49)
        Me.Button4.TabIndex = 100
        Me.Button4.TabStop = False
        Me.Button4.Text = "Tax"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'addInput
        '
        Me.addInput.Location = New System.Drawing.Point(126, 67)
        Me.addInput.Name = "addInput"
        Me.addInput.Size = New System.Drawing.Size(115, 20)
        Me.addInput.TabIndex = 2
        Me.addInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'addButton
        '
        Me.addButton.Enabled = False
        Me.addButton.Location = New System.Drawing.Point(95, 67)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(25, 20)
        Me.addButton.TabIndex = 105
        Me.addButton.TabStop = False
        Me.addButton.Text = "+"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Enabled = False
        Me.multiplyButton.Location = New System.Drawing.Point(95, 41)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(25, 20)
        Me.multiplyButton.TabIndex = 106
        Me.multiplyButton.TabStop = False
        Me.multiplyButton.Text = "x"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'multiplyInput
        '
        Me.multiplyInput.Location = New System.Drawing.Point(126, 41)
        Me.multiplyInput.Name = "multiplyInput"
        Me.multiplyInput.Size = New System.Drawing.Size(115, 20)
        Me.multiplyInput.TabIndex = 1
        Me.multiplyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'alwaysOnTop
        '
        Me.alwaysOnTop.AutoSize = True
        Me.alwaysOnTop.Location = New System.Drawing.Point(12, 334)
        Me.alwaysOnTop.Name = "alwaysOnTop"
        Me.alwaysOnTop.Size = New System.Drawing.Size(176, 17)
        Me.alwaysOnTop.TabIndex = 107
        Me.alwaysOnTop.TabStop = False
        Me.alwaysOnTop.Text = "Application always on top"
        Me.alwaysOnTop.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 259)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 48)
        Me.Button5.TabIndex = 108
        Me.Button5.TabStop = False
        Me.Button5.Text = "Profit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'profitMultiplyInput
        '
        Me.profitMultiplyInput.Location = New System.Drawing.Point(126, 259)
        Me.profitMultiplyInput.Name = "profitMultiplyInput"
        Me.profitMultiplyInput.Size = New System.Drawing.Size(115, 20)
        Me.profitMultiplyInput.TabIndex = 6
        Me.profitMultiplyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(95, 259)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 20)
        Me.Button6.TabIndex = 110
        Me.Button6.TabStop = False
        Me.Button6.Text = "x"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(95, 287)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 20)
        Me.Button7.TabIndex = 111
        Me.Button7.TabStop = False
        Me.Button7.Text = "+"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'profitAddInput
        '
        Me.profitAddInput.Location = New System.Drawing.Point(126, 287)
        Me.profitAddInput.Name = "profitAddInput"
        Me.profitAddInput.Size = New System.Drawing.Size(115, 20)
        Me.profitAddInput.TabIndex = 7
        Me.profitAddInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 386)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(82, 20)
        Me.Button8.TabIndex = 113
        Me.Button8.TabStop = False
        Me.Button8.Text = "Minimal Price"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(12, 412)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(82, 20)
        Me.Button9.TabIndex = 114
        Me.Button9.TabStop = False
        Me.Button9.Text = "With Profit"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'amazonProfitOutput
        '
        Me.amazonProfitOutput.Location = New System.Drawing.Point(100, 412)
        Me.amazonProfitOutput.Name = "amazonProfitOutput"
        Me.amazonProfitOutput.Size = New System.Drawing.Size(141, 20)
        Me.amazonProfitOutput.TabIndex = 10
        Me.amazonProfitOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.Location = New System.Drawing.Point(247, 164)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(25, 20)
        Me.Button10.TabIndex = 115
        Me.Button10.TabStop = False
        Me.Button10.Text = "%"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Enabled = False
        Me.Button11.Location = New System.Drawing.Point(247, 219)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(25, 20)
        Me.Button11.TabIndex = 116
        Me.Button11.TabStop = False
        Me.Button11.Text = "%"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Enabled = False
        Me.Button12.Location = New System.Drawing.Point(247, 259)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(25, 20)
        Me.Button12.TabIndex = 117
        Me.Button12.TabStop = False
        Me.Button12.Text = "%"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Enabled = False
        Me.Button13.Location = New System.Drawing.Point(247, 109)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(25, 20)
        Me.Button13.TabIndex = 118
        Me.Button13.TabStop = False
        Me.Button13.Text = "€"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Enabled = False
        Me.Button14.Location = New System.Drawing.Point(247, 287)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(25, 20)
        Me.Button14.TabIndex = 119
        Me.Button14.TabStop = False
        Me.Button14.Text = "€"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Enabled = False
        Me.Button15.Location = New System.Drawing.Point(247, 12)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(25, 23)
        Me.Button15.TabIndex = 120
        Me.Button15.TabStop = False
        Me.Button15.Text = "€"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Enabled = False
        Me.Button16.Location = New System.Drawing.Point(247, 386)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(25, 20)
        Me.Button16.TabIndex = 121
        Me.Button16.TabStop = False
        Me.Button16.Text = "€"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Enabled = False
        Me.Button17.Location = New System.Drawing.Point(247, 412)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(25, 20)
        Me.Button17.TabIndex = 122
        Me.Button17.TabStop = False
        Me.Button17.Text = "€"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Enabled = False
        Me.Button18.Location = New System.Drawing.Point(247, 67)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(25, 20)
        Me.Button18.TabIndex = 123
        Me.Button18.TabStop = False
        Me.Button18.Text = "€"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Enabled = False
        Me.Button19.Location = New System.Drawing.Point(247, 41)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(25, 20)
        Me.Button19.TabIndex = 124
        Me.Button19.TabStop = False
        Me.Button19.Text = "*"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'amazonCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 448)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.amazonProfitOutput)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.profitAddInput)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.profitMultiplyInput)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.alwaysOnTop)
        Me.Controls.Add(Me.multiplyInput)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.addInput)
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
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents addInput As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents multiplyButton As Button
    Friend WithEvents multiplyInput As TextBox
    Friend WithEvents alwaysOnTop As CheckBox
    Friend WithEvents Button5 As Button
    Friend WithEvents profitMultiplyInput As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents profitAddInput As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents amazonProfitOutput As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
End Class
