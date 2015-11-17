create proc add_h_res
 @h int,
 @wc float, 
 @pt float, 
 @perc float
as
	
	insert into tblhpf
	values (@h, @wc, @pt, @perc);
