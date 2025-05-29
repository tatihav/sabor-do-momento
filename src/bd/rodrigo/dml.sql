-- Inserir valores em uma tabela
INSERT INTO receita (
	titulo,
	ingredientes,
	modo_preparo,
	id_usuario_autor
) VALUES (
	'Bolo de fubá',
	'2 xícaras de chá de fubá
1 xícara de chá de farinha de trigo
2 xícaras de chá de açúcar
3 ovos
1/2 xícara de chá de óleo
1 xícara de chá de leite
1 colher de sopa de fermento em pó
(opcional) 50g de queijo ralado ou coco ralado',
	'1. Preaqueça o forno a 180 °C.
2. Em uma tigela, misture os ovos, o açúcar e o óleo.
3. Acrescente o leite, o fubá, a farinha de trigo e misture bem até ficar homogêneo.
4. Adicione o fermento e misture delicadamente.
5. (Opcional) Incorpore o queijo ou coco ralado.
6. Despeje a massa em uma forma untada e enfarinhada.
7. Leve ao forno por cerca de 35 a 40 minutos ou até dourar e passar no teste do palito.',
	1
);

-- Atualizar valores em uma tabela
UPDATE receita SET aprovada = 1 WHERE id_receita = 1;

-- Deletar valores em uma tabela
DELETE FROM receita WHERE titulo = 'Bolo de fubá';

-- Consultar valores de uma tabela e com filtro
SELECT *
FROM receita
WHERE id_receita = 1;

-- Consultar valores de uma tabela, colocando a relação com a outra tabela para conseguir trazer também na consulta a coluna da tabela relacionada, incluindo um filtro
SELECT
	t.id_receita,
	t.titulo,
	t.id_usuario_autor,
	usu.nome
FROM receita t
LEFT JOIN usuario usu ON usu.id_usuario = t.id_usuario_autor
WHERE t.id_usuario_autor = 26;

-- Consultar valores de uma tabela usando o ORDER BY com um DESC para trazer do mais recente para mais antigo (já que id_receita é auto incrementada)
SELECT *
FROM receita
ORDER BY id_receita DESC;
 
-- Consultar o número total de receitas não aprovadas agrupando por usuario autor
SELECT 
	usu.id_usuario,
	usu.nome
COUNT(*) AS total_nao_aprovadas
FROM receita t
INNER JOIN usuario usu ON usu.id_usuario = t.id_usuario_autor
WHERE t.aprovada = 0
GROUP BY usu.id_usuario, usu.nome;


-- Consultar o usuário que tem mais receitas aprovadas
SELECT 
	usu.id_usuario,
	usu.nome
COUNT(*) AS total_aprovadas
FROM receita t
INNER JOIN usuario usu ON usu.id_usuario = t.id_usuario_autor
WHERE t.aprovada = 1
GROUP BY usu.id_usuario, usu.nome
ORDER BY total_aprovadas DESC
LIMIT 1;

-- Consultar usuários que tem 2 ou mais receitas não aprovadas:
SELECT 
	usu.id_usuario,
	usu.nome
COUNT(*) AS total_nao_aprovadas
FROM receita t
INNER JOIN usuario usu ON usu.id_usuario = t.id_usuario_autor
WHERE t.aprovada = 0
GROUP BY usu.id_usuario, usu.nome
HAVING COUNT(*) >= 2;

-- Consultar a média de receitas postadas por usuário
SELECT
  AVG(total_receitas) AS media_receitas_por_usuario
FROM (
  SELECT
    id_usuario_autor
    COUNT(*) AS total_receitas
  FROM receita
  GROUP BY id_usuario_autor
) AS subconsulta;