use CarDB
go

drop table if exists CarRace
drop table if exists Race
drop table if exists Trip
drop table if exists Car
drop table if exists Person
drop table if exists AutoClass
go



create table dbo.AutoClass(
      AutoClassID int not null identity primary key,
      AutoClassName varchar(25) not null constraint u_AutoClass_name unique,

)

create table dbo.Person(
      PersonID int not null identity primary key,
      LastName varchar(26) not null constraint u_Person_Lastname_unique unique
)

create table dbo.Car(
      CarId int not null identity primary key,
      AutoClassID int null constraint f_AutoClass_Car foreign key references AutoClass(AutoClassID),
      PersonID int not null constraint f_Person_Car foreign key references Person(PersonID),
    Make varchar(25),
    Model varchar(25),
    MakeYear int,
    Price decimal(10,2),
    Used bit,
    constraint u_Car_Make_MakeYear unique(Make,MakeYear)
)

create table dbo.Trip(
      TripID int not null identity primary key,
      CarID int not null constraint f_Car_Trip foreign key references Car(CarID),
      Destination varchar(100) not null,
      DateStart date not null,
      DateEnd date,
      MilesTraveled int


)

create table dbo.Race(
    RaceId int not null identity primary key,
    RaceName varchar(100) not null constraint u_Race_Name unique
)

create table dbo.CarRace(
    CarRaceId int not null identity primary key,
    CarId int not null constraint f_Car_CarRace foreign key references Car(CarId),
    RaceId int not null constraint f_Race_CarRace foreign key references Race(RaceId),
    CarPosition int not null,
    constraint u_CarRace_Car_Race unique(CarId,RaceId),
    constraint u_CarRace_Race_CarPosition unique(RaceId,CarPosition)
)