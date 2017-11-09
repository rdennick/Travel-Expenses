'*****************************************************************
'Ryan Dennick
'11/01/2017
'Travel Expenses
'Travel expenses takes in five inputs: number of days on the trip
'hotel per day cost, airfare, parking amount from the trip and
'meal amount for the trip.  Travel expenses has one output: total
'reimbursement for the trip. Reimbursements are limited to 95 per
'day on hotels, 10 per day on parking and 37 per day for meals.
'If inputs are less than reimbursement caps, employee will be 
'reimbursed the amount entered times the amount of days on the trip
'*****************************************************************

Option Strict On

Public Class Form1


    Structure Numbers
        Dim intDaysOnTrip As Integer
        Dim dblHotelCost As Double
        Dim dblAirfare As Double
        Dim dblParkingAmount As Double
        Dim dblMealAmount As Double
    End Structure

    Dim blnOK As Boolean = True

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Create local variables
        Dim Number As Numbers
        Dim dblTotalReimbursement As Double

        txtDaysOnTrip.BackColor = Color.White
        txtHotelCost.BackColor = Color.White
        txtAirfare.BackColor = Color.White
        txtParkingAmount.BackColor = Color.White
        txtMealAmount.BackColor = Color.White

        Try
            'Validate inputs
            Validation(Number)

            'Check validations
            If blnOK = True Then

                'Calculate total reimbursement for trip
                dblTotalReimbursement = CalcLodging(Number) + CalcParkingFees(Number) + CalcMeals(Number)
                'Display output
                Display(dblTotalReimbursement.ToString("c"))
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Function CalcLodging(ByVal Nums As Numbers) As Double

        'Create function to calculate hotel reimbursement

        'Create per day cost and hotel reimbursement variables
        Dim dblPerDayCost As Double
        Dim dblHotelReimbursement As Double
        'Create hotel reimbursement constant
        Const intHotelReimbursementDailyAmount As Integer = 95

        dblPerDayCost = Nums.dblHotelCost / Nums.intDaysOnTrip

        If dblPerDayCost <= intHotelReimbursementDailyAmount Then
            dblHotelReimbursement = dblPerDayCost * Nums.intDaysOnTrip
        Else
            dblHotelReimbursement = intHotelReimbursementDailyAmount * Nums.intDaysOnTrip
        End If

        Return dblHotelReimbursement

    End Function

    Private Function CalcParkingFees(ByVal Nums As Numbers) As Double

        'Create function to calculate parking reimbursement

        'Create per day cost and parking reimbursement variables
        Dim dblPerDayCost As Double
        Dim dblParkingReimbursement As Double
        'Create parking reimbursement constant
        Const intParkingReimbursementDailyAmount As Integer = 10

        dblPerDayCost = Nums.dblParkingAmount / Nums.intDaysOnTrip

        If dblPerDayCost <= intParkingReimbursementDailyAmount Then
            dblParkingReimbursement = dblPerDayCost * Nums.intDaysOnTrip
        Else
            dblParkingReimbursement = intParkingReimbursementDailyAmount * Nums.intDaysOnTrip
        End If

        Return dblParkingReimbursement

    End Function


    Private Function CalcMeals(ByVal Nums As Numbers) As Double

        'Create function to calculate meal reimbursement

        'Create per day cost and meal reimbursement variables
        Dim dblPerDayCost As Double
        Dim dblMealReimbursement As Double
        'Create meal reimbursement constant
        Const dblMealReimbursementDailyAmount As Double = 37

        dblPerDayCost = Nums.dblMealAmount / Nums.intDaysOnTrip

        If dblPerDayCost <= dblMealReimbursementDailyAmount Then
            dblMealReimbursement = dblPerDayCost * Nums.intDaysOnTrip
        Else
            dblMealReimbursement = dblMealReimbursementDailyAmount * Nums.intDaysOnTrip
        End If

        Return dblMealReimbursement


    End Function

    Private Sub Display(ByVal Output As String)

        'Display the output for the application
        lblReimbursementTotal.Text = Output

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear input and output controls
        ResetDaysOnTrip()
        ResetHotelCost()
        ResetAirfare()
        ResetParkingAmount()
        ResetMealAmount()
        ResetReimbursementAmount()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Exits application
        Me.Close()

    End Sub

    Private Sub Validation(ByRef Number As Numbers)

        'Validate inputs
        If IsNumeric(txtDaysOnTrip.Text) Then
            Number.intDaysOnTrip = CInt(txtDaysOnTrip.Text)
        Else
            MessageBox.Show("Please enter numeric values only for number of days on trip")
            txtDaysOnTrip.Focus()
            txtDaysOnTrip.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        If Number.intDaysOnTrip < 1 Then
            MessageBox.Show("Please enter at least one for days on trip")
            txtDaysOnTrip.Focus()
            txtDaysOnTrip.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        If IsNumeric(txtHotelCost.Text) Then
            Number.dblHotelCost = CDbl(txtHotelCost.Text)
        Else
            MessageBox.Show("Please enter numeric values only for hotel cost")
            txtHotelCost.Focus()
            txtHotelCost.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        If Number.dblHotelCost < 0 Then
            MessageBox.Show("Please enter a value greater than zero for hotel cost")
            txtHotelCost.Focus()
            txtHotelCost.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        If IsNumeric(txtAirfare.Text) Then
            Number.dblAirfare = CDbl(txtAirfare.Text)
        Else
            MessageBox.Show("Please enter numeric values only for hotel cost")
            txtAirfare.Focus()
            txtAirfare.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        If Number.dblAirfare < 0 Then
            MessageBox.Show("Please enter a value greater than zero for airfare cost")
            txtAirfare.Focus()
            txtAirfare.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        If IsNumeric(txtParkingAmount.Text) Then
            Number.dblParkingAmount = CDbl(txtParkingAmount.Text)
        Else
            MessageBox.Show("Please enter numeric values only for parking cost")
            txtParkingAmount.Focus()
            txtParkingAmount.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        If Number.dblParkingAmount < 0 Then
            MessageBox.Show("Please enter a value greater than zero for parking cost")
            txtParkingAmount.Focus()
            txtParkingAmount.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        If IsNumeric(txtMealAmount.Text) Then
            Number.dblMealAmount = CDbl(txtMealAmount.Text)
        Else
            MessageBox.Show("Please enter numeric values only for meal cost")
            txtMealAmount.Focus()
            txtMealAmount.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        If Number.dblMealAmount < 0 Then
            MessageBox.Show("Please enter a value greater than zero for meal cost")
            txtMealAmount.Focus()
            txtMealAmount.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        blnOK = True

    End Sub

    Private Sub ResetDaysOnTrip()

        'Reset days spent on trip
        txtDaysOnTrip.Text = String.Empty

    End Sub

    Private Sub ResetHotelCost()

        'Reset hotel cost per day
        txtHotelCost.Text = String.Empty

    End Sub

    Private Sub ResetAirfare()

        'Reset airfare cost
        txtAirfare.Text = String.Empty

    End Sub

    Private Sub ResetParkingAmount()

        'Reset parking amount
        txtParkingAmount.Text = String.Empty

    End Sub

    Private Sub ResetMealAmount()

        'Reset meal amount
        txtMealAmount.Text = String.Empty

    End Sub

    Private Sub ResetReimbursementAmount()

        'Reset reimbursement label
        lblReimbursementTotal.Text = String.Empty

    End Sub
End Class
