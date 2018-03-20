<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim KodeLabel As System.Windows.Forms.Label
        Dim NamaAlatLabel As System.Windows.Forms.Label
        Dim MerkLabel As System.Windows.Forms.Label
        Dim LokasiLabel As System.Windows.Forms.Label
        Me.DataSet1 = New Jobsheet_1.DataSet1()
        Me.AlatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlatTableAdapter = New Jobsheet_1.DataSet1TableAdapters.alatTableAdapter()
        Me.TableAdapterManager = New Jobsheet_1.DataSet1TableAdapters.TableAdapterManager()
        Me.AlatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AlatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.KodeTextBox = New System.Windows.Forms.TextBox()
        Me.NamaAlatTextBox = New System.Windows.Forms.TextBox()
        Me.MerkTextBox = New System.Windows.Forms.TextBox()
        Me.LokasiTextBox = New System.Windows.Forms.TextBox()
        Me.AlatDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        KodeLabel = New System.Windows.Forms.Label()
        NamaAlatLabel = New System.Windows.Forms.Label()
        MerkLabel = New System.Windows.Forms.Label()
        LokasiLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlatBindingNavigator.SuspendLayout()
        CType(Me.AlatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlatBindingSource
        '
        Me.AlatBindingSource.DataMember = "alat"
        Me.AlatBindingSource.DataSource = Me.DataSet1
        '
        'AlatTableAdapter
        '
        Me.AlatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alatTableAdapter = Me.AlatTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Jobsheet_1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlatBindingNavigator
        '
        Me.AlatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AlatBindingNavigator.BindingSource = Me.AlatBindingSource
        Me.AlatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AlatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AlatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AlatBindingNavigatorSaveItem})
        Me.AlatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AlatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AlatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AlatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AlatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AlatBindingNavigator.Name = "AlatBindingNavigator"
        Me.AlatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AlatBindingNavigator.Size = New System.Drawing.Size(524, 25)
        Me.AlatBindingNavigator.TabIndex = 0
        Me.AlatBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'AlatBindingNavigatorSaveItem
        '
        Me.AlatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlatBindingNavigatorSaveItem.Image = CType(resources.GetObject("AlatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AlatBindingNavigatorSaveItem.Name = "AlatBindingNavigatorSaveItem"
        Me.AlatBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AlatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KodeLabel
        '
        KodeLabel.AutoSize = True
        KodeLabel.Location = New System.Drawing.Point(43, 45)
        KodeLabel.Name = "KodeLabel"
        KodeLabel.Size = New System.Drawing.Size(35, 13)
        KodeLabel.TabIndex = 1
        KodeLabel.Text = "Kode:"
        '
        'KodeTextBox
        '
        Me.KodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlatBindingSource, "Kode", True))
        Me.KodeTextBox.Location = New System.Drawing.Point(108, 42)
        Me.KodeTextBox.Name = "KodeTextBox"
        Me.KodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KodeTextBox.TabIndex = 2
        '
        'NamaAlatLabel
        '
        NamaAlatLabel.AutoSize = True
        NamaAlatLabel.Location = New System.Drawing.Point(43, 71)
        NamaAlatLabel.Name = "NamaAlatLabel"
        NamaAlatLabel.Size = New System.Drawing.Size(59, 13)
        NamaAlatLabel.TabIndex = 3
        NamaAlatLabel.Text = "Nama Alat:"
        '
        'NamaAlatTextBox
        '
        Me.NamaAlatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlatBindingSource, "NamaAlat", True))
        Me.NamaAlatTextBox.Location = New System.Drawing.Point(108, 68)
        Me.NamaAlatTextBox.Name = "NamaAlatTextBox"
        Me.NamaAlatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NamaAlatTextBox.TabIndex = 4
        '
        'MerkLabel
        '
        MerkLabel.AutoSize = True
        MerkLabel.Location = New System.Drawing.Point(43, 97)
        MerkLabel.Name = "MerkLabel"
        MerkLabel.Size = New System.Drawing.Size(34, 13)
        MerkLabel.TabIndex = 5
        MerkLabel.Text = "Merk:"
        '
        'MerkTextBox
        '
        Me.MerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlatBindingSource, "Merk", True))
        Me.MerkTextBox.Location = New System.Drawing.Point(108, 94)
        Me.MerkTextBox.Name = "MerkTextBox"
        Me.MerkTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MerkTextBox.TabIndex = 6
        '
        'LokasiLabel
        '
        LokasiLabel.AutoSize = True
        LokasiLabel.Location = New System.Drawing.Point(43, 123)
        LokasiLabel.Name = "LokasiLabel"
        LokasiLabel.Size = New System.Drawing.Size(41, 13)
        LokasiLabel.TabIndex = 7
        LokasiLabel.Text = "Lokasi:"
        '
        'LokasiTextBox
        '
        Me.LokasiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlatBindingSource, "Lokasi", True))
        Me.LokasiTextBox.Location = New System.Drawing.Point(108, 120)
        Me.LokasiTextBox.Name = "LokasiTextBox"
        Me.LokasiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LokasiTextBox.TabIndex = 8
        '
        'AlatDataGridView
        '
        Me.AlatDataGridView.AutoGenerateColumns = False
        Me.AlatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AlatDataGridView.DataSource = Me.AlatBindingSource
        Me.AlatDataGridView.Location = New System.Drawing.Point(46, 164)
        Me.AlatDataGridView.Name = "AlatDataGridView"
        Me.AlatDataGridView.Size = New System.Drawing.Size(447, 181)
        Me.AlatDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Kode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NamaAlat"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NamaAlat"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Merk"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Merk"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Lokasi"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lokasi"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 357)
        Me.Controls.Add(Me.AlatDataGridView)
        Me.Controls.Add(KodeLabel)
        Me.Controls.Add(Me.KodeTextBox)
        Me.Controls.Add(NamaAlatLabel)
        Me.Controls.Add(Me.NamaAlatTextBox)
        Me.Controls.Add(MerkLabel)
        Me.Controls.Add(Me.MerkTextBox)
        Me.Controls.Add(LokasiLabel)
        Me.Controls.Add(Me.LokasiTextBox)
        Me.Controls.Add(Me.AlatBindingNavigator)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlatBindingNavigator.ResumeLayout(False)
        Me.AlatBindingNavigator.PerformLayout()
        CType(Me.AlatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As Jobsheet_1.DataSet1
    Friend WithEvents AlatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlatTableAdapter As Jobsheet_1.DataSet1TableAdapters.alatTableAdapter
    Friend WithEvents TableAdapterManager As Jobsheet_1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AlatBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AlatBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents KodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaAlatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MerkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LokasiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlatDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
