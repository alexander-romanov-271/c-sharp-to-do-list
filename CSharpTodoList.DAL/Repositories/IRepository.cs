using CSharpTodoList.DAL.Models;

namespace CSharpTodoList.DAL.Repositories
{
    interface IRepository<T> : IDisposable
    where T : class
    {
        IEnumerable<T> GetItemList();
        T GetItem();
        void Create();
        void Delete();
        void Update();
    }


    class ProjectRepository : IRepository<ProjectModel>
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ProjectModel GetItem()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectModel> GetItemList()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }


}