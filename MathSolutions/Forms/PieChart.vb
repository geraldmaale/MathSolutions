Public Class PieChart
    Private Sub PieChart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim n As Integer = 8
        For n = 3 To n
            ComboBox1.Items.Add(n)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        angle.Visible = False
        angle1.Visible = False
        angle2.Visible = False
        angle3.Visible = False
        angle4.Visible = False
        angle5.Visible = False
        angle6.Visible = False
        angle7.Visible = False
        angle8.Visible = False
        Label1.Visible = False : PictureBox1.Visible = False
        Label2.Visible = False : PictureBox2.Visible = False
        Label3.Visible = False : PictureBox3.Visible = False
        Label4.Visible = False : PictureBox4.Visible = False
        Label5.Visible = False : PictureBox5.Visible = False
        Label6.Visible = False : PictureBox6.Visible = False
        Label7.Visible = False : PictureBox7.Visible = False
        Label8.Visible = False : PictureBox8.Visible = False
        Me.Refresh()
        Item1.Focus()

        If ComboBox1.Text = "3" Then
            Item1.Focus()
            Item1.Visible = True : TextBox2.Visible = True
            Item2.Visible = True : TextBox4.Visible = True
            Item3.Visible = True : TextBox6.Visible = True
            item4.Visible = False : TextBox8.Visible = False
            item5.Visible = False : TextBox10.Visible = False
            item6.Visible = False : TextBox12.Visible = False
            item7.Visible = False : TextBox14.Visible = False
            item8.Visible = False : TextBox16.Visible = False
            Button2.Visible = True
            Button3.Visible = True
            item.Visible = True : Number.Visible = True

        ElseIf ComboBox1.Text = "4" Then
            Item1.Visible = True : TextBox2.Visible = True
            Item2.Visible = True : TextBox4.Visible = True
            Item3.Visible = True : TextBox6.Visible = True
            item4.Visible = True : TextBox8.Visible = True
            item5.Visible = False : TextBox10.Visible = False
            item6.Visible = False : TextBox12.Visible = False
            item7.Visible = False : TextBox14.Visible = False
            item8.Visible = False : TextBox16.Visible = False
            Button2.Visible = True
            Button3.Visible = True
            item.Visible = True : Number.Visible = True

        ElseIf ComboBox1.Text = "5" Then
            Item1.Visible = True : TextBox2.Visible = True
            Item2.Visible = True : TextBox4.Visible = True
            Item3.Visible = True : TextBox6.Visible = True
            item4.Visible = True : TextBox8.Visible = True
            item5.Visible = True : TextBox10.Visible = True
            item6.Visible = False : TextBox12.Visible = False
            item7.Visible = False : TextBox14.Visible = False
            item8.Visible = False : TextBox16.Visible = False
            Button2.Visible = True
            Button3.Visible = True
            item.Visible = True : Number.Visible = True

        ElseIf ComboBox1.Text = "6" Then
            Item1.Visible = True : TextBox2.Visible = True
            Item2.Visible = True : TextBox4.Visible = True
            Item3.Visible = True : TextBox6.Visible = True
            item4.Visible = True : TextBox8.Visible = True
            item5.Visible = True : TextBox10.Visible = True
            item6.Visible = True : TextBox12.Visible = True
            item7.Visible = False : TextBox14.Visible = False
            item8.Visible = False : TextBox16.Visible = False
            Button2.Visible = True
            Button3.Visible = True
            item.Visible = True : Number.Visible = True

        ElseIf ComboBox1.Text = "7" Then
            Item1.Visible = True : TextBox2.Visible = True
            Item2.Visible = True : TextBox4.Visible = True
            Item3.Visible = True : TextBox6.Visible = True
            item4.Visible = True : TextBox8.Visible = True
            item5.Visible = True : TextBox10.Visible = True
            item6.Visible = True : TextBox12.Visible = True
            item7.Visible = True : TextBox14.Visible = True
            item8.Visible = False : TextBox16.Visible = False
            Button2.Visible = True
            Button3.Visible = True
            item.Visible = True : Number.Visible = True

        ElseIf ComboBox1.Text = "8" Then
            Item1.Visible = True : TextBox2.Visible = True
            Item2.Visible = True : TextBox4.Visible = True
            Item3.Visible = True : TextBox6.Visible = True
            item4.Visible = True : TextBox8.Visible = True
            item5.Visible = True : TextBox10.Visible = True
            item6.Visible = True : TextBox12.Visible = True
            item7.Visible = True : TextBox14.Visible = True
            item8.Visible = True : TextBox16.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            item.Visible = True : Number.Visible = True

        ElseIf ComboBox1.Text = "9" Then
            Item1.Visible = True : TextBox2.Visible = True
            Item2.Visible = True : TextBox4.Visible = True
            Item3.Visible = True : TextBox6.Visible = True
            item4.Visible = False : TextBox8.Visible = False
            item5.Visible = False : TextBox10.Visible = False
            item6.Visible = False : TextBox12.Visible = False
            item7.Visible = False : TextBox14.Visible = False
            item8.Visible = False : TextBox16.Visible = False
            Button2.Visible = True
            Button3.Visible = True
            item.Visible = True : Number.Visible = True

        ElseIf ComboBox1.Text = "10" Then
            Item1.Visible = True : TextBox2.Visible = True
            Item2.Visible = True : TextBox4.Visible = True
            Item3.Visible = True : TextBox6.Visible = True
            item4.Visible = False : TextBox8.Visible = False
            item5.Visible = False : TextBox10.Visible = False
            item6.Visible = False : TextBox12.Visible = False
            item7.Visible = False : TextBox14.Visible = False
            item8.Visible = False : TextBox16.Visible = False
            Button2.Visible = True
            Button3.Visible = True
            item.Visible = True : Number.Visible = True

        End If
    End Sub

    Dim total, num1, num2, num3, num4, num5, num6, num7, num8 As Integer
    Dim itemNum1, itemNum2, itemNum3, itemNum4, itemNum5, itemNum6, itemNum7, itemNum8 As Integer
    Dim Str1, Str2, Str3, str4, str5, str6, str7, str8 As String

    ' Shows how to call the DrawPieChart method
    Public Sub drawPieChartHelper3()
        Dim percents() As Integer = {num1, num2, num3}
        Dim colors() As Color = {Color.Red, Color.Blue, Color.Orange}
        Dim graphics As Graphics = Me.CreateGraphics
        Dim location As Point = New Point(200, 70)
        Dim size As Size = New Point(200, 200)
        DrawPieChart(percents, colors, graphics, location, size)

    End Sub

    Public Sub drawPieChartHelper4()
        Dim percents() As Integer = {num1, num2, num3, num4}
        Dim colors() As Color = {Color.Red, Color.Blue, Color.Orange, Color.Khaki}
        Dim graphics As Graphics = Me.CreateGraphics
        Dim location As Point = New Point(200, 70)
        Dim size As Size = New Point(200, 200)
        DrawPieChart(percents, colors, graphics, location, size)

    End Sub

    Public Sub drawPieChartHelper5()
        Dim percents() As Integer = {num1, num2, num3, num4, num5}
        Dim colors() As Color = {Color.Red, Color.Blue, Color.Orange, Color.Khaki, Color.Yellow}
        Dim graphics As Graphics = Me.CreateGraphics
        Dim location As Point = New Point(200, 70)
        Dim size As Size = New Point(200, 200)
        DrawPieChart(percents, colors, graphics, location, size)

    End Sub

    Public Sub drawPieChartHelper6()
        Dim percents() As Integer = {num1, num2, num3, num4, num5, num6}
        Dim colors() As Color = {Color.Red, Color.Blue, Color.Orange, Color.Khaki, Color.Yellow, Color.Green}
        Dim graphics As Graphics = Me.CreateGraphics
        Dim location As Point = New Point(200, 70)
        Dim size As Size = New Point(200, 200)
        DrawPieChart(percents, colors, graphics, location, size)

    End Sub

    Public Sub drawPieChartHelper7()
        Dim percents() As Integer = {num1, num2, num3, num4, num5, num6, num7}
        Dim colors() As Color = {Color.Red, Color.Blue, Color.Orange, Color.Khaki, Color.Yellow, Color.Green, Color.Violet}
        Dim graphics As Graphics = Me.CreateGraphics
        Dim location As Point = New Point(200, 70)
        Dim size As Size = New Point(200, 200)
        DrawPieChart(percents, colors, graphics, location, size)

    End Sub

    Public Sub drawPieChartHelper8()
        Dim percents() As Integer = {num1, num2, num3, num4, num5, num6, num7, num8}
        Dim colors() As Color = {Color.Red, Color.Blue, Color.Orange, Color.Khaki, Color.Yellow, Color.Green, Color.Violet, Color.Pink}
        Dim graphics As Graphics = Me.CreateGraphics
        Dim location As Point = New Point(200, 70)
        Dim size As Size = New Point(200, 200)
        DrawPieChart(percents, colors, graphics, location, size)

    End Sub

    'draws piechart
    Public Sub DrawPieChart(ByVal percents() As Integer, ByVal colors() As Color, ByVal surface As Graphics, ByVal location As Point, ByVal piesize As Size)
        'CHECK IF SECTORS ARE UP TO 100
        Dim sum As Integer
        For Each percent As Integer In percents
            sum += percent
        Next

        'If sum <> total Then
        '    Throw New ArgumentException("Percentages do not add to 100.")
        '    'MsgBox("Percentages do not add to 100")
        '    'Exit Sub
        'End If

        If percents.Length <> colors.Length Then
            Throw New ArgumentException("There must be the same number of percents and colors.")
        End If

        Dim percentageTotal As Integer = 0
        For percent As Integer = 0 To percents.Length() - 1
            surface.FillPie(New SolidBrush(colors(percent)), New Rectangle(location, piesize), CType(percentageTotal * 360 / total, Single), CType(percents(percent) * 360 / total, Single))
            percentageTotal += percents(percent)
        Next
        Return
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Refresh()

        'calls the method that draws the pie chart
        'calculation for 3 number pie
        If ComboBox1.Text = "3" Then
            drawPieChartHelper3()

            num1 = Val(TextBox2.Text)
            num2 = Val(TextBox4.Text)
            num3 = Val(TextBox6.Text)
            total = num1 + num2 + num3

            'calculating angles
            If total = 0 Then
                total = 1
            End If

            itemNum1 = num1 / total * 360
            itemNum2 = num2 / total * 360
            itemNum3 = num3 / total * 360

            'dispalying angles
            angle.Visible = True
            angle1.Visible = True
            angle2.Visible = True
            angle3.Visible = True
            angle1.Text = itemNum1 & "°"
            angle2.Text = itemNum2 & "°"
            angle3.Text = itemNum3 & "°"


            'Me.Size = New Point(574, 421)
            Dim drawFormat As New StringFormat

            'draw report title
            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Black)
                formGraphics.DrawString(My.Resources.ReportTitle, drawFont, drawBrush, 250, 20, drawFormat)

            End Using


            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Transparent)
                formGraphics.DrawString(num1, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num2, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num3, drawFont, drawBrush, 0, 0, drawFormat)

            End Using

            Str1 = CStr(Item1.Text)
            Str2 = CStr(Item2.Text)
            Str3 = CStr(Item3.Text)

            Label1.Text = Str1
            Label2.Text = Str2
            Label3.Text = Str3

            Label1.Visible = True : PictureBox1.Visible = True
            Label2.Visible = True : PictureBox2.Visible = True
            Label3.Visible = True : PictureBox3.Visible = True
            Label4.Visible = False : PictureBox4.Visible = False
            Label5.Visible = False : PictureBox5.Visible = False
            Label6.Visible = False : PictureBox6.Visible = False
            Label7.Visible = False : PictureBox7.Visible = False
            Label8.Visible = False : PictureBox8.Visible = False


            PictureBox1.BackColor = Color.Red
            PictureBox2.BackColor = Color.Blue
            PictureBox3.BackColor = Color.Orange


            'calculation for 4 number pie
        ElseIf ComboBox1.Text = "4" Then
            drawPieChartHelper4()

            num1 = Val(TextBox2.Text)
            num2 = Val(TextBox4.Text)
            num3 = Val(TextBox6.Text)
            num4 = Val(TextBox8.Text)
            total = num1 + num2 + num3 + num4

            'calculating angles
            If total = 0 Then
                total = 1
            End If

            itemNum1 = num1 / total * 360
            itemNum2 = num2 / total * 360
            itemNum3 = num3 / total * 360
            itemNum4 = num4 / total * 360

            'dispalying angles
            angle.Visible = True
            angle1.Visible = True
            angle2.Visible = True
            angle3.Visible = True
            angle4.Visible = True
            angle1.Text = itemNum1 & "°"
            angle2.Text = itemNum2 & "°"
            angle3.Text = itemNum3 & "°"
            angle4.Text = itemNum4 & "°"

            'Me.Size = New Point(574, 421)
            Dim drawFormat As New StringFormat

            'draw report title
            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Black)
                formGraphics.DrawString(My.Resources.ReportTitle, drawFont, drawBrush, 250, 20, drawFormat)

            End Using


            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Transparent)
                formGraphics.DrawString(num1, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num2, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num3, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num4, drawFont, drawBrush, 0, 0, drawFormat)

            End Using

            Str1 = CStr(Item1.Text)
            Str2 = CStr(Item2.Text)
            Str3 = CStr(Item3.Text)
            str4 = CStr(item4.Text)

            Label1.Text = Str1
            Label2.Text = Str2
            Label3.Text = Str3
            Label4.Text = str4

            Label1.Visible = True : PictureBox1.Visible = True
            Label2.Visible = True : PictureBox2.Visible = True
            Label3.Visible = True : PictureBox3.Visible = True
            Label4.Visible = True : PictureBox4.Visible = True
            Label4.Visible = True : PictureBox4.Visible = True
            Label5.Visible = False : PictureBox5.Visible = False
            Label6.Visible = False : PictureBox6.Visible = False
            Label7.Visible = False : PictureBox7.Visible = False
            Label8.Visible = False : PictureBox8.Visible = False


            PictureBox1.BackColor = Color.Red
            PictureBox2.BackColor = Color.Blue
            PictureBox3.BackColor = Color.Orange
            PictureBox4.BackColor = Color.Khaki


            'calculation for 5 number pie
        ElseIf ComboBox1.Text = "5" Then
            drawPieChartHelper5()

            num1 = Val(TextBox2.Text)
            num2 = Val(TextBox4.Text)
            num3 = Val(TextBox6.Text)
            num4 = Val(TextBox8.Text)
            num5 = Val(TextBox10.Text)

            total = num1 + num2 + num3 + num4 + num5

            'calculating angles
            If total = 0 Then
                total = 1
            End If

            itemNum1 = num1 / total * 360
            itemNum2 = num2 / total * 360
            itemNum3 = num3 / total * 360
            itemNum4 = num4 / total * 360
            itemNum5 = num5 / total * 360

            'dispalying angles
            angle.Visible = True
            angle1.Visible = True
            angle2.Visible = True
            angle3.Visible = True
            angle4.Visible = True
            angle5.Visible = True

            angle1.Text = itemNum1 & "°"
            angle2.Text = itemNum2 & "°"
            angle3.Text = itemNum3 & "°"
            angle4.Text = itemNum4 & "°"
            angle5.Text = itemNum5 & "°"

            'Me.Size = New Point(574, 421)
            Dim drawFormat As New StringFormat

            'draw report title
            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Black)
                formGraphics.DrawString(My.Resources.ReportTitle, drawFont, drawBrush, 250, 20, drawFormat)

            End Using


            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Transparent)
                formGraphics.DrawString(num1, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num2, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num3, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num4, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num5, drawFont, drawBrush, 0, 0, drawFormat)

            End Using

            Str1 = CStr(Item1.Text)
            Str2 = CStr(Item2.Text)
            Str3 = CStr(Item3.Text)
            str4 = CStr(item4.Text)
            str5 = CStr(item5.Text)

            Label1.Text = Str1
            Label2.Text = Str2
            Label3.Text = Str3
            Label4.Text = str4
            Label5.Text = str5

            Label1.Visible = True : PictureBox1.Visible = True
            Label2.Visible = True : PictureBox2.Visible = True
            Label3.Visible = True : PictureBox3.Visible = True
            Label4.Visible = True : PictureBox4.Visible = True
            Label5.Visible = True : PictureBox5.Visible = True
            Label6.Visible = False : PictureBox6.Visible = False
            Label7.Visible = False : PictureBox7.Visible = False
            Label8.Visible = False : PictureBox8.Visible = False


            PictureBox1.BackColor = Color.Red
            PictureBox2.BackColor = Color.Blue
            PictureBox3.BackColor = Color.Orange
            PictureBox4.BackColor = Color.Khaki
            PictureBox5.BackColor = Color.Yellow


            'calculation for 6 number pie
        ElseIf ComboBox1.Text = "6" Then
            drawPieChartHelper6()

            num1 = Val(TextBox2.Text)
            num2 = Val(TextBox4.Text)
            num3 = Val(TextBox6.Text)
            num4 = Val(TextBox8.Text)
            num5 = Val(TextBox10.Text)
            num6 = Val(TextBox12.Text)

            total = num1 + num2 + num3 + num4 + num5 + num6

            'calculating angles
            If total = 0 Then
                total = 1
            End If

            itemNum1 = num1 / total * 360
            itemNum2 = num2 / total * 360
            itemNum3 = num3 / total * 360
            itemNum4 = num4 / total * 360
            itemNum5 = num5 / total * 360
            itemNum6 = num6 / total * 360

            'dispalying angles
            angle.Visible = True
            angle1.Visible = True
            angle2.Visible = True
            angle3.Visible = True
            angle4.Visible = True
            angle5.Visible = True
            angle6.Visible = True

            angle1.Text = itemNum1 & "°"
            angle2.Text = itemNum2 & "°"
            angle3.Text = itemNum3 & "°"
            angle4.Text = itemNum4 & "°"
            angle5.Text = itemNum5 & "°"
            angle6.Text = itemNum6 & "°"

            'Me.Size = New Point(574, 421)
            Dim drawFormat As New StringFormat

            'draw report title
            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Black)
                formGraphics.DrawString(My.Resources.ReportTitle, drawFont, drawBrush, 250, 20, drawFormat)

            End Using


            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Transparent)
                formGraphics.DrawString(num1, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num2, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num3, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num4, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num5, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num6, drawFont, drawBrush, 0, 0, drawFormat)

            End Using

            Str1 = CStr(Item1.Text)
            Str2 = CStr(Item2.Text)
            Str3 = CStr(Item3.Text)
            str4 = CStr(item4.Text)
            str5 = CStr(item5.Text)
            str6 = CStr(item6.Text)

            Label1.Text = Str1
            Label2.Text = Str2
            Label3.Text = Str3
            Label4.Text = str4
            Label5.Text = str5
            Label6.Text = str6

            Label1.Visible = True : PictureBox1.Visible = True
            Label2.Visible = True : PictureBox2.Visible = True
            Label3.Visible = True : PictureBox3.Visible = True
            Label4.Visible = True : PictureBox4.Visible = True
            Label5.Visible = True : PictureBox5.Visible = True
            Label6.Visible = True : PictureBox6.Visible = True
            Label7.Visible = False : PictureBox7.Visible = False
            Label8.Visible = False : PictureBox8.Visible = False


            PictureBox1.BackColor = Color.Red
            PictureBox2.BackColor = Color.Blue
            PictureBox3.BackColor = Color.Orange
            PictureBox4.BackColor = Color.Khaki
            PictureBox5.BackColor = Color.Yellow
            PictureBox6.BackColor = Color.Green


            'calculation for 7 number pie
        ElseIf ComboBox1.Text = "7" Then
            drawPieChartHelper7()

            num1 = Val(TextBox2.Text)
            num2 = Val(TextBox4.Text)
            num3 = Val(TextBox6.Text)
            num4 = Val(TextBox8.Text)
            num5 = Val(TextBox10.Text)
            num6 = Val(TextBox12.Text)
            num7 = Val(TextBox14.Text)

            total = num1 + num2 + num3 + num4 + num5 + num6 + num7

            'calculating angles
            If total = 0 Then
                total = 1
            End If

            itemNum1 = num1 / total * 360
            itemNum2 = num2 / total * 360
            itemNum3 = num3 / total * 360
            itemNum4 = num4 / total * 360
            itemNum5 = num5 / total * 360
            itemNum6 = num6 / total * 360
            itemNum7 = num7 / total * 360

            'dispalying angles
            angle.Visible = True
            angle1.Visible = True
            angle2.Visible = True
            angle3.Visible = True
            angle4.Visible = True
            angle5.Visible = True
            angle6.Visible = True
            angle7.Visible = True

            angle1.Text = itemNum1 & "°"
            angle2.Text = itemNum2 & "°"
            angle3.Text = itemNum3 & "°"
            angle4.Text = itemNum4 & "°"
            angle5.Text = itemNum5 & "°"
            angle6.Text = itemNum6 & "°"
            angle7.Text = itemNum7 & "°"

            'Me.Size = New Point(574, 421)
            Dim drawFormat As New StringFormat

            'draw report title
            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Black)
                formGraphics.DrawString(My.Resources.ReportTitle, drawFont, drawBrush, 250, 20, drawFormat)

            End Using


            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Transparent)
                formGraphics.DrawString(num1, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num2, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num3, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num4, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num5, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num6, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num7, drawFont, drawBrush, 0, 0, drawFormat)

            End Using

            Str1 = CStr(Item1.Text)
            Str2 = CStr(Item2.Text)
            Str3 = CStr(Item3.Text)
            str4 = CStr(item4.Text)
            str5 = CStr(item5.Text)
            str6 = CStr(item6.Text)
            str7 = CStr(item7.Text)

            Label1.Text = Str1
            Label2.Text = Str2
            Label3.Text = Str3
            Label4.Text = str4
            Label5.Text = str5
            Label6.Text = str6
            Label7.Text = str7

            Label1.Visible = True : PictureBox1.Visible = True
            Label2.Visible = True : PictureBox2.Visible = True
            Label3.Visible = True : PictureBox3.Visible = True
            Label4.Visible = True : PictureBox4.Visible = True
            Label5.Visible = True : PictureBox5.Visible = True
            Label6.Visible = True : PictureBox6.Visible = True
            Label7.Visible = True : PictureBox7.Visible = True
            Label8.Visible = False : PictureBox8.Visible = False


            PictureBox1.BackColor = Color.Red
            PictureBox2.BackColor = Color.Blue
            PictureBox3.BackColor = Color.Orange
            PictureBox4.BackColor = Color.Khaki
            PictureBox5.BackColor = Color.Yellow
            PictureBox6.BackColor = Color.Green
            PictureBox7.BackColor = Color.Violet


            'calculation for 8 number pie
        ElseIf ComboBox1.Text = "8" Then
            drawPieChartHelper8()

            num1 = Val(TextBox2.Text)
            num2 = Val(TextBox4.Text)
            num3 = Val(TextBox6.Text)
            num4 = Val(TextBox8.Text)
            num5 = Val(TextBox10.Text)
            num6 = Val(TextBox12.Text)
            num7 = Val(TextBox14.Text)
            num8 = Val(TextBox16.Text)

            total = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8

            'calculating angles
            If total = 0 Then
                total = 1
            End If

            itemNum1 = num1 / total * 360
            itemNum2 = num2 / total * 360
            itemNum3 = num3 / total * 360
            itemNum4 = num4 / total * 360
            itemNum5 = num5 / total * 360
            itemNum6 = num6 / total * 360
            itemNum7 = num7 / total * 360
            itemNum8 = num8 / total * 360

            'dispalying angles
            angle.Visible = True
            angle1.Visible = True
            angle2.Visible = True
            angle3.Visible = True
            angle4.Visible = True
            angle5.Visible = True
            angle6.Visible = True
            angle7.Visible = True
            angle8.Visible = True

            angle1.Text = itemNum1 & "°"
            angle2.Text = itemNum2 & "°"
            angle3.Text = itemNum3 & "°"
            angle4.Text = itemNum4 & "°"
            angle5.Text = itemNum5 & "°"
            angle6.Text = itemNum6 & "°"
            angle7.Text = itemNum7 & "°"
            angle8.Text = itemNum8 & "°"

            'Me.Size = New Point(574, 421)
            Dim drawFormat As New StringFormat

            'draw report title
            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Black)
                formGraphics.DrawString(My.Resources.ReportTitle, drawFont, drawBrush, 250, 20, drawFormat)

            End Using


            Using formGraphics As Graphics = Me.CreateGraphics(), _
            drawFont As New System.Drawing.Font("Times New Roman", 16), _
            drawBrush As New SolidBrush(Color.Transparent)
                formGraphics.DrawString(num1, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num2, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num3, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num4, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num5, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num6, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num7, drawFont, drawBrush, 0, 0, drawFormat)
                formGraphics.DrawString(num8, drawFont, drawBrush, 0, 0, drawFormat)

            End Using

            Str1 = CStr(Item1.Text)
            Str2 = CStr(Item2.Text)
            Str3 = CStr(Item3.Text)
            str4 = CStr(item4.Text)
            str5 = CStr(item5.Text)
            str6 = CStr(item6.Text)
            str7 = CStr(item7.Text)
            str8 = CStr(item8.Text)

            Label1.Text = Str1
            Label2.Text = Str2
            Label3.Text = Str3
            Label4.Text = str4
            Label5.Text = str5
            Label6.Text = str6
            Label7.Text = str7
            Label8.Text = str8

            Label1.Visible = True : PictureBox1.Visible = True
            Label2.Visible = True : PictureBox2.Visible = True
            Label3.Visible = True : PictureBox3.Visible = True
            Label4.Visible = True : PictureBox4.Visible = True
            Label5.Visible = True : PictureBox5.Visible = True
            Label6.Visible = True : PictureBox6.Visible = True
            Label7.Visible = True : PictureBox7.Visible = True
            Label8.Visible = True : PictureBox8.Visible = True


            PictureBox1.BackColor = Color.Red
            PictureBox2.BackColor = Color.Blue
            PictureBox3.BackColor = Color.Orange
            PictureBox4.BackColor = Color.Khaki
            PictureBox5.BackColor = Color.Yellow
            PictureBox6.BackColor = Color.Green
            PictureBox7.BackColor = Color.Violet
            PictureBox8.BackColor = Color.Pink

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Item1.Clear() : TextBox2.Clear()
        Item2.Clear() : TextBox4.Clear()
        Item3.Clear() : TextBox6.Clear()
        item4.Clear() : TextBox8.Clear()
        item5.Clear() : TextBox10.Clear()
        item6.Clear() : TextBox12.Clear()
        item7.Clear() : TextBox14.Clear()
        item8.Clear() : TextBox16.Clear()
        Label1.Visible = False : PictureBox1.Visible = False
        Label2.Visible = False : PictureBox2.Visible = False
        Label3.Visible = False : PictureBox3.Visible = False
        Label4.Visible = False : PictureBox4.Visible = False
        Label5.Visible = False : PictureBox5.Visible = False
        Label6.Visible = False : PictureBox6.Visible = False
        Label7.Visible = False : PictureBox7.Visible = False
        Label8.Visible = False : PictureBox8.Visible = False
        angle.Visible = False
        angle1.Visible = False
        angle2.Visible = False
        angle3.Visible = False
        angle4.Visible = False
        angle5.Visible = False
        angle6.Visible = False
        angle7.Visible = False
        angle8.Visible = False
        Item1.Focus()
        Refresh()
        Me.Refresh()
    End Sub

End Class