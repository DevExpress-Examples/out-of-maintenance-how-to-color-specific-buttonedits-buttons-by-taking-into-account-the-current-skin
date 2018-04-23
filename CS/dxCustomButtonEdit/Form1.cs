using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dxCustomButtonEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customButtonEdit1.Text = "main text";

            SetColorForDxBaseStyleControl(Color.Red, customButtonEdit1.Properties);

        }


        public static void SetColorForDxBaseStyleControl(Color color, RepositoryItem repositoryItem)
        {
            var look = new UserLookAndFeel(repositoryItem);
            look.SkinName = look.ActiveSkinName;
            look.UseDefaultLookAndFeel = false;
            look.SkinMaskColor = color;
            repositoryItem.LookAndFeel.Assign(look);
        }
    }
}
