Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.DashboardCommon

Namespace Grid_FormatRules
	Partial Public Class BarConditionForm
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
			Dim dashboard As New Dashboard()
			dashboard.LoadFromXml("..\..\Data\Dashboard.xml")
			dashboardViewer1.Dashboard = dashboard
			Dim grid As GridDashboardItem = CType(dashboard.Items("gridDashboardItem1"), GridDashboardItem)
			Dim extendedPrice As GridMeasureColumn = CType(grid.Columns(1), GridMeasureColumn)

			Dim barRule As New GridItemFormatRule(extendedPrice)
			Dim barCondition As New FormatConditionBar()
			barCondition.StyleSettings = New BarStyleSettings(FormatConditionAppearanceType.PaleBlue)
			barCondition.NegativeStyleSettings = New BarStyleSettings(FormatConditionAppearanceType.PaleRed)
			barCondition.BarOptions.AllowNegativeAxis = checkBox1.Checked
			barCondition.BarOptions.DrawAxis = checkBox2.Checked
			barRule.Condition = barCondition

			grid.FormatRules.AddRange(barRule)
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			UpdateBarOptions()
		End Sub

		Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
			UpdateBarOptions()
		End Sub

		Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
			UpdateBarOptions()
		End Sub

		Private Sub UpdateBarOptions()
			Dim grid As GridDashboardItem = CType(dashboardViewer1.Dashboard.Items(0), GridDashboardItem)
			Dim barOptions As FormatConditionBarOptions = (CType((grid.FormatRules(0)).Condition, FormatConditionBar)).BarOptions
			barOptions.AllowNegativeAxis = checkBox1.Checked
			barOptions.DrawAxis = checkBox2.Checked
			barOptions.ShowBarOnly = checkBox3.Checked
		End Sub
	End Class
End Namespace
