create database filter

go
use filter

create table tblbilateral
(
	height int not null,
	width_c float not null,
	p_time float not null,
	window float,
	sigma_s float,
	sigma_i float
)

create table tbllpf
(
	height int not null,
	width_c float not null,
	p_time float not null,
	perc float not null
)

create table tblhpf
(
	height int not null,
	width_c float not null,
	p_time float not null,
	perc float not null
)
go