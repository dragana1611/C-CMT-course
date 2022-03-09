/*SELECT skolaId FROM dbo.skola Where naziv = 'Gimnazija Isidora Sekulic';*/
/*SELECT * FROM skola,polaznik;*/
/*SELECT p.polaznikId, p.ime, s.naziv FROM polaznik p, skola s WHERE p.skolaId = s.skolaId;*/
/*SELECT k.naziv, p.ime FROM kurs k, predavac p, predaje pr WHERE k.kursId = pr.kursId AND pr.predavacId = p.predavacId;*/
/*SELECT * FROM dbo.kurs;*/
/*SELECT * FROM dbo.skola WHERE naziv = 'Gimnazija Isidora Sekulic';
INSERT INTO dbo.polaznik (ime, prezime, razred, skolaId) 
VALUES ('Marko', 'Markovic',3,3);
SELECT * FROM dbo.polaznik;*/


/*SELECT * FROM dbo.kurs;
SELECT polaznikId, ime, prezime FROM polaznik WHERE ime = 'Stefan' AND prezime = 'Vukanovic';

INSERT INTO pohadja (polaznikId, kursId, ocena)
VALUES (10, 3, 3);
SELECT * FROM pohadja;*/

SELECT polaznikId, ime, prezime FROM polaznik WHERE ime = 'Ognjen' AND prezime = 'Nikolic';
UPDATE polaznik SET razred = 2 WHERE polaznikId = 9;
SELECT * FROM polaznik;