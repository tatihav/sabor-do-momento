-- Cria um banco de dados
CREATE DATABASE sabordomomento;

-- Cria uma tabela
CREATE TABLE receita (
    id_receita INT UNSIGNED NOT NULL AUTO_INCREMENT,
    titulo VARCHAR(255) NOT NULL,
    ingredientes LONGTEXT NULL DEFAULT NULL,
    modo_preparo LONGTEXT NULL DEFAULT NULL,
    aprovada TINYINT(1) UNSIGNED NOT NULL DEFAULT 0,
    id_usuario_autor INT UNSIGNED NOT NULL,
    PRIMARY KEY (id_receita),
    FOREIGN KEY (id_usuario_autor) REFERENCES usuario(id_usuario)
);

-- Adiciona colunas à uma tabela
ALTER TABLE receita
ADD COLUMN data_criacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
ADD COLUMN tempo_preparo INT UNSIGNED NULL COMMENT 'Tempo em minutos',
ADD COLUMN porcoes TINYINT UNSIGNED NULL COMMENT 'Número de porções',
ADD COLUMN dificuldade ENUM('fácil', 'médio', 'difícil') NULL;

-- Deleta uma tabela
DROP TABLE receita;

-- Renomeia uma tablea
RENAME TABLE receita TO receitas;

-- Limpa os dados de uma tabela
TRUNCATE TABLE receita;