Imports System.Data.SqlClient
Module Modulekoneksi
	Public Conn As SqlConnection
	Public Dr As SqlDataReader
	Public Da As SqlDataAdapter
	Public Cmd As SqlCommand
	Public Ds As DataSet


	Sub Koneksi()
		Try
			Conn = New SqlConnection("Data Source = NUNU-PC\SQLEXPRESS ; Initial Catalog = INV ; Integrated Security = True")
			Conn.Open()
			FormMDSLogin.LabelStatusKoneksi.Text = "Database Connect"


		Catch ex As Exception
			FormMDSLogin.LabelStatusKoneksi.Text = "Fail To Connect"

		End Try

	End Sub



End Module
