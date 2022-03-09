insert into pohadja
values((select polaznikid from polaznik where ime='Mario' and prezime='Peric'),
(select kursId from kurs where naziv = 'C osnovni A'), 3)