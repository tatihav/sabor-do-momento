-- criar o banco de dados

create database receitas_sabordomomento;

CREATE TABLE Usuario(
	id_usuario int primary key auto_increment,
    nome_usuario char(100),
    email_usuario char(50) UNIQUE,
    senha_usuario char(10),
    foto_perfil text,
    data_cadastro DATETIME,
    ativo BOOLEAN );
    
-- alterar para adicionar um telefone
ALTER TABLE usuario
ADD telefone char(15);

-- deletar uma coluna
ALTER TABLE Usuario
DROP COLUMN foto_perfil;

-- Renomear nome da tabela
RENAME TABLE Usuario TO novo_Usuario
