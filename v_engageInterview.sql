alter view V_EngageInterview
as 
select a.*, b.Human_name,d.Id as majorId, d.Major_name from dbo.Engage_interview a
inner join Engage_resume b 
on a.Er_no = b.Id
inner join Engage_major_release c
on b.Emr_no = c.Id
inner join Config_major d
on c.Cm_no = d.Id