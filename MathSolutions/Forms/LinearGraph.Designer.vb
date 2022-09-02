<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinearGraph
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
        Me.components = New System.ComponentModel.Container
        Me.chkX = New System.Windows.Forms.RadioButton
        Me.chkY = New System.Windows.Forms.RadioButton
        Me.linearGraphsToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboSelect = New System.Windows.Forms.ComboBox
        Me.lblCoordinates = New System.Windows.Forms.Label
        Me.lblEquation = New System.Windows.Forms.Label
        Me.lblInterval = New System.Windows.Forms.Label
        Me.lstCoordinates = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtConstant = New System.Windows.Forms.TextBox
        Me.txtLast = New System.Windows.Forms.TextBox
        Me.txtGrad = New System.Windows.Forms.TextBox
        Me.IntervalPoints = New System.Windows.Forms.GroupBox
        Me.txtFirst = New System.Windows.Forms.TextBox
        Me.opt5 = New System.Windows.Forms.RadioButton
        Me.opt4 = New System.Windows.Forms.RadioButton
        Me.opt3 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.opt2 = New System.Windows.Forms.RadioButton
        Me.opt1 = New System.Windows.Forms.RadioButton
        Me.lblSelect = New System.Windows.Forms.Label
        Me.lblStraightLine = New System.Windows.Forms.Label
        Me.txtC = New System.Windows.Forms.TextBox
        Me.txtA = New System.Windows.Forms.TextBox
        Me.cmdReset = New System.Windows.Forms.Button
        Me.txtB = New System.Windows.Forms.TextBox
        Me.grpFormat = New System.Windows.Forms.GroupBox
        Me.grpGradient = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpConstant = New System.Windows.Forms.GroupBox
        Me.grpLine = New System.Windows.Forms.GroupBox
        Me.grpInterval = New System.Windows.Forms.GroupBox
        Me.GroupBox2.SuspendLayout()
        Me.IntervalPoints.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpFormat.SuspendLayout()
        Me.grpGradient.SuspendLayout()
        Me.grpConstant.SuspendLayout()
        Me.grpLine.SuspendLayout()
        Me.grpInterval.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkX
        '
        Me.chkX.AutoSize = True
        Me.chkX.Location = New System.Drawing.Point(13, 43)
        Me.chkX.Name = "chkX"
        Me.chkX.Size = New System.Drawing.Size(42, 23)
        Me.chkX.TabIndex = 1
        Me.chkX.TabStop = True
        Me.chkX.Text = " X"
        Me.chkX.UseVisualStyleBackColor = True
        '
        'chkY
        '
        Me.chkY.AutoSize = True
        Me.chkY.Location = New System.Drawing.Point(13, 21)
        Me.chkY.Name = "chkY"
        Me.chkY.Size = New System.Drawing.Size(41, 23)
        Me.chkY.TabIndex = 0
        Me.chkY.TabStop = True
        Me.chkY.Text = " Y"
        Me.chkY.UseVisualStyleBackColor = True
        '
        'linearGraphsToolTip
        '
        Me.linearGraphsToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.linearGraphsToolTip.ToolTipTitle = "info:"
        '
        'cboSelect
        '
        Me.cboSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelect.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Location = New System.Drawing.Point(21, 60)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(138, 27)
        Me.cboSelect.TabIndex = 90
        Me.linearGraphsToolTip.SetToolTip(Me.cboSelect, "Select option for solving")
        '
        'lblCoordinates
        '
        Me.lblCoordinates.AutoSize = True
        Me.lblCoordinates.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoordinates.ForeColor = System.Drawing.Color.Black
        Me.lblCoordinates.Location = New System.Drawing.Point(340, 146)
        Me.lblCoordinates.Name = "lblCoordinates"
        Me.lblCoordinates.Size = New System.Drawing.Size(62, 19)
        Me.lblCoordinates.TabIndex = 88
        Me.lblCoordinates.Text = "Answers"
        Me.lblCoordinates.Visible = False
        '
        'lblEquation
        '
        Me.lblEquation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEquation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEquation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquation.Location = New System.Drawing.Point(7, 22)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(124, 21)
        Me.lblEquation.TabIndex = 84
        Me.lblEquation.Text = "y = mx + c"
        Me.lblEquation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInterval.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterval.Location = New System.Drawing.Point(10, 22)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(71, 21)
        Me.lblInterval.TabIndex = 85
        Me.lblInterval.Text = "a ≤ X ≤ b"
        Me.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstCoordinates
        '
        Me.lstCoordinates.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstCoordinates.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCoordinates.FormattingEnabled = True
        Me.lstCoordinates.ItemHeight = 19
        Me.lstCoordinates.Location = New System.Drawing.Point(333, 168)
        Me.lstCoordinates.Name = "lstCoordinates"
        Me.lstCoordinates.Size = New System.Drawing.Size(138, 175)
        Me.lstCoordinates.TabIndex = 81
        Me.lstCoordinates.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkX)
        Me.GroupBox2.Controls.Add(Me.chkY)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(114, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(83, 72)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Equation"
        Me.GroupBox2.Visible = False
        '
        'txtConstant
        '
        Me.txtConstant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConstant.Location = New System.Drawing.Point(6, 23)
        Me.txtConstant.Name = "txtConstant"
        Me.txtConstant.Size = New System.Drawing.Size(100, 26)
        Me.txtConstant.TabIndex = 93
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(64, 18)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(40, 26)
        Me.txtLast.TabIndex = 42
        '
        'txtGrad
        '
        Me.txtGrad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrad.Location = New System.Drawing.Point(8, 23)
        Me.txtGrad.Name = "txtGrad"
        Me.txtGrad.Size = New System.Drawing.Size(100, 26)
        Me.txtGrad.TabIndex = 92
        '
        'IntervalPoints
        '
        Me.IntervalPoints.Controls.Add(Me.txtLast)
        Me.IntervalPoints.Controls.Add(Me.txtFirst)
        Me.IntervalPoints.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalPoints.Location = New System.Drawing.Point(203, 230)
        Me.IntervalPoints.Name = "IntervalPoints"
        Me.IntervalPoints.Size = New System.Drawing.Size(114, 50)
        Me.IntervalPoints.TabIndex = 96
        Me.IntervalPoints.TabStop = False
        Me.IntervalPoints.Text = "Interval"
        Me.IntervalPoints.Visible = False
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(9, 18)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(42, 26)
        Me.txtFirst.TabIndex = 41
        '
        'opt5
        '
        Me.opt5.AutoSize = True
        Me.opt5.Location = New System.Drawing.Point(11, 96)
        Me.opt5.Name = "opt5"
        Me.opt5.Size = New System.Drawing.Size(67, 23)
        Me.opt5.TabIndex = 35
        Me.opt5.Text = "Step 5"
        Me.opt5.UseVisualStyleBackColor = True
        '
        'opt4
        '
        Me.opt4.AutoSize = True
        Me.opt4.Location = New System.Drawing.Point(11, 77)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(67, 23)
        Me.opt4.TabIndex = 34
        Me.opt4.Text = "Step 4"
        Me.opt4.UseVisualStyleBackColor = True
        '
        'opt3
        '
        Me.opt3.AutoSize = True
        Me.opt3.Location = New System.Drawing.Point(11, 58)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(67, 23)
        Me.opt3.TabIndex = 33
        Me.opt3.Text = "Step 3"
        Me.opt3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opt5)
        Me.GroupBox1.Controls.Add(Me.opt4)
        Me.GroupBox1.Controls.Add(Me.opt3)
        Me.GroupBox1.Controls.Add(Me.opt2)
        Me.GroupBox1.Controls.Add(Me.opt1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 123)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step"
        Me.GroupBox1.Visible = False
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(11, 39)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(67, 23)
        Me.opt2.TabIndex = 32
        Me.opt2.Text = "Step 2"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(11, 19)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(67, 23)
        Me.opt1.TabIndex = 31
        Me.opt1.Text = "Step 1"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.ForeColor = System.Drawing.Color.Black
        Me.lblSelect.Location = New System.Drawing.Point(22, 38)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(53, 19)
        Me.lblSelect.TabIndex = 91
        Me.lblSelect.Text = "Select :"
        '
        'lblStraightLine
        '
        Me.lblStraightLine.AutoSize = True
        Me.lblStraightLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraightLine.Location = New System.Drawing.Point(17, 16)
        Me.lblStraightLine.Name = "lblStraightLine"
        Me.lblStraightLine.Size = New System.Drawing.Size(133, 24)
        Me.lblStraightLine.TabIndex = 46
        Me.lblStraightLine.Text = "ax + by + c = 0"
        Me.lblStraightLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(113, 43)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(47, 26)
        Me.txtC.TabIndex = 49
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(7, 43)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(47, 26)
        Me.txtA.TabIndex = 47
        '
        'cmdReset
        '
        Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(75, 295)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(84, 39)
        Me.cmdReset.TabIndex = 82
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.Visible = False
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(60, 43)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(47, 26)
        Me.txtB.TabIndex = 48
        '
        'grpFormat
        '
        Me.grpFormat.Controls.Add(Me.txtC)
        Me.grpFormat.Controls.Add(Me.txtB)
        Me.grpFormat.Controls.Add(Me.txtA)
        Me.grpFormat.Controls.Add(Me.lblStraightLine)
        Me.grpFormat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFormat.Location = New System.Drawing.Point(161, 38)
        Me.grpFormat.Name = "grpFormat"
        Me.grpFormat.Size = New System.Drawing.Size(167, 71)
        Me.grpFormat.TabIndex = 97
        Me.grpFormat.TabStop = False
        Me.grpFormat.Text = "Format:"
        Me.grpFormat.Visible = False
        '
        'grpGradient
        '
        Me.grpGradient.Controls.Add(Me.txtGrad)
        Me.grpGradient.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGradient.Location = New System.Drawing.Point(203, 110)
        Me.grpGradient.Name = "grpGradient"
        Me.grpGradient.Size = New System.Drawing.Size(117, 55)
        Me.grpGradient.TabIndex = 101
        Me.grpGradient.TabStop = False
        Me.grpGradient.Text = "Gradient (m)"
        Me.grpGradient.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 22)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Linear Graphs && Equations"
        '
        'grpConstant
        '
        Me.grpConstant.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpConstant.Controls.Add(Me.txtConstant)
        Me.grpConstant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConstant.Location = New System.Drawing.Point(203, 168)
        Me.grpConstant.Name = "grpConstant"
        Me.grpConstant.Size = New System.Drawing.Size(117, 56)
        Me.grpConstant.TabIndex = 102
        Me.grpConstant.TabStop = False
        Me.grpConstant.Text = "Constant (c)"
        Me.grpConstant.Visible = False
        '
        'grpLine
        '
        Me.grpLine.Controls.Add(Me.lblEquation)
        Me.grpLine.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLine.Location = New System.Drawing.Point(334, 38)
        Me.grpLine.Name = "grpLine"
        Me.grpLine.Size = New System.Drawing.Size(137, 50)
        Me.grpLine.TabIndex = 103
        Me.grpLine.TabStop = False
        Me.grpLine.Text = "Gradient of Line"
        Me.grpLine.Visible = False
        '
        'grpInterval
        '
        Me.grpInterval.Controls.Add(Me.lblInterval)
        Me.grpInterval.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInterval.Location = New System.Drawing.Point(334, 94)
        Me.grpInterval.Name = "grpInterval"
        Me.grpInterval.Size = New System.Drawing.Size(137, 50)
        Me.grpInterval.TabIndex = 104
        Me.grpInterval.TabStop = False
        Me.grpInterval.Text = "Interval"
        Me.grpInterval.Visible = False
        '
        'LinearGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 356)
        Me.Controls.Add(Me.grpInterval)
        Me.Controls.Add(Me.IntervalPoints)
        Me.Controls.Add(Me.grpLine)
        Me.Controls.Add(Me.grpConstant)
        Me.Controls.Add(Me.grpGradient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCoordinates)
        Me.Controls.Add(Me.lstCoordinates)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.grpFormat)
        Me.MaximizeBox = False
        Me.Name = "LinearGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Linear Graphs"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.IntervalPoints.ResumeLayout(False)
        Me.IntervalPoints.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpFormat.ResumeLayout(False)
        Me.grpFormat.PerformLayout()
        Me.grpGradient.ResumeLayout(False)
        Me.grpGradient.PerformLayout()
        Me.grpConstant.ResumeLayout(False)
        Me.grpConstant.PerformLayout()
        Me.grpLine.ResumeLayout(False)
        Me.grpInterval.ResumeLayout(False)
        Me.grpInterval.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkX As System.Windows.Forms.RadioButton
    Friend WithEvents chkY As System.Windows.Forms.RadioButton
    Friend WithEvents linearGraphsToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents lblCoordinates As System.Windows.Forms.Label
    Friend WithEvents lblEquation As System.Windows.Forms.Label
    Friend WithEvents lblInterval As System.Windows.Forms.Label
    Friend WithEvents lstCoordinates As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConstant As System.Windows.Forms.TextBox
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents txtGrad As System.Windows.Forms.TextBox
    Friend WithEvents IntervalPoints As System.Windows.Forms.GroupBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents opt5 As System.Windows.Forms.RadioButton
    Friend WithEvents opt4 As System.Windows.Forms.RadioButton
    Friend WithEvents opt3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents lblStraightLine As System.Windows.Forms.Label
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents grpFormat As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpGradient As System.Windows.Forms.GroupBox
    Friend WithEvents grpConstant As System.Windows.Forms.GroupBox
    Friend WithEvents grpLine As System.Windows.Forms.GroupBox
    Friend WithEvents grpInterval As System.Windows.Forms.GroupBox
End Class
