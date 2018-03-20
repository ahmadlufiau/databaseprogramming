Public Class Form6

    Private Sub DataPribadiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPribadiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DataPribadiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MahasiswaDataSet)

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MahasiswaDataSet.DataPribadi' table. You can move, or remove it, as needed.
        Me.DataPribadiTableAdapter.Fill(Me.MahasiswaDataSet.DataPribadi)

    End Sub
End Class