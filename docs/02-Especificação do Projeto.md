# Especificações do Projeto



## Personas



<table>
<tr>
   <th>Foto</th>
    <th>Nome</th>
    <th>Descrição</th>
    <th>Aplicativos</th>
    <th>Motivações</th>
    <th>Frustrações</th>
    <th>Hobbies, História</th>
  
</tr
        <tr>
    <td><title="João Marcos" <a href="https://ibb.co/yskznd2"><img src="https://i.ibb.co/yskznd2/avatar-genf4e04ee775f79805b2a90968a3d76e9a-H.jpg" alt="avatar-genf4e04ee775f79805b2a90968a3d76e9a-H" border="0"</a></td>
    <td>João Marcos </td>
    <td>
      <ul>
        <li>45 anos</li>
        <li>Motorista de Uber</li>
        <li>Mora em SP junto com seus dois filhos </li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Uber</li>
        <li>Instagram</li>
        <li>WhatsApp</li>
        <li>ifood</li>
         </ul>
    </td>
    <td>
      <ul>
        <li>Dar estudo aos filhos</li>
        <li>Ter um financeiro estável</li>
        <li>Dar boas experiências aos filhos</li>
      </ul>
    </td>
    <td>
      <li>Perdeu a esposa</li>
      <li>Tem dificuldade em sustentar os filhos</li>
    </td>
    <td>
      <li>Cozinhar para filhos e amigos</li>
      <li>Conhecer lugares novos</li>
       <li>Perdeu a esposa tem 2 anos, então passou a cuidar dos filhos sozinho, lutando para dar a eles o melhor. </li>
          </td>
</tr
        <tr>
    <td><title="Ana Julia" <a href="https://ibb.co/s567CPT"><img src="https://i.ibb.co/s567CPT/avatar-gen69b2e14520c5abb7209c48dfb8a38542.jpg" alt="avatar-gen69b2e14520c5abb7209c48dfb8a38542" border="0"></a></td>
    <td>Ana Julia </td>
    <td>
      <ul>
        <li>28 anos</li>
        <li>Casada</li>
        <li>1 filho de 10 anos
        <li>Trabalha em home office </li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Ifood</li>
        <li>Instagram</li>
        <li>WhatsApp</li>
        <li>Facebook</li>
         </ul>
    </td>
    <td>
      <ul>
        <li>Ter mais tempo para passar com o filho e marido</li>
        <li>Dar o melhor a seu filho</li>
      </ul>
    </td>
    <td>
      <li>Dificuldade em organizar uma rotina em casa</li>
    </td>
    <td>
      <li>Viajar, conhecer novas culturas</li>
      <li>Testar pratos novos na cozinha</li>
       <li>Começou a trabalhar de casa para poder ficar mais perto do filho, porém as demandas estão altas. </li>
          </td>
          </tr
        <tr>
    <td><title="Maria Carla" <a href="https://ibb.co/BB1qRt7"><img src="https://i.ibb.co/BB1qRt7/avatar-genbb474f62012e0c868f9fcaed2abbe140.jpg" alt="avatar-genbb474f62012e0c868f9fcaed2abbe140" border="0"></a></td>
    <td>Maria Carla </td>
    <td>
      <ul>
        <li>35 anos</li>
        <li>Casada</li>
        <li>Mãe de 2 meninas</li>
        <li>Trabalha como Assistente Admnistrativo</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>WhatsApp</li>
        <li>Shopee</li>
        <li>Ifood</li>
         </ul>
    </td>
    <td>
      <ul>
        <li>Passar tempo com as filhas </li>
        <li>Ter uma vida estável</li>
      </ul>
    </td>
    <td>
      <li>Não conseguiu fazer graduação</li>
    </td>
    <td>
      <li>Conhecer pessoas e lugares novos</li>
      <li>Cozinhar para a família</li>
       <li>Teve as filhas muito cedo e hoje trabalha para poder dar um futuro melhor para as filhas. </li>
          </td>
          </tr>
  </table>

## Histórias de Usuário

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.

|EU COMO `PERSONA`   | QUERO/PRECISO `O QUE` |PARA ... `POR QUE`             |
|--------------------|---------------------------|----------------------------------|
| Ana Julia | ter minhas receitas de culinária em um único lugar | deixar de me sentir perdida na hora de procurar uma receita |
| Ana Julia | ver receitas de acordo com meu gosto e preferências | economizar tempo procurando receitas que satisfaçam meus gostos e restrições |
| Ana Julia | preocupada com a qualidade e confiabilidade das receitas | Ter confiança nos conteúdos  |
| Ana Julia | Poder combinar filtros | Encontrar mais rápido as receitas específicas que atendem minha dieta |
| Maria Carla | saber o que outras pessoas estão achando daquela receita | matar curiosidade em saber o que outras pessoas acharam da receita, se tiveram opinião em comum, ver repercussão |
| João Marcos | quero compartilhar receitas | poder compartilhar com meus amigos as receitas que mais gostei |
| João Marcos | ver sugestões de receitas adequadas para o momento do dia (café da manhã, almoço, jantar) | sair do excesso de informação, ter mais praticidade e economizar tempo |
| Maria Carla | salvar minhas receitas favoritas | poder encontrar rapidamente minhas receitas favoritas |
| Maria Carla | ver receitas tanto no computador quanto no celular | quando tiver na casa dos meus parentes e quiser mostrar uma receita para eles, ou para prepararmos juntos |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID     | Descrição do Requisito                                                                 | Prioridade |
|--------|----------------------------------------------------------------------------------------|------------|
| RF-001 | O sistema deve possibilitar o usuário a adicionar, editar e excluir receitas na plataforma. | ALTA       |
| RF-002 | O sistema deve possibilitar o usuário adicionar foto e descrição na publicação de receitas. | ALTA       |
| RF-003 | O sistema deve ter um sistema de aprovação de publicações de receita pelos usuários.    | MÉDIA      |
| RF-004 | O sistema deve permitir que usuários tenham um filtro de pesquisa, para pesquisar as receitas pelo nome ou categoria. | ALTA       |
| RF-005 | O sistema deve possibilitar um sistema de interação entre usuários, com curtidas e comentários. | MÉDIA      |
| RF-006 | O sistema deve possibilitar os usuários a favoritarem as receitas e de ver essas receitas salvas. | MÉDIA      |
| RF-007 | O sistema deve possibilitar os usuários a compartilharem as receitas externamente, com atalho para compartilhar no Facebook e WhatsApp. | BAIXA      |
| RF-008 | O sistema deve conter atalho para copiar o link da página da receita, para facilitar o compartilhamento. | BAIXA      |
| RF-009 | O sistema deve ter um filtro avançado para combinar filtros e exibir as receitas de acordo com sua preferência. | MÉDIA      |
| RF-010 | O sistema deve ter grids para exibição das receitas na plataforma.                      | ALTA       |
| RF-011 | Cada receita terá uma página para sua exibição e visualização na plataforma.            | ALTA       |
| RF-012 | O sistema deve permitir que os usuários cadastrem-se, façam login e logout na plataforma. | ALTA       |

### Requisitos não Funcionais

| ID      | Descrição do Requisito                                                                 | Prioridade |
|---------|----------------------------------------------------------------------------------------|------------|
| RNF-001 | O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). | ALTA       |
| RNF-002 | O site deverá ser responsivo permitindo a visualização em telas de diversos tamanhos de forma adequada. | ALTA       |
| RNF-003 | O sistema deverá ser baseado em Programação Orientada a Objetos (POO).                  | ALTA       |
| RNF-004 | O sistema deverá utilizar C# e .NET para o back-end.                                    | ALTA       |
| RNF-005 | O sistema deverá utilizar banco de dados.                                               | ALTA       |
| RNF-006 | O sistema deverá seguir o padrão MVC.                                               | ALTA       |



## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

| ID | Restrição                                             |
|----|-------------------------------------------------------|
| 01 | O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 15/06/2025. |
| 02 | A equipe não pode subcontratar o desenvolvimento do trabalho. |
| 03 | O idioma da plataforma será apenas PT-BR.             |
| 04 | O projeto deverá ser realizado somente com ferramentas gratuitas. |
| 05 | O projeto deverá utilizar o Github para versionamento do código. |
| 05 | O projeto deverá utilizar o Kanban do Github. |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

![image](https://github.com/user-attachments/assets/09adc930-3df4-4b5c-8304-b95ab1d427d9)

