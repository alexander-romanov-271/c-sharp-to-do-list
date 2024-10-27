using CSharpTodoList.DAL.Models;
using CSharpTodoList.DAL.Contexts;


namespace CSharpTodoList.DAL.Repositories
{
    interface IRepository<T> : IDisposable
    where T : class
    {
        IEnumerable<T> GetItemList();
        T GetItem(int id);
        void Create(T item);
        void Delete(int id);
        void Update(T item);
    }


    class ProjectRepository : IRepository<ProjectModel>
    {
        private FileContext _projectContext; 
        public ProjectRepository()
        {
            this._projectContext = new FileContext();
        }
        public void Create(ProjectModel item)
        {
            _projectContext.Open();
            _projectContext.Add(_projectContext.ConvertToString(item));
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ProjectModel GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectModel> GetItemList()
        {
            throw new NotImplementedException();
        }

        public void Update(ProjectModel item)
        {
            throw new NotImplementedException();
        }
    }


}