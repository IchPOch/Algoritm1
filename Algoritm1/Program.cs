// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

public class Sorti
{
    public static void Vibor(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            double buf = arr[min];
            arr[min] = arr[i];
            arr[i] = buf;
        }
    }
    public static void Randomich(double[] arr, int N)
    {
        var rand = new Random();
        for (int i = 0; i < N; i++)
        { 
            arr[i] = rand.NextDouble() * 2 - 1;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var sort = new Sorti();
        double[] arr1000 = new double[1000];
        double[] arr2000 = new double[2000];
        double[] arr4000 = new double[4000];
        double[] arr8000 = new double[8000];
        double[] arr16000 = new double[16000];
        double[] arr32000 = new double[32000];
        double[] arr64000 = new double[64000];
        double[] arr128000 = new double[128000];
        Sorti.Randomich(arr1000, 1000);
        Sorti.Randomich(arr2000, 2000);
        Sorti.Randomich(arr4000, 4000);
        Sorti.Randomich(arr8000, 8000);
        Sorti.Randomich(arr16000, 16000);
        Sorti.Randomich(arr32000, 32000);
        Sorti.Randomich(arr64000, 64000);
        Sorti.Randomich(arr128000, 128000);
        string path = @"C:\asd\note.txt";
        using (StreamWriter fstream = new StreamWriter(path))
        {
            
                Stopwatch stopwatch = new Stopwatch();
            TimeSpan ts;
            string text;
            for (int i = 0; i < 20; i++)
            {
                stopwatch.Start();
                Sorti.Vibor(arr1000);
                stopwatch.Stop();
                Console.WriteLine("Сортировка 1000 = " + stopwatch.ElapsedMilliseconds);
                ts = stopwatch.Elapsed;
                Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                text = stopwatch.ElapsedMilliseconds.ToString();
                fstream.WriteLine(text);
                stopwatch.Reset();
                Sorti.Randomich(arr1000, 1000);
            }
            for (int i = 0; i < 20; i++)
            {
                stopwatch.Start();
                Sorti.Vibor(arr2000);
                stopwatch.Stop();
                Console.WriteLine("Сортировка 2000 = " + stopwatch.ElapsedMilliseconds);
                ts = stopwatch.Elapsed;
                Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                text = stopwatch.ElapsedMilliseconds.ToString();
                fstream.WriteLine(text);
                stopwatch.Reset();
                Sorti.Randomich(arr2000, 2000);
            }
            for (int i = 0; i < 20; i++)
            {
                stopwatch.Start();
                Sorti.Vibor(arr4000);
                stopwatch.Stop();
                Console.WriteLine("Сортировка 4000 = " + stopwatch.ElapsedMilliseconds);
                ts = stopwatch.Elapsed;
                Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                text = stopwatch.ElapsedMilliseconds.ToString();
                fstream.WriteLine(text);
                stopwatch.Reset();
                Sorti.Randomich(arr4000, 4000);
            }
            for (int i = 0; i < 20; i++)
            {
                stopwatch.Start();
                Sorti.Vibor(arr8000);
                stopwatch.Stop();
                Console.WriteLine("Сортировка 8000 = " + stopwatch.ElapsedMilliseconds);
                ts = stopwatch.Elapsed;
                Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                text = stopwatch.ElapsedMilliseconds.ToString();
                fstream.WriteLine(text);
                stopwatch.Reset();
                Sorti.Randomich(arr8000, 8000);
            }
            for (int i = 0; i < 20; i++)
            {
                stopwatch.Start();
                Sorti.Vibor(arr16000);
                stopwatch.Stop();
                Console.WriteLine("Сортировка 16000 = " + stopwatch.ElapsedMilliseconds);
                ts = stopwatch.Elapsed;
                Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                text = stopwatch.ElapsedMilliseconds.ToString();
                fstream.WriteLine(text);
                stopwatch.Reset();
                Sorti.Randomich(arr16000, 16000);
            }
            for (int i = 0; i < 20; i++)
            {
                stopwatch.Start();
                Sorti.Vibor(arr32000);
                stopwatch.Stop();
                Console.WriteLine("Сортировка 32000 = " + stopwatch.ElapsedMilliseconds);
                ts = stopwatch.Elapsed;
                Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                text = stopwatch.ElapsedMilliseconds.ToString();
                fstream.WriteLine(text);
                stopwatch.Reset();
                Sorti.Randomich(arr32000, 32000);
            }
            for (int i = 0; i < 20; i++)
            {
                stopwatch.Start();
                Sorti.Vibor(arr64000);
                stopwatch.Stop();
                Console.WriteLine("Сортировка 64000 = " + stopwatch.ElapsedMilliseconds);
                ts = stopwatch.Elapsed;
                Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                text = stopwatch.ElapsedMilliseconds.ToString();
                fstream.WriteLine(text);
                stopwatch.Reset();
                Sorti.Randomich(arr64000, 64000);
            }
            for (int i = 0; i < 20; i++)
            {
                stopwatch.Start();
                Sorti.Vibor(arr128000);
                stopwatch.Stop();
                Console.WriteLine("Сортировка 128000 = " + stopwatch.ElapsedMilliseconds);
                ts = stopwatch.Elapsed;
                Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                text = stopwatch.ElapsedMilliseconds.ToString();
                fstream.WriteLine(text);
                stopwatch.Reset();
                Sorti.Randomich(arr128000, 128000);
            }
        }

    }
}