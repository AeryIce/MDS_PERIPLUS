Imports System.Windows.Forms

Public Class MDIParentMDSHome

	Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
		' Create a new instance of the child form.
		Dim ChildForm As New System.Windows.Forms.Form
		' Make it a child of this MDI form before showing it.
		ChildForm.MdiParent = Me

		m_ChildFormNumber += 1
		ChildForm.Text = "Window " & m_ChildFormNumber

		ChildForm.Show()
	End Sub

	Private m_ChildFormNumber As Integer

	Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
		Me.Close()
		FormMDSLogin.Close()
	End Sub

	Private Sub StatusTSMI_Click(sender As Object, e As EventArgs) Handles StatusTSMI.Click
		FormStatus.Show()
	End Sub
End Class
