Module ImageSetup
    Public Function BytesToImage(ByVal ImageBytes() As Byte) As Image
        Dim imgNew As Image
        Dim memImage As New System.IO.MemoryStream(ImageBytes)
        imgNew = Image.FromStream(memImage)
        Return imgNew
    End Function

    Public Function ImageToBytes(ByVal Image As Image) As Byte()
        Dim memImage As New System.IO.MemoryStream
        Dim bytImage() As Byte
        Image.Save(memImage, Image.RawFormat)
        bytImage = memImage.GetBuffer()
        Return bytImage
    End Function
End Module
