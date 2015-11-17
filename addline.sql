create procedure add_line
@f varchar(9),
@n varchar(13),
@h int,
@w int,
@pt float,
@ps float,
@p1 float,
@p2 float,
@p3 float
as
insert into Data
values (@f, @n, @h, @w, @pt, @ps, @p1, @p2, @p3);