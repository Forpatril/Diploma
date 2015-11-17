create function b_max ()
returns float
begin
return (select MAX(p_time) as m1 from tblbilateral)
end