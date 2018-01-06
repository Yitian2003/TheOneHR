
alter View V_ExamList
as
select c.Major_name, d.Major_kind_name, COUNT(*) as Number, a.Emr_no from Engage_exam a
inner join Engage_major_release b
on a.Emr_no = b.Id
inner join Config_major c
on b.Cm_no = c.Id
inner join Config_major_kind d
on c.Cmk_no = d.Id
group by c.Major_name, d.Major_kind_name, a.Emr_no

create View V_ExamSubject
as
select c.First_kind_name, b.Second_kind_name, count(*) as Number from Engage_subject a
inner join Config_question_second_kind b
on a.Cqsk_No = b.Id
inner join Config_question_first_kind c
on b.Cqfk_no = c.Id
group by c.First_kind_name, b.Second_kind_name




