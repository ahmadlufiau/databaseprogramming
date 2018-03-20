Public Class Formke3
    Private Sub DataPribadiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DataPribadiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Formke3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MahasiswaDataSet.DataPribadi' table. You can move, or remove it, as needed.
        Me.DataPribadiTableAdapter.Fill(Me.MahasiswaDataSet.DataPribadi)
        'TODO: This line of code loads data into the 'DataSet1.DataPribadi' table. You can move, or remove it, as needed.
        Me.DataPribadiTableAdapter.Fill(Me.DataSet1.DataPribadi)

    End Sub

    Private Sub DataPribadiBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles DataPribadiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DataPribadiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MahasiswaDataSet)

    End Sub
End Class