<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreasPerimeters
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
        Me.btnProof = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cboAreas = New System.Windows.Forms.ComboBox
        Me.lblCalculation = New System.Windows.Forms.Label
        Me.lblPara1 = New System.Windows.Forms.Label
        Me.lblDiag1 = New System.Windows.Forms.Label
        Me.lblLength = New System.Windows.Forms.Label
        Me.lblPara2 = New System.Windows.Forms.Label
        Me.lblHeight = New System.Windows.Forms.Label
        Me.txtB = New System.Windows.Forms.TextBox
        Me.lblBase = New System.Windows.Forms.Label
        Me.PlaneFigureToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboAreaPerimeters = New System.Windows.Forms.ComboBox
        Me.txtProof = New System.Windows.Forms.RichTextBox
        Me.formula = New System.Windows.Forms.RichTextBox
        Me.lblArea = New System.Windows.Forms.Label
        Me.txtArea = New System.Windows.Forms.TextBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnSolve = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblChoose = New System.Windows.Forms.Label
        Me.lblWidth = New System.Windows.Forms.Label
        Me.lblRadius = New System.Windows.Forms.Label
        Me.lblDiag2 = New System.Windows.Forms.Label
        Me.lblAngle = New System.Windows.Forms.Label
        Me.txtA = New System.Windows.Forms.TextBox
        Me.lblB = New System.Windows.Forms.Label
        Me.lblA = New System.Windows.Forms.Label
        Me.txtRadius = New System.Windows.Forms.TextBox
        Me.txtLength = New System.Windows.Forms.TextBox
        Me.txtC = New System.Windows.Forms.TextBox
        Me.lblC = New System.Windows.Forms.Label
        Me.txtDiag1 = New System.Windows.Forms.TextBox
        Me.txtPara1 = New System.Windows.Forms.TextBox
        Me.txtBase = New System.Windows.Forms.TextBox
        Me.txtDiag2 = New System.Windows.Forms.TextBox
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.txtWidth = New System.Windows.Forms.TextBox
        Me.txtPara2 = New System.Windows.Forms.TextBox
        Me.txtD = New System.Windows.Forms.TextBox
        Me.txtAngle = New System.Windows.Forms.TextBox
        Me.lblD = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProof
        '
        Me.btnProof.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProof.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProof.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProof.Location = New System.Drawing.Point(222, 254)
        Me.btnProof.Name = "btnProof"
        Me.btnProof.Size = New System.Drawing.Size(75, 23)
        Me.btnProof.TabIndex = 97
        Me.btnProof.Text = "&Proof"
        Me.btnProof.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cboAreas)
        Me.Panel2.Controls.Add(Me.lblCalculation)
        Me.Panel2.Location = New System.Drawing.Point(22, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(288, 38)
        Me.Panel2.TabIndex = 101
        '
        'cboAreas
        '
        Me.cboAreas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAreas.FormattingEnabled = True
        Me.cboAreas.Location = New System.Drawing.Point(128, 7)
        Me.cboAreas.Name = "cboAreas"
        Me.cboAreas.Size = New System.Drawing.Size(148, 24)
        Me.cboAreas.TabIndex = 0
        Me.PlaneFigureToolTip.SetToolTip(Me.cboAreas, "Select Plane Figure for soiving")
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculation.Location = New System.Drawing.Point(1, 12)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(80, 16)
        Me.lblCalculation.TabIndex = 12
        Me.lblCalculation.Text = " Calculation:"
        '
        'lblPara1
        '
        Me.lblPara1.AutoSize = True
        Me.lblPara1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPara1.Location = New System.Drawing.Point(34, 133)
        Me.lblPara1.Name = "lblPara1"
        Me.lblPara1.Size = New System.Drawing.Size(98, 16)
        Me.lblPara1.TabIndex = 85
        Me.lblPara1.Text = "Parallel Side 1:"
        '
        'lblDiag1
        '
        Me.lblDiag1.AutoSize = True
        Me.lblDiag1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiag1.Location = New System.Drawing.Point(42, 133)
        Me.lblDiag1.Name = "lblDiag1"
        Me.lblDiag1.Size = New System.Drawing.Size(76, 16)
        Me.lblDiag1.TabIndex = 89
        Me.lblDiag1.Text = "Diagonal 1:"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(42, 133)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(51, 16)
        Me.lblLength.TabIndex = 86
        Me.lblLength.Text = "Length:"
        '
        'lblPara2
        '
        Me.lblPara2.AutoSize = True
        Me.lblPara2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPara2.Location = New System.Drawing.Point(35, 164)
        Me.lblPara2.Name = "lblPara2"
        Me.lblPara2.Size = New System.Drawing.Size(98, 16)
        Me.lblPara2.TabIndex = 83
        Me.lblPara2.Text = "Parallel Side 2:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(43, 164)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(50, 16)
        Me.lblHeight.TabIndex = 76
        Me.lblHeight.Text = "Height:"
        '
        'txtB
        '
        Me.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(72, 161)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(74, 22)
        Me.txtB.TabIndex = 80
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(42, 134)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(43, 16)
        Me.lblBase.TabIndex = 81
        Me.lblBase.Text = "Base:"
        '
        'PlaneFigureToolTip
        '
        Me.PlaneFigureToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.PlaneFigureToolTip.ToolTipTitle = "info:"
        '
        'cboAreaPerimeters
        '
        Me.cboAreaPerimeters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboAreaPerimeters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAreaPerimeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAreaPerimeters.FormattingEnabled = True
        Me.cboAreaPerimeters.Location = New System.Drawing.Point(152, 47)
        Me.cboAreaPerimeters.Name = "cboAreaPerimeters"
        Me.cboAreaPerimeters.Size = New System.Drawing.Size(148, 24)
        Me.cboAreaPerimeters.TabIndex = 68
        Me.PlaneFigureToolTip.SetToolTip(Me.cboAreaPerimeters, "Choose either Areas or Perimeters for plane figures")
        '
        'txtProof
        '
        Me.txtProof.BackColor = System.Drawing.Color.White
        Me.txtProof.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProof.Location = New System.Drawing.Point(336, 41)
        Me.txtProof.Name = "txtProof"
        Me.txtProof.Size = New System.Drawing.Size(188, 324)
        Me.txtProof.TabIndex = 99
        Me.txtProof.Text = ""
        '
        'formula
        '
        Me.formula.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.formula.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formula.Location = New System.Drawing.Point(22, 293)
        Me.formula.Name = "formula"
        Me.formula.ReadOnly = True
        Me.formula.Size = New System.Drawing.Size(288, 72)
        Me.formula.TabIndex = 98
        Me.formula.Text = ""
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(42, 225)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(40, 16)
        Me.lblArea.TabIndex = 70
        Me.lblArea.Text = "Area:"
        '
        'txtArea
        '
        Me.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(152, 222)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(139, 22)
        Me.txtArea.TabIndex = 94
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(130, 254)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 96
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSolve
        '
        Me.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSolve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolve.Location = New System.Drawing.Point(37, 254)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 23)
        Me.btnSolve.TabIndex = 95
        Me.btnSolve.Text = "&Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblChoose)
        Me.Panel1.Location = New System.Drawing.Point(22, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 33)
        Me.Panel1.TabIndex = 100
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.Location = New System.Drawing.Point(1, 9)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(49, 16)
        Me.lblChoose.TabIndex = 22
        Me.lblChoose.Text = "Select:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidth.Location = New System.Drawing.Point(43, 164)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(45, 16)
        Me.lblWidth.TabIndex = 73
        Me.lblWidth.Text = "Width:"
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadius.Location = New System.Drawing.Point(42, 133)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(54, 16)
        Me.lblRadius.TabIndex = 74
        Me.lblRadius.Text = "Radius:"
        '
        'lblDiag2
        '
        Me.lblDiag2.AutoSize = True
        Me.lblDiag2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiag2.Location = New System.Drawing.Point(43, 164)
        Me.lblDiag2.Name = "lblDiag2"
        Me.lblDiag2.Size = New System.Drawing.Size(76, 16)
        Me.lblDiag2.TabIndex = 79
        Me.lblDiag2.Text = "Diagonal 2:"
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngle.Location = New System.Drawing.Point(43, 164)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(64, 16)
        Me.lblAngle.TabIndex = 91
        Me.lblAngle.Text = "θ (Angle):"
        '
        'txtA
        '
        Me.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(72, 131)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(74, 22)
        Me.txtA.TabIndex = 78
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(36, 162)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(20, 16)
        Me.lblB.TabIndex = 103
        Me.lblB.Text = "B:"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(35, 134)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(20, 16)
        Me.lblA.TabIndex = 102
        Me.lblA.Text = "A:"
        '
        'txtRadius
        '
        Me.txtRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRadius.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRadius.Location = New System.Drawing.Point(152, 131)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(139, 22)
        Me.txtRadius.TabIndex = 72
        '
        'txtLength
        '
        Me.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(152, 131)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(139, 22)
        Me.txtLength.TabIndex = 69
        '
        'txtC
        '
        Me.txtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(211, 131)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(80, 22)
        Me.txtC.TabIndex = 82
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(173, 134)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(20, 16)
        Me.lblC.TabIndex = 104
        Me.lblC.Text = "C:"
        '
        'txtDiag1
        '
        Me.txtDiag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiag1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiag1.Location = New System.Drawing.Point(152, 131)
        Me.txtDiag1.Name = "txtDiag1"
        Me.txtDiag1.Size = New System.Drawing.Size(139, 22)
        Me.txtDiag1.TabIndex = 75
        '
        'txtPara1
        '
        Me.txtPara1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPara1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPara1.Location = New System.Drawing.Point(152, 131)
        Me.txtPara1.Name = "txtPara1"
        Me.txtPara1.Size = New System.Drawing.Size(139, 22)
        Me.txtPara1.TabIndex = 77
        '
        'txtBase
        '
        Me.txtBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBase.Location = New System.Drawing.Point(152, 131)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(139, 22)
        Me.txtBase.TabIndex = 71
        '
        'txtDiag2
        '
        Me.txtDiag2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiag2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiag2.Location = New System.Drawing.Point(152, 161)
        Me.txtDiag2.Name = "txtDiag2"
        Me.txtDiag2.Size = New System.Drawing.Size(139, 22)
        Me.txtDiag2.TabIndex = 90
        '
        'txtHeight
        '
        Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(152, 161)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(139, 22)
        Me.txtHeight.TabIndex = 92
        '
        'txtWidth
        '
        Me.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWidth.Location = New System.Drawing.Point(152, 161)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(139, 22)
        Me.txtWidth.TabIndex = 88
        '
        'txtPara2
        '
        Me.txtPara2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPara2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPara2.Location = New System.Drawing.Point(152, 161)
        Me.txtPara2.Name = "txtPara2"
        Me.txtPara2.Size = New System.Drawing.Size(139, 22)
        Me.txtPara2.TabIndex = 87
        '
        'txtD
        '
        Me.txtD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD.Location = New System.Drawing.Point(211, 161)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(80, 22)
        Me.txtD.TabIndex = 84
        '
        'txtAngle
        '
        Me.txtAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAngle.Location = New System.Drawing.Point(152, 161)
        Me.txtAngle.Name = "txtAngle"
        Me.txtAngle.Size = New System.Drawing.Size(139, 22)
        Me.txtAngle.TabIndex = 93
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(173, 164)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(21, 16)
        Me.lblD.TabIndex = 105
        Me.lblD.Text = "D:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 22)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Areas && Perimeters"
        '
        'AreasPerimeters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 377)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProof)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblPara1)
        Me.Controls.Add(Me.lblDiag1)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblPara2)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.txtProof)
        Me.Controls.Add(Me.cboAreaPerimeters)
        Me.Controls.Add(Me.formula)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.lblDiag2)
        Me.Controls.Add(Me.lblAngle)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.txtDiag1)
        Me.Controls.Add(Me.txtPara1)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.txtDiag2)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtPara2)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtAngle)
        Me.Controls.Add(Me.lblD)
        Me.MaximizeBox = False
        Me.Name = "AreasPerimeters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Areas & Perimeters"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProof As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboAreas As System.Windows.Forms.ComboBox
    Friend WithEvents PlaneFigureToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblCalculation As System.Windows.Forms.Label
    Friend WithEvents lblPara1 As System.Windows.Forms.Label
    Friend WithEvents lblDiag1 As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblPara2 As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents cboAreaPerimeters As System.Windows.Forms.ComboBox
    Friend WithEvents txtProof As System.Windows.Forms.RichTextBox
    Friend WithEvents formula As System.Windows.Forms.RichTextBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblChoose As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblRadius As System.Windows.Forms.Label
    Friend WithEvents lblDiag2 As System.Windows.Forms.Label
    Friend WithEvents lblAngle As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents txtDiag1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPara1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents txtDiag2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtPara2 As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents txtAngle As System.Windows.Forms.TextBox
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
