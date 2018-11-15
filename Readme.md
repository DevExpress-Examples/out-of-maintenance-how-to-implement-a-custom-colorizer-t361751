<!-- default file list -->
*Files to look at*:

* [BillionaireInfo.cs](./CS/CustomColorizerSample/BillionaireInfo.cs) (VB: [BillionaireInfo.vb](./VB/CustomColorizerSample/BillionaireInfo.vb))
* **[CustomColorizer.cs](./CS/CustomColorizerSample/CustomColorizer.cs) (VB: [CustomColorizer.vb](./VB/CustomColorizerSample/CustomColorizer.vb))**
* [Form1.cs](./CS/CustomColorizerSample/Form1.cs) (VB: [Form1.vb](./VB/CustomColorizerSample/Form1.vb))
<!-- default file list end -->
# How to: Implement a custom colorizer


This example demonstrates how to implement a custom colorizer that can be used to color a TreeMap.


<h3>Description</h3>

<p>To do this, design a class implementing the&nbsp;<strong>ITreeMapColorizer</strong>&nbsp;interface and implement the interface&nbsp;<strong>GetItemColor&nbsp;</strong>method. After that, an instance of the class can be assigned to the&nbsp;<strong>TreeMapControl.Colorizer</strong>&nbsp;property.</p>

<br/>


