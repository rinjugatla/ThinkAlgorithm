Namespace Sample
	Friend Class B
		Public ReadOnly Property Data1 As Double
		Public ReadOnly Property Data2 As String
		Public ReadOnly Property Data3 As Integer

		Friend Sub New(d1 As Double, d2 As String, d3 As Integer)
			Me.Data1 = d1
			Me.Data2 = d2
			Me.Data3 = d3
		End Sub
	End Class
End Namespace