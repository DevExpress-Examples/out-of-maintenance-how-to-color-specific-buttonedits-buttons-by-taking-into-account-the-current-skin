Namespace dxCustomButtonEdit
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject5 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject6 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject7 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject8 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject9 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject10 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject11 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject12 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject13 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject14 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject15 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject16 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject17 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject18 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject19 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject20 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject21 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.customButtonEdit1 = New dxCustomButtonEdit.CustomButtonEdit()
			DirectCast(Me.customButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customButtonEdit1
			' 
			Me.customButtonEdit1.Location = New System.Drawing.Point(34, 45)
			Me.customButtonEdit1.Name = "customButtonEdit1"
			serializableAppearanceObject2.BackColor = System.Drawing.Color.ForestGreen
			serializableAppearanceObject2.Options.UseBackColor = True
			serializableAppearanceObject3.BackColor = System.Drawing.Color.Yellow
			serializableAppearanceObject3.Options.UseBackColor = True
			serializableAppearanceObject4.BackColor = System.Drawing.Color.Yellow
			serializableAppearanceObject4.Options.UseBackColor = True
			serializableAppearanceObject5.BackColor = System.Drawing.Color.Yellow
			serializableAppearanceObject5.Options.UseBackColor = True
			serializableAppearanceObject6.BackColor = System.Drawing.Color.Blue
			serializableAppearanceObject6.Options.UseBackColor = True
			serializableAppearanceObject7.BackColor = System.Drawing.Color.White
			serializableAppearanceObject7.Options.UseBackColor = True
			serializableAppearanceObject8.BackColor = System.Drawing.Color.White
			serializableAppearanceObject8.Options.UseBackColor = True
			serializableAppearanceObject9.BackColor = System.Drawing.Color.White
			serializableAppearanceObject9.Options.UseBackColor = True
			serializableAppearanceObject10.BackColor = System.Drawing.Color.Blue
			serializableAppearanceObject10.Options.UseBackColor = True
			serializableAppearanceObject11.BackColor = System.Drawing.Color.Blue
			serializableAppearanceObject11.Options.UseBackColor = True
			serializableAppearanceObject12.BackColor = System.Drawing.Color.Blue
			serializableAppearanceObject12.Options.UseBackColor = True
			serializableAppearanceObject13.BackColor = System.Drawing.Color.Blue
			serializableAppearanceObject13.Options.UseBackColor = True
			serializableAppearanceObject14.BackColor = System.Drawing.Color.Gray
			serializableAppearanceObject14.Options.UseBackColor = True
			serializableAppearanceObject15.BackColor = System.Drawing.Color.Red
			serializableAppearanceObject15.Options.UseBackColor = True
			serializableAppearanceObject16.BackColor = System.Drawing.Color.Red
			serializableAppearanceObject16.Options.UseBackColor = True
			serializableAppearanceObject17.BackColor = System.Drawing.Color.Red
			serializableAppearanceObject17.Options.UseBackColor = True
			serializableAppearanceObject18.BackColor = System.Drawing.Color.Aqua
			serializableAppearanceObject18.Options.UseBackColor = True
			serializableAppearanceObject19.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(64)))), (CInt((CByte(64)))))
			serializableAppearanceObject19.Options.UseBackColor = True
			serializableAppearanceObject20.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(64)))), (CInt((CByte(64)))))
			serializableAppearanceObject20.Options.UseBackColor = True
			serializableAppearanceObject21.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(64)))), (CInt((CByte(64)))))
            serializableAppearanceObject21.Options.UseBackColor = True
            Me.customButtonEdit1.Size = New System.Drawing.Size(308, 20)
            Me.customButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True),
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 80, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, "", New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, serializableAppearanceObject5, "", "Custom", Nothing, True),
                New DevExpress.XtraEditors.Controls.EditorButton(),
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, "", New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, serializableAppearanceObject9, "", "Custom", Nothing, True),
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinUp, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, "", New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, serializableAppearanceObject13, "", Nothing, Nothing, True),
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, "", New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, serializableAppearanceObject17, "", "Custom", Nothing, True),
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinRight, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, "", New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, serializableAppearanceObject21, "", "Custom", Nothing, True)
            })
            Me.customButtonEdit1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(368, 115)
			Me.Controls.Add(Me.customButtonEdit1)
			Me.Name = "Form1"
			Me.Text = "HowToColorTheRequiredButton"
			DirectCast(Me.customButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private customButtonEdit1 As CustomButtonEdit


	End Class
End Namespace

