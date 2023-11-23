CREATE DATABASE RecuperacaoParalela
USE RecuperacaoParalela

CREATE TABLE Usuario (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100),
    Telefone NVARCHAR(20),
    Email NVARCHAR(100),
    Endereco NVARCHAR(255),
    Contato DATETIME,
    Cargo NVARCHAR(50),
    Empresa NVARCHAR(100)
);