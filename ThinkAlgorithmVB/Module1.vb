Imports ThinkAlgorithmVB.Sample

Module Module1

    Sub Main()
        Dim data As Main = New Main(
            New A(1, 3, 3, 4, 5),
            New B(1.0, "A", 2),
            New List(Of D)() From {
            New D(New List(Of E)() From {
            New E(123.4, 12.0, 0.0, 1, 1, 17, 12),
            New E(123.4, 12.0, 0.0, 12, 0, 13, 52),
            New E(123.4, 12.0, 0.0, 11, 2, 1, 12)}),
            New D(New List(Of E)() From {
            New E(123.4, 12.0, 0.0, 1, 2, 21, 52)}),
            New D(New List(Of E)() From {
            New E(123.4, 12.0, 0.0, 1, 1, 11, 50),
            New E(123.4, 12.0, 0.0, 12, 1, 35, 70)})})
    End Sub

End Module