CREATE DATABASE SavingsDB;
--@block
USE SavingsDB;
CREATE TABLE SavingsType (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(32) NOT NULL
);
--@block
USE SavingsDB;
CREATE TABLE Savings (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    SavingsTypeId INT,
    FOREIGN KEY (SavingsTypeId) REFERENCES SavingsType(Id),
    Name VARCHAR(50) NOT NULL,
    Amount INT,
    AddingDate DATE
);
--@block
-- Wstawianie przykładowych danych do tabeli SavingsType
INSERT INTO SavingsType (Name) VALUES
('Emergency'),
('Retirement'),
('Vacation');

-- Wstawianie przykładowych danych do tabeli Savings
INSERT INTO Savings (SavingsTypeId, Name, Amount, AddingDate) VALUES
(1, 'Emergency Fund', 1000.00, '2024-04-28'),
(2, '401(k)', 5000.00, '2024-04-28'),
(3, 'Dream Vacation', 2500.00, '2024-04-28');

--@block
USE SavingsDB;
DROP TABLE Savings;
DROP TABLE SavingsType;
DROP DATABASE SavingsDB;
