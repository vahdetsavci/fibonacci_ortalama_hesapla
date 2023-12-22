namespace fibonacci_ortalama_hesapla;

internal class IsYonetim
{
    private VeriYonetim fibonacci;
    private int derinlik;

    internal IsYonetim(int derinlik)
    {
        fibonacci = new VeriYonetim();
        this.derinlik = derinlik;
    }

    internal float hesapla()
    {
        float sonuc = degerlendir(derinlik);
        if (sonuc < 1)
        {
            return sonuc;
        }
        else
        {
            int[] ints = fibonacci.sayilariBul(derinlik);
            return fibonacci.ortalamaHesapla(ints);
        }
    }

    private float degerlendir(float derinlik)
    {
        switch (derinlik)
        {
            case 1:
                return 0 / 1;
            case 2:
                return (float) 1 / 2;
            default:
                return 1;
        }
    }
}