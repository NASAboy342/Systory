use master;
drop database Systory;
go

CREATE DATABASE Systory;
GO

USE Systory;
GO

CREATE TABLE dbo.Batch (
    Batch INT PRIMARY KEY,
    Year INT
);
GO

CREATE TABLE dbo.Major (
    MajorId INT PRIMARY KEY IDENTITY(1,1),
    MajorName VARCHAR(100) NOT NULL,
    Batch INT FOREIGN KEY REFERENCES dbo.Batch(Batch)
);
GO

insert into dbo.Batch([Batch],[Year])
values(1,2020);
go

insert into dbo.Major([MajorName],[Batch])
values('Computer Science',1);
go
insert into dbo.Major([MajorName],[Batch])
values('English for communication',1);
go

create type dbo.NewBatch as table
(
	[Batch] int,
	[Year] int
)
go

CREATE PROCEDURE dbo.InsertNewBatch
@newBatch [dbo].[NewBatch] readonly
as
begin
	insert into [dbo].[Batch]
	(
		[Batch],
		[Year]
	)
	select
		[Batch],
		[Year]
	from @newBatch;
end
go