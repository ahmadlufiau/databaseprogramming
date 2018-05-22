<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matakuliah
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.MskCari = New System.Windows.Forms.MaskedTextBox()
        Me.CmbCari = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtJT = New System.Windows.Forms.TextBox()
        Me.TxtSKS = New System.Windows.Forms.TextBox()
        Me.TxtNMK = New System.Windows.Forms.TextBox()
        Me.TxtKMK = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtJP = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("NewsGoth Cn BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(74, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(418, 39)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "FORM PENGISIAN DATA MATA KULIAH"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 265)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(556, 247)
        Me.DataGridView1.TabIndex = 86
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(448, 143)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(75, 23)
        Me.BtnCari.TabIndex = 84
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'MskCari
        '
        Me.MskCari.Location = New System.Drawing.Point(331, 117)
        Me.MskCari.Name = "MskCari"
        Me.MskCari.Size = New System.Drawing.Size(192, 20)
        Me.MskCari.TabIndex = 83
        '
        'CmbCari
        '
        Me.CmbCari.FormattingEnabled = True
        Me.CmbCari.Items.AddRange(New Object() {"Kode Mata Kuliah", "Nama Mata Kuliah"})
        Me.CmbCari.Location = New System.Drawing.Point(402, 89)
        Me.CmbCari.Name = "CmbCari"
        Me.CmbCari.Size = New System.Drawing.Size(121, 21)
        Me.CmbCari.TabIndex = 82
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(328, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Berdasarkan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(319, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 101)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(171, 153)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 79
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(93, 153)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 78
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(14, 153)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 77
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(44, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Jam Teori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(44, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "SKS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(44, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Nama Mata Kuliah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(44, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Kode Mata Kuliah"
        '
        'TxtJT
        '
        Me.TxtJT.Location = New System.Drawing.Point(138, 169)
        Me.TxtJT.Name = "TxtJT"
        Me.TxtJT.Size = New System.Drawing.Size(141, 20)
        Me.TxtJT.TabIndex = 72
        '
        'TxtSKS
        '
        Me.TxtSKS.Location = New System.Drawing.Point(138, 143)
        Me.TxtSKS.Name = "TxtSKS"
        Me.TxtSKS.Size = New System.Drawing.Size(141, 20)
        Me.TxtSKS.TabIndex = 71
        '
        'TxtNMK
        '
        Me.TxtNMK.Location = New System.Drawing.Point(138, 114)
        Me.TxtNMK.Name = "TxtNMK"
        Me.TxtNMK.Size = New System.Drawing.Size(141, 20)
        Me.TxtNMK.TabIndex = 70
        '
        'TxtKMK
        '
        Me.TxtKMK.Location = New System.Drawing.Point(138, 86)
        Me.TxtKMK.Name = "TxtKMK"
        Me.TxtKMK.Size = New System.Drawing.Size(141, 20)
        Me.TxtKMK.TabIndex = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtJP)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Controls.Add(Me.BtnUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 190)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Data Mata Kuliah"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(11, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Jam Praktek"
        '
        'TxtJP
        '
        Me.TxtJP.Location = New System.Drawing.Point(105, 127)
        Me.TxtJP.Name = "TxtJP"
        Me.TxtJP.Size = New System.Drawing.Size(141, 20)
        Me.TxtJP.TabIndex = 87
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(525, -1)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(56, 46)
        Me.BtnExit.TabIndex = 87
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Matakuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(580, 524)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.MskCari)
        Me.Controls.Add(Me.CmbCari)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtJT)
        Me.Controls.Add(Me.TxtSKS)
        Me.Controls.Add(Me.TxtNMK)
        Me.Controls.Add(Me.TxtKMK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Matakuliah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matakuliah"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnCari As Button
    Friend WithEvents MskCari As MaskedTextBox
    Friend WithEvents CmbCari As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtJT As TextBox
    Friend WithEvents TxtSKS As TextBox
    Friend WithEvents TxtNMK As TextBox
    Friend WithEvents TxtKMK As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtJP As TextBox
    Friend WithEvents BtnExit As Button
End Class
