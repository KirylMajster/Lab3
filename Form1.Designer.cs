namespace Lab3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.NumericUpDown numericSize;
        private System.Windows.Forms.NumericUpDown numericThreads;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.Label labelSeq;
        private System.Windows.Forms.Label labelPar;
        private System.Windows.Forms.Label labelThread;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.numericSize = new System.Windows.Forms.NumericUpDown();
            this.numericThreads = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.labelSeq = new System.Windows.Forms.Label();
            this.labelPar = new System.Windows.Forms.Label();
            this.labelThread = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numericSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreads)).BeginInit();
            this.SuspendLayout();

            // numericSize
            this.numericSize.Location = new System.Drawing.Point(30, 30);
            this.numericSize.Maximum = 1000;
            this.numericSize.Minimum = 1;
            this.numericSize.Value = 100;
            this.numericSize.Name = "numericSize";
            this.numericSize.Size = new System.Drawing.Size(120, 23);

            // numericThreads
            this.numericThreads.Location = new System.Drawing.Point(30, 70);
            this.numericThreads.Maximum = 64;
            this.numericThreads.Minimum = 1;
            this.numericThreads.Value = 4;
            this.numericThreads.Name = "numericThreads";
            this.numericThreads.Size = new System.Drawing.Size(120, 23);

            // btnRun
            this.btnRun.Location = new System.Drawing.Point(30, 110);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(120, 30);
            this.btnRun.Text = "Uruchom";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);

            // labelSeq
            this.labelSeq.Location = new System.Drawing.Point(30, 160);
            this.labelSeq.Name = "labelSeq";
            this.labelSeq.Size = new System.Drawing.Size(400, 20);
            this.labelSeq.Text = "Sekwencyjnie:";

            // labelPar
            this.labelPar.Location = new System.Drawing.Point(30, 190);
            this.labelPar.Name = "labelPar";
            this.labelPar.Size = new System.Drawing.Size(400, 20);
            this.labelPar.Text = "Parallel:";

            // labelThread
            this.labelThread.Location = new System.Drawing.Point(30, 220);
            this.labelThread.Name = "labelThread";
            this.labelThread.Size = new System.Drawing.Size(400, 20);
            this.labelThread.Text = "Thread:";

            // btnBenchmark
            this.btnBenchmark.Location = new System.Drawing.Point(200, 110);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(180, 30);
            this.btnBenchmark.Text = "Uruchom benchmark";
            this.btnBenchmark.UseVisualStyleBackColor = true;
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.numericSize);
            this.Controls.Add(this.numericThreads);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.labelSeq);
            this.Controls.Add(this.labelPar);
            this.Controls.Add(this.labelThread);
            this.Controls.Add(this.btnBenchmark);
            this.Name = "Form1";
            this.Text = "Lab3 - Mnożenie macierzy";

            ((System.ComponentModel.ISupportInitialize)(this.numericSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreads)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
