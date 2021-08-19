## Amaç
Program yazarken bazı durumlarda belirli diziler içinde sırayla gezinmeye ihtiyaç duyarız. Bu gibi durumlarda **foreach** döngü yapısını kullanabiliriz. Bu sorumuzda da foreach döngü yapısının nasıl kullanıldığını açıklıyacağız.


## Gereksinim
Bu örneği anlayabilmek için **C#.NET** hakkında ön bilgiye sahip olmanız yeterlidir. Örneğin içerisinde **if-else** kontrol yapısı, **List** yapısı ve **class** yapısı kullanılmıştır.
- **If-Else** yapısı ilgili detaylı kullanımı anlatan eğitim videomuza **[buradan](http://www.google.com/)** erişebilirsiniz.
- **Class** yapısı ilgili detaylı kullanımı anlatan eğitim videomuza **[buradan](http://www.google.com/)** erişebilirsiniz.
- **List** yapısı ilgili detaylı kullanımı anlatan eğitim videomuza **[buradan](http://www.google.com/)** erişebilirsiniz.

## Ön Bilgi
E-Ticaret sitelerindeki online tahsilat ekranlarında müşteri tarafından girilen 16 haneli kredi kartı numarasının ilk 6 hanesi, kartın BIN numarasıdır (Bank Identification Number). BIN numarası, kartın ait olduğu banka (Akbank,Garanti,Vakıfbank vb), kart programı (Bonus, Axess, Fix vb), VISA / Mastercard / American Express ayrımı, Kredi Kartı / Banka Kartı ayrımı ve Bireysel / Ticari Kart ayrımlarının tespit edilmesine imkan sağlayan global bir koddur. Her bankanın kendi kart programlarına özel taksit imkanları sunmaktadır. Örneğin **Finansbank**'a ait **CardFinans** kredi kartına **12** taksit imkanı sağlarken aynı bankanın **FIX** kartına en fazla **4** taksit imkanı sağlayabilmektedir.


## Soru
E-Ticaret platformumuzun online ödeme ekranında müşterinin girdiği kart numarasını alarak, ilgili karta en fazla kaç taksit imkanı sağladığını öğrenip müşteriye dönen kod bloğundaki eksik kısmı tamamlayaınız.


## Derleme ve Test
Kod bloğun içerisinde örnek olarak rastgele 10 adet BIN numarası listesi oluşturularak ve her bir kartın en fazla taksit imkanı verdiği bilgisi yer almaktadır.Bu listeyi kullanarak hangi kartın kaç taksit yaptığı bilgisine ulaşabilirsiniz. Projeyi derleyip çalıştırdıktan sonra aşağıdaki değerleri girerek karşılık gelen sonuşları almanız gerekmektedir.
- Ekrana **435508** değerini girdiğinizde "**Kredi kartınıza 6 taksit imkanı sunulmaktadır.**" şeklince çıktı almanız gerekmetedir.
- Ekrana **552645** değerini girdiğinizde "**Kredi kartınıza 2 taksit imkanı sunulmaktadır.**" şeklince çıktı almanız gerekmetedir.
