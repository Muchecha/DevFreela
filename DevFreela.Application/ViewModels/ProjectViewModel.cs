namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(string title, DateTime creadeAt)
        {
            Title = title;
            CreadeAt = creadeAt;
        }

        public string Title { get; private set; }
        public DateTime CreadeAt { get; private set; }
    }
}
