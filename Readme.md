<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1919)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [GridControl.cs](./CS/B143073/GridControl.cs) (VB: [GridControl.vb](./VB/B143073/GridControl.vb))
<!-- default file list end -->
# How to implement your own Filter Builder dialog for the GridView


<p>This example demonstrates how to add an additional functionality to the standard Filter Builder dialog. For example, disable the "OK" and "Apply" buttons until the user modifies the filter criteria.</p>


<h3>Description</h3>

<p>To implement a custom Filter Builder dialog, you can either create your own dialog window from scratch, or inherit the DevExpress.XtraGrid.FilterEditor.FilterBuilder class and modify its functionality. Then, you need to create a GridView descendant, and override its CreateFilterBuilderDialog method to return your own dialog form.</p><p><strong>See Also:</strong> <a data-ticket="A859">How to create a GridView descendant class and register it for design-time use</a><br />
<strong>See Also:</strong> <a data-ticket="E900">How to create a GridView descendant class and register it for design-time use</a> (example)</p>

<br/>


