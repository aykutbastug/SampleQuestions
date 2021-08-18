using System;
using System.Collections.Generic;

namespace SampleQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //decimal sepetTutari;
            //decimal odenecekTutar;
            //Console.WriteLine("Sepet tutarını giriniz.");
            //sepetTutari = decimal.Parse(Console.ReadLine());

            //if (sepetTutari < 100)
            //{
            //    Console.WriteLine($"İndirim kazanamadınız. Tahsil edilecek tutar: {sepetTutari} TL");
            //}
            //else if (sepetTutari < 200)
            //{
            //    odenecekTutar = sepetTutari - (sepetTutari * 10) / 100;
            //    Console.WriteLine($"%10 indirim kazandınız. Tahsil edilecek tutar: {odenecekTutar} TL");

            //}
            //else if (sepetTutari < 300)
            //{
            //    odenecekTutar = sepetTutari - (sepetTutari * 15) / 100;
            //    Console.WriteLine($"%15 indirim kazandınız. Tahsil edilecek tutar: {odenecekTutar} TL");
            //}
            //else
            //{
            //    odenecekTutar = sepetTutari - (sepetTutari * 20) / 100;
            //    Console.WriteLine($"%20 indirim kazandınız. Tahsil edilecek tutar: {odenecekTutar} TL");
            //}
            //Console.ReadKey();



            List<BinNumber> binNumbers = new List<BinNumber>();
            binNumbers.Add(new BinNumber() { Bin = "402277", Banka = "FINANSBANK", KartProgrami = "FIX", MaksimumTaksitSayisi = 4 });
            binNumbers.Add(new BinNumber() { Bin = "529572", Banka = "FINANSBANK", KartProgrami = "FIX", MaksimumTaksitSayisi = 12 });
            binNumbers.Add(new BinNumber() { Bin = "535280", Banka = "AKBANK", KartProgrami = "AXESS", MaksimumTaksitSayisi = 9 });
            binNumbers.Add(new BinNumber() { Bin = "435508", Banka = "AKBANK", KartProgrami = "WINGS", MaksimumTaksitSayisi = 6 });
            binNumbers.Add(new BinNumber() { Bin = "435508", Banka = "GARANTİ", KartProgrami = "BONUS", MaksimumTaksitSayisi = 10 });
            binNumbers.Add(new BinNumber() { Bin = "403666", Banka = "GARANTİ", KartProgrami = "BONUS BUSINESS", MaksimumTaksitSayisi = 10 });
            binNumbers.Add(new BinNumber() { Bin = "520097", Banka = "GARANTİ", KartProgrami = "BONUS PLATINUM", MaksimumTaksitSayisi = 3 });
            binNumbers.Add(new BinNumber() { Bin = "540122", Banka = "YAPIKREDİ", KartProgrami = "CLASSIC", MaksimumTaksitSayisi = 9 });
            binNumbers.Add(new BinNumber() { Bin = "491206", Banka = "YAPIKREDİ", KartProgrami = "PLATINUM", MaksimumTaksitSayisi = 6 });
            binNumbers.Add(new BinNumber() { Bin = "552645", Banka = "YAPIKREDİ", KartProgrami = "BUSINESS", MaksimumTaksitSayisi = 2 });


            Console.WriteLine("Kartınızın ilk 6 hanesini giriniz.");
            string binNumarasi = Console.ReadLine();
            int maksimumTaksitSayisi = 0;

            foreach (var number in binNumbers)
            {
                if (number.Bin == binNumarasi)
                {
                    maksimumTaksitSayisi = number.MaksimumTaksitSayisi;
                    break;
                }
            }

            if (maksimumTaksitSayisi == 0)
                Console.WriteLine($"Kredi kartınızın taksit imkanı bulunmamaktadır");
            else
                Console.WriteLine($"Kredi kartınıza {maksimumTaksitSayisi} taksit imkanı sunulmaktadır.");

            Console.ReadKey();
        }
    }

    class BinNumber
    {
        public string Bin { get; set; }
        public string Banka { get; set; }
        public string KartProgrami { get; set; }
        public int MaksimumTaksitSayisi { get; set; }
    }
}


