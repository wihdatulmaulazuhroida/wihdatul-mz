using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan jumlah bilangan Fibonacci yang ingin dihasilkan: ");
        int n = int.Parse(Console.ReadLine());

        Fibonacci(n);
    }

    static void Fibonacci(int n)
    {
        int a = 0, b = 1, next;

        // Cetak dua angka pertama, masing-masing di baris baru
        Console.WriteLine(a);
        Console.WriteLine(b);

        // Menghasilkan deret Fibonacci secara vertikal menggunakan for loop
        for (int i = 2; i < n; i++)
        {
            next = a + b;
            Console.WriteLine(next);  // Cetak setiap angka di baris baru

            a = b;
            b = next;
        }
    }
}