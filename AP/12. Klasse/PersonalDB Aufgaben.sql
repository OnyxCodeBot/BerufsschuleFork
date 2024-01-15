use PersonalDB_21ITA007

--1.1
select NNAME, VNAME
from Personal
order by nname, vname

--1.2
select *
from Personal
where GEHALT >= 1500
and GEHALT <= 3000

--1.3
select *
from Personal
where nname like '%ei%'
order by PERSNR

--1.4
select *
from Personal
where lower(nname) like '%ma%'
order by nname, vname

--1.5
select *
from Personal
where len(nname) > 4
order by persnr

--1.6
select *
from Personal
where nname is null

--1.7
select *
from Akte
where DATUM > '1998'
and GEHALT > 2800

--1.8
select nname, vname, len(vname) as laenge
from Personal
where substring(nname, 1, 1) >= 'M'
order by laenge desc

--1.9
select persnr, vname, nname, LEN(vname) + LEN(nname) as laenge
from personal
order by laenge

--1.10
select *
from personal
where nname like '_a%'
order by persnr


--2.1
select count(distinct nname)
from Personal

--2.2
select sum(gehalt) as gehaltssumme
from personal

--2.3
select projnr, count(persnr) as anzahl
from Personal
group by projnr
order by anzahl desc

--2.4
select cast(count(projnr) as decimal) / cast(count(distinct abtnr) as decimal) as mittl_projzahl
from Projekt

--2.5
select telefonnr, count(telefonnr) as anzahl
from personal
group by telefonnr
having count(telefonnr) > 1

--2.6
select proj.abtnr, sum(pers.gehalt) as gehaltssumme
from Personal as pers
left join Projekt as proj on proj.projnr = pers.projnr
group by proj.abtnr
order by proj.abtnr

--2.7
select cast(count(persnr) as decimal) / cast(count(distinct projnr) as decimal) as m_pro_proj
from Personal

--2.8
select projnr, sum(gehalt) as gehaelter, count(persnr) as anz_mitarbeiter
from Personal
group by projnr
having
	(count(persnr) > 5) or
	(sum(gehalt) > 3000)
order by projnr

--2.9
select year(datum) as jahr, count(*) as count
from akte
group by year(datum)
order by jahr desc


--3.1
select abt.ABTNAME, pers.VNAME, pers.NNAME, pers.TELEFONNR
from Abteilung as abt
inner join Personal as pers on pers.PERSNR = abt.CHEFNR
order by abt.ABTNAME

--3.2
select pers.PERSNR, pers.NNAME, pers.VNAME, abt.ABTNAME
from personal as pers
inner join Projekt as proj on proj.PROJNR = pers.PROJNR
inner join Abteilung as abt on abt.ABTNR = proj.ABTNR
order by pers.PERSNR

--3.3
select *
from personal
where PERSNR in 
(
select abt.CHEFNR
from Personal as pers
inner join Projekt as proj on proj.PROJNR = pers.PROJNR
inner join Abteilung as abt on abt.ABTNR = proj.ABTNR
where pers.VNAME = 'Heinz'
)

--3.4
select pers.*
from Personal as pers
inner join Projekt as proj on proj.PROJNR = pers.PROJNR
inner join Abteilung as abt on abt.ABTNR = proj.ABTNR
where abt.ABTNR in (
	select abt.abtnr
	from Personal as pers
	inner join Projekt as proj on proj.PROJNR = pers.PROJNR
	inner join Abteilung as abt on abt.ABTNR = proj.ABTNR
	where pers.VNAME = 'Donald')

--3.5
select distinct abt.ABTNAME, abt.BUDGET
from Abteilung as abt
inner join Projekt as proj on proj.BUDGET = abt.BUDGET
order by abt.ABTNAME

--3.6
select a1.persnr, year(a1.DATUM) as jahr
from Akte as a1
inner join Akte as a2 on a2.PERSNR = a1.PERSNR
where year(a1.DATUM) = year(a2.DATUM) and
a1.GEHALT - a2.GEHALT >= 1000

--3.7
select pers1.PERSNR, pers1.VNAME, pers1.NNAME, pers2.PERSNR, pers2.VNAME, pers2.NNAME
from Personal as pers1
inner join Personal as pers2 on pers1.VNAME = pers2.VNAME and pers1.PERSNR != pers2.PERSNR
order by pers1.PERSNR, pers2.PERSNR

--3.8
select pers.PERSNR, pers.VNAME, pers.NNAME, akt.POSITION
from Personal as pers
left join Akte as akt on akt.PERSNR = pers.PERSNR
where pers.NNAME like '%a%'
order by pers.PERSNR, akt.POSITION

--3.9
select abt.ABTNR, abt.ABTNAME, count(proj.PROJNR) as anz_proj
from Abteilung as abt
left join Projekt as proj on proj.ABTNR = abt.ABTNR
group by abt.ABTNR, abt.ABTNAME
order by abt.ABTNR

--3.10
select proj.PROJNR, proj.ABTNR, pers.VNAME, pers.NNAME
from Projekt as proj
left join Abteilung as abt on abt.ABTNR = proj.ABTNR
left join Personal as pers on pers.PERSNR = abt.CHEFNR and pers.PROJNR = proj.PROJNR
order by proj.PROJNR

--3.11
select abt.ABTNR, sum(pers.GEHALT) as gehaltssumme
from Abteilung as abt
left join Projekt as proj on proj.ABTNR = abt.ABTNR
left join Personal as pers on pers.PROJNR = proj.PROJNR
group by abt.ABTNR
order by abt.ABTNR


--4.1
select *
from personal
where persnr not in
(
select pers.persnr
from personal as pers
inner join akte as akt on akt.persnr = pers.persnr
)

--4.2

--4.3

--4.4

--4.5

--4.6

--4.7

--4.8

--4.9

--4.10