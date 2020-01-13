
create view "Siparisler" as

select musteri.ad_soyad as 'Ad Soyad',urun.urun_icerik as 'Ürün',siparis.tarih as 'Sipariþ Tarihi'
from Musteri
join Siparis
on Musteri.musteri_no=Siparis.musteri_no
join urun
on urun.urun_kodu=siparis.urun_kodu
group by Musteri.musteri_no,Musteri.ad_soyad,urun.urun_icerik,Siparis.tarih

select * from Siparisler
