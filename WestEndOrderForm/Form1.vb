Public Class frmWestEndOrderx

    ' Class level constants as decimal values
    Const TAX_RATE As Decimal = 0.0875D '8.75% tax rate

    Const PRICE_RIBEYE_SANDWICH As Decimal = 7.5D
    Const PRICE_LOBSTER As Decimal = 22D
    Const PRICE_HOKIE_CLUB As Decimal = 6.5D
    Const PRICE_PUB_BURGER As Decimal = 5D

    Const PRICE_CHEESE As Decimal = 0.5D
    Const PRICE_TOMATO As Decimal = 0.2D

    Const PRICE_WATER As Decimal = 0.05D
    Const PRICE_SODA As Decimal = 1.25D
    Const PRICE_JUICE As Decimal = 1D
    Const PRICE_SMOOTHIE As Decimal = 2.5D

    Const PRICE_FRENCH_FRIES As Decimal = 1.5D
    Const PRICE_MOZZARELLA_STICKS As Decimal = 3D

    'Class level variables
    Dim subtotal As Decimal
    Dim tax As Decimal
    Dim total As Decimal

   
        UpdateTotal()
        ClearCustomerSelections()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        InitializeVariables()
        ClearCustomerSelections()
        ClearReceipt()
        MsgBox("Trey's version")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

    End Sub
End Class
