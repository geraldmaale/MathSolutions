<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Polygons
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSides = New System.Windows.Forms.Label
        Me.txtSides = New System.Windows.Forms.TextBox
        Me.txtPoly = New System.Windows.Forms.TextBox
        Me.lblPoly = New System.Windows.Forms.Label
        Me.btnSolve = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboAngle = New System.Windows.Forms.ComboBox
        Me.lblProof = New System.Windows.Forms.Label
        Me.btnProof = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angles of a Regular Polygon"
        '
        'lblSides
        '
        Me.lblSides.AutoSize = True
        Me.lblSides.Location = New System.Drawing.Point(171, 49)
        Me.lblSides.Name = "lblSides"
        Me.lblSides.Size = New System.Drawing.Size(112, 19)
        Me.lblSides.TabIndex = 3
        Me.lblSides.Text = "Number of Sides"
        '
        'txtSides
        '
        Me.txtSides.Location = New System.Drawing.Point(175, 71)
        Me.txtSides.Name = "txtSides"
        Me.txtSides.Size = New System.Drawing.Size(100, 26)
        Me.txtSides.TabIndex = 4
        '
        'txtPoly
        '
        Me.txtPoly.Location = New System.Drawing.Point(175, 134)
        Me.txtPoly.Name = "txtPoly"
        Me.txtPoly.Size = New System.Drawing.Size(100, 26)
        Me.txtPoly.TabIndex = 5
        '
        'lblPoly
        '
        Me.lblPoly.AutoSize = True
        Me.lblPoly.Location = New System.Drawing.Point(171, 112)
        Me.lblPoly.Name = "lblPoly"
        Me.lblPoly.Size = New System.Drawing.Size(58, 19)
        Me.lblPoly.TabIndex = 6
        Me.lblPoly.Text = "Polygon"
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(186, 171)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 29)
        Me.btnSolve.TabIndex = 7
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(186, 261)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 29)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angle of polygon"
        '
        'cboAngle
        '
        Me.cboAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAngle.FormattingEnabled = True
        Me.cboAngle.Location = New System.Drawing.Point(8, 70)
        Me.cboAngle.Name = "cboAngle"
        Me.cboAngle.Size = New System.Drawing.Size(152, 27)
        Me.cboAngle.TabIndex = 2
        '
        'lblProof
        '
        Me.lblProof.BackColor = System.Drawing.Color.White
        Me.lblProof.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProof.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProof.Location = New System.Drawing.Point(293, 71)
        Me.lblProof.Name = "lblProof"
        Me.lblProof.Size = New System.Drawing.Size(168, 224)
        Me.lblProof.TabIndex = 9
        Me.lblProof.Text = "Show Proof"
        '
        'btnProof
        '
        Me.btnProof.Location = New System.Drawing.Point(186, 215)
        Me.btnProof.Name = "btnProof"
        Me.btnProof.Size = New System.Drawing.Size(75, 31)
        Me.btnProof.TabIndex = 10
        Me.btnProof.Text = "Proof"
        Me.btnProof.UseVisualStyleBackColor = True
        Me.btnProof.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 180)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Label3"
        '
        'Polygons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 302)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnProof)
        Me.Controls.Add(Me.lblProof)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.lblPoly)
        Me.Controls.Add(Me.txtPoly)
        Me.Controls.Add(Me.txtSides)
        Me.Controls.Add(Me.lblSides)
        Me.Controls.Add(Me.cboAngle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Polygons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polygons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSides As System.Windows.Forms.Label
    Friend WithEvents txtSides As System.Windows.Forms.TextBox
    Friend WithEvents txtPoly As System.Windows.Forms.TextBox
    Friend WithEvents lblPoly As System.Windows.Forms.Label
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAngle As System.Windows.Forms.ComboBox
    Friend WithEvents lblProof As System.Windows.Forms.Label
    Friend WithEvents btnProof As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
