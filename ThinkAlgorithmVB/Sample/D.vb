Namespace Sample
	Friend Class D
		Public ReadOnly Property Es As IReadOnlyList(Of E)
		Friend Sub New(es As IReadOnlyList(Of E))
			Me.Es = es
		End Sub
	End Class
End Namespace
