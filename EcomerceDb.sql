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