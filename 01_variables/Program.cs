namespace _01_variables
{
    class degerlendirme{
        public void deger(int d)
        {
            if (d<100)
            {
                Console.WriteLine("değerimiz 100 den küçüktür");
            }
            else
            {
                Console.WriteLine("değerimiz 100 den büyüktür");
            }
        }
    }
    internal class Program
    {
        static int islem(int a,int b,char c)
        {
            int sonuc=0;
            if (c == '+')
                sonuc = a + b;
            else if (c == '-')
                sonuc = a - b;
            else if (c == '*')
                sonuc = a * b;
            else if (c == '/')
                sonuc = a / b;
            else
                Console.WriteLine("Hatalı Sembol");

            return sonuc;   
        }
        static void Main(string[] args)
        {
            int a=0, b;
            char c;
            
            Console.WriteLine("Lütfen iki sayı giriniz:");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen sayı giriniz:");
            }
           

            b = Convert.ToInt32(Console.ReadLine());

            c = Convert.ToChar(Console.ReadLine());


            int sonuc = islem(a, b, c);
            degerlendirme o1=new degerlendirme();

            degerlendirme2 o2 = new degerlendirme2();

            o2.deger(sonuc);
            o1.deger(sonuc);
        }
    }
}

