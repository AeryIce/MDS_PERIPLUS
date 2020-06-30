Public Class FormStatus
    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = MDIParentMDSHome

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class