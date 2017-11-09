<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDaysOnTrip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHotelCost = New System.Windows.Forms.TextBox()
        Me.txtAirfare = New System.Windows.Forms.TextBox()
        Me.txtParkingAmount = New System.Windows.Forms.TextBox()
        Me.txtMealAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblReimbursementTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Days on Trip"
        '
        'txtDaysOnTrip
        '
        Me.txtDaysOnTrip.Location = New System.Drawing.Point(156, 30)
        Me.txtDaysOnTrip.Name = "txtDaysOnTrip"
        Me.txtDaysOnTrip.Size = New System.Drawing.Size(100, 20)
        Me.txtDaysOnTrip.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Cost of Hotel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Airfare"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Amount of Parking"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Amount for Meals"
        '
        'txtHotelCost
        '
        Me.txtHotelCost.Location = New System.Drawing.Point(156, 76)
        Me.txtHotelCost.Name = "txtHotelCost"
        Me.txtHotelCost.Size = New System.Drawing.Size(100, 20)
        Me.txtHotelCost.TabIndex = 6
        '
        'txtAirfare
        '
        Me.txtAirfare.Location = New System.Drawing.Point(156, 124)
        Me.txtAirfare.Name = "txtAirfare"
        Me.txtAirfare.Size = New System.Drawing.Size(100, 20)
        Me.txtAirfare.TabIndex = 7
        '
        'txtParkingAmount
        '
        Me.txtParkingAmount.Location = New System.Drawing.Point(156, 168)
        Me.txtParkingAmount.Name = "txtParkingAmount"
        Me.txtParkingAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtParkingAmount.TabIndex = 8
        '
        'txtMealAmount
        '
        Me.txtMealAmount.Location = New System.Drawing.Point(156, 212)
        Me.txtMealAmount.Name = "txtMealAmount"
        Me.txtMealAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtMealAmount.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Reimbursement"
        '
        'lblReimbursementTotal
        '
        Me.lblReimbursementTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReimbursementTotal.Location = New System.Drawing.Point(156, 254)
        Me.lblReimbursementTotal.Name = "lblReimbursementTotal"
        Me.lblReimbursementTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblReimbursementTotal.TabIndex = 11
        Me.lblReimbursementTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(29, 303)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(128, 303)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(226, 303)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 352)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblReimbursementTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMealAmount)
        Me.Controls.Add(Me.txtParkingAmount)
        Me.Controls.Add(Me.txtAirfare)
        Me.Controls.Add(Me.txtHotelCost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDaysOnTrip)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Travel Expenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDaysOnTrip As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHotelCost As TextBox
    Friend WithEvents txtAirfare As TextBox
    Friend WithEvents txtParkingAmount As TextBox
    Friend WithEvents txtMealAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblReimbursementTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
