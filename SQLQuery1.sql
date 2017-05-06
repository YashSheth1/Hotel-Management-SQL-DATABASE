create database hotelMGMT;

use hotelMGMT;

create table menu(
sr_no int not null,
Dish varchar(25),
info varchar(100), 
price int,
primary key(sr_no)
);

create table orders(
sr_no int,
amount int,
req varchar(100)
);

create table temp_orders(
sr_n0 int,
amount int,
req varchar(100)
);


insert into menu values(1,'chilli Pasta','chefs special chilli masala to blow your mind',200);

select * from menu;



drop table menu;

