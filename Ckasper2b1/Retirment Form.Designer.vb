<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Retirment_Form
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
        Me.nlblgross = New System.Windows.Forms.Label()
        Me.NlblEmployeeCont = New System.Windows.Forms.Label()
        Me.NlblEmployercont = New System.Windows.Forms.Label()
        Me.NlblEmployeeAnnual = New System.Windows.Forms.Label()
        Me.NlblEmployerAnn = New System.Windows.Forms.Label()
        Me.NlbltotalAnn = New System.Windows.Forms.Label()
        Me.txtGrosspay = New System.Windows.Forms.TextBox()
        Me.txtEmployeeCont = New System.Windows.Forms.TextBox()
        Me.txtEmployerCont = New System.Windows.Forms.TextBox()
        Me.lblEmployeeAnn = New System.Windows.Forms.Label()
        Me.lblEmployerAnn = New System.Windows.Forms.Label()
        Me.lblTotalAnn = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nlblgross
        '
        Me.nlblgross.AutoSize = True
        Me.nlblgross.Location = New System.Drawing.Point(12, 9)
        Me.nlblgross.Name = "nlblgross"
        Me.nlblgross.Size = New System.Drawing.Size(125, 20)
        Me.nlblgross.TabIndex = 0
        Me.nlblgross.Text = "&Gross weekly pay:"
        '
        'NlblEmployeeCont
        '
        Me.NlblEmployeeCont.AutoSize = True
        Me.NlblEmployeeCont.Location = New System.Drawing.Point(12, 42)
        Me.NlblEmployeeCont.Name = "NlblEmployeeCont"
        Me.NlblEmployeeCont.Size = New System.Drawing.Size(296, 20)
        Me.NlblEmployeeCont.TabIndex = 2
        Me.NlblEmployeeCont.Text = "&Employee contribution rate (decimal form):"
        '
        'NlblEmployercont
        '
        Me.NlblEmployercont.AutoSize = True
        Me.NlblEmployercont.Location = New System.Drawing.Point(12, 75)
        Me.NlblEmployercont.Name = "NlblEmployercont"
        Me.NlblEmployercont.Size = New System.Drawing.Size(293, 20)
        Me.NlblEmployercont.TabIndex = 4
        Me.NlblEmployercont.Text = "Employe&r contribution rate (decimal form):"
        '
        'NlblEmployeeAnnual
        '
        Me.NlblEmployeeAnnual.AutoSize = True
        Me.NlblEmployeeAnnual.Location = New System.Drawing.Point(12, 108)
        Me.NlblEmployeeAnnual.Name = "NlblEmployeeAnnual"
        Me.NlblEmployeeAnnual.Size = New System.Drawing.Size(211, 20)
        Me.NlblEmployeeAnnual.TabIndex = 6
        Me.NlblEmployeeAnnual.Text = "Employee annual contribution:"
        '
        'NlblEmployerAnn
        '
        Me.NlblEmployerAnn.AutoSize = True
        Me.NlblEmployerAnn.Location = New System.Drawing.Point(12, 145)
        Me.NlblEmployerAnn.Name = "NlblEmployerAnn"
        Me.NlblEmployerAnn.Size = New System.Drawing.Size(208, 20)
        Me.NlblEmployerAnn.TabIndex = 8
        Me.NlblEmployerAnn.Text = "Employer annual contribution:"
        '
        'NlbltotalAnn
        '
        Me.NlbltotalAnn.AutoSize = True
        Me.NlbltotalAnn.Location = New System.Drawing.Point(12, 183)
        Me.NlbltotalAnn.Name = "NlbltotalAnn"
        Me.NlbltotalAnn.Size = New System.Drawing.Size(175, 20)
        Me.NlbltotalAnn.TabIndex = 10
        Me.NlbltotalAnn.Text = "Total annual contribution"
        '
        'txtGrosspay
        '
        Me.txtGrosspay.Location = New System.Drawing.Point(301, 6)
        Me.txtGrosspay.Name = "txtGrosspay"
        Me.txtGrosspay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGrosspay.Size = New System.Drawing.Size(203, 27)
        Me.txtGrosspay.TabIndex = 1
        Me.txtGrosspay.Text = "1000"
        Me.txtGrosspay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployeeCont
        '
        Me.txtEmployeeCont.Location = New System.Drawing.Point(339, 39)
        Me.txtEmployeeCont.Name = "txtEmployeeCont"
        Me.txtEmployeeCont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmployeeCont.Size = New System.Drawing.Size(165, 27)
        Me.txtEmployeeCont.TabIndex = 3
        Me.txtEmployeeCont.Text = "0.05"
        Me.txtEmployeeCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployerCont
        '
        Me.txtEmployerCont.Location = New System.Drawing.Point(339, 72)
        Me.txtEmployerCont.Name = "txtEmployerCont"
        Me.txtEmployerCont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmployerCont.Size = New System.Drawing.Size(165, 27)
        Me.txtEmployerCont.TabIndex = 5
        Me.txtEmployerCont.Text = "0.07"
        Me.txtEmployerCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmployeeAnn
        '
        Me.lblEmployeeAnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeAnn.Location = New System.Drawing.Point(301, 107)
        Me.lblEmployeeAnn.Name = "lblEmployeeAnn"
        Me.lblEmployeeAnn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblEmployeeAnn.Size = New System.Drawing.Size(203, 27)
        Me.lblEmployeeAnn.TabIndex = 7
        '
        'lblEmployerAnn
        '
        Me.lblEmployerAnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployerAnn.Location = New System.Drawing.Point(301, 144)
        Me.lblEmployerAnn.Name = "lblEmployerAnn"
        Me.lblEmployerAnn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblEmployerAnn.Size = New System.Drawing.Size(203, 27)
        Me.lblEmployerAnn.TabIndex = 9
        '
        'lblTotalAnn
        '
        Me.lblTotalAnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAnn.Location = New System.Drawing.Point(269, 182)
        Me.lblTotalAnn.Name = "lblTotalAnn"
        Me.lblTotalAnn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotalAnn.Size = New System.Drawing.Size(235, 27)
        Me.lblTotalAnn.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(206, 236)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(146, 40)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(358, 236)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 40)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(54, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(146, 40)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Retirment_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 288)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalAnn)
        Me.Controls.Add(Me.lblEmployerAnn)
        Me.Controls.Add(Me.lblEmployeeAnn)
        Me.Controls.Add(Me.txtEmployerCont)
        Me.Controls.Add(Me.txtEmployeeCont)
        Me.Controls.Add(Me.txtGrosspay)
        Me.Controls.Add(Me.NlbltotalAnn)
        Me.Controls.Add(Me.NlblEmployerAnn)
        Me.Controls.Add(Me.NlblEmployeeAnnual)
        Me.Controls.Add(Me.NlblEmployercont)
        Me.Controls.Add(Me.NlblEmployeeCont)
        Me.Controls.Add(Me.nlblgross)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Retirment_Form"
        Me.Text = "Ckasper2b2 Retirment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nlblgross As Label
    Friend WithEvents NlblEmployeeCont As Label
    Friend WithEvents NlblEmployercont As Label
    Friend WithEvents NlblEmployeeAnnual As Label
    Friend WithEvents NlblEmployerAnn As Label
    Friend WithEvents NlbltotalAnn As Label
    Friend WithEvents txtGrosspay As TextBox
    Friend WithEvents txtEmployeeCont As TextBox
    Friend WithEvents txtEmployerCont As TextBox
    Friend WithEvents lblEmployeeAnn As Label
    Friend WithEvents lblEmployerAnn As Label
    Friend WithEvents lblTotalAnn As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
