<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transformation
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
        Me.cboTrans = New System.Windows.Forms.ComboBox
        Me.lblTrans = New System.Windows.Forms.Label
        Me.txtX = New System.Windows.Forms.TextBox
        Me.txtY = New System.Windows.Forms.TextBox
        Me.cboSelect = New System.Windows.Forms.ComboBox
        Me.grpPoint = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtXa = New System.Windows.Forms.TextBox
        Me.txtYb = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpImage = New System.Windows.Forms.GroupBox
        Me.btnTrans = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblShow = New System.Windows.Forms.Label
        Me.lblFormula = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtA = New System.Windows.Forms.TextBox
        Me.lblA = New System.Windows.Forms.Label
        Me.lblB = New System.Windows.Forms.Label
        Me.txtB = New System.Windows.Forms.TextBox
        Me.grpOrigin = New System.Windows.Forms.GroupBox
        Me.grpScale = New System.Windows.Forms.GroupBox
        Me.txtK = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.grpPoint.SuspendLayout()
        Me.grpImage.SuspendLayout()
        Me.grpOrigin.SuspendLayout()
        Me.grpScale.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTrans
        '
        Me.cboTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrans.FormattingEnabled = True
        Me.cboTrans.Location = New System.Drawing.Point(9, 103)
        Me.cboTrans.Name = "cboTrans"
        Me.cboTrans.Size = New System.Drawing.Size(198, 27)
        Me.cboTrans.TabIndex = 0
        '
        'lblTrans
        '
        Me.lblTrans.AutoSize = True
        Me.lblTrans.Location = New System.Drawing.Point(10, 79)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(140, 19)
        Me.lblTrans.TabIndex = 1
        Me.lblTrans.Text = "Select Transformation"
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(11, 40)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(37, 26)
        Me.txtX.TabIndex = 0
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(54, 40)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(37, 26)
        Me.txtY.TabIndex = 1
        '
        'cboSelect
        '
        Me.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Location = New System.Drawing.Point(9, 154)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(198, 27)
        Me.cboSelect.TabIndex = 1
        Me.cboSelect.Visible = False
        '
        'grpPoint
        '
        Me.grpPoint.Controls.Add(Me.Label2)
        Me.grpPoint.Controls.Add(Me.Label1)
        Me.grpPoint.Controls.Add(Me.txtY)
        Me.grpPoint.Controls.Add(Me.txtX)
        Me.grpPoint.Enabled = False
        Me.grpPoint.Location = New System.Drawing.Point(213, 79)
        Me.grpPoint.Name = "grpPoint"
        Me.grpPoint.Size = New System.Drawing.Size(99, 75)
        Me.grpPoint.TabIndex = 2
        Me.grpPoint.TabStop = False
        Me.grpPoint.Text = "Point"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "x"
        '
        'txtXa
        '
        Me.txtXa.Location = New System.Drawing.Point(12, 45)
        Me.txtXa.Name = "txtXa"
        Me.txtXa.Size = New System.Drawing.Size(37, 26)
        Me.txtXa.TabIndex = 0
        '
        'txtYb
        '
        Me.txtYb.Location = New System.Drawing.Point(55, 45)
        Me.txtYb.Name = "txtYb"
        Me.txtYb.Size = New System.Drawing.Size(37, 26)
        Me.txtYb.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "x'"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "y'"
        '
        'grpImage
        '
        Me.grpImage.Controls.Add(Me.Label4)
        Me.grpImage.Controls.Add(Me.Label3)
        Me.grpImage.Controls.Add(Me.txtYb)
        Me.grpImage.Controls.Add(Me.txtXa)
        Me.grpImage.Enabled = False
        Me.grpImage.Location = New System.Drawing.Point(342, 79)
        Me.grpImage.Name = "grpImage"
        Me.grpImage.Size = New System.Drawing.Size(103, 82)
        Me.grpImage.TabIndex = 3
        Me.grpImage.TabStop = False
        Me.grpImage.Text = "Image"
        '
        'btnTrans
        '
        Me.btnTrans.Location = New System.Drawing.Point(213, 244)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(88, 29)
        Me.btnTrans.TabIndex = 5
        Me.btnTrans.Text = "Transform"
        Me.btnTrans.UseVisualStyleBackColor = True
        Me.btnTrans.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(363, 244)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 29)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'lblShow
        '
        Me.lblShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShow.Location = New System.Drawing.Point(175, 285)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(296, 50)
        Me.lblShow.TabIndex = 7
        Me.lblShow.Text = "Label5"
        Me.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblShow.Visible = False
        '
        'lblFormula
        '
        Me.lblFormula.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFormula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFormula.Location = New System.Drawing.Point(174, 367)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(297, 81)
        Me.lblFormula.TabIndex = 8
        Me.lblFormula.Text = "Label5"
        Me.lblFormula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormula.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(14, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(457, 69)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Transformations"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(199, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Formula"
        Me.Label6.Visible = False
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(10, 46)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(37, 26)
        Me.txtA.TabIndex = 0
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(20, 24)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(20, 19)
        Me.lblA.TabIndex = 0
        Me.lblA.Text = "a "
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(65, 24)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(17, 19)
        Me.lblB.TabIndex = 0
        Me.lblB.Text = "b"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(54, 46)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(37, 26)
        Me.txtB.TabIndex = 1
        '
        'grpOrigin
        '
        Me.grpOrigin.Controls.Add(Me.txtB)
        Me.grpOrigin.Controls.Add(Me.txtA)
        Me.grpOrigin.Controls.Add(Me.lblB)
        Me.grpOrigin.Controls.Add(Me.lblA)
        Me.grpOrigin.Location = New System.Drawing.Point(213, 156)
        Me.grpOrigin.Name = "grpOrigin"
        Me.grpOrigin.Size = New System.Drawing.Size(99, 82)
        Me.grpOrigin.TabIndex = 4
        Me.grpOrigin.TabStop = False
        Me.grpOrigin.Text = "Other Origin"
        Me.grpOrigin.Visible = False
        '
        'grpScale
        '
        Me.grpScale.Controls.Add(Me.txtK)
        Me.grpScale.Controls.Add(Me.Label7)
        Me.grpScale.Location = New System.Drawing.Point(346, 156)
        Me.grpScale.Name = "grpScale"
        Me.grpScale.Size = New System.Drawing.Size(108, 82)
        Me.grpScale.TabIndex = 5
        Me.grpScale.TabStop = False
        Me.grpScale.Text = "Scale Factor"
        Me.grpScale.Visible = False
        '
        'txtK
        '
        Me.txtK.Location = New System.Drawing.Point(10, 46)
        Me.txtK.Name = "txtK"
        Me.txtK.Size = New System.Drawing.Size(37, 26)
        Me.txtK.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "k"
        '
        'Transformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 457)
        Me.Controls.Add(Me.grpScale)
        Me.Controls.Add(Me.grpOrigin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.lblShow)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTrans)
        Me.Controls.Add(Me.grpImage)
        Me.Controls.Add(Me.grpPoint)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.lblTrans)
        Me.Controls.Add(Me.cboTrans)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Transformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transformations"
        Me.grpPoint.ResumeLayout(False)
        Me.grpPoint.PerformLayout()
        Me.grpImage.ResumeLayout(False)
        Me.grpImage.PerformLayout()
        Me.grpOrigin.ResumeLayout(False)
        Me.grpOrigin.PerformLayout()
        Me.grpScale.ResumeLayout(False)
        Me.grpScale.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTrans As System.Windows.Forms.ComboBox
    Friend WithEvents lblTrans As System.Windows.Forms.Label
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents grpPoint As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtXa As System.Windows.Forms.TextBox
    Friend WithEvents txtYb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpImage As System.Windows.Forms.GroupBox
    Friend WithEvents btnTrans As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblShow As System.Windows.Forms.Label
    Friend WithEvents lblFormula As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents grpOrigin As System.Windows.Forms.GroupBox
    Friend WithEvents grpScale As System.Windows.Forms.GroupBox
    Friend WithEvents txtK As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
