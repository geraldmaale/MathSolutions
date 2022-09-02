Public Class AreasPerimeters
    Dim Length As Single
    Dim WidthObj As Single
    Dim HeightObj As Single
    Dim Base As Single
    Dim Diag1 As Single
    Dim Diag2 As Single
    Dim Para1 As Single
    Dim Para2 As Single
    Dim radius As Single
    Dim angle As Single
    Dim Area As Single
    Dim A As Single, B As Single, C As Single, D As Single
    Const pi = Math.PI

    Private Sub frmAreaSquare_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        cboAreaPerimeters.Items.Add("Areas")
        cboAreaPerimeters.Items.Add("Perimeters")

        cboAreas.Visible = False
        lblCalculation.Visible = False
        Panel2.Visible = False

        'Hiding the objects
        lblArea.Visible = False
        lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
        lblDiag1.Visible = False
        lblDiag2.Visible = False
        lblHeight.Visible = False
        lblLength.Visible = False
        lblWidth.Visible = False
        lblPara1.Visible = False
        lblPara2.Visible = False
        lblRadius.Visible = False : lblAngle.Visible = False
        lblAngle.Visible = False
        lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False

        txtArea.Visible = False
        txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
        txtDiag1.Visible = False
        txtDiag2.Visible = False
        txtHeight.Visible = False
        txtLength.Visible = False
        txtWidth.Visible = False
        txtPara1.Visible = False
        txtPara2.Visible = False
        txtRadius.Visible = False : txtAngle.Visible = False
        txtAngle.Visible = False
        txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
        txtProof.Visible = False

        btnReset.Visible = False
        btnSolve.Visible = False
        btnProof.Visible = False
        formula.Visible = False

    End Sub

    Private Sub cboAreas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAreas.SelectedIndexChanged
        'Selection for area calculations
        If cboAreas.Text = "Area of Rectangle" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblLength.Visible = True
            lblWidth.Visible = True
            lblArea.Visible = True
            txtArea.Visible = True
            txtLength.Visible = True
            txtWidth.Visible = True
            btnSolve.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnProof.Visible = True
            txtLength.Focus()

        ElseIf cboAreas.Text = "Area of Square" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblLength.Visible = True
            lblArea.Visible = True
            txtArea.Visible = True
            txtLength.Visible = True
            btnSolve.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            txtLength.Focus()

        ElseIf cboAreas.Text = "Area of Trapezium" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblPara1.Visible = True
            lblPara2.Visible = True
            lblHeight.Visible = True
            txtArea.Visible = True
            txtPara1.Visible = True
            txtPara2.Visible = True
            txtHeight.Visible = True
            btnSolve.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            txtPara1.Focus()
            lblHeight.Location = New Point(42, 161)
            txtHeight.Location = New Point(152, 161)


        ElseIf cboAreas.Text = "Area of Parallelogram" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblBase.Visible = True
            lblHeight.Visible = True
            txtArea.Visible = True
            txtBase.Visible = True
            txtHeight.Visible = True
            btnSolve.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            txtBase.Focus()
            lblHeight.Location = New Point(42, 131)
            txtHeight.Location = New Point(152, 131)


        ElseIf cboAreas.Text = "Area of Kite" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblDiag1.Visible = True
            lblDiag2.Visible = True
            txtArea.Visible = True
            txtDiag1.Visible = True
            txtDiag2.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtDiag1.Focus()

        ElseIf cboAreas.Text = "Area of Rhombus" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblDiag1.Visible = True
            lblDiag2.Visible = True
            txtArea.Visible = True
            txtDiag1.Visible = True
            txtDiag2.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtDiag1.Focus()

        ElseIf cboAreas.Text = "Area of Triangle" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblBase.Visible = True
            lblHeight.Visible = True
            txtArea.Visible = True
            txtBase.Visible = True
            txtHeight.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtBase.Focus()

        ElseIf cboAreas.Text = "Area of Circle" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblRadius.Visible = True
            txtArea.Visible = True
            txtRadius.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtRadius.Focus()

        ElseIf cboAreas.Text = "Area of Semi-Circle" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblRadius.Visible = True
            txtArea.Visible = True
            txtRadius.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtRadius.Focus()

        ElseIf cboAreas.Text = "Area of Sector" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblRadius.Visible = True
            lblAngle.Visible = True
            txtArea.Visible = True
            txtRadius.Visible = True
            txtAngle.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtRadius.Focus()

        ElseIf cboAreas.Text = "Circumference of Circle" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblRadius.Visible = True
            txtArea.Visible = True
            txtRadius.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtRadius.Focus()

        ElseIf cboAreas.Text = "Length of an Arc" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblRadius.Visible = True
            lblAngle.Visible = True
            txtArea.Visible = True
            txtRadius.Visible = True
            txtAngle.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtRadius.Focus()

        ElseIf cboAreas.Text = "Area of Circle" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblRadius.Visible = True
            txtArea.Visible = True
            txtRadius.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtRadius.Focus()

        ElseIf cboAreas.Text = "Area of Sector" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblRadius.Visible = True
            txtArea.Visible = True
            txtRadius.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtRadius.Focus()

        ElseIf cboAreas.Text = "Area of Quadrant" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblRadius.Visible = True
            txtArea.Visible = True
            txtRadius.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtRadius.Focus()

        ElseIf cboAreas.Text = "Semi-Circle" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblRadius.Visible = True
            txtArea.Visible = True
            txtRadius.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtRadius.Focus()

        End If

        'Selection for perimeter calculations
        If cboAreas.Text = "Perimeter of Rectangle" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblLength.Visible = True
            lblWidth.Visible = True
            lblArea.Visible = True
            txtArea.Visible = True
            txtLength.Visible = True
            txtWidth.Visible = True
            btnSolve.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            txtLength.Focus()

        ElseIf cboAreas.Text = "Perimeter of Square" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblLength.Visible = True
            lblArea.Visible = True
            txtArea.Visible = True
            txtLength.Visible = True
            btnSolve.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            txtLength.Focus()

        ElseIf cboAreas.Text = "Perimeter of Trapezium" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblA.Visible = True
            lblB.Visible = True
            lblC.Visible = True
            lblD.Visible = True
            txtA.Visible = True
            txtB.Visible = True
            txtC.Visible = True
            txtD.Visible = True
            txtArea.Visible = True
            btnSolve.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            txtA.Focus()


        ElseIf cboAreas.Text = "Perimeter of Parallelogram" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblBase.Visible = True
            lblHeight.Text = "Side:"
            lblHeight.Visible = True
            txtArea.Visible = True
            txtBase.Visible = True
            txtHeight.Visible = True
            btnSolve.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            txtBase.Focus()


        ElseIf cboAreas.Text = "Perimeter of Kite" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblA.Visible = True
            lblB.Visible = True
            lblC.Visible = True
            lblD.Visible = True
            txtA.Visible = True
            txtB.Visible = True
            txtC.Visible = True
            txtD.Visible = True
            txtArea.Visible = True
            btnSolve.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            txtA.Focus()

        ElseIf cboAreas.Text = "Perimeter of Rhombus" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblLength.Visible = True
            txtArea.Visible = True
            txtLength.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            btnSolve.Visible = True
            txtLength.Focus()

        ElseIf cboAreas.Text = "Perimeter of Triangle" Then

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            formula.Visible = False

            lblArea.ForeColor = Color.Black
            lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
            lblDiag1.ForeColor = Color.Black
            lblDiag2.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblLength.ForeColor = Color.Black
            lblWidth.ForeColor = Color.Black
            lblPara1.ForeColor = Color.Black
            lblPara2.ForeColor = Color.Black
            lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

            txtArea.ForeColor = Color.Black
            txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
            txtDiag1.ForeColor = Color.Black
            txtDiag2.ForeColor = Color.Black
            txtHeight.ForeColor = Color.Black
            txtLength.ForeColor = Color.Black
            txtWidth.ForeColor = Color.Black
            txtPara1.ForeColor = Color.Black
            txtPara2.ForeColor = Color.Black
            txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

            txtArea.Clear()
            txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
            txtDiag1.Clear()
            txtDiag2.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtWidth.Clear()
            txtPara1.Clear()
            txtPara2.Clear()
            txtRadius.Clear() : txtAngle.Clear()

            formula.Clear()

            'setting
            lblArea.Visible = True
            lblA.Visible = True
            lblB.Visible = True
            lblC.Visible = True
            txtA.Visible = True
            txtB.Visible = True
            txtC.Visible = True
            txtArea.Visible = True
            btnSolve.Visible = True
            btnReset.Visible = True : btnProof.Visible = True
            txtA.Focus()
        End If

    End Sub

    Private Sub btnSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolve.Click

        If cboAreas.Text = "Area of Rectangle" Then

            'Solving for Rectangle
            If txtLength.Text = "" Then
                'Length is empty
                WidthObj = Val(txtWidth.Text)
                Area = Val(txtArea.Text)
                Length = Area / WidthObj
                txtLength.Text = CSng(Length)
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Length = Area ÷ Width")
            ElseIf txtWidth.Text = "" Then
                'Width is empty
                Length = Val(txtLength.Text)
                Area = Val(txtArea.Text)
                WidthObj = Area / Length
                txtWidth.Text = CSng(WidthObj)
                txtWidth.ForeColor = Color.Blue : lblWidth.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Width = Area ÷ Length")

            ElseIf txtArea.Text = "" Then
                'Area is empty
                Length = Val(txtLength.Text)
                WidthObj = Val(txtWidth.Text)
                Area = Length * WidthObj
                txtArea.Text = CSng(Area)
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Area = Length × Width ")

            End If


        ElseIf cboAreas.Text = "Area of Square" Then

            'Solving for Square
            If txtLength.Text = "" Then
                'Length is empty
                Area = Val(txtArea.Text)
                Length = (Area) ^ (1 / 2)
                txtLength.Text = CSng(Length)
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Length = √(A), where A is area.")

            ElseIf txtArea.Text = "" Then
                'Area is empty
                Length = Val(txtLength.Text)
                Area = Length * Length
                txtArea.Text = CSng(Area)
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Area = (L)², where L is length.")
            End If


        ElseIf cboAreas.Text = "Area of Trapezium" Then

            'Solving for Trapezium
            If txtPara1.Text = "" Then
                'Parallel Side 1 empty
                Para2 = Val(txtPara2.Text)
                Area = Val(txtArea.Text)
                HeightObj = Val(txtHeight.Text)
                Para1 = ((2 * Area) - (Para2 * HeightObj)) / HeightObj
                txtPara1.Text = CSng(Para1)
                txtPara1.ForeColor = Color.Blue : lblPara1.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Parallel side1= (2 × Area - parallel side2 × height) ÷ height")

            ElseIf txtPara2.Text = "" Then
                'Parallel side 2 empty
                Para1 = Val(txtPara1.Text)
                Area = Val(txtArea.Text)
                HeightObj = Val(txtHeight.Text)
                Para2 = ((2 * Area) - (Para1 * HeightObj)) / HeightObj
                txtPara2.Text = CSng(Para2)
                txtPara2.ForeColor = Color.Blue : lblPara2.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Parallel side2= (2 × Area - parallel side1 × height) ÷ height")

            ElseIf txtHeight.Text = "" Then
                'Height empty
                Para1 = Val(txtPara1.Text)
                Para2 = Val(txtPara2.Text)
                Area = Val(txtArea.Text)
                HeightObj = ((2 * Area) / (Para1 + Para2))
                txtHeight.Text = CSng(HeightObj)
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Height = (2 × Area ÷ (parallel side1 + parallel side2))")

            ElseIf txtArea.Text = "" Then
                'Area empty
                Para1 = Val(txtPara1.Text)
                Para2 = Val(txtPara2.Text)
                HeightObj = Val(txtHeight.Text)
                Area = (Para1 * HeightObj + Para2 * HeightObj) / 2
                txtArea.Text = CSng(Area)
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Area = 1/2 × (sum of parallel sides) × height")
            End If


        ElseIf cboAreas.Text = "Area of Parallelogram" Then

            'Solving for parallelogram
            If txtBase.Text = "" Then
                'Length of base empty
                HeightObj = Val(txtHeight.Text)
                Area = Val(txtArea.Text)
                Base = Area / HeightObj
                txtBase.Text = CSng(Base)
                txtBase.ForeColor = Color.Blue : lblBase.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Length of Base = Area ÷ Perpendicular height")

            ElseIf txtHeight.Text = "" Then
                'Height empty
                Base = Val(txtBase.Text)
                Area = Val(txtArea.Text)
                HeightObj = Area / Base
                txtHeight.Text = CSng(HeightObj)
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Perpendicular height = Area ÷ Length of base")

            ElseIf txtArea.Text = "" Then
                'Area empty
                Base = Val(txtBase.Text)
                HeightObj = Val(txtHeight.Text)
                Area = Base * HeightObj
                txtArea.Text = CSng(Area)
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Area = Length of base × Perpendicular height")

            End If

        ElseIf cboAreas.Text = "Area of Rhombus" Then
            'Solving for Rhombus

            If txtDiag1.Text = "" Then
                'Diagonal Side 1 empty
                Diag2 = Val(txtDiag2.Text)
                Area = Val(txtArea.Text)
                Diag1 = (2 * Area) / (Diag2)
                txtDiag1.Text = CSng(Diag1)
                txtDiag1.ForeColor = Color.Blue : lblDiag1.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Diagonal side1= (2 × Area ÷ diagllel side2")

            ElseIf txtDiag2.Text = "" Then
                'Diagonal side 2 empty
                Diag1 = Val(txtDiag1.Text)
                Area = Val(txtArea.Text)
                Diag2 = ((2 * Area) / (Diag1))
                txtDiag2.Text = CSng(Diag2)
                txtDiag2.ForeColor = Color.Blue : lblDiag2.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Diagonal side2= (2 × Area ÷ Diagonal side1")

            ElseIf txtArea.Text = "" Then
                'Area empty
                Diag1 = Val(txtDiag1.Text)
                Diag2 = Val(txtDiag2.Text)
                Area = (1 / 2) * (Diag1 * Diag2)
                txtArea.Text = CSng(Area)
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Area = 1/2 × (Product of Diagonals)")
            End If


        ElseIf cboAreas.Text = "Area of Kite" Then
            'Solving for Kite

            If txtDiag1.Text = "" Then
                'Diagonal Side 1 empty
                Diag2 = Val(txtDiag2.Text)
                Area = Val(txtArea.Text)
                Diag1 = (2 * Area) / (Diag2)
                txtDiag1.Text = CSng(Diag1)
                txtDiag1.ForeColor = Color.Blue : lblDiag1.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Diagonal side1= (2 × Area ÷ diagllel side2")

            ElseIf txtDiag2.Text = "" Then
                'Diagonal side 2 empty
                Diag1 = Val(txtDiag1.Text)
                Area = Val(txtArea.Text)
                Diag2 = ((2 * Area) / (Diag1))
                txtDiag2.Text = CSng(Diag2)
                txtDiag2.ForeColor = Color.Blue : lblDiag2.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Diagonal side2= (2 × Area ÷ Diagonal side1")

            ElseIf txtArea.Text = "" Then
                'Area empty
                Diag1 = Val(txtDiag1.Text)
                Diag2 = Val(txtDiag2.Text)
                Area = (1 / 2) * (Diag1 * Diag2)
                txtArea.Text = CSng(Area)
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:   Area = 1/2 × (Product of Diagonals)")
            End If

        ElseIf cboAreas.Text = "Area of Triangle" Then

            'Solving for Triangle
            If txtBase.Text = "" Then
                'base empty
                HeightObj = Val(txtHeight.Text)
                Area = Val(txtArea.Text)
                Base = 2 * Area / HeightObj
                txtBase.Text = CSng(Base)
                txtBase.ForeColor = Color.Blue : lblBase.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Base = 2 × Area ÷ Height")

            ElseIf txtHeight.Text = "" Then
                'Height empty
                Base = Val(txtBase.Text)
                Area = Val(txtArea.Text)
                HeightObj = 2 * Area / Base
                txtHeight.Text = CSng(HeightObj)
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Height = 2 × Area ÷ Base")

            ElseIf txtArea.Text = "" Then
                'Area empty
                Base = Val(txtBase.Text)
                HeightObj = Val(txtHeight.Text)
                Area = 1 / 2 * (Base * HeightObj)
                txtArea.Text = CSng(Area)
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Area = 1 / 2 × (Base × Height)")

            End If

        ElseIf cboAreas.Text = "Circumference of Circle" Then

            'Solving Circumference of circle
            If txtRadius.Text = "" Then
                'Radius empty
                Area = Val(txtArea.Text)
                radius = Area / 2 * pi
                txtRadius.Text = CSng(radius)
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Radius = Area ÷ 2 π")

            ElseIf txtArea.Text = "" Then
                'Area empty
                radius = Val(txtRadius.Text)
                Area = 2 * pi * radius
                txtArea.Text = System.Math.Round(Area, 4) & "   to 4 d.p."
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Area = 2 π r, where r is radius")

            End If


        ElseIf cboAreas.Text = "Length of an Arc" Then

            'Solving Length of an Arc
            If txtRadius.Text = "" Then
                'Radius empty
                angle = Val(txtAngle.Text)
                Area = Val(txtArea.Text)
                radius = (360 * Area) / (2 * pi * angle)
                txtRadius.Text = CSng(radius)
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Radius = (360 × Area) ÷ (2 π θ), where θ is angle.")

            ElseIf txtAngle.Text = "" Then
                'Angle empty
                radius = Val(txtRadius.Text)
                Area = Val(txtArea.Text)
                angle = (360 * Area) / (2 * pi * radius)
                txtAngle.Text = angle
                txtAngle.ForeColor = Color.Blue : lblAngle.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      θ = (360 × Area) ÷ (2 π r), where θ is angle & r is radius.")

            ElseIf txtArea.Text = "" Then
                'Area empty
                angle = Val(txtAngle.Text)
                radius = Val(txtRadius.Text)
                Area = 2 * pi * radius
                txtArea.Text = System.Math.Round(Area, 4) & "   to 4 d.p."
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Area = θ/360 × 2 π r, where θ is angle & r is radius.")

            End If

        ElseIf cboAreas.Text = "Area of Circle" Then

            'Solving Area of circle
            If txtRadius.Text = "" Then
                'Radius empty
                Area = Val(txtArea.Text)
                radius = Math.Sqrt(Area / pi)
                txtRadius.Text = CSng(radius)
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Radius = √(Area / π)")

            ElseIf txtArea.Text = "" Then
                'Area empty
                radius = Val(txtRadius.Text)
                Area = 2 * pi * radius
                txtArea.Text = System.Math.Round(Area, 4) & "   to 4 d.p."
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Area = π r ², where r is radius.")

            End If

        ElseIf cboAreas.Text = "Area of Sector" Then

            'Solving for Area of sector
            If txtRadius.Text = "" Then
                'Radius empty
                angle = Val(txtAngle.Text)
                Area = Val(txtArea.Text)
                radius = Math.Sqrt((360 * Area) / (pi * angle))
                txtRadius.Text = CSng(radius)
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Radius = √(360 × Area ÷ π θ), where θ is angle.")

            ElseIf txtAngle.Text = "" Then
                'Angle empty
                radius = Val(txtRadius.Text)
                Area = Val(txtArea.Text)
                angle = Math.Sqrt((360 * Area) / (pi * radius))
                txtAngle.Text = angle
                txtAngle.ForeColor = Color.Blue : lblAngle.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      θ = √(360 × Area ÷ π r), where θ is angle & r is radius.")

            ElseIf txtArea.Text = "" Then
                'Area empty
                angle = Val(txtAngle.Text)
                radius = Val(txtRadius.Text)
                Area = (angle / 360) * pi * radius * radius
                txtArea.Text = System.Math.Round(Area, 4) & "   to 4 d.p."
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Area = θ/360 × π r ², where θ is angle & r is radius.")

            End If


        ElseIf cboAreas.Text = "Area of Quadrant" Then

            'Solving Area of Quadrant
            If txtRadius.Text = "" Then
                'Radius empty
                Area = Val(txtArea.Text)
                radius = Math.Sqrt(4 * Area / pi)
                txtRadius.Text = CSng(radius)
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Radius = √(4 × Area / π)")

            ElseIf txtArea.Text = "" Then
                'Area empty
                radius = Val(txtRadius.Text)
                Area = 2 * pi * radius
                txtArea.Text = System.Math.Round(Area, 4) & "   to 4 d.p."
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Area = 1/4 π r ², where r is radius.")

            End If


        ElseIf cboAreas.Text = "Area of Semi-Circle" Then

            'Solving Area of Semi-Circle
            If txtRadius.Text = "" Then
                'Radius empty
                Area = Val(txtArea.Text)
                radius = Math.Sqrt(2 * Area / pi)
                txtRadius.Text = CSng(radius)
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Radius = √(2 × Area / π)")

            ElseIf txtArea.Text = "" Then
                'Area empty
                radius = Val(txtRadius.Text)
                Area = 2 * pi * radius
                txtArea.Text = System.Math.Round(Area, 4) & "   to 4 d.p."
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Area = 1/2 π r ², where r is radius.")

            End If

        ElseIf cboAreas.Text = "Perimeter of Trapezium" Then

            'Solving Perimeter of Trapezium
            If txtA.Text = "" Then
                'Side A empty
                B = Val(txtB.Text)
                C = Val(txtC.Text)
                D = Val(txtD.Text)
                Area = Val(txtArea.Text)
                A = Area - B - C - D
                txtA.Text = (A)
                txtA.ForeColor = Color.Blue : lblA.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      A = Area - B - C - D")

            ElseIf txtB.Text = "" Then
                'Side B empty
                A = Val(txtA.Text)
                C = Val(txtC.Text)
                D = Val(txtD.Text)
                Area = Val(txtArea.Text)
                B = Area - A - C - D
                txtB.Text = (B)
                txtB.ForeColor = Color.Blue : lblB.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     B = Area - A - C - D ")

            ElseIf txtC.Text = "" Then
                'Side C empty
                B = Val(txtB.Text)
                A = Val(txtA.Text)
                D = Val(txtD.Text)
                Area = Val(txtArea.Text)
                C = Area - B - A - D
                txtC.Text = (C)
                txtC.ForeColor = Color.Blue : lblC.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      C = Area - A - B - D")

            ElseIf txtD.Text = "" Then
                'Side D empty
                A = Val(txtA.Text)
                C = Val(txtC.Text)
                B = Val(txtB.Text)
                Area = Val(txtArea.Text)
                D = Area - A - C - B
                txtD.Text = (D)
                txtD.ForeColor = Color.Blue : lblD.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     D = Area - A - B - C ")

            ElseIf txtArea.Text = "" Then
                'Side Area empty
                A = Val(txtA.Text)
                C = Val(txtC.Text)
                D = Val(txtD.Text)
                B = Val(txtB.Text)
                Area = A + B + C + D
                txtArea.Text = (Area)
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Area = A + B + C + D")

            End If

        ElseIf cboAreas.Text = "Perimeter of Kite" Then

            'Solving Perimeter of Kite
            If txtA.Text = "" Then
                'Side A empty
                B = Val(txtB.Text)
                C = Val(txtC.Text)
                D = Val(txtD.Text)
                Area = Val(txtArea.Text)
                A = Area - B - C - D
                txtA.Text = (A)
                txtA.ForeColor = Color.Blue : lblA.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      A = Area - B - C - D")

            ElseIf txtB.Text = "" Then
                'Side B empty
                A = Val(txtA.Text)
                C = Val(txtC.Text)
                D = Val(txtD.Text)
                Area = Val(txtArea.Text)
                B = Area - A - C - D
                txtB.Text = (B)
                txtB.ForeColor = Color.Blue : lblB.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     B = Area - A - C - D ")

            ElseIf txtC.Text = "" Then
                'Side C empty
                B = Val(txtB.Text)
                A = Val(txtA.Text)
                D = Val(txtD.Text)
                Area = Val(txtArea.Text)
                C = Area - B - A - D
                txtC.Text = (C)
                txtC.ForeColor = Color.Blue : lblC.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      C = Area - A - B - D")

            ElseIf txtD.Text = "" Then
                'Side D empty
                A = Val(txtA.Text)
                C = Val(txtC.Text)
                B = Val(txtB.Text)
                Area = Val(txtArea.Text)
                D = Area - A - C - B
                txtD.Text = (D)
                txtD.ForeColor = Color.Blue : lblD.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     D = Area - A - B - C ")

            ElseIf txtArea.Text = "" Then
                'Side Area empty
                A = Val(txtA.Text)
                C = Val(txtC.Text)
                D = Val(txtD.Text)
                B = Val(txtB.Text)
                Area = A + B + C + D
                txtArea.Text = (Area)
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Area = A + B + C + D")

            End If

        ElseIf cboAreas.Text = "Perimeter of Triangle" Then

            'Solving Perimeter of Triangle
            If txtA.Text = "" Then
                'Side A empty
                B = Val(txtB.Text)
                C = Val(txtC.Text)
                Area = Val(txtArea.Text)
                A = Area - B - C
                txtA.Text = (A)
                txtA.ForeColor = Color.Blue : lblA.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      A = Area - B - C ")

            ElseIf txtB.Text = "" Then
                'Side B empty
                A = Val(txtA.Text)
                C = Val(txtC.Text)
                Area = Val(txtArea.Text)
                B = Area - A - C
                txtB.Text = (B)
                txtB.ForeColor = Color.Blue : lblB.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     B = Area - A - C ")

            ElseIf txtC.Text = "" Then
                'Side C empty
                B = Val(txtB.Text)
                A = Val(txtA.Text)
                Area = Val(txtArea.Text)
                C = Area - B - A - D
                txtC.Text = (C)
                txtC.ForeColor = Color.Blue : lblC.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      C = Area - A - B ")

            ElseIf txtArea.Text = "" Then
                'Side Area empty
                A = Val(txtA.Text)
                C = Val(txtC.Text)
                B = Val(txtB.Text)
                Area = A + B + C
                txtArea.Text = (Area)
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Area = A + B + C")

            End If


        ElseIf cboAreas.Text = "Perimeter of Rectangle" Then

            'Solving Perimeter of Rectangle
            If txtLength.Text = "" Then
                'Length empty
                WidthObj = Val(txtWidth.Text)
                Area = Val(txtArea.Text)
                Length = (Area - 2 * WidthObj) / 2
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Length = (Area - 2 × Width)/2")

            ElseIf txtWidth.Text = "" Then
                'Width empty
                Length = Val(txtLength.Text)
                Area = Val(txtArea.Text)
                WidthObj = (Area - 2 * Length) / 2
                txtWidth.Text = WidthObj
                txtWidth.ForeColor = Color.Blue : lblWidth.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Width = (Area - 2 × Length)/2")

            ElseIf txtArea.Text = "" Then
                'Area empty
                WidthObj = Val(txtWidth.Text)
                Length = Val(txtLength.Text)
                Area = (2 * Length) + (2 * WidthObj)
                txtArea.Text = Area
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Area = 2(Length + Width)")

            End If


        ElseIf cboAreas.Text = "Perimeter of Square" Then

            'Solving Perimeter of Square
            If txtLength.Text = "" Then
                'Length empty
                Area = Val(txtArea.Text)
                Length = Area / 4
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Length = (Area)/4")

            ElseIf txtArea.Text = "" Then
                'Area empty
                Length = Val(txtLength.Text)
                Area = (4 * Length)
                txtArea.Text = Area
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Area = 4(Length)")

            End If


        ElseIf cboAreas.Text = "Perimeter of Rhombus" Then

            'Solving Perimeter of Rhombus
            If txtLength.Text = "" Then
                'Length empty
                Area = Val(txtArea.Text)
                Length = Area / 4
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Length = (Area)/4")

            ElseIf txtArea.Text = "" Then
                'Area empty
                Length = Val(txtLength.Text)
                Area = (4 * Length)
                txtArea.Text = Area
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Area = 4(Length)")
            End If


        ElseIf cboAreas.Text = "Perimeter of Parallelogram" Then

            'Solving Perimeter of Parallelogram
            If txtBase.Text = "" Then
                'base empty
                HeightObj = Val(txtHeight.Text)
                Area = Val(txtArea.Text)
                Base = (Area - 2 * HeightObj) / 2
                txtBase.Text = Base
                txtBase.ForeColor = Color.Blue : lblBase.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Base = (Area - 2 × Side)/2")

            ElseIf txtHeight.Text = "" Then
                'height empty
                Base = Val(txtBase.Text)
                Area = Val(txtArea.Text)
                HeightObj = (Area - 2 * Base) / 2
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:      Side = (Area - 2 × Base)/2")

            ElseIf txtArea.Text = "" Then
                'Area empty
                HeightObj = Val(txtHeight.Text)
                Base = Val(txtBase.Text)
                Area = (2 * Base) + (2 * HeightObj)
                txtArea.Text = Area
                txtArea.ForeColor = Color.Blue : lblArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = CStr("Formula:     Area = 2(Base + Side)")

            End If
        End If

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        lblArea.ForeColor = Color.Black
        lblBase.ForeColor = Color.Black : lblA.ForeColor = Color.Black : lblB.ForeColor = Color.Black : lblC.ForeColor = Color.Black : lblD.ForeColor = Color.Black
        lblDiag1.ForeColor = Color.Black
        lblDiag2.ForeColor = Color.Black
        lblHeight.ForeColor = Color.Black
        lblLength.ForeColor = Color.Black
        lblWidth.ForeColor = Color.Black
        lblPara1.ForeColor = Color.Black
        lblPara2.ForeColor = Color.Black
        lblRadius.ForeColor = Color.Black : lblAngle.ForeColor = Color.Black

        txtArea.ForeColor = Color.Black
        txtBase.ForeColor = Color.Black : txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black : txtC.ForeColor = Color.Black : txtD.ForeColor = Color.Black
        txtDiag1.ForeColor = Color.Black
        txtDiag2.ForeColor = Color.Black
        txtHeight.ForeColor = Color.Black
        txtLength.ForeColor = Color.Black
        txtWidth.ForeColor = Color.Black
        txtPara1.ForeColor = Color.Black
        txtPara2.ForeColor = Color.Black
        txtRadius.ForeColor = Color.Black : txtAngle.ForeColor = Color.Black

        txtArea.Clear()
        txtBase.Clear() : txtA.Clear() : txtB.Clear() : txtC.Clear() : txtD.Clear()
        txtDiag1.Clear()
        txtDiag2.Clear()
        txtHeight.Clear()
        txtLength.Clear()
        txtWidth.Clear()
        txtPara1.Clear()
        txtPara2.Clear()
        txtProof.Text = ""
        txtRadius.Clear() : txtAngle.Clear()

        formula.Clear()
        formula.Visible = False
        txtProof.Visible = False
        Me.Size = New Size(336, 383)


    End Sub


    Private Sub txtRadius_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWidth.KeyPress, txtRadius.KeyPress, txtPara2.KeyPress, txtPara1.KeyPress, txtLength.KeyPress, txtHeight.KeyPress, txtDiag2.KeyPress, txtDiag1.KeyPress, txtBase.KeyPress, txtArea.KeyPress, MyBase.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then
            btnSolve.Focus()
        Else
            e.KeyChar = ChrW(0)
            Beep()
        End If
    End Sub

    Private Sub cboAreaPerimeters_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAreaPerimeters.SelectedIndexChanged
        Me.Size = New Point(344, 415)

        If cboAreaPerimeters.Text = "Areas" Then
            cboAreas.Focus()

            lblCalculation.Visible = True
            cboAreas.Visible = True
            Panel2.Visible = True
            cboAreas.Items.Clear()
            cboAreas.Items.Add("Area of Rectangle")
            cboAreas.Items.Add("Area of Square")
            cboAreas.Items.Add("Area of Trapezium")
            cboAreas.Items.Add("Area of Parallelogram")
            cboAreas.Items.Add("Area of Rhombus")
            cboAreas.Items.Add("Area of Kite")
            cboAreas.Items.Add("Area of Triangle")
            cboAreas.Items.Add("Circumference of Circle")
            cboAreas.Items.Add("Length of an Arc")
            cboAreas.Items.Add("Area of Circle")
            cboAreas.Items.Add("Area of Sector")
            cboAreas.Items.Add("Area of Quadrant")
            cboAreas.Items.Add("Area of Semi-Circle")


            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            btnProof.Visible = False
            formula.Visible = False

        ElseIf cboAreaPerimeters.Text = "Perimeters" Then
            cboAreas.Focus()

            lblCalculation.Visible = True
            cboAreas.Visible = True
            Panel2.Visible = True
            cboAreas.Items.Clear()
            cboAreas.Items.Add("Perimeter of Rectangle")
            cboAreas.Items.Add("Perimeter of Square")
            cboAreas.Items.Add("Perimeter of Trapezium")
            cboAreas.Items.Add("Perimeter of Parallelogram")
            cboAreas.Items.Add("Perimeter of Rhombus")
            cboAreas.Items.Add("Perimeter of Kite")
            cboAreas.Items.Add("Perimeter of Triangle")

            'clearing
            lblArea.Visible = False
            lblBase.Visible = False : lblA.Visible = False : lblB.Visible = False : lblC.Visible = False : lblD.Visible = False
            lblDiag1.Visible = False
            lblDiag2.Visible = False
            lblHeight.Visible = False
            lblLength.Visible = False
            lblWidth.Visible = False
            lblPara1.Visible = False
            lblPara2.Visible = False
            lblRadius.Visible = False : lblAngle.Visible = False

            txtArea.Visible = False
            txtBase.Visible = False : txtA.Visible = False : txtB.Visible = False : txtC.Visible = False : txtD.Visible = False
            txtDiag1.Visible = False
            txtDiag2.Visible = False
            txtHeight.Visible = False
            txtLength.Visible = False
            txtWidth.Visible = False
            txtPara1.Visible = False
            txtPara2.Visible = False
            txtRadius.Visible = False : txtAngle.Visible = False

            btnReset.Visible = False
            btnSolve.Visible = False
            btnProof.Visible = False
            formula.Visible = False

        End If
    End Sub

    Private Sub btnProof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProof.Click
        Me.Size = New Size(567, 415)
        txtProof.Visible = True

        'showing working 
        If cboAreas.Text = "Area of Rectangle" Then
            txtProof.Text = CStr("Formula:   Area = Length × Width ")
            txtProof.Text = txtProof.Text & "Length = " & Length & " , Width = " & WidthObj & "                   "
            txtProof.Text = txtProof.Text & "Area = " & Length & " × " & WidthObj & "                                   "
            txtProof.Text = txtProof.Text & "Area = " & Area & " Units Sq."
        End If

        'PictureBox1.Image = Image.FromFile _
        '(System.Environment.GetFolderPath _
        '(System.Environment.SpecialFolder.Desktop) _
        '& "\rectangle.png")


    End Sub



End Class
