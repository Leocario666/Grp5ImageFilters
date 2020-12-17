using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer
{
    public partial class MainForm: UserControl
    {
        private Bitmap originalBitmap;
        private Bitmap bitmapWithFilter;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSave_click(object sender, EventArgs e)
        {
            ImportExportImage.SaveImg((Bitmap)picPreview.Image);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            originalBitmap = ImportExportImage.LoadImg();
            picPreview.Image = originalBitmap;
            bitmapWithFilter = originalBitmap;
            cmbEdgeDetection.Enabled = true;
            buttonHell.Enabled = true;
            buttonNight.Enabled = true;
            buttonZen.Enabled = true;
            buttonReset.Enabled = true;
            buttonSave.Enabled = true;
            

        }
        private void cmbEdgeDetection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonHell_Click(object sender, EventArgs e)
        {
            picPreview.Image = ImageFilters.ApplyFilter((Bitmap)picPreview.Image, 1, 1, 10, 15);
            bitmapWithFilter = (Bitmap)picPreview.Image;
            buttonHell.Enabled = false;
        }

        private void buttonZen_Click(object sender, EventArgs e)
        {
            picPreview.Image = ImageFilters.ApplyFilter((Bitmap)picPreview.Image, 1, 10, 1, 1);
            bitmapWithFilter = (Bitmap)picPreview.Image;
            buttonZen.Enabled = false;
        }

        private void buttonNight_Click(object sender, EventArgs e)
        {
            picPreview.Image = ImageFilters.ApplyFilter((Bitmap)picPreview.Image, 1, 1, 1, 25);
            bitmapWithFilter = (Bitmap)picPreview.Image;
            buttonNight.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            picPreview.Image = originalBitmap;
            buttonHell.Enabled = true;
            buttonNight.Enabled = true;
            buttonZen.Enabled = true;
        }
    }
}
