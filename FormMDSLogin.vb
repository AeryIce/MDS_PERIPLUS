Public Class FormMDSLogin
    Private Sub ButtonToMDI_Click(sender As Object, e As EventArgs)
        MDIParentMDSHome.Show()
        Me.Visible = False
    End Sub

    Private Sub FormMDSLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
