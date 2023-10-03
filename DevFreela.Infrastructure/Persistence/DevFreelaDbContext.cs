using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha Descricao de Projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha Descricao de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha Descricao de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Murilo Nascimento", "murilohnascimento@outlook.com.br", new DateTime(1990, 7, 25)),
                new User("Caroline Marcelly", "cah_loiras2@outlook.com.br", new DateTime(1993, 4, 16)),
                new User("Bento Nascimento", "bento_Gato@outlook.com.br", new DateTime(2022, 4, 16))
            };

            Skills = new List<Skill>
            {
                new Skill("Net Core"),
                new Skill("C#"),
                new Skill("SQL Server")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
