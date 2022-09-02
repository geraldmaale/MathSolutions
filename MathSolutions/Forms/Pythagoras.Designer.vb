<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pythagoras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOpp = New System.Windows.Forms.TextBox
        Me.txtAdj = New System.Windows.Forms.TextBox
        Me.txtHyp = New System.Windows.Forms.TextBox
        Me.btnSolve = New System.Windows.Forms.Button
        Me.txtClear = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pythagoras Theorem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "BC"
        '
        'txtOpp
        '
        Me.txtOpp.Location = New System.Drawing.Point(127, 74)
        Me.txtOpp.Name = "txtOpp"
        Me.txtOpp.Size = New System.Drawing.Size(100, 26)
        Me.txtOpp.TabIndex = 5
        '
        'txtAdj
        '
        Me.txtAdj.Location = New System.Drawing.Point(127, 113)
        Me.txtAdj.Name = "txtAdj"
        Me.txtAdj.Size = New System.Drawing.Size(100, 26)
        Me.txtAdj.TabIndex = 6
        '
        'txtHyp
        '
        Me.txtHyp.Location = New System.Drawing.Point(127, 152)
        Me.txtHyp.Name = "txtHyp"
        Me.txtHyp.Size = New System.Drawing.Size(100, 26)
        Me.txtHyp.TabIndex = 7
        '
        'btnSolve
        '
        Me.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSolve.Location = New System.Drawing.Point(45, 224)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 28)
        Me.btnSolve.TabIndex = 8
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'txtClear
        '
        Me.txtClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtClear.Location = New System.Drawing.Point(142, 224)
        Me.txtClear.Name = "txtClear"
        Me.txtClear.Size = New System.Drawing.Size(75, 28)
        Me.txtClear.TabIndex = 9
        Me.txtClear.Text = "&Clear"
        Me.txtClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.MathSolutions.My.Resources.Resources.right_angle
        Me.PictureBox1.Location = New System.Drawing.Point(252, 294)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(252, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 272)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Label5"
        '
        'Pythagoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 430)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtClear)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.txtHyp)
        Me.Controls.Add(Me.txtAdj)
        Me.Controls.Add(Me.txtOpp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Pythagoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pythagoras Theorem"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOpp As System.Windows.Forms.TextBox
    Friend WithEvents txtAdj As System.Windows.Forms.TextBox
    Friend WithEvents txtHyp As System.Windows.Forms.TextBox
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Friend WithEvents txtClear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
