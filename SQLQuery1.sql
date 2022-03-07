create database tdiefm
use tdiefm
create table personne (CIN int primary key , NOM  varchar(20),
Prenom varchar(20),age float   , tel int )
insert into personne values(3,'abamni','khadija',31,658749224)
select * from personne ;