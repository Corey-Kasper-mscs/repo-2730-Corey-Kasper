<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radSubCentimeters = New System.Windows.Forms.RadioButton()
        Me.radSubInches = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMeasurement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radFuncCentimeters = New System.Windows.Forms.RadioButton()
        Me.radFuncInches = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblWeightTotal = New System.Windows.Forms.Label()
        Me.txtEarthsweight = New System.Windows.Forms.TextBox()
        Me.cobWeightOn = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radFunWeight = New System.Windows.Forms.RadioButton()
        Me.radSubWeight = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radSubCentimeters
        '
        Me.radSubCentimeters.Checked = True
        Me.radSubCentimeters.Location = New System.Drawing.Point(160, 25)
        Me.radSubCentimeters.Margin = New System.Windows.Forms.Padding(2)
        Me.radSubCentimeters.Name = "radSubCentimeters"
        Me.radSubCentimeters.Size = New System.Drawing.Size(215, 26)
        Me.radSubCentimeters.TabIndex = 5
        Me.radSubCentimeters.TabStop = True
        Me.radSubCentimeters.Text = "Sub: Inches to &Centimeters"
        '
        'radSubInches
        '
        Me.radSubInches.Location = New System.Drawing.Point(160, 58)
        Me.radSubInches.Margin = New System.Windows.Forms.Padding(2)
        Me.radSubInches.Name = "radSubInches"
        Me.radSubInches.Size = New System.Drawing.Size(215, 26)
        Me.radSubInches.TabIndex = 6
        Me.radSubInches.Text = "Sub: Centimeters to &Inches"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Measurement:"
        '
        'txtMeasurement
        '
        Me.txtMeasurement.Location = New System.Drawing.Point(26, 57)
        Me.txtMeasurement.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Size = New System.Drawing.Size(55, 27)
        Me.txtMeasurement.TabIndex = 1
        Me.txtMeasurement.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(26, 111)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(81, 30)
        Me.lblResult.TabIndex = 3
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(26, 143)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        '
        'radFuncCentimeters
        '
        Me.radFuncCentimeters.Location = New System.Drawing.Point(160, 88)
        Me.radFuncCentimeters.Margin = New System.Windows.Forms.Padding(2)
        Me.radFuncCentimeters.Name = "radFuncCentimeters"
        Me.radFuncCentimeters.Size = New System.Drawing.Size(215, 26)
        Me.radFuncCentimeters.TabIndex = 7
        Me.radFuncCentimeters.Text = "Func: Inches to &Centimeters"
        '
        'radFuncInches
        '
        Me.radFuncInches.Location = New System.Drawing.Point(160, 122)
        Me.radFuncInches.Margin = New System.Windows.Forms.Padding(2)
        Me.radFuncInches.Name = "radFuncInches"
        Me.radFuncInches.Size = New System.Drawing.Size(215, 26)
        Me.radFuncInches.TabIndex = 8
        Me.radFuncInches.Text = "Func: Centimeters to &Inches"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFuncInches)
        Me.GroupBox1.Controls.Add(Me.radFuncCentimeters)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMeasurement)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.radSubInches)
        Me.GroupBox1.Controls.Add(Me.radSubCentimeters)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 188)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p418 #15-16 Measurment Converter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Earth weight:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "&Weight on:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Calculate using:"
        '
        'lblWeightTotal
        '
        Me.lblWeightTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeightTotal.Location = New System.Drawing.Point(147, 104)
        Me.lblWeightTotal.Name = "lblWeightTotal"
        Me.lblWeightTotal.Size = New System.Drawing.Size(115, 32)
        Me.lblWeightTotal.TabIndex = 4
        '
        'txtEarthsweight
        '
        Me.txtEarthsweight.Location = New System.Drawing.Point(13, 55)
        Me.txtEarthsweight.Name = "txtEarthsweight"
        Me.txtEarthsweight.Size = New System.Drawing.Size(102, 27)
        Me.txtEarthsweight.TabIndex = 1
        Me.txtEarthsweight.Text = "100"
        '
        'cobWeightOn
        '
        Me.cobWeightOn.FormattingEnabled = True
        Me.cobWeightOn.Location = New System.Drawing.Point(147, 55)
        Me.cobWeightOn.Name = "cobWeightOn"
        Me.cobWeightOn.Size = New System.Drawing.Size(115, 28)
        Me.cobWeightOn.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radFunWeight)
        Me.GroupBox2.Controls.Add(Me.radSubWeight)
        Me.GroupBox2.Controls.Add(Me.cobWeightOn)
        Me.GroupBox2.Controls.Add(Me.txtEarthsweight)
        Me.GroupBox2.Controls.Add(Me.lblWeightTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 166)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p426-427 #4-6"
        '
        'radFunWeight
        '
        Me.radFunWeight.AutoSize = True
        Me.radFunWeight.Location = New System.Drawing.Point(292, 104)
        Me.radFunWeight.Name = "radFunWeight"
        Me.radFunWeight.Size = New System.Drawing.Size(83, 24)
        Me.radFunWeight.TabIndex = 7
        Me.radFunWeight.Text = "Function"
        Me.radFunWeight.UseVisualStyleBackColor = True
        '
        'radSubWeight
        '
        Me.radSubWeight.AutoSize = True
        Me.radSubWeight.Checked = True
        Me.radSubWeight.Location = New System.Drawing.Point(290, 59)
        Me.radSubWeight.Name = "radSubWeight"
        Me.radSubWeight.Size = New System.Drawing.Size(52, 24)
        Me.radSubWeight.TabIndex = 6
        Me.radSubWeight.TabStop = True
        Me.radSubWeight.Text = "Sub"
        Me.radSubWeight.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(182, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 438)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Measurement Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents radSubCentimeters As System.Windows.Forms.RadioButton
    Friend WithEvents radSubInches As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMeasurement As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radFuncCentimeters As RadioButton
    Friend WithEvents radFuncInches As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblWeightTotal As Label
    Friend WithEvents txtEarthsweight As TextBox
    Friend WithEvents cobWeightOn As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radFunWeight As RadioButton
    Friend WithEvents radSubWeight As RadioButton
    Friend WithEvents Button1 As Button
End Class
