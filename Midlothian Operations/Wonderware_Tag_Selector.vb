Imports System.Xml


Public Class Wonderware_Tag_Selector

    Dim ds As New DataSet
    Private Sub Wonderware_Tag_Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Dim xmlFile As XmlReader = XmlReader.Create("WonderWareTags.xml", New XmlReaderSettings())


        Try
            ds.ReadXml(xmlFile)

            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 300


        Catch ex As Exception

        End Try
        Try
            xmlFile.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        ds.Tables(0).DefaultView.RowFilter = String.Format("TAGNAME LIKE '%{0}%' AND TAGDESCRIPTION LIKE '%{1}%'", TextBox1.Text, TextBox2.Text)
        DataGridView1.Refresh()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ds.Tables(0).DefaultView.RowFilter = String.Format("TAGNAME LIKE '%{0}%' AND TAGDESCRIPTION LIKE '%{1}%'", TextBox1.Text, TextBox2.Text)
        DataGridView1.Refresh()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Call SetAndClose()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Call SetAndClose()
    End Sub

    Public Sub SetAndClose()

        DirectCast(Me.Owner, ChartBuilder).TextBox1.Text = DataGridView1.SelectedCells(0).Value.ToString
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class