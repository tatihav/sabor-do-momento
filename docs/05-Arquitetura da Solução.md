# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![Arquitetura da Solução](img/arch-back.JPG)

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

```mermaid
classDiagram
    class Usuario {
        +int Id
        +string Nome
        +string Email
        +string Senha
        +string FotoPerfil
        +DateTime DataCadastro
        +bool Ativo
        +List~Receita~ ReceitasPublicadas
        +List~Receita~ ReceitasFavoritadas
        +List~Comentario~ Comentarios
        +Cadastrar() bool
        +Autenticar(string email, string senha) bool
        +EditarPerfil() bool
        +FavoritarReceita(Receita receita) bool
        +RemoverFavorito(Receita receita) bool
        +PublicarReceita(Receita receita) bool
    }
    
    class Receita {
        +int Id
        +string Titulo
        +string Descricao
        +int TempoPreparoMinutos
        +int Porcoes
        +DateTime DataPublicacao
        +string ImagemUrl
        +bool Aprovada
        +int IdUsuario
        +Usuario Autor
        +List~Ingrediente~ Ingredientes
        +List~PassoPreparo~ PassosPreparo
        +List~Categoria~ Categorias
        +List~Usuario~ UsuariosQueFavoritaram
        +List~Comentario~ Comentarios
        +List~Curtida~ Curtidas
        +Publicar() bool
        +Editar() bool
        +Excluir() bool
        +Aprovar() bool
        +Reprovar() bool
        +AdicionarIngrediente(Ingrediente ingrediente) void
        +AdicionarPassoPreparo(PassoPreparo passo) void
        +AdicionarCategoria(Categoria categoria) void
        +GerarLinkCompartilhamento() string
    }
    
    class Ingrediente {
        +int Id
        +string Nome
        +string Quantidade
        +int IdReceita
        +Receita Receita
    }
    
    class PassoPreparo {
        +int Id
        +int Numero
        +string Descricao
        +string ImagemUrl
        +int IdReceita
        +Receita Receita
    }
    
    class Categoria {
        +int Id
        +string Nome
        +string Descricao
        +List~Receita~ Receitas
        +Adicionar() bool
        +Editar() bool
        +Excluir() bool
    }
    
    class Comentario {
        +int Id
        +string Texto
        +DateTime DataCriacao
        +int IdUsuario
        +int IdReceita
        +Usuario Autor
        +Receita Receita
        +Adicionar() bool
        +Editar() bool
        +Excluir() bool
    }
    
    class Curtida {
        +int Id
        +DateTime DataCriacao
        +int IdUsuario
        +int IdReceita
        +Usuario Usuario
        +Receita Receita
        +Adicionar() bool
        +Remover() bool
    }
    
    class Compartilhamento {
        +int Id
        +DateTime DataCompartilhamento
        +string Plataforma
        +int IdReceita
        +Receita Receita
        +int IdUsuario
        +Usuario Usuario
        +Compartilhar(string plataforma) bool
        +GerarLink() string
    }
    
    class FiltroReceita {
        +string TermoBusca
        +List~int~ IdsCategorias
        +int TempoMaximoPreparo
        +int PorcoesMinimas
        +bool SomenteAprovadas
        +Filtrar() List~Receita~
    }
    
    class AprovacaoReceita {
        +int Id
        +int IdReceita
        +Receita Receita
        +int IdModerador
        +Usuario Moderador
        +bool Aprovada
        +string Observacao
        +DateTime DataAprovacao
        +Aprovar() bool
        +Reprovar(string motivo) bool
    }
    
    Usuario "1" -- "n" Receita : publica
    Usuario "n" -- "n" Receita : favorita
    Usuario "1" -- "n" Comentario : cria
    Usuario "1" -- "n" Curtida : realiza
    Usuario "1" -- "n" Compartilhamento : compartilha
    Usuario "1" -- "n" AprovacaoReceita : modera
    
    Receita "1" -- "n" Ingrediente : possui
    Receita "1" -- "n" PassoPreparo : possui
    Receita "n" -- "n" Categoria : pertence
    Receita "1" -- "n" Comentario : recebe
    Receita "1" -- "n" Curtida : recebe
    Receita "1" -- "n" Compartilhamento : é compartilhada
    Receita "1" -- "1" AprovacaoReceita : é avaliada
```

## Diagrama MER

O MER é representado por meio de entidades e relacionamentos, e foca nos atributos e relacionamentos entre as entidades.

![image](https://github.com/user-attachments/assets/caeeee9e-0475-4c95-b77e-7077a8e8cd9a)




## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
![image](https://github.com/user-attachments/assets/359e457e-25d3-4d72-971a-7a9ad2827643)


## Modelo Físico (DDL)

Entregar um arquivo banco.sql contendo os scripts de criação das tabelas do banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Instruções SQL de Manipulação do BD (DML)

Entregar um arquivo dml.sql contendo os scripts de manipulação de banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
