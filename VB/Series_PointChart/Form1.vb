Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_PointChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim pointChart As New ChartControl()

			' Create a point series.
			Dim series1 As New Series("Series 1", ViewType.Point)

			' Set the numerical argument scale types for the series,
			' as it is qualitative, by default.
			series1.ArgumentScaleType = ScaleType.Numerical

			' Add points to it.
			series1.Points.Add(New SeriesPoint(1, 10))
			series1.Points.Add(New SeriesPoint(2, 22))
			series1.Points.Add(New SeriesPoint(3, 14))
			series1.Points.Add(New SeriesPoint(4, 27))
			series1.Points.Add(New SeriesPoint(5, 15))
			series1.Points.Add(New SeriesPoint(6, 28))
			series1.Points.Add(New SeriesPoint(7, 15))
			series1.Points.Add(New SeriesPoint(8, 33))

			' Add the series to the chart.
			pointChart.Series.Add(series1)

			' Access the view-type-specific options of the series.
			Dim myView1 As PointSeriesView = CType(series1.View, PointSeriesView)
			myView1.PointMarkerOptions.Kind = MarkerKind.Star
			myView1.PointMarkerOptions.StarPointCount = 5
			myView1.PointMarkerOptions.Size = 20

			' Access the type-specific options of the diagram.
			CType(pointChart.Diagram, XYDiagram).Rotated = True

			' Hide the legend (if necessary).
			pointChart.Legend.Visible = False

			' Add a title to the chart (if necessary).
			pointChart.Titles.Add(New ChartTitle())
			pointChart.Titles(0).Text = "A Point Chart"

			' Add the chart to the form.
			pointChart.Dock = DockStyle.Fill
			Me.Controls.Add(pointChart)

		End Sub
	End Class
End Namespace