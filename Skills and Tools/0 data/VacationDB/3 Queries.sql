use VacationDB

--reports 
--1 list person, place, start date, end date. sorted by person lastname and then by place and then by start date
select p.lastname, v.VacPlace, v.VacStartDate, v.VacEndDate
from person p
join vacation v
on p.personID = v.personID
order by p.LastName, v.VacPlace, v.VacStartDate

--2 same as one but only for 2 of the people
select p.lastname, v.VacPlace, v.VacStartDate, v.VacEndDate
from person p
join vacation v
on p.personID = v.personID
where p.LastName in ('Herskovitz','Herman')
order by p.LastName, v.VacPlace, v.VacStartDate

--3 show how many vacations each person took, and the average length of the vacations
select p.LastName ,CountOfVac = count(*), AvgLenOfVac = avg(datediff(day,VacStartDate,VacEndDate))
from person p
join vacation v
on p.personID = v.personID
group by p.LastName

--4 show how many people visited each place
select CountOfPpl = count(*), v.VacPlace
from person p
join vacation v
on p.personID = v.personID
group by v.VacPlace
