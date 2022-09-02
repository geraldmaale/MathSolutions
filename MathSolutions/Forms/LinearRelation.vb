Public Class LinearRelation
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

    Private Sub GraphsRelation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        lblNote.Text = "Any relation of the form y=mx+c where m and c are constants is called a Linear Relation. Eg. Y=2x+1 or 2y=4x-1 or y=x is a linear relation. The graph of a linear relation is a straight line and two points are needed to draw a straight line."
        cboSelect.Items.Add("Equation y")
        cboSelect.Items.Add("Equation x")


    End Sub

    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged

        If cboSelect.Text = "Equation y" Then
            IntervalPoints.Text = "Interval of x"
            Label2.Visible = True
            cmdCalculate.Visible = True
            cmdReset.Visible = True
            Label2.Text = "y = m x + c"
            txtConstant.Text = ""
            txtFirst.Text = ""
            txtLast.Text = ""
            txtGrad.Text = ""

            'Equation(InputBox("grad", "Gradient, m"), InputBox("constant", "Constant, c"), InputBox("num1", "Interval - X1"), InputBox("num2", "Interval - X2"))
            grpGradient.Visible = True : txtGrad.Visible = True
            grpConstant.Visible = True : txtConstant.Visible = True
            IntervalPoints.Visible = True
            txtGrad.Focus()

        ElseIf cboSelect.Text = "Equation x" Then
            IntervalPoints.Text = "Interval of y"
            Label2.Visible = True
            cmdCalculate.Visible = True
            cmdReset.Visible = True
            Label2.Text = "x = 1/m ( y - c)"
            txtConstant.Text = ""
            txtFirst.Text = ""
            txtLast.Text = ""
            txtGrad.Text = ""

            'Equation(InputBox("grad", "Gradient, m"), InputBox("constant", "Constant, c"), InputBox("num1", "First Range"), InputBox("num2", "Last Range"))
            grpGradient.Visible = True : txtGrad.Visible = True
            grpConstant.Visible = True : txtConstant.Visible = True
            IntervalPoints.Visible = True
            txtGrad.Focus()
        End If
    End Sub
    Private Sub txtInterval_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then

        Else
            e.KeyChar = ChrW(0)
            Beep()
        End If
    End Sub
    Private Sub txtGrad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrad.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
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
            NumStep.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub numstep_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumStep.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            firstEqn = Val(txtFirst.Text)

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

            If cboSelect.Text = "Equation y" Then
                EquationY()
            ElseIf cboSelect.Text = "Equation x" Then
                EquationX()
            End If
            
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Function EquationY() As Single
        lstCoordinates.Items.Clear()

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

        Dim init, stepnum As Single
        stepnum = Val(NumStep.Text)
        If NumStep.Text = "" Then
            stepnum = 1
            NumStep.Text = 1
        End If

        For init = num1 To num2 Step stepnum
            If cboSelect.Text = "Equation y" Then
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
                interval = (CStr(num1) & " ≤ x ≤ " & CStr(num2))
                lblEquation.Text = eqnShow
                lblInterval.Text = interval
            End If
        Next

    End Function

    Private Function EquationX() As Single
        lstCoordinates.Items.Clear()

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

        Dim init, stepnum As Single
        stepnum = Val(NumStep.Text)
        If NumStep.Text = "" Then
            stepnum = 1
            NumStep.Text = 1
        End If

        For init = num1 To num2 Step stepnum
            If cboSelect.Text = "Equation x" Then
                x = Math.Round((init - constantEqn) / gradientEqn, 2)

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
                interval = (CStr(num1) & " ≤ y ≤ " & CStr(num2))
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
        txtConstant.Text = ""
        txtFirst.Text = ""
        txtLast.Text = ""
        txtGrad.Text = ""
        NumStep.Clear()
        txtGrad.Focus()

    End Sub


    Private Sub cmdCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculate.Click
        If cboSelect.Text = "Equation y" Then
            EquationY()
        ElseIf cboSelect.Text = "Equation x" Then
            EquationX()
        End If

    End Sub
End Class