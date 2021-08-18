using System;

namespace SampleQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sepetTutari;
            decimal odenecekTutar;
            Console.WriteLine("Sepet tutarını giriniz.");
            sepetTutari = decimal.Parse(Console.ReadLine());

            if (sepetTutari < 100)
            {
                Console.WriteLine("İndirim kazanamadınız. Tahsil edilecek tutar: " + sepetTutari + " ₺");
            }
            else if (sepetTutari < 200)
            {
                odenecekTutar = sepetTutari - (sepetTutari * 10) / 100;
                Console.WriteLine("%10 indirim kazandınız. Tahsil edilecek tutar: " + odenecekTutar + " ₺");

            }
            else if (sepetTutari < 300)
            {
                odenecekTutar = sepetTutari - (sepetTutari * 15) / 100;
                Console.WriteLine("%15 indirim kazandınız. Tahsil edilecek tutar: " + odenecekTutar + " ₺");
            }
            else
            {
                odenecekTutar = sepetTutari - (sepetTutari * 20) / 100;
                Console.WriteLine("%20 indirim kazandınız. Tahsil edilecek tutar: " + odenecekTutar + " ₺");
            }
            Console.ReadKey();
        }
    }
}
