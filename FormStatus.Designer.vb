<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatus
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.PanelAtas = New System.Windows.Forms.Panel()
		Me.LabelFormStatus = New System.Windows.Forms.Label()
		Me.ButtonClose = New System.Windows.Forms.Button()
		Me.ButtonMaximize = New System.Windows.Forms.Button()
		Me.ButtonMiniMize = New System.Windows.Forms.Button()
		Me.PanelAtas.SuspendLayout()
		Me.SuspendLayout()
		'
		'PanelAtas
		'
		Me.PanelAtas.Controls.Add(Me.ButtonClose)
		Me.PanelAtas.Controls.Add(Me.LabelFormStatus)
		Me.PanelAtas.Controls.Add(Me.ButtonMaximize)
		Me.PanelAtas.Controls.Add(Me.ButtonMiniMize)
		Me.PanelAtas.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelAtas.Location = New System.Drawing.Point(0, 0)
		Me.PanelAtas.Name = "PanelAtas"
		Me.PanelAtas.Size = New System.Drawing.Size(1009, 30)
		Me.PanelAtas.TabIndex = 0
		'
		'LabelFormStatus
		'
		Me.LabelFormStatus.AutoSize = True
		Me.LabelFormStatus.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelFormStatus.Location = New System.Drawing.Point(3, 8)
		Me.LabelFormStatus.Name = "LabelFormStatus"
		Me.LabelFormStatus.Size = New System.Drawing.Size(129, 16)
		Me.LabelFormStatus.TabIndex = 1
		Me.LabelFormStatus.Text = "Form Status"
		'
		'ButtonClose
		'
		Me.ButtonClose.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.close_window_32px
		Me.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonClose.Location = New System.Drawing.Point(975, 4)
		Me.ButtonClose.Name = "ButtonClose"
		Me.ButtonClose.Size = New System.Drawing.Size(25, 23)
		Me.ButtonClose.TabIndex = 7
		Me.ButtonClose.UseVisualStyleBackColor = True
		'
		'ButtonMaximize
		'
		Me.ButtonMaximize.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.maximize_window_32px
		Me.ButtonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonMaximize.Location = New System.Drawing.Point(944, 4)
		Me.ButtonMaximize.Name = "ButtonMaximize"
		Me.ButtonMaximize.Size = New System.Drawing.Size(25, 23)
		Me.ButtonMaximize.TabIndex = 6
		Me.ButtonMaximize.UseVisualStyleBackColor = True
		'
		'ButtonMiniMize
		'
		Me.ButtonMiniMize.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.minimize_window_32px
		Me.ButtonMiniMize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonMiniMize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonMiniMize.Location = New System.Drawing.Point(913, 4)
		Me.ButtonMiniMize.Name = "ButtonMiniMize"
		Me.ButtonMiniMize.Size = New System.Drawing.Size(25, 23)
		Me.ButtonMiniMize.TabIndex = 5
		Me.ButtonMiniMize.UseVisualStyleBackColor = True
		'
		'FormStatus
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1009, 569)
		Me.Controls.Add(Me.PanelAtas)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormStatus"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormStatus"
		Me.PanelAtas.ResumeLayout(False)
		Me.PanelAtas.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PanelAtas As Panel
	Friend WithEvents LabelFormStatus As Label
	Friend WithEvents ButtonClose As Button
	Friend WithEvents ButtonMaximize As Button
	Friend WithEvents ButtonMiniMize As Button
End Class
