Public Class Trigonometry
    Dim cos, sin, tan, sec, cot, cosec As Double
    Dim opp, adj, hyp, angle, trig, ans As Double

    Private Sub Trigonometry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        cboTrig.Items.Add("Sin θ")
        cboTrig.Items.Add("Cos θ")
        cboTrig.Items.Add("Tan θ - 1")
        cboTrig.Items.Add("Tan θ - 2")
        cboTrig.Items.Add("Sec θ")
        cboTrig.Items.Add("Cosec θ")
        cboTrig.Items.Add("Cot θ")
        cboTrig.Text = "Sin θ"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrig.SelectedIndexChanged
        txtAdj.Clear() : txtAdj.ForeColor = Color.Black
        txtAngle.Clear() : txtAngle.ForeColor = Color.Black
        txtHyp.Clear() : txtHyp.ForeColor = Color.Black
        txtOpp.Clear() : txtOpp.ForeColor = Color.Black
        txtTrig.Clear() : txtTrig.ForeColor = Color.Black


        If cboTrig.Text = "Sin θ" Then
            txtAdj.Visible = False
            txtOpp.Visible = True
            txtHyp.Visible = True
            lblOpp.Text = "opp :"
            lblHyp.Text = "hyp :"
            lblTrigFunx.Text = "Sine of an Angle"
            Label1.Text = "sin θ"
            txtOpp.Focus()
            lblHyp.Visible = True
            lblAngle.Visible = True
            txtAngle.Visible = True
            picSin.Visible = True
            picCos.Visible = False
            picCosec.Visible = False
            picCot.Visible = False
            picSec.Visible = False
            picTan.Visible = False

        ElseIf cboTrig.Text = "Cos θ" Then
            txtOpp.Visible = False
            txtAdj.Visible = True
            txtHyp.Visible = True
            txtAdj.Location = New Point(73, 2)
            lblOpp.Text = "adj :"
            lblHyp.Text = "hyp :"
            Label1.Text = "cos θ"
            lblTrigFunx.Text = "Cosine of an Angle"
            txtAdj.Focus()
            lblHyp.Visible = True
            lblAngle.Visible = True
            txtAngle.Visible = True
            picSin.Visible = False
            picCos.Visible = True
            picCosec.Visible = False
            picCot.Visible = False
            picSec.Visible = False
            picTan.Visible = False

        ElseIf cboTrig.Text = "Tan θ - 1" Then
            txtHyp.Visible = False
            txtOpp.Visible = True
            txtAdj.Visible = True
            txtAdj.Location = New Point(73, 34)
            lblOpp.Text = "opp :"
            lblHyp.Text = "adj :"
            Label1.Text = "tan θ"
            lblTrigFunx.Text = "Tangent of an Angle"
            txtOpp.Focus()
            lblHyp.Visible = True
            lblAngle.Visible = True
            txtAngle.Visible = True
            picSin.Visible = False
            picCos.Visible = False
            picCosec.Visible = False
            picCot.Visible = False
            picSec.Visible = False
            picTan.Visible = True

        ElseIf cboTrig.Text = "Tan θ - 2" Then
            txtHyp.Visible = False
            txtOpp.Visible = True
            txtAdj.Visible = True
            txtAdj.Location = New Point(73, 34)
            lblOpp.Text = "sin θ:"
            lblHyp.Text = "cos θ:"
            Label1.Text = "tan θ"
            lblTrigFunx.Text = "Tangent of an Angle"
            txtOpp.Focus()
            lblHyp.Visible = True
            lblAngle.Visible = True
            txtAngle.Visible = True
            picSin.Visible = False
            picCos.Visible = False
            picCosec.Visible = False
            picCot.Visible = False
            picSec.Visible = False
            picTan.Visible = True

        ElseIf cboTrig.Text = "Sec θ" Then
            txtHyp.Visible = False
            lblHyp.Visible = False
            txtOpp.Visible = True
            txtAdj.Visible = False
            txtAdj.Location = New Point(73, 34)
            lblOpp.Text = "cos θ:"
            Label1.Text = "Sec θ"
            lblTrigFunx.Text = "Secant of an Angle"
            txtOpp.Focus()
            lblAngle.Visible = False
            txtAngle.Visible = False
            picSin.Visible = False
            picCos.Visible = False
            picCosec.Visible = False
            picCot.Visible = False
            picSec.Visible = True
            picTan.Visible = False

        ElseIf cboTrig.Text = "Cosec θ" Then
            txtHyp.Visible = False
            lblHyp.Visible = False
            txtOpp.Visible = True
            txtAdj.Visible = False
            txtAdj.Location = New Point(73, 34)
            lblOpp.Text = "sin θ:"
            Label1.Text = "cosec θ"
            lblTrigFunx.Text = "Cosecant of an Angle"
            txtOpp.Focus()
            lblAngle.Visible = False
            txtAngle.Visible = False
            picSin.Visible = False
            picCos.Visible = False
            picCosec.Visible = True
            picCot.Visible = False
            picSec.Visible = False
            picTan.Visible = False

        ElseIf cboTrig.Text = "Cot θ" Then
            txtHyp.Visible = True
            lblHyp.Visible = True
            txtOpp.Visible = True
            txtAdj.Visible = False
            lblOpp.Text = "cos θ:"
            lblHyp.Text = "sin θ:"
            Label1.Text = "cot θ"
            lblTrigFunx.Text = "Cotangent of an Angle"
            txtOpp.Focus()
            lblAngle.Visible = False
            txtAngle.Visible = False
            picSin.Visible = False
            picCos.Visible = False
            picCosec.Visible = False
            picCot.Visible = True
            picSec.Visible = False
            picTan.Visible = False

        End If

    End Sub

    Public Function SinA() As Double
        'sine angles 
        Dim x As Double

        If txtAngle.Text = "" And txtOpp.Text = "" Then
            'finding angle and opposite

            trig = Val(txtTrig.Text)
            hyp = Val(txtHyp.Text)

            'displaying answer for opposite
            opp = Math.Round(trig * hyp, 2)
            txtOpp.Text = opp : txtOpp.ForeColor = Color.Blue

            'solving angle
            x = opp / hyp
            sin = Math.Asin(x)
            'converting from radians to angle
            sin = Math.Round((sin * (180 / Math.PI)), 2)

            txtAngle.Text = sin & " °"
            txtTrig.Text = Math.Round(x, 2)
            txtAngle.ForeColor = Color.Blue

        ElseIf txtAngle.Text = "" And txtHyp.Text = "" Then
            'finding angle and hypotenuse

            trig = Val(txtTrig.Text)
            opp = Val(txtOpp.Text)

            'displaying answer for hyp
            hyp = Math.Round(opp / trig, 2)
            txtHyp.Text = opp : txtHyp.ForeColor = Color.Blue

            'solving angle
            x = opp / hyp
            sin = Math.Asin(x)
            'converting from radians to angle
            sin = Math.Round((sin * (180 / Math.PI)), 2)

            txtAngle.Text = sin & " °"
            txtTrig.Text = Math.Round(x, 2)
            txtAngle.ForeColor = Color.Blue

        ElseIf txtAngle.Text = "" And txtTrig.Text = "" Then
            'finding angle and trig's sine

            opp = Val(txtOpp.Text)
            hyp = Val(txtHyp.Text)

            'degrees to radians
            'solving angle
            x = opp / hyp
            sin = Math.Asin(x)
            'converting from radians to angle
            sin = Math.Round((sin * (180 / Math.PI)), 2)

            txtAngle.Text = sin & " °"
            txtTrig.Text = Math.Round(x, 2)
            txtAngle.ForeColor = Color.Blue
            txtTrig.ForeColor = Color.Blue

        ElseIf txtTrig.Text = "" And txtOpp.Text = "" Then
            'finding trig's sine and opposite

            angle = Val(txtAngle.Text)
            hyp = Val(txtHyp.Text)
            angle = (angle * (Math.PI / 180))
            'finding trig's sine
            trig = Math.Sin(angle)
            txtTrig.Text = Math.Round(trig, 2) : txtTrig.ForeColor = Color.Blue
            'displaying answer for opposite
            opp = Math.Round(trig * hyp, 2)
            txtOpp.Text = opp : txtOpp.ForeColor = Color.Blue


        ElseIf txtTrig.Text = "" And txtHyp.Text = "" Then
            'finding trig's sine and hypotenuse
            angle = Val(txtAngle.Text)
            opp = Val(txtOpp.Text)
            angle = (angle * (Math.PI / 180))
            'finding trig's sine
            trig = Math.Round(Math.Sin(angle), 2)
            txtTrig.Text = trig : txtTrig.ForeColor = Color.Blue
            'finding hypotenuse
            hyp = Math.Round((opp / trig), 2)
            txtHyp.Text = hyp : txtHyp.ForeColor = Color.Blue

        ElseIf txtHyp.Text = "" And txtOpp.Text = "" Then
            'finding hypotenuse and opposite
            'this is complex
            MsgBox("You can't solve for hypotenuse and opposite, please try again", MsgBoxStyle.Critical, "Entry Error")
            txtOpp.Focus()
            Exit Function

        End If
    End Function

    Public Function CosA() As Double
        'Cosine angles 
        Dim x As Double

        If txtAngle.Text = "" And txtAdj.Text = "" Then
            'finding angle and Adjacent

            trig = Val(txtTrig.Text)
            hyp = Val(txtHyp.Text)

            'displaying answer for Adjacent
            adj = Math.Round(trig * hyp, 2)
            txtAdj.Text = adj : txtAdj.ForeColor = Color.Blue

            'solving angle
            x = adj / hyp
            cos = Math.Acos(x)
            'converting from radians to angle
            cos = Math.Round((cos * (180 / Math.PI)), 2)

            txtAngle.Text = cos & " °"
            txtTrig.Text = Math.Round(x, 2)
            txtAngle.ForeColor = Color.Blue

        ElseIf txtAngle.Text = "" And txtHyp.Text = "" Then
            'finding angle and hypotenuse

            trig = Val(txtTrig.Text)
            adj = Val(txtAdj.Text)

            'displaying answer for hyp
            hyp = Math.Round(adj / trig, 2)
            txtHyp.Text = hyp : txtHyp.ForeColor = Color.Blue

            'solving angle
            x = adj / hyp
            cos = Math.Acos(x)
            'converting from radians to angle
            cos = Math.Round((cos * (180 / Math.PI)), 2)

            txtAngle.Text = cos & " °"
            txtTrig.Text = Math.Round(x, 2)
            txtAngle.ForeColor = Color.Blue

        ElseIf txtAngle.Text = "" And txtTrig.Text = "" Then
            'finding angle and trig's cose

            adj = Val(txtAdj.Text)
            hyp = Val(txtHyp.Text)

            'degrees to radians
            'solving angle
            x = adj / hyp
            cos = Math.Acos(x)
            'converting from radians to angle
            cos = Math.Round((cos * (180 / Math.PI)), 2)

            txtAngle.Text = cos & " °"
            txtTrig.Text = Math.Round(x, 2)
            txtAngle.ForeColor = Color.Blue
            txtTrig.ForeColor = Color.Blue


        ElseIf txtTrig.Text = "" And txtAdj.Text = "" Then
            'finding trig's cos and adjosite

            angle = Val(txtAngle.Text)
            hyp = Val(txtHyp.Text)
            angle = (angle * (Math.PI / 180))
            'finding trig's sine
            trig = Math.Cos(angle)
            txtTrig.Text = Math.Round(trig, 2) : txtTrig.ForeColor = Color.Blue
            'displaying answer for adjosite
            adj = Math.Round(trig * hyp, 2)
            txtAdj.Text = adj : txtAdj.ForeColor = Color.Blue


        ElseIf txtTrig.Text = "" And txtHyp.Text = "" Then
            'finding trig's cos and hypotenuse
            angle = Val(txtAngle.Text)
            adj = Val(txtAdj.Text)
            angle = (angle * (Math.PI / 180))
            'finding trig's sine
            trig = Math.Round(Math.Cos(angle), 2)
            txtTrig.Text = trig : txtTrig.ForeColor = Color.Blue
            'finding hypotenuse
            hyp = Math.Round((adj / trig), 2)
            txtHyp.Text = hyp : txtHyp.ForeColor = Color.Blue


        ElseIf txtHyp.Text = "" And txtAdj.Text = "" Then
            'finding hypotenuse and Adjosite
            'this is complex
            MsgBox("You can't solve for hypotenuse and Adjacent, please try again", MsgBoxStyle.Critical, "Entry Error")
            txtAdj.Focus()
            Exit Function

        End If
    End Function

    Public Function Tan1A() As Double
        'tangent angles 
        Dim x As Double

        If txtAngle.Text = "" And txtOpp.Text = "" Then
            'finding angle and oppacent

            trig = Val(txtTrig.Text)
            adj = Val(txtAdj.Text)

            'displaying answer for oppacent
            opp = Math.Round(trig * adj, 2)
            txtOpp.Text = opp : txtOpp.ForeColor = Color.Blue

            'solving angle
            x = opp / adj
            tan = Math.Atan(x)
            'converting from radians to angle
            tan = Math.Round((tan * (180 / Math.PI)), 2)

            txtAngle.Text = tan & " °"
            txtTrig.Text = Math.Round(x, 2)
            txtAngle.ForeColor = Color.Blue

        ElseIf txtAngle.Text = "" And txtAdj.Text = "" Then
            'finding angle and adjotenuse

            trig = Val(txtTrig.Text)
            opp = Val(txtOpp.Text)

            'displaying answer for adj
            adj = Math.Round(opp / trig, 2)
            txtAdj.Text = adj : txtAdj.ForeColor = Color.Blue

            'solving angle
            x = opp / adj
            tan = Math.Atan(x)
            'converting from radians to angle
            tan = Math.Round((tan * (180 / Math.PI)), 2)

            txtAngle.Text = tan & " °"
            txtTrig.Text = Math.Round(x, 2)
            txtAngle.ForeColor = Color.Blue

        ElseIf txtAngle.Text = "" And txtTrig.Text = "" Then
            'finding angle and trig's tane

            opp = Val(txtOpp.Text)
            adj = Val(txtAdj.Text)

            'degrees to radians
            'solving angle
            x = opp / adj
            tan = Math.Atan(x)
            'converting from radians to angle
            tan = Math.Round((tan * (180 / Math.PI)), 2)

            txtAngle.Text = tan & " °"
            txtTrig.Text = Math.Round(x, 2)
            txtAngle.ForeColor = Color.Blue
            txtTrig.ForeColor = Color.Blue


        ElseIf txtTrig.Text = "" And txtOpp.Text = "" Then
            'finding trig's sine and opposite

            angle = Val(txtAngle.Text)
            adj = Val(txtAdj.Text)
            angle = (angle * (Math.PI / 180))
            'finding trig's sine
            trig = Math.Tan(angle)
            txtTrig.Text = Math.Round(trig, 2) : txtTrig.ForeColor = Color.Blue
            'displaying answer for opposite
            opp = Math.Round(trig * adj, 2)
            txtOpp.Text = opp : txtOpp.ForeColor = Color.Blue

        ElseIf txtTrig.Text = "" And txtAdj.Text = "" Then
            'finding trig's sine and adjacent
            angle = Val(txtAngle.Text)
            opp = Val(txtOpp.Text)
            angle = (angle * (Math.PI / 180))
            'finding trig's sine
            trig = Math.Round(Math.Tan(angle), 2)
            txtTrig.Text = trig : txtTrig.ForeColor = Color.Blue
            'finding adjacent
            adj = Math.Round((opp / trig), 2)
            txtAdj.Text = adj : txtAdj.ForeColor = Color.Blue


        ElseIf txtAdj.Text = "" And txtOpp.Text = "" Then
            'finding adjotenuse and opposite
            'this is complex
            MsgBox("You can't solve for adjacent and opposite, please try again", MsgBoxStyle.Critical, "Entry Error")
            txtOpp.Focus()
            Exit Function

        End If
    End Function

    Public Function Tan2A() As Double
        'tangent angles 
        Dim x As Double

        If txtAngle.Text = "" Then
            'finding angle

            adj = Val(txtAdj.Text)
            opp = Val(txtOpp.Text)
            x = opp / adj
            tan = Math.Atan(x)

            'converting from radians to angle
            tan = Math.Round((tan * (180 / Math.PI)), 2)

            txtAngle.Text = tan & " °"
            txtTrig.Text = Math.Round(x, 2)
            txtAngle.ForeColor = Color.Blue

        ElseIf txtAdj.Text = "" Then
            'finding adjacent
            angle = Val(txtAngle.Text)
            opp = Val(txtOpp.Text)
            'degrees to radians
            Dim NumAngle As Double = angle * (Math.PI / 180)
            adj = (Math.Tan(NumAngle)) * opp
            adj = Math.Round(adj, 2)

            txtAdj.Text = adj
            txtTrig.Text = Math.Round(NumAngle, 2)
            txtAdj.ForeColor = Color.Blue

        ElseIf txtOpp.Text = "" Then
            'finding opposite
            angle = Val(txtAngle.Text)
            adj = Val(txtAdj.Text)
            'degrees to radians
            Dim NumAngle As Double = angle * (Math.PI / 180)
            opp = adj / (Math.Tan(NumAngle))
            opp = Math.Round(opp, 2)

            txtOpp.Text = opp
            txtTrig.Text = Math.Round(NumAngle, 2)
            txtOpp.ForeColor = Color.Blue

        End If
    End Function

    Public Function SecA() As Double
        'secant angles 
        'opp is used as cos
        ' Dim x As Double

        If txtAngle.Text = "" Then
            'finding angle
            opp = Val(txtOpp.Text)
            'x = (opp * (Math.PI / 180))
            sec = 1 / opp
            sec = Math.Round(sec, 2)
            'txtAngle.Text = sec & " °"
            txtTrig.Text = Math.Round(sec, 2)
            'txtAngle.ForeColor = Color.Blue

            'opp is used as cos
        ElseIf txtOpp.Text = "" Then
            MsgBox("Cos θ Required", MsgBoxStyle.Information, "Secant Eroor")
            Exit Function
            txtOpp.Focus()

        End If
    End Function

    Public Function CosecA() As Double
        'cosec angles 
        'opp is used as sin
        ' Dim x As Double

        If txtAngle.Text = "" Then
            'finding angle
            opp = Val(txtOpp.Text)
            ' x = (opp * (Math.PI / 180))
            cosec = 1 / opp
            cosec = Math.Round(cosec, 2)
            'txtAngle.Text = sec & " °"
            txtTrig.Text = cosec
            'txtAngle.ForeColor = Color.Blue

            'opp is used as sin
        ElseIf txtOpp.Text = "" Then
            MsgBox("Sin θ Required", MsgBoxStyle.Information, "Cosecant Eroor")
            Exit Function
            txtOpp.Focus()

        End If
    End Function

    Public Function CotA() As Double
        'cotangent angles 

        If txtTrig.Text = "" Then
            'finding cot

            'hyp and opp used as sin and cos resp.
            opp = Val(txtOpp.Text)
            hyp = Val(txtHyp.Text)
            'converting from radians to degrees
            'cos = Math.Cos(opp * (Math.PI / 180))
            'sin = Math.Sin(hyp * (Math.PI / 180))
            cot = opp / hyp

            'txtAngle.Text = tan & " °"
            txtTrig.Text = Math.Round(cot, 2)
            'txtAngle.ForeColor = Color.Blue

            'hyp used as sin
        ElseIf txtHyp.Text = "" Then

            'finding sin
            cot = Val(txtTrig.Text)
            opp = Val(txtOpp.Text)
            hyp = opp / cot
            hyp = Math.Round(hyp, 2)

            txtHyp.Text = hyp
            txtHyp.ForeColor = Color.Blue

            'opp used as cos
        ElseIf txtOpp.Text = "" Then

            'finding cos
            cot = Val(txtTrig.Text)
            hyp = Val(txtHyp.Text)
            opp = hyp / cot
            opp = Math.Round(opp, 2)

            txtOpp.Text = opp
            txtOpp.ForeColor = Color.Blue

        End If
    End Function

    Private Sub btnSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolve.Click
        If cboTrig.Text = "Sin θ" Then
            SinA()

        ElseIf cboTrig.Text = "Cos θ" Then
            CosA()

        ElseIf cboTrig.Text = "Tan θ - 1" Then
            Tan1A()

        ElseIf cboTrig.Text = "Tan θ - 2" Then
            Tan2A()

        ElseIf cboTrig.Text = "Sec θ" Then
            SecA()

        ElseIf cboTrig.Text = "Cosec θ" Then
            CosecA()

        ElseIf cboTrig.Text = "Cot θ" Then
            CotA()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtAdj.Clear() : txtAdj.ForeColor = Color.Black
        txtAngle.Clear() : txtAngle.ForeColor = Color.Black
        txtHyp.Clear() : txtHyp.ForeColor = Color.Black
        txtOpp.Clear() : txtOpp.ForeColor = Color.Black
        txtTrig.Clear() : txtTrig.ForeColor = Color.Black
        txtOpp.Focus()

    End Sub

    Private Sub txtAdj_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdj.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then

        End If
    End Sub

    Private Sub txtAngle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAngle.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            If cboTrig.Text = "Sin θ" Then
                SinA()

            ElseIf cboTrig.Text = "Cos θ" Then
                CosA()

            ElseIf cboTrig.Text = "Tan θ - 1" Then
                Tan1A()

            ElseIf cboTrig.Text = "Tan θ - 2" Then
                Tan2A()

            ElseIf cboTrig.Text = "Sec θ" Then
                SecA()

            ElseIf cboTrig.Text = "Cosec θ" Then
                CosecA()

            ElseIf cboTrig.Text = "Cot θ" Then
                CotA()

            End If

        Else
            e.KeyChar = ChrW(0)

        End If
    End Sub

    Private Sub txtHyp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHyp.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            If cboTrig.Text = "Sin θ" Then
                SinA()

            ElseIf cboTrig.Text = "Cos θ" Then
                CosA()

            ElseIf cboTrig.Text = "Tan θ - 1" Then
                Tan1A()

            ElseIf cboTrig.Text = "Tan θ - 2" Then
                Tan2A()

            ElseIf cboTrig.Text = "Sec θ" Then
                SecA()

            ElseIf cboTrig.Text = "Cosec θ" Then
                CosecA()

            ElseIf cboTrig.Text = "Cot θ" Then
                CotA()

            End If

        Else
            e.KeyChar = ChrW(0)

        End If
    End Sub

    Private Sub txtOpp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpp.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            If cboTrig.Text = "Sin θ" Then
                SinA()

            ElseIf cboTrig.Text = "Cos θ" Then
                CosA()

            ElseIf cboTrig.Text = "Tan θ - 1" Then
                Tan1A()

            ElseIf cboTrig.Text = "Tan θ - 2" Then
                Tan2A()

            ElseIf cboTrig.Text = "Sec θ" Then
                SecA()

            ElseIf cboTrig.Text = "Cosec θ" Then
                CosecA()

            ElseIf cboTrig.Text = "Cot θ" Then
                CotA()

            End If

        Else
            e.KeyChar = ChrW(0)

        End If
    End Sub

    Private Sub txtTrig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTrig.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            If cboTrig.Text = "Sin θ" Then
                SinA()

            ElseIf cboTrig.Text = "Cos θ" Then
                CosA()

            ElseIf cboTrig.Text = "Tan θ - 1" Then
                Tan1A()

            ElseIf cboTrig.Text = "Tan θ - 2" Then
                Tan2A()

            ElseIf cboTrig.Text = "Sec θ" Then
                SecA()

            ElseIf cboTrig.Text = "Cosec θ" Then
                CosecA()

            ElseIf cboTrig.Text = "Cot θ" Then
                CotA()

            End If

        Else
            e.KeyChar = ChrW(0)

        End If
    End Sub
End Class