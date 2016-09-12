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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.lblincrease = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtprojectIncrease = New System.Windows.Forms.TextBox()
        Me.lblStraw = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblRasp = New System.Windows.Forms.Label()
        Me.lblCurrentsales = New System.Windows.Forms.Label()
        Me.lblProjectedSales = New System.Windows.Forms.Label()
        Me.lblProStraw = New System.Windows.Forms.Label()
        Me.txtCurStraw = New System.Windows.Forms.TextBox()
        Me.lblProBlue = New System.Windows.Forms.Label()
        Me.lblProRasp = New System.Windows.Forms.Label()
        Me.txtCurBlue = New System.Windows.Forms.TextBox()
        Me.txtCurRasp = New System.Windows.Forms.TextBox()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic1
        '
        Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(27, 31)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(110, 75)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'lblincrease
        '
        Me.lblincrease.AutoSize = True
        Me.lblincrease.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblincrease.Location = New System.Drawing.Point(143, 57)
        Me.lblincrease.Name = "lblincrease"
        Me.lblincrease.Size = New System.Drawing.Size(153, 21)
        Me.lblincrease.TabIndex = 10
        Me.lblincrease.Text = "Projected &Increase %"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "(in decimal form)"
        '
        'txtprojectIncrease
        '
        Me.txtprojectIncrease.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprojectIncrease.Location = New System.Drawing.Point(314, 60)
        Me.txtprojectIncrease.Name = "txtprojectIncrease"
        Me.txtprojectIncrease.Size = New System.Drawing.Size(93, 29)
        Me.txtprojectIncrease.TabIndex = 0
        Me.txtprojectIncrease.Text = "0.05"
        Me.txtprojectIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStraw
        '
        Me.lblStraw.AutoSize = True
        Me.lblStraw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraw.Location = New System.Drawing.Point(89, 146)
        Me.lblStraw.Name = "lblStraw"
        Me.lblStraw.Size = New System.Drawing.Size(97, 21)
        Me.lblStraw.TabIndex = 1
        Me.lblStraw.Text = "&Strawberries"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(89, 182)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(88, 21)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Text = "&Blueberries"
        '
        'lblRasp
        '
        Me.lblRasp.AutoSize = True
        Me.lblRasp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRasp.Location = New System.Drawing.Point(89, 217)
        Me.lblRasp.Name = "lblRasp"
        Me.lblRasp.Size = New System.Drawing.Size(92, 21)
        Me.lblRasp.TabIndex = 5
        Me.lblRasp.Text = "&Raspberries"
        '
        'lblCurrentsales
        '
        Me.lblCurrentsales.AutoSize = True
        Me.lblCurrentsales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentsales.Location = New System.Drawing.Point(199, 115)
        Me.lblCurrentsales.Name = "lblCurrentsales"
        Me.lblCurrentsales.Size = New System.Drawing.Size(97, 21)
        Me.lblCurrentsales.TabIndex = 12
        Me.lblCurrentsales.Text = "Curent Sales"
        '
        'lblProjectedSales
        '
        Me.lblProjectedSales.AutoSize = True
        Me.lblProjectedSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectedSales.Location = New System.Drawing.Point(308, 115)
        Me.lblProjectedSales.Name = "lblProjectedSales"
        Me.lblProjectedSales.Size = New System.Drawing.Size(115, 21)
        Me.lblProjectedSales.TabIndex = 13
        Me.lblProjectedSales.Text = "Projected Sales"
        '
        'lblProStraw
        '
        Me.lblProStraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProStraw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProStraw.Location = New System.Drawing.Point(317, 141)
        Me.lblProStraw.Name = "lblProStraw"
        Me.lblProStraw.Size = New System.Drawing.Size(93, 29)
        Me.lblProStraw.TabIndex = 14
        '
        'txtCurStraw
        '
        Me.txtCurStraw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurStraw.Location = New System.Drawing.Point(200, 143)
        Me.txtCurStraw.Name = "txtCurStraw"
        Me.txtCurStraw.Size = New System.Drawing.Size(93, 29)
        Me.txtCurStraw.TabIndex = 2
        '
        'lblProBlue
        '
        Me.lblProBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProBlue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProBlue.Location = New System.Drawing.Point(317, 177)
        Me.lblProBlue.Name = "lblProBlue"
        Me.lblProBlue.Size = New System.Drawing.Size(93, 29)
        Me.lblProBlue.TabIndex = 15
        '
        'lblProRasp
        '
        Me.lblProRasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProRasp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProRasp.Location = New System.Drawing.Point(317, 214)
        Me.lblProRasp.Name = "lblProRasp"
        Me.lblProRasp.Size = New System.Drawing.Size(93, 29)
        Me.lblProRasp.TabIndex = 16
        '
        'txtCurBlue
        '
        Me.txtCurBlue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurBlue.Location = New System.Drawing.Point(200, 179)
        Me.txtCurBlue.Name = "txtCurBlue"
        Me.txtCurBlue.Size = New System.Drawing.Size(93, 29)
        Me.txtCurBlue.TabIndex = 4
        '
        'txtCurRasp
        '
        Me.txtCurRasp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurRasp.Location = New System.Drawing.Point(200, 214)
        Me.txtCurRasp.Name = "txtCurRasp"
        Me.txtCurRasp.Size = New System.Drawing.Size(93, 29)
        Me.txtCurRasp.TabIndex = 6
        '
        'btnCal
        '
        Me.btnCal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.Location = New System.Drawing.Point(102, 256)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(72, 33)
        Me.btnCal.TabIndex = 7
        Me.btnCal.Text = "&Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(180, 256)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 33)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(258, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 33)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(336, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 33)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 296)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.txtCurRasp)
        Me.Controls.Add(Me.txtCurBlue)
        Me.Controls.Add(Me.lblProRasp)
        Me.Controls.Add(Me.lblProBlue)
        Me.Controls.Add(Me.txtCurStraw)
        Me.Controls.Add(Me.lblProStraw)
        Me.Controls.Add(Me.lblProjectedSales)
        Me.Controls.Add(Me.lblCurrentsales)
        Me.Controls.Add(Me.lblRasp)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblStraw)
        Me.Controls.Add(Me.txtprojectIncrease)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblincrease)
        Me.Controls.Add(Me.pic1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic1 As PictureBox
    Friend WithEvents lblincrease As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtprojectIncrease As TextBox
    Friend WithEvents lblStraw As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblRasp As Label
    Friend WithEvents lblCurrentsales As Label
    Friend WithEvents lblProjectedSales As Label
    Friend WithEvents lblProStraw As Label
    Friend WithEvents txtCurStraw As TextBox
    Friend WithEvents lblProBlue As Label
    Friend WithEvents lblProRasp As Label
    Friend WithEvents txtCurBlue As TextBox
    Friend WithEvents txtCurRasp As TextBox
    Friend WithEvents btnCal As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
