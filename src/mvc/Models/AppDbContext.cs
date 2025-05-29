using Microsoft.EntityFrameworkCore;
using mvc.Models.Domain;

namespace mvc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Curtida> Curtidas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<ReceitaHasTag> ReceitaHasTags { get; set; }
        public DbSet<ReceitaSalva> ReceitasSalvas { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Comentario -> Usuario
            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Usuario)
                .WithMany(u => u.Comentarios)
                .HasForeignKey(c => c.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            // Comentario -> Receita
            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Receita)
                .WithMany(r => r.Comentarios)
                .HasForeignKey(c => c.ReceitaId)
                .OnDelete(DeleteBehavior.NoAction);

            // Curtida -> Usuario
            modelBuilder.Entity<Curtida>()
                .HasOne(c => c.Usuario)
                .WithMany(u => u.Curtidas)
                .HasForeignKey(c => c.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            // Curtida -> Receita
            modelBuilder.Entity<Curtida>()
                .HasOne(c => c.Receita)
                .WithMany(r => r.Curtidas)
                .HasForeignKey(c => c.ReceitaId)
                .OnDelete(DeleteBehavior.NoAction);

            // ReceitaSalva -> Usuario
            modelBuilder.Entity<ReceitaSalva>()
                .HasOne(rs => rs.Usuario)
                .WithMany(u => u.ReceitasSalvas)
                .HasForeignKey(rs => rs.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            // ReceitaSalva -> Receita
            modelBuilder.Entity<ReceitaSalva>()
                .HasOne(rs => rs.Receita)
                .WithMany(r => r.ReceitasSalvas)
                .HasForeignKey(rs => rs.ReceitaId)
                .OnDelete(DeleteBehavior.NoAction);

            // Receita -> Usuario
            modelBuilder.Entity<Receita>()
                .HasOne(r => r.Usuario)
                .WithMany(u => u.Receitas)
                .HasForeignKey(r => r.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            // ReceitaHasTag -> Receita
            modelBuilder.Entity<ReceitaHasTag>()
                .HasOne(rht => rht.Receita)
                .WithMany(r => r.ReceitaHasTags)
                .HasForeignKey(rht => rht.ReceitaId)
                .OnDelete(DeleteBehavior.NoAction);

            // ReceitaHasTag -> Tag
            modelBuilder.Entity<ReceitaHasTag>()
                .HasOne(rht => rht.Tag)
                .WithMany(t => t.ReceitaHasTags)
                .HasForeignKey(rht => rht.TagId)
                .OnDelete(DeleteBehavior.NoAction);

            // Seed Categorias
            string categoriasJson = System.IO.File.ReadAllText("categorias.json");

            List<Categoria> categorias = System.Text.Json.JsonSerializer.Deserialize<List<Categoria>>(categoriasJson);

            foreach (Categoria categoria in categorias)
                modelBuilder.Entity<Categoria>().HasData(categoria);

            // Seed Tags
            string tagsJson = System.IO.File.ReadAllText("tags.json");

            List<Tag> tags = System.Text.Json.JsonSerializer.Deserialize<List<Tag>>(tagsJson);

            foreach (Tag tag in tags)
                modelBuilder.Entity<Tag>().HasData(tag);

            // Seed Usuarios
            string usuariosJson = System.IO.File.ReadAllText("usuarios.json");

            List<Usuario> usuarios = System.Text.Json.JsonSerializer.Deserialize<List<Usuario>>(usuariosJson);

            foreach (Usuario usuario in usuarios)
                modelBuilder.Entity<Usuario>().HasData(usuario);

            // Seed Receitas
            string receitasJson = System.IO.File.ReadAllText("receitas.json");

            List<Receita> receitas = System.Text.Json.JsonSerializer.Deserialize<List<Receita>>(receitasJson);

            foreach (Receita receita in receitas)
                modelBuilder.Entity<Receita>().HasData(receita);

            // Seed ReceitaHasTags
            string receitahastagsJson = System.IO.File.ReadAllText("receitahastags.json");

            List<ReceitaHasTag> receitahastags = System.Text.Json.JsonSerializer.Deserialize<List<ReceitaHasTag>>(receitahastagsJson);

            foreach (ReceitaHasTag receitahastag in receitahastags)
                modelBuilder.Entity<ReceitaHasTag>().HasData(receitahastag);

            // Seed Comentarios
            string comentariosJson = System.IO.File.ReadAllText("comentarios.json");

            List<Comentario> comentarios = System.Text.Json.JsonSerializer.Deserialize<List<Comentario>>(comentariosJson);

            foreach (Comentario comentario in comentarios)
                modelBuilder.Entity<Comentario>().HasData(comentario);

            // Seed Curtidas
            string curtidasJson = System.IO.File.ReadAllText("curtidas.json");

            List<Curtida> curtidas = System.Text.Json.JsonSerializer.Deserialize<List<Curtida>>(curtidasJson);

            foreach (Curtida curtida in curtidas)
                modelBuilder.Entity<Curtida>().HasData(curtida);

            // Seed ReceitasSalvas
            string receitassalvasJson = System.IO.File.ReadAllText("receitassalvas.json");

            List<ReceitaSalva> receitassalvas = System.Text.Json.JsonSerializer.Deserialize<List<ReceitaSalva>>(receitassalvasJson);

            foreach (ReceitaSalva receitasalva in receitassalvas)
                modelBuilder.Entity<ReceitaSalva>().HasData(receitasalva);
        }
    }
}
