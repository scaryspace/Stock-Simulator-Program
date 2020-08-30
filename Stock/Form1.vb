Public Class Form1

    Dim Total_stocks_GOOGL, Stocks_Owned_GOOGL, Stocks_Owned_AAPL, Total_stocks_AAPL, BrokerageFee As Decimal
    Dim Google, Apple As String
    Dim BuyOrSell As String
    Dim AAPL_Cost As Integer
    Dim GOOGL_Cost As Integer
    Dim CostWithQuantity As Integer

    Private Sub ButtonBuySell_Click(sender As Object, e As EventArgs) Handles ButtonBuySell.Click

        REM This is where I will add the brokerage fee, using an If statement.
        If RadioButtonBuy.Checked = True And RadioButtonSell.Checked = False Then
            If TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 1000 Then
                BrokerageFee = 10
            ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 1000 AndAlso TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 10000 Then
                BrokerageFee = 19.95
            ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 10000 AndAlso TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 25000 Then
                BrokerageFee = 29.95
            ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 25000 Then
                BrokerageFee = (TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text) * 0.12
            End If
        End If
        REM $10.00 (Up to and including $1,000)

        REM $19.95 (Over $1,000 up to $10,000)

        REM $29.95 (Over $10,000 up to $25,000)

        REM 0.12% (Over $25,000)

        REM This will determine if the user is buying/selling and will Add/Remove the Shares/Money.
        If RadioButtonBuy.Checked <> True Or RadioButtonSell.Checked <> False Then Return
        If BuySellDropDown.SelectedItem = Apple Then
            If (AAPL_Cost * TextBoxBuySellQuantity.Text + BrokerageFee) <= TextBoxFunds.Text Then
                Total_stocks_AAPL = Total_stocks_AAPL - TextBoxBuySellQuantity.Text
                Stocks_Owned_AAPL = Stocks_Owned_AAPL + TextBoxBuySellQuantity.Text
                TextBoxFunds.Text = TextBoxFunds.Text - (AAPL_Cost * TextBoxBuySellQuantity.Text) - BrokerageFee
            Else MsgBox("Insufficient funds", "0", "Order Error")
            End If
        ElseIf BuySellDropDown.SelectedItem = Google Then
            If (GOOGL_Cost * TextBoxBuySellQuantity.Text + BrokerageFee) <= TextBoxFunds.Text Then
                Total_stocks_GOOGL = Total_stocks_GOOGL - TextBoxBuySellQuantity.Text
                Stocks_Owned_GOOGL = Stocks_Owned_GOOGL + TextBoxBuySellQuantity.Text
                TextBoxFunds.Text = TextBoxFunds.Text - (GOOGL_Cost * TextBoxBuySellQuantity.Text) - BrokerageFee
            Else MsgBox("Insufficient funds", "0", "Order Error")
            End If
        ElseIf BuySellDropDown.SelectedItem = Apple AndAlso Stocks_Owned_AAPL >= TextBoxBuySellQuantity.Text Then
            Total_stocks_AAPL = Total_stocks_AAPL + TextBoxBuySellQuantity.Text
            Stocks_Owned_AAPL = Stocks_Owned_AAPL - TextBoxBuySellQuantity.Text
            TextBoxFunds.Text = TextBoxFunds.Text + AAPL_Cost * TextBoxBuySellQuantity.Text
        ElseIf BuySellDropDown.SelectedItem = Google AndAlso Stocks_Owned_GOOGL >= TextBoxBuySellQuantity.Text Then
            Total_stocks_GOOGL = Total_stocks_GOOGL + TextBoxBuySellQuantity.Text
            Stocks_Owned_GOOGL = Stocks_Owned_GOOGL - TextBoxBuySellQuantity.Text
            TextBoxFunds.Text = TextBoxFunds.Text + GOOGL_Cost * TextBoxBuySellQuantity.Text
        End If

        REM This will set the info to the right amount
        If InfoDropdownStock.SelectedItem = Google Then
            TextBoxSharesAvailable.Text = Total_stocks_GOOGL
            TextBoxSharesOwned.Text = Stocks_Owned_GOOGL
            TextBoxValueOfShares.Text = GOOGL_Cost * Stocks_Owned_GOOGL
        ElseIf InfoDropdownStock.SelectedItem = Apple Then
            TextBoxSharesAvailable.Text = Total_stocks_AAPL
            TextBoxSharesOwned.Text = Stocks_Owned_AAPL
            TextBoxValueOfShares.Text = AAPL_Cost * Stocks_Owned_GOOGL
        End If
    End Sub

    Private Sub BuySellDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BuySellDropDown.SelectedIndexChanged
        If BuySellDropDown.SelectedItem = Apple Then
            TextBoxBuySellPrice.Text = AAPL_Cost
        ElseIf BuySellDropDown.SelectedItem = Google Then
            TextBoxBuySellPrice.Text = GOOGL_Cost
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM Prices and such on the specific shares
        Total_stocks_GOOGL = 1000
        Stocks_Owned_GOOGL = 0
        Total_stocks_AAPL = 2000
        Stocks_Owned_AAPL = 0
        GOOGL_Cost = 1000
        AAPL_Cost = 250
        TextBoxFunds.Text = 100000
        TextBoxValueOfShares.Text = 0
        Google = "Google (GOOGL)"
        Apple = "Apple (AAPL)"
    End Sub

    Private Sub InfoDropdownStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InfoDropdownStock.SelectedIndexChanged
        If InfoDropdownStock.SelectedItem = Google Then
            TextBoxSharesAvailable.Text = Total_stocks_GOOGL
            TextBoxSharesOwned.Text = Stocks_Owned_GOOGL
            TextBoxMarketCap.Text = (Stocks_Owned_GOOGL + Total_stocks_GOOGL) * GOOGL_Cost

        ElseIf InfoDropdownStock.SelectedItem = Apple Then
            TextBoxSharesAvailable.Text = Total_stocks_AAPL
            TextBoxSharesOwned.Text = Stocks_Owned_AAPL
            TextBoxMarketCap.Text = (Stocks_Owned_AAPL + Total_stocks_AAPL) * AAPL_Cost
        End If
    End Sub

    Private Sub RadioButtonBuy_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBuy.CheckedChanged
        If RadioButtonBuy.Checked = True And RadioButtonSell.Checked = False Then
            ButtonBuySell.Text = "Buy"
        Else ButtonBuySell.Text = "Sell"
        End If
    End Sub
End Class
