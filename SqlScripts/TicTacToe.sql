CREATE DATABASE TicTacToe

USE TicTacToe
GO

CREATE TABLE TicTacToe
(
    Id INT NOt NULL UNIQUE CHECK(Id IN (1,2,3,4,5,6,7,8,9)),
    [Value] BIT NOT NULL
)