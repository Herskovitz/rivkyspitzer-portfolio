use CarDB
go
--In the CarDB add a person without cars, and a car without trips

--1) Show all cars with trips
select * from Car c
join Trip t
on c.CarId = t.CarID

--2) Show all cars and any trips they may have
select * from Car c
left join Trip t
on c.CarId = t.CarID

--3) Same as 2 but do not show any nulls
select Make = isnull(c.Make,''), Model = isnull(c.Model,''), MakeYear = isnull(c.MakeYear, 0), TripID = isnull(t.TripID,0), Destination = isnull(t.Destination, '') from Car c
left join Trip t
on c.CarId = t.CarID
order by c.Model

--4) show all people, cars, and any trips
select p.PersonID, p.LastName, c.CarId, c.Make, c.Model, t.TripID, t.Destination
from Person p
join Car c
on p.PersonID = c.PersonID
left join Trip t
on c.CarId = t.CarID

--5) show all people, any cars, and any trips
select p.PersonID, p.LastName, c.CarId, c.Make, c.Model, t.TripID, t.Destination
from Person p
left join Car c
on p.PersonID = c.PersonID
left join Trip t
on c.CarId = t.CarID

--6) show the following cannot be done: show all people, any cars, but only cars with trips
select p.PersonID, p.LastName, c.CarId, c.Make, c.Model, t.TripID, t.Destination
from Person p
left join Car c
on p.PersonID = c.PersonID
join Trip t
on c.CarId = t.CarID

--7) show the number of cars per person, if no cars then show zero
select p.lastname, count(CarId)
from Person p
left join Car c
on p.PersonID = c.PersonID
group by p.LastName

--8) show people that do not have cars
select *
from Person p
left join Car c
on p.PersonID = c.PersonID
where c.CarId is null