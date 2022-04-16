create table ogrencibilgi(
ogrenciNo int primary key,
ogrenciAdi varchar(20) not null,
ogrenciSoyadi varchar(20) not null,
ogrenciBolumu varchar(30) not null,
ogrenciSinifi tinyint not null,
ogrenciDogumTarihi date not null);