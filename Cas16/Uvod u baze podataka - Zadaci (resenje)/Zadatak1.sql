insert into polaznik 
values ('Marko','Marković',3,
(select skola.skolaId from skola where skola.naziv = 'Gimnazija Isidora Sekulić'));