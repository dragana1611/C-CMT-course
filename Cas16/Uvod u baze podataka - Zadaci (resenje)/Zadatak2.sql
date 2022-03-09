insert into pohadja
values ((select polaznikid from polaznik where ime='Stefan' and prezime='Vukanovic'), 
(select kursId from kurs where naziv = 'C osnovni B'), 3)