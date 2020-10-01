using System.Threading;

namespace ToDoList.Model
{
    public class Category
    {
        public static int id;
        public int Id { get; set; }
        public string Description { get; set; }
        
        public Category(string description)
        {
            Id = Interlocked.Increment(ref id);
            Description = description;
        }
    }
}