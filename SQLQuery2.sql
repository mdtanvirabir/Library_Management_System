CREATE TABLE Borrowers(
BorrowerId int IDENTITY(500,1) PRIMARY KEY NOT NULL,
FirstName varchar(50) NOT NULL,
LastName varchar(50) NOT NULL,
MiddleName varchar(30) NOT NULL,
Address varchar(40) NOT NULL,
Gender bit NOT NULL,
ContactNo varchar(20) NOT NULL
)