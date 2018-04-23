using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.LookAndFeel;
using System.Windows.Forms;

namespace dxCustomButtonEdit
{
    [ToolboxItem(true)]
    public class CustomButtonEdit : ButtonEdit
    {
         static CustomButtonEdit() 
        {
            RepositoryItemCustomButtonEdit.RegisterCustomButtonEdit();
        }
         public CustomButtonEdit() 
         {
         }
        public override string EditorTypeName 
        {
            get { return RepositoryItemCustomButtonEdit.EditorName; } 
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemCustomButtonEdit; } 
        }
    }

    public class TextEditorButton : EditorButton{
        
    }

    [UserRepositoryItem("RegisterCustomButtonEdit")]
    public class RepositoryItemCustomButtonEdit : RepositoryItemButtonEdit
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), RefreshProperties(RefreshProperties.All)]
        public override string EditorTypeName
        {
            get { return EditorName; }
        }
        static RepositoryItemCustomButtonEdit() 
        { 
            RegisterCustomButtonEdit(); 
        }
        public RepositoryItemCustomButtonEdit() {

        }
        internal const string EditorName = "CustomButtonEdit";

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemCustomButtonEdit source = item as RepositoryItemCustomButtonEdit;
                if (source == null) return;
            }
            finally
            {
                EndUpdate();
            }
        }
         
        public static void RegisterCustomButtonEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(CustomButtonEdit),
                typeof(RepositoryItemCustomButtonEdit), typeof(ButtonEditViewInfo), 
                new CustomButtonEditPainter(), true, null, typeof(DevExpress.Accessibility.ButtonEditAccessible)));
        }
    }

    public class CustomButtonEditPainter : ButtonEditPainter
    {
        protected override void DrawButton(ButtonEditViewInfo viewInfo, EditorButtonObjectInfoArgs info)
        {
            if (info.Button.Tag != null && info.Button.Tag.ToString() == "Custom")
            {
                var look = new UserLookAndFeel(viewInfo.OwnerEdit);                
                look.SkinName = look.ActiveSkinName;
                look.UseDefaultLookAndFeel = false;
                look.SkinMaskColor = info.Button.Appearance.BackColor;
                SkinEditorButtonPainter painter = new SkinEditorButtonPainter(look);
                painter.DrawObject(info);
            }
            else
                base.DrawButton(viewInfo, info);
        }
    }
}
