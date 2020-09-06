<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Karyawan))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.inpNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.inpLaki = New System.Windows.Forms.RadioButton()
        Me.inpPerempuan = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inpKategori = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inpNip = New System.Windows.Forms.TextBox()
        Me.inpNohp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.KaryawanTab = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.inpSearch = New System.Windows.Forms.TextBox()
        Me.LaporanTab = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.logoutTab = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.KaryawanTab.SuspendLayout()
        Me.LaporanTab.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.logoutTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(14, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Daftar data karyawan yang tersedia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(715, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(780, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 20)
        Me.TextBox1.TabIndex = 5
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.AllowUserToOrderColumns = True
        Me.dataGrid.AllowUserToResizeColumns = False
        Me.dataGrid.AllowUserToResizeRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(430, 156)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.Size = New System.Drawing.Size(553, 277)
        Me.dataGrid.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(7, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 78)
        Me.Panel1.TabIndex = 7
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(113, 265)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 8
        Me.btn.Text = "Update"
        Me.btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'inpNama
        '
        Me.inpNama.Location = New System.Drawing.Point(110, 72)
        Me.inpNama.Name = "inpNama"
        Me.inpNama.Size = New System.Drawing.Size(264, 20)
        Me.inpNama.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jenis Kelamin"
        '
        'inpLaki
        '
        Me.inpLaki.AutoSize = True
        Me.inpLaki.Location = New System.Drawing.Point(109, 120)
        Me.inpLaki.Name = "inpLaki"
        Me.inpLaki.Size = New System.Drawing.Size(68, 17)
        Me.inpLaki.TabIndex = 15
        Me.inpLaki.TabStop = True
        Me.inpLaki.Text = "Laki Laki"
        Me.inpLaki.UseVisualStyleBackColor = True
        '
        'inpPerempuan
        '
        Me.inpPerempuan.AutoSize = True
        Me.inpPerempuan.Location = New System.Drawing.Point(217, 120)
        Me.inpPerempuan.Name = "inpPerempuan"
        Me.inpPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.inpPerempuan.TabIndex = 16
        Me.inpPerempuan.TabStop = True
        Me.inpPerempuan.Text = "Perempuan"
        Me.inpPerempuan.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Kategori"
        '
        'inpKategori
        '
        Me.inpKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inpKategori.FormattingEnabled = True
        Me.inpKategori.Location = New System.Drawing.Point(110, 163)
        Me.inpKategori.Name = "inpKategori"
        Me.inpKategori.Size = New System.Drawing.Size(264, 21)
        Me.inpKategori.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "NIP"
        '
        'inpNip
        '
        Me.inpNip.Location = New System.Drawing.Point(110, 29)
        Me.inpNip.Name = "inpNip"
        Me.inpNip.Size = New System.Drawing.Size(264, 20)
        Me.inpNip.TabIndex = 11
        '
        'inpNohp
        '
        Me.inpNohp.Location = New System.Drawing.Point(110, 207)
        Me.inpNohp.Name = "inpNohp"
        Me.inpNohp.Size = New System.Drawing.Size(264, 20)
        Me.inpNohp.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "No HP"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.inpNohp)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btn)
        Me.GroupBox1.Controls.Add(Me.inpKategori)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.inpPerempuan)
        Me.GroupBox1.Controls.Add(Me.inpLaki)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.inpNama)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.inpNip)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 313)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Karyawan"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(299, 265)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.KaryawanTab)
        Me.TabControl1.Controls.Add(Me.LaporanTab)
        Me.TabControl1.Controls.Add(Me.logoutTab)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1000, 483)
        Me.TabControl1.TabIndex = 22
        '
        'KaryawanTab
        '
        Me.KaryawanTab.Controls.Add(Me.Label11)
        Me.KaryawanTab.Controls.Add(Me.Button5)
        Me.KaryawanTab.Controls.Add(Me.inpSearch)
        Me.KaryawanTab.Controls.Add(Me.Panel1)
        Me.KaryawanTab.Controls.Add(Me.dataGrid)
        Me.KaryawanTab.Controls.Add(Me.GroupBox1)
        Me.KaryawanTab.Location = New System.Drawing.Point(4, 22)
        Me.KaryawanTab.Name = "KaryawanTab"
        Me.KaryawanTab.Padding = New System.Windows.Forms.Padding(3)
        Me.KaryawanTab.Size = New System.Drawing.Size(992, 457)
        Me.KaryawanTab.TabIndex = 0
        Me.KaryawanTab.Text = "Karyawan"
        Me.KaryawanTab.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(688, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Search"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(908, 123)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'inpSearch
        '
        Me.inpSearch.Location = New System.Drawing.Point(735, 126)
        Me.inpSearch.Name = "inpSearch"
        Me.inpSearch.Size = New System.Drawing.Size(167, 20)
        Me.inpSearch.TabIndex = 22
        '
        'LaporanTab
        '
        Me.LaporanTab.Controls.Add(Me.Label17)
        Me.LaporanTab.Controls.Add(Me.Label16)
        Me.LaporanTab.Controls.Add(Me.PictureBox2)
        Me.LaporanTab.Controls.Add(Me.Label15)
        Me.LaporanTab.Controls.Add(Me.Button6)
        Me.LaporanTab.Controls.Add(Me.Label14)
        Me.LaporanTab.Controls.Add(Me.DateTimePicker2)
        Me.LaporanTab.Controls.Add(Me.DateTimePicker1)
        Me.LaporanTab.Controls.Add(Me.DataGridView1)
        Me.LaporanTab.Controls.Add(Me.Panel2)
        Me.LaporanTab.Location = New System.Drawing.Point(4, 22)
        Me.LaporanTab.Name = "LaporanTab"
        Me.LaporanTab.Padding = New System.Windows.Forms.Padding(3)
        Me.LaporanTab.Size = New System.Drawing.Size(992, 457)
        Me.LaporanTab.TabIndex = 1
        Me.LaporanTab.Text = "Laporan"
        Me.LaporanTab.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(40, 391)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(332, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Pilih tanggal awal awal dan tanggal akhir untuk menampilkan laporan"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(57, 131)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(287, 222)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(521, 131)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Periode"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(907, 125)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Generate"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(739, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "-"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(755, 128)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(146, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(587, 128)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(146, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(429, 154)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(553, 277)
        Me.DataGridView1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(8, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(976, 78)
        Me.Panel2.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(13, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Laporan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(14, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Daftar laporan absensi karyawan"
        '
        'logoutTab
        '
        Me.logoutTab.Controls.Add(Me.Button3)
        Me.logoutTab.Controls.Add(Me.Label10)
        Me.logoutTab.Controls.Add(Me.Label9)
        Me.logoutTab.Controls.Add(Me.PictureBox1)
        Me.logoutTab.Location = New System.Drawing.Point(4, 22)
        Me.logoutTab.Name = "logoutTab"
        Me.logoutTab.Padding = New System.Windows.Forms.Padding(3)
        Me.logoutTab.Size = New System.Drawing.Size(992, 457)
        Me.logoutTab.TabIndex = 2
        Me.logoutTab.Text = "Logout"
        Me.logoutTab.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(451, 372)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(397, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Stay di sini aja ya jangan ningalin aku :("
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(422, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 24)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Apakah Yakin ?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(355, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(117, 356)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(152, 24)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Laporan Absensi"
        '
        'Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 479)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Karyawan"
        Me.Text = "Karyawan"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.KaryawanTab.ResumeLayout(False)
        Me.KaryawanTab.PerformLayout()
        Me.LaporanTab.ResumeLayout(False)
        Me.LaporanTab.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.logoutTab.ResumeLayout(False)
        Me.logoutTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents inpNama As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents inpLaki As System.Windows.Forms.RadioButton
    Friend WithEvents inpPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents inpKategori As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents inpNip As System.Windows.Forms.TextBox
    Friend WithEvents inpNohp As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents KaryawanTab As System.Windows.Forms.TabPage
    Friend WithEvents LaporanTab As System.Windows.Forms.TabPage
    Friend WithEvents logoutTab As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents inpSearch As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
