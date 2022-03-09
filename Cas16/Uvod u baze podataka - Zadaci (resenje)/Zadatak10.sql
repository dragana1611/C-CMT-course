select count(*)
from polaznik p, kurs k, pohadja po
where k.kursId = po.kursId and k.naziv = 'OOP C#'
and po.polaznikId = p.polaznikId and p.ime LIKE 'A%'