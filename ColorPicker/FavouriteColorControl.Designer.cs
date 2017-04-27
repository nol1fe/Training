namespace ColorPicker
{
    partial class FavouriteColorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.favNameYourColor = new System.Windows.Forms.TextBox();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.labelColorName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(195, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // favNameYourColor
            // 
            this.favNameYourColor.Location = new System.Drawing.Point(79, 24);
            this.favNameYourColor.Name = "favNameYourColor";
            this.favNameYourColor.Size = new System.Drawing.Size(100, 20);
            this.favNameYourColor.TabIndex = 3;
            // 
            // btnSaveName
            // 
            this.btnSaveName.ForeColor = System.Drawing.Color.Green;
            this.btnSaveName.Location = new System.Drawing.Point(195, 24);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(20, 20);
            this.btnSaveName.TabIndex = 4;
            this.btnSaveName.Text = "✓";
            this.btnSaveName.UseVisualStyleBackColor = true;
            // 
            // labelColorName
            // 
            this.labelColorName.AutoSize = true;
            this.labelColorName.Location = new System.Drawing.Point(79, 5);
            this.labelColorName.Name = "labelColorName";
            this.labelColorName.Size = new System.Drawing.Size(60, 13);
            this.labelColorName.TabIndex = 5;
            this.labelColorName.Text = "Color name";
            // 
            // FavouriteColorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelColorName);
            this.Controls.Add(this.btnSaveName);
            this.Controls.Add(this.favNameYourColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FavouriteColorControl";
            this.Size = new System.Drawing.Size(231, 73);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox favNameYourColor;
        private System.Windows.Forms.Button btnSaveName;
        private System.Windows.Forms.Label labelColorName;
    }
}
