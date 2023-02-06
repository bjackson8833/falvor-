Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub lstFlavor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFlavor.SelectedIndexChanged
        If lstFlavor.SelectedItem = "Strawberry" Then
            picFlavor.Image = Image.FromFile("C:\Users\bjackson8833\Downloads\strawbberry.jpg")
        End If
        If lstFlavor.SelectedItem = "Cookies n Cream" Then
            picFlavor.Image = Image.FromFile("C:\Users\bjackson8833\Downloads\cooknes.jpg")
        End If
        If lstFlavor.SelectedItem = "Mint" Then
            picFlavor.Image = Image.FromFile("C:\Users\bjackson8833\Downloads\mint.jpg")
        End If
        If lstFlavor.SelectedItem = "Butter Peacon" Then
            picFlavor.Image = Image.FromFile("C:\Users\bjackson8833\Downloads\buter peacon.jpg")
        End If
        If lstFlavor.SelectedItem = "Banana" Then
            picFlavor.Image = Image.FromFile("C:\Users\bjackson8833\Downloads\banna.jpg")
        End If


    End Sub
End Class
