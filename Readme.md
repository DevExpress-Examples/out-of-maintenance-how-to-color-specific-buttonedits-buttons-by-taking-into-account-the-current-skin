<!-- default file list -->
*Files to look at*:

* [CustomButtonEdit.cs](./CS/dxCustomButtonEdit/CustomButtonEdit.cs) (VB: [CustomButtonEdit.vb](./VB/dxCustomButtonEdit/CustomButtonEdit.vb))
* [Form1.cs](./CS/dxCustomButtonEdit/Form1.cs) (VB: [Form1.vb](./VB/dxCustomButtonEdit/Form1.vb))
* [Program.cs](./CS/dxCustomButtonEdit/Program.cs) (VB: [Program.vb](./VB/dxCustomButtonEdit/Program.vb))
<!-- default file list end -->
# How to color specific ButtonEdit's buttons by taking into account the current skin


<p>This example demonstrates how to color a specific ButtonEdit's button using the SkinMaskColor property by taking into account the current skin. The main idea is to create a ButtonEdit descendant as described in the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument4716">Custom Editors</a> help article. Then, override the ButtonEditPainter.DrawButton method in order to draw the required button using your own LookAndFeel object.<br>Note that you can set the required button's color using the EditorButton.Appearance.BackColor property at design time or in code.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-color-specific-buttonedits-buttons-by-taking-into-account-the-current-skin-t522495/16.1.7+/media/ac82e189-4aad-11e7-80c0-00155d624807.png"></p>

<br/>


