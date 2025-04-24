namespace Lab3_zadanie3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureOriginal;
        private System.Windows.Forms.PictureBox pictureGray;
        private System.Windows.Forms.PictureBox pictureNegative;
        private System.Windows.Forms.PictureBox pictureThreshold;
        private System.Windows.Forms.PictureBox pictureMirror;

        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelGray;
        private System.Windows.Forms.Label labelNegative;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.Label labelMirror;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureOriginal = new System.Windows.Forms.PictureBox();
            this.pictureGray = new System.Windows.Forms.PictureBox();
            this.pictureNegative = new System.Windows.Forms.PictureBox();
            this.pictureThreshold = new System.Windows.Forms.PictureBox();
            this.pictureMirror = new System.Windows.Forms.PictureBox();

            this.labelOriginal = new System.Windows.Forms.Label();
            this.labelGray = new System.Windows.Forms.Label();
            this.labelNegative = new System.Windows.Forms.Label();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.labelMirror = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNegative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMirror)).BeginInit();

            this.SuspendLayout();

            // btnLoad
            this.btnLoad.Location = new System.Drawing.Point(20, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 30);
            this.btnLoad.Text = "Wczytaj obraz";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // pictureOriginal
            this.pictureOriginal.Location = new System.Drawing.Point(20, 70);
            this.pictureOriginal.Size = new System.Drawing.Size(200, 200);
            this.pictureOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // pictureGray
            this.pictureGray.Location = new System.Drawing.Point(240, 70);
            this.pictureGray.Size = new System.Drawing.Size(200, 200);
            this.pictureGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // pictureNegative
            this.pictureNegative.Location = new System.Drawing.Point(460, 70);
            this.pictureNegative.Size = new System.Drawing.Size(200, 200);
            this.pictureNegative.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureNegative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // pictureThreshold
            this.pictureThreshold.Location = new System.Drawing.Point(680, 70);
            this.pictureThreshold.Size = new System.Drawing.Size(200, 200);
            this.pictureThreshold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // pictureMirror
            this.pictureMirror.Location = new System.Drawing.Point(900, 70);
            this.pictureMirror.Size = new System.Drawing.Size(200, 200);
            this.pictureMirror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMirror.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // labelOriginal
            this.labelOriginal.Location = new System.Drawing.Point(20, 275);
            this.labelOriginal.Size = new System.Drawing.Size(200, 20);
            this.labelOriginal.Text = "Oryginał";
            this.labelOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelGray
            this.labelGray.Location = new System.Drawing.Point(240, 275);
            this.labelGray.Size = new System.Drawing.Size(200, 20);
            this.labelGray.Text = "Szarość";
            this.labelGray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelNegative
            this.labelNegative.Location = new System.Drawing.Point(460, 275);
            this.labelNegative.Size = new System.Drawing.Size(200, 20);
            this.labelNegative.Text = "Negatyw";
            this.labelNegative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelThreshold
            this.labelThreshold.Location = new System.Drawing.Point(680, 275);
            this.labelThreshold.Size = new System.Drawing.Size(200, 20);
            this.labelThreshold.Text = "Progowanie";
            this.labelThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelMirror
            this.labelMirror.Location = new System.Drawing.Point(900, 275);
            this.labelMirror.Size = new System.Drawing.Size(200, 20);
            this.labelMirror.Text = "Odbicie";
            this.labelMirror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1140, 320);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureOriginal);
            this.Controls.Add(this.pictureGray);
            this.Controls.Add(this.pictureNegative);
            this.Controls.Add(this.pictureThreshold);
            this.Controls.Add(this.pictureMirror);

            this.Controls.Add(this.labelOriginal);
            this.Controls.Add(this.labelGray);
            this.Controls.Add(this.labelNegative);
            this.Controls.Add(this.labelThreshold);
            this.Controls.Add(this.labelMirror);

            this.Name = "Form1";
            this.Text = "Zadanie 3 - Przetwarzanie Obrazów";

            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNegative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMirror)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
