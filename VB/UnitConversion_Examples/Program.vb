Imports Microsoft.VisualBasic
#Region "#usings"
Imports DevExpress.UnitConversion
Imports System.Diagnostics
#End Region ' #usings

Namespace UnitConversion_Examples
	Friend Class Program
		Shared Sub Main(ByVal args() As String)
'			#Region "#metricprefix"
			' The pressure value is set to 760 mmHg.
			Dim pressure As QuantityValue(Of Pressure) = (760).MmHg()
			' Since it is a quantity value, it should be transformed to a proper measurement unit
			' to obtain a value for display or for comparison.
			' The pressure is obtained in Pascals and then converted into hectoPascals.
			Dim prefixConverter As New MetricUnitsConverter()
			Dim pressure_in_hPa As Double = prefixConverter.Convert(pressure.ToPascals(), MetricPrefix.None, MetricPrefix.Hecto)
			Debug.WriteLine(pressure_in_hPa)
'			#End Region ' #metricprefix
		End Sub
	End Class
End Namespace
