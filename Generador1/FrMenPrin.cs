using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;

namespace Generador
{
    public partial class FrMenPrin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrMenPrin()
        {
            InitializeComponent();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            GrillaRef.ShowRibbonPrintPreview();
        }
        
    }
}