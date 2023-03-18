use LoginFormTest

create table tbl_books(
accession_number int NOT NULL IDENTITY(1,1) primary key,
book_title varchar(250) not null,
book_author varchar(250) not null,
book_price bigint not null,
book_quantity bigint not null,
book_purchase_date varchar(250) not null
);

create table tbl_books1(
accession_number int NOT NULL primary key,
book_title varchar(250) not null,
book_author varchar(250) not null,
book_price bigint not null,
book_quantity bigint not null,
book_purchase_date varchar(250) not null
);

select * from tbl_books
select * from tbl_books1
select * from BorrowBook