CREATE DATABASE Empresa;
GO

USE Empresa;
GO

CREATE TABLE Empleados(
idEmpleado INT PRIMARY KEY NOT NULL,
Nombre VARCHAR(50) NOT NULL,
Apellido VARCHAR(100) NOT NULL,
Direccion VARCHAR(200) NOT NULL,
);
GO

INSERT INTO Empleados VALUES(1,'Isaac','Hernandez','Colonia Univo');
GO


SELECT * FROM Empleados;
GO

DELETE FROM Empleados;
GO