Public Class FormKalkulator

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silakan isi Angka 1 dan Angka 2 terlebih dahulu!")
        Else
            TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        End If

    End Sub

    Private Sub FormKalkulator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silakan isi Angka 1 dan Angka 2 terlebih dahulu!")
        Else
            TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silakan isi Angka 1 dan Angka 2 terlebih dahulu!")
        Else
            TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silakan isi Angka 1 dan Angka 2 terlebih dahulu!")
        Else
            TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
