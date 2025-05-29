# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Enumere quais cenários de testes foram selecionados para teste. Neste tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo de usuários que foi escolhido para participar do teste e as ferramentas utilizadas.


| **Caso de Teste** 	| **CT01 – Cadastrar, Login e Logout de perfil ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-012 - O sistema deve permitir que os usuários cadastrem-se, façam login e logout na plataforma. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação, fazer o login e logout. |
| Passos 	| - Acessar o navegador <br> - https://icei-puc-minas-pmv-sint.github.io/pmv-sint-2024-2-e2-proj-front-grupo4-receitas1/<br> - Clicar em "Cadastrar-se". <br> - Preencher os campos obrigatórios (nome, e-mail e senha). <br> - Clicar em "Cadastrar". <br> - Login, preencher os campos solicitados (e-mail e senha).  <br> - Clicar em "entrar". <br> - Logout, clicar em "Sair" no canto superior esquerdo da página.
|Critério de Êxito para login | - Login realizado com sucesso. |
|Critério de Êxito para logout | - Página retorna ao login. |
|  	|  	|

| **Caso de Teste** 	| **CT02 – Adicionar nova receita  ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O sistema deve possibilitar o usuário a adicionar receitas na plataforma. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar uma nova receita na aplicação. |
| Passos 	| - Acessar o navegador <br> - https://icei-puc-minas-pmv-sint.github.io/pmv-sint-2024-2-e2-proj-front-grupo4-receitas1/<br> - Na sua tela de perfil clicar em "Postar receita". <br> - Preencher os campos obrigatórios (Nome da receita, foto da receita, ingredientes e modo de preparo). <br> - Selecionar a categoria ( Café da manhã, Lanche, Almoço, Jantar, sobremesa). <br> Adicionar tags ( Vegana, Fitness, LowCarb, Sopa, Doce, Rápido, Saudável)  - Clicar em "Salvar Receita". <br>
|Critério de Êxito para cadastro de nova receita | - Nova receita salva com sucesso. |
|  	|  	|

| **Caso de Teste** 	| **CT03 – Aprovação de novas receitas  ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - O sistema deve ter um sistema de aprovação de publicações de receita pelos usuários. |  *Apenas Admin tem esse acesso
| Objetivo do Teste 	| Verificar se o sistema tem opção de aprovação de nova receita cadastrada. |
| Passos 	| - Acessar o navegador <br> - https://icei-puc-minas-pmv-sint.github.io/pmv-sint-2024-2-e2-proj-front-grupo4-receitas1/<br> - Na sua tela de perfil clicar em "Aprovar receita". <br> - Aparecerá as receitas que estão pendentes de aprovação. <br> - Clique em aprovar ou excluir a receita. <br>
|Critério de Êxito para sistema de aprovação | - Receita deixa de estar pendente. |
|  	|  	|

 | **Caso de Teste** 	| **CT04– Visualização de tela da receita  ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-0011 -  Cada receita terá uma página para sua exibição e visualização na plataforma. |
| Objetivo do Teste 	| Verificar se o sistema tem opção visualização da tela da receita  |
| Passos 	| - Acessar o navegador <br> - https://icei-puc-minas-pmv-sint.github.io/pmv-sint-2024-2-e2-proj-front-grupo4-receitas1/<br> - Na Tela inicial pode escolher uma receita por meio das tags ou pesquisa. Ou na sua tela de perfil onde terá seus receitas preferidas. <br> - Clicar em cima da receita escolhida. <br> - Será direcionado para a tela da receita, onde poderá ver seus ingredientes e modo de praparo. <br>
|Critério de Êxito para exibição e visualização da receita | - ser redirecionado para a tela da receita. |
|  	|  	|

