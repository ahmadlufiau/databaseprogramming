<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beasiswa
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
        Me.TxtKB = New System.Windows.Forms.TextBox()
        Me.TxtNB = New System.Windows.Forms.TextBox()
        Me.TxtIS = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.MskCari = New System.Windows.Forms.MaskedTextBox()
        Me.CmbCari = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtKB
        '
        Me.TxtKB.Location = New System.Drawing.Point(117, 81)
        Me.TxtKB.Name = "TxtKB"
        Me.TxtKB.Size = New System.Drawing.Size(141, 20)
        Me.TxtKB.TabIndex = 0
        '
        'TxtNB
        '
        Me.TxtNB.Location = New System.Drawing.Point(117, 109)
        Me.TxtNB.Name = "TxtNB"
        Me.TxtNB.Size = New System.Drawing.Size(141, 20)
        Me.TxtNB.TabIndex = 1
        '
        'TxtIS
        '
        Me.TxtIS.Location = New System.Drawing.Point(117, 138)
        Me.TxtIS.Name = "TxtIS"
        Me.TxtIS.Size = New System.Drawing.Size(141, 20)
        Me.TxtIS.TabIndex = 2
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(117, 164)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(141, 20)
        Me.TxtJumlah.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kode Beasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Beasiswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Institusi Sponsor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jumlah"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(26, 192)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 8
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(105, 192)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(183, 192)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 164)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Data Beasiswa"
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(427, 138)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(75, 23)
        Me.BtnCari.TabIndex = 64
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'MskCari
        '
        Me.MskCari.Location = New System.Drawing.Point(310, 112)
        Me.MskCari.Name = "MskCari"
        Me.MskCari.Size = New System.Drawing.Size(192, 20)
        Me.MskCari.TabIndex = 63
        '
        'CmbCari
        '
        Me.CmbCari.FormattingEnabled = True
        Me.CmbCari.Items.AddRange(New Object() {"Kode Beasiswa", "Nama Beasiswa"})
        Me.CmbCari.Location = New System.Drawing.Point(381, 84)
        Me.CmbCari.Name = "CmbCari"
        Me.CmbCari.Size = New System.Drawing.Size(121, 21)
        Me.CmbCari.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(307, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Berdasarkan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(298, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 101)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 247)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(508, 150)
        Me.DataGridView1.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(369, 25)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "FORM PENGISIAN DATA BEASISWA"
        '
        'Beasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 403)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.MskCari)
        Me.Controls.Add(Me.CmbCari)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.TxtIS)
        Me.Controls.Add(Me.TxtNB)
        Me.Controls.Add(Me.TxtKB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Beasiswa"
        Me.Text = "Beasiswa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtKB As TextBox
    Friend WithEvents TxtNB As TextBox
    Friend WithEvents TxtIS As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCari As Button
    Friend WithEvents MskCari As MaskedTextBox
    Friend WithEvents CmbCari As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
End Class
