Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.FilterEditor
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.Utils.Menu
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Namespace DXSample
	Public Class MyGridControl
		Inherits GridControl
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridViewInfoRegistrator())
		End Sub
	End Class

	Public Class MyGridView
		Inherits GridView
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub

		Friend Const MyGridViewName As String = "MyGridView"
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return MyGridViewName
			End Get
		End Property

		Protected Overrides Function CreateFilterBuilderDialog(ByVal filterColumns As FilterColumnCollection, ByVal defaultFilterColumn As FilterColumn) As Form
			Return New MyFilterBuilder(filterColumns, GridControl.MenuManager, GridControl.LookAndFeel, Me, defaultFilterColumn)
		End Function
	End Class

	Public Class MyGridViewInfoRegistrator
		Inherits GridInfoRegistrator
		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return MyGridView.MyGridViewName
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyGridView(grid)
		End Function
	End Class

	Public Class MyFilterBuilder
		Inherits FilterBuilder
		Public Sub New(ByVal columns As FilterColumnCollection, ByVal manager As IDXMenuManager, ByVal lookAndFeel As UserLookAndFeel, ByVal view As ColumnView, ByVal fColumn As FilterColumn)
			MyBase.New(columns, manager, lookAndFeel, view, fColumn)
			sbApply.Enabled = False
			sbOK.Enabled = sbApply.Enabled
			AddHandler (CType(fcMain, FilterControl)).FilterChanged, AddressOf OnFilterControlFilterChanged
		End Sub

		Private Sub OnFilterControlFilterChanged(ByVal sender As Object, ByVal e As FilterChangedEventArgs)
			sbApply.Enabled = True
			sbOK.Enabled = sbApply.Enabled
			RemoveHandler (CType(fcMain, FilterControl)).FilterChanged, AddressOf OnFilterControlFilterChanged
		End Sub
	End Class
End Namespace