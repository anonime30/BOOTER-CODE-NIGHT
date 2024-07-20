Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Timer1.Stop()
        Timer1.Interval = TextBox2.Text
        Timer1.Start()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Timer1.Stop()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = False

    End Sub

    Private Sub Timer.Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Try

            My.Compteur.Network.Ping(TextBox1.Text)

        Catch ex As Exception

        End Try

    End Sub

End Class