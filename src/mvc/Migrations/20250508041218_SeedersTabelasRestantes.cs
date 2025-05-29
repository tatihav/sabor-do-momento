using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mvc.Migrations
{
    /// <inheritdoc />
    public partial class SeedersTabelasRestantes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Nome", "Senha", "UrlFoto" },
                values: new object[,]
                {
                    { 1, "usuario1@gmail.com", "Maria Souza", "12345678", "https://randomuser.me/api/portraits/women/2.jpg" },
                    { 2, "usuario2@gmail.com", "Bruna Mendes", "12345678", "https://randomuser.me/api/portraits/women/6.jpg" },
                    { 3, "usuario3@gmail.com", "Roberta Carvalho", "12345678", "https://randomuser.me/api/portraits/women/10.jpg" },
                    { 4, "usuario4@gmail.com", "Marcelo Gomes", "12345678", "https://randomuser.me/api/portraits/men/13.jpg" },
                    { 5, "usuario5@gmail.com", "Patrícia Almeida", "12345678", "https://randomuser.me/api/portraits/women/15.jpg" },
                    { 6, "usuario6@gmail.com", "Débora Vieira", "12345678", "https://randomuser.me/api/portraits/women/17.jpg" },
                    { 7, "usuario7@gmail.com", "Gustavo Lopes", "12345678", "https://randomuser.me/api/portraits/men/19.jpg" },
                    { 8, "usuario8@gmail.com", "João Lima", "12345678", "https://randomuser.me/api/portraits/men/22.jpg" },
                    { 9, "usuario9@gmail.com", "Carlos Moreira", "12345678", "https://randomuser.me/api/portraits/men/26.jpg" },
                    { 10, "usuario10@gmail.com", "André Gomes", "12345678", "https://randomuser.me/api/portraits/men/33.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Receitas",
                columns: new[] { "Id", "Aprovada", "CategoriaId", "Ingredientes", "ModoPreparo", "TempoPreparo", "Titulo", "UrlFoto", "UsuarioId" },
                values: new object[,]
                {
                    { 1, true, 5, "3 cenouras médias, 4 ovos, 1 xícara de óleo, 2 xícaras de açúcar, 2 xícaras de farinha de trigo, 1 colher de sopa de fermento em pó", "Bata no liquidificador as cenouras, ovos e óleo. Misture o açúcar, a farinha e o fermento em uma tigela e adicione à mistura do liquidificador. Asse em forno pré-aquecido a 180°C por 40 minutos.", 30, "Bolo de Cenoura", "https://abiad.org.br/2021/wp-content/uploads/2020/09/bolocenoura_xilitol_igorrocha.jpg", 1 },
                    { 2, true, 2, "500g de carne moída, 1 pacote de massa para lasanha, 500g de queijo mussarela, 500g de presunto, 1 lata de molho de tomate, 2 colheres de sopa de óleo, Sal e pimenta a gosto", "Refogue a carne com óleo, sal e pimenta. Adicione o molho de tomate. Em uma travessa, alterne camadas de massa, carne, presunto e queijo. Finalize com queijo. Asse por 30 minutos a 180°C.", 20, "Lasanha de Carne", "https://p2.trrsf.com/image/fget/cf/1200/1600/middle/images.terra.com/2022/01/20/1189747356-lasanha-escondidinho-carne-moida-768x512.jpg", 2 },
                    { 3, true, 4, "1 pacote de biscoito maisena, 100g de manteiga, 1 lata de leite condensado, Suco de 2 limões, Raspas de limão, 3 claras, 3 colheres de açúcar", "Misture o biscoito triturado com a manteiga derretida e forre uma forma. Bata o leite condensado com o suco de limão e despeje sobre a massa. Faça o merengue com as claras e açúcar e cubra a torta. Asse por 10 minutos até dourar.", 40, "Torta de Limão", "https://www.mococa.com.br/wp-content/uploads/2022/07/Torta-de-limao_6-scaled.jpg", 3 },
                    { 4, true, 3, "500g de feijão preto, 300g de carne seca, 200g de linguiça calabresa, 200g de paio, 1 cebola picada, 2 dentes de alho, Sal e pimenta a gosto", "Deixe o feijão de molho. Cozinhe as carnes separadamente e depois misture ao feijão. Adicione a cebola e o alho refogados. Cozinhe até o feijão estar macio.", 30, "Feijoada", "https://static.itdg.com.br/images/1200-630/7a1c975ecbe125ad44416e5611a15569/352595-original.jpg", 4 },
                    { 5, true, 2, "1 pé de alface romana, 100g de queijo parmesão, 100g de croutons, 2 filés de peito de frango, Molho Caesar (à base de maionese, parmesão, limão e alho)", "Grelhe o frango e fatie. Monte a salada com alface, frango, parmesão e croutons. Regue com o molho Caesar.", 10, "Salada Caesar", "https://d1uz88p17r663j.cloudfront.net/original/82ddb6cea5bc7d60f39e3efadb89dab6_salada-cesar-receitas-nestle.jpg", 5 },
                    { 6, true, 3, "2 peitos de frango, 2 ovos, Farinha de trigo para empanar, Farinha de rosca para empanar, Molho de tomate, 200g de queijo mussarela, Sal e pimenta a gosto", "Tempere os peitos de frango com sal e pimenta, passe na farinha de trigo, nos ovos batidos e na farinha de rosca. Frite até dourar. Coloque o molho de tomate e queijo por cima e leve ao forno até derreter o queijo.", 30, "Frango à Parmegiana", "https://p2.trrsf.com/image/fget/cf/1200/1600/middle/images.terra.com/2024/01/28/1237455610-file-de-frango-a-parmegiana-sem-fritar-ca48iw6c.jpg", 6 },
                    { 7, true, 2, "1 kg de filé de peixe (pescada, robalo ou outro), 1 cebola grande, 1 pimentão vermelho, 1 pimentão verde, 2 tomates, 200ml de leite de coco, Azeite de dendê, Coentro a gosto, Sal e pimenta a gosto", "Tempere os filés de peixe com sal e pimenta. Em uma panela, refogue a cebola, os pimentões e os tomates. Adicione o leite de coco e o azeite de dendê. Cozinhe o peixe por cerca de 20 minutos. Finalize com coentro.", 20, "Moqueca de Peixe", "https://www.receiteria.com.br/wp-content/uploads/moqueca-de-pintado-00.jpg", 7 },
                    { 8, true, 5, "1 peito de frango desfiado, 1 cebola picada, 2 dentes de alho, 1 colher de sopa de azeite, 2 colheres de sopa de farinha de trigo, 1 copo de caldo de frango, Farinha de rosca para empanar, Óleo para fritar", "Refogue o frango com cebola, alho e azeite. Adicione a farinha e o caldo de frango até formar uma massa. Modele as coxinhas, empane na farinha de rosca e frite em óleo quente até dourar.", 45, "Coxinha de Frango", "https://static.itdg.com.br/images/1200-675/1dc3e596953e0d2e6bfff1b90fbcbb29/118911-original.jpg", 8 },
                    { 9, true, 4, "1 lata de leite condensado, 2 colheres de sopa de chocolate em pó, 1 colher de sopa de manteiga, Chocolate granulado para decorar", "Em uma panela, misture o leite condensado, o chocolate em pó e a manteiga. Cozinhe em fogo baixo até desgrudar do fundo da panela. Deixe esfriar, faça bolinhas e passe no granulado.", 10, "Brigadeiro", "https://www.conqualita.com.br/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/r/brigadeiro_2.jpg", 9 },
                    { 10, true, 1, "1 xícara de farinha de trigo, 1 colher de sopa de açúcar, 1 colher de chá de fermento em pó, 1 xícara de leite, 1 ovo, 1 colher de sopa de manteiga derretida", "Misture todos os ingredientes em uma tigela até obter uma massa homogênea. Aqueça uma frigideira e coloque uma porção da massa. Cozinhe até formar bolhas e vire. Sirva com mel ou frutas.", 15, "Panqueca Americana", "https://conteudo.imguol.com.br/c/entretenimento/8f/2020/06/05/panqueca-americana-com-frutas-vermelhas-1591366485086_v2_1280x1920.jpg", 10 }
                });

            migrationBuilder.InsertData(
                table: "Comentarios",
                columns: new[] { "Id", "ReceitaId", "TextoComentario", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, "Muito bom", 1 },
                    { 2, 1, "Receita top, eu adorei", 2 },
                    { 3, 1, "pessoal aqui em casa amou", 3 },
                    { 4, 2, "essa é a minha receita favorita", 4 },
                    { 5, 2, "top", 5 },
                    { 6, 2, "recomendo, podem fazer", 6 },
                    { 7, 2, "excelente", 7 },
                    { 8, 2, "recomendo", 8 },
                    { 9, 1, "receita muito boa", 9 },
                    { 10, 3, "a minha favorita", 10 }
                });

            migrationBuilder.InsertData(
                table: "Curtidas",
                columns: new[] { "Id", "ReceitaId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 1, 9 },
                    { 10, 1, 10 },
                    { 11, 6, 1 },
                    { 12, 6, 2 },
                    { 13, 6, 3 },
                    { 14, 6, 4 },
                    { 15, 6, 5 },
                    { 16, 6, 6 },
                    { 17, 7, 7 },
                    { 18, 7, 1 },
                    { 19, 7, 2 },
                    { 20, 7, 3 },
                    { 21, 7, 4 },
                    { 22, 7, 5 },
                    { 23, 7, 6 },
                    { 24, 7, 7 },
                    { 25, 7, 8 },
                    { 26, 7, 9 },
                    { 27, 7, 10 },
                    { 28, 8, 1 },
                    { 29, 8, 2 },
                    { 30, 8, 3 },
                    { 31, 8, 4 },
                    { 32, 8, 5 },
                    { 33, 8, 6 },
                    { 34, 8, 7 },
                    { 35, 8, 8 },
                    { 36, 8, 9 },
                    { 37, 8, 10 },
                    { 38, 9, 1 },
                    { 39, 9, 2 },
                    { 40, 9, 3 }
                });

            migrationBuilder.InsertData(
                table: "ReceitaHasTags",
                columns: new[] { "Id", "ReceitaId", "TagId" },
                values: new object[,]
                {
                    { 1, 1, 7 },
                    { 2, 1, 10 },
                    { 3, 2, 7 },
                    { 4, 2, 11 },
                    { 5, 3, 4 },
                    { 6, 4, 7 },
                    { 7, 5, 9 },
                    { 8, 5, 2 },
                    { 9, 6, 7 },
                    { 10, 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "ReceitasSalvas",
                columns: new[] { "Id", "ReceitaId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 8, 8, 1 },
                    { 9, 9, 1 },
                    { 10, 10, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Curtidas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ReceitaHasTags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReceitaHasTags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReceitaHasTags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReceitaHasTags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReceitaHasTags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReceitaHasTags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReceitaHasTags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ReceitaHasTags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReceitaHasTags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ReceitaHasTags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ReceitasSalvas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReceitasSalvas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReceitasSalvas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReceitasSalvas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReceitasSalvas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReceitasSalvas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReceitasSalvas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ReceitasSalvas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReceitasSalvas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ReceitasSalvas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
