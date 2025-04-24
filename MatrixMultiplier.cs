using System.Threading.Tasks; 
using System.Threading;

namespace Lab3
{
    public static class MatrixMultiplier
    {
        public static int[,] MultiplySequential(int[,] A, int[,] B)
        {
            int size = A.GetLength(0);
            int[,] result = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    for (int k = 0; k < size; k++)
                        result[i, j] += A[i, k] * B[k, j];
            return result;
        }

        public static int[,] MultiplyParallel(int[,] A, int[,] B, int threads)
        {
            int size = A.GetLength(0);
            int[,] result = new int[size, size];
            var options = new ParallelOptions { MaxDegreeOfParallelism = threads };

            Parallel.For(0, size, options, i =>
            {
                for (int j = 0; j < size; j++)
                    for (int k = 0; k < size; k++)
                        result[i, j] += A[i, k] * B[k, j];
            });

            return result;
        }

       

    public static int[,] MultiplyWithThreads(int[,] A, int[,] B, int threadCount)
        {
            int size = A.GetLength(0);
            int[,] result = new int[size, size];
            Thread[] threads = new Thread[threadCount];

            int rowsPerThread = size / threadCount;
            int remainingRows = size % threadCount;

            for (int t = 0; t < threadCount; t++)
            {
                int start = t * rowsPerThread;
                int end = (t == threadCount - 1) ? (start + rowsPerThread + remainingRows) : (start + rowsPerThread);

                threads[t] = new Thread(() =>
                {
                    for (int i = start; i < end; i++)
                        for (int j = 0; j < size; j++)
                            for (int k = 0; k < size; k++)
                                result[i, j] += A[i, k] * B[k, j];
                });

                threads[t].Start();
            }

            foreach (Thread thread in threads)
                thread.Join();

            return result;
        }

    }
}
