create procedure MusteriUrunSP

as
begin
select Musteri.ad_soyad as 'Ad Soyad',urun.urun_icerik as 'Ürün'
from Musteri
join siparis on musteri.musteri_no=siparis.musteri_no
join urun on siparis.urun_kodu=urun.urun_kodu
end