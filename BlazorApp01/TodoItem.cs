namespace BlazorApp01
{
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;

        public TodoItem(string? title, bool isDone)
        {
            Title = title;
            IsDone = isDone;    
        }
    }
}
