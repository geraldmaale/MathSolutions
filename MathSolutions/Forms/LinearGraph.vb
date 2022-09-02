Public Class LinearGraph
    Dim eqnShow As String
    Dim interval As String
    Dim gradientEqn As Single
    Dim constantEqn As Single
    Dim firstEqn As Single
    Dim lastEqn As Single
    Dim num1 As Single
    Dim num2 As Single
    Dim y As Single : Dim a As Single : Dim b As Single : Dim c As Single : Dim d As Single
    Dim x As Single

    'Private Sub Equation()
    '    'Variables for equation
    '    Dim x As Single
    '    Dim y As Single

    '    'temperal variable for swapping
    '    Dim temp As Single

    '    'num2 must be greater than num1 for interval
    '    If num1 > num2 Then
    '        temp = num1
    '        num1 = num2
    '        num2 = temp
    '    End If

    '    'looping interval for equation

    '    Dim init As Single
    '    Dim stepNum As Single

    '    If opt1.Checked = True Then
    '        stepNum = 1
    '    ElseIf opt2.Checked = True Then
    '        stepNum = 2
    '    ElseIf opt3.Checked = True Then
    '        stepNum = 3

    '    End If

    '    'If txtInterval.Text = "" Then
    '    '    stepNum = 1
    '    'Else
    '    '    stepNum = Val(txtInterval.Text)
    '    'End If

    '    For init = num1 To num2 Step stepNum
    '        If chkY.Checked Then
    '            y = gradientEqn * init + constantEqn
    '            Dim eqnY As Single

    '            eqnY = y
    '            'listing coordinates
    '            lstCoordinates.Visible = True
    '            lstCoordinates.Items.Add(CStr("(" & init & " , " & eqnY & ")"))
    '            'cmdReset.Visible = True
    '            lblEquation.Visible = True
    '            Label2.Visible = True
    '            Label3.Visible = True
    '            Label4.Visible = True
    '            lblInterval.Visible = True

    '            eqnShow = ("y = " & gradientEqn & "x + " & "(" & constantEqn & ")")
    '            interval = (CStr(num1) & " ≤ X ≤ " & CStr(num2))

    '        ElseIf chkX.Checked Then
    '            x = (init - constantEqn) / gradientEqn
    '            Dim eqnX As Single
    '            eqnX = x
    '            'listing coordinates
    '            lstCoordinates.Visible = True
    '            lstCoordinates.Items.Add(CStr("(" & eqnX & " , " & init & ")"))
    '            'cmdReset.Visible = True
    '            lblEquation.Visible = True
    '            Label2.Visible = True
    '            Label3.Visible = True
    '            Label4.Visible = True
    '            lblInterval.Visible = True

    '            eqnShow = ("y = " & gradientEqn & "x + " & "(" & constantEqn & ")")
    '            interval = (CStr(num1) & " ≤ Y ≤ " & CStr(num2))

    '        End If
    '    Next
    'End Sub

    Private Sub chkX_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkX.CheckedChanged
        txtConstant.Text = ""
        txtFirst.Text = ""
        txtLast.Text = ""
        txtGrad.Text = ""

        'Equation(InputBox("grad", "Gradient, m"), InputBox("constant", "Constant, c"), InputBox("num1", "First Range"), InputBox("num2", "Last Range"))
        grpGradient.Visible = True : txtGrad.Visible = True
        grpConstant.Visible = True : txtConstant.Visible = True
        IntervalPoints.Visible = True
        txtGrad.Focus()
    End Sub

    Private Sub chkY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkY.CheckedChanged
        txtConstant.Text = ""
        txtFirst.Text = ""
        txtLast.Text = ""
        txtGrad.Text = ""

        'Equation(InputBox("grad", "Gradient, m"), InputBox("constant", "Constant, c"), InputBox("num1", "Interval - X1"), InputBox("num2", "Interval - X2"))
        grpGradient.Visible = True : txtGrad.Visible = True
        grpConstant.Visible = True : txtConstant.Visible = True
        IntervalPoints.Visible = True
        txtGrad.Focus()
    End Sub

    Private Sub txtInterval_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then
            GroupBox2.Focus()
        Else
            e.KeyChar = ChrW(0)
            Beep()
        End If
    End Sub

    Private Sub LinearEquation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        cboSelect.Items.Add("Equation of a Line")
        cboSelect.Items.Add("Linear Functions")
    End Sub

    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        'Selecting linear functions
        If cboSelect.Text = "Linear Functions" Then

            lstCoordinates.Items.Clear()
            lstCoordinates.Visible = False
            lblCoordinates.Visible = False
            lblInterval.Visible = False
            lblEquation.Visible = False
            grpLine.Visible = False
            grpInterval.Visible = False
            GroupBox2.Visible = False
            grpInterval.Visible = False
            grpGradient.Visible = False
            lblInterval.Visible = False
            txtConstant.Visible = False
            txtGrad.Visible = False
            IntervalPoints.Visible = False
            grpFormat.Visible = False
            txtConstant.Text = ""
            txtFirst.Text = ""
            txtLast.Text = ""
            txtGrad.Text = ""
            cmdReset.Visible = False
            GroupBox1.Visible = True

            'Selecting equation of a line
        ElseIf cboSelect.Text = "Equation of a Line" Then

            lstCoordinates.Items.Clear()
            lstCoordinates.Visible = False
            lblCoordinates.Visible = False
            lblInterval.Visible = False
            lblEquation.Visible = False
            grpLine.Visible = False
            grpInterval.Visible = False
            GroupBox2.Visible = False
            grpConstant.Visible = False
            grpGradient.Visible = False
            lblInterval.Visible = False
            txtConstant.Visible = False
            txtGrad.Visible = False
            IntervalPoints.Visible = False
            GroupBox1.Visible = False
            txtConstant.Text = ""
            txtFirst.Text = ""
            txtLast.Text = ""
            txtGrad.Text = ""
            cmdReset.Visible = False
            grpFormat.Visible = True
            txtA.Focus()

        End If

    End Sub

    Private Sub opt5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt5.CheckedChanged
        GroupBox2.Visible = True
    End Sub

    Private Sub opt4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt4.CheckedChanged
        GroupBox2.Visible = True
    End Sub

    Private Sub opt3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt3.CheckedChanged
        GroupBox2.Visible = True
    End Sub

    Private Sub opt2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt2.CheckedChanged
        GroupBox2.Visible = True
    End Sub

    Private Sub opt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt1.CheckedChanged
        GroupBox2.Visible = True
    End Sub


    Private Sub txtGrad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrad.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Or e.KeyChar = ChrW(47) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then

            'Check answer
            gradientEqn = Val(txtGrad.Text)

            ' grpGradient.Visible = False
            'txtGrad.Visible = False
            grpConstant.Visible = True
            txtConstant.Visible = True
            txtConstant.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtConstant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConstant.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            constantEqn = Val(txtConstant.Text)
            'grpConstant.Visible = False
            ' txtConstant.Visible = False
            IntervalPoints.Visible = True
            txtFirst.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtFirst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirst.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            firstEqn = Val(txtFirst.Text)
            txtLast.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtLast_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLast.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            lastEqn = Val(txtLast.Text)
            ' IntervalPoints.Visible = False
            Dim eqnY As Single
            Dim eqnX As Single
            eqnX = EquationX()
            eqnY = EquationY()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Function EquationY() As Single

        'assignment
        gradientEqn = Val(txtGrad.Text)
        constantEqn = Val(txtConstant.Text)

        'temperal variable for swapping
        Dim temp As Single

        'num2 must be greater than num1 for interval
        num1 = Val(txtFirst.Text)
        num2 = Val(txtLast.Text)

        If num1 > num2 Then
            temp = num1
            num1 = num2
            num2 = temp
        End If

        'looping interval for equation

        Dim init As Single
        Dim stepNum As Single

        If opt1.Checked = True Then
            stepNum = 1
        ElseIf opt2.Checked = True Then
            stepNum = 2
        ElseIf opt3.Checked = True Then
            stepNum = 3
        ElseIf opt4.Checked = True Then
            stepNum = 4
        ElseIf opt5.Checked = True Then
            stepNum = 5
        End If


        For init = num1 To num2 Step stepNum
            If chkY.Checked Then
                y = gradientEqn * init + constantEqn

                'listing coordinates
                lstCoordinates.Visible = True
                lstCoordinates.Items.Add(CStr("(" & init & " , " & y & ")"))
                'cmdReset.Visible = True
                lblEquation.Visible = True
                grpLine.Visible = True
                grpInterval.Visible = True
                lblCoordinates.Visible = True
                lblInterval.Visible = True
                cmdReset.Visible = True

                eqnShow = ("y = " & gradientEqn & "x + " & "(" & constantEqn & ")")
                interval = (CStr(num1) & " ≤ X ≤ " & CStr(num2))
                lblEquation.Text = eqnShow
                lblInterval.Text = interval
            End If
        Next

    End Function

    Private Function EquationX() As Single

        'assignment
        gradientEqn = Val(txtGrad.Text)
        constantEqn = Val(txtConstant.Text)

        'temperal variable for swapping
        Dim temp As Single

        'num2 must be greater than num1 for interval
        num1 = Val(txtFirst.Text)
        num2 = Val(txtLast.Text)

        If num1 > num2 Then
            temp = num1
            num1 = num2
            num2 = temp
        End If

        'looping interval for equation

        Dim init As Single
        Dim stepNum As Single

        If opt1.Checked = True Then
            stepNum = 1
        ElseIf opt2.Checked = True Then
            stepNum = 2
        ElseIf opt3.Checked = True Then
            stepNum = 3
        ElseIf opt4.Checked = True Then
            stepNum = 4
        ElseIf opt5.Checked = True Then
            stepNum = 5
        End If


        For init = num1 To num2 Step stepNum
            If chkX.Checked Then
                x = (init - constantEqn) / gradientEqn

                'listing coordinates
                lstCoordinates.Visible = True
                lstCoordinates.Items.Add(CStr("(" & x & " , " & init & ")"))
                'cmdReset.Visible = True
                lblEquation.Visible = True
                grpLine.Visible = True
                grpInterval.Visible = True
                lblCoordinates.Visible = True
                lblInterval.Visible = True
                cmdReset.Visible = True

                eqnShow = ("y = " & gradientEqn & "x + " & "(" & constantEqn & ")")
                interval = (CStr(num1) & " ≤ Y ≤ " & CStr(num2))
                lblEquation.Text = eqnShow
                lblInterval.Text = interval

            End If
        Next

    End Function

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click

        lstCoordinates.Items.Clear()
        lstCoordinates.Visible = False
        lblCoordinates.Visible = False
        lblInterval.Visible = False
        lblEquation.Visible = False
        grpLine.Visible = False
        grpInterval.Visible = False
        GroupBox2.Visible = False
        grpConstant.Visible = False
        grpGradient.Visible = False
        lblInterval.Visible = False
        txtConstant.Visible = False
        txtGrad.Visible = False
        IntervalPoints.Visible = False
        txtConstant.Text = ""
        txtFirst.Text = ""
        txtLast.Text = ""
        txtGrad.Text = ""
        txtA.Clear() : txtA.Focus() : txtB.Clear() : txtC.Clear()

    End Sub


    Private Sub txtA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtA.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            a = Val(txtA.Text)
            txtB.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub


    Private Sub txtB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtB.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            b = Val(txtB.Text)
            txtC.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub


    Private Sub txtC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtC.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            c = Val(txtC.Text)
            Dim EquationStraight As Single
            EquationStraight = EquationStraightLine()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Function EquationStraightLine() As Single
        lstCoordinates.Items.Clear()
        a = txtA.Text
        b = txtB.Text
        c = txtC.Text

        'accept variables in the format ax+by+c=0
        gradientEqn = -(a / b)
        'intercept on the y-axis, y=0
        y = Math.Round(-(c / b), 2)
        'coordinates of the y-axis
        Dim yAxis As String
        yAxis = CStr("Y-Axis: ( 0, " & y & ")")
        'intercept on the x-axis, x=0
        x = Math.Round(-(c / a), 2)
        'coordinates of the x-axis
        Dim xAxis As String
        xAxis = CStr("X-Axis: (" & x & ", 0)")

        'Displaying answers
        lblCoordinates.Visible = True
        grpLine.Visible = True
        lblEquation.Visible = True
        lstCoordinates.Visible = True

        lblEquation.Text = CStr("y = " & gradientEqn & "x + (" & y & ")")
        lstCoordinates.Items.Add("Gradient, m = " & gradientEqn)
        lstCoordinates.Items.Add(yAxis)
        lstCoordinates.Items.Add(xAxis)

        cmdReset.Visible = True

    End Function

End Class