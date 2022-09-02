<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrainBox
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
        Me.txtNum2 = New System.Windows.Forms.TextBox
        Me.rbMult = New System.Windows.Forms.RadioButton
        Me.rbSub = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.rbAdd = New System.Windows.Forms.RadioButton
        Me.Score = New System.Windows.Forms.TextBox
        Me.cmdNext = New System.Windows.Forms.Button
        Me.Message = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.lblSign = New System.Windows.Forms.Label
        Me.rbDiv = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdNew = New System.Windows.Forms.Button
        Me.grp1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMin = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtMax = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.grp2 = New System.Windows.Forms.GroupBox
        Me.txtAnswer = New System.Windows.Forms.TextBox
        Me.txtNum1 = New System.Windows.Forms.TextBox
        Me.GroupBox3.SuspendLayout()
        Me.grp1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.grp2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNum2
        '
        Me.txtNum2.BackColor = System.Drawing.Color.White
        Me.txtNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNum2.Enabled = False
        Me.txtNum2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(135, 21)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(65, 39)
        Me.txtNum2.TabIndex = 3
        Me.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbMult
        '
        Me.rbMult.AutoSize = True
        Me.rbMult.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMult.Location = New System.Drawing.Point(273, 15)
        Me.rbMult.Name = "rbMult"
        Me.rbMult.Size = New System.Drawing.Size(44, 33)
        Me.rbMult.TabIndex = 38
        Me.rbMult.Text = "x"
        Me.rbMult.UseVisualStyleBackColor = True
        '
        'rbSub
        '
        Me.rbSub.AutoSize = True
        Me.rbSub.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSub.Location = New System.Drawing.Point(117, 15)
        Me.rbSub.Name = "rbSub"
        Me.rbSub.Size = New System.Drawing.Size(39, 33)
        Me.rbSub.TabIndex = 36
        Me.rbSub.Text = "-"
        Me.rbSub.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(138, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 22)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Brain Box"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbAdd
        '
        Me.rbAdd.AutoSize = True
        Me.rbAdd.Checked = True
        Me.rbAdd.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdd.Location = New System.Drawing.Point(28, 15)
        Me.rbAdd.Name = "rbAdd"
        Me.rbAdd.Size = New System.Drawing.Size(45, 33)
        Me.rbAdd.TabIndex = 35
        Me.rbAdd.TabStop = True
        Me.rbAdd.Text = "+"
        Me.rbAdd.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.Score.BackColor = System.Drawing.Color.White
        Me.Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Score.Enabled = False
        Me.Score.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.ForeColor = System.Drawing.Color.Red
        Me.Score.Location = New System.Drawing.Point(19, 18)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(100, 39)
        Me.Score.TabIndex = 5
        Me.Score.Text = "0"
        Me.Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdNext
        '
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(71, 347)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(104, 48)
        Me.cmdNext.TabIndex = 4
        Me.cmdNext.Text = "&Next Problem"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'Message
        '
        Me.Message.BackColor = System.Drawing.Color.White
        Me.Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Message.Enabled = False
        Me.Message.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message.ForeColor = System.Drawing.Color.Red
        Me.Message.Location = New System.Drawing.Point(131, 24)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(186, 29)
        Me.Message.TabIndex = 6
        Me.Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(244, 19)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(70, 39)
        Me.TextBox8.TabIndex = 4
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSign.Location = New System.Drawing.Point(95, 23)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(24, 25)
        Me.lblSign.TabIndex = 15
        Me.lblSign.Text = "+"
        '
        'rbDiv
        '
        Me.rbDiv.AutoSize = True
        Me.rbDiv.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDiv.Location = New System.Drawing.Point(199, 15)
        Me.rbDiv.Name = "rbDiv"
        Me.rbDiv.Size = New System.Drawing.Size(38, 33)
        Me.rbDiv.TabIndex = 37
        Me.rbDiv.Text = "/"
        Me.rbDiv.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Score)
        Me.GroupBox3.Controls.Add(Me.Message)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(14, 268)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(333, 62)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Display"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "="
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(206, 347)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(95, 48)
        Me.cmdNew.TabIndex = 5
        Me.cmdNew.Text = "New Numbers"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'grp1
        '
        Me.grp1.BackColor = System.Drawing.SystemColors.Control
        Me.grp1.Controls.Add(Me.Button4)
        Me.grp1.Controls.Add(Me.Label6)
        Me.grp1.Controls.Add(Me.GroupBox6)
        Me.grp1.Controls.Add(Me.Label2)
        Me.grp1.Controls.Add(Me.txtMin)
        Me.grp1.Controls.Add(Me.GroupBox4)
        Me.grp1.Controls.Add(Me.txtMax)
        Me.grp1.Controls.Add(Me.Button3)
        Me.grp1.Controls.Add(Me.Label13)
        Me.grp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp1.ForeColor = System.Drawing.Color.Black
        Me.grp1.Location = New System.Drawing.Point(14, 39)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(333, 66)
        Me.grp1.TabIndex = 0
        Me.grp1.TabStop = False
        Me.grp1.Text = "Type Range for Solving:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(178, 264)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 48)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "New Numbers"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(169, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Max Number:"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.TextBox13)
        Me.GroupBox6.Controls.Add(Me.TextBox14)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(0, 185)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(333, 62)
        Me.GroupBox6.TabIndex = 32
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Display"
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.White
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox13.Enabled = False
        Me.TextBox13.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.ForeColor = System.Drawing.Color.Red
        Me.TextBox13.Location = New System.Drawing.Point(19, 17)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 39)
        Me.TextBox13.TabIndex = 5
        Me.TextBox13.Text = "0"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.White
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox14.Enabled = False
        Me.TextBox14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.ForeColor = System.Drawing.Color.Red
        Me.TextBox14.Location = New System.Drawing.Point(131, 22)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(186, 29)
        Me.TextBox14.TabIndex = 6
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Min Number:"
        '
        'txtMin
        '
        Me.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMin.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(97, 21)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(59, 39)
        Me.txtMin.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.TextBox8)
        Me.GroupBox4.Controls.Add(Me.TextBox9)
        Me.GroupBox4.Controls.Add(Me.TextBox10)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(0, 92)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(333, 74)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Solve This:"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Enabled = False
        Me.TextBox9.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(14, 19)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(68, 39)
        Me.TextBox9.TabIndex = 2
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Enabled = False
        Me.TextBox10.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(128, 19)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(65, 39)
        Me.TextBox10.TabIndex = 3
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(95, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 25)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "+"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(206, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 25)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "="
        '
        'txtMax
        '
        Me.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMax.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax.Location = New System.Drawing.Point(268, 21)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(59, 39)
        Me.txtMax.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(57, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 48)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "&Next Problem"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(36, -55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(264, 36)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "CLICK Next Program TO RACK " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "YOUR BRAIN"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox7.Controls.Add(Me.rbDiv)
        Me.GroupBox7.Controls.Add(Me.rbMult)
        Me.GroupBox7.Controls.Add(Me.rbAdd)
        Me.GroupBox7.Controls.Add(Me.rbSub)
        Me.GroupBox7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(14, 111)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(333, 54)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Select:"
        '
        'grp2
        '
        Me.grp2.BackColor = System.Drawing.SystemColors.Control
        Me.grp2.Controls.Add(Me.txtAnswer)
        Me.grp2.Controls.Add(Me.txtNum1)
        Me.grp2.Controls.Add(Me.txtNum2)
        Me.grp2.Controls.Add(Me.lblSign)
        Me.grp2.Controls.Add(Me.Label3)
        Me.grp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp2.ForeColor = System.Drawing.Color.Black
        Me.grp2.Location = New System.Drawing.Point(14, 182)
        Me.grp2.Name = "grp2"
        Me.grp2.Size = New System.Drawing.Size(333, 74)
        Me.grp2.TabIndex = 2
        Me.grp2.TabStop = False
        Me.grp2.Text = "Solve This:"
        '
        'txtAnswer
        '
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(244, 21)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(70, 39)
        Me.txtAnswer.TabIndex = 4
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum1
        '
        Me.txtNum1.BackColor = System.Drawing.Color.White
        Me.txtNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNum1.Enabled = False
        Me.txtNum1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(19, 21)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(68, 39)
        Me.txtNum1.TabIndex = 2
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BrainBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 399)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.grp2)
        Me.MaximizeBox = False
        Me.Name = "BrainBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BrainBox"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.grp2.ResumeLayout(False)
        Me.grp2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents rbMult As System.Windows.Forms.RadioButton
    Friend WithEvents rbSub As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbAdd As System.Windows.Forms.RadioButton
    Friend WithEvents Score As System.Windows.Forms.TextBox
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents Message As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents lblSign As System.Windows.Forms.Label
    Friend WithEvents rbDiv As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents grp2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
End Class
