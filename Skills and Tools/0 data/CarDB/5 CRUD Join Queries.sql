use CarDB
go

--SELECT
--1) show all person, cars, trips without repeating any columns order by person, car, trip start, end, and miles traveled.
select p.PersonID, p.LastName, c.CarId, c.Make, c.Model, c.MakeYear, c.Price, c.Used, t.TripID, t.Destination, t.DateStart, t.DateEnd, t.MilesTraveled
from Person p
join Car c
on p.PersonID = c.PersonID
join Trip t
on c.CarId = t.CarID
order by p.LastName, c.Make, t.DateStart, t.DateEnd, t.MilesTraveled

--2) Show the number of cars per person.
select p.LastName, CountOfCars = count(*)
from Person p
join Car c
on p.PersonID = c.PersonID
group by p.LastName

--3) Show number of trips per car.
select c.CarId, CountOfTrips = count (*)
from Car c
join Trip t
on c.CarId = t.CarID
group by c.CarId

--4) Show the number of trips per person.
select p.LastName ,NumOfTrips = count(*)
from Person p
join Car c
on p.PersonID = c.PersonID
join Trip t
on c.CarId = t.CarID
group by p.LastName

--5) Show the total amount of miles and days traveled per person.
select p.LastName ,TtlMilesTraveled = sum(MilesTraveled), DaysTraveled = datediff(day,t.DateStart,t.DateEnd)
from Person p
join Car c
on p.PersonID = c.PersonID
join Trip t
on c.CarId = t.CarID
group by datediff(day,t.DateStart,t.DateEnd), p.LastName

--6) Show 1 thru 6 even for people that don't have cars, and cars that don't have trips

--DELETE (repopulate data after deleting)
--1) Delete all trips where the total days traveled were more that three days.
delete t
from Trip t
where datediff(day,DateStart, DateEnd) > 3

--2) Pick a person and delete all his\her trips, then delete his\her cars, then delete the person
delete t
from Person p
join Car c
on p.PersonID = c.PersonID
join Trip t
on t.CarID = t.CarID
where p.LastName = 'Friedman'

delete c
from Person p
join Car c
on p.PersonID = c.PersonID
where p.LastName = 'Friedman'

delete p
from Person p
where p.LastName = 'Friedman'

--3) Delete all cars (and related trips) that were made between 2015 and 2020
delete t
from Car c
join Trip t
on c.CarId = t.CarID
where c.MakeYear between 2015 and 2020

delete c
from Car c
where c.MakeYear between 2015 and 2020

--4) Pick one person and delete all his\her trips
delete t
from Person p
join Car c
on p.PersonID = c.PersonID
join Trip t
on c.CarId = t.CarID
where p.LastName = 'Friedman'

--UPDATE
--1) Increase the prices of all cars made in 1900's by 10%.
update c
set c.Price = c.Price * 1.1
from Car c
where c.MakeYear between 1900 and 1999

--2) For each trip add the name of the car to the trip destination in parenthesis
update t
set t.Destination = concat(t.Destination, ' (', c.Make,' ',c.Model,')')
--select TripSummary = concat(t.Destination, ' (', c.Make,' ',c.Model,')')
from Car c
join Trip t
on c.CarId = t.CarID

--3) Pick one person and double the amount of miles traveled.
update t
set t.MilesTraveled = t.MilesTraveled * 2
--select t.MilesTraveled, t.MilesTraveled * 2
from Person p
join Car c
on p.PersonID = c.PersonID
join Trip t
on c.CarId = t.CarID
where p.LastName = 'Jefferson'

--4) Pick one person and increase all trip end days by 10 days.
update t
set t.DateEnd = dateadd(day,10,DateEnd)
--select t.DateEnd, dateadd(day,10,DateEnd)
from Person p
join Car c
on p.PersonID = c.PersonID
join Trip t
on t.CarID = t.CarID
where p.LastName = 'Friedman'