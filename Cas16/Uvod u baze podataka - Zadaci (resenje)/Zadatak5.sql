select p.ime, p.prezime, k.naziv 
from polaznik p , kurs k, pohadja po
where po.polaznikId = p.polaznikId and po.kursId = k.kursId
order by k.naziv