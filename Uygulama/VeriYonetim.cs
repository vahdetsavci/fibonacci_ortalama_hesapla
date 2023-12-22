using System;

namespace fibonacci_ortalama_hesapla;

internal class VeriYonetim
{
    internal int[] sayilariBul(int derinlik)
    {
        int toplam = 0, sayi1 = 0, sayi2 = 1;
        int[] sayilar = new int[derinlik];

        // ilk iki sayı 0 ve 1
        sayilar[0] = sayi1;
        sayilar[1] = sayi2;
        Console.Write($"{sayi1} + {sayi2}");

        for (int i = 2; i < derinlik; i++)
        {
            toplam = sayi1 + sayi2;    // 0 + 1 + 1 + 2 + 3 + 5 + .....
            sayi1 = sayi2;
            sayi2 = toplam;
            Console.Write($" + {toplam}");
            
            sayilar[i] = toplam;
        }
        return sayilar;
    }

    internal float ortalamaHesapla(int[] sayilar)
    {
        int toplam = 0;

        for (int i = 0; i < sayilar.Length; i++)
        {
            toplam += sayilar[i];
        }

        Console.WriteLine($" = {toplam}");
        Console.Write($"{toplam} / {sayilar.Length}");
        return (float) toplam / sayilar.Length;
    }
}