Public Class Form1

    Dim g As Graphics


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = PictureBox1.CreateGraphics
    End Sub



    Public Sub Marco()
        g.DrawRectangle(Pens.Black, 0, 0, PictureBox1.Width - 1, PictureBox1.Height - 1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label1.Text = PictureBox1.Width()
        Label2.Text = PictureBox1.Height()

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Refresh()

    End Sub
    'ejercicio 1
    Public Sub Ejercicio1_1(ax As UInt32, bx As UInt32, ay As UInt32, by As UInt32, n As UInt32)

        Dim x1, y1, x2, y2 As Single
        Dim r1, vi1, r2, vi2
        Dim mx As Single
        Dim i As Integer

        vi1 = ay

        r1 = (by - ay) / n

        mx = (bx + ax) / 2

        vi2 = by

        r2 = (by - ay) / n


        x1 = ax

        x2 = mx

        g.DrawRectangle(Pens.Black, ax, ay, bx - ax, by - ay)
        g.DrawLine(Pens.Black, mx, ay, mx, by)

        For i = 1 To n + 1
            y1 = vi1 + (i - 1) * r1
            y2 = vi2 - (i - 1) * r2
            g.DrawLine(Pens.Blue, x1, y1, x2, y2)



        Next

    End Sub



    Private Sub EJERCICIO1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO1ToolStripMenuItem.Click
        Ejercicio1_1(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)

    End Sub



    Public Sub Ejercicio2(ax As UInt32, bx As UInt32, ay As UInt32, by As UInt32, n As UInt32)

        Dim x, y, A, L As Single
        Dim vi1, r1, vi2, r2, vi3, r3, mmx, my, mx As Single
        Dim i As Integer
        My = (by + ay) / 2
        mx = (bx + ax) / 2
        mmx = (bx + mx) / 2



        g.DrawRectangle(Pens.Black, mx, ay, bx - mx, by - ay)
        g.DrawRectangle(Pens.Black, ax, ay, bx - ax, by - ay)

        For i = 1 To n
            x = mx + Rnd() * (mmx - mx)

            y = ay + Rnd() * (my - ay)

            A = (mmx - x) * 2

            L = (my - y) * 2



            g.DrawRectangle(Pens.Blue, x, y, A, L)

        Next

    End Sub



    Private Sub EJERCICIO2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO2ToolStripMenuItem.Click

        Ejercicio2(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)

    End Sub

End Class
