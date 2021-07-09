Imports System
Imports System.Windows.Forms

Namespace Grid_FormatRules
	Partial Public Class StartForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
			listBoxControl1.Items.AddEnum(Of CFRules)()
		End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            OpenForm()
        End Sub

        Private Sub OpenForm()
            Dim demo As CFRules = CType(listBoxControl1.SelectedItem, CFRules)
            Select Case demo
                Case CFRules.BarColorRanges
                    CType(New RangeColorBarConditionForm(), RangeColorBarConditionForm).ShowDialog()
                Case CFRules.BarGradientRanges
                    CType(New RangeGradientBarConditionForm(), RangeGradientBarConditionForm).ShowDialog()
                Case CFRules.BarFormat
                    CType(New BarConditionForm(), BarConditionForm).ShowDialog()
                Case CFRules.ValueFormat
                    CType(New ValueConditionForm(), ValueConditionForm).ShowDialog()
                Case CFRules.TopBottomAverage
                    CType(New TopAverageConditionForm(), TopAverageConditionForm).ShowDialog()
                Case CFRules.IconRanges
                    CType(New IconRangeConditionForm(), IconRangeConditionForm).ShowDialog()
                Case CFRules.GradientRanges
                    CType(New GradientRangeConditionForm(), GradientRangeConditionForm).ShowDialog()
                Case CFRules.DateOccuring
                    CType(New DateOccurringForm(), DateOccurringForm).ShowDialog()
                Case Else
            End Select
        End Sub

        Private Sub listBoxControl1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl1.DoubleClick
            OpenForm()
        End Sub
    End Class

	Public Enum CFRules
		ValueFormat
		TopBottomAverage
		IconRanges
		GradientRanges
		DateOccuring
		BarFormat
		BarColorRanges
		BarGradientRanges
	End Enum
End Namespace
