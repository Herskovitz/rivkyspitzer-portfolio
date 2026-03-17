-- SM Excellent! 100% Now its neat code. See comment
use RehabDB
go

delete Rehab
go

Insert Rehab(PatientFirstName,PatientLastName,PatientMiddleName,DateOfBirth,Gender,SSN,DateAdmitted,ConditionAdmittedRank,FloorNum,RoomNum,DateDischarged,ConditionDischargedRank)
select case when p.FirstName like '% %' 
    then substring(p.FirstName,1,charindex(' ',p.FirstName)-1)
    else p.FirstName end,
p.LastName,
-- SM Use len() for last argument in substring()
case when p.FirstName like '% %'
    then substring(p.FirstName,charindex(' ',p.FirstName) + 1,len(p.FirstName))
    else '' end,
p.DateBorn,
'M',
concat(p.TermStart,isnull(p.NumOfFullTermsServed,0),year(p.DateBorn)),
dateadd(year,p.Num,p.DateBorn),
case
    when p.FirstName like '% %' then 2
    else 3
    end,
case 
    when p.TermStart - year(p.DateBorn) < 50 then 2
    when p.TermStart - year(p.DateBorn) between 50 and 65 then 3
    else 4
    end,
p.TermStart - year(p.DateBorn),
case 
    when p.Party not in ('Democrat','Republican') 
    or p.AgeAtDeath between 70 and 73 or p.AgeAtDeath between 50 and 58 or p.AgeAtDeath between 75 and 77
    then datefromparts((p.TermStart + 10),1,7)
    else null
    end,
case
    when p.Party not in ('Democrat','Republican') then 1
    when p.AgeAtDeath between 50 and 58 and p.Party in ('Democrat','Republican') then 2 
    when p.AgeAtDeath between 70 and 73 and p.Party in ('Democrat','Republican') then 3
    when p.AgeAtDeath between 75 and 77 and p.Party in ('Democrat','Republican') then 4
    else null
    end
from RecordKeeperDB.dbo.president p
