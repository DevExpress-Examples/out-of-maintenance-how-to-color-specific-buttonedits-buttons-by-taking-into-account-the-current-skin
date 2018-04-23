Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace dxCustomButtonEdit
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			customButtonEdit1.Text = "main text"

			SetColorForDxBaseStyleControl(Color.Red, customButtonEdit1.Properties)

		End Sub


		Public Shared Sub SetColorForDxBaseStyleControl(ByVal color As Color, ByVal repositoryItem As RepositoryItem)
			Dim look = New UserLookAndFeel(repositoryItem)
			look.SkinName = look.ActiveSkinName
			look.UseDefaultLookAndFeel = False
			look.SkinMaskColor = color
			repositoryItem.LookAndFeel.Assign(look)
		End Sub
	End Class
End Namespace
