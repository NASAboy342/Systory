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

create table dbo.Faculty(
	[FacultyId] int primary key identity(1,1),
	[FacultyName] varchar(100)
);
go

insert into dbo.Faculty(
	[FacultyName]
)
values('Art,Humanities and Languages')
insert into dbo.Faculty(
	[FacultyName]
)
values('Social Sciences')
insert into dbo.Faculty(
	[FacultyName]
)
values('Management & Hotel-Tourism')
insert into dbo.Faculty(
	[FacultyName]
)
values('Science, Engineering & Technologies')
go


CREATE TABLE dbo.Major (
    MajorId INT PRIMARY KEY IDENTITY(1,1),
    MajorName VARCHAR(100) NOT NULL,
	FacultyId int foreign key references dbo.Faculty(FacultyId),
    Batch INT FOREIGN KEY REFERENCES dbo.Batch(Batch)
);
GO

insert into dbo.Batch([Batch],[Year])
values(1,2020);
go

insert into dbo.Major([MajorName],[FacultyId],[Batch])
values('Computer Science',4,1);
go
insert into dbo.Major([MajorName],[FacultyId],[Batch])
values('English for communication',1,1);
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

create type dbo.NewMajor as table
(
	[MajorName] varchar(100),
	[FacultyId] int,
	[Batch] int
)
go

create procedure dbo.InsertNewMajor
@newMajor [dbo].[NewMajor] readonly
as
begin
	insert into [dbo].[Major]
	(
		[MajorName],
		[FacultyId],
		[Batch]
	)
	select
		[MajorName],
		[FacultyId],
		[Batch]
	from @newMajor;
end
go