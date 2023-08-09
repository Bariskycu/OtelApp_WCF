

Select * from MutfakUrunleri
Where year(gelisTarihi)='2018'


/*report wiever  bu hafta sisteme girenler*/
 SELECT KullaniciBilgileriId, Ad, Soyad, Telefon, Email, kullaniciAdi, kullaniciSifre, girisTarihi FROM dbo.kullaniciBilgileri where girisTarihi>=DATEADD(wk,DATEDIFF(wk,0,GETDATE()),0)
and girisTarihi<DATEADD(wk,1,DATEADD(wk,1,DATEADD(wk,DATEDIFF(wk,0,GETDATE()),0)))

