--1) show a list of people and their cars, do not incudle the same column twice, order by person and then by car
select p.LastName, c.Make, c.Model, c.MakeYear, c.Used
from Person p 
join Car c
on p.PersonID = c.PersonID

--2A) same as number 1 but only for two of the people, order by car then by person
select p.LastName, c.Make, c.Model, c.MakeYear, c.Used
from Person p 
join Car c
on p.PersonID = c.PersonID
where p.LastName in ('Friedman','Jefferson')

--2B) show count of cars per person
select p.LastName ,count(*)
from Person p
join Car c
on p.PersonID = c.PersonID
group by p.LastName

--3) show count of people per car model
select c.Model, count(*)
from Person p
join Car c
on p.PersonID = c.PersonID
group by c.Model

--4) Attempt to delete data in person table
delete Person
where LastName = 'Smith'

--5) Attempt to drop person table
drop table Person