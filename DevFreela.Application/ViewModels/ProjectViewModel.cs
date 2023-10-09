namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string title, DateTime creadeAt)
        {
            Id = id;
            Title = title;
            CreadeAt = creadeAt;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public DateTime CreadeAt { get; private set; }
    }
}
