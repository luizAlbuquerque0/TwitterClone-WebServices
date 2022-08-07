namespace TwitterClone.Application.ViewModels
{
    public class UpdatePostViewModel
    {
        public UpdatePostViewModel(string content, int id)
        {
            Content = content;
            Id = id;
        }

        public string Content { get; private set; }
        public int Id { get; private set; }
    }
}
