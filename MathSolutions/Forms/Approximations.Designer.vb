<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Approximations
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.txtAns = New System.Windows.Forms.TextBox
        Me.cboApprox = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblApprox = New System.Windows.Forms.Label
        Me.pnlNumber = New System.Windows.Forms.Panel
        Me.btnApprox = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.pnlApprox = New System.Windows.Forms.Panel
        Me.lblNote = New System.Windows.Forms.Label
        Me.pnlNumber.SuspendLayout()
        Me.pnlApprox.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboSelect
        '
        Me.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Location = New System.Drawing.Point(15, 68)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(121, 27)
        Me.cboSelect.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Answer"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(3, 27)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(124, 26)
        Me.txtNum.TabIndex = 3
        '
        'txtAns
        '
        Me.txtAns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAns.ForeColor = System.Drawing.Color.Black
        Me.txtAns.Location = New System.Drawing.Point(3, 86)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.ReadOnly = True
        Me.txtAns.Size = New System.Drawing.Size(124, 26)
        Me.txtAns.TabIndex = 4
        '
        'cboApprox
        '
        Me.cboApprox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApprox.FormattingEnabled = True
        Me.cboApprox.ItemHeight = 19
        Me.cboApprox.Location = New System.Drawing.Point(3, 25)
        Me.cboApprox.MaxDropDownItems = 10
        Me.cboApprox.Name = "cboApprox"
        Me.cboApprox.Size = New System.Drawing.Size(121, 27)
        Me.cboApprox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Select"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Approximation"
        '
        'lblApprox
        '
        Me.lblApprox.AutoSize = True
        Me.lblApprox.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApprox.Location = New System.Drawing.Point(113, 9)
        Me.lblApprox.Name = "lblApprox"
        Me.lblApprox.Size = New System.Drawing.Size(161, 22)
        Me.lblApprox.TabIndex = 8
        Me.lblApprox.Text = "Approximations"
        '
        'pnlNumber
        '
        Me.pnlNumber.Controls.Add(Me.txtAns)
        Me.pnlNumber.Controls.Add(Me.Label2)
        Me.pnlNumber.Controls.Add(Me.txtNum)
        Me.pnlNumber.Controls.Add(Me.Label1)
        Me.pnlNumber.Location = New System.Drawing.Point(200, 85)
        Me.pnlNumber.Name = "pnlNumber"
        Me.pnlNumber.Size = New System.Drawing.Size(130, 120)
        Me.pnlNumber.TabIndex = 9
        Me.pnlNumber.Visible = False
        '
        'btnApprox
        '
        Me.btnApprox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApprox.Location = New System.Drawing.Point(15, 171)
        Me.btnApprox.Name = "btnApprox"
        Me.btnApprox.Size = New System.Drawing.Size(121, 34)
        Me.btnApprox.TabIndex = 11
        Me.btnApprox.Text = "Correct to"
        Me.btnApprox.UseVisualStyleBackColor = True
        Me.btnApprox.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(137, 245)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'pnlApprox
        '
        Me.pnlApprox.Controls.Add(Me.Label4)
        Me.pnlApprox.Controls.Add(Me.cboApprox)
        Me.pnlApprox.Location = New System.Drawing.Point(12, 101)
        Me.pnlApprox.Name = "pnlApprox"
        Me.pnlApprox.Size = New System.Drawing.Size(133, 63)
        Me.pnlApprox.TabIndex = 13
        Me.pnlApprox.Visible = False
        '
        'lblNote
        '
        Me.lblNote.ForeColor = System.Drawing.Color.Blue
        Me.lblNote.Location = New System.Drawing.Point(174, 48)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(188, 19)
        Me.lblNote.TabIndex = 14
        Me.lblNote.Text = "Correct to 2 d.p."
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNote.Visible = False
        '
        'Approximations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 302)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.pnlApprox)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnApprox)
        Me.Controls.Add(Me.pnlNumber)
        Me.Controls.Add(Me.lblApprox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboSelect)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Approximations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approximations"
        Me.pnlNumber.ResumeLayout(False)
        Me.pnlNumber.PerformLayout()
        Me.pnlApprox.ResumeLayout(False)
        Me.pnlApprox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents cboApprox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblApprox As System.Windows.Forms.Label
    Friend WithEvents pnlNumber As System.Windows.Forms.Panel
    Friend WithEvents btnApprox As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents pnlApprox As System.Windows.Forms.Panel
    Friend WithEvents lblNote As System.Windows.Forms.Label
End Class
