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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.chkOverTenYears = New System.Windows.Forms.CheckBox()
        Me.chkTravelling = New System.Windows.Forms.CheckBox()
        Me.lblCommissions = New System.Windows.Forms.Label()
        Me.lblAdditionalAmount = New System.Windows.Forms.Label()
        Me.lblTotalCommiss = New System.Windows.Forms.Label()
        Me.btnIfThen = New System.Windows.Forms.Button()
        Me.btnNestedIf = New System.Windows.Forms.Button()
        Me.btnIfElseIF = New System.Windows.Forms.Button()
        Me.btnSelectCase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(356, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 243)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission calculations"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(136, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "$700"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(136, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "$500"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Travelling"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "> 10 years"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Additional amounts"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(135, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "$3,120 + 14% of sales > 30,000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "> 30,000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(135, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "$120 + 13% of sales > 6,000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "6,000 - 29,999.99"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(136, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "10% of sales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "1 - 5,999.99"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(139, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Commissions"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sales ($)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Commissions only:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 188)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Additional amount:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(19, 255)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Total commission:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(15, 25)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(93, 20)
        Me.txtSales.TabIndex = 7
        '
        'chkOverTenYears
        '
        Me.chkOverTenYears.AutoSize = True
        Me.chkOverTenYears.Location = New System.Drawing.Point(15, 61)
        Me.chkOverTenYears.Name = "chkOverTenYears"
        Me.chkOverTenYears.Size = New System.Drawing.Size(77, 17)
        Me.chkOverTenYears.TabIndex = 8
        Me.chkOverTenYears.Text = "> 10 Years"
        Me.chkOverTenYears.UseVisualStyleBackColor = True
        '
        'chkTravelling
        '
        Me.chkTravelling.AutoSize = True
        Me.chkTravelling.Location = New System.Drawing.Point(15, 84)
        Me.chkTravelling.Name = "chkTravelling"
        Me.chkTravelling.Size = New System.Drawing.Size(70, 17)
        Me.chkTravelling.TabIndex = 9
        Me.chkTravelling.Text = "Traveling"
        Me.chkTravelling.UseVisualStyleBackColor = True
        '
        'lblCommissions
        '
        Me.lblCommissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommissions.Location = New System.Drawing.Point(15, 142)
        Me.lblCommissions.Name = "lblCommissions"
        Me.lblCommissions.Size = New System.Drawing.Size(124, 26)
        Me.lblCommissions.TabIndex = 10
        '
        'lblAdditionalAmount
        '
        Me.lblAdditionalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditionalAmount.Location = New System.Drawing.Point(15, 211)
        Me.lblAdditionalAmount.Name = "lblAdditionalAmount"
        Me.lblAdditionalAmount.Size = New System.Drawing.Size(124, 26)
        Me.lblAdditionalAmount.TabIndex = 11
        '
        'lblTotalCommiss
        '
        Me.lblTotalCommiss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCommiss.Location = New System.Drawing.Point(15, 278)
        Me.lblTotalCommiss.Name = "lblTotalCommiss"
        Me.lblTotalCommiss.Size = New System.Drawing.Size(124, 26)
        Me.lblTotalCommiss.TabIndex = 12
        '
        'btnIfThen
        '
        Me.btnIfThen.Location = New System.Drawing.Point(192, 34)
        Me.btnIfThen.Name = "btnIfThen"
        Me.btnIfThen.Size = New System.Drawing.Size(108, 30)
        Me.btnIfThen.TabIndex = 13
        Me.btnIfThen.Text = "If Then"
        Me.btnIfThen.UseVisualStyleBackColor = True
        '
        'btnNestedIf
        '
        Me.btnNestedIf.Location = New System.Drawing.Point(192, 71)
        Me.btnNestedIf.Name = "btnNestedIf"
        Me.btnNestedIf.Size = New System.Drawing.Size(108, 30)
        Me.btnNestedIf.TabIndex = 14
        Me.btnNestedIf.Text = "Nested If"
        Me.btnNestedIf.UseVisualStyleBackColor = True
        '
        'btnIfElseIF
        '
        Me.btnIfElseIF.Location = New System.Drawing.Point(192, 107)
        Me.btnIfElseIF.Name = "btnIfElseIF"
        Me.btnIfElseIF.Size = New System.Drawing.Size(108, 30)
        Me.btnIfElseIF.TabIndex = 15
        Me.btnIfElseIF.Text = "If ElseIf"
        Me.btnIfElseIF.UseVisualStyleBackColor = True
        '
        'btnSelectCase
        '
        Me.btnSelectCase.Location = New System.Drawing.Point(192, 143)
        Me.btnSelectCase.Name = "btnSelectCase"
        Me.btnSelectCase.Size = New System.Drawing.Size(108, 30)
        Me.btnSelectCase.TabIndex = 16
        Me.btnSelectCase.Text = "Select Case"
        Me.btnSelectCase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(192, 179)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 30)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 333)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelectCase)
        Me.Controls.Add(Me.btnIfElseIF)
        Me.Controls.Add(Me.btnNestedIf)
        Me.Controls.Add(Me.btnIfThen)
        Me.Controls.Add(Me.lblTotalCommiss)
        Me.Controls.Add(Me.lblAdditionalAmount)
        Me.Controls.Add(Me.lblCommissions)
        Me.Controls.Add(Me.chkTravelling)
        Me.Controls.Add(Me.chkOverTenYears)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Ckasper2h1 Marshall Sales Commission"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents chkOverTenYears As CheckBox
    Friend WithEvents chkTravelling As CheckBox
    Friend WithEvents lblCommissions As Label
    Friend WithEvents lblAdditionalAmount As Label
    Friend WithEvents lblTotalCommiss As Label
    Friend WithEvents btnIfThen As Button
    Friend WithEvents btnNestedIf As Button
    Friend WithEvents btnIfElseIF As Button
    Friend WithEvents btnSelectCase As Button
    Friend WithEvents btnExit As Button
End Class
