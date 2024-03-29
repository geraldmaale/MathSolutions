﻿Public Class CubicRelations
    Dim eqnShow As String
    Dim interval As String
    Dim A As Single
    Dim B As Single
    Dim C, D As Single
    Dim firstEqn As Single
    Dim lastEqn As Single
    Dim num1 As Single
    Dim num2 As Single
    Dim y As Single
    Dim x As Single

    

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        grpLine.Visible = False
        grpInterval.Visible = False
        lstCoordinates.Visible = False
        lblCoordinates.Visible = False
        txtA.Text = ""
        txtB.Text = ""
        txtC.Text = ""
        txtD.Text = ""
        txtFirst.Text = ""
        txtLast.Text = ""
        NumStep.Clear()

        txtA.Focus()

    End Sub

    Private Function EquationY() As Single
        lstCoordinates.Items.Clear()
        grpLine.Visible = True
        grpInterval.Visible = True
        lstCoordinates.Visible = True
        lblCoordinates.Visible = True

        'assignment
        A = Val(txtA.Text)
        B = Val(txtB.Text)
        C = Val(txtC.Text)
        D = Val(txtD.Text)

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
            y = ((A * (init) ^ 3) + (B * (init) ^ 2) + (C * init) + D)

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

            eqnShow = ("y = " & A & "x³ + " & "(" & B & ")x² + (" & C & ")x + (" & D & ")")
            interval = (CStr(num1) & " ≤ x ≤ " & CStr(num2))
            lblEquation.Text = eqnShow
            lblInterval.Text = interval
        Next

    End Function

    Private Sub cmdCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculate.Click
        EquationY()

    End Sub


    Private Sub txtA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtA.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Or e.KeyChar = ChrW(47) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then

            'Check answer
            A = Val(txtA.Text)
            txtB.Focus()

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtB.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            B = Val(txtB.Text)
            txtC.Focus()
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
            C = Val(txtC.Text)

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

            Dim eqnY As Single
            eqnY = EquationY()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub


    Private Sub txtC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtC.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            C = Val(txtC.Text)

            IntervalPoints.Visible = True
            txtD.Focus()

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            D = Val(txtD.Text)

            IntervalPoints.Visible = True
            NumStep.Focus()

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub
    Private Sub CubicRelations_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.gms6
        lblNote.Text = "Any relation in which the highest power of x is 3 is a Cubic Relation. The cubic relation has the form y=ax³+bx²+cx+d, where a, b, c and d are constants and a≠0. Eg. y=x³-5x, y=x(12-x)(8-x) are both cubic relations."

    End Sub
End Class