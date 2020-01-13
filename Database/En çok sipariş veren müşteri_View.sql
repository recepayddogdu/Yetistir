

/*Select top 5 Musteri.ad_soyad as 'Müþteri Adý',count(Siparis.siparis_no) AS Toplam
FROM Musteri
join Siparis
on Musteri.musteri_no=Siparis.musteri_no
Group by Siparis.siparis_no
ORDER BY Toplam desc
*/

alter view "EnCokSiparisVeren"
with encryption
as
Select top 5 Musteri.musteri_no as 'Müþteri Numarasý',Musteri.ad_soyad 'Müþteri Adý',count(*) AS Toplam
FROM Siparis
join Musteri
on Siparis.musteri_no=Musteri.musteri_no
Group by Musteri.ad_soyad,Musteri.musteri_no
order by Toplam desc
--ORDER BY Toplam desc

--select * from EnCokSiparisVeren