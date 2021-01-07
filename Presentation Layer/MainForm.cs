using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer
{
    public partial class MainForm : Form
    {
            private readonly ImportExportImage importExportImage = new ImportExportImage();
        private readonly EdgeFilters edgeFilters = new EdgeFilters();
        private readonly ImageFilters imageFilters = new ImageFilters();
        private Bitmap originalBitmap;
        private Bitmap bitmapWithFilter;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSave_click(object sender, EventArgs e)
        {
            importExportImage.SaveImg((Bitmap)picPreview.Image);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            originalBitmap = importExportImage.LoadImg();
            if (originalBitmap != null)
            {
                picPreview.Image = originalBitmap;
                bitmapWithFilter = originalBitmap;
                cmbEdgeDetection.Enabled = true;
                buttonHell.Enabled = true;
                buttonNight.Enabled = true;
                buttonZen.Enabled = true;
                buttonReset.Enabled = true;
                buttonSave.Enabled = true;
                cmbEdgeDetection.SelectedItem = "None";
            }

        }
        private void cmbEdgeDetection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap resultBitmap = edgeFilters.ApplyEdgeDetection(bitmapWithFilter, cmbEdgeDetection.SelectedItem.ToString());

            picPreview.Image = resultBitmap;
        }

        private void buttonHell_Click(object sender, EventArgs e)
        {
            picPreview.Image = imageFilters.ApplyFilter((Bitmap)picPreview.Image, 1, 1, 10, 15);
            bitmapWithFilter = (Bitmap)picPreview.Image;
            buttonHell.Enabled = false;
        }

        private void buttonZen_Click(object sender, EventArgs e)
        {
            picPreview.Image = imageFilters.ApplyFilter((Bitmap)picPreview.Image, 1, 10, 1, 1);
            bitmapWithFilter = (Bitmap)picPreview.Image;
            buttonZen.Enabled = false;
        }

        private void buttonNight_Click(object sender, EventArgs e)
        {
            picPreview.Image = imageFilters.ApplyFilter((Bitmap)picPreview.Image, 1, 1, 1, 25);
            bitmapWithFilter = (Bitmap)picPreview.Image;
            buttonNight.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            picPreview.Image = originalBitmap;
            bitmapWithFilter = originalBitmap;
            cmbEdgeDetection.SelectedItem = "None";
            buttonHell.Enabled = true;
            buttonNight.Enabled = true;
            buttonZen.Enabled = true;
        }
    }
    
}
