Namespace Sample
	Friend Class E
		Public ReadOnly Property X As Double
		Public ReadOnly Property Y As Double
		Public ReadOnly Property Z As Double
		Public ReadOnly Property Data1 As Integer
		Public ReadOnly Property Data2 As Integer
		Public ReadOnly Property Data3 As Integer
		Public ReadOnly Property Data4 As Integer

		Friend Sub New(x As Double, y As Double, z As Double, d1 As Integer, d2 As Integer, d3 As Integer, d4 As Integer)
			Me.X = x
			Me.Y = y
			Me.Z = z
			Me.Data1 = d1
			Me.Data2 = d2
			Me.Data3 = d3
			Me.Data4 = d4
		End Sub
	End Class
End Namespace
