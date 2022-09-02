Public Class Pythagoras
    Dim opp, adj, hyp As Single
    Dim ans As Single

    Private Sub btnSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolve.Click
        Pythagoras()
    End Sub

    Public Function Pythagoras() As Single
        If txtOpp.Text = "" Then
            'solving opposite
            adj = Val(txtAdj.Text)
            hyp = Val(txtHyp.Text)

            opp = Math.Sqrt((hyp ^ 2) - (adj ^ 2))
            txtOpp.Text = opp : txtOpp.ForeColor = Color.Blue

        ElseIf txtAdj.Text = "" Then
            'solving adjacent
            opp = Val(txtOpp.Text)
            hyp = Val(txtHyp.Text)

            adj = Math.Sqrt((hyp ^ 2) - (opp ^ 2))
            txtAdj.Text = adj : txtAdj.ForeColor = Color.Blue

        ElseIf txtHyp.Text = "" Then
            'solving hypotenuse
            opp = Val(txtOpp.Text)
            adj = Val(txtAdj.Text)

            hyp = Math.Sqrt((adj ^ 2) + (opp ^ 2))
            txtHyp.Text = hyp : txtHyp.ForeColor = Color.Blue

        End If
    End Function

    Private Sub txtClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClear.Click
        txtAdj.Clear() : txtAdj.ForeColor = Color.Black
        txtHyp.Clear() : txtHyp.ForeColor = Color.Black
        txtOpp.Clear() : txtOpp.ForeColor = Color.Black
        txtOpp.Focus()

    End Sub

    Private Sub txtAdj_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdj.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            Pythagoras()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtHyp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHyp.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            Pythagoras()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtOpp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpp.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            Pythagoras()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub Pythagoras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        Label5.Text = "Pythagoras’ Theorem state that for any right-angled triangle: The square on the hypotenuse = the sum of the squares for the other two sides. "
        Label5.Text &= " From the figure;           |BC|² = |AB|² + |AC|    i.e. c² = a² + b², c = √(a² + b²). |AB|² = |BC|² - |AC|²    i.e. a² = c² - b², a = √(c² - b²). |AC|² = |BC|² - |AB|²    i.e. b² = c² - a²,	 b = √(c² - a²). "

    End Sub
End Class