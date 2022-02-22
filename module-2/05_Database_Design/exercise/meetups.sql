USE [master];
GO

IF DB_ID('meetups') IS NOT NULL
BEGIN
	ALTER DATABASE [meetups] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE [meetups];
END

CREATE DATABASE meetups;
GO

USE meetups;
GO

CREATE TABLE [member] (
	MemberNumber INT NOT NULL,
	LastName NVARCHAR(200) NOT NULL,
	FirstName NVARCHAR(200) NOT NULL,
	EmailAddress NVARCHAR(200) NOT NULL,
	PhoneNumber NVARCHAR(200), 
	Birthday NVARCHAR(200) NOT NULL,
	ReminderEmail BIT NOT NULL
	CONSTRAINT [PK_member] PRIMARY KEY (MemberNumber),
	
);

CREATE TABLE [interestgroup] (
	GroupNumber INT NOT NULL,
	GroupName NVARCHAR(200) NOT NULL,
	MemberNumber INT NOT NULL,
	CONSTRAINT [PK_interestgroup] PRIMARY KEY (GroupName),
	CONSTRAINT [FK_interestgroup_member] FOREIGN KEY (MemberNumber) REFERENCES member (MemberNumber),
	
);

CREATE TABLE [member_interestgroup] (
	MemberNumber INT NOT NULL,
	GroupName NVARCHAR(200) NOT NULL,
	CONSTRAINT [FK_member_interestgroup_member] FOREIGN KEY (MemberNumber) REFERENCES member (MemberNumber),
	CONSTRAINT [FK_groupname_interestgroup] FOREIGN KEY (GroupName) REFERENCES interestgroup (GroupName),
	
);

CREATE TABLE [event] (
	EventNumber INT NOT NULL,
	Name NVARCHAR(200) NOT NULL,
	Description NVARCHAR(200) NOT NULL,
	StartDateTime DATE NOT NULL,
	Duration INT NOT NULL,
	GroupName NVARCHAR(200) NOT NULL,
	CONSTRAINT [PK_event] PRIMARY KEY (EventNumber),
	CONSTRAINT [FK_event_interestgroupname] FOREIGN KEY (GroupName) REFERENCES interestgroup (GroupName),
	CONSTRAINT [CHK_event] CHECK (Duration >= 30)
);

CREATE TABLE [member_event] (
	MemberNumber INT NOT NULL,
	EventNumber int NOT NULL,
	CONSTRAINT [FK_member_event_member] FOREIGN KEY (MemberNumber) REFERENCES member (MemberNumber),
	CONSTRAINT [FK_member_event_event] FOREIGN KEY (EventNumber) REFERENCES event (EventNumber),
	
);


-- insert data into member


INSERT INTO [member] (MemberNumber, LastName, FirstName, EmailAddress, PhoneNumber, Birthday, ReminderEmail) VALUES (1, 'Manning', 'Peyton', 'pmanning@nfl.com', '888-888-1234', '03/01/1965', 'True')
INSERT INTO [member] (MemberNumber, LastName, FirstName, EmailAddress, PhoneNumber, Birthday, ReminderEmail) VALUES (2, 'Chubb', 'Nick', 'chubb@browns.com', '123-344-2322', '05/01/1990', 'False')
INSERT INTO [member] (MemberNumber, LastName, FirstName, EmailAddress, PhoneNumber, Birthday, ReminderEmail) VALUES (3, 'Burrow', 'Joe', 'joecool@cinci.com', '222-444-5252', '10/11/2000', 'True')
INSERT INTO [member] (MemberNumber, LastName, FirstName, EmailAddress, PhoneNumber, Birthday, ReminderEmail) VALUES (4, 'Ward', 'Denzel', 'warden@browns.com', '320-442-3451', '12/11/1993', 'False')
INSERT INTO [member] (MemberNumber, LastName, FirstName, EmailAddress, PhoneNumber, Birthday, ReminderEmail) VALUES (5, 'Chase', 'Jamar', 'chase@bengals.com', '231-422-5242', '02/15/1999', 'True')
INSERT INTO [member] (MemberNumber, LastName, FirstName, EmailAddress, PhoneNumber, Birthday, ReminderEmail) VALUES (6, 'Landry', 'Jarvis', 'juice@browns.com', '241-511-5511', '10/30/1990', 'False')
INSERT INTO [member] (MemberNumber, LastName, FirstName, EmailAddress, PhoneNumber, Birthday, ReminderEmail) VALUES (7, 'Hunt', 'Kareem', 'reem@browns.com', '123-987-5678', '08/22/1995', 'True')
INSERT INTO [member] (MemberNumber, LastName, FirstName, EmailAddress, PhoneNumber, Birthday, ReminderEmail) VALUES (8, 'Williams', 'Greedy', 'greedy@browns.com', '123-444-2312', '09/13/7555', 'False')





--insert data into interestgroup
INSERT INTO [interestgroup] (GroupNumber, GroupName, MemberNumber) VALUES (1,'Quarterback', 1)
INSERT INTO [interestgroup] (GroupNumber, GroupName, MemberNumber) VALUES (2, 'WideReceiver', 5)
INSERT INTO [interestgroup] (GroupNumber, GroupName, MemberNumber) VALUES (3,'RunningBack', 2)
INSERT INTO [interestgroup] (GroupNumber, GroupName, MemberNumber) VALUES (4,'Defense', 4)

--insert data into member_interestgroup

INSERT INTO [member_interestgroup] (MemberNumber, GroupName) VALUES (1, 'Quarterback')
INSERT INTO [member_interestgroup] (MemberNumber, GroupName) VALUES (2, 'RunningBack')
INSERT INTO [member_interestgroup] (MemberNumber, GroupName) VALUES (3, 'Quarterback')
INSERT INTO [member_interestgroup] (MemberNumber, GroupName) VALUES (4, 'Defense')
INSERT INTO [member_interestgroup] (MemberNumber, GroupName) VALUES (5, 'WideReceiver')
INSERT INTO [member_interestgroup] (MemberNumber, GroupName) VALUES (6, 'WideReceiver')
INSERT INTO [member_interestgroup] (MemberNumber, GroupName) VALUES (7, 'RunningBack')
INSERT INTO [member_interestgroup] (MemberNumber, GroupName) VALUES (8, 'Defense')


--insert data into event
INSERT INTO [event] (EventNumber, Name, Description, StartDateTime, Duration, GroupName) VALUES (1, 'How to play Quarterback', 'Teach you to throw', '2022/02/22 15:00:00', 60, 'Quarterback')
INSERT INTO [event] (EventNumber, Name, Description, StartDateTime, Duration, GroupName) VALUES (2, 'How to play Wide Receiver', 'Teach you to run routes','2022/02/23 17:00:00', 60, 'WideReceiver')
INSERT INTO [event] (EventNumber, Name, Description, StartDateTime, Duration, GroupName) VALUES (3, 'How to play Running Back in the NFL', 'Teach you to juke', '2022/02/25 12:00:00', 60, 'RunningBack')
INSERT INTO [event] (EventNumber, Name, Description, StartDateTime, Duration, GroupName) VALUES (4, 'How to play Defense in the NFL', 'Teach you to tackle', '2022/02/25 12:00:00', 60, 'Defense')

--insert data into member_event
INSERT INTO [member_event] (MemberNumber, EventNumber) VALUES (1, 1)
INSERT INTO [member_event] (MemberNumber, EventNumber) VALUES (2, 3)
INSERT INTO [member_event] (MemberNumber, EventNumber) VALUES (3, 1)
INSERT INTO [member_event] (MemberNumber, EventNumber) VALUES (4, 4)
INSERT INTO [member_event] (MemberNumber, EventNumber) VALUES (5, 2)
INSERT INTO [member_event] (MemberNumber, EventNumber) VALUES (6, 2)
INSERT INTO [member_event] (MemberNumber, EventNumber) VALUES (7, 3)
INSERT INTO [member_event] (MemberNumber, EventNumber) VALUES (8, 4)

