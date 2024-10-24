using CSharpTodoList.DAL.Models;

namespace CSharpTodoList.DAL.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Name {get; set;}
        public string? Content {get; set;}
        public string? CreateBy {get; set;}
        public DateTime? CreatedAt {get; set;}        
        public string? ModifiedBy {get; set;}
        public DateTime? ModifiedAt {get; set;}

    }
}