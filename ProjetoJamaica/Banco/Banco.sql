create database IrieJamaica;
use IrieJamaica;

create table tbCliente(
	Id int auto_increment primary key,
    Nome varchar(50) not null,
    Email varchar(50) not null,
    Senha varchar(8) not null,
    ConfirmacaoSenha varchar(8) not null,
	Situacao char(1) not null

);

INSERT INTO tbCliente values(default, "Sasuke", "Sasuke@gmail.com", "Sasuke", "Sasuke", "A")