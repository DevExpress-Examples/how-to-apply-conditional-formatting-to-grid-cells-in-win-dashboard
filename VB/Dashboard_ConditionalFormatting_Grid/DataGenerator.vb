Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Threading

Namespace Grid_FormatRules
	Public Class DataGenerator
		Private privateDate As DateTime
		Public Property [Date]() As DateTime
			Get
				Return privateDate
			End Get
			Set(ByVal value As DateTime)
				privateDate = value
			End Set
		End Property
		Private privateSales As Decimal
		Public Property Sales() As Decimal
			Get
				Return privateSales
			End Get
			Set(ByVal value As Decimal)
				privateSales = value
			End Set
		End Property

		Public Shared Function CreateData() As List(Of DataGenerator)
			Dim data As New List(Of DataGenerator)()

			For i As Integer = 0 To 99
				Dim record As New DataGenerator()
				Dim startDate As New DateTime(DateTime.Today.Year, 1, 1)
				Dim rand As New Random()
				Dim range As Integer = (DateTime.Today.Subtract(startDate)).Days

				record.Sales = New Random(Guid.NewGuid().GetHashCode()).Next(0, 1000)
				record.Date = startDate.AddDays(rand.Next(range))
				data.Add(record)
				Thread.Sleep(3)
			Next i
			Return data
		End Function
	End Class
End Namespace
