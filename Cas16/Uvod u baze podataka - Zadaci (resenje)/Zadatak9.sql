select distinct s.naziv
from polaznik p, kurs k, skola s, pohadja po
where k.naziv ='C napredni B' and k.kursId = po.kursId
and po.polaznikId = p.polaznikId and p.skolaId = s.skolaId;