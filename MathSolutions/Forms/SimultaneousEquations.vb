Public Class SimultaneousEquations
    Dim a1, a2, a3, a4 As Integer
    Dim b1, b2, b3, b4 As Integer
    Dim c1, c2, c3, c4 As Integer
    Dim d1, d2, d3, d4 As Integer
    Dim x, y, z As Integer

    Private Sub Simultaneous_Equations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        cboDim.Items.Add("2")

    End Sub

    Private Sub cboDim_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDim.SelectedIndexChanged
        If cboDim.Text = "2" Then
            lblc.Visible = False
            Text1_2.Visible = False
            Text1_7.Visible = False
            Text1_10.Visible = False
            Text1_11.Visible = False
            Text1_12.Visible = False
            Label2_2.Visible = False
            Text1_27.Visible = False
            txtz.Visible = False
            Label1.Text = "Simultaneous Equation in 2 variables"
            Text1_2.Focus()

        ElseIf cboDim.Text = "3" Then
            lblc.Visible = True
            Text1_2.Visible = True
            Text1_7.Visible = True
            Text1_10.Visible = True
            Text1_11.Visible = True
            Text1_12.Visible = True
            Label2_2.Visible = True
            Text1_27.Visible = True
            txtz.Visible = True
            Label1.Text = "Simultaneous Equation in 3 variables"

        End If
    End Sub

    Private Sub btnSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolve.Click
        If cboDim.Text = "2" Then
            TwoVariables()
        ElseIf cboDim.Text = "3" Then

        End If

    End Sub

    Private Function TwoVariables() As Integer
        'declaring variables
        a1 = Val(Text1_0.Text)
        a2 = Val(Text1_1.Text)
        b1 = Val(Text1_5.Text)
        b2 = Val(Text1_6.Text)
        c1 = Val(Text1_25.Text)
        c2 = Val(Text1_26.Text)
        'equation is in the form
        'a1x+b1y=c1     --------(1)
        'a2x+b2y=c2     --------(2)

        'multiplying b2 in eqn 2 by eqn 1
        a3 = a1 * b2
        b3 = b1 * b2
        c3 = c1 * b2

        'multiplying b1 in eqn 1 by eqn 2
        a4 = a2 * b1
        b4 = b2 * b1
        c4 = c2 * b1

        'subtracting eqn 3 from wqn 4
        x = (c3 - c4) / (a3 - a4)
        y = (c1 - (a1 * x)) / b1

        'displaying x and y
        txtx.Text = "x = " & CInt(x)
        txty.Text = "y = " & CInt(y)

        'Dim two As Integer = TwoVariables

    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Text1_0.Clear() : Text1_2.Clear() : Text1_6.Clear()
        Text1_1.Clear() : Text1_25.Clear() : Text1_7.Clear()
        Text1_10.Clear() : Text1_26.Clear() : Text1_0.Focus()
        Text1_11.Clear() : Text1_27.Clear()
        Text1_12.Clear() : Text1_5.Clear()
        txtx.Clear() : txty.Clear() : txtz.Clear()

    End Sub

    Private Sub txtx_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtx.KeyPress, Text1_7.KeyPress, Text1_6.KeyPress, Text1_5.KeyPress, Text1_27.KeyPress, Text1_26.KeyPress, Text1_25.KeyPress, Text1_2.KeyPress, Text1_12.KeyPress, Text1_11.KeyPress, Text1_10.KeyPress, Text1_1.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub
End Class