Public Class BrainBox
    Dim result As Single
    Dim NumProb As Single, NumRight As Single
    Dim Number1 As Single
    Dim Number2 As Single
    Dim Itxtmax% : Dim Itxtmin%

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        'Generate next addition problem


        txtAnswer.Text = ""
        Message.Text = ""
        Score.Text = ""

        If txtMin.Text = "" Then
            MsgBox("Provide txtminimum Number", MsgBoxStyle.Information, "Error, Reqired Number")
            txtMin.Focus()
            Exit Sub

        Else
            Itxtmin = Val(txtMin.Text)
        End If

        If txtMax.Text = "" Then
            MsgBox("Provide txtmaximum Number", MsgBoxStyle.Information, "Error, Reqired Number")
            txtMax.Focus()
            Exit Sub
        Else
            Itxtmax = txtMax.Text
        End If

        NumProb = NumProb + 1

        Number1 = Int((Itxtmax - Itxtmin + 1) * Rnd()) + Itxtmin
        Number2 = Int((Itxtmax - Itxtmin + 1) * Rnd()) + Itxtmin

        'Generate random numbers for addends
        'Number1 = Int(Rnd() * 1)
        'Number2 = Int(Rnd() * 5)
        txtNum1.Text = Number1
        txtNum2.Text = Number2

        If rbAdd.Checked Then
            result = FuncAdd()

        ElseIf rbSub.Checked Then
            result = FuncSubtract()

        ElseIf rbDiv.Checked Then
            result = FuncDivide()

        ElseIf rbMult.Checked Then
            result = FuncMult()
        End If

        txtAnswer.Focus()
    End Sub

    Private Sub Flash_Card_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        txtMin.Focus()
        VBMath.Randomize()
        NumProb = 0
        NumRight = 0
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click

        txtMin.Clear() : txtMax.Clear()
        txtAnswer.Clear() : Message.Clear() : Score.Text = "Play"
        txtNum1.Clear() : txtNum2.Clear()
        txtMin.Focus()

    End Sub
    Public Function FuncDivide() As Single
        'this function calculates for the divide operator
        result = Number1 / Number2
        FuncDivide = Math.Round(result, 2)
    End Function

    Public Function FuncAdd() As Single
        'this fuction calculates for the add operator
        result = Number1 + Number2
        FuncAdd = result
    End Function
    Public Function FuncMult() As Single

        result = Number1 * Number2
        FuncMult = result

    End Function
    Function FuncSubtract() As Single
        result = Number1 - Number2
        FuncSubtract = result
    End Function

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtMin.Clear() : txtMax.Clear()
        txtAnswer.Clear() : Message.Clear() : Score.Text = "Play"
        txtNum1.Clear() : txtNum2.Clear()
        txtMin.Focus()
    End Sub

    Private Sub txtAnswer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer.KeyPress
        Dim Ans As Single

        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Or e.KeyChar = ChrW(46) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then
            'Check answer
            Ans = Val(txtAnswer.Text)
            If Ans = result Then
                NumRight = NumRight + 1
                Message.Text = "That's correct!"
                Score.Text = "Pass"
            Else
                Message.Text = "Answer is " + Format(result)
                Score.Text = "Fail"
            End If

            'Score.Text = Format(100 * NumRight / NumProb, "##0")
            'cmdNext.Enabled = True
            cmdNext.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub rbMult_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMult.CheckedChanged
        lblSign.Text = "×"

    End Sub
    Private Sub rbDiv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDiv.CheckedChanged
        lblSign.Text = "÷"

    End Sub
    Private Sub rbSub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSub.CheckedChanged
        lblSign.Text = "-"

    End Sub
    Private Sub rbAdd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAdd.CheckedChanged
        lblSign.Text = "+"

    End Sub

    Private Sub txtMax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMax.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then
            cmdNext.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub

    Private Sub txtMin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMin.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then
            txtMax.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub
End Class