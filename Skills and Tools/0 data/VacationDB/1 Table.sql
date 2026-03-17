use VacationDB
go

drop table if exists VacationNote
drop table if exists NoteType
drop table if exists Attraction
drop table if exists Vacation
drop table if exists Person
drop table if exists Transportation
go

create table dbo.Transportation(
    TransportationID int not null identity primary key,
    TransportationMethod varchar(10) not null constraint u_Transportation_method unique
    constraint c_Transportation_must_be_either_car_plane_bus_or_boat check(TransportationMethod in ('Plane','Car','Bus','Boat'))
)

create table dbo.Person(
    PersonId int not null identity primary key,
    LastName varchar(26) constraint u_Person_last_name unique

)

create table dbo.Vacation(
    VacationID int not null identity primary key,
    TransportationID int constraint f_Trasnportation_Vacation foreign key references Transportation(TransportationID),
    PersonId int constraint f_person_vacation foreign key references Person(PersonId),
    VacPlace varchar(40) not null,
    VacStartDate date not null,
    VacEndDate date not null,
)

create table dbo.Attraction(
    AttractionID int not null identity primary key,
    VacationID int constraint f_Vacation_Attraction foreign key references Vacation(VacationID),
    AttractionName varchar(100) not null,
    MoneySpent decimal (7,2) not null
)

create table dbo.NoteType(
    NoteTypeId int not null identity primary key,
    NoteTypeName varchar(20) not null constraint u_Note_Type unique
)

create table dbo.VacationNote(
    VacationNoteId int not null identity primary key,
    VacationNoteDesc varchar(500) not null,
    NoteTypeId int not null constraint f_VacationNote_Note foreign key references NoteType(NoteTypeId),
    VacationId int not null constraint f_VacationNote_Vacation foreign key references Vacation(VacationId),
    constraint u_Note_Vacation unique (NoteTypeId,VacationId)

)