DROP DATABASE schoolPaths

CREATE DATABASE schoolPaths

DROP TABLE usuario_db

CREATE TABLE usuario_db
(
id_user INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
usuario VARCHAR(20) NOT NULL,
senha VARCHAR(20) NOT NULL
)

DROP TABLE aluno_db

CREATE TABLE aluno_db
(
id_user INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
nome VARCHAR(30) NOT NULL,
sobrenome VARCHAR(20) NOT NULL,
nascimento DATE NOT NULL,
cpf CHAR(11) NOT NULL,
rg VARCHAR(10) NOT NULL,
ddd CHAR(05) NOT NULL,
telefone CHAR(12) NOT NULL,
endereço VARCHAR(35) NOT NULL,
numero CHAR(09) NOT NULL,
bairro VARCHAR(35) NOT NULL,
cidade VARCHAR(15) NOT NULL,
cep CHAR(10) NOT NULL,
uf VARCHAR(05) NOT NULL,
escola VARCHAR(30) NOT NULL,
sexo VARCHAR(10) NOT NULL,
)

SELECT table_catalog, table_schema, table_name, table_type FROM information_schema.tables

ALTER TABLE aluno_db
ALTER COLUMN nascimento CHAR (10);

ALTER TABLE aluno_db
ALTER COLUMN uf VARCHAR (05);

ALTER TABLE aluno_db
ALTER COLUMN bairro VARCHAR(35);

SELECT * FROM aluno_db

DELETE FROM aluno_db

SELECT * FROM usuario_db

DELETE FROM usuario_db