insert into predavac
values
('Milan', 'Milić', 1234321)

insert into predaje
values
((select predavacId from predavac where ime = 'Milan' and prezime='Milić'),
(select kursId from kurs where naziv = 'C napredni B'))