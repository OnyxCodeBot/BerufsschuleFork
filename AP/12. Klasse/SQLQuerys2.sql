--Anzahl Lehrer pro Unterrichtsfach vom SJ 2021
select 
	Fach.bezeichnung, count(distinct Lehrer.l_id) as Anzahl
from
	Fach
	join Unterricht on Unterricht.fach_id = Fach.f_id
	join Lehrer on Lehrer.l_id = Unterricht.lehrer_id
where 
	Unterricht.schuljahr = '2021'
group by 
	Fach.bezeichnung
order by count(Lehrer.l_id) desc


--Alle Lehrer(vname, nname) der Klasse 19ITA die im SJ 2021 AP oder IT Systeme
select
	Lehrer.vname, 
	Lehrer.nname
from
	Lehrer
	join Unterricht on Unterricht.lehrer_id = Lehrer.l_id
	join Fach on Fach.f_id = Unterricht.fach_id
where
	(Fach.bezeichnung = 'AP' or Fach.bezeichnung = 'IT Systeme') and
	Unterricht.schuljahr = '2021' and
	Unterricht.klassen_id = '19ITA'

--Variante 2
select 
	distinct vname, 
	nname
from 
	lehrer, 
	unterricht, 
	fach
where 
	schuljahr = 2021 and 
	klassen_id = '19ITA' and 
	l_id = lehrer_id and 
	fach_id in (select f_id from fach where bezeichnung = 'AP' or bezeichnung = 'IT Systeme')


--Alle Lehrer(vname, nname) die im SJ 2021 nicht das Fach IT Technink unterrichten
select 
	distinct Lehrer.vname, 
	Lehrer.nname
from
	Lehrer
	join Unterricht on Unterricht.lehrer_id = Lehrer.l_id
where
	Unterricht.schuljahr = '2021' and
	Lehrer.l_id not in 
	(	select 
			Lehrer.l_id 
		from 
			Lehrer 
			join Unterricht on Unterricht.lehrer_id = Lehrer.l_id 
			join Fach on Fach.f_id = Unterricht.fach_id 
		where 
			Fach.bezeichnung = 'IT Technik' and 
			Unterricht.schuljahr = 2021)


--Alle Lehrer, die mehr als der Durchschnitt aller Lehrer verdienen
--Sortierung nach Gehalt absteigend, Nachnamen aufsteigend

select 
	mgehalt,
	nname,
	vname
from
	Lehrer
where 
	mgehalt > (select avg(mgehalt) from Lehrer)
order by
	mgehalt desc,
	nname asc