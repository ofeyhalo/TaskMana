-- Create or use the database
IF DB_ID('TaskManaDB') IS NULL
    CREATE DATABASE TaskManaDB;
GO
USE TaskManaDB;
GO

-- Users table (for assigning tasks, optional for now)
CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- Boards table
CREATE TABLE Boards (
    BoardId INT PRIMARY KEY IDENTITY(1,1),
    BoardName NVARCHAR(100) NOT NULL,
    CreatedBy INT, -- FK to Users
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserId)
);
GO

-- Lists table (e.g. To Do, Doing, Done)
CREATE TABLE Lists (
    ListId INT PRIMARY KEY IDENTITY(1,1),
    BoardId INT NOT NULL,
    ListTitle NVARCHAR(100) NOT NULL,
    SortOrder INT,
    FOREIGN KEY (BoardId) REFERENCES Boards(BoardId)
);
GO

-- Tasks table (cards)
CREATE TABLE Tasks (
    TaskId INT PRIMARY KEY IDENTITY(1,1),
    ListId INT NOT NULL,
    TaskTitle NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX),
    DueDate DATETIME NULL,
    AssignedTo INT NULL, -- FK to Users
    CreatedAt DATETIME DEFAULT GETDATE(),
    SortOrder INT,
    FOREIGN KEY (ListId) REFERENCES Lists(ListId),
    FOREIGN KEY (AssignedTo) REFERENCES Users(UserId)
);
GO

-- Labels table (like Trello color tags)
CREATE TABLE Labels (
    LabelId INT PRIMARY KEY IDENTITY(1,1),
    LabelName NVARCHAR(50),
    Color NVARCHAR(20)
);
GO

-- TaskLabels join table (many-to-many between tasks and labels)
CREATE TABLE TaskLabels (
    TaskId INT NOT NULL,
    LabelId INT NOT NULL,
    PRIMARY KEY (TaskId, LabelId),
    FOREIGN KEY (TaskId) REFERENCES Tasks(TaskId),
    FOREIGN KEY (LabelId) REFERENCES Labels(LabelId)
);
GO

-- Checklists per Task
CREATE TABLE Checklists (
    ChecklistId INT PRIMARY KEY IDENTITY(1,1),
    TaskId INT NOT NULL,
    ItemText NVARCHAR(200) NOT NULL,
    IsChecked BIT DEFAULT 0,
    SortOrder INT,
    FOREIGN KEY (TaskId) REFERENCES Tasks(TaskId)
);
GO
