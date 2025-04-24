using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\antek\Desktop\semestr6\Net_i_Java\Lab3\benchmark_results.csv";
            BenchmarkManager.RunTests(filePath, repetitions: 5);
            MessageBox.Show("Wyniki zapisane w:\n" + filePath);

        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            int size = (int)numericSize.Value;
            int threads = (int)numericThreads.Value;

            var A = MatrixGenerator.Generate(size);
            var B = MatrixGenerator.Generate(size);

            var sw = Stopwatch.StartNew();
            var resultSeq = MatrixMultiplier.MultiplySequential(A, B);
            sw.Stop();
            labelSeq.Text = $"Sekwencyjnie: {sw.ElapsedMilliseconds} ms";

            sw.Restart();
            var resultPar = MatrixMultiplier.MultiplyParallel(A, B, threads);
            sw.Stop();
            labelPar.Text = $"Parallel ({threads} w¹tków): {sw.ElapsedMilliseconds} ms";

            sw.Restart();
            var resultThread = MatrixMultiplier.MultiplyWithThreads(A, B, threads);
            sw.Stop();
            labelThread.Text = $"Thread ({threads} w¹tków): {sw.ElapsedMilliseconds} ms";

        }
    }
}
