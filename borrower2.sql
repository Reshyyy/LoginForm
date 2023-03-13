use LoginFormTest;

create table BorrowBook(
id int NOT NULL IDENTITY(1,1) primary key,
std_name varchar (250) not null,
std_number  varchar (250) not null,
std_dept varchar (250) not null,
std_contact bigint not null,
std_email varchar (250) not null,
book_name varchar (1250) not null,
borrow_date varchar (250) not null,
return_date varchar (250)
);

select * from tblUserRegistration
select * from books
select * from AddBorrower
select * from BorrowBook