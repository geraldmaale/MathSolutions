<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Trigonometry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trigonometry))
        Me.lblTrigFunx = New System.Windows.Forms.Label
        Me.txtOpp = New System.Windows.Forms.TextBox
        Me.txtHyp = New System.Windows.Forms.TextBox
        Me.txtAngle = New System.Windows.Forms.TextBox
        Me.txtAdj = New System.Windows.Forms.TextBox
        Me.cboTrig = New System.Windows.Forms.ComboBox
        Me.btnSolve = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblOpp = New System.Windows.Forms.Label
        Me.lblHyp = New System.Windows.Forms.Label
        Me.lblAngle = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTrig = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.picTan = New System.Windows.Forms.PictureBox
        Me.picSin = New System.Windows.Forms.PictureBox
        Me.picCos = New System.Windows.Forms.PictureBox
        Me.picCosec = New System.Windows.Forms.PictureBox
        Me.picCot = New System.Windows.Forms.PictureBox
        Me.picSec = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.picTan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCosec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTrigFunx
        '
        Me.lblTrigFunx.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrigFunx.Location = New System.Drawing.Point(31, 8)
        Me.lblTrigFunx.Name = "lblTrigFunx"
        Me.lblTrigFunx.Size = New System.Drawing.Size(290, 26)
        Me.lblTrigFunx.TabIndex = 0
        Me.lblTrigFunx.Text = "Label1"
        Me.lblTrigFunx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOpp
        '
        Me.txtOpp.Location = New System.Drawing.Point(73, 2)
        Me.txtOpp.Name = "txtOpp"
        Me.txtOpp.Size = New System.Drawing.Size(59, 26)
        Me.txtOpp.TabIndex = 0
        Me.txtOpp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHyp
        '
        Me.txtHyp.BackColor = System.Drawing.Color.White
        Me.txtHyp.Location = New System.Drawing.Point(73, 34)
        Me.txtHyp.Name = "txtHyp"
        Me.txtHyp.Size = New System.Drawing.Size(59, 26)
        Me.txtHyp.TabIndex = 2
        Me.txtHyp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAngle
        '
        Me.txtAngle.BackColor = System.Drawing.Color.White
        Me.txtAngle.Location = New System.Drawing.Point(73, 98)
        Me.txtAngle.Name = "txtAngle"
        Me.txtAngle.Size = New System.Drawing.Size(59, 26)
        Me.txtAngle.TabIndex = 4
        Me.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAdj
        '
        Me.txtAdj.Location = New System.Drawing.Point(73, 2)
        Me.txtAdj.Name = "txtAdj"
        Me.txtAdj.Size = New System.Drawing.Size(59, 26)
        Me.txtAdj.TabIndex = 0
        Me.txtAdj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAdj.Visible = False
        '
        'cboTrig
        '
        Me.cboTrig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrig.FormattingEnabled = True
        Me.cboTrig.Location = New System.Drawing.Point(12, 59)
        Me.cboTrig.Name = "cboTrig"
        Me.cboTrig.Size = New System.Drawing.Size(100, 27)
        Me.cboTrig.TabIndex = 0
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(138, 7)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(65, 37)
        Me.btnSolve.TabIndex = 5
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblOpp
        '
        Me.lblOpp.AutoSize = True
        Me.lblOpp.Location = New System.Drawing.Point(9, 7)
        Me.lblOpp.Name = "lblOpp"
        Me.lblOpp.Size = New System.Drawing.Size(33, 19)
        Me.lblOpp.TabIndex = 7
        Me.lblOpp.Text = "opp"
        '
        'lblHyp
        '
        Me.lblHyp.AutoSize = True
        Me.lblHyp.Location = New System.Drawing.Point(9, 39)
        Me.lblHyp.Name = "lblHyp"
        Me.lblHyp.Size = New System.Drawing.Size(31, 19)
        Me.lblHyp.TabIndex = 8
        Me.lblHyp.Text = "hyp"
        '
        'lblAngle
        '
        Me.lblAngle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngle.Location = New System.Drawing.Point(9, 100)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(39, 23)
        Me.lblAngle.TabIndex = 9
        Me.lblAngle.Text = "θ"
        Me.lblAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTrig)
        Me.Panel1.Controls.Add(Me.lblAngle)
        Me.Panel1.Controls.Add(Me.lblHyp)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnSolve)
        Me.Panel1.Controls.Add(Me.txtHyp)
        Me.Panel1.Controls.Add(Me.txtOpp)
        Me.Panel1.Controls.Add(Me.txtAngle)
        Me.Panel1.Controls.Add(Me.txtAdj)
        Me.Panel1.Controls.Add(Me.lblOpp)
        Me.Panel1.Location = New System.Drawing.Point(118, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 127)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "sin"
        '
        'txtTrig
        '
        Me.txtTrig.Location = New System.Drawing.Point(73, 66)
        Me.txtTrig.Name = "txtTrig"
        Me.txtTrig.Size = New System.Drawing.Size(59, 26)
        Me.txtTrig.TabIndex = 3
        Me.txtTrig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Trig Functions"
        '
        'picTan
        '
        Me.picTan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picTan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picTan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picTan.Image = Global.MathSolutions.My.Resources.Resources.tan
        Me.picTan.Location = New System.Drawing.Point(12, 170)
        Me.picTan.Name = "picTan"
        Me.picTan.Size = New System.Drawing.Size(315, 160)
        Me.picTan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTan.TabIndex = 2
        Me.picTan.TabStop = False
        Me.picTan.Visible = False
        '
        'picSin
        '
        Me.picSin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picSin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSin.Image = Global.MathSolutions.My.Resources.Resources.sin
        Me.picSin.Location = New System.Drawing.Point(12, 170)
        Me.picSin.Name = "picSin"
        Me.picSin.Size = New System.Drawing.Size(315, 160)
        Me.picSin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSin.TabIndex = 3
        Me.picSin.TabStop = False
        Me.picSin.Visible = False
        '
        'picCos
        '
        Me.picCos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picCos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCos.Image = Global.MathSolutions.My.Resources.Resources.COS
        Me.picCos.Location = New System.Drawing.Point(12, 170)
        Me.picCos.Name = "picCos"
        Me.picCos.Size = New System.Drawing.Size(315, 160)
        Me.picCos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCos.TabIndex = 4
        Me.picCos.TabStop = False
        Me.picCos.Visible = False
        '
        'picCosec
        '
        Me.picCosec.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picCosec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picCosec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCosec.Image = CType(resources.GetObject("picCosec.Image"), System.Drawing.Image)
        Me.picCosec.Location = New System.Drawing.Point(12, 184)
        Me.picCosec.Name = "picCosec"
        Me.picCosec.Size = New System.Drawing.Size(315, 130)
        Me.picCosec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCosec.TabIndex = 5
        Me.picCosec.TabStop = False
        Me.picCosec.Visible = False
        '
        'picCot
        '
        Me.picCot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picCot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCot.Image = CType(resources.GetObject("picCot.Image"), System.Drawing.Image)
        Me.picCot.Location = New System.Drawing.Point(12, 184)
        Me.picCot.Name = "picCot"
        Me.picCot.Size = New System.Drawing.Size(313, 130)
        Me.picCot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCot.TabIndex = 6
        Me.picCot.TabStop = False
        Me.picCot.Visible = False
        '
        'picSec
        '
        Me.picSec.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picSec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSec.Image = Global.MathSolutions.My.Resources.Resources.sec
        Me.picSec.Location = New System.Drawing.Point(12, 184)
        Me.picSec.Name = "picSec"
        Me.picSec.Size = New System.Drawing.Size(315, 130)
        Me.picSec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSec.TabIndex = 7
        Me.picSec.TabStop = False
        Me.picSec.Visible = False
        '
        'Trigonometry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 341)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cboTrig)
        Me.Controls.Add(Me.lblTrigFunx)
        Me.Controls.Add(Me.picTan)
        Me.Controls.Add(Me.picCos)
        Me.Controls.Add(Me.picSin)
        Me.Controls.Add(Me.picSec)
        Me.Controls.Add(Me.picCot)
        Me.Controls.Add(Me.picCosec)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Trigonometry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trigonometry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picTan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCosec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTrigFunx As System.Windows.Forms.Label
    Friend WithEvents txtOpp As System.Windows.Forms.TextBox
    Friend WithEvents txtHyp As System.Windows.Forms.TextBox
    Friend WithEvents txtAngle As System.Windows.Forms.TextBox
    Friend WithEvents txtAdj As System.Windows.Forms.TextBox
    Friend WithEvents cboTrig As System.Windows.Forms.ComboBox
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblAngle As System.Windows.Forms.Label
    Friend WithEvents lblHyp As System.Windows.Forms.Label
    Friend WithEvents lblOpp As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picTan As System.Windows.Forms.PictureBox
    Friend WithEvents txtTrig As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picSin As System.Windows.Forms.PictureBox
    Friend WithEvents picCos As System.Windows.Forms.PictureBox
    Friend WithEvents picCosec As System.Windows.Forms.PictureBox
    Friend WithEvents picCot As System.Windows.Forms.PictureBox
    Friend WithEvents picSec As System.Windows.Forms.PictureBox
End Class
