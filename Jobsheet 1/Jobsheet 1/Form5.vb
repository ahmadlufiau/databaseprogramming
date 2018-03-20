Public Class Form5

    Private Sub AlatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.alat' table. You can move, or remove it, as needed.
        Me.AlatTableAdapter.Fill(Me.DataSet1.alat)

    End Sub
End Class