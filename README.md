# İngilizce-Türkçe Sözlük

#İngilizce-Türkçe Sözlük Uygulaması 

Projemiz C# tabanlı ,veritabanı Sql Server Management tarafından sağlanan bir kelime oyunudur.

#Modüller
-Kullanıcı Kayıt, şifremi unuttum ve giriş bölümlerini barındırır.
-Kelime Ekleme özelliği barındırır.(İngilizce kelime, Türkçe karşılığı, İngilizce kelimenin birden çok cümle içerisinde geçmesi, Kelime ile ilgili bir resim)
-Sınav modülünü barındırır:
Temel 6 Sefer Quiz Sorularının Belirlenme Algoritması: Bir soruyu hakkı ile bilmesi için altı kez üst üste doğru cevabı işaretlemesi lazım. Eğer 6 kez aynı soru için doğru cevabı vermez ise, süreç o soru için başa döner ve 6 kez aynı soru için doğru cevabı vermesi beklenir. Bilinen bir sorunun testte öğrenciye sorulması için kullanılacak zaman aralığı; 1 gün sonra, 1 hafta sonra,1 ay sonra,3 ay sonra,6 ay sonra ve 1 yıl sonra. Eğer 6 farklı zamanda da aynı soruyu doğru olarak bilmiş isek o zaman o soruyu soru havuzundan bilinen soru havuzuna taşı. Sınıfta verilen örnekler harici, bir örnek aşağıda verilmiştir.
08.02.2024 (Çarşamba) günü.
İlk on soru 8,12,13,33,54,55,86,87, 19, 10 -> Bu sorulardan 8,12,86,87,19 numaralı kelimeleri 08.03.2022 tarihinden doğru cevapladı.
09.02.2024 (Perşembe) günü.
Dünden bilinen kelimeler yani 8,12,86,87,19 numaralı kelimeler ile rast gele seçilen dün bildiği kelimeler hariç 10 kelime daha eklensin yani ezberlemesi için gelecek 2,5,6,78,45,14,56,57,80,81.
Öğrenci dün bildiği 5 kelimeden bu sefer 3 tanesini yani 8,12,87 numaralı kelimeleri bildi ve bugün karşılaştığı 45,14,56,57,80,81 numaralı kelimeleri bilsin.
15.02.2024 (Çarşamba Günü)Bir önceki haftadan bildiği kelimeler 8,12,87 ve dünden yani 14.03 günü itibari ile bildiği kelimeler ve o güne ait karşısına çıkan rastgele 10 kelime üzerinden aynı mantık ile test olsun.
-Kullanıcı kendi ekranında bulunan ayarlar kısmından yeni kelime çıkma sayısını değiştirebilir.
-Kullanıcı çözümlediği kelimeler üzerinden bir analiz raporu alabilir. Bu raporda da öğrencinin hangi konular ile ilgili yüzdesel olarak ne kadar başarılı olduğunu görebilir. Bu rapor istendiğinde kağıt üzerinden çıktı alınabilir.
-Kullanıcı menüden ayrıca Wordle oyunu ile kelime öğrenimini arttırabilir.
-Kullanıcı menüden ayrıca bir başka oyun olan Word Chian ile kelime öğrenimini arttırabilir.
