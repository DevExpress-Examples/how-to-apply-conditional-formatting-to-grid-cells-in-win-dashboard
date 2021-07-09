Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors

Namespace Grid_FormatRules
	Partial Public Class ValueConditionForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			Dim dashboard As New Dashboard()
			dashboard.LoadFromXml("..\..\Data\Dashboard.xml")
			dashboardViewer1.Dashboard = dashboard
			Dim grid As GridDashboardItem = CType(dashboard.Items("gridDashboardItem1"), GridDashboardItem)
			Dim extendedPrice As GridMeasureColumn = CType(grid.Columns(1), GridMeasureColumn)

			Dim lessThanRule As New GridItemFormatRule(extendedPrice)
			Dim lessThanCondition As New FormatConditionValue()
			lessThanCondition.Condition = DashboardFormatCondition.LessOrEqual
			lessThanCondition.Value1 = 100000
			lessThanCondition.StyleSettings = New AppearanceSettings(FormatConditionAppearanceType.FontRed)
			lessThanRule.Condition = lessThanCondition

			Dim betweenRule As New GridItemFormatRule(extendedPrice)
			Dim betweenCondition As New FormatConditionValue()
			betweenCondition.Condition = DashboardFormatCondition.Between
			betweenCondition.Value1 = 100000
			betweenCondition.Value2 = 200000
			betweenCondition.StyleSettings = New AppearanceSettings(FormatConditionAppearanceType.FontYellow)
			betweenRule.Condition = betweenCondition

			Dim greaterThanRule As New GridItemFormatRule(extendedPrice)
			Dim greaterThanCondition As New FormatConditionValue()
			greaterThanCondition.Condition = DashboardFormatCondition.GreaterOrEqual
			greaterThanCondition.Value1 = 200000
			greaterThanCondition.StyleSettings = New AppearanceSettings(FormatConditionAppearanceType.FontGreen)
			greaterThanRule.Condition = greaterThanCondition

			grid.FormatRules.AddRange(lessThanRule, betweenRule, greaterThanRule)
		End Sub
	End Class
End Namespace
