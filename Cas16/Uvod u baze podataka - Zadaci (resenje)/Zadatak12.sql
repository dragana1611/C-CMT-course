select p.ime, p.prezime, s.naziv, po.ocena
from polaznik p, kurs k, pohadja po, skola s
where k.kursId = po.kursId and k.jezik = 'C'
and po.polaznikId = p.polaznikId and s.skolaId = p.skolaId 
and po.ocena>3