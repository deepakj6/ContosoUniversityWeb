CREATE TABLE Instructor (
    ID int NOT NULL auto_increment,
    LastName varchar(50) NOT NULL,
    FirstName varchar(50) NOT NULL,
    HireDate datetime NOT NULL,
    CONSTRAINT PK_Instructor PRIMARY KEY (ID)
);
CREATE TABLE CourseAssignment (
    InstructorID int NOT NULL,
    CourseID int NOT NULL,
    CONSTRAINT PK_CourseAssignment PRIMARY KEY (CourseID, InstructorID),
    CONSTRAINT FK_CourseAssignment_Course_CourseID FOREIGN KEY (CourseID) REFERENCES Course (CourseID) ON DELETE CASCADE,
    CONSTRAINT FK_CourseAssignment_Instructor_InstructorID FOREIGN KEY (InstructorID) REFERENCES Instructor (ID) ON DELETE CASCADE
);
CREATE TABLE Department (
    DepartmentID int NOT NULL auto_increment,
    Name varchar(50) NULL,
    Budget numeric(13,2) NOT NULL,
    StartDate datetime NOT NULL,
    InstructorID int NULL,
    CONSTRAINT PK_Department PRIMARY KEY (DepartmentID),
    CONSTRAINT FK_Department_Instructor_InstructorID FOREIGN KEY (InstructorID) REFERENCES Instructor (ID) ON DELETE NO ACTION
);
CREATE TABLE OfficeAssignment (
    InstructorID int NOT NULL,
    Location varchar(50) NULL,
    CONSTRAINT PK_OfficeAssignment PRIMARY KEY (InstructorID),
    CONSTRAINT FK_OfficeAssignment_Instructor_InstructorID FOREIGN KEY (InstructorID) REFERENCES Instructor (ID) ON DELETE CASCADE
);
----------
-- CREATE INDEX IX_Course_DepartmentID ON Course (DepartmentID); NOT WORKING -- SKIPPED
----------
CREATE INDEX IX_CourseAssignment_InstructorID ON CourseAssignment (InstructorID);
CREATE INDEX IX_Department_InstructorID ON Department (InstructorID);
CREATE INDEX IX_Enrollment_CourseID ON Enrollment (CourseID);
CREATE INDEX IX_Enrollment_StudentID ON Enrollment (StudentID);

ALTER TABLE Course ADD DepartmentID int NOT NULL DEFAULT 0;
ALTER TABLE Course ADD CONSTRAINT FK_Course_Department_DepartmentID FOREIGN KEY (DepartmentID) REFERENCES Department (DepartmentID) ON DELETE CASCADE;
ALTER TABLE Department ADD RowVersion timestamp NULL;
ALTER TABLE Course modify COLUMN Title varchar(50) NULL