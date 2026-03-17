-- SM Excellent! 100% See comment, no need to resubmit.
use RehabDB
go
drop table if exists Rehab
go
create table dbo.Rehab(
    PatientID int not null identity primary key,
    PatientFirstName varchar(20) not null constraint c_Rehab_patient_first_name_cannot_be_blank check(PatientFirstName > ''),
    PatientLastName varchar(24) not null constraint c_Rehab_patient_last_name_cannot_be_blank check(PatientLastName > ''),
    PatientMiddleName varchar(16) not null default '',
    DateOfBirth date not null,
    Gender char(1) not null constraint c_Rehab_gender_can_only_be_M_or_F check(Gender in('M','F')),
-- SM Change data type to char(9) because int will remove leading 0s
    SSN char(9) not null constraint c_Rehab_SSN_must_be_nine_digits check(SSN like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    DateAdmitted date not null,
    ConditionAdmittedRank int constraint c_Rehab_condition_admitted_rank_must_be_either_2_or_3 check(ConditionAdmittedRank in (2,3)),
    FloorNum int not null constraint c_Rehab_floor_num_must_be_either_2_3_or_4 check(FloorNum in (2,3,4)),
    RoomNum int not null constraint c_Rehab_room_num_must_be_greater_than_zero check(RoomNum > 0),
    DateDischarged date constraint c_Rehab_date_discharged_cannot_be_earlier_than_current_date check(DateDischarged <= getdate()),
    ConditionDischargedRank int constraint c_condition_discharged_rank_must_be_a_number_from_1_through_4_or_no_record check(ConditionDischargedRank between 1 and 4),
    DateRecorded datetime not null default getdate(),
    ConditionAdmitted as case when ConditionAdmittedRank = 2 then 'Minor Loss of Functionality' when ConditionAdmittedRank = 3 then 'Major Loss of Functionality'end persisted,
    ConditionDischarged as case when ConditionDischargedRank = 1 then 'Good Health' when ConditionDischargedRank = 2 then 'Minor Loss of Functionality' 
    when ConditionDischargedRank = 3 then 'Major Loss of Functionality' when ConditionDischargedRank = 4 then 'Deceased' end persisted,
    constraint c_Rehab_date_of_birth_must_be_earlier_than_date_admitted check(DateAdmitted >= DateOfBirth),
    constraint c_Rehab_if_date_discharged_is_recorded_then_must_be_on_or_later_than_date_admitted check(DateDischarged >= DateAdmitted or DateDischarged is null),
    constraint c_Rehab_date_discharged_and_condition_discharged_must_both_either_be_blank_or_have_value check((DateDischarged is null and ConditionDischargedRank is null) 
    or (DateDischarged is not null and ConditionDischargedRank is not null))
    )
