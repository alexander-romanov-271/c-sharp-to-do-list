namespace CSharpTodoList.DAL.Models

{
    public class User : BaseModel
    {
        public int Id {get; set; }
        public string? Login {get; set;}
    }
}
