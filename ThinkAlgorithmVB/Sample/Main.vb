Namespace Sample
    Friend Class Main
        Public ReadOnly Property HeaderA As A

        Public ReadOnly Property HeaderB As B

        Public ReadOnly Property DataD As IReadOnlyList(Of D)

        Friend Sub New(headerA As A, headerB As B, dataD As IReadOnlyList(Of D))
            Me.HeaderA = headerA
            Me.HeaderB = headerB
            Me.DataD = dataD
        End Sub
    End Class
End Namespace
