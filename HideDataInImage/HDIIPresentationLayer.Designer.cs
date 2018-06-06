namespace HideDataInImage
{
    partial class HDIIPresentationLayer
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
            this.openImage = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.encodeTextBox = new System.Windows.Forms.TextBox();
            this.encodeText = new System.Windows.Forms.Button();
            this.decodeText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openImage
            // 
            this.openImage.Location = new System.Drawing.Point(12, 12);
            this.openImage.Name = "openImage";
            this.openImage.Size = new System.Drawing.Size(100, 23);
            this.openImage.TabIndex = 0;
            this.openImage.Text = "Abrir imagem";
            this.openImage.UseVisualStyleBackColor = true;
            this.openImage.Click += new System.EventHandler(this.openImage_Click);
            // 
            // saveImage
            // 
            this.saveImage.Location = new System.Drawing.Point(118, 12);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(119, 23);
            this.saveImage.TabIndex = 1;
            this.saveImage.Text = "Guardar imagem";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 696);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // encodeTextBox
            // 
            this.encodeTextBox.Location = new System.Drawing.Point(353, 12);
            this.encodeTextBox.Multiline = true;
            this.encodeTextBox.Name = "encodeTextBox";
            this.encodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.encodeTextBox.Size = new System.Drawing.Size(260, 42);
            this.encodeTextBox.TabIndex = 5;
            this.encodeTextBox.TextChanged += new System.EventHandler(this.encodeTextBox_TextChanged);
            // 
            // encodeText
            // 
            this.encodeText.Location = new System.Drawing.Point(619, 21);
            this.encodeText.Name = "encodeText";
            this.encodeText.Size = new System.Drawing.Size(130, 23);
            this.encodeText.TabIndex = 6;
            this.encodeText.Text = "Encode ";
            this.encodeText.UseVisualStyleBackColor = true;
            this.encodeText.Click += new System.EventHandler(this.encodeText_Click);
            // 
            // decodeText
            // 
            this.decodeText.Location = new System.Drawing.Point(755, 21);
            this.decodeText.Name = "decodeText";
            this.decodeText.Size = new System.Drawing.Size(130, 23);
            this.decodeText.TabIndex = 7;
            this.decodeText.Text = "Decode";
            this.decodeText.UseVisualStyleBackColor = true;
            this.decodeText.Click += new System.EventHandler(this.decodeText_Click);
            // 
            // HDIIPresentationLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 741);
            this.Controls.Add(this.decodeText);
            this.Controls.Add(this.encodeText);
            this.Controls.Add(this.encodeTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.openImage);
            this.Name = "HDIIPresentationLayer";
            this.Text = "Hide data in image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openImage;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox encodeTextBox;
        private System.Windows.Forms.Button encodeText;
        private System.Windows.Forms.Button decodeText;
    }
}

