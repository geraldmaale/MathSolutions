<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Numbers
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
        Me.b = New System.Windows.Forms.TextBox
        Me.txtNotes = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblStop = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstPrime = New System.Windows.Forms.ListBox
        Me.lstFactors = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdGo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.a = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtNum1 = New System.Windows.Forms.TextBox
        Me.txtNum2 = New System.Windows.Forms.TextBox
        Me.grpNumbers = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.txtLcm = New System.Windows.Forms.TextBox
        Me.txtHcf = New System.Windows.Forms.TextBox
        Me.pnlNumbers = New System.Windows.Forms.Panel
        Me.LcmHcf = New System.Windows.Forms.Panel
        Me.lblInfo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpNumbers.SuspendLayout()
        Me.pnlNumbers.SuspendLayout()
        Me.LcmHcf.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'b
        '
        Me.b.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(205, 18)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(32, 29)
        Me.b.TabIndex = 1
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.White
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNotes.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(411, 38)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(158, 324)
        Me.txtNotes.TabIndex = 32
        Me.txtNotes.Text = "Label4"
        Me.txtNotes.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(216, 371)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 32)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.Location = New System.Drawing.Point(199, 2)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(41, 13)
        Me.lblStop.TabIndex = 11
        Me.lblStop.Text = "Stop at"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(144, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 22)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Select your calculation"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'lstPrime
        '
        Me.lstPrime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrime.FormattingEnabled = True
        Me.lstPrime.ItemHeight = 19
        Me.lstPrime.Location = New System.Drawing.Point(136, 149)
        Me.lstPrime.Name = "lstPrime"
        Me.lstPrime.ScrollAlwaysVisible = True
        Me.lstPrime.Size = New System.Drawing.Size(270, 80)
        Me.lstPrime.TabIndex = 1
        Me.lstPrime.Visible = False
        '
        'lstFactors
        '
        Me.lstFactors.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFactors.FormattingEnabled = True
        Me.lstFactors.ItemHeight = 19
        Me.lstFactors.Location = New System.Drawing.Point(136, 149)
        Me.lstFactors.MultiColumn = True
        Me.lstFactors.Name = "lstFactors"
        Me.lstFactors.Size = New System.Drawing.Size(270, 213)
        Me.lstFactors.TabIndex = 27
        Me.lstFactors.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Select "
        '
        'cmdGo
        '
        Me.cmdGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGo.Location = New System.Drawing.Point(240, 19)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(31, 27)
        Me.cmdGo.TabIndex = 12
        Me.cmdGo.Text = "GO"
        Me.cmdGo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Number:"
        '
        'a
        '
        Me.a.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.Location = New System.Drawing.Point(139, 18)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(62, 29)
        Me.a.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(5, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox1.TabIndex = 0
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(6, 34)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(43, 26)
        Me.txtNum1.TabIndex = 33
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(55, 34)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(43, 26)
        Me.txtNum2.TabIndex = 34
        '
        'grpNumbers
        '
        Me.grpNumbers.Controls.Add(Me.txtNum1)
        Me.grpNumbers.Controls.Add(Me.txtNum2)
        Me.grpNumbers.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNumbers.Location = New System.Drawing.Point(194, 38)
        Me.grpNumbers.Name = "grpNumbers"
        Me.grpNumbers.Size = New System.Drawing.Size(105, 66)
        Me.grpNumbers.TabIndex = 35
        Me.grpNumbers.TabStop = False
        Me.grpNumbers.Text = "Numbers"
        Me.grpNumbers.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "LCM ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "HCF ="
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(168, 123)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 40
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        Me.btnFind.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(254, 123)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 41
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'txtLcm
        '
        Me.txtLcm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLcm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLcm.Location = New System.Drawing.Point(73, 12)
        Me.txtLcm.Name = "txtLcm"
        Me.txtLcm.Size = New System.Drawing.Size(41, 26)
        Me.txtLcm.TabIndex = 38
        '
        'txtHcf
        '
        Me.txtHcf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHcf.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHcf.Location = New System.Drawing.Point(73, 35)
        Me.txtHcf.Name = "txtHcf"
        Me.txtHcf.Size = New System.Drawing.Size(41, 26)
        Me.txtHcf.TabIndex = 39
        '
        'pnlNumbers
        '
        Me.pnlNumbers.Controls.Add(Me.cmdGo)
        Me.pnlNumbers.Controls.Add(Me.lblStop)
        Me.pnlNumbers.Controls.Add(Me.b)
        Me.pnlNumbers.Controls.Add(Me.Label1)
        Me.pnlNumbers.Controls.Add(Me.a)
        Me.pnlNumbers.Location = New System.Drawing.Point(134, 49)
        Me.pnlNumbers.Name = "pnlNumbers"
        Me.pnlNumbers.Size = New System.Drawing.Size(273, 51)
        Me.pnlNumbers.TabIndex = 30
        Me.pnlNumbers.Visible = False
        '
        'LcmHcf
        '
        Me.LcmHcf.Controls.Add(Me.txtHcf)
        Me.LcmHcf.Controls.Add(Me.txtLcm)
        Me.LcmHcf.Controls.Add(Me.Label4)
        Me.LcmHcf.Controls.Add(Me.Label5)
        Me.LcmHcf.Location = New System.Drawing.Point(181, 176)
        Me.LcmHcf.Name = "LcmHcf"
        Me.LcmHcf.Size = New System.Drawing.Size(130, 73)
        Me.LcmHcf.TabIndex = 40
        Me.LcmHcf.Visible = False
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblInfo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInfo.Location = New System.Drawing.Point(8, 80)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(115, 282)
        Me.lblInfo.TabIndex = 24
        Me.lblInfo.Text = "Select your choice as to determine prime, even, odd numbers, find roots and power" & _
            "s,  generate factors or multiples of numbers, LCMs or HCF."
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(130, 411)
        Me.Panel1.TabIndex = 42
        '
        'Numbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 407)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.LcmHcf)
        Me.Controls.Add(Me.grpNumbers)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstPrime)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lstFactors)
        Me.Controls.Add(Me.pnlNumbers)
        Me.MaximizeBox = False
        Me.Name = "Numbers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Numbers"
        Me.grpNumbers.ResumeLayout(False)
        Me.grpNumbers.PerformLayout()
        Me.pnlNumbers.ResumeLayout(False)
        Me.pnlNumbers.PerformLayout()
        Me.LcmHcf.ResumeLayout(False)
        Me.LcmHcf.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblStop As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstPrime As System.Windows.Forms.ListBox
    Friend WithEvents lstFactors As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents grpNumbers As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtHcf As System.Windows.Forms.TextBox
    Friend WithEvents txtLcm As System.Windows.Forms.TextBox
    Friend WithEvents pnlNumbers As System.Windows.Forms.Panel
    Friend WithEvents LcmHcf As System.Windows.Forms.Panel
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
