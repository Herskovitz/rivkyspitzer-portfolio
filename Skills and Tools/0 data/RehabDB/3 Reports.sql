-- SM Excellent! 100%
/*Reports: 
1) For government audit: list of all patients discharged, presented as: last name, first name, date of admit, date of discharge, condition upon admit and discharge.
	We want to show our success stories on top, order by condition at discharge
2) For facility admin: show list of patients whose condition deteriorated under our care, include condition descriptions
3) Show me the average days patients stayed at our facility, per condition at admit. For patients that are not discharged yet calculate average days from the current date.
4) Show me the numeric change of condition from admit to discharge and the number of patients with that change.
*/

--1) For government audit: list of all patients discharged, presented as: last name, first name, date of admit, date of discharge, condition upon admit and discharge.
	--We want to show our success stories on top, order by condition at discharge
select PatientLastName,PatientFirstName,DateAdmitted,DateDischarged,ConditionAdmitted,ConditionDischarged
from Rehab r
where r.DateDischarged is not null
order by ConditionDischargedRank

--2) For facility admin: show list of patients whose condition deteriorated under our care, include condition descriptions
select *
from rehab r
where r.ConditionDischargedRank > r.ConditionAdmittedRank

--3) Show me the average days patients stayed at our facility, per condition at admit. For patients that are not discharged yet calculate average days from the current date.
select ConditionAdmittedRank,AvgDaysAtFacility = avg(datediff(day,DateAdmitted,isnull(DateDischarged,getdate())))
from Rehab
group by ConditionAdmittedRank

--4) Show me the numeric change of condition from admit to discharge and the number of patients with that change.
select ChangeOfCondition = ConditionAdmittedRank - ConditionDischargedRank, NumOfPatients = count(*) 
from rehab r
where ConditionDischargedRank is not null
group by ConditionAdmittedRank - ConditionDischargedRank
order by ChangeOfCondition desc


