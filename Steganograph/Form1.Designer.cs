namespace Steganograph
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textMessageIn = new System.Windows.Forms.TextBox();
            this.textInNumbers = new System.Windows.Forms.TextBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.textMessageOut = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.multipliLabel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(172, 236);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(468, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // textMessageIn
            // 
            this.textMessageIn.Location = new System.Drawing.Point(35, 287);
            this.textMessageIn.Name = "textMessageIn";
            this.textMessageIn.Size = new System.Drawing.Size(131, 20);
            this.textMessageIn.TabIndex = 3;
            // 
            // textInNumbers
            // 
            this.textInNumbers.Location = new System.Drawing.Point(35, 399);
            this.textInNumbers.Multiline = true;
            this.textInNumbers.Name = "textInNumbers";
            this.textInNumbers.Size = new System.Drawing.Size(226, 235);
            this.textInNumbers.TabIndex = 8;
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(172, 287);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(75, 23);
            this.btnCode.TabIndex = 9;
            this.btnCode.Text = "Code";
            this.btnCode.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(331, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 200);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(35, 339);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 12;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // textMessageOut
            // 
            this.textMessageOut.Location = new System.Drawing.Point(116, 341);
            this.textMessageOut.Name = "textMessageOut";
            this.textMessageOut.Size = new System.Drawing.Size(131, 20);
            this.textMessageOut.TabIndex = 13;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(289, 480);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(230, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 10;
            // 
            // multipliLabel
            // 
            this.multipliLabel.AutoSize = true;
            this.multipliLabel.Location = new System.Drawing.Point(484, 453);
            this.multipliLabel.Name = "multipliLabel";
            this.multipliLabel.Size = new System.Drawing.Size(16, 13);
            this.multipliLabel.TabIndex = 15;
            this.multipliLabel.Text = "...";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(457, 591);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Multiplicator value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Enter text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 669);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.multipliLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textMessageOut);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.textInNumbers);
            this.Controls.Add(this.textMessageIn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textMessageIn;
        private System.Windows.Forms.TextBox textInNumbers;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox textMessageOut;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label multipliLabel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

