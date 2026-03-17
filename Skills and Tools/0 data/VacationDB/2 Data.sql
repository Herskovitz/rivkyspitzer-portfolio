use VacationDB 
go

delete VacationNote
delete NoteType
delete Attraction
delete Vacation
delete Person
delete Transportation
go

Insert Transportation(TransportationMethod)
select 'Plane' 
union select 'Car'
union select 'Bus'
union select 'Boat'

Insert Person(LastName)
select 'Herskovitz'
union select 'Friedman'
union select 'Herman'
union select 'Stern'
union select 'Spria'
union select 'Roth'
union select 'Spitzer'
union select 'Turner'
union select 'Schwartz'
union select 'Weiss'
union select 'Menczer'
union select 'Morris'
union select 'Adams'
union select 'Bee'
union select 'Carter'


Insert Vacation(PersonID, TransportationID, VacPlace,VacStartDate,VacEndDate)
select p.PersonID , null, 'Israel', '08-01-2023', '08-20-2023' from Person p where p.LastName = 'Herskovitz'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Plane'),'Florida', '06-14-2023', '06-16-2023' from Person p where p.LastName = 'Friedman'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Car'),'New Hampshire', '07-02-2023', '07-07-2023' from Person p where p.LastName = 'Stern'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Plane'), 'Switzerland', '07-30-2023', '08-10-2023' from Person p where p.LastName = 'Spira'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Car'), 'Catskill Mountains', '06-29-2023', '08-31-2023' from Person p where p.LastName = 'Roth'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Plane'), 'Israel', '08-01-2023', '08-20-2023' from Person p where p.LastName = 'Heskovitz'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Car'), 'Florida', '06-14-2023', '06-16-2023' from Person p where p.LastName = 'Spitzer'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Bus'), 'New Hampshire', '07-02-2023', '07-07-2023' from Person p where p.LastName = 'Stern'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Plane'), 'Switzerland', '07-30-2023', '08-10-2023' from Person p where p.LastName = 'Spira'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Bus'), 'Catskill Mountains', '06-29-2023', '08-31-2023' from Person p where p.LastName = 'Weiss'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Plane'), 'Israel', '08-01-2023', '08-20-2023' from Person p where p.LastName = 'Schwartz'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Plane'), 'Switzerland', '07-30-2023', '08-10-2023' from Person p where p.LastName = 'Menczer'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Bus'), 'Catskill Mountains', '06-29-2023', '08-31-2023' from Person p where p.LastName = 'Herman'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Plane'), 'Israel', '08-01-2023', '08-20-2023' from Person p where p.LastName = 'Turner'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Bus'), 'Morristown', '07-30-2023', '08-10-2023' from Person p where p.LastName = 'Menczer'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Bus'), 'France', '07-30-2023', '08-10-2023' from Person p where p.LastName = 'Menczer'
union select p.PersonID, (select t.TransportationID from Transportation t where t.TransportationMethod = 'Bus'), 'Japan', '07-30-2023', '08-10-2023' from Person p where p.LastName = 'Menczer'


Insert Attraction(VacationID,AttractionName,MoneySpent)
select v.VacationID, 'Helicoper Ride', 5000 from Vacation v where v.VacPlace = 'New Hampshire'
union select v.VacationID, 'Beach', 75 from Vacation v where v.VacPlace = 'Florida'
union select v.VacationID, 'VR', 300 from Vacation v where v.VacPlace = 'Catskill Mountains'
union select v.VacationID, 'Jeeping', 250 from Vacation v where v.VacPlace = 'Israel'
union select v.VacationID, 'Racing', 150 from Vacation v where v.VacPlace = 'Switzerland'
union select v.VacationID, 'Climbing', 400 from Vacation v where v.VacPlace = 'New Hampshire'
union select v.VacationID, 'Roller Blates', 175 from Vacation v where v.VacPlace = 'Florida'
union select v.VacationID, 'Walking', 25 from Vacation v where v.VacPlace = 'Catskill Mountains'
union select v.VacationID, 'Swimming', 50 from Vacation v where v.VacPlace = 'Israel'
union select v.VacationID, 'Flying', 1000 from Vacation v where v.VacPlace = 'Switzerland'


insert NoteType(NoteTypeName)
select 'Praise / Compliment'
union select 'Complaint'
union select 'Suggestion'
union select 'Warning'

;
with x as(
    select LastName = 'Adams', Place = 'Israel', NoteType = 'Praise', NoteText = 'Nice Place'
    union select 'Adams', 'Florida', 'Suggestion', 'Bring your own coffee'
    union select 'Adams', 'France', 'Complaint','They think they are better than Americans'
    union select 'Adams', 'Japan', 'Warning', 'Japanese is hard to speak'
    union select 'Bee', 'New Hampshire', 'Compliment', 'Good tea'
    union select 'Bee', 'Morristown', 'Compliment', 'Sunny and lots of beach'
    union select 'Bee', 'Switzerland', 'Compliment', 'Interesting culture'
    union select 'Carter', 'Catskill Mountains', 'Suggestion', 'Bring boots'
)

insert VacationNote (VacationNoteDesc,NoteTypeId,VacationId)
select x.NoteText, n.NoteTypeId, v.VacationID
from x
join Person p
on x.LastName = p.LastName
join Vacation v
on x.Place = v.VacPlace
join NoteType n
on x.NoteType = n.NoteTypeName
