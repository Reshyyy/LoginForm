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

create table BorrowBook2(
id int NOT NULL IDENTITY(1,1) primary key,
std_name varchar (250) not null,
std_number  varchar (250) not null,
std_dept varchar (250) not null,
std_contact bigint not null,
std_email varchar (250) not null,
book_name varchar (1250) not null,
borrow_date datetime not null,
return_date datetime
);

drop table BorrowBook

select * from tblUserRegistration
select * from books
select * from AddBorrower
select * from BorrowBook2

INSERT INTO BorrowBook2 (std_name, std_number, std_dept, std_contact, std_email, book_name, borrow_date, return_date)
VALUES
    ('John Smith', '123456789', 'Biology', 5551234567, 'johnsmith@example.com', 'The Great Gatsby', '2023-03-15', '2023-04-05'),
    ('Jane Doe', '987654321', 'History', 5559876543, 'janedoe@example.com', 'To Kill a Mockingbird', '2023-03-17', '2023-04-07'),
    ('Bob Johnson', '456789123', 'Computer Science', 5554567890, 'bobjohnson@example.com', '1984', '2023-03-19', '2023-04-09'),
    ('Sarah Lee', '321654987', 'Psychology', 5553216540, 'sarahlee@example.com', 'Pride and Prejudice', '2023-03-18', '2023-04-08'),
    ('David Kim', '741852963', 'English', 5557418520, 'davidkim@example.com', 'The Catcher in the Rye', '2023-03-16', '2023-04-06');