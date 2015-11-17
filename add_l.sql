create proc add_l_res
 @h int,
 @wc float, 
 @pt float, 
 @perc float
as
	
	insert into tbllpf
	values (@h, @wc, @pt, @perc);
