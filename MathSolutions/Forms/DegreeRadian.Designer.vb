<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DegreeRadian
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
        Me.txtDeg = New System.Windows.Forms.TextBox
        Me.txtRad = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnRad = New System.Windows.Forms.Button
        Me.btnDeg = New System.Windows.Forms.Button
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.txtAns = New System.Windows.Forms.TextBox
        Me.cboTrig = New System.Windows.Forms.ComboBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnConvert = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDeg
        '
        Me.txtDeg.Location = New System.Drawing.Point(28, 67)
        Me.txtDeg.Name = "txtDeg"
        Me.txtDeg.Size = New System.Drawing.Size(100, 26)
        Me.txtDeg.TabIndex = 0
        '
        'txtRad
        '
        Me.txtRad.Location = New System.Drawing.Point(158, 67)
        Me.txtRad.Name = "txtRad"
        Me.txtRad.Size = New System.Drawing.Size(147, 26)
        Me.txtRad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Degrees"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Radians"
        '
        'btnRad
        '
        Me.btnRad.Location = New System.Drawing.Point(52, 99)
        Me.btnRad.Name = "btnRad"
        Me.btnRad.Size = New System.Drawing.Size(75, 26)
        Me.btnRad.TabIndex = 4
        Me.btnRad.Text = "Radians"
        Me.btnRad.UseVisualStyleBackColor = True
        '
        'btnDeg
        '
        Me.btnDeg.Location = New System.Drawing.Point(162, 99)
        Me.btnDeg.Name = "btnDeg"
        Me.btnDeg.Size = New System.Drawing.Size(75, 26)
        Me.btnDeg.TabIndex = 5
        Me.btnDeg.Text = "Degrees"
        Me.btnDeg.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(103, 22)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(66, 26)
        Me.txtNum.TabIndex = 6
        '
        'txtAns
        '
        Me.txtAns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAns.Location = New System.Drawing.Point(175, 22)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.ReadOnly = True
        Me.txtAns.Size = New System.Drawing.Size(118, 26)
        Me.txtAns.TabIndex = 7
        '
        'cboTrig
        '
        Me.cboTrig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrig.FormattingEnabled = True
        Me.cboTrig.Location = New System.Drawing.Point(14, 21)
        Me.cboTrig.Name = "cboTrig"
        Me.cboTrig.Size = New System.Drawing.Size(81, 27)
        Me.cboTrig.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Location = New System.Drawing.Point(189, 208)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Conversion of Angles"
        '
        'btnConvert
        '
        Me.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvert.Location = New System.Drawing.Point(106, 208)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 30)
        Me.btnConvert.TabIndex = 11
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboTrig)
        Me.GroupBox1.Controls.Add(Me.txtAns)
        Me.GroupBox1.Controls.Add(Me.txtNum)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 61)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Sin, Cos or Tan"
        '
        'DegreeRadian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 273)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDeg)
        Me.Controls.Add(Me.btnRad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRad)
        Me.Controls.Add(Me.txtDeg)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "DegreeRadian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DegreeRadian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDeg As System.Windows.Forms.TextBox
    Friend WithEvents txtRad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRad As System.Windows.Forms.Button
    Friend WithEvents btnDeg As System.Windows.Forms.Button
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents cboTrig As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
