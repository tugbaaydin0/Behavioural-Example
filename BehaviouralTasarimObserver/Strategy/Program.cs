namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eleman eleman1 = new Eleman(new MuhendisIzın(), new MuhendisMaas());
            int muhendisMaas = eleman1.maasHesapla();
            int muhendisIzin = eleman1.izinHesapla();

            Eleman eleman2 = new Eleman(new YoneticiIzin(), new YoneticiMaas());
            int yoneticiMaas = eleman2.maasHesapla();
            int yoneticiIzin = eleman2.izinHesapla();
            
            
            Eleman eleman3 = new Eleman(new TeknisyenIzin(), new TeknisyenMaas());
            int teknisyenMaas = eleman3.maasHesapla();
            int teknisyenIzin = eleman3.izinHesapla();


            Console.WriteLine("Yönetici maaşı: "+yoneticiMaas+"izni: "+yoneticiIzin);
            Console.WriteLine("Muhendis maaşı: "+muhendisMaas+"izin: "+muhendisIzin);
            Console.WriteLine("teknisyen maaşı: "+teknisyenMaas+"izin: "+teknisyenIzin);
        }
    }
}