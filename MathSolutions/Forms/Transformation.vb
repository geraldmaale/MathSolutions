Public Class Transformation
    Dim x, xa, y, yb, a, b, k, x1, x2, y1, y2, ans As Integer

    Private Sub Transformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        cboTrans.Items.Add("Rotation")
        cboTrans.Items.Add("Reflection")
        cboTrans.Items.Add("Translation")
        cboTrans.Items.Add("Enlargement")

    End Sub

    Private Sub cboTrans_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrans.SelectedIndexChanged
        cboSelect.Visible = True
        grpPoint.Enabled = False
        grpImage.Enabled = False
        Label6.Visible = False
        lblFormula.Visible = False
        btnClear.Visible = False
        btnTrans.Visible = False
        grpOrigin.Visible = False
        txtX.Clear() : txtXa.Clear() : txtY.Clear() : txtYb.Clear() : txtA.Clear() : txtB.Clear()
        lblShow.Visible = False
        grpScale.Visible = False

        If cboTrans.Text = "Reflection" Then
            cboSelect.Items.Clear()
            'enabling reflection
            lblTitle.Text = "Reflection"
            cboSelect.Items.Add("x-axis (the line y=0)")
            cboSelect.Items.Add("y-axis (the line x=0)")
            cboSelect.Items.Add("The line x=a or x-a=0")
            cboSelect.Items.Add("The line y=a or y-a=0")
            cboSelect.Items.Add("The line y=x or x-y=0")
            cboSelect.Items.Add("The line y=-x or x+y=0")
            cboSelect.Items.Add("Equation of line")

        ElseIf cboTrans.Text = "Rotation" Then
            cboSelect.Items.Clear()
            'enabling rotation
            lblTitle.Text = "Rotation"
            cboSelect.Items.Add("90°ACW or 270° CW")
            cboSelect.Items.Add("180° ACW ")
            cboSelect.Items.Add("270° ACW or 90° AC")
            cboSelect.Items.Add("Any point other than origin 90°")
            cboSelect.Items.Add("Any point other than origin 180°")
            cboSelect.Items.Add("Any point other than origin 270°")

        ElseIf cboTrans.Text = "Translation" Then
            lblTitle.Text = "Translation"
            cboSelect.Visible = False
            grpPoint.Enabled = True
            grpImage.Enabled = True
            Label6.Visible = True
            lblFormula.Visible = True
            lblFormula.Text = "If the  point (x, y) is translated by the vector (a, b), the image point is (x+a, y+b)."
            btnClear.Visible = True
            btnTrans.Visible = True
            grpOrigin.Visible = True : grpOrigin.Text = "Vector"
            txtX.Focus()

        ElseIf cboTrans.Text = "Enlargement" Then
            cboSelect.Items.Clear()
            'enabling enlargement
            lblTitle.Text = "Enlargement"
            cboSelect.Items.Add("From the origin")
            cboSelect.Items.Add("From any point other than origin ")
        End If
    End Sub

    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        grpPoint.Enabled = True
        grpImage.Enabled = True
        txtX.Focus()
        Label6.Visible = True
        lblFormula.Visible = True
        btnClear.Visible = True
        btnTrans.Visible = True
        grpOrigin.Visible = False
        grpPoint.Text = "Point" : grpImage.Text = "Image"
        grpScale.Visible = False

        txtX.Clear() : txtX.ForeColor = Color.Black
        txtXa.Clear() : txtXa.ForeColor = Color.Black
        txtY.Clear() : txtY.ForeColor = Color.Black
        txtYb.Clear() : txtYb.ForeColor = Color.Black
        txtX.Focus() : txtA.Clear() : txtB.Clear()
        lblShow.Visible = False : txtK.Clear()

        If cboSelect.Text = "x-axis (the line y=0)" Then
            lblFormula.Text = "The mapping is (x, y) --> (x, -y)"
            lblTitle.Text = "Reflection in the x-axis (the line y=0)"

        ElseIf cboSelect.Text = ("y-axis (the line x=0)") Then
            lblFormula.Text = "The mapping is (x, y) --> (-x, y)"
            lblTitle.Text = "Reflection in the y-axis (the line x=0)"

        ElseIf cboSelect.Text = ("The line x=a or x-a=0") Then
            lblFormula.Text = "The mapping is (x, y) --> (2a-x, y). If a=0, it becomes reflection in the y-axis."
            lblTitle.Text = "Reflection in the line x=a or x-a=0"
            grpOrigin.Visible = True : lblB.Enabled = False : txtB.Enabled = False

        ElseIf cboSelect.Text = ("The line y=a or y-a=0") Then
            lblFormula.Text = "The mapping is (x, y) --> (x, 2a-y). If a=0, it becomes reflection in the x-axis."
            lblTitle.Text = "Reflection in the line y=a or y-a=0"
            grpOrigin.Visible = True : lblB.Enabled = False : txtB.Enabled = False

        ElseIf cboSelect.Text = ("The line y=x or x-y=0") Then
            lblFormula.Text = "The mapping is (x, y) --> (y, x)"
            lblTitle.Text = "Reflection in theline y=x or y-x=0"

        ElseIf cboSelect.Text = ("The line y=-x or x+y=0") Then
            lblFormula.Text = "The mapping is (x, y) --> (-y, -x)"
            lblTitle.Text = "Reflection in the line y=-x or y+x=0"

        ElseIf cboSelect.Text = ("Equation of line") Then
            lblTitle.Text = "Finding the equation of the line of reflection"
            lblFormula.Text = "if x-coordinates are the same, y=k and if y-coordinates are the same, x=k. k is the midpoint of the point and image of x and y respectively."

        ElseIf cboSelect.Text = ("90°ACW or 270° CW") Then
            lblFormula.Text = "The mapping is (x, y) --> (-y, x)"
            lblTitle.Text = "Anticlockwise rotation of 90° about the origin"

        ElseIf cboSelect.Text = ("180° ACW ") Then
            lblFormula.Text = "The mapping is (x, y) --> (-x, -y)"
            lblTitle.Text = "Anticlockwise rotation of 180° about the origin"

        ElseIf cboSelect.Text = ("270° ACW or 90° AC") Then
            lblFormula.Text = "The mapping is (x, y) --> (-y, x)"
            lblTitle.Text = "Anticlockwise rotation of 270° about the origin"

        ElseIf cboSelect.Text = ("Any point other than origin 90°") Then
            lblFormula.Text = "Rotation about any point (a, b) other than the origin through 90° is (x, y) --> (-(y-b)+a, (x-a)+b)"
            lblTitle.Text = "Rotation about any point other than the origin through 90° ACW"
            grpOrigin.Visible = True

        ElseIf cboSelect.Text = ("Any point other than origin 180°") Then
            lblFormula.Text = "Rotation about any point (a, b) other than the origin through 180° is (x, y) --> (-(y-b)+a, (x-a)+b)"
            lblTitle.Text = "Rotation about any point other than the origin through 180° ACW"
            grpOrigin.Visible = True

        ElseIf cboSelect.Text = ("Any point other than origin 270°") Then
            lblFormula.Text = "Rotation about any point (a, b) other than the origin through 270° is (x, y) --> (-(y-b)+a, (x-a)+b)"
            lblTitle.Text = "Rotation about any point other than the origin through 270° ACW"
            grpOrigin.Visible = True

        ElseIf cboSelect.Text = ("From the origin") Then
            lblFormula.Text = "Enalargement with scale factor k, is (x, y) --> (kx, ky)"
            lblTitle.Text = "Enlargement from the origin"
            grpScale.Visible = True : grpScale.Location = New Point(213, 156)

        ElseIf cboSelect.Text = ("From any point other than origin ") Then
            lblFormula.Text = "Enlargement from any point (a, b) other than the origin with scale factor k, is (x, y) --> (k(x-a)+a, k(y-b)+b)"
            lblTitle.Text = "Enlargement from any point other than the origin"
            grpOrigin.Visible = True
            grpScale.Visible = True : grpScale.Location = New Point(346, 156)

        End If


    End Sub

    Private Sub txtX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtX.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then

            txtY.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtY.KeyPress, txtA.KeyPress, txtB.KeyPress, txtK.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then

            'txtY.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtXa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtXa.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then

            txtYb.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtYb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYb.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then

            'txtY.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtX.Clear() : txtX.ForeColor = Color.Black
        txtXa.Clear() : txtXa.ForeColor = Color.Black
        txtY.Clear() : txtY.ForeColor = Color.Black
        txtYb.Clear() : txtYb.ForeColor = Color.Black
        txtX.Focus() : txtA.Clear() : txtB.Clear()
        txtA.ForeColor = Color.Black : txtB.ForeColor = Color.Black
        lblShow.Visible = False : txtK.Clear()

    End Sub

    Private Sub btnTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrans.Click
        If cboSelect.Text = "x-axis (the line y=0)" Then
            RefXAxis()
        ElseIf cboSelect.Text = ("y-axis (the line x=0)") Then
            RefYAxis()
        ElseIf cboSelect.Text = ("The line x=a or x-a=0") Then
            RefXisA()
        ElseIf cboSelect.Text = ("The line y=a or y-a=0") Then
            RefYisA()
        ElseIf cboSelect.Text = ("The line y=x or x-y=0") Then
            Ref_YeX()
        ElseIf cboSelect.Text = ("The line y=-x or x+y=0") Then
            Ref_YemX()
        ElseIf cboSelect.Text = ("Equation of line") Then
            RefEquation()
        ElseIf cboSelect.Text = ("90°ACW or 270° CW") Then
            Rot90()
        ElseIf cboSelect.Text = ("180° ACW ") Then
            Rot180()
        ElseIf cboSelect.Text = ("270° ACW or 90° AC") Then
            Rot270()
        ElseIf cboSelect.Text = ("Any point other than origin 90°") Then
            RotAnyPt90()
        ElseIf cboSelect.Text = ("Any point other than origin 180°") Then
            RotAnyPt180()
        ElseIf cboSelect.Text = ("Any point other than origin 270°") Then
            RotAnyPt270()
        ElseIf cboSelect.Text = ("From the origin") Then
            Enlargement()
        ElseIf cboSelect.Text = ("From any point other than origin ") Then
            EnlargemtOther()
        ElseIf cboTrans.Text = "Translation" Then
            Translation()
        End If
    End Sub

    Public Function RefXAxis() As Integer
        'finding reflection in the x-axis
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : y = Val(txtY.Text)
            xa = x
            yb = -y
            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") is (" & xa & ", " & yb & ")"
        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : yb = Val(txtYb.Text)
            x = xa
            y = -yb
            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image (" & xa & ", " & yb & ") has point (" & x & "," & y & ") "

        End If
    End Function

    Public Function RefYAxis() As Integer
        'finding reflection in the y-axis
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : y = Val(txtY.Text)
            xa = -x
            yb = y
            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") is (" & xa & ", " & yb & ")"
        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : yb = Val(txtYb.Text)
            x = -xa
            y = yb
            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image (" & xa & ", " & yb & ") has point (" & x & "," & y & ") "

        End If
    End Function

    Public Function RefXisA() As Integer
        'finding reflection in the line x=a
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : y = Val(txtY.Text) : a = Val(txtA.Text)
            xa = ((2 * a) - x)
            yb = y

            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") in the line x=" & a & " is (" & xa & ", " & yb & ")"
        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : yb = Val(txtYb.Text) : a = Val(txtA.Text)
            x = ((2 * a) - xa)
            y = yb
            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") in the line x=" & a & " is (" & xa & ", " & yb & ")"

        End If
    End Function

    Public Function RefYisA() As Integer
        'finding reflection in the line y=a
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : y = Val(txtY.Text) : a = Val(txtA.Text)
            xa = x
            yb = ((2 * a) - y)

            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") in the line x=" & a & " is (" & xa & ", " & yb & ")"
        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : yb = Val(txtYb.Text) : a = Val(txtA.Text)
            x = xa
            y = ((2 * a) - yb)
            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") in the line x=" & a & " is (" & xa & ", " & yb & ")"

        End If
    End Function

    Public Function Ref_YeX() As Integer
        'finding reflection in the line y=x
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : y = Val(txtY.Text)
            xa = y
            yb = x
            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") is (" & xa & ", " & yb & ")"
        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : yb = Val(txtYb.Text)
            x = yb
            y = xa
            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image (" & xa & ", " & yb & ") has point (" & x & "," & y & ") "

        End If
    End Function

    Public Function Ref_YemX() As Integer
        'finding reflection in the line y=-x
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : y = Val(txtY.Text)
            xa = -y
            yb = -x
            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") is (" & xa & ", " & yb & ")"
        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : yb = Val(txtYb.Text)
            x = -yb
            y = -xa
            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image (" & xa & ", " & yb & ") has point (" & x & "," & y & ") "

        End If
    End Function

    Public Function RefEquation() As Integer
        'finding the equation of the line of reflection
        x = Val(txtX.Text) : xa = Val(txtXa.Text)
        y = Val(txtY.Text) : yb = Val(txtYb.Text)
        lblShow.Visible = True

        'comparing 
        If x = xa Then
            MsgBox("Since the x-coordinates are the same, the line of reflection is parallel to the x-asi with equation y=k", MsgBoxStyle.Information)

        ElseIf y = yb Then
            MsgBox("Since the y-coordinates are the same, the line of reflection is parallel to the y-asi with equation x=k", MsgBoxStyle.Information)

        End If

        'calculation midpoint
        x1 = ((x + xa) / 2)
        y1 = ((y + yb) / 2)

        'displaying answers
        lblShow.Text = "The midpoint of the points is (" & x1 & ", " & y1 & ") and the equation of line is y = " & y1

    End Function

    Public Function Rot90() As Integer
        'rotation through 90 anticlockwise
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : y = Val(txtY.Text)
            xa = -y
            yb = x
            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") is (" & xa & ", " & yb & ")"
        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : yb = Val(txtYb.Text)
            x = yb
            y = -xa
            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image (" & xa & ", " & yb & ") has point (" & x & "," & y & ") "

        End If
    End Function

    Public Function Rot180() As Integer
        'rotation through 180 anticlockwise
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : y = Val(txtY.Text)
            xa = -x
            yb = -y
            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") is (" & xa & ", " & yb & ")"
        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : yb = Val(txtYb.Text)
            x = -xa
            y = -yb
            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image (" & xa & ", " & yb & ") has point (" & x & "," & y & ") "

        End If
    End Function

    Public Function Rot270() As Integer
        'rotation through 270 anticlockwise
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : y = Val(txtY.Text)
            xa = y
            yb = -x
            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") is (" & xa & ", " & yb & ")"
        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : yb = Val(txtYb.Text)
            x = -yb
            y = xa
            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image (" & xa & ", " & yb & ") has point (" & x & "," & y & ") "

        End If
    End Function

    Public Function RotAnyPt90() As Integer
        'rotation about any point other than the origin through 90
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : a = Val(txtA.Text)
            y = Val(txtY.Text) : b = Val(txtB.Text)
            xa = (-(y - b) + a)
            yb = ((x - a) + b)

            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the rotation through 90° ACW about the point (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : a = Val(txtA.Text)
            yb = Val(txtYb.Text) : b = Val(txtB.Text)
            x = yb + a - b
            y = b + a - xa

            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the rotation through 90° ACW about the point (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        ElseIf txtA.Text = "" And txtB.Text = "" Then
            'finding the other origin
            xa = Val(txtXa.Text) : x = Val(txtX.Text)
            yb = Val(txtYb.Text) : y = Val(txtY.Text)
            a = (xa + y - yb + x) / 2
            b = yb - x + a

            txtA.Text = a : txtA.ForeColor = Color.Blue
            txtB.Text = b : txtB.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the rotation through 90° ACW about the point (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        End If
    End Function

    Public Function RotAnyPt180() As Integer
        'rotation about any point other than the origin through 180
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : a = Val(txtA.Text)
            y = Val(txtY.Text) : b = Val(txtB.Text)
            xa = (-(x - a) + a)
            yb = (-(y - b) + b)

            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the rotation through 90° ACW about the point (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : a = Val(txtA.Text)
            yb = Val(txtYb.Text) : b = Val(txtB.Text)
            x = -xa + (2 * a)
            y = -yb + (2 * b)

            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the rotation through 90° ACW about the point (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        ElseIf txtA.Text = "" And txtB.Text = "" Then
            'finding the other origin
            xa = Val(txtXa.Text) : x = Val(txtX.Text)
            yb = Val(txtYb.Text) : y = Val(txtY.Text)
            a = (xa + x) / 2
            b = (yb + y) / 2

            txtA.Text = a : txtA.ForeColor = Color.Blue
            txtB.Text = b : txtB.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the rotation through 90° ACW about the point (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        End If
    End Function

    Public Function RotAnyPt270() As Integer
        'rotation about any point other than the origin through 90
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : a = Val(txtA.Text)
            y = Val(txtY.Text) : b = Val(txtB.Text)
            xa = ((y - b) + a)
            yb = (-(x - a) + b)

            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the rotation through 90° ACW about the point (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : a = Val(txtA.Text)
            yb = Val(txtYb.Text) : b = Val(txtB.Text)
            y = xa + b - a
            x = a + b - yb

            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the rotation through 90° ACW about the point (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        ElseIf txtA.Text = "" And txtB.Text = "" Then
            'finding the other origin
            xa = Val(txtXa.Text) : x = Val(txtX.Text)
            yb = Val(txtYb.Text) : y = Val(txtY.Text)
            a = (xa - y + x + yb) / 2
            b = x - a + yb

            txtA.Text = a : txtA.ForeColor = Color.Blue
            txtB.Text = b : txtB.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the rotation through 90° ACW about the point (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        End If
    End Function

    Public Function Translation() As Integer
        'translation by a vector
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : a = Val(txtA.Text)
            y = Val(txtY.Text) : b = Val(txtB.Text)
            xa = x + a
            yb = y + b

            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") translated by the vector (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : a = Val(txtA.Text)
            yb = Val(txtYb.Text) : b = Val(txtB.Text)
            x = xa - a
            y = yb - b

            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") translated by the vector (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        ElseIf txtA.Text = "" And txtB.Text = "" Then
            'finding the other origin
            xa = Val(txtXa.Text) : x = Val(txtX.Text)
            yb = Val(txtYb.Text) : y = Val(txtY.Text)
            a = xa - x
            b = yb - y

            txtA.Text = a : txtA.ForeColor = Color.Blue
            txtB.Text = b : txtB.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") translated by the vector (" & a & ", " & b & ") is (" & xa & ", " & yb & ")"

        End If
    End Function

    Public Function Enlargement() As Integer
        'enlargement from the origin
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : y = Val(txtY.Text) : k = Val(txtK.Text)
            xa = k * x
            yb = k * y

            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the enlargement from the origin with scale factor " & k & " is (" & xa & ", " & yb & ")"
        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : yb = Val(txtYb.Text) : a = Val(txtK.Text)
            x = xa / k
            y = yb / k
            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the enlargement from the origin with scale factor " & k & " is (" & xa & ", " & yb & ")"

        End If
    End Function

    Public Function EnlargemtOther() As Integer
        'enlargement from any point other than the origin 
        If txtXa.Text = "" And txtYb.Text = "" Then
            'finding the image
            x = Val(txtX.Text) : a = Val(txtA.Text)
            y = Val(txtY.Text) : b = Val(txtB.Text) : k = Val(txtK.Text)
            xa = (k * x) - (k * a) + a
            yb = (k * y) - (k * b) + b

            txtXa.Text = xa : txtXa.ForeColor = Color.Blue
            txtYb.Text = yb : txtYb.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the enlargement from the point (" & a & ", " & b & ") with scale factor " & k & " is (" & xa & ", " & yb & ")"

        ElseIf txtX.Text = "" And txtY.Text = "" Then
            'finding the point
            xa = Val(txtXa.Text) : a = Val(txtA.Text)
            yb = Val(txtYb.Text) : b = Val(txtB.Text) : k = Val(txtK.Text)
            x = (xa + (k * a) - a) / k
            y = (yb + (k * b) - b) / k

            txtX.Text = x : txtX.ForeColor = Color.Blue
            txtY.Text = y : txtY.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the enlargement from the point (" & a & ", " & b & ") with scale factor " & k & " is (" & xa & ", " & yb & ")"

        ElseIf txtA.Text = "" And txtB.Text = "" Then
            'finding the other origin
            xa = Val(txtXa.Text) : x = Val(txtX.Text)
            yb = Val(txtYb.Text) : y = Val(txtY.Text) : k = Val(txtK.Text)
            a = (xa - (k * x)) / (1 - k)
            b = (yb - (k * y)) / (1 - k)

            txtA.Text = a : txtA.ForeColor = Color.Blue
            txtB.Text = b : txtB.ForeColor = Color.Blue
            lblShow.Visible = True
            lblShow.Text = "The image of (" & x & "," & y & ") under the enlargement from the point (" & a & ", " & b & ") with scale factor " & k & " is (" & xa & ", " & yb & ")"

        End If
    End Function
End Class