<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxMarketCap = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxValueOfShares = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxFunds = New System.Windows.Forms.TextBox()
        Me.InfoDropdownStock = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSharesOwned = New System.Windows.Forms.TextBox()
        Me.TextBoxSharesAvailable = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RadioButtonBuy = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSell = New System.Windows.Forms.RadioButton()
        Me.TextBoxBuySellPrice = New System.Windows.Forms.TextBox()
        Me.BuySellDropDown = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonBuySell = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonBuySellQuantityAll = New System.Windows.Forms.Button()
        Me.TextBoxBuySellQuantity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelHistoryBuyOrSell = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelHistorySharePrice = New System.Windows.Forms.Label()
        Me.LabelHistoryQuantity = New System.Windows.Forms.Label()
        Me.LabelHistoryBrokerageFee = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Market Simulator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shares available"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Shares Owned"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelHistoryBrokerageFee)
        Me.GroupBox1.Controls.Add(Me.LabelHistoryQuantity)
        Me.GroupBox1.Controls.Add(Me.LabelHistorySharePrice)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.LabelHistoryBuyOrSell)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxMarketCap)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBoxValueOfShares)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxFunds)
        Me.GroupBox1.Controls.Add(Me.InfoDropdownStock)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxSharesOwned)
        Me.GroupBox1.Controls.Add(Me.TextBoxSharesAvailable)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 375)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Market Cap"
        '
        'TextBoxMarketCap
        '
        Me.TextBoxMarketCap.Location = New System.Drawing.Point(9, 138)
        Me.TextBoxMarketCap.Name = "TextBoxMarketCap"
        Me.TextBoxMarketCap.ReadOnly = True
        Me.TextBoxMarketCap.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxMarketCap.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(140, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Value of Owned Shares"
        '
        'TextBoxValueOfShares
        '
        Me.TextBoxValueOfShares.Location = New System.Drawing.Point(143, 99)
        Me.TextBoxValueOfShares.Name = "TextBoxValueOfShares"
        Me.TextBoxValueOfShares.ReadOnly = True
        Me.TextBoxValueOfShares.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxValueOfShares.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Funds available"
        '
        'TextBoxFunds
        '
        Me.TextBoxFunds.Location = New System.Drawing.Point(9, 99)
        Me.TextBoxFunds.Name = "TextBoxFunds"
        Me.TextBoxFunds.ReadOnly = True
        Me.TextBoxFunds.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxFunds.TabIndex = 7
        '
        'InfoDropdownStock
        '
        Me.InfoDropdownStock.FormattingEnabled = True
        Me.InfoDropdownStock.Items.AddRange(New Object() {"Apple (AAPL)", "Google (GOOGL)"})
        Me.InfoDropdownStock.Location = New System.Drawing.Point(72, 20)
        Me.InfoDropdownStock.Name = "InfoDropdownStock"
        Me.InfoDropdownStock.Size = New System.Drawing.Size(100, 21)
        Me.InfoDropdownStock.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Stock:"
        '
        'TextBoxSharesOwned
        '
        Me.TextBoxSharesOwned.Location = New System.Drawing.Point(143, 62)
        Me.TextBoxSharesOwned.Name = "TextBoxSharesOwned"
        Me.TextBoxSharesOwned.ReadOnly = True
        Me.TextBoxSharesOwned.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxSharesOwned.TabIndex = 4
        '
        'TextBoxSharesAvailable
        '
        Me.TextBoxSharesAvailable.Location = New System.Drawing.Point(9, 62)
        Me.TextBoxSharesAvailable.Name = "TextBoxSharesAvailable"
        Me.TextBoxSharesAvailable.ReadOnly = True
        Me.TextBoxSharesAvailable.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxSharesAvailable.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 117)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Brokerage Fees:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$10.00 (Up to and including $1,000)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$19.95 (Over $1,000 up " &
    "to $10,000)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$29.95 (Over $10,000 up to $25,000)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.12% (Over $25,000)"
        '
        'RadioButtonBuy
        '
        Me.RadioButtonBuy.AutoSize = True
        Me.RadioButtonBuy.Checked = True
        Me.RadioButtonBuy.Location = New System.Drawing.Point(6, 16)
        Me.RadioButtonBuy.Name = "RadioButtonBuy"
        Me.RadioButtonBuy.Size = New System.Drawing.Size(43, 17)
        Me.RadioButtonBuy.TabIndex = 0
        Me.RadioButtonBuy.TabStop = True
        Me.RadioButtonBuy.Text = "Buy"
        Me.RadioButtonBuy.UseVisualStyleBackColor = True
        '
        'RadioButtonSell
        '
        Me.RadioButtonSell.AutoSize = True
        Me.RadioButtonSell.Location = New System.Drawing.Point(55, 16)
        Me.RadioButtonSell.Name = "RadioButtonSell"
        Me.RadioButtonSell.Size = New System.Drawing.Size(42, 17)
        Me.RadioButtonSell.TabIndex = 1
        Me.RadioButtonSell.Text = "Sell"
        Me.RadioButtonSell.UseVisualStyleBackColor = True
        '
        'TextBoxBuySellPrice
        '
        Me.TextBoxBuySellPrice.Location = New System.Drawing.Point(148, 62)
        Me.TextBoxBuySellPrice.Name = "TextBoxBuySellPrice"
        Me.TextBoxBuySellPrice.ReadOnly = True
        Me.TextBoxBuySellPrice.Size = New System.Drawing.Size(91, 20)
        Me.TextBoxBuySellPrice.TabIndex = 4
        '
        'BuySellDropDown
        '
        Me.BuySellDropDown.FormattingEnabled = True
        Me.BuySellDropDown.Items.AddRange(New Object() {"Apple (AAPL)", "Google (GOOGL)"})
        Me.BuySellDropDown.Location = New System.Drawing.Point(9, 62)
        Me.BuySellDropDown.Name = "BuySellDropDown"
        Me.BuySellDropDown.Size = New System.Drawing.Size(121, 21)
        Me.BuySellDropDown.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stock:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(145, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Price:"
        '
        'ButtonBuySell
        '
        Me.ButtonBuySell.Location = New System.Drawing.Point(9, 102)
        Me.ButtonBuySell.Name = "ButtonBuySell"
        Me.ButtonBuySell.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuySell.TabIndex = 10
        Me.ButtonBuySell.Text = "Buy"
        Me.ButtonBuySell.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonBuySellQuantityAll)
        Me.GroupBox2.Controls.Add(Me.TextBoxBuySellQuantity)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ButtonBuySell)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.BuySellDropDown)
        Me.GroupBox2.Controls.Add(Me.TextBoxBuySellPrice)
        Me.GroupBox2.Controls.Add(Me.RadioButtonSell)
        Me.GroupBox2.Controls.Add(Me.RadioButtonBuy)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(517, 375)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buy/Sell"
        '
        'ButtonBuySellQuantityAll
        '
        Me.ButtonBuySellQuantityAll.Location = New System.Drawing.Point(376, 58)
        Me.ButtonBuySellQuantityAll.Name = "ButtonBuySellQuantityAll"
        Me.ButtonBuySellQuantityAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuySellQuantityAll.TabIndex = 13
        Me.ButtonBuySellQuantityAll.Text = "All"
        Me.ButtonBuySellQuantityAll.UseVisualStyleBackColor = True
        '
        'TextBoxBuySellQuantity
        '
        Me.TextBoxBuySellQuantity.Location = New System.Drawing.Point(269, 62)
        Me.TextBoxBuySellQuantity.Name = "TextBoxBuySellQuantity"
        Me.TextBoxBuySellQuantity.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBuySellQuantity.TabIndex = 12
        Me.TextBoxBuySellQuantity.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(266, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Quantity:"
        '
        'Timer1
        '
        '
        'LabelHistoryBuyOrSell
        '
        Me.LabelHistoryBuyOrSell.AutoSize = True
        Me.LabelHistoryBuyOrSell.Location = New System.Drawing.Point(6, 220)
        Me.LabelHistoryBuyOrSell.Name = "LabelHistoryBuyOrSell"
        Me.LabelHistoryBuyOrSell.Size = New System.Drawing.Size(53, 13)
        Me.LabelHistoryBuyOrSell.TabIndex = 14
        Me.LabelHistoryBuyOrSell.Text = "Buy/Sell: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Last Purchase Infomation:"
        '
        'LabelHistorySharePrice
        '
        Me.LabelHistorySharePrice.AutoSize = True
        Me.LabelHistorySharePrice.Location = New System.Drawing.Point(6, 243)
        Me.LabelHistorySharePrice.Name = "LabelHistorySharePrice"
        Me.LabelHistorySharePrice.Size = New System.Drawing.Size(65, 13)
        Me.LabelHistorySharePrice.TabIndex = 16
        Me.LabelHistorySharePrice.Text = "Share Price:"
        '
        'LabelHistoryQuantity
        '
        Me.LabelHistoryQuantity.AutoSize = True
        Me.LabelHistoryQuantity.Location = New System.Drawing.Point(6, 267)
        Me.LabelHistoryQuantity.Name = "LabelHistoryQuantity"
        Me.LabelHistoryQuantity.Size = New System.Drawing.Size(103, 13)
        Me.LabelHistoryQuantity.TabIndex = 17
        Me.LabelHistoryQuantity.Text = "Quantity Purchased:"
        '
        'LabelHistoryBrokerageFee
        '
        Me.LabelHistoryBrokerageFee.AutoSize = True
        Me.LabelHistoryBrokerageFee.Location = New System.Drawing.Point(9, 294)
        Me.LabelHistoryBrokerageFee.Name = "LabelHistoryBrokerageFee"
        Me.LabelHistoryBrokerageFee.Size = New System.Drawing.Size(80, 13)
        Me.LabelHistoryBrokerageFee.TabIndex = 18
        Me.LabelHistoryBrokerageFee.Text = "Brokerage Fee:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 452)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Stock Market Simulator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxSharesAvailable As TextBox
    Friend WithEvents TextBoxSharesOwned As TextBox
    Friend WithEvents InfoDropdownStock As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxFunds As TextBox
    Friend WithEvents RadioButtonBuy As RadioButton
    Friend WithEvents RadioButtonSell As RadioButton
    Friend WithEvents TextBoxBuySellPrice As TextBox
    Friend WithEvents BuySellDropDown As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonBuySell As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxBuySellQuantity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxValueOfShares As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxMarketCap As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ButtonBuySellQuantityAll As Button
    Friend WithEvents LabelHistoryBrokerageFee As Label
    Friend WithEvents LabelHistoryQuantity As Label
    Friend WithEvents LabelHistorySharePrice As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelHistoryBuyOrSell As Label
End Class
