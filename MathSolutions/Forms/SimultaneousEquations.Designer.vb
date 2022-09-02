<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimultaneousEquations
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
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSolve = New System.Windows.Forms.Button
        Me.txtz = New System.Windows.Forms.TextBox
        Me.txty = New System.Windows.Forms.TextBox
        Me.txtx = New System.Windows.Forms.TextBox
        Me.cboDim = New System.Windows.Forms.ComboBox
        Me.Text1_27 = New System.Windows.Forms.TextBox
        Me.Text1_26 = New System.Windows.Forms.TextBox
        Me.Text1_25 = New System.Windows.Forms.TextBox
        Me.Text1_12 = New System.Windows.Forms.TextBox
        Me.Text1_11 = New System.Windows.Forms.TextBox
        Me.Text1_10 = New System.Windows.Forms.TextBox
        Me.Text1_7 = New System.Windows.Forms.TextBox
        Me.Text1_6 = New System.Windows.Forms.TextBox
        Me.Text1_5 = New System.Windows.Forms.TextBox
        Me.Text1_2 = New System.Windows.Forms.TextBox
        Me.Text1_1 = New System.Windows.Forms.TextBox
        Me.Text1_0 = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2_2 = New System.Windows.Forms.Label
        Me.Label2_1 = New System.Windows.Forms.Label
        Me.Label2_0 = New System.Windows.Forms.Label
        Me.lblc = New System.Windows.Forms.Label
        Me.lblb = New System.Windows.Forms.Label
        Me.lbla = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(185, 162)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 46)
        Me.btnClear.TabIndex = 321
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 33)
        Me.Label1.TabIndex = 320
        Me.Label1.Text = "Equations"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSolve
        '
        Me.btnSolve.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolve.Location = New System.Drawing.Point(93, 162)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(86, 46)
        Me.btnSolve.TabIndex = 319
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'txtz
        '
        Me.txtz.AcceptsReturn = True
        Me.txtz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtz.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtz.Location = New System.Drawing.Point(286, 111)
        Me.txtz.MaxLength = 0
        Me.txtz.Name = "txtz"
        Me.txtz.ReadOnly = True
        Me.txtz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtz.Size = New System.Drawing.Size(58, 26)
        Me.txtz.TabIndex = 315
        Me.txtz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtz.Visible = False
        '
        'txty
        '
        Me.txty.AcceptsReturn = True
        Me.txty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txty.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txty.Location = New System.Drawing.Point(286, 87)
        Me.txty.MaxLength = 0
        Me.txty.Name = "txty"
        Me.txty.ReadOnly = True
        Me.txty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txty.Size = New System.Drawing.Size(58, 26)
        Me.txty.TabIndex = 314
        Me.txty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtx
        '
        Me.txtx.AcceptsReturn = True
        Me.txtx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtx.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtx.Location = New System.Drawing.Point(286, 63)
        Me.txtx.MaxLength = 0
        Me.txtx.Name = "txtx"
        Me.txtx.ReadOnly = True
        Me.txtx.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtx.Size = New System.Drawing.Size(58, 26)
        Me.txtx.TabIndex = 313
        Me.txtx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboDim
        '
        Me.cboDim.AllowDrop = True
        Me.cboDim.BackColor = System.Drawing.SystemColors.Window
        Me.cboDim.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDim.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDim.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDim.Location = New System.Drawing.Point(12, 87)
        Me.cboDim.Name = "cboDim"
        Me.cboDim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDim.Size = New System.Drawing.Size(67, 27)
        Me.cboDim.TabIndex = 316
        '
        'Text1_27
        '
        Me.Text1_27.AcceptsReturn = True
        Me.Text1_27.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_27.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_27.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_27.Location = New System.Drawing.Point(234, 111)
        Me.Text1_27.MaxLength = 0
        Me.Text1_27.Name = "Text1_27"
        Me.Text1_27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_27.Size = New System.Drawing.Size(37, 26)
        Me.Text1_27.TabIndex = 309
        Me.Text1_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text1_27.Visible = False
        '
        'Text1_26
        '
        Me.Text1_26.AcceptsReturn = True
        Me.Text1_26.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_26.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_26.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_26.Location = New System.Drawing.Point(234, 87)
        Me.Text1_26.MaxLength = 0
        Me.Text1_26.Name = "Text1_26"
        Me.Text1_26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_26.Size = New System.Drawing.Size(37, 26)
        Me.Text1_26.TabIndex = 308
        Me.Text1_26.Text = "13"
        Me.Text1_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Text1_25
        '
        Me.Text1_25.AcceptsReturn = True
        Me.Text1_25.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_25.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_25.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_25.Location = New System.Drawing.Point(234, 63)
        Me.Text1_25.MaxLength = 0
        Me.Text1_25.Name = "Text1_25"
        Me.Text1_25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_25.Size = New System.Drawing.Size(37, 26)
        Me.Text1_25.TabIndex = 307
        Me.Text1_25.Text = "7"
        Me.Text1_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Text1_12
        '
        Me.Text1_12.AcceptsReturn = True
        Me.Text1_12.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_12.Location = New System.Drawing.Point(172, 111)
        Me.Text1_12.MaxLength = 0
        Me.Text1_12.Name = "Text1_12"
        Me.Text1_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_12.Size = New System.Drawing.Size(37, 26)
        Me.Text1_12.TabIndex = 303
        Me.Text1_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text1_12.Visible = False
        '
        'Text1_11
        '
        Me.Text1_11.AcceptsReturn = True
        Me.Text1_11.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_11.Location = New System.Drawing.Point(132, 111)
        Me.Text1_11.MaxLength = 0
        Me.Text1_11.Name = "Text1_11"
        Me.Text1_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_11.Size = New System.Drawing.Size(37, 26)
        Me.Text1_11.TabIndex = 302
        Me.Text1_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text1_11.Visible = False
        '
        'Text1_10
        '
        Me.Text1_10.AcceptsReturn = True
        Me.Text1_10.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_10.Location = New System.Drawing.Point(92, 111)
        Me.Text1_10.MaxLength = 0
        Me.Text1_10.Name = "Text1_10"
        Me.Text1_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_10.Size = New System.Drawing.Size(37, 26)
        Me.Text1_10.TabIndex = 301
        Me.Text1_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text1_10.Visible = False
        '
        'Text1_7
        '
        Me.Text1_7.AcceptsReturn = True
        Me.Text1_7.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_7.Location = New System.Drawing.Point(172, 87)
        Me.Text1_7.MaxLength = 0
        Me.Text1_7.Name = "Text1_7"
        Me.Text1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_7.Size = New System.Drawing.Size(37, 26)
        Me.Text1_7.TabIndex = 300
        Me.Text1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text1_7.Visible = False
        '
        'Text1_6
        '
        Me.Text1_6.AcceptsReturn = True
        Me.Text1_6.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_6.Location = New System.Drawing.Point(132, 87)
        Me.Text1_6.MaxLength = 0
        Me.Text1_6.Name = "Text1_6"
        Me.Text1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_6.Size = New System.Drawing.Size(37, 26)
        Me.Text1_6.TabIndex = 299
        Me.Text1_6.Text = "4"
        Me.Text1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Text1_5
        '
        Me.Text1_5.AcceptsReturn = True
        Me.Text1_5.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_5.Location = New System.Drawing.Point(92, 87)
        Me.Text1_5.MaxLength = 0
        Me.Text1_5.Name = "Text1_5"
        Me.Text1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_5.Size = New System.Drawing.Size(37, 26)
        Me.Text1_5.TabIndex = 298
        Me.Text1_5.Text = "5"
        Me.Text1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Text1_2
        '
        Me.Text1_2.AcceptsReturn = True
        Me.Text1_2.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_2.Location = New System.Drawing.Point(172, 63)
        Me.Text1_2.MaxLength = 0
        Me.Text1_2.Name = "Text1_2"
        Me.Text1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_2.Size = New System.Drawing.Size(37, 26)
        Me.Text1_2.TabIndex = 297
        Me.Text1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text1_2.Visible = False
        '
        'Text1_1
        '
        Me.Text1_1.AcceptsReturn = True
        Me.Text1_1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_1.Location = New System.Drawing.Point(132, 63)
        Me.Text1_1.MaxLength = 0
        Me.Text1_1.Name = "Text1_1"
        Me.Text1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_1.Size = New System.Drawing.Size(37, 26)
        Me.Text1_1.TabIndex = 296
        Me.Text1_1.Text = "2"
        Me.Text1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Text1_0
        '
        Me.Text1_0.AcceptsReturn = True
        Me.Text1_0.BackColor = System.Drawing.SystemColors.Window
        Me.Text1_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1_0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1_0.Location = New System.Drawing.Point(92, 63)
        Me.Text1_0.MaxLength = 0
        Me.Text1_0.Name = "Text1_0"
        Me.Text1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1_0.Size = New System.Drawing.Size(37, 26)
        Me.Text1_0.TabIndex = 295
        Me.Text1_0.Text = "3"
        Me.Text1_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(283, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 318
        Me.Label5.Text = "Solution"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(72, 38)
        Me.Label3.TabIndex = 317
        Me.Label3.Text = "System " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Variables"
        '
        'Label2_2
        '
        Me.Label2_2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_2.Location = New System.Drawing.Point(210, 111)
        Me.Label2_2.Name = "Label2_2"
        Me.Label2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_2.Size = New System.Drawing.Size(25, 17)
        Me.Label2_2.TabIndex = 312
        Me.Label2_2.Text = "="
        Me.Label2_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2_2.Visible = False
        '
        'Label2_1
        '
        Me.Label2_1.BackColor = System.Drawing.SystemColors.Control
        Me.Label2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_1.Location = New System.Drawing.Point(210, 87)
        Me.Label2_1.Name = "Label2_1"
        Me.Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_1.Size = New System.Drawing.Size(25, 17)
        Me.Label2_1.TabIndex = 311
        Me.Label2_1.Text = "="
        Me.Label2_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2_0
        '
        Me.Label2_0.BackColor = System.Drawing.SystemColors.Control
        Me.Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_0.Location = New System.Drawing.Point(210, 63)
        Me.Label2_0.Name = "Label2_0"
        Me.Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_0.Size = New System.Drawing.Size(25, 17)
        Me.Label2_0.TabIndex = 310
        Me.Label2_0.Text = "="
        Me.Label2_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblc
        '
        Me.lblc.AutoSize = True
        Me.lblc.BackColor = System.Drawing.SystemColors.Control
        Me.lblc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblc.Location = New System.Drawing.Point(181, 42)
        Me.lblc.Name = "lblc"
        Me.lblc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblc.Size = New System.Drawing.Size(16, 19)
        Me.lblc.TabIndex = 306
        Me.lblc.Text = "c"
        Me.lblc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblc.Visible = False
        '
        'lblb
        '
        Me.lblb.AutoSize = True
        Me.lblb.BackColor = System.Drawing.SystemColors.Control
        Me.lblb.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblb.Location = New System.Drawing.Point(141, 42)
        Me.lblb.Name = "lblb"
        Me.lblb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblb.Size = New System.Drawing.Size(17, 19)
        Me.lblb.TabIndex = 305
        Me.lblb.Text = "b"
        Me.lblb.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.BackColor = System.Drawing.SystemColors.Control
        Me.lbla.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbla.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbla.Location = New System.Drawing.Point(101, 42)
        Me.lbla.Name = "lbla"
        Me.lbla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbla.Size = New System.Drawing.Size(17, 19)
        Me.lbla.TabIndex = 304
        Me.lbla.Text = "a"
        Me.lbla.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SimultaneousEquations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 230)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.txtz)
        Me.Controls.Add(Me.txty)
        Me.Controls.Add(Me.txtx)
        Me.Controls.Add(Me.cboDim)
        Me.Controls.Add(Me.Text1_27)
        Me.Controls.Add(Me.Text1_26)
        Me.Controls.Add(Me.Text1_25)
        Me.Controls.Add(Me.Text1_12)
        Me.Controls.Add(Me.Text1_11)
        Me.Controls.Add(Me.Text1_10)
        Me.Controls.Add(Me.Text1_7)
        Me.Controls.Add(Me.Text1_6)
        Me.Controls.Add(Me.Text1_5)
        Me.Controls.Add(Me.Text1_2)
        Me.Controls.Add(Me.Text1_1)
        Me.Controls.Add(Me.Text1_0)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2_2)
        Me.Controls.Add(Me.Label2_1)
        Me.Controls.Add(Me.Label2_0)
        Me.Controls.Add(Me.lblc)
        Me.Controls.Add(Me.lblb)
        Me.Controls.Add(Me.lbla)
        Me.MaximizeBox = False
        Me.Name = "SimultaneousEquations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SimultaneousEquations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Public WithEvents txtz As System.Windows.Forms.TextBox
    Public WithEvents txty As System.Windows.Forms.TextBox
    Public WithEvents txtx As System.Windows.Forms.TextBox
    Public WithEvents cboDim As System.Windows.Forms.ComboBox
    Public WithEvents Text1_27 As System.Windows.Forms.TextBox
    Public WithEvents Text1_26 As System.Windows.Forms.TextBox
    Public WithEvents Text1_25 As System.Windows.Forms.TextBox
    Public WithEvents Text1_12 As System.Windows.Forms.TextBox
    Public WithEvents Text1_11 As System.Windows.Forms.TextBox
    Public WithEvents Text1_10 As System.Windows.Forms.TextBox
    Public WithEvents Text1_7 As System.Windows.Forms.TextBox
    Public WithEvents Text1_6 As System.Windows.Forms.TextBox
    Public WithEvents Text1_5 As System.Windows.Forms.TextBox
    Public WithEvents Text1_2 As System.Windows.Forms.TextBox
    Public WithEvents Text1_1 As System.Windows.Forms.TextBox
    Public WithEvents Text1_0 As System.Windows.Forms.TextBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2_2 As System.Windows.Forms.Label
    Public WithEvents Label2_1 As System.Windows.Forms.Label
    Public WithEvents Label2_0 As System.Windows.Forms.Label
    Public WithEvents lblc As System.Windows.Forms.Label
    Public WithEvents lblb As System.Windows.Forms.Label
    Public WithEvents lbla As System.Windows.Forms.Label
End Class
