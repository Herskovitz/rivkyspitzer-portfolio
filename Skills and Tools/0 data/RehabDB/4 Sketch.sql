/*
Rehab

PatientID int not null identity primary key
PatientFirstName varchar(20) not null, no blank
PatientMiddleName varchar(16) not null, (yes blank)
PatientLastName varchar(24) not null, no blank
DateOfBirth date not null
Gender bit not null
SSN int not null, must be 9 digits
DateAdmitted date, not null
ConditionAdmittedRank int not null 2 or 3
FloorNum int btwn 2 and 4
Room Num int 
DateDischarged date, (yes null)
ConditionDischargedRank int yes (null) 1-4
RecordEntered getdate default

constraint DOB must be earlier than dateadmitted
contraint datedischarged >= dateadmitted or datedishcharged is null
constraint datedischarged cannot be earlier than current date
constraint datedischarge and conditiondischarge both either null or both not null

*/








