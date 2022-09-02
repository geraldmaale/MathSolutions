<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CubicRelations
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLast = New System.Windows.Forms.TextBox
        Me.grpConstant = New System.Windows.Forms.GroupBox
        Me.txtC = New System.Windows.Forms.TextBox
        Me.lblEquation = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpLine = New System.Windows.Forms.GroupBox
        Me.grpB = New System.Windows.Forms.GroupBox
        Me.txtB = New System.Windows.Forms.TextBox
        Me.lblCoordinates = New System.Windows.Forms.Label
        Me.grpA = New System.Windows.Forms.GroupBox
        Me.txtA = New System.Windows.Forms.TextBox
        Me.lstCoordinates = New System.Windows.Forms.ListBox
        Me.lblNote = New System.Windows.Forms.Label
        Me.cmdCalculate = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumStep = New System.Windows.Forms.TextBox
        Me.cmdReset = New System.Windows.Forms.Button
        Me.grpInterval = New System.Windows.Forms.GroupBox
        Me.lblInterval = New System.Windows.Forms.Label
        Me.IntervalPoints = New System.Windows.Forms.GroupBox
        Me.txtFirst = New System.Windows.Forms.TextBox
        Me.txtD = New System.Windows.Forms.TextBox
        Me.grpD = New System.Windows.Forms.GroupBox
        Me.grpConstant.SuspendLayout()
        Me.grpLine.SuspendLayout()
        Me.grpB.SuspendLayout()
        Me.grpA.SuspendLayout()
        Me.grpInterval.SuspendLayout()
        Me.IntervalPoints.SuspendLayout()
        Me.grpD.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(14, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "step"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(111, 35)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(36, 26)
        Me.txtLast.TabIndex = 2
        '
        'grpConstant
        '
        Me.grpConstant.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpConstant.Controls.Add(Me.txtC)
        Me.grpConstant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConstant.Location = New System.Drawing.Point(12, 170)
        Me.grpConstant.Margin = New System.Windows.Forms.Padding(4)
        Me.grpConstant.Name = "grpConstant"
        Me.grpConstant.Padding = New System.Windows.Forms.Padding(4)
        Me.grpConstant.Size = New System.Drawing.Size(147, 50)
        Me.grpConstant.TabIndex = 2
        Me.grpConstant.TabStop = False
        Me.grpConstant.Text = "Coefficient of x (c)"
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(12, 19)
        Me.txtC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(86, 26)
        Me.txtC.TabIndex = 0
        '
        'lblEquation
        '
        Me.lblEquation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEquation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEquation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquation.Location = New System.Drawing.Point(10, 23)
        Me.lblEquation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(200, 30)
        Me.lblEquation.TabIndex = 84
        Me.lblEquation.Text = "y = ax³ + bx² + cx + d"
        Me.lblEquation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Range"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 19)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "y = ax³ + bx² + cx + d"
        '
        'grpLine
        '
        Me.grpLine.Controls.Add(Me.lblEquation)
        Me.grpLine.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLine.Location = New System.Drawing.Point(165, 33)
        Me.grpLine.Margin = New System.Windows.Forms.Padding(4)
        Me.grpLine.Name = "grpLine"
        Me.grpLine.Padding = New System.Windows.Forms.Padding(4)
        Me.grpLine.Size = New System.Drawing.Size(218, 62)
        Me.grpLine.TabIndex = 136
        Me.grpLine.TabStop = False
        Me.grpLine.Text = "Equation "
        Me.grpLine.Visible = False
        '
        'grpB
        '
        Me.grpB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpB.Controls.Add(Me.txtB)
        Me.grpB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpB.Location = New System.Drawing.Point(12, 115)
        Me.grpB.Margin = New System.Windows.Forms.Padding(4)
        Me.grpB.Name = "grpB"
        Me.grpB.Padding = New System.Windows.Forms.Padding(4)
        Me.grpB.Size = New System.Drawing.Size(147, 53)
        Me.grpB.TabIndex = 1
        Me.grpB.TabStop = False
        Me.grpB.Text = "Coefficient of x² (b)"
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(12, 22)
        Me.txtB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(86, 26)
        Me.txtB.TabIndex = 0
        '
        'lblCoordinates
        '
        Me.lblCoordinates.AutoSize = True
        Me.lblCoordinates.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoordinates.ForeColor = System.Drawing.Color.Black
        Me.lblCoordinates.Location = New System.Drawing.Point(207, 165)
        Me.lblCoordinates.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCoordinates.Name = "lblCoordinates"
        Me.lblCoordinates.Size = New System.Drawing.Size(45, 19)
        Me.lblCoordinates.TabIndex = 135
        Me.lblCoordinates.Text = "points"
        Me.lblCoordinates.Visible = False
        '
        'grpA
        '
        Me.grpA.Controls.Add(Me.txtA)
        Me.grpA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpA.Location = New System.Drawing.Point(12, 64)
        Me.grpA.Margin = New System.Windows.Forms.Padding(4)
        Me.grpA.Name = "grpA"
        Me.grpA.Padding = New System.Windows.Forms.Padding(4)
        Me.grpA.Size = New System.Drawing.Size(147, 52)
        Me.grpA.TabIndex = 0
        Me.grpA.TabStop = False
        Me.grpA.Text = "Coefficient of x³ (a)"
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(12, 21)
        Me.txtA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(86, 26)
        Me.txtA.TabIndex = 0
        '
        'lstCoordinates
        '
        Me.lstCoordinates.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstCoordinates.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCoordinates.FormattingEnabled = True
        Me.lstCoordinates.ItemHeight = 19
        Me.lstCoordinates.Location = New System.Drawing.Point(201, 186)
        Me.lstCoordinates.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCoordinates.Name = "lstCoordinates"
        Me.lstCoordinates.Size = New System.Drawing.Size(155, 194)
        Me.lstCoordinates.TabIndex = 7
        Me.lstCoordinates.Visible = False
        '
        'lblNote
        '
        Me.lblNote.BackColor = System.Drawing.Color.White
        Me.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNote.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(391, 33)
        Me.lblNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(148, 350)
        Me.lblNote.TabIndex = 134
        Me.lblNote.Text = "Label1"
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(114, 391)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(112, 34)
        Me.cmdCalculate.TabIndex = 5
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 22)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Cubic Relations"
        '
        'NumStep
        '
        Me.NumStep.ForeColor = System.Drawing.Color.Blue
        Me.NumStep.Location = New System.Drawing.Point(10, 35)
        Me.NumStep.Name = "NumStep"
        Me.NumStep.Size = New System.Drawing.Size(37, 26)
        Me.NumStep.TabIndex = 0
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(250, 391)
        Me.cmdReset.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(112, 34)
        Me.cmdReset.TabIndex = 6
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'grpInterval
        '
        Me.grpInterval.Controls.Add(Me.lblInterval)
        Me.grpInterval.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInterval.Location = New System.Drawing.Point(193, 99)
        Me.grpInterval.Margin = New System.Windows.Forms.Padding(4)
        Me.grpInterval.Name = "grpInterval"
        Me.grpInterval.Padding = New System.Windows.Forms.Padding(4)
        Me.grpInterval.Size = New System.Drawing.Size(163, 62)
        Me.grpInterval.TabIndex = 137
        Me.grpInterval.TabStop = False
        Me.grpInterval.Text = "Interval"
        Me.grpInterval.Visible = False
        '
        'lblInterval
        '
        Me.lblInterval.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInterval.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterval.Location = New System.Drawing.Point(8, 23)
        Me.lblInterval.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(147, 30)
        Me.lblInterval.TabIndex = 85
        Me.lblInterval.Text = "a ≤ X ≤ b"
        Me.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IntervalPoints
        '
        Me.IntervalPoints.Controls.Add(Me.Label4)
        Me.IntervalPoints.Controls.Add(Me.Label3)
        Me.IntervalPoints.Controls.Add(Me.txtLast)
        Me.IntervalPoints.Controls.Add(Me.txtFirst)
        Me.IntervalPoints.Controls.Add(Me.NumStep)
        Me.IntervalPoints.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalPoints.Location = New System.Drawing.Point(12, 288)
        Me.IntervalPoints.Margin = New System.Windows.Forms.Padding(4)
        Me.IntervalPoints.Name = "IntervalPoints"
        Me.IntervalPoints.Padding = New System.Windows.Forms.Padding(4)
        Me.IntervalPoints.Size = New System.Drawing.Size(155, 69)
        Me.IntervalPoints.TabIndex = 4
        Me.IntervalPoints.TabStop = False
        Me.IntervalPoints.Text = "Interval"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(62, 35)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(36, 26)
        Me.txtFirst.TabIndex = 1
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(12, 21)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(88, 26)
        Me.txtD.TabIndex = 140
        '
        'grpD
        '
        Me.grpD.Controls.Add(Me.txtD)
        Me.grpD.Location = New System.Drawing.Point(12, 227)
        Me.grpD.Name = "grpD"
        Me.grpD.Size = New System.Drawing.Size(147, 56)
        Me.grpD.TabIndex = 3
        Me.grpD.TabStop = False
        Me.grpD.Text = "Constant (d)"
        '
        'CubicRelations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 430)
        Me.Controls.Add(Me.grpConstant)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpLine)
        Me.Controls.Add(Me.grpB)
        Me.Controls.Add(Me.lblCoordinates)
        Me.Controls.Add(Me.grpA)
        Me.Controls.Add(Me.lstCoordinates)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.grpInterval)
        Me.Controls.Add(Me.IntervalPoints)
        Me.Controls.Add(Me.grpD)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "CubicRelations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cubic Relations"
        Me.grpConstant.ResumeLayout(False)
        Me.grpConstant.PerformLayout()
        Me.grpLine.ResumeLayout(False)
        Me.grpB.ResumeLayout(False)
        Me.grpB.PerformLayout()
        Me.grpA.ResumeLayout(False)
        Me.grpA.PerformLayout()
        Me.grpInterval.ResumeLayout(False)
        Me.IntervalPoints.ResumeLayout(False)
        Me.IntervalPoints.PerformLayout()
        Me.grpD.ResumeLayout(False)
        Me.grpD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents grpConstant As System.Windows.Forms.GroupBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents lblEquation As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpLine As System.Windows.Forms.GroupBox
    Friend WithEvents grpB As System.Windows.Forms.GroupBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents lblCoordinates As System.Windows.Forms.Label
    Friend WithEvents grpA As System.Windows.Forms.GroupBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents lstCoordinates As System.Windows.Forms.ListBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumStep As System.Windows.Forms.TextBox
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents grpInterval As System.Windows.Forms.GroupBox
    Friend WithEvents lblInterval As System.Windows.Forms.Label
    Friend WithEvents IntervalPoints As System.Windows.Forms.GroupBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents grpD As System.Windows.Forms.GroupBox
End Class
