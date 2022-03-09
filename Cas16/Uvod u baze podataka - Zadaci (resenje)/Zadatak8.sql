select p.ime, p.prezime
from predavac p, predaje pr, kurs k
where p.predavacId = pr.predavacId and
k.kursId = pr.kursId and k.naziv = 'OOP C#'
order by p.prezime desc