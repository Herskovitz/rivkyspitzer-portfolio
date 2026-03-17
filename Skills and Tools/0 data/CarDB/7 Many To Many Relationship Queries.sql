--1) List all races and any cars they may have, sort by race and then race position.
select r.RaceId, r.RaceName, c.CarId, c.Make, c.MakeYear, p.LastName, cr.CarPosition
from Race r
left join CarRace cr
on r.RaceId = cr.RaceId
left join Car c
on cr.CarId = c.CarId
left join Person p
on p.PersonID = c.PersonID
order by r.RaceName, cr.CarPosition

--2) Show all cars and how many races it may have been in.
select c.CarId, c.Make, c.MakeYear, NumRaces = count(cr.RaceId)
from Car c
left join CarRace cr
on c.CarId = cr.CarId
group by c.CarId, c.Make, c.MakeYear
order by NumRaces desc

--3) Show all races and how many cars participated in each one.
select r.RaceName, NumOfCars = count(cr.CarId) 
from Race r
left join CarRace cr
on r.RaceId = cr.RaceId
group by r.RaceName
order by NumOfCars desc

--4) Delete all cars from one of the races
delete cr
--select *
from Race r
join CarRace cr
on r.RaceId = cr.RaceId
where r.RaceName = 'Indianapolis 500'
