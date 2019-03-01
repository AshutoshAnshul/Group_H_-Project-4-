Imports System.Security

Public Class Form1
    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        incond.Size = New Size(155, 100)
        fd.Size = New Size(155, 35)
        dem.Size = New Size(155, 35)
        parameter.Size = New Size(155, 35)
        dem.Top = fd.Bottom + 5
        parameter.Top = dem.Bottom + 5
        incond.Top = parameter.Bottom + 5
        setbut.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fd.Size = New Size(155, 270)
        incond.Size = New Size(155, 35)
        dem.Size = New Size(155, 35)
        parameter.Size = New Size(155, 35)
        dem.Top = fd.Bottom + 5
        parameter.Top = dem.Bottom + 5
        incond.Top = parameter.Bottom + 5
        setbut.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dem.Size = New Size(155, 150)
        fd.Size = New Size(155, 35)
        incond.Size = New Size(155, 35)
        parameter.Size = New Size(155, 35)
        dem.Top = fd.Bottom + 5
        parameter.Top = dem.Bottom + 5
        incond.Top = parameter.Bottom + 5
        setbut.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        parameter.Size = New Size(155, 100)
        fd.Size = New Size(155, 35)
        incond.Size = New Size(155, 35)
        dem.Size = New Size(155, 35)
        dem.Top = fd.Bottom + 5
        parameter.Top = dem.Bottom + 5
        incond.Top = parameter.Bottom + 5
        setbut.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If openfile.ShowDialog() = DialogResult.OK Then
            If openfile.FileName.EndsWith(".asc") Then
                MessageBox.Show(openfile.FileName+" read")
            Else 
                MessageBox.Show("It should be an asc file")
            End If
        End If

    End Sub
End Class
