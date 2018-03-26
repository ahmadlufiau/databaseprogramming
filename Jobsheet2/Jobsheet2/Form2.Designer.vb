<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnUrl = New System.Windows.Forms.Button()
        Me.TxtUrl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUrl
        '
        Me.btnUrl.Location = New System.Drawing.Point(277, 74)
        Me.btnUrl.Name = "btnUrl"
        Me.btnUrl.Size = New System.Drawing.Size(59, 23)
        Me.btnUrl.TabIndex = 42
        Me.btnUrl.Text = "OK"
        Me.btnUrl.UseVisualStyleBackColor = True
        '
        'TxtUrl
        '
        Me.TxtUrl.Location = New System.Drawing.Point(86, 77)
        Me.TxtUrl.Name = "TxtUrl"
        Me.TxtUrl.Size = New System.Drawing.Size(176, 20)
        Me.TxtUrl.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "URL"
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(277, 35)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(59, 23)
        Me.btnEmail.TabIndex = 39
        Me.btnEmail.Text = "OK"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(86, 38)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(176, 20)
        Me.TxtEmail.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Email"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 132)
        Me.Controls.Add(Me.btnUrl)
        Me.Controls.Add(Me.TxtUrl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label10)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUrl As Button
    Friend WithEvents TxtUrl As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEmail As Button
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label10 As Label
End Class
