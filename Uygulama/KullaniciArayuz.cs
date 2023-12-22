using System;

namespace fibonacci_ortalama_hesapla;

internal class KullaniciArayuz
{
    private string cizgi = "--------------------------------------------------------------------------------------";
    
    internal void Giris()
    {
        Basla:
        Console.WriteLine("**************************************************************************************");
        Console.WriteLine("Lütfen ortalamasını almak istediğiniz fibonacci dizisinin uzunluğunu giriniz!");
        Console.WriteLine(cizgi);
        int.TryParse(Console.ReadLine(), out int sayi);

        if (sayi < 1)
        {
            Console.WriteLine("Dizi uzunluğu pozitif bir sayı olmalı! Devam etmek için [Enter] tuşuna basın!");
            Console.ReadLine();
            goto Basla;
        }
        else
        {
            IsYonetim IsYonetim = new IsYonetim(sayi);
            Console.WriteLine($" = {IsYonetim.hesapla()}");
            System.Threading.Thread.Sleep(2000);
            
            TekrarDene:
            Console.WriteLine("Tekrar ortalama hesaplamak ister misiniz? [E] Evet / [H] Hayır");
            Console.WriteLine(cizgi);

            switch (Console.ReadLine().ToLower())
            {
                case "e":
                    goto Basla;
                case "h":
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız!");
                    goto TekrarDene;
            }
        }
    }
}