create procedure TariheGoreSiparis
@begdate as date='20190101',
@enddate as date='20191230'
as
begin
select Musteri.ad_soyad as 'Ad Soyad',Urun.urun_icerik as 'Ürün Ýçeriði'
		,Siparis.tarih as 'Sipariþ Verilen Tarih'

from Siparis
join Musteri on Siparis.musteri_no=Musteri.musteri_no
join Urun on Siparis.urun_kodu=urun.urun_kodu
where Siparis.tarih between @begdate and @enddate
order by Siparis.tarih
end

TariheGoreSiparis '201910'