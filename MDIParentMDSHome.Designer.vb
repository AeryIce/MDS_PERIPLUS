<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParentMDSHome
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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.ButtonClose = New System.Windows.Forms.Button()
		Me.ButtonMaximize = New System.Windows.Forms.Button()
		Me.ButtonMiniMize = New System.Windows.Forms.Button()
		Me.LabelDeskripsi = New System.Windows.Forms.Label()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.MasterTSMI = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusTSMI = New System.Windows.Forms.ToolStripMenuItem()
		Me.ClassParetoTSMI = New System.Windows.Forms.ToolStripMenuItem()
		Me.UserTSMI = New System.Windows.Forms.ToolStripMenuItem()
		Me.StoreManagerTSMI = New System.Windows.Forms.ToolStripMenuItem()
		Me.JadwalOrderTokoTSMI = New System.Windows.Forms.ToolStripMenuItem()
		Me.TargetSalesTokoTSMI = New System.Windows.Forms.ToolStripMenuItem()
		Me.SettingDatabaseTSMI = New System.Windows.Forms.ToolStripMenuItem()
		Me.InformasiTokoTSMI = New System.Windows.Forms.ToolStripMenuItem()
		Me.SettingPromoPOSTSMI = New System.Windows.Forms.ToolStripMenuItem()
		Me.MasterTokoWeeklyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MasterBOWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MasterStaffTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MasterStrukBandaraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MasterTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MasterDataPOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SalesHarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TransferDataMDSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExportMDSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImportMDSBukuEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PanelMenuProgram = New System.Windows.Forms.Panel()
		Me.Panel1.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.PanelMenuProgram.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.ButtonClose)
		Me.Panel1.Controls.Add(Me.ButtonMaximize)
		Me.Panel1.Controls.Add(Me.ButtonMiniMize)
		Me.Panel1.Controls.Add(Me.LabelDeskripsi)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1141, 30)
		Me.Panel1.TabIndex = 1
		'
		'ButtonClose
		'
		Me.ButtonClose.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.close_window_32px
		Me.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonClose.Location = New System.Drawing.Point(1108, 3)
		Me.ButtonClose.Name = "ButtonClose"
		Me.ButtonClose.Size = New System.Drawing.Size(25, 23)
		Me.ButtonClose.TabIndex = 4
		Me.ButtonClose.UseVisualStyleBackColor = True
		'
		'ButtonMaximize
		'
		Me.ButtonMaximize.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.maximize_window_32px
		Me.ButtonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonMaximize.Location = New System.Drawing.Point(1077, 3)
		Me.ButtonMaximize.Name = "ButtonMaximize"
		Me.ButtonMaximize.Size = New System.Drawing.Size(25, 23)
		Me.ButtonMaximize.TabIndex = 3
		Me.ButtonMaximize.UseVisualStyleBackColor = True
		'
		'ButtonMiniMize
		'
		Me.ButtonMiniMize.BackgroundImage = Global.MDS_Periplus.My.Resources.Resources.minimize_window_32px
		Me.ButtonMiniMize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonMiniMize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonMiniMize.Location = New System.Drawing.Point(1046, 3)
		Me.ButtonMiniMize.Name = "ButtonMiniMize"
		Me.ButtonMiniMize.Size = New System.Drawing.Size(25, 23)
		Me.ButtonMiniMize.TabIndex = 2
		Me.ButtonMiniMize.UseVisualStyleBackColor = True
		'
		'LabelDeskripsi
		'
		Me.LabelDeskripsi.AutoSize = True
		Me.LabelDeskripsi.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelDeskripsi.Location = New System.Drawing.Point(12, 9)
		Me.LabelDeskripsi.Name = "LabelDeskripsi"
		Me.LabelDeskripsi.Size = New System.Drawing.Size(206, 16)
		Me.LabelDeskripsi.TabIndex = 2
		Me.LabelDeskripsi.Text = ".::MDS PERIPLUS::."
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterTSMI, Me.ProsesToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1141, 24)
		Me.MenuStrip1.TabIndex = 2
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'MasterTSMI
		'
		Me.MasterTSMI.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.MasterTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusTSMI, Me.ClassParetoTSMI, Me.UserTSMI, Me.StoreManagerTSMI, Me.JadwalOrderTokoTSMI, Me.TargetSalesTokoTSMI, Me.SettingDatabaseTSMI, Me.InformasiTokoTSMI, Me.SettingPromoPOSTSMI, Me.MasterTokoWeeklyReportToolStripMenuItem, Me.MasterBOWToolStripMenuItem, Me.MasterStaffTokoToolStripMenuItem, Me.MasterStrukBandaraToolStripMenuItem, Me.MasterTokoToolStripMenuItem, Me.MasterDataPOSToolStripMenuItem})
		Me.MasterTSMI.Name = "MasterTSMI"
		Me.MasterTSMI.Size = New System.Drawing.Size(52, 20)
		Me.MasterTSMI.Text = "Master"
		'
		'StatusTSMI
		'
		Me.StatusTSMI.Name = "StatusTSMI"
		Me.StatusTSMI.Size = New System.Drawing.Size(207, 22)
		Me.StatusTSMI.Text = "Status"
		'
		'ClassParetoTSMI
		'
		Me.ClassParetoTSMI.Name = "ClassParetoTSMI"
		Me.ClassParetoTSMI.Size = New System.Drawing.Size(207, 22)
		Me.ClassParetoTSMI.Text = "Class Pareto"
		'
		'UserTSMI
		'
		Me.UserTSMI.Name = "UserTSMI"
		Me.UserTSMI.Size = New System.Drawing.Size(207, 22)
		Me.UserTSMI.Text = "User"
		'
		'StoreManagerTSMI
		'
		Me.StoreManagerTSMI.Name = "StoreManagerTSMI"
		Me.StoreManagerTSMI.Size = New System.Drawing.Size(207, 22)
		Me.StoreManagerTSMI.Text = "Store Manager"
		'
		'JadwalOrderTokoTSMI
		'
		Me.JadwalOrderTokoTSMI.Name = "JadwalOrderTokoTSMI"
		Me.JadwalOrderTokoTSMI.Size = New System.Drawing.Size(207, 22)
		Me.JadwalOrderTokoTSMI.Text = "Jadwal Order Toko"
		'
		'TargetSalesTokoTSMI
		'
		Me.TargetSalesTokoTSMI.Name = "TargetSalesTokoTSMI"
		Me.TargetSalesTokoTSMI.Size = New System.Drawing.Size(207, 22)
		Me.TargetSalesTokoTSMI.Text = "Target Sales Toko"
		'
		'SettingDatabaseTSMI
		'
		Me.SettingDatabaseTSMI.Name = "SettingDatabaseTSMI"
		Me.SettingDatabaseTSMI.Size = New System.Drawing.Size(207, 22)
		Me.SettingDatabaseTSMI.Text = "Setting Database"
		'
		'InformasiTokoTSMI
		'
		Me.InformasiTokoTSMI.Name = "InformasiTokoTSMI"
		Me.InformasiTokoTSMI.Size = New System.Drawing.Size(207, 22)
		Me.InformasiTokoTSMI.Text = "Informasi Toko"
		'
		'SettingPromoPOSTSMI
		'
		Me.SettingPromoPOSTSMI.Name = "SettingPromoPOSTSMI"
		Me.SettingPromoPOSTSMI.Size = New System.Drawing.Size(207, 22)
		Me.SettingPromoPOSTSMI.Text = "Setting Promo POS"
		'
		'MasterTokoWeeklyReportToolStripMenuItem
		'
		Me.MasterTokoWeeklyReportToolStripMenuItem.Name = "MasterTokoWeeklyReportToolStripMenuItem"
		Me.MasterTokoWeeklyReportToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
		Me.MasterTokoWeeklyReportToolStripMenuItem.Text = "Master Toko Weekly Report"
		'
		'MasterBOWToolStripMenuItem
		'
		Me.MasterBOWToolStripMenuItem.Name = "MasterBOWToolStripMenuItem"
		Me.MasterBOWToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
		Me.MasterBOWToolStripMenuItem.Text = "Master BOW"
		'
		'MasterStaffTokoToolStripMenuItem
		'
		Me.MasterStaffTokoToolStripMenuItem.Name = "MasterStaffTokoToolStripMenuItem"
		Me.MasterStaffTokoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
		Me.MasterStaffTokoToolStripMenuItem.Text = "Master Staff Toko"
		'
		'MasterStrukBandaraToolStripMenuItem
		'
		Me.MasterStrukBandaraToolStripMenuItem.Name = "MasterStrukBandaraToolStripMenuItem"
		Me.MasterStrukBandaraToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
		Me.MasterStrukBandaraToolStripMenuItem.Text = "Master Struk Bandara"
		'
		'MasterTokoToolStripMenuItem
		'
		Me.MasterTokoToolStripMenuItem.Name = "MasterTokoToolStripMenuItem"
		Me.MasterTokoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
		Me.MasterTokoToolStripMenuItem.Text = "Master Toko"
		'
		'MasterDataPOSToolStripMenuItem
		'
		Me.MasterDataPOSToolStripMenuItem.Name = "MasterDataPOSToolStripMenuItem"
		Me.MasterDataPOSToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
		Me.MasterDataPOSToolStripMenuItem.Text = "Master Data POS"
		'
		'ProsesToolStripMenuItem
		'
		Me.ProsesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesHarianToolStripMenuItem, Me.TransferDataMDSToolStripMenuItem, Me.ExportMDSToolStripMenuItem, Me.ImportMDSBukuEditToolStripMenuItem})
		Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
		Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
		Me.ProsesToolStripMenuItem.Text = "Proses"
		'
		'SalesHarianToolStripMenuItem
		'
		Me.SalesHarianToolStripMenuItem.Name = "SalesHarianToolStripMenuItem"
		Me.SalesHarianToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
		Me.SalesHarianToolStripMenuItem.Text = "Sales Harian"
		'
		'TransferDataMDSToolStripMenuItem
		'
		Me.TransferDataMDSToolStripMenuItem.Name = "TransferDataMDSToolStripMenuItem"
		Me.TransferDataMDSToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
		Me.TransferDataMDSToolStripMenuItem.Text = "Transfer Data MDS"
		'
		'ExportMDSToolStripMenuItem
		'
		Me.ExportMDSToolStripMenuItem.Name = "ExportMDSToolStripMenuItem"
		Me.ExportMDSToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
		Me.ExportMDSToolStripMenuItem.Text = "Export MDS"
		'
		'ImportMDSBukuEditToolStripMenuItem
		'
		Me.ImportMDSBukuEditToolStripMenuItem.Name = "ImportMDSBukuEditToolStripMenuItem"
		Me.ImportMDSBukuEditToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
		Me.ImportMDSBukuEditToolStripMenuItem.Text = "Import MDS Buku / Edit"
		'
		'PanelMenuProgram
		'
		Me.PanelMenuProgram.BackColor = System.Drawing.Color.Aqua
		Me.PanelMenuProgram.Controls.Add(Me.MenuStrip1)
		Me.PanelMenuProgram.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelMenuProgram.Location = New System.Drawing.Point(0, 30)
		Me.PanelMenuProgram.Name = "PanelMenuProgram"
		Me.PanelMenuProgram.Size = New System.Drawing.Size(1141, 23)
		Me.PanelMenuProgram.TabIndex = 3
		'
		'MDIParentMDSHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.ClientSize = New System.Drawing.Size(1141, 826)
		Me.Controls.Add(Me.PanelMenuProgram)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "MDIParentMDSHome"
		Me.Opacity = 0.95R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MDIParentMDSHome"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.PanelMenuProgram.ResumeLayout(False)
		Me.PanelMenuProgram.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents LabelDeskripsi As Label
	Friend WithEvents ButtonMiniMize As Button
	Friend WithEvents ButtonMaximize As Button
	Friend WithEvents ButtonClose As Button
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents MasterTSMI As ToolStripMenuItem
	Friend WithEvents StatusTSMI As ToolStripMenuItem
	Friend WithEvents ClassParetoTSMI As ToolStripMenuItem
	Friend WithEvents UserTSMI As ToolStripMenuItem
	Friend WithEvents StoreManagerTSMI As ToolStripMenuItem
	Friend WithEvents JadwalOrderTokoTSMI As ToolStripMenuItem
	Friend WithEvents TargetSalesTokoTSMI As ToolStripMenuItem
	Friend WithEvents SettingDatabaseTSMI As ToolStripMenuItem
	Friend WithEvents InformasiTokoTSMI As ToolStripMenuItem
	Friend WithEvents SettingPromoPOSTSMI As ToolStripMenuItem
	Friend WithEvents MasterTokoWeeklyReportToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MasterBOWToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MasterStaffTokoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MasterStrukBandaraToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MasterTokoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MasterDataPOSToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PanelMenuProgram As Panel
	Friend WithEvents ProsesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SalesHarianToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TransferDataMDSToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExportMDSToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ImportMDSBukuEditToolStripMenuItem As ToolStripMenuItem
End Class
