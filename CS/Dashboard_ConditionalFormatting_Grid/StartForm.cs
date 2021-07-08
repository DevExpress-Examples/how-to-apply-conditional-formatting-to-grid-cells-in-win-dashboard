using System;
using System.Windows.Forms;

namespace Grid_FormatRules {
    public partial class StartForm : Form {
        public StartForm() {
            InitializeComponent();
            listBoxControl1.Items.AddEnum<CFRules>();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            CFRules demo = (CFRules)listBoxControl1.SelectedItem;
            switch(demo) {
                case CFRules.BarColorRanges:
                    new RangeColorBarConditionForm().ShowDialog();
                    break;
                case CFRules.BarGradientRanges:
                    new RangeGradientBarConditionForm().ShowDialog();
                    break;
                case CFRules.BarFormat:
                    new BarConditionForm().ShowDialog();
                    break;
                case CFRules.ValueFormat:
                    new ValueConditionForm().ShowDialog();
                    break;
                case CFRules.TopBottomAverage:
                    new TopAverageConditionForm().ShowDialog();
                    break;
                case CFRules.IconRanges:
                    new IconRangeConditionForm().ShowDialog();
                    break;
                case CFRules.GradientRanges:
                    new GradientRangeConditionForm().ShowDialog();
                    break;
                case CFRules.DateOccuring:
                    new DateOccurringForm().ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void listBoxControl1_DoubleClick(object sender, EventArgs e) {
            simpleButton1_Click(listBoxControl1, e);
        }
    }

    public enum CFRules { 
        ValueFormat,
        TopBottomAverage,
        IconRanges,
        GradientRanges,
        DateOccuring,
        BarFormat,
        BarColorRanges,
        BarGradientRanges
    }
}
