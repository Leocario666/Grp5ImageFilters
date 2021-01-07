namespace Presentation_Layer
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHell = new System.Windows.Forms.Button();
            this.buttonZen = new System.Windows.Forms.Button();
            this.buttonNight = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.cmbEdgeDetection = new System.Windows.Forms.ComboBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 627);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(125, 35);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load Image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(482, 630);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 35);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save Image";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_click);
            // 
            // buttonHell
            // 
            this.buttonHell.Enabled = false;
            this.buttonHell.Location = new System.Drawing.Point(143, 680);
            this.buttonHell.Name = "buttonHell";
            this.buttonHell.Size = new System.Drawing.Size(107, 31);
            this.buttonHell.TabIndex = 2;
            this.buttonHell.Text = "Hell Filter";
            this.buttonHell.UseVisualStyleBackColor = true;
            this.buttonHell.Click += new System.EventHandler(this.buttonHell_Click);
            // 
            // buttonZen
            // 
            this.buttonZen.Enabled = false;
            this.buttonZen.Location = new System.Drawing.Point(256, 680);
            this.buttonZen.Name = "buttonZen";
            this.buttonZen.Size = new System.Drawing.Size(107, 31);
            this.buttonZen.TabIndex = 3;
            this.buttonZen.Text = "Zen Filter";
            this.buttonZen.UseVisualStyleBackColor = true;
            this.buttonZen.Click += new System.EventHandler(this.buttonZen_Click);
            // 
            // buttonNight
            // 
            this.buttonNight.Enabled = false;
            this.buttonNight.Location = new System.Drawing.Point(369, 680);
            this.buttonNight.Name = "buttonNight";
            this.buttonNight.Size = new System.Drawing.Size(107, 31);
            this.buttonNight.TabIndex = 4;
            this.buttonNight.Text = "Night Filter";
            this.buttonNight.UseVisualStyleBackColor = true;
            this.buttonNight.Click += new System.EventHandler(this.buttonNight_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(143, 730);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(333, 31);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // cmbEdgeDetection
            // 
            this.cmbEdgeDetection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdgeDetection.Enabled = false;
            this.cmbEdgeDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdgeDetection.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbEdgeDetection.FormattingEnabled = true;
            this.cmbEdgeDetection.ItemHeight = 25;
            this.cmbEdgeDetection.Items.AddRange(new object[] {
            "None",
            "Laplacian 3x3",
            "Laplacian 5x5",
            "Laplacian of Gaussian"});
            this.cmbEdgeDetection.Location = new System.Drawing.Point(143, 629);
            this.cmbEdgeDetection.Name = "cmbEdgeDetection";
            this.cmbEdgeDetection.Size = new System.Drawing.Size(333, 33);
            this.cmbEdgeDetection.TabIndex = 7;
            this.cmbEdgeDetection.SelectedIndexChanged += new System.EventHandler(this.cmbEdgeDetection_SelectedIndexChanged);
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(12, 21);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(600, 600);
            this.picPreview.TabIndex = 6;
            this.picPreview.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 774);
            this.Controls.Add(this.cmbEdgeDetection);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonNight);
            this.Controls.Add(this.buttonZen);
            this.Controls.Add(this.buttonHell);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonHell;
        private System.Windows.Forms.Button buttonZen;
        private System.Windows.Forms.Button buttonNight;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox cmbEdgeDetection;
        private System.Windows.Forms.PictureBox picPreview;
    }
}

