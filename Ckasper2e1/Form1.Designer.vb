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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrderAmount = New System.Windows.Forms.TextBox()
        Me.txtYandN = New System.Windows.Forms.TextBox()
        Me.lblShippingCharge = New System.Windows.Forms.Label()
        Me.btnCalcAnd = New System.Windows.Forms.Button()
        Me.btnCalcOr = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.btnCalcEqual = New System.Windows.Forms.Button()
        Me.btnCalcNotEqual = New System.Windows.Forms.Button()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Order amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Free shipping orders over $100 with Savannah CC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Savannah (Y/N):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Shipping charge:"
        '
        'txtOrderAmount
        '
        Me.txtOrderAmount.Location = New System.Drawing.Point(12, 51)
        Me.txtOrderAmount.Name = "txtOrderAmount"
        Me.txtOrderAmount.Size = New System.Drawing.Size(74, 20)
        Me.txtOrderAmount.TabIndex = 4
        '
        'txtYandN
        '
        Me.txtYandN.Location = New System.Drawing.Point(92, 51)
        Me.txtYandN.Name = "txtYandN"
        Me.txtYandN.Size = New System.Drawing.Size(40, 20)
        Me.txtYandN.TabIndex = 5
        '
        'lblShippingCharge
        '
        Me.lblShippingCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShippingCharge.Location = New System.Drawing.Point(193, 53)
        Me.lblShippingCharge.Name = "lblShippingCharge"
        Me.lblShippingCharge.Size = New System.Drawing.Size(74, 20)
        Me.lblShippingCharge.TabIndex = 6
        '
        'btnCalcAnd
        '
        Me.btnCalcAnd.Location = New System.Drawing.Point(309, 35)
        Me.btnCalcAnd.Name = "btnCalcAnd"
        Me.btnCalcAnd.Size = New System.Drawing.Size(97, 20)
        Me.btnCalcAnd.TabIndex = 7
        Me.btnCalcAnd.Text = "Calculate (And)"
        Me.btnCalcAnd.UseVisualStyleBackColor = True
        '
        'btnCalcOr
        '
        Me.btnCalcOr.Location = New System.Drawing.Point(309, 61)
        Me.btnCalcOr.Name = "btnCalcOr"
        Me.btnCalcOr.Size = New System.Drawing.Size(97, 20)
        Me.btnCalcOr.TabIndex = 8
        Me.btnCalcOr.Text = "Calculate (Or)"
        Me.btnCalcOr.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "15% commissions for sales > 25000 with codes A1,B2,C3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Sales:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(202, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Commission:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(12, 229)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(40, 20)
        Me.txtID.TabIndex = 13
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(88, 229)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(92, 20)
        Me.txtSales.TabIndex = 14
        '
        'btnCalcEqual
        '
        Me.btnCalcEqual.Location = New System.Drawing.Point(309, 213)
        Me.btnCalcEqual.Name = "btnCalcEqual"
        Me.btnCalcEqual.Size = New System.Drawing.Size(97, 20)
        Me.btnCalcEqual.TabIndex = 16
        Me.btnCalcEqual.Text = "Calculate (=)"
        Me.btnCalcEqual.UseVisualStyleBackColor = True
        '
        'btnCalcNotEqual
        '
        Me.btnCalcNotEqual.Location = New System.Drawing.Point(309, 239)
        Me.btnCalcNotEqual.Name = "btnCalcNotEqual"
        Me.btnCalcNotEqual.Size = New System.Drawing.Size(97, 20)
        Me.btnCalcNotEqual.TabIndex = 17
        Me.btnCalcNotEqual.Text = "Calculate (<>)"
        Me.btnCalcNotEqual.UseVisualStyleBackColor = True
        '
        'lblComm
        '
        Me.lblComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComm.Location = New System.Drawing.Point(201, 229)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(74, 20)
        Me.lblComm.TabIndex = 18
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 20)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 411)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblComm)
        Me.Controls.Add(Me.btnCalcNotEqual)
        Me.Controls.Add(Me.btnCalcEqual)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCalcOr)
        Me.Controls.Add(Me.btnCalcAnd)
        Me.Controls.Add(Me.lblShippingCharge)
        Me.Controls.Add(Me.txtYandN)
        Me.Controls.Add(Me.txtOrderAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Ckasper2e1 AndAlso, OrElse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOrderAmount As TextBox
    Friend WithEvents txtYandN As TextBox
    Friend WithEvents lblShippingCharge As Label
    Friend WithEvents btnCalcAnd As Button
    Friend WithEvents btnCalcOr As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtSales As TextBox
    Friend WithEvents btnCalcEqual As Button
    Friend WithEvents btnCalcNotEqual As Button
    Friend WithEvents lblComm As Label
    Friend WithEvents btnExit As Button
End Class
