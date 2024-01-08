

namespace DateTime_
{
    class Program
    {
        static void Main(string[] arg)
        {
            const int ELEMAN_SAY = 10;
            int[] notlar = new int[ELEMAN_SAY] { 45, 70, 90, 100, 40, 35, 95, 50, 55, 80 };
            int say, enb, enk;
            
             enb=notlar[0];
             enk=notlar[0];
             say = 0;
            foreach (var i in notlar)
            {
                if (enb < i)
                {
                    enb = i;
                }
                if (enk > i)
                {
                    enk = i;
                    
                }

                say += i;

            }
            
            Console.WriteLine($"En büyük not: {enb} En küçük not: {enk}   fark: {enb - enk}   toplam not: {say}");
            Ma();
        }

        public static void Ma()
        {
            const string ALFABE = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ"; 
            string okunan, harf, sonuc = "";
            int pozisyon, say;
            okunan=Console.ReadLine();
            
            for (say = 0; say < okunan.Length; say++){
                harf =okunan. Substring(say, 1);
               pozisyon= ALFABE.IndexOf(harf);
            pozisyon = (pozisyon + 5) % ALFABE.Length;
            sonuc = ALFABE.Substring(pozisyon, 1) + sonuc;
            Console.WriteLine($"harf: {harf} pozisyon: {pozisyon} sonuc: {sonuc} say: {say}");
            
            }
            Console.WriteLine(sonuc);
      
        }
    }
}

