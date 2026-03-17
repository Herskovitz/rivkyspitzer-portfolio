use VacationDB
go
--In VacationDB add a person without a vacation and a vacation without attractions


--1 Show all people with vacations and attractions, sorted by person last name, vacation place, attraction name
select *
from Person p
join Vacation v
on p.PersonId = v.PersonId
join Attraction a
on v.VacationID = a.VacationID
order by p.LastName,v.VacPlace,a.AttractionName

--2 Show all people, their vacations, and any attractions, sorted same as 1
select *
from Person p
join Vacation v
on p.PersonId = v.PersonId
left join Attraction a
on v.VacationID = a.VacationID
order by p.LastName,v.VacPlace,a.AttractionName


--3 Show number of attractions per vacation place, show zero if no attractions, sort by number of attractions and then by vacation place
select v.VacPlace, NumOfAttractions = count(a.AttractionID)
from Vacation v
left join Attraction a
on v.VacationID = a.VacationID
group by v.VacPlace
order by NumOfAttractions, v.VacPlace

--4 Show number of attractions per person, show zero if no attractions
select p.LastName, NumOfAttractions = count(a.AttractionID)
from Person p
left join Vacation v
on p.PersonId = v.PersonId
left join Attraction a
on v.VacationID = a.VacationID
group by p.LastName
order by NumOfAttractions

--5 Delete the person that has no vacations
delete p
--select *
from Person p
left join Vacation v
on p.PersonId = v.PersonId
where v.VacationID is null

--6 Delete any vacation that has no attractions
delete v
--select *
from Vacation v
left join Attraction a
on v.VacationID = a.VacationID
where a.AttractionID is null
