namespace ColorPicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sliderRed = new System.Windows.Forms.TrackBar();
            this.sliderGreen = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.sliderBlue = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.colorDisplay = new System.Windows.Forms.TextBox();
            this.redAmmount = new System.Windows.Forms.TextBox();
            this.greenAmmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.blueAmmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.favouriteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.favouriteListPanel = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myFav = new System.Windows.Forms.Label();
            this.lastColors = new System.Windows.Forms.Label();
            this.lastColorsPanel = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBlue)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ammount";
            // 
            // sliderRed
            // 
            this.sliderRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderRed.Location = new System.Drawing.Point(58, 129);
            this.sliderRed.Maximum = 255;
            this.sliderRed.Name = "sliderRed";
            this.sliderRed.Size = new System.Drawing.Size(524, 45);
            this.sliderRed.TabIndex = 3;
            // 
            // sliderGreen
            // 
            this.sliderGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderGreen.Location = new System.Drawing.Point(58, 205);
            this.sliderGreen.Maximum = 255;
            this.sliderGreen.Name = "sliderGreen";
            this.sliderGreen.Size = new System.Drawing.Size(524, 45);
            this.sliderGreen.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Green";
            // 
            // sliderBlue
            // 
            this.sliderBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderBlue.Location = new System.Drawing.Point(58, 274);
            this.sliderBlue.Maximum = 255;
            this.sliderBlue.Name = "sliderBlue";
            this.sliderBlue.Size = new System.Drawing.Size(524, 45);
            this.sliderBlue.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Blue";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRandom.Location = new System.Drawing.Point(103, 399);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(120, 23);
            this.buttonRandom.TabIndex = 10;
            this.buttonRandom.Text = "Generate";
            this.buttonRandom.UseVisualStyleBackColor = true;
            // 
            // colorDisplay
            // 
            this.colorDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.colorDisplay.Location = new System.Drawing.Point(58, 67);
            this.colorDisplay.Name = "colorDisplay";
            this.colorDisplay.Size = new System.Drawing.Size(581, 20);
            this.colorDisplay.TabIndex = 17;
            // 
            // redAmmount
            // 
            this.redAmmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.redAmmount.Location = new System.Drawing.Point(591, 135);
            this.redAmmount.Name = "redAmmount";
            this.redAmmount.Size = new System.Drawing.Size(48, 20);
            this.redAmmount.TabIndex = 18;
            // 
            // greenAmmount
            // 
            this.greenAmmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.greenAmmount.Location = new System.Drawing.Point(591, 211);
            this.greenAmmount.Name = "greenAmmount";
            this.greenAmmount.Size = new System.Drawing.Size(48, 20);
            this.greenAmmount.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ammount";
            // 
            // blueAmmount
            // 
            this.blueAmmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.blueAmmount.Location = new System.Drawing.Point(591, 280);
            this.blueAmmount.Name = "blueAmmount";
            this.blueAmmount.Size = new System.Drawing.Size(48, 20);
            this.blueAmmount.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ammount";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.favouriteToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 661);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.saveToolStripButton.Tag = "Save to file";
            this.saveToolStripButton.Text = "Save to file";
            this.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            // 
            // favouriteToolStripButton
            // 
            this.favouriteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.favouriteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("favouriteToolStripButton.Image")));
            this.favouriteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.favouriteToolStripButton.Name = "favouriteToolStripButton";
            this.favouriteToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.favouriteToolStripButton.Text = "Add to favourites";
            // 
            // favouriteListPanel
            // 
            this.favouriteListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favouriteListPanel.AutoScroll = true;
            this.favouriteListPanel.Location = new System.Drawing.Point(28, 67);
            this.favouriteListPanel.Name = "favouriteListPanel";
            this.favouriteListPanel.Size = new System.Drawing.Size(318, 489);
            this.favouriteListPanel.TabIndex = 25;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(229, 399);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 23);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExport.Location = new System.Drawing.Point(355, 399);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(120, 23);
            this.buttonExport.TabIndex = 27;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.myFav);
            this.panel1.Controls.Add(this.favouriteListPanel);
            this.panel1.Location = new System.Drawing.Point(666, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 661);
            this.panel1.TabIndex = 28;
            // 
            // myFav
            // 
            this.myFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myFav.AutoSize = true;
            this.myFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.myFav.Location = new System.Drawing.Point(94, 9);
            this.myFav.Name = "myFav";
            this.myFav.Size = new System.Drawing.Size(180, 39);
            this.myFav.TabIndex = 0;
            this.myFav.Text = "Favourites";
            // 
            // lastColors
            // 
            this.lastColors.AutoSize = true;
            this.lastColors.Location = new System.Drawing.Point(58, 507);
            this.lastColors.Name = "lastColors";
            this.lastColors.Size = new System.Drawing.Size(59, 13);
            this.lastColors.TabIndex = 29;
            this.lastColors.Text = "Last Colors";
            // 
            // lastColorsPanel
            // 
            this.lastColorsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastColorsPanel.AutoScroll = true;
            this.lastColorsPanel.Location = new System.Drawing.Point(61, 537);
            this.lastColorsPanel.Name = "lastColorsPanel";
            this.lastColorsPanel.Size = new System.Drawing.Size(570, 82);
            this.lastColorsPanel.TabIndex = 30;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(481, 399);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 23);
            this.buttonClear.TabIndex = 31;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 661);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.lastColorsPanel);
            this.Controls.Add(this.lastColors);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.blueAmmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.greenAmmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.redAmmount);
            this.Controls.Add(this.colorDisplay);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.sliderBlue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sliderGreen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sliderRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(1040, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorPicker";
            ((System.ComponentModel.ISupportInitialize)(this.sliderRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBlue)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sliderRed;
        private System.Windows.Forms.TrackBar sliderGreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar sliderBlue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRandom;
        public System.Windows.Forms.TextBox colorDisplay;
        private System.Windows.Forms.TextBox redAmmount;
        private System.Windows.Forms.TextBox greenAmmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox blueAmmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton favouriteToolStripButton;
        private System.Windows.Forms.Panel favouriteListPanel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label myFav;
        private System.Windows.Forms.Label lastColors;
        private System.Windows.Forms.Panel lastColorsPanel;
        private System.Windows.Forms.Button buttonClear;
    }
}

