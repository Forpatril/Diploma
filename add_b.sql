create proc add_b_res
 @h int,
 @wc float, 
 @pt float, 
 @w float, 
 @ss float, 
 @si float
as
	
	insert into tblbilateral
	values (@h, @wc, @pt, @w, @ss, @si);
