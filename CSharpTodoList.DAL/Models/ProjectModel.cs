namespace CSharpTodoList.DAL.Models
{
    public class ProjectModel : BaseModel
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public string Content {get; set;}

        public ProjectModel(Dictionary<string, dynamic> d)
        {
            this.Id = d["Id"];
            this.Name = d["Name"];
            this.Content = d["Content"];      
        }
    }

}