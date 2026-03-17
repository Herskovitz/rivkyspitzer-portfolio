use CarDB
go

delete Trip
delete Car
delete Person
delete Autoclass
go

Insert AutoClass(AutoClassName)
select 'Minicompact'
union select 'Subcompact'
union select 'Compact'
union select 'Mid-size'
union select 'Large'
union select 'Two-seater'
union select 'Minivan'
union select 'Small SUV'
union select 'Standard SUV'


Insert Person(LastName)
select 'Smith'
union select 'Jefferson'
union select 'Friedman'
union select 'Jones'

insert Car (PersonID, AutoClassID, Make,Model,MakeYear,Price,Used)
select p.PersonID, (select a.AutoclassID from AutoClass a where a.AutoClassName = 'Minicompact'), 'Toyota','Camry',2019,20000,0 from Person p where p.LastName = 'Smith'
union select p.PersonID,(select a.AutoclassID from AutoClass a where a.AutoClassName = 'Two-seater'), 'Ford','Mustang',2020,35000,0 from Person p where p.LastName = 'Smith'
union select p.PersonID,(select a.AutoclassID from AutoClass a where a.AutoClassName = 'Compact'), 'Honda','Accord',2016,13000,1 from Person p where p.LastName = 'Smith'
union select p.PersonID,(select a.AutoclassID from AutoClass a where a.AutoClassName = 'Standard SUV'), 'Jeep','Wrangler',2021,40000,0 from Person p where p.LastName = 'Jefferson'
union select p.PersonID,(select a.AutoclassID from AutoClass a where a.AutoClassName = 'Minivan'), 'Honda','Odyssey',2015,25000,1 from Person p where p.LastName = 'Jefferson'
union select p.PersonID,(select a.AutoclassID from AutoClass a where a.AutoClassName = 'Minivan'), 'Toyota','Sienna',2022,46000,0 from Person p where p.LastName = 'Friedman'
union select p.PersonID,(select a.AutoclassID from AutoClass a where a.AutoClassName = 'Subcompact'), 'Tesla','Model 3',2022,23000,0 from Person p where p.LastName = 'Friedman'
union select p.PersonID, null, 'Hyundai','Elantra',2021,13500,1 from Person p where p.LastName = 'Friedman'

Insert Trip(CarID, Destination, DateStart, DateEnd, MilesTraveled)
select 
      case
      when s.StateCode like 'A%' then (select c.CarId from Car c where c.Make = 'Honda' and c.MakeYear = 2015)
      when s.StateCode like 'N%' then (select c.CarId from Car c where c.Make = 'Tesla' and c.MakeYear = 2022)
      else (select c.CarId from Car c where c.Make = 'Jeep' and c.MakeYear = 2021)
      end,
       s.StateName, 
       case when s.StateCode like 'a%' then '01-20-1999' when s.StateCode like 'n%' then '05-25-2005' else '02-22-2002' end, 
       case when s.StateCode like 's%' then '01-20-2000' when s.StateCode like 'c%' then '09-25-2005' else '02-22-2012' end, 
       case when s.StateCode like 'w%' then 250 when s.StateCode like 'f%' then 500 else 1000 end
from RecordKeeperDB.dbo.states s

;
with x as(
    select RaceName = 'Monaco Grand Prix', Make = 'Tesla', MakeYear = 2022, CarPosition = 1
    union select 'Monaco Grand Prix', 'Hyundai', 2021, 2
    union select 'Monaco Grand Prix', 'Ford', 2020, 3
    union select 'Monaco Grand Prix', 'Honda', 2015, 4
    union select 'Indianapolis 500','Honda',2016,1
    union select 'Indianapolis 500','Toyota',2022,2
    union select 'Indianapolis 500', 'Jeep', 2021, 3
)

insert CarRace (CarId, RaceId, CarPosition)
select c.CarId, r.RaceId, x.CarPosition
from x
join Car c
on c.Make = x.Make
and c.MakeYear = x.MakeYear
join Race r
on r.RaceName = x.RaceName
