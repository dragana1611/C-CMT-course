select avg(po.ocena)
from polaznik p, kurs k, pohadja po
where k.kursId = po.kursId and k.naziv = 'C osnovni A'
and po.polaznikId = p.polaznikId