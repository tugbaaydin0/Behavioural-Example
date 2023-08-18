namespace BehaviouralTasarimObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun Kitap = new Urun1("Kitap", 10.25M);
            Kitap.TakipList.Add(new Uye { E_Mail = "a@a.com" });
            Kitap.TakipList.Add(new Uye { E_Mail = "b@b.com" });
            Kitap.Fiyat = 8.99M;
        
        }
       
    }
}