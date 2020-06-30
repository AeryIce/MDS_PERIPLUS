<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMDSLogin
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
		Me.LabelStatusKoneksi = New System.Windows.Forms.Label()
		Me.TextBoxUserName = New System.Windows.Forms.TextBox()
		Me.TextBoxPassword = New System.Windows.Forms.TextBox()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.ButtonLogin = New System.Windows.Forms.Button()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.LabelPeririplus = New System.Windows.Forms.Label()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LabelStatusKoneksi
		'
		Me.LabelStatusKoneksi.AutoSize = True
		Me.LabelStatusKoneksi.Font = New System.Drawing.Font("Lucida Console", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusKoneksi.Location = New System.Drawing.Point(209, 429)
		Me.LabelStatusKoneksi.Name = "LabelStatusKoneksi"
		Me.LabelStatusKoneksi.Size = New System.Drawing.Size(10, 8)
		Me.LabelStatusKoneksi.TabIndex = 1
		Me.LabelStatusKoneksi.Text = "."
		'
		'TextBoxUserName
		'
		Me.TextBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxUserName.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxUserName.Location = New System.Drawing.Point(104, 171)
		Me.TextBoxUserName.Name = "TextBoxUserName"
		Me.TextBoxUserName.Size = New System.Drawing.Size(133, 28)
		Me.TextBoxUserName.TabIndex = 3
		'
		'TextBoxPassword
		'
		Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxPassword.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxPassword.Location = New System.Drawing.Point(104, 218)
		Me.TextBoxPassword.Name = "TextBoxPassword"
		Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBoxPassword.Size = New System.Drawing.Size(133, 28)
		Me.TextBoxPassword.TabIndex = 5
		'
		'ButtonCancel
		'
		Me.ButtonCancel.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.close_window_32px
		Me.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonCancel.FlatAppearance.BorderSize = 0
		Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonCancel.Location = New System.Drawing.Point(169, 263)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(61, 30)
		Me.ButtonCancel.TabIndex = 7
		Me.ButtonCancel.UseVisualStyleBackColor = True
		'
		'ButtonLogin
		'
		Me.ButtonLogin.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.telegram_app_32px
		Me.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonLogin.FlatAppearance.BorderSize = 0
		Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonLogin.Location = New System.Drawing.Point(110, 263)
		Me.ButtonLogin.Name = "ButtonLogin"
		Me.ButtonLogin.Size = New System.Drawing.Size(53, 30)
		Me.ButtonLogin.TabIndex = 6
		Me.ButtonLogin.UseVisualStyleBackColor = True
		'
		'PictureBox2
		'
		Me.PictureBox2.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.password_32px
		Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox2.Location = New System.Drawing.Point(62, 212)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(33, 40)
		Me.PictureBox2.TabIndex = 4
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.user_32px
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox1.Location = New System.Drawing.Point(62, 166)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(33, 40)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'PictureBox3
		'
		Me.PictureBox3.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.pngtree_vintage_frame_background_png_image_316654
		Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox3.Location = New System.Drawing.Point(11, 33)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(276, 376)
		Me.PictureBox3.TabIndex = 8
		Me.PictureBox3.TabStop = False
		'
		'LabelPeririplus
		'
		Me.LabelPeririplus.AutoSize = True
		Me.LabelPeririplus.BackColor = System.Drawing.Color.WhiteSmoke
		Me.LabelPeririplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LabelPeririplus.Font = New System.Drawing.Font("Courier New", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelPeririplus.Location = New System.Drawing.Point(86, 127)
		Me.LabelPeririplus.Name = "LabelPeririplus"
		Me.LabelPeririplus.Size = New System.Drawing.Size(124, 28)
		Me.LabelPeririplus.TabIndex = 9
		Me.LabelPeririplus.Text = "PERIPLUS"
		'
		'FormMDSLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ClientSize = New System.Drawing.Size(300, 450)
		Me.Controls.Add(Me.LabelPeririplus)
		Me.Controls.Add(Me.ButtonCancel)
		Me.Controls.Add(Me.ButtonLogin)
		Me.Controls.Add(Me.TextBoxPassword)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.TextBoxUserName)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.LabelStatusKoneksi)
		Me.Controls.Add(Me.PictureBox3)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormMDSLogin"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MDS LOGIN"
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Public WithEvents LabelStatusKoneksi As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents TextBoxUserName As TextBox
	Friend WithEvents TextBoxPassword As TextBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents ButtonLogin As Button
	Friend WithEvents ButtonCancel As Button
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents LabelPeririplus As Label
End Class
