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
select pr.projnr, count(pe.persnr) as anzahl
from personal as pe join projekt as pr on pe.projnr = pr.projnr
group by pr.projnr
order by anzahl desc

--2.4
select cast(count(projnr) as decimal(5,2)) / cast(count(distinct abtnr) as decimal(5,2)) as mittl_projzahl
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
select cast(count(persnr) as decimal(5,2)) / cast(count(distinct projnr) as decimal(5,2)) as m_pro_proj
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