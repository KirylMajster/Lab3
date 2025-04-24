using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Lab3
{
    public static class BenchmarkManager
    {
        public static void RunTests(string path, int repetitions = 5)
        {
            int[] sizes = { 100, 200, 300, 500, 700};
            int[] threads = { 1, 2, 4, 8, 10, 12 };

            var sb = new StringBuilder();
            sb.AppendLine("Size;Threads;Avg_Sequential(ms);Avg_Parallel(ms);Avg_Thread(ms)");

            foreach (var size in sizes)
            {
                foreach (var t in threads)
                {
                    List<long> sequentialTimes = new();
                    List<long> parallelTimes = new();
                    List<long> threadTimes = new();

                    for (int r = 0; r < repetitions; r++)
                    {
                        var A = MatrixGenerator.Generate(size);
                        var B = MatrixGenerator.Generate(size);
                        var sw = Stopwatch.StartNew();

                        // Sequential
                        sw.Restart();
                        MatrixMultiplier.MultiplySequential(A, B);
                        sw.Stop();
                        sequentialTimes.Add(sw.ElapsedMilliseconds);

                        // Parallel
                        sw.Restart();
                        MatrixMultiplier.MultiplyParallel(A, B, t);
                        sw.Stop();
                        parallelTimes.Add(sw.ElapsedMilliseconds);

                        // Thread
                        sw.Restart();
                        MatrixMultiplier.MultiplyWithThreads(A, B, t);
                        sw.Stop();
                        threadTimes.Add(sw.ElapsedMilliseconds);
                    }

                    double avgSeq = sequentialTimes.Average();
                    double avgPar = parallelTimes.Average();
                    double avgThread = threadTimes.Average();

                    sb.AppendLine($"{size};{t};{avgSeq:F2};{avgPar:F2};{avgThread:F2}");
                }
            }

            File.WriteAllText(path, sb.ToString());
        }

    }
}
