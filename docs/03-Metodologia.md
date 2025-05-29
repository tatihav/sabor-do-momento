
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Descreva aqui a metodologia de trabalho do grupo para atacar o problema. Definições sobre os ambiente de trabalho utilizados pela  equipe para desenvolver o projeto. Abrange a relação de ambientes utilizados, a estrutura para gestão do código fonte, além da definição do processo e ferramenta através dos quais a equipe se organiza (Gestão de Times).


## Controle de Versão

o [Github](https://github.com) foi a ferramenta adotada no projeto tanto para controle de versão, quanto para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `master`: versão estável já testada do software
- `develop`: versão de desenvolvimento do software, no qual vamos mergeando as branches já testadas e aprovadas

- `feature/nomeDaFeature`: versão do software para trabalhar novas melhorias e implementações, criada a partir da develop e que após ser testada e aprovada vai subir na develop
- `bugfix/nomeDoBugParaCorrecao`: versão de desenvolvimento do software para trabalhar o bug "x" a ser corrigido, e que após ser testada e aprovada vai subir na develop

Fluxo: 
1. Uma nova branch é criada a partir da develop (atualizada), para resolver problema "x", sendo um bug ou uma feature. 
2. Depois que esse card for testado e aprovado, a develop vai receber o merge da branch.
3. Ao final da sprint, será criada uma versão com base na develop (que foi recebendo os merges das branches aprovadas), e a master receberá o merge dessa versão criada.

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

## Gerenciamento de Projeto


### Divisão de Papéis

A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento. A equipe está organizada da seguinte maneira:
- Scrum Master: Tatiana Barbosa;
- Product Owner: Rodrigo Souza;
- Equipe de Desenvolvimento: Rodrigo Souza, Tatiana Barbosa;
- Equipe de Design: Rodrigo Souza, Tatiana Barbosa.


### Processo


Escolhemos o GitHub Projects para representar nosso método Kanban, pois ele oferece uma interface intuitiva para organizar e acompanhar tarefas. Essa abordagem nos permite visualizar o fluxo de trabalho, gerenciar prioridades e colaborar em tempo real, mantendo a equipe alinhada e atualizada sobre o progresso do projeto.
Coloque  informações sobre detalhes da implementação do Scrum seguido pelo grupo. O grupo deverá fazer uso do recurso de gerenciamento de projeto oferecido pelo GitHub, que permite acompanhar o andamento do projeto, a execução das tarefas e o status de desenvolvimento da solução.
Atualmente, nosso fluxo de trabalho no Kanban está estruturado da seguinte maneira:

 - Backlog do produto: Contém todas as tarefas identificadas para o projeto, incluindo aquelas que ainda precisam ser detalhadas antes de serem trabalhadas.
 - Pendência: Tarefas prontas para serem iniciadas, mas que ainda não estão em andamento.
 - Em andamento: Tarefas que estão ativamente sendo desenvolvidas pela equipe.
 - Feito: Tarefas finalizadas e que passaram pelo processo de revisão e validação.

   
<a href="https://ibb.co/BKSHQ9TQ"><img src="https://i.ibb.co/bR8jCkNC/Captura-de-tela-2025-03-11-210352.png" alt="Captura-de-tela-2025-03-11-210352" border="0"></a>



Com essa estrutura, conseguimos acompanhar o desenvolvimento do projeto de maneira organizada e eficaz, garantindo que cada etapa do processo seja devidamente monitorada.


### Ferramentas

Para garantir um desenvolvimento eficiente e colaborativo, utilizamos um conjunto de ferramentas que nos auxilia em diferentes aspectos do projeto. A escolha dessas ferramentas foi baseada na integração entre elas, facilidade de uso e suporte a práticas modernas de desenvolvimento de software.

 - Repositório de Código Fonte
Plataforma: GitHub - Utilizamos o GitHub para hospedar e versionar nosso código, garantindo um ambiente seguro e organizado para colaboração entre os membros da equipe. Ele nos permite acompanhar alterações, revisar código e gerenciar branches de forma eficiente.
 - Documentação do Projeto
Plataforma: GitHub Wiki - Mantemos nossa documentação dentro do próprio GitHub para facilitar a consulta e edição por todos os membros da equipe. Isso inclui especificações técnicas, diagramas e decisões de arquitetura.
 - Desenvolvimento: Editor de Código: Visual Studio Code - O VS Code oferece suporte para diversas extensões úteis no desenvolvimento, além de integração com o GitHub.
Ferramenta de Interface: Figma - o Figma permite criar wireframes e protótipos interativos, facilitando a validação do design da interface.
 - Gerenciamento do Projeto
Plataforma: GitHub Projects - Utilizamos o GitHub Projects para acompanhar tarefas e manter o fluxo de trabalho organizado através do método Kanban.
 - Comunicação
Ferramentas: Microsoft Teams, WhatsApp - O Teams é utilizado para reuniões e alinhamentos formais semanais, enquanto o WhatsApp facilita a comunicação rápida da equipe.

## Relação de Ambientes de Trabalho

| AMBIENTE                            | PLATAFORMA                         | LINK DE ACESSO                         |
|-------------------------------------|------------------------------------|----------------------------------------|
| Repositório de código fonte         | GitHub                             | [Código Fonte](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2025-1-e3-proj-back-t1-receitas-culinaria/blob/main/README.md)                           |
| Documentos do projeto               | GitHub                             | [MyRep](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2025-1-e3-proj-back-t1-receitas-culinaria/tree/main/docs)                            |
| Projeto de Interface                | Figma                              | [Protótipo](https://www.figma.com/file/fbwMuLej2Voba16iX0yoe6/Untitled?type=design&node-id=0-1&mode=design&t=7U62SZ4xrNxd2ZHK-0)                            |
| Gerenciamento do Projeto            | GitHub                    | [GitHub](https://github.com/orgs/ICEI-PUC-Minas-PMV-SInt/projects/50)                            |
| Reuniões Diárias                          | Microsoft Teams                       | [Teams](https://www.microsoft.com/pt-br/microsoft-teams/log-in)|
| Comunicação do time                 | WhatsApp                          |  [WhatsApp](https://web.whatsapp.com/)
| Editor de códigos                   | Visual Studio Code                | [Visual Studo Code](https://code.visualstudio.com/).       





