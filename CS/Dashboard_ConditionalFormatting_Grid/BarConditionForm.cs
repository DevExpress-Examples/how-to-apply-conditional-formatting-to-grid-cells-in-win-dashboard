using DevExpress.DashboardCommon;

namespace Grid_FormatRules {
    public partial class BarConditionForm : DevExpress.XtraEditors.XtraForm {
        public BarConditionForm() {
            InitializeComponent();
            Dashboard dashboard = new Dashboard(); dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");
            dashboardViewer1.Dashboard = dashboard;
            GridDashboardItem grid = (GridDashboardItem)dashboard.Items["gridDashboardItem1"];
            GridMeasureColumn extendedPrice = (GridMeasureColumn)grid.Columns[1];

            GridItemFormatRule barRule = new GridItemFormatRule(extendedPrice);
            FormatConditionBar barCondition = new FormatConditionBar();
            barCondition.StyleSettings = new BarStyleSettings(FormatConditionAppearanceType.PaleBlue);
            barCondition.NegativeStyleSettings = new BarStyleSettings(FormatConditionAppearanceType.PaleRed);
            barCondition.BarOptions.AllowNegativeAxis = checkBox1.Checked;
            barCondition.BarOptions.DrawAxis = checkBox2.Checked;
            barRule.Condition = barCondition;

            grid.FormatRules.AddRange(barRule);
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            UpdateBarOptions();
        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e) {
            UpdateBarOptions();
        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e) {
            UpdateBarOptions();
        }

        private void UpdateBarOptions() {
            GridDashboardItem grid = (GridDashboardItem)dashboardViewer1.Dashboard.Items[0];
            FormatConditionBarOptions barOptions = ((FormatConditionBar)(grid.FormatRules[0]).Condition).BarOptions;
            barOptions.AllowNegativeAxis = checkBox1.Checked;
            barOptions.DrawAxis = checkBox2.Checked;
            barOptions.ShowBarOnly = checkBox3.Checked;
        }
    }
}
