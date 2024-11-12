create database Ecomerce;

use Ecomerce;


create table Users(
userId int primary key identity(1,1),
userName varchar(40),
userEmail varchar(40),
userPassword varchar(40)
);


create table Products(
productId int primary key identity(1,1),
productName varchar(40),
prodcutCategory varchar(40),
productPrice varchar(30),
productDescribtion varchar(40)
)

insert into Products values ('Microeave' , 'Kitchen' , 3000 ,'Hight heat quality'),
('Latptop' , 'Electronic' , 50030 ,'intel core i  5 11th'),
('Mobile Iphone' , 'Electronic' , 40000 ,'4k camera'),
('Mobile Samsung' , 'Electronic' , 40000 ,'16gb ram'),
('Heater' , 'Kitchen' , 20000 ,'140 degree')