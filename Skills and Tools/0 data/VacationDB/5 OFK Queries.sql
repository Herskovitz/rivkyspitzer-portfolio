use VacationDB
go

--Reports
--For all reports (as relevant): Show Person Name, Vacation Place, Transportation Method, and Attraction Name. Sort in that order.


--1) Show all vacations that have a transportation method
select v.VacPlace, t.TransportationMethod
from Vacation v
join Transportation t
on v.TransportationID = t.TransportationID
order by v.VacPlace, t.TransportationMethod

--2) Show all transportation methods and how many times each was used
select t.TransportationMethod, AmntOfTimesUsed = count(v.VacationID)
from Transportation t
left join Vacation v
on t.TransportationID = v.TransportationID
group by t.TransportationMethod
order by t.TransportationMethod

--3) Show all people who traveled by boat or plane
select p.LastName, v.VacPlace, t.TransportationMethod
from Person p
join Vacation v
on p.PersonId = v.PersonId
join Transportation t
on v.TransportationID = t.TransportationID
where t.TransportationMethod in ('Boat','Plane')
order by p.LastName, v.VacPlace, t.TransportationMethod

--4) Show all attractions and their methods of transportation. If null show "Local"
select a.AttractionName, TransportationMethod = isnull(t.TransportationMethod,'Local')
from Attraction a
left join Vacation v
on a.VacationID = v.VacationID
left join Transportation t
on v.TransportationID = t.TransportationID
order by t.TransportationMethod, a.AttractionName

--5) Show all transportation methods that were not used
select t.TransportationMethod
from Transportation t
left join Vacation v
on t.TransportationID = v.TransportationID
where v.VacationID is null
order by v.VacPlace, t.TransportationMethod

--6) Show all vacation places that did not use any transportation method
select v.VacPlace
from Vacation v
where v.TransportationID is null
order by v.VacPlace

--7) List the attractions that were reached by bus. Show the vacation place and the attraction name 
select v.VacPlace, t.TransportationMethod, a.AttractionName
from Attraction a
join Vacation v
on a.VacationID = v.VacationID
join Transportation t
on v.TransportationID = t.TransportationID
where t.TransportationMethod = 'Bus'
order by v.VacPlace, t.TransportationMethod, a.AttractionName
