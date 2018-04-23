# How to implement your own Filter Builder dialog for the GridView


<p>This example demonstrates how to add an additional functionality to the standard Filter Builder dialog. For example, disable the "OK" and "Apply" buttons until the user modifies the filter criteria.</p>


<h3>Description</h3>

<p>To implement a custom Filter Builder dialog, you can either create your own dialog window from scratch, or inherit the DevExpress.XtraGrid.FilterEditor.FilterBuilder class and modify its functionality. Then, you need to create a GridView descendant, and override its CreateFilterBuilderDialog method to return your own dialog form.</p><p><strong>See Also:</strong> <a data-ticket="A859">How to create a GridView descendant class and register it for design-time use</a><br />
<strong>See Also:</strong> <a data-ticket="E900">How to create a GridView descendant class and register it for design-time use</a> (example)</p>

<br/>


