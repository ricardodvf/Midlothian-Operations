Imports System.Xml
Imports System.Security.Cryptography
Imports System.Text
Module Module1
    Public Function OpenXML(XMLFile As String, XMLNodes As String) As DataSet
        Dim xmlFileR As XmlReader = XmlReader.Create(XMLFile, New XmlReaderSettings())
        Dim ds As New DataSet
        ds.ReadXml(XMLFile)
        Return ds
    End Function



    Public Function HashSHA256(Value As String) As String
        '"Encrypts" a string
        Dim shaM As SHA256Managed = SHA256.Create()
        Convert.ToBase64String(shaM.ComputeHash(Encoding.ASCII.GetBytes(Value)))
        Dim eNC_data() As Byte = ASCIIEncoding.ASCII.GetBytes(Value)
        Dim eNC_str As String = Convert.ToBase64String(eNC_data)
        Return eNC_str

    End Function

    Public Function DecryptHSA256(ByVal Data As String) As String
        '"Decrypts" a string
        Try
            Dim dEC_data() As Byte = Convert.FromBase64String(Data)
            Dim dEC_Str As String = ASCIIEncoding.ASCII.GetString(dEC_data)
            Return dEC_Str
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Module
