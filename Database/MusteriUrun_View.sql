
--CREATE VIEW "MusteriUrun" AS

--SELECT  Musteri.ad_soyad as 'Ad Soyad', tarih,Urun.urun_icerik as 'Ýçerik'

--FROM Siparis
--JOIN Musteri
--ON Siparis.musteri_no=Musteri.musteri_no
--JOIN Urun
--ON Siparis.urun_kodu=Urun.urun_kodu;

select * from MusteriUrun
