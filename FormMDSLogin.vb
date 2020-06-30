Public Class FormMDSLogin
    Private Sub ButtonToMDI_Click(sender As Object, e As EventArgs)
        MDIParentMDSHome.Show()
        Me.Visible = False
    End Sub

    Private Sub FormMDSLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()


    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub
End Class
