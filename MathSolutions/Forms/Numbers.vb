Public Class Numbers

    'Private Sub prime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    pnlNumbers.Visible = True
    '    Label1.Text = "Prime Number: "
    '    Dim ans As Integer = FuncPrime(ans)
    'End Sub

    Private Sub factors_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GroupBox1.Visible = True
        Label1.Text = "Factors"
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        ComboBox1.Items.Add("Factors")
        ComboBox1.Items.Add("Multiples")
        ComboBox1.Items.Add("HCF & LCM")
        ComboBox1.Items.Add("Even Numbers")
        ComboBox1.Items.Add("Odd Numbers")
        ComboBox1.Items.Add("Prime Number")

        ComboBox1.Items.Add("Roots & Powers")
        'Label6.Visible = True

    End Sub
    'Public Function FuncPrime() As Integer
    '    lstPrime.Items.Clear()

    '    Dim i, number, remainder, not_divisible As Integer
    '    not_divisible = 1
    '    number = Val(a.Text)
    '    For i = 2 To number
    '        remainder = number Mod i + 1
    '        If remainder = 0 Then
    '            not_divisible = 0
    '            lstPrime.Visible = True
    '            Button1.Visible = True
    '            lstPrime.Items.Add(number & " is not a prime number, it is divisible by " & i)

    '        End If
    '        If not_divisible = 1 Then
    '            lstPrime.Visible = True
    '            Button1.Visible = True
    '            lstPrime.Items.Add(number & " is a prime number")
    '            Exit For
    '        End If
    '    Next

    'End Function

    Private Function AllIPrime(ByVal CheckMe As Long) As Boolean

        AllIPrime = True
        '1 is always prime so lets handle it here 
        If CheckMe = 1 Then
            AllIPrime = True
            Exit Function
        End If
        ' positive numbers only
        If CheckMe <= 0 Then
            AllIPrime = False
            Exit Function
        End If

        For i As Long = 2 To CheckMe - 1
            If CheckMe Mod i = 0 Then
                AllIPrime = False
                lstFactors.Visible = True
                btnClear.Visible = True

                Exit Function
            End If
        Next
    End Function

    Public Function FuncFactors() As Long
        lstFactors.Items.Clear()

        Dim i, number, remainder, not_divisible As Long
        not_divisible = 1
        number = Val(a.Text)

        If number > 1000000 Then
            MsgBox("This is a few seconds to calculate")
        End If

        For i = 1 To number
            remainder = number Mod i
            If remainder = 0 Then
                'not_divisible = 0
                lstFactors.Visible = True
                btnClear.Visible = True
                lstFactors.Items.Add(i)
            End If

        Next
    End Function

    Private Function FuncMultiples() As Long
        lstFactors.Items.Clear()

        Dim j, number, remainder As Long
        Dim i, stopNum As Long

        number = Val(a.Text)
        stopNum = Val(b.Text)

        For i = number To number
            lstFactors.Items.Add("Multiples of " & number)
            lstFactors.Items.Add("Stop at " & stopNum)

            For j = 1 To stopNum

                remainder = i * j
                lstFactors.Visible = True
                btnClear.Visible = True
                lstFactors.Items.Add(i & " * " & j & " = " & remainder)

            Next

        Next

    End Function

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Prime Number" Then
            Me.Size = New Point(584, 454)
            pnlNumbers.Visible = True
            Label2.Visible = True
            Label1.Text = "Prime Number"
            Label2.Text = "Prime Number Determinant"
            txtNotes.Visible = True
            txtNotes.Text = "A Prime Number is a number that can only be divided by itself and 1. Therefore a prime number has exactly two factors. Eg. 5 is a prime number because its factors are only 1 and 5. Note 1 is not a prime number."
            lstPrime.Visible = False
            lstFactors.Visible = False
            b.Visible = False
            lblStop.Visible = False
            ' Label6.Visible = False
            grpNumbers.Visible = False
            LcmHcf.Visible = False
            btnFind.Visible = False
            btnReset.Visible = False
            'cmdMultiples.Visible = False
            lstPrime.Items.Clear()
            a.Clear()
            a.Focus()

        ElseIf ComboBox1.Text = "Factors" Then
            Me.Size = New Point(584, 454)
            Label2.Visible = True
            pnlNumbers.Visible = True
            Label1.Text = "Factors of"
            Label2.Text = "Factors Generator"
            txtNotes.Visible = True
            txtNotes.Text = "A Factor is a number that divides exactly into it, giving a number as the answer. Eg. 5 is a factor of 30 since 30÷5=6, 5 is not a factor of 32 since 32÷5=6 remainder 2. 1 is a factor of every number and every number is a factor of itself."
            lstFactors.Visible = False
            lstPrime.Visible = False
            b.Visible = False
            lblStop.Visible = False
            ' Label6.Visible = False
            grpNumbers.Visible = False
            LcmHcf.Visible = False
            btnFind.Visible = False
            btnReset.Visible = False
            ' cmdMultiples.Visible = False
            lstFactors.Items.Clear()
            a.Clear()
            a.Focus()

        ElseIf ComboBox1.Text = "Multiples" Then
            Me.Size = New Point(584, 454)
            Label2.Visible = True
            pnlNumbers.Visible = True
            Label1.Text = "Multiples of "
            Label2.Text = "Multiples Generator"
            txtNotes.Visible = True
            txtNotes.Text = "A Multiple of a number is found by multiplying it by any number. Eg. 5×8=40, therefore 40 is a multiple of 5 or a multiple of 8."
            lstFactors.Visible = False
            lstPrime.Visible = False
            b.Visible = True
            lblStop.Visible = True
            ' Label6.Visible = False
            grpNumbers.Visible = False
            LcmHcf.Visible = False
            btnFind.Visible = False
            btnReset.Visible = False
            'cmdMultiples.Visible = True
            lstFactors.Items.Clear()
            a.Clear()
            a.Focus()

        ElseIf ComboBox1.Text = "Even Numbers" Then
            Label2.Visible = False
            NaturalNumbers.Show()
            Label2.Text = "Select your calculation"
            'Label6.Visible = True
            Me.Size = New Point(276, 445)
            pnlNumbers.Visible = False
            grpNumbers.Visible = False
            LcmHcf.Visible = False
            btnFind.Visible = False
            btnReset.Visible = False
            My.Forms.NaturalNumbers.ComboBox1.Text = "Even Numbers"

        ElseIf ComboBox1.Text = "Odd Numbers" Then
            Label2.Visible = False
            NaturalNumbers.Show()
            Label2.Text = "Select your calculation"
            My.Forms.NaturalNumbers.ComboBox1.Text = "Odd Numbers"
            ' Label6.Visible = True
            Me.Size = New Point(276, 445)
            pnlNumbers.Visible = False
            grpNumbers.Visible = False
            LcmHcf.Visible = False
            btnFind.Visible = False
            btnReset.Visible = False

        ElseIf ComboBox1.Text = "Roots & Powers" Then
            Label2.Visible = False
            NaturalNumbers.Show()
            My.Forms.NaturalNumbers.ComboBox1.Text = "Roots & Powers"
            Label2.Text = "Select your calculation"
            ' Label6.Visible = True
            Me.Size = New Point(276, 445)
            pnlNumbers.Visible = False
            grpNumbers.Visible = False
            LcmHcf.Visible = False
            btnFind.Visible = False
            btnReset.Visible = False

        ElseIf ComboBox1.Text = "HCF & LCM" Then
            Label2.Visible = True
            Label2.Text = "LCM && HCF of 2 Numbers"
            grpNumbers.Visible = True
            txtNum1.Focus()
            pnlNumbers.Visible = False
            LcmHcf.Visible = True
            lstFactors.Visible = False
            lstPrime.Visible = False
            btnClear.Visible = False
            ' Label6.Visible = False
            txtNotes.Visible = False
            btnFind.Visible = True
            btnReset.Visible = True
            Me.Size = New Point(426, 445)

        End If
    End Sub


    Private Sub a_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles a.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            cmdGo.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstFactors.Items.Clear()
        lstFactors.Visible = False
        lstPrime.Visible = False
        a.Text = ""
        b.Text = ""
        a.Focus()
    End Sub

    Private Sub b_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles b.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            a.Focus()

        Else : e.KeyChar = ChrW(0)

        End If
    End Sub

    Private Sub cmdGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGo.Click

        If ComboBox1.Text = "Prime Number" Then
            lstFactors.Visible = False

            lstPrime.Items.Clear()
            Dim lngSource As Long
            lngSource = a.Text
            Dim boolResult As Boolean
            boolResult = AllIPrime(lngSource)
            If boolResult = True Then
                lstPrime.Visible = True
                lstPrime.Items.Add(a.Text & " is a prime number!")
            Else
                lstFactors.Visible = False
                lstPrime.Visible = True
                lstPrime.Items.Add(a.Text & " is a not prime number!")
            End If
            Dim ans As Integer = AllIPrime(ans)


        ElseIf ComboBox1.Text = "Factors" Then
            FuncFactors()

        ElseIf ComboBox1.Text = "Multiples" Then
            FuncMultiples()

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        LcmHcf.Visible = True
        FuncLcm()
        FuncHCF()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtNum1.Text = ""
        txtNum2.Text = ""
        txtNum1.Focus()
        txtHcf.Text = ""
        txtLcm.Text = ""
        LcmHcf.Visible = False

    End Sub

    Public Function FuncLcm() As Integer
        Dim num1, num2, i, lcm As Integer
        num1 = Val(txtNum1.Text)
        num2 = Val(txtNum2.Text)
        lcm = 1

        While num1 > 1 Or num2 > 1
            For i = 2 To 1000
                If num1 Mod i = 0 Or num2 Mod i = 0 Then
                    'lstLcmHcf.Visible = True
                    'lstLcmHcf.Items.Add(num1 & " | " & num2)

                    If num1 Mod i = 0 Then
                        num1 = num1 / i
                    End If

                    If num2 Mod i = 0 Then
                        num2 = num2 / i
                    End If

                    lcm = lcm * i

                End If
            Next
        End While

        'lstLcmHcf.Visible = True
        'lstLcmHcf.Items.Add(lcm & 1 & " | " & 1)
        txtLcm.Text = CInt(lcm)

    End Function

    Public Function FuncHCF() As Integer

        Dim gcfnum1 = 1, gcfnum2 = 1, cntnum1(1000), cntnum2(1000), gcf, num1, num2, i As Integer
        num1 = Val(txtNum1.Text)
        num2 = Val(txtNum2.Text)
        gcf = 1

        'for num1
        While num1 > 1
            For i = 2 To 1000 Step 1
                If num1 Mod i = 0 Then
                    num1 = num1 / i
                    gcfnum1 = gcfnum1 * i
                    cntnum1(i) = cntnum1(i) + 1
                End If
            Next
        End While
       
        'for num2
        While num2 > 1
            For i = 2 To 1000 Step 1
                If num2 Mod i = 0 Then
                    num2 = num2 / i
                    gcfnum2 = gcfnum2 * i
                    cntnum2(i) = cntnum2(i) + 1
                End If
            Next
        End While


        'gcf logic
        For i = 2 To 1000 Step 1
            If cntnum1(i) = 0 Or cntnum2(i) = 0 Then
                Continue For
            ElseIf cntnum1(i) < cntnum2(i) Then
                gcf = gcf * Math.Pow(i, cntnum1(i))
            ElseIf cntnum2(i) < cntnum1(i) Then
                gcf = gcf * Math.Pow(i, cntnum2(i))
            ElseIf cntnum1(i) > 0 Then
                gcf = gcf * Math.Pow(i, cntnum1(i))
            ElseIf cntnum2(i) > 0 Then
                gcf = gcf * Math.Pow(i, cntnum2(i))
            End If
        Next

        txtHcf.Text = CInt(gcf)

    End Function

    Private Sub txtNum1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum1.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            txtNum2.Focus()

        Else : e.KeyChar = ChrW(0)

        End If
    End Sub

    Private Sub txtNum2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum2.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            btnFind.Focus()

        Else : e.KeyChar = ChrW(0)

        End If
    End Sub
End Class