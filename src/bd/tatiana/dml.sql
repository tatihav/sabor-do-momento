INSERT INTO	 novo_Usuario (nome_usuario, email_usuario, senha_usuario, data_cadastro, telefone, ativo)
VALUES ('Tatiana Barbosa', 'tatiana@gmail.com', 'asd1234', NOW(), '(85)954658473', true);
INSERT INTO	 novo_Usuario (nome_usuario, email_usuario, senha_usuario, data_cadastro, telefone, ativo)
VALUES ('julia Santos', 'julia@gmail.com', 'qwe1234', NOW(), '(85)9745983654', true); 

-- selecionar usuarios
select * from novo_usuario;

select nome_usuario, id_usuario, email_usuario FROM novo_usuario;

-- fazer alteração de telefone do usuario
UPDATE novo_usuario
SET telefone = '(85)954679574'
where email_usuario = 'tatiana@gmail.com';


-- deletar um usuario
DELETE FROM novo_usuario
where email_usuario = 'julia@gmail.com';
