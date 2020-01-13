--CREATE VIEW "EnCokSatilan5Urun" AS

--Select top 5 Urun.urun_icerik as 'Ürün Adý',count(1) AS Toplam
--FROM Siparis
--join Urun
--on Siparis.urun_kodu=Urun.urun_kodu
--Group by Urun.urun_icerik
--ORDER BY Toplam desc

select * from EnCokSatilan5Urun