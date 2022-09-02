<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinearRelation
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
        Me.lblNote = New System.Windows.Forms.Label
        Me.grpInterval = New System.Windows.Forms.GroupBox
        Me.lblInterval = New System.Windows.Forms.Label
        Me.IntervalPoints = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.NumStep = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLast = New System.Windows.Forms.TextBox
        Me.txtFirst = New System.Windows.Forms.TextBox
        Me.grpLine = New System.Windows.Forms.GroupBox
        Me.lblEquation = New System.Windows.Forms.Label
        Me.grpConstant = New System.Windows.Forms.GroupBox
        Me.txtConstant = New System.Windows.Forms.TextBox
        Me.grpGradient = New System.Windows.Forms.GroupBox
        Me.txtGrad = New System.Windows.Forms.TextBox
        Me.lblCoordinates = New System.Windows.Forms.Label
        Me.lstCoordinates = New System.Windows.Forms.ListBox
        Me.cboSelect = New System.Windows.Forms.ComboBox
        Me.cmdReset = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdCalculate = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.grpInterval.SuspendLayout()
        Me.IntervalPoints.SuspendLayout()
        Me.grpLine.SuspendLayout()
        Me.grpConstant.SuspendLayout()
        Me.grpGradient.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNote
        '
        Me.lblNote.BackColor = System.Drawing.Color.White
        Me.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNote.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(319, 34)
        Me.lblNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(162, 350)
        Me.lblNote.TabIndex = 99
        Me.lblNote.Text = "Label1"
        '
        'grpInterval
        '
        Me.grpInterval.Controls.Add(Me.lblInterval)
        Me.grpInterval.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInterval.Location = New System.Drawing.Point(162, 103)
        Me.grpInterval.Margin = New System.Windows.Forms.Padding(4)
        Me.grpInterval.Name = "grpInterval"
        Me.grpInterval.Padding = New System.Windows.Forms.Padding(4)
        Me.grpInterval.Size = New System.Drawing.Size(149, 62)
        Me.grpInterval.TabIndex = 111
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
        Me.lblInterval.Size = New System.Drawing.Size(133, 30)
        Me.lblInterval.TabIndex = 85
        Me.lblInterval.Text = "a ≤ X ≤ b"
        Me.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IntervalPoints
        '
        Me.IntervalPoints.Controls.Add(Me.Label4)
        Me.IntervalPoints.Controls.Add(Me.NumStep)
        Me.IntervalPoints.Controls.Add(Me.Label3)
        Me.IntervalPoints.Controls.Add(Me.txtLast)
        Me.IntervalPoints.Controls.Add(Me.txtFirst)
        Me.IntervalPoints.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalPoints.Location = New System.Drawing.Point(15, 238)
        Me.IntervalPoints.Margin = New System.Windows.Forms.Padding(4)
        Me.IntervalPoints.Name = "IntervalPoints"
        Me.IntervalPoints.Padding = New System.Windows.Forms.Padding(4)
        Me.IntervalPoints.Size = New System.Drawing.Size(141, 64)
        Me.IntervalPoints.TabIndex = 5
        Me.IntervalPoints.TabStop = False
        Me.IntervalPoints.Text = "Interval"
        Me.IntervalPoints.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "step"
        '
        'NumStep
        '
        Me.NumStep.ForeColor = System.Drawing.Color.Blue
        Me.NumStep.Location = New System.Drawing.Point(8, 31)
        Me.NumStep.Name = "NumStep"
        Me.NumStep.Size = New System.Drawing.Size(37, 26)
        Me.NumStep.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Range"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(100, 32)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(36, 26)
        Me.txtLast.TabIndex = 4
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(51, 32)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(36, 26)
        Me.txtFirst.TabIndex = 3
        '
        'grpLine
        '
        Me.grpLine.Controls.Add(Me.lblEquation)
        Me.grpLine.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLine.Location = New System.Drawing.Point(160, 34)
        Me.grpLine.Margin = New System.Windows.Forms.Padding(4)
        Me.grpLine.Name = "grpLine"
        Me.grpLine.Padding = New System.Windows.Forms.Padding(4)
        Me.grpLine.Size = New System.Drawing.Size(151, 62)
        Me.grpLine.TabIndex = 110
        Me.grpLine.TabStop = False
        Me.grpLine.Text = "Equation of Line"
        Me.grpLine.Visible = False
        '
        'lblEquation
        '
        Me.lblEquation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEquation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEquation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquation.Location = New System.Drawing.Point(10, 23)
        Me.lblEquation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(133, 30)
        Me.lblEquation.TabIndex = 84
        Me.lblEquation.Text = "y = mx + c"
        Me.lblEquation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpConstant
        '
        Me.grpConstant.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpConstant.Controls.Add(Me.txtConstant)
        Me.grpConstant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConstant.Location = New System.Drawing.Point(15, 175)
        Me.grpConstant.Margin = New System.Windows.Forms.Padding(4)
        Me.grpConstant.Name = "grpConstant"
        Me.grpConstant.Padding = New System.Windows.Forms.Padding(4)
        Me.grpConstant.Size = New System.Drawing.Size(108, 57)
        Me.grpConstant.TabIndex = 4
        Me.grpConstant.TabStop = False
        Me.grpConstant.Text = "Constant (c)"
        Me.grpConstant.Visible = False
        '
        'txtConstant
        '
        Me.txtConstant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConstant.Location = New System.Drawing.Point(12, 22)
        Me.txtConstant.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConstant.Name = "txtConstant"
        Me.txtConstant.Size = New System.Drawing.Size(86, 26)
        Me.txtConstant.TabIndex = 0
        '
        'grpGradient
        '
        Me.grpGradient.Controls.Add(Me.txtGrad)
        Me.grpGradient.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGradient.Location = New System.Drawing.Point(15, 113)
        Me.grpGradient.Margin = New System.Windows.Forms.Padding(4)
        Me.grpGradient.Name = "grpGradient"
        Me.grpGradient.Padding = New System.Windows.Forms.Padding(4)
        Me.grpGradient.Size = New System.Drawing.Size(108, 56)
        Me.grpGradient.TabIndex = 3
        Me.grpGradient.TabStop = False
        Me.grpGradient.Text = "Gradient (m)"
        Me.grpGradient.Visible = False
        '
        'txtGrad
        '
        Me.txtGrad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrad.Location = New System.Drawing.Point(12, 22)
        Me.txtGrad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrad.Name = "txtGrad"
        Me.txtGrad.Size = New System.Drawing.Size(86, 26)
        Me.txtGrad.TabIndex = 0
        '
        'lblCoordinates
        '
        Me.lblCoordinates.AutoSize = True
        Me.lblCoordinates.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoordinates.ForeColor = System.Drawing.Color.Black
        Me.lblCoordinates.Location = New System.Drawing.Point(176, 169)
        Me.lblCoordinates.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCoordinates.Name = "lblCoordinates"
        Me.lblCoordinates.Size = New System.Drawing.Size(45, 19)
        Me.lblCoordinates.TabIndex = 106
        Me.lblCoordinates.Text = "points"
        Me.lblCoordinates.Visible = False
        '
        'lstCoordinates
        '
        Me.lstCoordinates.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstCoordinates.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCoordinates.FormattingEnabled = True
        Me.lstCoordinates.ItemHeight = 19
        Me.lstCoordinates.Location = New System.Drawing.Point(164, 192)
        Me.lstCoordinates.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCoordinates.Name = "lstCoordinates"
        Me.lstCoordinates.Size = New System.Drawing.Size(147, 194)
        Me.lstCoordinates.TabIndex = 105
        Me.lstCoordinates.Visible = False
        '
        'cboSelect
        '
        Me.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelect.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Location = New System.Drawing.Point(15, 52)
        Me.cboSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(124, 27)
        Me.cboSelect.TabIndex = 1
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(15, 350)
        Me.cmdReset.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(112, 34)
        Me.cmdReset.TabIndex = 7
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 22)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Linear Relations"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "y = m x + c"
        Me.Label2.Visible = False
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(15, 309)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(112, 34)
        Me.cmdCalculate.TabIndex = 6
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        Me.cmdCalculate.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Select Equation"
        '
        'LinearRelation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 399)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.grpInterval)
        Me.Controls.Add(Me.IntervalPoints)
        Me.Controls.Add(Me.grpLine)
        Me.Controls.Add(Me.grpConstant)
        Me.Controls.Add(Me.grpGradient)
        Me.Controls.Add(Me.lblCoordinates)
        Me.Controls.Add(Me.lstCoordinates)
        Me.Controls.Add(Me.lblNote)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "LinearRelation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Linear Relations"
        Me.grpInterval.ResumeLayout(False)
        Me.IntervalPoints.ResumeLayout(False)
        Me.IntervalPoints.PerformLayout()
        Me.grpLine.ResumeLayout(False)
        Me.grpConstant.ResumeLayout(False)
        Me.grpConstant.PerformLayout()
        Me.grpGradient.ResumeLayout(False)
        Me.grpGradient.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents grpInterval As System.Windows.Forms.GroupBox
    Friend WithEvents lblInterval As System.Windows.Forms.Label
    Friend WithEvents IntervalPoints As System.Windows.Forms.GroupBox
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents grpLine As System.Windows.Forms.GroupBox
    Friend WithEvents lblEquation As System.Windows.Forms.Label
    Friend WithEvents grpConstant As System.Windows.Forms.GroupBox
    Friend WithEvents txtConstant As System.Windows.Forms.TextBox
    Friend WithEvents grpGradient As System.Windows.Forms.GroupBox
    Friend WithEvents txtGrad As System.Windows.Forms.TextBox
    Friend WithEvents lblCoordinates As System.Windows.Forms.Label
    Friend WithEvents lstCoordinates As System.Windows.Forms.ListBox
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumStep As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
