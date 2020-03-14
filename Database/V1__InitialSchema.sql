CREATE TABLE Course (
    CourseID int NOT NULL,
    Title varchar(2000) NULL,
    Credits int NOT NULL,
    CONSTRAINT PK_Course PRIMARY KEY (CourseID)
);
CREATE TABLE Student (
    ID int NOT NULL auto_increment,
    LastName varchar(2000) NULL,
    FirstMidName varchar(2000) NULL,
    EnrollmentDate datetime NOT NULL,
    CONSTRAINT PK_Student PRIMARY KEY (ID)
);
CREATE TABLE Enrollment (
    EnrollmentID int NOT NULL auto_increment,
    CourseID int NOT NULL,
    StudentID int NOT NULL,
    Grade int NULL,
    CONSTRAINT PK_Enrollment PRIMARY KEY (EnrollmentID),
    CONSTRAINT FK_Enrollment_Course_CourseID FOREIGN KEY (CourseID) REFERENCES Course (CourseID) ON DELETE CASCADE,
    CONSTRAINT FK_Enrollment_Student_StudentID FOREIGN KEY (StudentID) REFERENCES Student (ID) ON DELETE CASCADE
);










