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
        private readonly IEdgeFilters iedgeFilters;
        private readonly IImageFilters iimageFilters;

        private ImageController ic;
        private EdgeFilters edgeFilters;
        private ImageFilters imageFilters;

        private Bitmap originalBitmap;
        private Bitmap bitmapWithFilter;
        public MainForm()
        {
            InitializeComponent();
            this.ic = new ImageController();
            this.edgeFilters = new EdgeFilters(iedgeFilters);
            this.imageFilters = new ImageFilters(iimageFilters);
        }

        private void buttonSave_click(object sender, EventArgs e)
        {
            ic.SaveImg((Bitmap)picPreview.Image);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            originalBitmap = ic.LoadImg();
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
            picPreview.Image = bitmapWithFilter;
            picPreview.Image = imageFilters.ApplyFilter((Bitmap)picPreview.Image, 1, 1, 10, 15);
            bitmapWithFilter = (Bitmap)picPreview.Image;
            buttonHell.Enabled = false;
            cmbEdgeDetection.SelectedItem = "None";
        }

        private void buttonZen_Click(object sender, EventArgs e)
        {
            picPreview.Image = bitmapWithFilter;
            picPreview.Image = imageFilters.ApplyFilter((Bitmap)picPreview.Image, 1, 10, 1, 1);
            bitmapWithFilter = (Bitmap)picPreview.Image;
            buttonZen.Enabled = false;
            cmbEdgeDetection.SelectedItem = "None";
        }

        private void buttonNight_Click(object sender, EventArgs e)
        {
            picPreview.Image = bitmapWithFilter;
            picPreview.Image = imageFilters.ApplyFilter((Bitmap)picPreview.Image, 1, 1, 1, 25);
            bitmapWithFilter = (Bitmap)picPreview.Image;
            buttonNight.Enabled = false;
            cmbEdgeDetection.SelectedItem = "None";
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
