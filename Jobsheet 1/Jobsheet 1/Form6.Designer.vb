﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Dim NIMLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim Tepat_LahirLabel As System.Windows.Forms.Label
        Dim Tanggal_LahirLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim No_HPLabel As System.Windows.Forms.Label
        Me.MahasiswaDataSet = New Jobsheet_1.MahasiswaDataSet()
        Me.DataPribadiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataPribadiTableAdapter = New Jobsheet_1.MahasiswaDataSetTableAdapters.DataPribadiTableAdapter()
        Me.TableAdapterManager = New Jobsheet_1.MahasiswaDataSetTableAdapters.TableAdapterManager()
        Me.DataPribadiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DataPribadiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NIMTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.Tepat_LahirTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_LahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.No_HPTextBox = New System.Windows.Forms.TextBox()
        Me.DataPribadiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NIMLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        Tepat_LahirLabel = New System.Windows.Forms.Label()
        Tanggal_LahirLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        No_HPLabel = New System.Windows.Forms.Label()
        CType(Me.MahasiswaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPribadiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPribadiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataPribadiBindingNavigator.SuspendLayout()
        CType(Me.DataPribadiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MahasiswaDataSet
        '
        Me.MahasiswaDataSet.DataSetName = "MahasiswaDataSet"
        Me.MahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataPribadiBindingSource
        '
        Me.DataPribadiBindingSource.DataMember = "DataPribadi"
        Me.DataPribadiBindingSource.DataSource = Me.MahasiswaDataSet
        '
        'DataPribadiTableAdapter
        '
        Me.DataPribadiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DataPribadiTableAdapter = Me.DataPribadiTableAdapter
        Me.TableAdapterManager.UpdateOrder = Jobsheet_1.MahasiswaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataPribadiBindingNavigator
        '
        Me.DataPribadiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DataPribadiBindingNavigator.BindingSource = Me.DataPribadiBindingSource
        Me.DataPribadiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DataPribadiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DataPribadiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DataPribadiBindingNavigatorSaveItem})
        Me.DataPribadiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DataPribadiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DataPribadiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DataPribadiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DataPribadiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DataPribadiBindingNavigator.Name = "DataPribadiBindingNavigator"
        Me.DataPribadiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DataPribadiBindingNavigator.Size = New System.Drawing.Size(673, 25)
        Me.DataPribadiBindingNavigator.TabIndex = 0
        Me.DataPribadiBindingNavigator.Text = "BindingNavigator1"
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
        'DataPribadiBindingNavigatorSaveItem
        '
        Me.DataPribadiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DataPribadiBindingNavigatorSaveItem.Image = CType(resources.GetObject("DataPribadiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DataPribadiBindingNavigatorSaveItem.Name = "DataPribadiBindingNavigatorSaveItem"
        Me.DataPribadiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DataPribadiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NIMLabel
        '
        NIMLabel.AutoSize = True
        NIMLabel.Location = New System.Drawing.Point(54, 50)
        NIMLabel.Name = "NIMLabel"
        NIMLabel.Size = New System.Drawing.Size(30, 13)
        NIMLabel.TabIndex = 1
        NIMLabel.Text = "NIM:"
        '
        'NIMTextBox
        '
        Me.NIMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataPribadiBindingSource, "NIM", True))
        Me.NIMTextBox.Location = New System.Drawing.Point(135, 47)
        Me.NIMTextBox.Name = "NIMTextBox"
        Me.NIMTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NIMTextBox.TabIndex = 2
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(54, 76)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 3
        NamaLabel.Text = "Nama:"
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataPribadiBindingSource, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(135, 73)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaTextBox.TabIndex = 4
        '
        'Tepat_LahirLabel
        '
        Tepat_LahirLabel.AutoSize = True
        Tepat_LahirLabel.Location = New System.Drawing.Point(54, 102)
        Tepat_LahirLabel.Name = "Tepat_LahirLabel"
        Tepat_LahirLabel.Size = New System.Drawing.Size(64, 13)
        Tepat_LahirLabel.TabIndex = 5
        Tepat_LahirLabel.Text = "Tepat Lahir:"
        '
        'Tepat_LahirTextBox
        '
        Me.Tepat_LahirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataPribadiBindingSource, "Tepat_Lahir", True))
        Me.Tepat_LahirTextBox.Location = New System.Drawing.Point(135, 99)
        Me.Tepat_LahirTextBox.Name = "Tepat_LahirTextBox"
        Me.Tepat_LahirTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tepat_LahirTextBox.TabIndex = 6
        '
        'Tanggal_LahirLabel
        '
        Tanggal_LahirLabel.AutoSize = True
        Tanggal_LahirLabel.Location = New System.Drawing.Point(54, 129)
        Tanggal_LahirLabel.Name = "Tanggal_LahirLabel"
        Tanggal_LahirLabel.Size = New System.Drawing.Size(75, 13)
        Tanggal_LahirLabel.TabIndex = 7
        Tanggal_LahirLabel.Text = "Tanggal Lahir:"
        '
        'Tanggal_LahirDateTimePicker
        '
        Me.Tanggal_LahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataPribadiBindingSource, "Tanggal_Lahir", True))
        Me.Tanggal_LahirDateTimePicker.Location = New System.Drawing.Point(135, 125)
        Me.Tanggal_LahirDateTimePicker.Name = "Tanggal_LahirDateTimePicker"
        Me.Tanggal_LahirDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tanggal_LahirDateTimePicker.TabIndex = 8
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(54, 154)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataPribadiBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(135, 151)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 10
        '
        'No_HPLabel
        '
        No_HPLabel.AutoSize = True
        No_HPLabel.Location = New System.Drawing.Point(54, 180)
        No_HPLabel.Name = "No_HPLabel"
        No_HPLabel.Size = New System.Drawing.Size(42, 13)
        No_HPLabel.TabIndex = 11
        No_HPLabel.Text = "No HP:"
        '
        'No_HPTextBox
        '
        Me.No_HPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataPribadiBindingSource, "No_HP", True))
        Me.No_HPTextBox.Location = New System.Drawing.Point(135, 177)
        Me.No_HPTextBox.Name = "No_HPTextBox"
        Me.No_HPTextBox.Size = New System.Drawing.Size(200, 20)
        Me.No_HPTextBox.TabIndex = 12
        '
        'DataPribadiDataGridView
        '
        Me.DataPribadiDataGridView.AutoGenerateColumns = False
        Me.DataPribadiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPribadiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataPribadiDataGridView.DataSource = Me.DataPribadiBindingSource
        Me.DataPribadiDataGridView.Location = New System.Drawing.Point(12, 203)
        Me.DataPribadiDataGridView.Name = "DataPribadiDataGridView"
        Me.DataPribadiDataGridView.Size = New System.Drawing.Size(649, 220)
        Me.DataPribadiDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIM"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tepat_Lahir"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tepat_Lahir"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tanggal_Lahir"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tanggal_Lahir"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "No_HP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "No_HP"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 428)
        Me.Controls.Add(Me.DataPribadiDataGridView)
        Me.Controls.Add(NIMLabel)
        Me.Controls.Add(Me.NIMTextBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(Tepat_LahirLabel)
        Me.Controls.Add(Me.Tepat_LahirTextBox)
        Me.Controls.Add(Tanggal_LahirLabel)
        Me.Controls.Add(Me.Tanggal_LahirDateTimePicker)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(No_HPLabel)
        Me.Controls.Add(Me.No_HPTextBox)
        Me.Controls.Add(Me.DataPribadiBindingNavigator)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.MahasiswaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPribadiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPribadiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataPribadiBindingNavigator.ResumeLayout(False)
        Me.DataPribadiBindingNavigator.PerformLayout()
        CType(Me.DataPribadiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MahasiswaDataSet As Jobsheet_1.MahasiswaDataSet
    Friend WithEvents DataPribadiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataPribadiTableAdapter As Jobsheet_1.MahasiswaDataSetTableAdapters.DataPribadiTableAdapter
    Friend WithEvents TableAdapterManager As Jobsheet_1.MahasiswaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataPribadiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DataPribadiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NIMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tepat_LahirTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_LahirDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_HPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataPribadiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
