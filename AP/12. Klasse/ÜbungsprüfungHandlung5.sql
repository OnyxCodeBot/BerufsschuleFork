--a)
select 
distinct k.*
from Kunde as k
inner join Kunde_Selektionmerkmal as k_s on k_s.Kd_ID = k.Kd_ID
inner join Selektionsmerkmal as s on s.Sel_ID = k_s.Sel_ID
where s.Beschreibung = 'Messe Hamburg' or
	  s.Beschreibung = 'Messefreikarte'

--b)
select k.*
from Kunde as k
inner join Kunde_Selektionmerkmal as k_s on k_s.Kd_ID = k.Kd_ID
inner join Selektionsmerkmal as s on s.Sel_ID = k_s.Sel_ID
where s.Beschreibung = 'Messe Hamburg'
except
select k.*
from Kunde as k
inner join Kunde_Selektionmerkmal as k_s on k_s.Kd_ID = k.Kd_ID
inner join Selektionsmerkmal as s on s.Sel_ID = k_s.Sel_ID
where s.Beschreibung = 'Messefreikarte'

--c)
select 
*
from Kunde as k
left join Kunde_Selektionmerkmal as k_s on k_s.Kd_ID = k.Kd_ID
except
select * from Kunde as k
inner join Kunde_Selektionmerkmal as k_s on k_s.Kd_ID = k.Kd_ID


--d)
select * from Kunde as k
left join Kunde_Selektionmerkmal as k_s on k_s.Kd_ID = k.Kd_ID
left join Selektionsmerkmal as s on s.Sel_ID = k_s.Sel_ID

--e)
select k.Kd_ID, k.Name, count(distinct k_s.Sel_ID)
from Kunde as k
inner join Kunde_Selektionmerkmal as k_s on k_s.Kd_ID = k.Kd_ID
group by k.Kd_ID, k.Name