insert into Dersler (DersAdi)
values ('Matematik'),('Türkçe'),('Fizik'),('Kimya'),('Biyoloji')
select * from Dersler
insert into Ogrenciler(OgrAdi,OgrSoyadi)
values('Akýn Bora','Kýlýç'), ('Kerim','Uçak'), ('Yasin', 'Çelenk'),('Hamit','Dincel'),('Saffet','Tosun')
select * from Ogrenciler
insert into Ogretmenler (OgrtAdi,OgrtSoyadi)
values ('Esma','Mildan'),('Taner','Ertem'),('Arlin','Çaðlý'),('Ecem','Ertem'),('Oðuz','Kral')
select * from Dersler
select * from Ogrenciler
select * from Ogretmenler
select * from Notlar

insert into Notlarr (DersID,OgrID,Notun)
values (1,1,40),(2,1,50),(3,1,70),(4,1,90),(5,1,100),(1,2,85),(2,2,90),(3,2,60),(4,2,40),(5,2,50),(1,3,70),(2,3,80),(3,3,40),(4,3,40),(5,3,45),(1,4,60),(2,4,80),(3,4,18),(4,4,70),(5,4,100),(1,5,40),(2,5,90),(3,5,70),(4,5,50),(5,5,40)
select * from Notlarr
select * from Dersler
select * from Ogrenciler
select * from Ogretmenler

select * from Notlarr join Ogrenciler
on Notlarr.OgrID = Ogrenciler.OgrID join Dersler on Notlarr.DersID = Dersler.DersID