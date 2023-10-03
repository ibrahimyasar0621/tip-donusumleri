using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace tip_donusumleri;

class Program
{
    static void Main(string[] args)
    {
        //implicit Conversion(bilinsiz dönüşüm)
        byte a = 5;                     // 1 byte yer tutar      0 ile 255 arasında değer alır.
        sbyte b =30 ;                   // 1 byte yer tutar   -128 ile 127 arasında değer alır.
        short c = 10;                   // 2 byte yer tutar -32768 ile 32767 arasında değer alır.

        int d = a+b+c;                // ÇIKTI=45 burada verilen değerleri topladı integerin kapasitesi yukarıdakilerin kapasitesinde büyük. int 4byte
        Console.WriteLine("d;" + d);  // ÇIKTI=  d;45  burada d; dnoktallı virgül ifadesii ile d değerin birleştirdi.
        long h = d;
        Console.WriteLine("h;" + h);  // ÇIKTI= h;45 long un kapasitesi integerin kapasitesinden büyük. long 8 byte
        float i = h;                            
        Console.WriteLine("i;" + i);  // ÇIKTI=i;45 float ın kapasitesi long un kapasitesinden büyük. reel sayı 4 byte

        string e = "ibrahim";         // string sınırsıız tanımlanıyor     
        char f = 'k';                 // char tek
        object g = e + f + d;         // object e her çeşit veri atanabilir mesela(int, char, decimel, string)
        Console.WriteLine("g;" + g);  // ÇIKTI=  g;ibrahim45  sring+char+int  birleştirdi.

        //explicit Conversion(bilinçli dönüşüm)
        Console.WriteLine("************EXPLİCİT CONVERSİON**********");
        
        int x =4;
        byte y = (byte)x;             // eğer byte y = x; yazsaydım(int byte a döniştürülemez) hatası verirdi.hata vermesin diye x değerini byte cinsinden yazmasını istedik.
        Console.WriteLine("y;" + y);  //ÇIKTI= 4

        int j =100;
        byte k = (byte)j;             // int olarak yazılan j değerini byte olan k ile yazdık . j yi de byte kest ettik.
        Console.WriteLine("k;" + k);  // ÇIIKTI= 100

        float w = 10.9f;
        byte v = (byte)w;             // bu floatı benim için byte kest et dedik
        Console.WriteLine("v;" + v);  // ÇIKTI= 10 float reel sayı, byte tam sayı olduğu iiçn 10.3 ü  10 olarak aldı. Bu yüzden çevirimlerde veri kaybını göze almak gerekiyor
        
        //****ToString***** çevirim metodu aslında aldığı veriyi stringe kest eder
        Console.WriteLine("******************ToString********************");
        int xx = 6;
        string yy = xx.ToString();    //yukarıdaki xx integer değişkenini stringe çevir
        Console.WriteLine("yy" +yy);  //ÇIKTI=yy6 "yy" ekleme sebebimiz terminaylde kafamız karışmasın diye. normalde çıktıı sadece 6. bunu yy ile birleştiriyor diye yy6 çıkıyor

        string zz = 12.5f.ToString();
        Console.WriteLine("zz" +zz);   //ÇIKTI=zz12.5

        //System.Convert
        Console.WriteLine("******************System.Convert sınıfı********************");
        string s1 ="10", s2="20";     // bu satırda 2 değişken tanımladı atamasınıda yaptık ama tek bir veri tipi (string) kullandık. 
        int sayı1, sayı2;
        int Toplam;

        sayı1 = Convert.ToInt32(s1);
        sayı2 = Convert.ToInt32(s2);
        Toplam = sayı1 + sayı2;
        Console.WriteLine("Toplam;" + Toplam);

        //PARSE    // yeni bir kod bloğu oluşturduk çünkü değişkenleri tükettik. Y eni kod bloğu açarsan istediğin değişkeni teklrar kullanabilirsin.
        Console.WriteLine("******************PARSE METODU********************");
        ParseMethod();
    }
    public static void ParseMethod()      //static dersen ancak static metodlar içindeki metodlar kullanılabilir  VOID dersk geriye dönmeyceğini belirttik çünkü yukarıdaki gibi sasdece konsola yazdırma işini yapacağız. 
    {
        string metin1 = "10";
        string metin2 = "10.25";
        int rakam1;
        double double1;
        rakam1 = Int32.Parse(metin1);   // string bir değişkeni PARSE  kullanarak integer bir değişkee çevirdik. PARSE string ifadeleri çevirmede kullanılır.
        double1 = Double.Parse(metin2);

        Console.WriteLine("rakam1;" +rakam1);
        Console.WriteLine("double1;" +double1);


       
    }
    
}
