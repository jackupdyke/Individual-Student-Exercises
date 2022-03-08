USE master
GO

IF DB_ID('PetInfo') IS NOT NULL
BEGIN
	ALTER DATABASE PetInfo SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE PetInfo;
END
GO

CREATE DATABASE PetInfo;
GO

USE PetInfo;
GO

CREATE TABLE Pet (
	Id int IDENTITY PRIMARY KEY,
	Name nvarchar(30) NOT NULL,
	Type  nvarchar(30) NOT NULL,
	Breed  nvarchar(30) NOT NULL,
	Owner int NOT NULL
);

CREATE TABLE Owner(
	Id int IDENTITY(1000,1) PRIMARY KEY,
	Name nvarchar(30) NOT NULL,
	Email nvarchar(30) NOT NULL,
	Address nvarchar(30) NOT NULL,
	Phone nvarchar(30) NOT NULL
);

CREATE TABLE Activity(
	Id int IDENTITY(2000,1) PRIMARY KEY,
	Name nvarchar(30),
	Date datetime,
	Pet int
);

CREATE TABLE Users (
	Id INT IDENTITY PRIMARY KEY,
	Username VARCHAR(255) NOT NULL UNIQUE, -- Username
	Password VARCHAR(48) NOT NULL, -- Password (hashed, not plain-text)
	Salt VARCHAR(256) NOT NULL -- Password Salt
);

SET IDENTITY_INSERT  Pet ON
INSERT INTO Pet (Id, Name, Type, Breed, Owner) VALUES (1, 'Bella', 'dog', 'GSD', 1000);
INSERT INTO Pet (Id, Name, Type, Breed, Owner) VALUES (2, 'Primrose', 'cat', 'DSH', 1001);
INSERT INTO Pet (Id, Name, Type, Breed, Owner) VALUES (3, 'Gabriel', 'cat', 'DSH', 1001);
INSERT INTO Pet (Id, Name, Type, Breed, Owner) VALUES (4, 'Penny', 'cat', 'DSH', 1001);
INSERT INTO Pet (Id, Name, Type, Breed, Owner) VALUES (5, 'Fish01', 'fish', 'Goldfish', 1000);
INSERT INTO Pet (Id, Name, Type, Breed, Owner) VALUES (6, 'Fish02', 'fish', 'Goldfish', 1000);
SET IDENTITY_INSERT  Pet OFF

SET IDENTITY_INSERT  Owner ON
INSERT INTO Owner (Id, Name, Email, Address, Phone) VALUES (1000, 'John', 'John@email.com', '123 Any Street', '6145551234');
INSERT INTO Owner (Id, Name, Email, Address, Phone) VALUES (1001, 'Lisa', 'Lisa@email.com', '123 Any Street', '6145551234');
SET IDENTITY_INSERT  Owner OFF

SET IDENTITY_INSERT Activity ON
INSERT INTO Activity (Id, Name, Date, Pet) VALUES (2000, 'Rabies Vaccination', '2021-06-11', 1)
INSERT INTO Activity (Id, Name, Date, Pet) VALUES (2001, 'Rabies Vaccination', '2022-02-23', 2)
SET IDENTITY_INSERT Activity OFF


ALTER TABLE Pet
WITH CHECK ADD CONSTRAINT FK_PetOwner
FOREIGN KEY (Owner) REFERENCES Owner(Id);

ALTER TABLE Activity
WITH CHECK ADD CONSTRAINT FK_ProceduresPet
FOREIGN KEY (Pet) REFERENCES Pet(Id);
