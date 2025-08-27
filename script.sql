USE master;
GO
CREATE DATABASE listeTaches;
GO
USE listeTaches;
GO
CREATE TABLE taches(
tacheId INT IDENTITY NOT NULL,
tacheNom VARCHAR(15) NOT NULL,
tacheDescription VARCHAR(255) NOT NULL,
 tacheCreation DATETIME NOT NULL,
 tacheTerminer DATETIME NULL
);
GO
ALTER TABLE taches ADD CONSTRAINT PK_tacheId PRIMARY KEY (tacheId);
GO