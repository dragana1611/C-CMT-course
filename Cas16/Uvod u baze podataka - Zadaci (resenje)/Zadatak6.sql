delete from predaje where predavacId = 
(select predavacId 
from predavac where ime = 'Marko' and prezime='Tot') and 
kursId = (select kursId from kurs where naziv='C napredni B')

insert into predaje
values
((select predavacId from predavac where ime = 'Marko' and prezime='Tot'),
(select kursId from kurs where naziv = 'OOP C#'))