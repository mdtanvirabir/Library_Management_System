CREATE TABLE [dbo].[Book] (
    [BookId]         INT           IDENTITY (400, 1) NOT NULL,
    [BookName]       VARCHAR (50)  NOT NULL,
    [AuthorName]     VARCHAR (50)  NOT NULL,
    [Publisher]      VARCHAR (50)  NOT NULL,
    [PbulishDate]    DATE          NOT NULL,
    [Quantity]       INT           NOT NULL,
    [BookRentAmount] DECIMAL (18)  NOT NULL,
    [ImgPath]        VARCHAR (200) NULL,
    [Available]      BIT           NOT NULL,
    [EmployeeId]     INT           NULL,
    [BorrowerId]     INT           NULL,
    PRIMARY KEY CLUSTERED ([BookId] ASC),
    FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([EmployeeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY ([BorrowerId]) REFERENCES [dbo].[Borrowers] ([BorrowerId]) ON DELETE CASCADE ON UPDATE CASCADE
);

