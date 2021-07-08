using DevExpress.DashboardCommon;
using DevExpress.XtraEditors;

namespace Grid_FormatRules {
    public partial class DateOccurringForm : XtraForm {
        public DateOccurringForm() {
            InitializeComponent();
            dashboardViewer1.AsyncDataLoading += OnDashboardViewerAsyncDataLoading;
            dashboardViewer1.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.LoadAsIs;

            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(@"..\..\Data\DashboardDate.xml");
            dashboardViewer1.Dashboard = dashboard;
            GridDashboardItem grid = (GridDashboardItem)dashboard.Items["gridDashboardItem1"];
            GridDimensionColumn date = (GridDimensionColumn)grid.Columns[0];

            GridItemFormatRule dateOccurringRule = new GridItemFormatRule(date);
            FormatConditionDateOccurring dateOccurringCondition = new FormatConditionDateOccurring();
            dateOccurringCondition.DateType = FilterDateType.MonthAgo1 | FilterDateType.MonthAgo2;
            dateOccurringCondition.StyleSettings = 
                new AppearanceSettings(FormatConditionAppearanceType.PaleOrange);
            dateOccurringRule.Condition = dateOccurringCondition;
            dateOccurringRule.ApplyToRow = true;

            grid.FormatRules.Add(dateOccurringRule);            
        }
        void OnDashboardViewerAsyncDataLoading(object sender, DataLoadingEventArgs e) {
            e.Data = DataGenerator.CreateData();
        }
    }
}
