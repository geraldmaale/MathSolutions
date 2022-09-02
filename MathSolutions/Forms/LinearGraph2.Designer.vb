<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinearGraph2
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
        Me.cboSelect = New System.Windows.Forms.ComboBox
        Me.lblSelect = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblFormula = New System.Windows.Forms.Label
        Me.pointB = New System.Windows.Forms.GroupBox
        Me.txtX2 = New System.Windows.Forms.TextBox
        Me.txtY2 = New System.Windows.Forms.TextBox
        Me.pointA = New System.Windows.Forms.GroupBox
        Me.txtX1 = New System.Windows.Forms.TextBox
        Me.txtY1 = New System.Windows.Forms.TextBox
        Me.pnlAnsLength = New System.Windows.Forms.Panel
        Me.lblFormulaLabel = New System.Windows.Forms.Label
        Me.lblAnsEquation = New System.Windows.Forms.Label
        Me.cmdReset = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.pointB.SuspendLayout()
        Me.pointA.SuspendLayout()
        Me.pnlAnsLength.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboSelect
        '
        Me.cboSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelect.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Location = New System.Drawing.Point(17, 72)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(185, 27)
        Me.cboSelect.TabIndex = 92
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.ForeColor = System.Drawing.Color.Black
        Me.lblSelect.Location = New System.Drawing.Point(18, 50)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(53, 19)
        Me.lblSelect.TabIndex = 93
        Me.lblSelect.Text = "Select :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(139, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Formula:"
        Me.Label3.Visible = False
        '
        'lblFormula
        '
        Me.lblFormula.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFormula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFormula.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormula.Location = New System.Drawing.Point(142, 147)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(208, 35)
        Me.lblFormula.TabIndex = 100
        Me.lblFormula.Text = "Label2"
        Me.lblFormula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormula.Visible = False
        '
        'pointB
        '
        Me.pointB.Controls.Add(Me.txtX2)
        Me.pointB.Controls.Add(Me.txtY2)
        Me.pointB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointB.Location = New System.Drawing.Point(17, 188)
        Me.pointB.Name = "pointB"
        Me.pointB.Size = New System.Drawing.Size(108, 54)
        Me.pointB.TabIndex = 103
        Me.pointB.TabStop = False
        Me.pointB.Text = "B(x2,y2)"
        Me.pointB.Visible = False
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(6, 18)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(44, 26)
        Me.txtX2.TabIndex = 53
        '
        'txtY2
        '
        Me.txtY2.Location = New System.Drawing.Point(55, 18)
        Me.txtY2.Name = "txtY2"
        Me.txtY2.Size = New System.Drawing.Size(44, 26)
        Me.txtY2.TabIndex = 54
        '
        'pointA
        '
        Me.pointA.Controls.Add(Me.txtX1)
        Me.pointA.Controls.Add(Me.txtY1)
        Me.pointA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointA.Location = New System.Drawing.Point(17, 124)
        Me.pointA.Name = "pointA"
        Me.pointA.Size = New System.Drawing.Size(109, 58)
        Me.pointA.TabIndex = 102
        Me.pointA.TabStop = False
        Me.pointA.Text = "A(x1,y1)"
        Me.pointA.Visible = False
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(5, 18)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(44, 26)
        Me.txtX1.TabIndex = 51
        '
        'txtY1
        '
        Me.txtY1.Location = New System.Drawing.Point(55, 18)
        Me.txtY1.Name = "txtY1"
        Me.txtY1.Size = New System.Drawing.Size(44, 26)
        Me.txtY1.TabIndex = 52
        '
        'pnlAnsLength
        '
        Me.pnlAnsLength.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlAnsLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAnsLength.Controls.Add(Me.lblFormulaLabel)
        Me.pnlAnsLength.Controls.Add(Me.lblAnsEquation)
        Me.pnlAnsLength.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAnsLength.Location = New System.Drawing.Point(142, 194)
        Me.pnlAnsLength.Name = "pnlAnsLength"
        Me.pnlAnsLength.Size = New System.Drawing.Size(208, 48)
        Me.pnlAnsLength.TabIndex = 105
        Me.pnlAnsLength.Visible = False
        '
        'lblFormulaLabel
        '
        Me.lblFormulaLabel.AutoSize = True
        Me.lblFormulaLabel.Location = New System.Drawing.Point(3, 16)
        Me.lblFormulaLabel.Name = "lblFormulaLabel"
        Me.lblFormulaLabel.Size = New System.Drawing.Size(51, 19)
        Me.lblFormulaLabel.TabIndex = 60
        Me.lblFormulaLabel.Text = "Label1"
        '
        'lblAnsEquation
        '
        Me.lblAnsEquation.AutoSize = True
        Me.lblAnsEquation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnsEquation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsEquation.Location = New System.Drawing.Point(112, 14)
        Me.lblAnsEquation.Name = "lblAnsEquation"
        Me.lblAnsEquation.Size = New System.Drawing.Size(55, 19)
        Me.lblAnsEquation.TabIndex = 55
        Me.lblAnsEquation.Text = "Label1"
        '
        'cmdReset
        '
        Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(151, 280)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 106
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 22)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Linear Graphs && Equations"
        '
        'LinearGraph2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 318)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.pointB)
        Me.Controls.Add(Me.pointA)
        Me.Controls.Add(Me.pnlAnsLength)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.lblSelect)
        Me.MaximizeBox = False
        Me.Name = "LinearGraph2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Linear Graphs"
        Me.pointB.ResumeLayout(False)
        Me.pointB.PerformLayout()
        Me.pointA.ResumeLayout(False)
        Me.pointA.PerformLayout()
        Me.pnlAnsLength.ResumeLayout(False)
        Me.pnlAnsLength.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFormula As System.Windows.Forms.Label
    Friend WithEvents pointB As System.Windows.Forms.GroupBox
    Friend WithEvents txtX2 As System.Windows.Forms.TextBox
    Friend WithEvents txtY2 As System.Windows.Forms.TextBox
    Friend WithEvents pointA As System.Windows.Forms.GroupBox
    Friend WithEvents txtX1 As System.Windows.Forms.TextBox
    Friend WithEvents txtY1 As System.Windows.Forms.TextBox
    Friend WithEvents pnlAnsLength As System.Windows.Forms.Panel
    Friend WithEvents lblFormulaLabel As System.Windows.Forms.Label
    Friend WithEvents lblAnsEquation As System.Windows.Forms.Label
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
