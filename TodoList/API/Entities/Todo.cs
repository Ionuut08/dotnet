namespace API.Entities
{
    public class Todo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public boolean Created { get; set; }

        public boolean IsDone { get; set; }
    }
}