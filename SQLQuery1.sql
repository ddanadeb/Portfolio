Use master;
go
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name= 'Oprema' )
DROP DATABASE Oprema;
go
use Oprema
go 

CREATE TABLE IdentitetKupca (
KupacID int primary key,
Ime nvarchar (30) NOT NULL,
Prezime nvarchar(30) NOT NULL,
Telefon int NOT NULL,
Email nvarchar(30) NOT NUll,
Adresa nvarchar(50) NOT NULL)

CREATE TABLE Zaposleni (
ZaposleniID int primary key,
Ime nvarchar (30) NOT NULL,
Prezime nvarchar (30) NOT NULL,
Telefon int NOT NULL,
Email nvarchar (30) NOT NULL,
ProdavnicaID int primary key )

CREATE TABLE Proizvodi (
ProizvodiID int primary key 
ime_proizvoda nvarchar (30) NOT NULL,
KategorijaID int primary key,
BrendID int primary key 
cenovnik nvarchar (50) NOT NULL)

CREATE TABLE Narudzbina (
NarudzbinaID int primary key
Datum date NOT NULL,
KupacID int primary key )

CREATE TABLE NaruceniProizvodi (
NarudzbinaID int primary key
ProizvodID int primary key
Kolicina int NOT NULL,
Cena int NOT NULL )

CREATE TABLE Kategorije (
KategorijaID int primary key
ime_kategorije nvarchar (20) NOT NULL )

CREATE TABLE Brendovi (
BrendID int primary key
ime_brenda nvarchar (20) NOT NULL )

CREATE TABLE Skladiste (
ProizvodID int primary key 
ime_proizvoda nvarchar (30) NOT NULL )

CREATE TABLE Prodavnice (
ProdavnicaID int primary key
ime_prodavnice nvarchar (30) NOT NULL, 
Adresa nvarchar (50) NOT NULL ) 

















