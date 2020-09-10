Public Class Form1

    Dim Total_stocks_GOOGL, Stocks_Owned_GOOGL, Stocks_Owned_AAPL, Total_stocks_AAPL, BrokerageFee As Decimal
    Dim Google, Apple As String
    Dim BuyOrSell As String
    Dim AAPL_Cost As Decimal
    Dim GOOGL_Cost As Decimal
    Dim CostWithQuantity As Integer
    Function RefreshBuySellPrices () As String
        If BuySellDropDown.SelectedItem = Apple Then
            TextBoxBuySellPrice.Text = AAPL_Cost
        ElseIf BuySellDropDown.SelectedItem = Google Then
            TextBoxBuySellPrice.Text = GOOGL_Cost
        End If
    End Function
    
    Function RefreshInfoPanel () As String
        If InfoDropdownStock.SelectedItem = Google Then
            TextBoxSharesAvailable.Text = Total_stocks_GOOGL
            TextBoxSharesOwned.Text = Stocks_Owned_GOOGL
            TextBoxValueOfShares.Text = GOOGL_Cost * Stocks_Owned_GOOGL
            TextBoxMarketCap.Text = (Stocks_Owned_GOOGL + Total_stocks_GOOGL) * GOOGL_Cost
        ElseIf InfoDropdownStock.SelectedItem = Apple Then
            TextBoxSharesAvailable.Text = Total_stocks_AAPL
            TextBoxSharesOwned.Text = Stocks_Owned_AAPL
            TextBoxValueOfShares.Text = AAPL_Cost * Stocks_Owned_GOOGL
            TextBoxMarketCap.Text = (Stocks_Owned_AAPL + Total_stocks_AAPL) * AAPL_Cost
        End If
    End Function
    Function RandomizePrice () As String

        GOOGL_Cost = (Math.Ceiling(Rnd() * 1600)) + 700
        Randomize()
        AAPL_Cost = (Math.Ceiling(Rnd() * 500)) + 250
    End Function
    
    Function RandomizeTimerInterval() As String
        Randomize()
        Timer1.Interval = (Math.Ceiling(Rnd() * 10000)) + 1750
    End Function
    

    Private Sub ButtonBuySell_Click(sender As Object, e As EventArgs) Handles ButtonBuySell.Click

        REM This is where I will add the brokerage fee, using an If statement.
            If TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 1000 Then
                BrokerageFee = 10
            ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 1000 AndAlso TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 10000 Then
                BrokerageFee = 19.95
            ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 10000 AndAlso TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 25000 Then
                BrokerageFee = 29.95
            ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 25000 Then
                BrokerageFee = (TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text) * 0.12
            End If
        
        REM $10.00 (Up to and including $1,000)

        REM $19.95 (Over $1,000 up to $10,000)

        REM $29.95 (Over $10,000 up to $25,000)

        REM 0.12% (Over $25,000)
        
        if RadioButtonBuy.Checked = True REM This is for BUYING
            
            If BuySellDropDown.SelectedItem = Apple Then REM Checks if You are Buying Apple
                If (AAPL_Cost * TextBoxBuySellQuantity.Text + BrokerageFee) <= TextBoxFunds.Text Then REM Checks if you have enough moneys
                    Total_stocks_AAPL = Total_stocks_AAPL - TextBoxBuySellQuantity.Text
                    Stocks_Owned_AAPL = Stocks_Owned_AAPL + TextBoxBuySellQuantity.Text
                    TextBoxFunds.Text = TextBoxFunds.Text - (AAPL_Cost * TextBoxBuySellQuantity.Text) - BrokerageFee
                Else MsgBox("Insufficient funds.", "0", "Order Error") REM Biggie error maker.
                End If
            Elseif BuySellDropDown.SelectedItem = Google Then REM Checks if you are buying Google
                if (GOOGL_Cost * TextBoxBuySellQuantity.Text + BrokerageFee) <= TextBoxFunds.Text Then
                    Total_stocks_GOOGL = Total_stocks_GOOGL - TextBoxBuySellQuantity.Text
                    Stocks_Owned_GOOGL = Stocks_Owned_GOOGL + TextBoxBuySellQuantity.Text
                    TextBoxFunds.Text = TextBoxFunds.Text - (GOOGL_Cost * TextBoxBuySellQuantity.Text) - BrokerageFee
                Else MsgBox("Insufficient funds.", "0", "Order Error")
                End If    
            End If
            
        ElseIf RadioButtonSell.Checked = True Then
                
                If BuySellDropDown.SelectedItem = Apple Then REM Checks if You are Selling Apple
                    If Stocks_Owned_AAPL >= TextBoxBuySellQuantity.Text andalso (AAPL_Cost * TextBoxBuySellQuantity.Text + TextBoxFunds.Text) >= BrokerageFee Then REM Checks if you have enough $
                        Total_stocks_AAPL = Total_stocks_AAPL + TextBoxBuySellQuantity.Text
                        Stocks_Owned_AAPL = Stocks_Owned_AAPL - TextBoxBuySellQuantity.Text
                        TextBoxFunds.Text = TextBoxFunds.Text + (AAPL_Cost * TextBoxBuySellQuantity.Text) - BrokerageFee
                    Else 
                        MsgBox("Insufficient Shares or Funds Owned.", "0", "Order Error") REM Biggie error maker.
                    End If
                ElseIf BuySellDropDown.SelectedItem = Google andalso (GOOGL_Cost * TextBoxBuySellQuantity.Text + TextBoxFunds.Text) >= BrokerageFee Then REM Checks if you are buying Google
                    if Stocks_Owned_GOOGL >= TextBoxBuySellQuantity.Text Then
                        Total_stocks_GOOGL = Total_stocks_GOOGL + TextBoxBuySellQuantity.Text
                        Stocks_Owned_GOOGL = Stocks_Owned_GOOGL - TextBoxBuySellQuantity.Text
                        TextBoxFunds.Text = TextBoxFunds.Text + (GOOGL_Cost * TextBoxBuySellQuantity.Text) - BrokerageFee
                    Else 
                        MsgBox("Insufficient Shares or Funds Owned.", "0", "Order Error")
                        
                    End If
                End If    
        End If
   
                    
                    
        RandomizePrice()

        
        REM This will set the info to the right amount
        RefreshInfoPanel()
    End Sub

    Private Sub ButtonBuySellQuantityAll_Click(sender As Object, e As EventArgs) Handles ButtonBuySellQuantityAll.Click
        
        if TextBoxBuySellPrice.Text > 0 Then 
            
            If TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 1000 Then
                BrokerageFee = 10
            ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 1000 AndAlso TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 10000 Then
                BrokerageFee = 19.95
            ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 10000 AndAlso TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 25000 Then
                BrokerageFee = 29.95
            ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 25000 Then
                BrokerageFee = (TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text) * 0.12
            End If
        
            if RadioButtonBuy.Checked = True then
                if BuySellDropDown.SelectedItem = Apple Then
                    TextBoxBuySellQuantity.Text = TextBoxFunds.Text / (AAPL_Cost + BrokerageFee)
                ElseIf BuySellDropDown.SelectedItem = Google Then
                    TextBoxBuySellQuantity.Text = TextBoxFunds.Text / (GOOGL_Cost + BrokerageFee)
                End If    
            Else    
                if BuySellDropDown.SelectedItem = Apple Then
                    TextBoxBuySellQuantity.Text = Stocks_Owned_AAPL
                ElseIf BuySellDropDown.SelectedItem = Google Then
                    TextBoxBuySellQuantity.Text = Stocks_Owned_GOOGL
                End If
            End If
            
        End If
        
        If TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 1000 Then
            BrokerageFee = 10
        ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 1000 AndAlso TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 10000 Then
            BrokerageFee = 19.95
        ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 10000 AndAlso TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text <= 25000 Then
            BrokerageFee = 29.95
        ElseIf TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text > 25000 Then
            BrokerageFee = (TextBoxBuySellQuantity.Text * TextBoxBuySellPrice.Text) * 0.12
        End If
        
        if RadioButtonBuy.Checked = True then
            if BuySellDropDown.SelectedItem = Apple Then
                TextBoxBuySellQuantity.Text = TextBoxFunds.Text / (AAPL_Cost + BrokerageFee)
            ElseIf BuySellDropDown.SelectedItem = Google Then
                TextBoxBuySellQuantity.Text = TextBoxFunds.Text / (GOOGL_Cost + BrokerageFee)
            End If    
        Else    
            if BuySellDropDown.SelectedItem = Apple Then
                TextBoxBuySellQuantity.Text = Stocks_Owned_AAPL
            ElseIf BuySellDropDown.SelectedItem = Google Then
                TextBoxBuySellQuantity.Text = Stocks_Owned_GOOGL
            End If
        End If

        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RandomizePrice()
        RefreshBuySellPrices()
        RefreshInfoPanel()
        RandomizeTimerInterval()
    End Sub

    Private Sub BuySellDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BuySellDropDown.SelectedIndexChanged
        REM Refreshes the price textbox
        If BuySellDropDown.SelectedItem = Apple Then
            TextBoxBuySellPrice.Text = AAPL_Cost
        ElseIf BuySellDropDown.SelectedItem = Google Then
            TextBoxBuySellPrice.Text = GOOGL_Cost
        End If
        
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM Prices and such on the specific shares
        TextBoxFunds.Text = 100000
        TextBoxValueOfShares.Text = 0
        Google = "Google (GOOGL)"
        Apple = "Apple (AAPL)"
        Total_stocks_GOOGL = 1000
        Stocks_Owned_GOOGL = 0
        Total_stocks_AAPL = 2000
        Stocks_Owned_AAPL = 0
        Timer1.Interval = 1000
        Timer1.Start()
        
        
        REM This will randomize the amounts.
        Randomize()
        GOOGL_Cost = (Math.Ceiling(Rnd() * 1600)) + 700
        Randomize()
        AAPL_Cost = (Math.Ceiling(Rnd() * 500)) + 250

    End Sub

    Private Sub InfoDropdownStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InfoDropdownStock.SelectedIndexChanged
    RefreshInfoPanel()
    End Sub

    Private Sub RadioButtonBuy_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBuy.CheckedChanged
        If RadioButtonBuy.Checked = True And RadioButtonSell.Checked = False Then
            ButtonBuySell.Text = "Buy"
        Else ButtonBuySell.Text = "Sell"
        End If
    End Sub
End Class
