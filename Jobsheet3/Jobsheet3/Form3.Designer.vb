<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.TxtUsia = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.mtbCari = New System.Windows.Forms.MaskedTextBox()
        Me.cmbCari = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Ibu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Ibu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Usia"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(97, 174)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 4
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(97, 199)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(143, 20)
        Me.TxtNama.TabIndex = 5
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(97, 223)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(177, 20)
        Me.TxtAlamat.TabIndex = 6
        '
        'TxtUsia
        '
        Me.TxtUsia.Location = New System.Drawing.Point(97, 249)
        Me.TxtUsia.Name = "TxtUsia"
        Me.TxtUsia.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsia.TabIndex = 7
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(25, 275)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 8
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 310)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(114, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(294, 25)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "FORM PENGISIAN DATA IBU"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(187, 275)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 80
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(106, 275)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 79
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.mtbCari)
        Me.GroupBox1.Controls.Add(Me.cmbCari)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 106)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Data"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(116, 71)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(100, 23)
        Me.btnCari.TabIndex = 52
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'mtbCari
        '
        Me.mtbCari.Location = New System.Drawing.Point(116, 45)
        Me.mtbCari.Name = "mtbCari"
        Me.mtbCari.Size = New System.Drawing.Size(239, 20)
        Me.mtbCari.TabIndex = 2
        '
        'cmbCari
        '
        Me.cmbCari.FormattingEnabled = True
        Me.cmbCari.Items.AddRange(New Object() {"Id Ibu", "Nama Ibu"})
        Me.cmbCari.Location = New System.Drawing.Point(116, 18)
        Me.cmbCari.Name = "cmbCari"
        Me.cmbCari.Size = New System.Drawing.Size(121, 21)
        Me.cmbCari.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Berdasarkan"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 479)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtUsia)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Data Ibu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents TxtUsia As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents mtbCari As MaskedTextBox
    Friend WithEvents cmbCari As ComboBox
    Friend WithEvents Label5 As Label
End Class
