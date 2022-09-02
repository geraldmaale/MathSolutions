Public Class CoordinateGeometry
    Dim y As Single : Dim a As Single : Dim b As Single : Dim c As Single : Dim d As Single
    Dim x, Grad As Single
    Dim gradientEqn As Single

    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        'selecting Gradient of a line
        If cboSelect.Text = "Gradient of a Line (points)" Then
            Label4.Text = "Gradient of a Line given points"
            txtX1.Clear() : txtX2.Clear() : txtY1.Clear() : txtY2.Clear()
            pnlAnsLength.Visible = False : txtX1.Focus()

            cmdReset.Visible = False
            pnlAnsLength.Visible = False
            pointA.Visible = True
            pointB.Visible = True
            txtX1.Focus()
            Label3.Visible = True
            lblFormula.Visible = True
            lblFormulaLabel.Visible = True
            lblFormula.Text = "m = (y2-y1) / (x2-x1)= Δy/Δx"

            lstCoordinates.Items.Clear()
            lstCoordinates.Visible = False
            lblCoordinates.Visible = False
            lblEquation.Visible = False
            grpLine.Visible = False
            grpFormat.Visible = False

            'selecting Length of a Line
        ElseIf cboSelect.Text = "Length of a Line (points)" Then
            Label4.Text = "Length of a Line given points"
            txtX1.Clear() : txtX2.Clear() : txtY1.Clear() : txtY2.Clear()
            pnlAnsLength.Visible = False : txtX1.Focus()

            cmdReset.Visible = False
            pointA.Visible = True
            pointB.Visible = True
            pnlAnsLength.Visible = False
            txtX1.Focus()
            lblFormula.Visible = True
            lblFormulaLabel.Visible = True
            Label3.Visible = True
            lblFormula.Text = "|AB|=√((x2-x1)² + (y2-y1)²)"


            lstCoordinates.Items.Clear()
            lstCoordinates.Visible = False
            lblCoordinates.Visible = False
            lblEquation.Visible = False
            grpLine.Visible = False
            grpFormat.Visible = False

            'Selecting equation of a line given 
        ElseIf cboSelect.Text = "Equation of a Line - 1" Then
            Label4.Text = "Equation of a Line given Straight Line"
            txtA.Clear() : txtB.Clear() : txtC.Clear()

            cmdReset.Visible = False
            pointA.Visible = False
            pointB.Visible = False
            pnlAnsLength.Visible = False
            lblFormula.Visible = False
            lblFormulaLabel.Visible = False
            Label3.Visible = False
            ' lblFormula.Text = "|AB|=√((x2-x1)²+(y2-y1)²)"

            grpFormat.Visible = True
            lstCoordinates.Items.Clear()
            lstCoordinates.Visible = False
            lblCoordinates.Visible = False
            lblEquation.Visible = False
            grpLine.Visible = False
            cmdReset.Visible = False

            txtA.Focus()

            'Selecting equation of a line given 
        ElseIf cboSelect.Text = "Equation of a Line - 2" Then
            Label4.Text = "Equation of a Line given Two Points"
            txtA.Clear() : txtB.Clear() : txtC.Clear()

            cmdReset.Visible = False
            pointA.Visible = True
            pointB.Visible = True
            pnlAnsLength.Visible = False
            lblFormula.Visible = True
            lblFormulaLabel.Visible = False
            lblFormula.Text = "y - y1 = m ( x - x1 )"
            Label3.Visible = True
            grpGrad.Visible = False

            grpFormat.Visible = False
            lstCoordinates.Items.Clear()
            lstCoordinates.Visible = False
            lblCoordinates.Visible = False
            lblEquation.Visible = False
            grpLine.Visible = False
            cmdReset.Visible = False

            txtX1.Focus()

            'Selecting equation of a line given 
        ElseIf cboSelect.Text = "Equation of a Line - 3" Then
            Label4.Text = "Equation of a Line given Gradient && Point"
            txtA.Clear() : txtB.Clear() : txtC.Clear()

            cmdReset.Visible = False
            pointA.Visible = True
            pointB.Visible = False
            pnlAnsLength.Visible = False
            lblFormula.Visible = True
            lblFormulaLabel.Visible = False
            Label3.Visible = True
            lblFormula.Text = "y - y1 = m ( x - x1 )"
            grpGrad.Visible = True
            grpGrad.Location = New Point(17, 202)

            grpFormat.Visible = False
            lstCoordinates.Items.Clear()
            lstCoordinates.Visible = False
            lblCoordinates.Visible = False
            lblEquation.Visible = False
            grpLine.Visible = False
            cmdReset.Visible = False

            txtX1.Focus()

        End If
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        txtX1.Clear() : txtX2.Clear() : txtY1.Clear() : txtY2.Clear() : txtGrad.Clear()
        pnlAnsLength.Visible = False : txtX1.Focus()
        lstCoordinates.Items.Clear()
        lstCoordinates.Visible = False
        lblCoordinates.Visible = False
        grpLine.Visible = False
        txtA.Clear() : txtA.Focus() : txtB.Clear() : txtC.Clear()

    End Sub

    Private Sub txtY1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtY1.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            b = Val(txtY1.Text)
            txtGrad.Focus()
            txtX2.Focus()
            Else
                e.KeyChar = ChrW(0)
            End If

    End Sub

    Private Sub txtY2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtY2.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            d = Val(txtY2.Text)
            If cboSelect.Text = "Length of a Line (points)" Then
                LengthLine()
            ElseIf cboSelect.Text = "Gradient of a Line (points)" Then
                GradientLine()
            ElseIf cboSelect.Text = "Equation of a Line - 2" Then
                StraightLine2()
            End If
        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub
    Private Sub txtX1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtX1.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            a = Val(txtX1.Text)
            txtY1.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub

    Private Sub txtX2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtX2.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            c = Val(txtX2.Text)
            txtY2.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub

    Private Function LengthLine() As Single
        Dim AB As Single
        Dim XL As Single : Dim YL As Single
        XL = Math.Pow((c - a), 2)
        YL = Math.Pow((d - b), 2)
        AB = Math.Sqrt(XL + YL)
        pnlAnsLength.Visible = True
        cmdReset.Visible = True
        lblFormulaLabel.Text = "Length of Line:"
        lblAnsEquation.Text = Math.Round(AB, 2) & " Units"
    End Function

    Private Function GradientLine() As Single
        Dim AB As Single
        Dim XL As Single : Dim YL As Single
        XL = (c - a)
        YL = (d - b)
        AB = (YL / XL)
        pnlAnsLength.Visible = True
        cmdReset.Visible = True
        lblFormulaLabel.Text = "Gradient of Line:"
        lblAnsEquation.Text = CSng(AB)
    End Function

    Private Sub LinearGraph2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.gms6
        cboSelect.Items.Add("Length of a Line (points)")
        cboSelect.Items.Add("Gradient of a Line (points)")
        cboSelect.Items.Add("Equation of a Line - 1")
        cboSelect.Items.Add("Equation of a Line - 2")
        cboSelect.Items.Add("Equation of a Line - 3")

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
            StraightLine1()

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Function StraightLine1() As Single
        lstCoordinates.Items.Clear()
        a = Val(txtA.Text)
        b = Val(txtB.Text)
        c = Val(txtC.Text)

        'accept variables in the format ax+by+c=0
        gradientEqn = Math.Round(-(a / b), 2)
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
        'grpLine.Location = New Point(12, 221)
        lblEquation.Visible = True
        lstCoordinates.Visible = True

        lblEquation.Text = CStr("y = " & gradientEqn & "x + (" & y & ")")
        lstCoordinates.Items.Add("Gradient, m = " & gradientEqn)
        lstCoordinates.Items.Add(yAxis)
        lstCoordinates.Items.Add(xAxis)

        cmdReset.Visible = True

    End Function

    Private Function StraightLine2() As Single
        lstCoordinates.Items.Clear()
       
        Dim AB As Single
        Dim XL As Single : Dim YL As Single
        XL = (c - a)
        YL = (d - b)
        AB = Math.Round((YL) / (XL), 2)

        'Displaying answers
        lblCoordinates.Visible = True
        grpLine.Visible = True
        grpLine.Location = New Point(142, 209)

        lblEquation.Visible = True
        lstCoordinates.Visible = True
        lstCoordinates.Size = New Point(138, 42)
        lblEquation.Text = CStr("y = " & AB & "x + (" & (AB * -(a)) + b & ")")
        lstCoordinates.Items.Add("Gradient, m = " & AB)

        cmdReset.Visible = True
    End Function

    Public Function StraightLine3() As Single
        lstCoordinates.Items.Clear()
        Grad = Val(txtGrad.Text)

        'Displaying answers
        lblCoordinates.Visible = True
        grpLine.Visible = True
        grpLine.Location = New Point(142, 209)

        lblEquation.Visible = True
        lstCoordinates.Visible = True
        lstCoordinates.Size = New Point(138, 42)
        lblEquation.Text = CStr("y = " & Grad & "x + (" & (Grad * -(a)) + b & ")")
        lstCoordinates.Items.Add("Gradient, m = " & Grad)

        cmdReset.Visible = True
    End Function

    Private Sub txtGrad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrad.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            StraightLine3()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub
End Class