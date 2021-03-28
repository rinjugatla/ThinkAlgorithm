Namespace Sample
	Friend Class A
		Public ReadOnly Property Data1 As Integer

		Public ReadOnly Property Data2 As Integer

		Public ReadOnly Property Data3 As Integer

		Public ReadOnly Property Data4 As Integer

		Public ReadOnly Property Data5 As Integer

		Friend Sub New(d1 As Integer, d2 As Integer, d3 As Integer, d4 As Integer, d5 As Integer)
			Me.Data1 = d1
			Me.Data2 = d2
			Me.Data3 = d3
			Me.Data4 = d4
			Me.Data5 = d5
		End Sub
	End Class
End Namespace
