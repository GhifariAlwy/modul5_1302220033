// See https://aka.ms/new-console-template for more information
using System;



public class Penjumlahan

{

    public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic total1 = angka1;
        dynamic total2 = angka2;
        dynamic total3 = angka3;
        return total1 + total2 + total3;
    }


    public static void Main(string[] args)

    {
        Penjumlahan penjumlahan = new Penjumlahan();
        string NIM = "1302220033";


        if (NIM.EndsWith("1") || NIM.EndsWith("2"))

        {

            float hasil = penjumlahan.JumlahTigaAngka(float.Parse(NIM.Substring(0, 2)), float.Parse(NIM.Substring(2, 2)), float.Parse(NIM.Substring(4, 2)));
            Console.WriteLine("Hasil penjumlahan: " + hasil);

        }

        else if (NIM.EndsWith("3") || NIM.EndsWith("4") || NIM.EndsWith("5"))
        {
            double hasil = penjumlahan.JumlahTigaAngka(double.Parse(NIM.Substring(0, 2)), double.Parse(NIM.Substring(2, 2)), double.Parse(NIM.Substring(4, 2)));
            Console.WriteLine("Hasil penjumlahan: " + hasil);
        }
        else if (NIM.EndsWith("6") || NIM.EndsWith("7") || NIM.EndsWith("8"))
        {
            int hasil = penjumlahan.JumlahTigaAngka(int.Parse(NIM.Substring(0, 2)), int.Parse(NIM.Substring(2, 2)), int.Parse(NIM.Substring(4, 2)));
            Console.WriteLine("Hasil penjumlahan: " + hasil);
        }

        else if (NIM.EndsWith("9") || NIM.EndsWith("0"))
        {
            long hasil = penjumlahan.JumlahTigaAngka(long.Parse(NIM.Substring(0, 2)), long.Parse(NIM.Substring(2, 2)), long.Parse(NIM.Substring(4, 2)));
            Console.WriteLine("Hasil penjumlahan: " + hasil);
        }
        else
        {
            Console.WriteLine("Format NIM tidak valid.");
        }
    }
}


