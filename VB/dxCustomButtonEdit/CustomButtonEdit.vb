Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.LookAndFeel
Imports System.Windows.Forms

Namespace dxCustomButtonEdit
	<ToolboxItem(True)>
	Public Class CustomButtonEdit
		Inherits ButtonEdit

		 Shared Sub New()
			RepositoryItemCustomButtonEdit.RegisterCustomButtonEdit()
		 End Sub
		 Public Sub New()
		 End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomButtonEdit.EditorName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomButtonEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomButtonEdit)
			End Get
		End Property
	End Class

	Public Class TextEditorButton
		Inherits EditorButton

	End Class

	<UserRepositoryItem("RegisterCustomButtonEdit")>
	Public Class RepositoryItemCustomButtonEdit
		Inherits RepositoryItemButtonEdit

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content), RefreshProperties(RefreshProperties.All)>
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
		Shared Sub New()
			RegisterCustomButtonEdit()
		End Sub
		Public Sub New()

		End Sub
		Friend Const EditorName As String = "CustomButtonEdit"

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemCustomButtonEdit = TryCast(item, RepositoryItemCustomButtonEdit)
				If source Is Nothing Then
					Return
				End If
			Finally
				EndUpdate()
			End Try
		End Sub

		Public Shared Sub RegisterCustomButtonEdit()
            Dim _image As Image = Nothing

            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(CustomButtonEdit), GetType(RepositoryItemCustomButtonEdit), GetType(ButtonEditViewInfo), New CustomButtonEditPainter(), True, _image, GetType(DevExpress.Accessibility.ButtonEditAccessible)))
        End Sub
	End Class

	Public Class CustomButtonEditPainter
		Inherits ButtonEditPainter

		Protected Overrides Sub DrawButton(ByVal viewInfo As ButtonEditViewInfo, ByVal info As EditorButtonObjectInfoArgs)
			If info.Button.Tag IsNot Nothing AndAlso info.Button.Tag.ToString() = "Custom" Then
                Dim look = New UserLookAndFeel(viewInfo.OwnerEdit)
                Dim painter As New SkinEditorButtonPainter(look)
				look.SkinName = look.ActiveSkinName
				look.UseDefaultLookAndFeel = False
				look.SkinMaskColor = info.Button.Appearance.BackColor
				painter.DrawObject(info)
			Else
				MyBase.DrawButton(viewInfo, info)
			End If
		End Sub
	End Class
End Namespace
