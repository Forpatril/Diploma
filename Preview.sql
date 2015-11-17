use filter 

select * from tblbilateral cross join tblhpf cross join tbllpf

select * from tblbilateral

select MAX(p_time) as m1 from tblbilateral

select MIN(p_time) as m2 from tblbilateral

select distinct height order by p_time asc from tblbilateral

select * from tblhpf

delete from tblhpf where p_time > 1

select * from tbllpf

delete from tbllpf where p_time > 1