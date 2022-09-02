Public Class Equations
    Dim a, b, c, d, x1, x2, x3 As Integer

    Private Sub btnSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolve.Click
        If ComboBox1.Text = "Quadratic Equations" Then
            'solving quadratic equation
            Quadratic()

        ElseIf ComboBox1.Text = "Cubic Equations" Then
            'solving cubic equation
            CubicEquation()

        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtD.Clear()
        txtX.Clear()
        txtY.Clear()
        txtZ.Clear()
        txtA.Focus()

    End Sub

    Private Sub Equations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ComboBox1.Focus()
        ComboBox1.Text = "Quadratic Equations"

        Me.Icon = My.Resources.gms6
        ComboBox1.Items.Add("Quadratic Equations")
        ComboBox1.Items.Add("Cubic Equations")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Quadratic Equations" Then
            txtA.Clear()
            txtB.Clear()
            txtC.Clear()
            txtD.Clear()
            txtX.Clear()
            txtY.Clear()
            txtZ.Clear()
            txtA.Focus()
            pnlA.Visible = True
            pnlB.Visible = True
            pnlC.Visible = True
            pnlD.Visible = False
            pnlX.Visible = True
            pnlY.Visible = True
            pnlZ.Visible = False
            lblQuadratic.Visible = True
            lblCubic.Visible = False
            txtA.Focus()
            Label1.Text = "Quadratic Equations"

        ElseIf ComboBox1.Text = "Cubic Equations" Then
            txtA.Clear()
            txtB.Clear()
            txtC.Clear()
            txtD.Clear()
            txtX.Clear()
            txtY.Clear()
            txtZ.Clear()
            txtA.Focus()
            pnlA.Visible = True
            pnlB.Visible = True
            pnlC.Visible = True
            pnlD.Visible = True
            pnlX.Visible = True
            pnlY.Visible = True
            pnlZ.Visible = True
            lblQuadratic.Visible = False
            lblCubic.Visible = True
            txtA.Focus()
            Label1.Text = "Cubic Equations"

        End If
    End Sub

    Private Sub txtA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtA.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then
            txtB.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Public Function CubicEquation() As Single
        'cubic equation calculation
        a = Val(txtA.Text)
        b = Val(txtB.Text)
        c = Val(txtC.Text)
        d = Val(txtD.Text)

        Dim f, g, h, i, j, k, l, m, n, p As Single

        f = ((3 * (c / a)) - ((b ^ 2 / a ^ 2))) / 3
        g = ((2 * (b ^ 3 / a ^ 3)) - (9 * ((b * c) / a ^ 2)) + (27 * (d / a))) / 27
        h = (g ^ 2 / 4) + (f ^ 3 / 27)

        'Determining roots
        If h > 0 Then
            'there is 1 real root 
            MsgBox("The equation has 1 real root, please try again!", MsgBoxStyle.Critical, "Cubic Equations Error")
            txtA.Focus()
            Exit Function
            'Dim r, s, t, u As Single
            'r = -(g / 2) + (h ^ (1 / 2))
            's = (r ^ (1 / 3))
            't = -(g / 2) - (h ^ (1 / 2))
            'u = (t ^ (1 / 3))

            ''finding values of x
            'x1 = (s + u) - (b * (3 / a))
            'x2 = -((s + u) / 2 - (b / 3 * a) + i * (s - u) * (3) ^ (1 / 2)) / 2
            'x3 = -((s + u) / 2 - (b / 3 * a) - i * (s - u) * (3) ^ (1 / 2)) / 2

            'txtX.Text = x1
            'txtY.Text = x2
            'txtZ.Text = x3

        ElseIf f = 0 And g = 0 And h = 0 Then
            'All 3 roots are real and equal
            x1 = ((d / a) ^ (1 / 3)) * -3
            x2 = ((d / a) ^ (1 / 3)) * -3
            x3 = ((d / a) ^ (1 / 3)) * -3

            txtX.Text = x1
            txtY.Text = x2
            txtZ.Text = x3

        ElseIf h <= 0 Then
            'All 3 roots are real
            i = ((g ^ 2 / 4) - h) ^ (1 / 2)
            j = i ^ (1 / 3)
            k = Math.Acos(-g / (2 * i))
            l = j * -1
            m = Math.Cos(k / 3)
            n = 3 ^ (1 / 2) * Math.Sin(k / 3)
            p = (b / (3 * a)) * -1

            'finding value(s) of x
            x1 = 2 * j * Math.Cos(k / 3) - (b / (3 * a))
            x2 = l * (m + n) + p
            x3 = l * (m - n) + p

            txtX.Text = x1
            txtY.Text = x2
            txtZ.Text = x3

        End If

    End Function

    Public Function Quadratic() As Integer
        'solving quadratic equation
        a = Val(txtA.Text)
        b = Val(txtB.Text)
        c = Val(txtC.Text)

        If a = 0 Or ((b ^ 2) - (4 * a * c)) < 0 Then
            MsgBox("You cannot solve for complex roots", MsgBoxStyle.Critical, "Quadratic Equations Error")
            txtA.Focus()
        Else
            d = Math.Sqrt((b ^ 2) - (4 * a * c))

            x1 = (-b - d) / (2 * a)
            x2 = (-b + d) / (2 * a)
        End If

        txtX.Text = CInt(x1)
        txtY.Text = CInt(x2)
    End Function

    Private Sub txtB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtB.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then
            txtC.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtC.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then
            If ComboBox1.Text = "Quadratic Equations" Then
                Quadratic()
            ElseIf ComboBox1.Text = "Cubic Equations" Then
                txtD.Focus()
            End If
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then
            CubicEquation()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub
End Class