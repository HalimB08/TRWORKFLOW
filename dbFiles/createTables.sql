--DataBase Name = "TRWORKFLOW" (create a new database)
CREATE TABLE Users
(
ID NUMERIC(3) NOT NULL IDENTITY(1,1),
FirstName NVARCHAR(300) NOT NULL,
LastName NVARCHAR(300) NOT NULL,
Mail NVARCHAR(300),	
UserName NVARCHAR(300) NOT NULL,
Password NVARCHAR(300) NOT NULL,
BirthDate DATETIME NOT NULL,
Gender NVARCHAR(4) NOT NULL,
Authority INT,
IsActive BIT
CONSTRAINT
Users_ID_PK PRIMARY KEY (ID)
);

CREATE TABLE UserDetails
(
ID Numeric(38) NOT NULL IDENTITY(1,1),
PhoneNumber NVARCHAR(25),
Department NVARCHAR(300),
Profession NVARCHAR(300),
EmploymentStartDate DATETIME,
EmploymentEndDate DATETIME,
EmployeeClass NVARCHAR(300),
CONSTRAINT
UserDetails_ID_PK PRIMARY KEY (ID),
Users_ID_FK numeric(3) foreign key (Users_ID_FK)
references Users(ID)
)