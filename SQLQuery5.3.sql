use SPJTest
--name sherkati ra peida konid ke name shahrash ba name peroje dar hale anjam barabar bashad
select distinct sname
from S,SPJ,J
where spj.s#=s.s# and spj.j#=j.j# and s.city=j.city
--ravesh 2
select sname 
from S
where exists(
select *
from SPJ,J
where j.city=s.city and spj.j#=j.j# and spj.s#=s.s#
)
--ravesh 3
select sname
from S
where s#  in(
select s#
from SPJ,J
where spj.j#=j.j# and spj.s#=s.s# and s.city=j.city
) 
--name sherkati ra peida konid ke name shahrash ba name peroje dar hale anjam barabar bashad va faghat be shahre khodash forush karde bashad
select sname
from S
where s# not in(
select s#
from SPJ,J
where spj.j#=j.j# and spj.s#=s.s# and s.city<>j.city
)
--ravesh2
select sname
from S
where not exists(
select *
from SPJ,J
where spj.j#=j.j# and spj.s#=s.s# and j.city<>s.city
)
--miangin forush mahsul p1 ra begu
select AVG(qty)
from SPJ
group by p#
having p#='p1'
--code sherkati ra begu ke majmu forushe mahsul p1 an as miangin bishtar bashad
select s#
from SPJ
where p#='p1'
group by s# 
having SUM(qty)>7285
--name proje va share an dar surati ke mahsul p1 dar an masraf shode bashad
select distinct jname,city
from SPJ,J
where spj.j#=j.j# and p#='p1'
--ravesh2
select jname,city 
from J
where j# in(
select j#
from SPJ
where spj.j#=j.j# and p#='p1'
)
--ravesh3
select jname,city
from J
where exists(
select j# 
from SPJ
where spj.j#=j.j# and p#='p1'
)
--mizan kole froush
select SUM (qty)
from SPJ
 --moshakhas konid har mahsul chand darsad az kol frush ra darad
 select p#, (SUM(qty)*100)/157567
 from SPJ
 group by p#