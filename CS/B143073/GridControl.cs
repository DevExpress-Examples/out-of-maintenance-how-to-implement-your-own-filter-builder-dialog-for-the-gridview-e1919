using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.FilterEditor;
using DevExpress.XtraEditors.Filtering;
using DevExpress.Utils.Menu;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace DXSample {
    public class MyGridControl : GridControl {
        public MyGridControl() : base() { }

        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }

    public class MyGridView : GridView {
        public MyGridView() : base() { }
        public MyGridView(GridControl grid) : base(grid) { }

        internal const string MyGridViewName = "MyGridView";
        protected override string ViewName { get { return MyGridViewName; } }

        protected override Form CreateFilterBuilderDialog(FilterColumnCollection filterColumns, 
            FilterColumn defaultFilterColumn) {
            return new MyFilterBuilder(filterColumns, GridControl.MenuManager, GridControl.LookAndFeel, this, 
                defaultFilterColumn);
        }
    }

    public class MyGridViewInfoRegistrator : GridInfoRegistrator {
        public MyGridViewInfoRegistrator() : base() { }

        public override string ViewName { get { return MyGridView.MyGridViewName; } }

        public override BaseView CreateView(GridControl grid) {
            return new MyGridView(grid);
        }
    }

    public class MyFilterBuilder : FilterBuilder {
        public MyFilterBuilder(FilterColumnCollection columns, IDXMenuManager manager, UserLookAndFeel lookAndFeel, 
            ColumnView view, FilterColumn fColumn) 
            : base(columns, manager, lookAndFeel, view, fColumn) {
            sbOK.Enabled = sbApply.Enabled = false;
            ((FilterControl)fcMain).FilterChanged += 
                new FilterChangedEventHandler(OnFilterControlFilterChanged);
        }

        private void OnFilterControlFilterChanged(object sender, FilterChangedEventArgs e) {
            sbOK.Enabled = sbApply.Enabled = true;
            ((FilterControl)fcMain).FilterChanged -= new FilterChangedEventHandler(OnFilterControlFilterChanged);
        }
    }
}