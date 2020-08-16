Public Class Form1

    Dim Total_stocks_GOOGL, Stocks_Owned_GOOGL, Stocks_Owned_AAPL, Total_stocks_AAPL As Decimal
    Dim Google, Apple As String
    Dim BuyOrSell As String
    Dim AAPL_Cost As Integer
    Dim GOOGL_Cost As Integer
    Dim CostWithQuantity As Integer

    Private Sub ButtonBuySell_Click(sender As Object, e As EventArgs) Handles ButtonBuySell.Click
        If RadioButtonBuy.Checked = True And RadioButtonSell.Checked = False Then
            If BuySellDropDown.SelectedItem = Apple AndAlso AAPL_Cost * TextBoxBuySellQuantity.Text < TextBoxFunds.Text Then
                Total_stocks_AAPL = Total_stocks_AAPL - TextBoxBuySellQuantity.Text
                Stocks_Owned_AAPL = Stocks_Owned_AAPL + TextBoxBuySellQuantity.Text
                TextBoxFunds.Text = TextBoxFunds.Text - AAPL_Cost * TextBoxBuySellQuantity.Text
            ElseIf BuySellDropDown.SelectedItem = Google AndAlso GOOGL_Cost < TextBoxFunds.Text Then
                Total_stocks_GOOGL = Total_stocks_GOOGL - TextBoxBuySellQuantity.Text
                Stocks_Owned_GOOGL = Stocks_Owned_GOOGL + TextBoxBuySellQuantity.Text
                TextBoxFunds.Text = TextBoxFunds.Text - GOOGL_Cost * TextBoxBuySellQuantity.Text
            End If
        Else ButtonBuySell.Text = "Sell"
        End If
        REM This if will set the info to the right amount
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

        ElseIf InfoDropdownStock.SelectedItem = Apple Then
            TextBoxSharesAvailable.Text = Total_stocks_AAPL
            TextBoxSharesOwned.Text = Stocks_Owned_AAPL
        End If
    End Sub

    Private Sub RadioButtonBuy_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBuy.CheckedChanged
        If RadioButtonBuy.Checked = True And RadioButtonSell.Checked = False Then
            ButtonBuySell.Text = "Buy"
        Else ButtonBuySell.Text = "Sell"
        End If
    End Sub
End Class
