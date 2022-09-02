<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NaturalNumbers
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
        Me.txtLast = New System.Windows.Forms.TextBox
        Me.txtFirst = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboSelect = New System.Windows.Forms.ComboBox
        Me.cmdEven = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNotes = New System.Windows.Forms.Label
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.lblNumber = New System.Windows.Forms.Label
        Me.pnlRoot = New System.Windows.Forms.Panel
        Me.txtRoot = New System.Windows.Forms.TextBox
        Me.lblRoot = New System.Windows.Forms.Label
        Me.pnlNum = New System.Windows.Forms.Panel
        Me.cmdClear = New System.Windows.Forms.Button
        Me.lstNumbers = New System.Windows.Forms.ListBox
        Me.cmdOdd = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlRoot.SuspendLayout()
        Me.pnlNum.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLast
        '
        Me.txtLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.Location = New System.Drawing.Point(87, 60)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(50, 26)
        Me.txtLast.TabIndex = 1
        '
        'txtFirst
        '
        Me.txtFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(87, 20)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(50, 26)
        Me.txtFirst.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(14, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(132, 27)
        Me.ComboBox1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Select Calculation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(201, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Label3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLast)
        Me.GroupBox1.Controls.Add(Me.txtFirst)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(204, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 92)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Range of Numbers"
        Me.GroupBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Last:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "First:"
        '
        'cboSelect
        '
        Me.cboSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelect.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Location = New System.Drawing.Point(206, 36)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(158, 27)
        Me.cboSelect.TabIndex = 1
        Me.cboSelect.Visible = False
        '
        'cmdEven
        '
        Me.cmdEven.AutoSize = True
        Me.cmdEven.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEven.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdEven.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEven.Location = New System.Drawing.Point(224, 145)
        Me.cmdEven.Name = "cmdEven"
        Me.cmdEven.Size = New System.Drawing.Size(118, 28)
        Me.cmdEven.TabIndex = 6
        Me.cmdEven.Text = "Even Numbers"
        Me.cmdEven.UseVisualStyleBackColor = True
        Me.cmdEven.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 412)
        Me.Panel1.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 156)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Select your choice as to solve for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "even or odd numbers, or roots and powers"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.White
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNotes.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(399, 10)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(175, 359)
        Me.txtNotes.TabIndex = 41
        Me.txtNotes.Text = "Label6"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(71, 5)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(92, 26)
        Me.txtNumber.TabIndex = 0
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(3, 8)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(62, 19)
        Me.lblNumber.TabIndex = 7
        Me.lblNumber.Text = "Number:"
        '
        'pnlRoot
        '
        Me.pnlRoot.Controls.Add(Me.txtRoot)
        Me.pnlRoot.Controls.Add(Me.lblRoot)
        Me.pnlRoot.Location = New System.Drawing.Point(204, 69)
        Me.pnlRoot.Name = "pnlRoot"
        Me.pnlRoot.Size = New System.Drawing.Size(172, 36)
        Me.pnlRoot.TabIndex = 3
        Me.pnlRoot.Visible = False
        '
        'txtRoot
        '
        Me.txtRoot.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoot.Location = New System.Drawing.Point(72, 6)
        Me.txtRoot.Name = "txtRoot"
        Me.txtRoot.Size = New System.Drawing.Size(91, 26)
        Me.txtRoot.TabIndex = 0
        '
        'lblRoot
        '
        Me.lblRoot.AutoSize = True
        Me.lblRoot.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoot.Location = New System.Drawing.Point(2, 9)
        Me.lblRoot.Name = "lblRoot"
        Me.lblRoot.Size = New System.Drawing.Size(64, 19)
        Me.lblRoot.TabIndex = 13
        Me.lblRoot.Text = "nth Root:"
        '
        'pnlNum
        '
        Me.pnlNum.Controls.Add(Me.txtNumber)
        Me.pnlNum.Controls.Add(Me.lblNumber)
        Me.pnlNum.Location = New System.Drawing.Point(204, 106)
        Me.pnlNum.Name = "pnlNum"
        Me.pnlNum.Size = New System.Drawing.Size(175, 33)
        Me.pnlNum.TabIndex = 4
        Me.pnlNum.Visible = False
        '
        'cmdClear
        '
        Me.cmdClear.AutoSize = True
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(235, 375)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(104, 29)
        Me.cmdClear.TabIndex = 7
        Me.cmdClear.Text = "&Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        Me.cmdClear.Visible = False
        '
        'lstNumbers
        '
        Me.lstNumbers.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.ItemHeight = 19
        Me.lstNumbers.Location = New System.Drawing.Point(170, 175)
        Me.lstNumbers.MultiColumn = True
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(218, 194)
        Me.lstNumbers.TabIndex = 31
        Me.lstNumbers.Visible = False
        '
        'cmdOdd
        '
        Me.cmdOdd.AutoSize = True
        Me.cmdOdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdOdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOdd.Location = New System.Drawing.Point(224, 145)
        Me.cmdOdd.Name = "cmdOdd"
        Me.cmdOdd.Size = New System.Drawing.Size(118, 28)
        Me.cmdOdd.TabIndex = 5
        Me.cmdOdd.Text = "Odd Numbers"
        Me.cmdOdd.UseVisualStyleBackColor = True
        Me.cmdOdd.Visible = False
        '
        'NaturalNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 414)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.cmdEven)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.pnlRoot)
        Me.Controls.Add(Me.pnlNum)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.lstNumbers)
        Me.Controls.Add(Me.cmdOdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "NaturalNumbers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NaturalNumbers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlRoot.ResumeLayout(False)
        Me.pnlRoot.PerformLayout()
        Me.pnlNum.ResumeLayout(False)
        Me.pnlNum.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents cmdEven As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents pnlRoot As System.Windows.Forms.Panel
    Friend WithEvents txtRoot As System.Windows.Forms.TextBox
    Friend WithEvents lblRoot As System.Windows.Forms.Label
    Friend WithEvents pnlNum As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents lstNumbers As System.Windows.Forms.ListBox
    Friend WithEvents cmdOdd As System.Windows.Forms.Button
End Class
