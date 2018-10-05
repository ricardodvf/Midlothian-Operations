Imports DevExpress.XtraEditors

Public Class LDMSTagSelector

    Public Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim TAG As String = String.Format("{0}-{1}-{2}-{3}", ListBoxControl1.SelectedItem, ListBoxControl2.SelectedItem, ListBoxControl4.SelectedItem, ListBoxControl3.SelectedItem)
        DirectCast(Me.Owner, ChartBuilder).TextBox1.Text = TAG
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub



End Class