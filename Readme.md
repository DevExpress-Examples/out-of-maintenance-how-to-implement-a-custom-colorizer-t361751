<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576937/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T361751)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


