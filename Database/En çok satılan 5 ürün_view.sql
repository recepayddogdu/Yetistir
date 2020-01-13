alter view EnCokSatilan5Urun
with encryption
as
Select top 5 Urun.urun_icerik as 'Ürün Adý',count(*) AS Toplam
FROM Siparis
join Urun
on Siparis.urun_kodu=Urun.urun_kodu
Group by Urun.urun_icerik
ORDER BY Toplam desc

