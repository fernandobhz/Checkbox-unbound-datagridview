Imports WindowsApplication1.DataSet1
Public Class Form1

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        MsgBox(Me.ClienteDataGridView.Rows(0).Cells("sel").Value)


        Dim dr As DataGridViewRow

        For Each dr In Me.ClienteDataGridView.Rows

            If dr.Cells(0).Value = True Then
                MsgBox("Linha " & dr.Index & " selecionada")
            End If
        Next
    End Sub
End Class

