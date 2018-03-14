<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KoneksiDatabase
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
        Me.BtnTampil = New System.Windows.Forms.Button()
        Me.BtnBersih = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTampil
        '
        Me.BtnTampil.Location = New System.Drawing.Point(13, 13)
        Me.BtnTampil.Name = "BtnTampil"
        Me.BtnTampil.Size = New System.Drawing.Size(75, 35)
        Me.BtnTampil.TabIndex = 0
        Me.BtnTampil.Text = "Tampil"
        Me.BtnTampil.UseVisualStyleBackColor = True
        '
        'BtnBersih
        '
        Me.BtnBersih.Location = New System.Drawing.Point(94, 13)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(75, 35)
        Me.BtnBersih.TabIndex = 1
        Me.BtnBersih.Text = "Bersih"
        Me.BtnBersih.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 216)
        Me.DataGridView1.TabIndex = 2
        '
        'KoneksiDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 292)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.BtnTampil)
        Me.Name = "KoneksiDatabase"
        Me.Text = "Data Pribadi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnTampil As Button
    Friend WithEvents BtnBersih As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
