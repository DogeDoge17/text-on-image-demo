namespace TextOnImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openBtn = new System.Windows.Forms.Button();
            this.selectedFileLbl = new System.Windows.Forms.Label();
            this.previewImage = new System.Windows.Forms.PictureBox();
            this.inputRTB = new System.Windows.Forms.RichTextBox();
            this.outputImage = new System.Windows.Forms.PictureBox();
            this.processBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 12);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(87, 26);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open Image";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // selectedFileLbl
            // 
            this.selectedFileLbl.AutoSize = true;
            this.selectedFileLbl.Location = new System.Drawing.Point(105, 18);
            this.selectedFileLbl.Name = "selectedFileLbl";
            this.selectedFileLbl.Size = new System.Drawing.Size(91, 15);
            this.selectedFileLbl.TabIndex = 1;
            this.selectedFileLbl.Text = "No File Selected";
            // 
            // previewImage
            // 
            this.previewImage.Location = new System.Drawing.Point(12, 95);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(268, 306);
            this.previewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewImage.TabIndex = 2;
            this.previewImage.TabStop = false;
            // 
            // inputRTB
            // 
            this.inputRTB.Location = new System.Drawing.Point(286, 95);
            this.inputRTB.Name = "inputRTB";
            this.inputRTB.Size = new System.Drawing.Size(228, 234);
            this.inputRTB.TabIndex = 3;
            this.inputRTB.Text = "";
            // 
            // outputImage
            // 
            this.outputImage.Location = new System.Drawing.Point(520, 95);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(268, 306);
            this.outputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outputImage.TabIndex = 4;
            this.outputImage.TabStop = false;
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(286, 335);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(228, 66);
            this.processBtn.TabIndex = 5;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(675, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(113, 26);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save Image As";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.outputImage);
            this.Controls.Add(this.inputRTB);
            this.Controls.Add(this.previewImage);
            this.Controls.Add(this.selectedFileLbl);
            this.Controls.Add(this.openBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Image Over Text";
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openBtn;
        private Label selectedFileLbl;
        private PictureBox previewImage;
        private RichTextBox inputRTB;
        private PictureBox outputImage;
        private Button processBtn;
        private Button saveBtn;
    }
}