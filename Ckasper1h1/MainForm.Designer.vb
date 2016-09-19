<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblPayrate = New System.Windows.Forms.Label()
        Me.TxtHours = New System.Windows.Forms.TextBox()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblFwt = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblGrosstxt = New System.Windows.Forms.Label()
        Me.lblFWTtxt = New System.Windows.Forms.Label()
        Me.lblFicaTxt = New System.Windows.Forms.Label()
        Me.LblStateTxt = New System.Windows.Forms.Label()
        Me.lblNetTxt = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(164, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(268, 27)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(106, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "&Name:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(107, 69)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(51, 20)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "&Hours:"
        '
        'lblPayrate
        '
        Me.lblPayrate.AutoSize = True
        Me.lblPayrate.Location = New System.Drawing.Point(270, 69)
        Me.lblPayrate.Name = "lblPayrate"
        Me.lblPayrate.Size = New System.Drawing.Size(68, 20)
        Me.lblPayrate.TabIndex = 4
        Me.lblPayrate.Text = "Pay &Rate:"
        '
        'TxtHours
        '
        Me.TxtHours.Location = New System.Drawing.Point(164, 66)
        Me.TxtHours.Name = "TxtHours"
        Me.TxtHours.Size = New System.Drawing.Size(100, 27)
        Me.TxtHours.TabIndex = 3
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(344, 66)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(88, 27)
        Me.txtPayRate.TabIndex = 5
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGross.Location = New System.Drawing.Point(53, 133)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(68, 28)
        Me.lblGross.TabIndex = 7
        '
        'lblFwt
        '
        Me.lblFwt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFwt.Location = New System.Drawing.Point(131, 133)
        Me.lblFwt.Name = "lblFwt"
        Me.lblFwt.Size = New System.Drawing.Size(68, 28)
        Me.lblFwt.TabIndex = 9
        '
        'lblFICA
        '
        Me.lblFICA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFICA.Location = New System.Drawing.Point(208, 133)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(68, 28)
        Me.lblFICA.TabIndex = 11
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.Location = New System.Drawing.Point(285, 133)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(68, 28)
        Me.lblState.TabIndex = 13
        '
        'lblNet
        '
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Location = New System.Drawing.Point(364, 133)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(68, 28)
        Me.lblNet.TabIndex = 15
        '
        'lblGrosstxt
        '
        Me.lblGrosstxt.AutoSize = True
        Me.lblGrosstxt.Location = New System.Drawing.Point(50, 113)
        Me.lblGrosstxt.Name = "lblGrosstxt"
        Me.lblGrosstxt.Size = New System.Drawing.Size(48, 20)
        Me.lblGrosstxt.TabIndex = 6
        Me.lblGrosstxt.Text = "Gross:"
        '
        'lblFWTtxt
        '
        Me.lblFWTtxt.AutoSize = True
        Me.lblFWTtxt.Location = New System.Drawing.Point(127, 113)
        Me.lblFWTtxt.Name = "lblFWTtxt"
        Me.lblFWTtxt.Size = New System.Drawing.Size(41, 20)
        Me.lblFWTtxt.TabIndex = 8
        Me.lblFWTtxt.Text = "FWT:"
        '
        'lblFicaTxt
        '
        Me.lblFicaTxt.AutoSize = True
        Me.lblFicaTxt.Location = New System.Drawing.Point(204, 113)
        Me.lblFicaTxt.Name = "lblFicaTxt"
        Me.lblFicaTxt.Size = New System.Drawing.Size(42, 20)
        Me.lblFicaTxt.TabIndex = 10
        Me.lblFicaTxt.Text = "FICA:"
        '
        'LblStateTxt
        '
        Me.LblStateTxt.AutoSize = True
        Me.LblStateTxt.Location = New System.Drawing.Point(281, 113)
        Me.LblStateTxt.Name = "LblStateTxt"
        Me.LblStateTxt.Size = New System.Drawing.Size(46, 20)
        Me.LblStateTxt.TabIndex = 12
        Me.LblStateTxt.Text = "State:"
        '
        'lblNetTxt
        '
        Me.lblNetTxt.AutoSize = True
        Me.lblNetTxt.Location = New System.Drawing.Point(360, 113)
        Me.lblNetTxt.Name = "lblNetTxt"
        Me.lblNetTxt.Size = New System.Drawing.Size(36, 20)
        Me.lblNetTxt.TabIndex = 14
        Me.lblNetTxt.Text = "Net:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(54, 196)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(104, 30)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(193, 196)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 30)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(328, 196)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(104, 30)
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "&Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 244)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNetTxt)
        Me.Controls.Add(Me.LblStateTxt)
        Me.Controls.Add(Me.lblFicaTxt)
        Me.Controls.Add(Me.lblFWTtxt)
        Me.Controls.Add(Me.lblGrosstxt)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblFwt)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.TxtHours)
        Me.Controls.Add(Me.lblPayrate)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.Text = "Ckasper1h1 Photo Workshop Payroll"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblPayrate As Label
    Friend WithEvents TxtHours As TextBox
    Friend WithEvents txtPayRate As TextBox
    Friend WithEvents lblGross As Label
    Friend WithEvents lblFwt As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblGrosstxt As Label
    Friend WithEvents lblFWTtxt As Label
    Friend WithEvents lblFicaTxt As Label
    Friend WithEvents LblStateTxt As Label
    Friend WithEvents lblNetTxt As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents BtnExit As Button
End Class
