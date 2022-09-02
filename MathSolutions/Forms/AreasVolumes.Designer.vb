<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreasVolumes
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
        Me.txtBreadth = New System.Windows.Forms.TextBox
        Me.cboSolidFigures = New System.Windows.Forms.ComboBox
        Me.lblVolumesAreas = New System.Windows.Forms.Label
        Me.lblSolidFigures = New System.Windows.Forms.Label
        Me.cboVolumeArea = New System.Windows.Forms.ComboBox
        Me.SolidFigureToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblBreadth = New System.Windows.Forms.Label
        Me.formula = New System.Windows.Forms.RichTextBox
        Me.btnProof = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnSolve = New System.Windows.Forms.Button
        Me.txtVolumes = New System.Windows.Forms.TextBox
        Me.txtCurvedArea = New System.Windows.Forms.TextBox
        Me.txtTotalArea = New System.Windows.Forms.TextBox
        Me.txtBase = New System.Windows.Forms.TextBox
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.txtLength = New System.Windows.Forms.TextBox
        Me.txtRadius = New System.Windows.Forms.TextBox
        Me.lblLength = New System.Windows.Forms.Label
        Me.lblRadius = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblVolume = New System.Windows.Forms.Label
        Me.lblBase = New System.Windows.Forms.Label
        Me.lblHeight = New System.Windows.Forms.Label
        Me.lblCurvedArea = New System.Windows.Forms.Label
        Me.lblTotalArea = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBreadth
        '
        Me.txtBreadth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBreadth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBreadth.Location = New System.Drawing.Point(204, 167)
        Me.txtBreadth.Name = "txtBreadth"
        Me.txtBreadth.Size = New System.Drawing.Size(100, 26)
        Me.txtBreadth.TabIndex = 48
        Me.txtBreadth.Visible = False
        '
        'cboSolidFigures
        '
        Me.cboSolidFigures.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSolidFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSolidFigures.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSolidFigures.FormattingEnabled = True
        Me.cboSolidFigures.Location = New System.Drawing.Point(94, 8)
        Me.cboSolidFigures.Name = "cboSolidFigures"
        Me.cboSolidFigures.Size = New System.Drawing.Size(187, 24)
        Me.cboSolidFigures.TabIndex = 2
        Me.SolidFigureToolTip.SetToolTip(Me.cboSolidFigures, "Select Solid Figure")
        '
        'lblVolumesAreas
        '
        Me.lblVolumesAreas.AutoSize = True
        Me.lblVolumesAreas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolumesAreas.Location = New System.Drawing.Point(5, 14)
        Me.lblVolumesAreas.Name = "lblVolumesAreas"
        Me.lblVolumesAreas.Size = New System.Drawing.Size(79, 19)
        Me.lblVolumesAreas.TabIndex = 1
        Me.lblVolumesAreas.Text = "Calculation:"
        '
        'lblSolidFigures
        '
        Me.lblSolidFigures.AutoSize = True
        Me.lblSolidFigures.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolidFigures.Location = New System.Drawing.Point(3, 11)
        Me.lblSolidFigures.Name = "lblSolidFigures"
        Me.lblSolidFigures.Size = New System.Drawing.Size(95, 19)
        Me.lblSolidFigures.TabIndex = 0
        Me.lblSolidFigures.Text = "Solid Figures :"
        '
        'cboVolumeArea
        '
        Me.cboVolumeArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboVolumeArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVolumeArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVolumeArea.FormattingEnabled = True
        Me.cboVolumeArea.Location = New System.Drawing.Point(96, 7)
        Me.cboVolumeArea.Name = "cboVolumeArea"
        Me.cboVolumeArea.Size = New System.Drawing.Size(187, 24)
        Me.cboVolumeArea.TabIndex = 3
        Me.SolidFigureToolTip.SetToolTip(Me.cboVolumeArea, "Select part of solid figure  for solving")
        '
        'SolidFigureToolTip
        '
        Me.SolidFigureToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.SolidFigureToolTip.ToolTipTitle = "info:"
        '
        'lblBreadth
        '
        Me.lblBreadth.AutoSize = True
        Me.lblBreadth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreadth.Location = New System.Drawing.Point(64, 173)
        Me.lblBreadth.Name = "lblBreadth"
        Me.lblBreadth.Size = New System.Drawing.Size(64, 19)
        Me.lblBreadth.TabIndex = 50
        Me.lblBreadth.Text = "Breadth :"
        Me.lblBreadth.Visible = False
        '
        'formula
        '
        Me.formula.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.formula.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formula.Location = New System.Drawing.Point(35, 299)
        Me.formula.Name = "formula"
        Me.formula.ReadOnly = True
        Me.formula.Size = New System.Drawing.Size(287, 80)
        Me.formula.TabIndex = 69
        Me.formula.Text = ""
        Me.formula.Visible = False
        '
        'btnProof
        '
        Me.btnProof.AutoSize = True
        Me.btnProof.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProof.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProof.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProof.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProof.Location = New System.Drawing.Point(229, 260)
        Me.btnProof.Name = "btnProof"
        Me.btnProof.Size = New System.Drawing.Size(75, 31)
        Me.btnProof.TabIndex = 68
        Me.btnProof.Text = "&Proof"
        Me.btnProof.UseVisualStyleBackColor = True
        Me.btnProof.Visible = False
        '
        'btnReset
        '
        Me.btnReset.AutoSize = True
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(139, 260)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 31)
        Me.btnReset.TabIndex = 67
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'btnSolve
        '
        Me.btnSolve.AutoSize = True
        Me.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSolve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolve.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolve.Location = New System.Drawing.Point(58, 260)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 31)
        Me.btnSolve.TabIndex = 66
        Me.btnSolve.Text = "&Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        Me.btnSolve.Visible = False
        '
        'txtVolumes
        '
        Me.txtVolumes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVolumes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolumes.Location = New System.Drawing.Point(204, 195)
        Me.txtVolumes.Name = "txtVolumes"
        Me.txtVolumes.Size = New System.Drawing.Size(100, 26)
        Me.txtVolumes.TabIndex = 65
        Me.txtVolumes.Visible = False
        '
        'txtCurvedArea
        '
        Me.txtCurvedArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurvedArea.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurvedArea.Location = New System.Drawing.Point(204, 195)
        Me.txtCurvedArea.Name = "txtCurvedArea"
        Me.txtCurvedArea.Size = New System.Drawing.Size(100, 26)
        Me.txtCurvedArea.TabIndex = 64
        Me.txtCurvedArea.Visible = False
        '
        'txtTotalArea
        '
        Me.txtTotalArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalArea.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalArea.Location = New System.Drawing.Point(204, 195)
        Me.txtTotalArea.Name = "txtTotalArea"
        Me.txtTotalArea.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalArea.TabIndex = 63
        Me.txtTotalArea.Visible = False
        '
        'txtBase
        '
        Me.txtBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBase.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBase.Location = New System.Drawing.Point(204, 223)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(100, 26)
        Me.txtBase.TabIndex = 62
        Me.txtBase.Visible = False
        '
        'txtHeight
        '
        Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHeight.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(204, 195)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 26)
        Me.txtHeight.TabIndex = 57
        Me.txtHeight.Visible = False
        '
        'txtLength
        '
        Me.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLength.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(204, 167)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 26)
        Me.txtLength.TabIndex = 56
        Me.txtLength.Visible = False
        '
        'txtRadius
        '
        Me.txtRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRadius.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRadius.Location = New System.Drawing.Point(204, 136)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 26)
        Me.txtRadius.TabIndex = 55
        Me.txtRadius.Visible = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(64, 173)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(57, 19)
        Me.lblLength.TabIndex = 53
        Me.lblLength.Text = "Length :"
        Me.lblLength.Visible = False
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadius.Location = New System.Drawing.Point(64, 142)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(57, 19)
        Me.lblRadius.TabIndex = 52
        Me.lblRadius.Text = "Radius :"
        Me.lblRadius.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblVolumesAreas)
        Me.Panel2.Controls.Add(Me.cboVolumeArea)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(35, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(288, 41)
        Me.Panel2.TabIndex = 51
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cboSolidFigures)
        Me.Panel1.Controls.Add(Me.lblSolidFigures)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(35, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 41)
        Me.Panel1.TabIndex = 49
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(64, 201)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(61, 19)
        Me.lblVolume.TabIndex = 61
        Me.lblVolume.Text = "Volume :"
        Me.lblVolume.Visible = False
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(64, 229)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(79, 19)
        Me.lblBase.TabIndex = 58
        Me.lblBase.Text = "Base Area :"
        Me.lblBase.Visible = False
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(64, 201)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(55, 19)
        Me.lblHeight.TabIndex = 54
        Me.lblHeight.Text = "Height :"
        Me.lblHeight.Visible = False
        '
        'lblCurvedArea
        '
        Me.lblCurvedArea.AutoSize = True
        Me.lblCurvedArea.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurvedArea.Location = New System.Drawing.Point(64, 201)
        Me.lblCurvedArea.Name = "lblCurvedArea"
        Me.lblCurvedArea.Size = New System.Drawing.Size(111, 19)
        Me.lblCurvedArea.TabIndex = 60
        Me.lblCurvedArea.Text = "Curved S. Area :"
        Me.lblCurvedArea.Visible = False
        '
        'lblTotalArea
        '
        Me.lblTotalArea.AutoSize = True
        Me.lblTotalArea.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalArea.Location = New System.Drawing.Point(64, 201)
        Me.lblTotalArea.Name = "lblTotalArea"
        Me.lblTotalArea.Size = New System.Drawing.Size(96, 19)
        Me.lblTotalArea.TabIndex = 59
        Me.lblTotalArea.Text = "Total S. Area :"
        Me.lblTotalArea.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 22)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Areas && Volumes"
        '
        'AreasVolumes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 386)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBreadth)
        Me.Controls.Add(Me.lblBreadth)
        Me.Controls.Add(Me.formula)
        Me.Controls.Add(Me.btnProof)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.txtVolumes)
        Me.Controls.Add(Me.txtCurvedArea)
        Me.Controls.Add(Me.txtTotalArea)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblCurvedArea)
        Me.Controls.Add(Me.lblTotalArea)
        Me.MaximizeBox = False
        Me.Name = "AreasVolumes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Areas & Volumes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBreadth As System.Windows.Forms.TextBox
    Friend WithEvents cboSolidFigures As System.Windows.Forms.ComboBox
    Friend WithEvents SolidFigureToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblVolumesAreas As System.Windows.Forms.Label
    Friend WithEvents lblSolidFigures As System.Windows.Forms.Label
    Friend WithEvents cboVolumeArea As System.Windows.Forms.ComboBox
    Friend WithEvents lblBreadth As System.Windows.Forms.Label
    Friend WithEvents formula As System.Windows.Forms.RichTextBox
    Friend WithEvents btnProof As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Friend WithEvents txtVolumes As System.Windows.Forms.TextBox
    Friend WithEvents txtCurvedArea As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalArea As System.Windows.Forms.TextBox
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblRadius As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblCurvedArea As System.Windows.Forms.Label
    Friend WithEvents lblTotalArea As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
