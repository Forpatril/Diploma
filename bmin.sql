create function b_min ()
returns float
begin
return (select MIN(p_time) as m1 from tblbilateral)
end