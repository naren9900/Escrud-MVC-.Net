using proyectoMVC.Models;

namespace proyectoMVC.Data
{
    public interface IRepositorio
    {
        public Task Save<T>(T obj) where T : Entity;

        public void Delete<T>(T obj) where T : Entity;

        public void Update<T>(T obj) where T : Entity;

       public Task <List<T>>GetAll<T>() where T : Entity;

        public Task Comit();

    }
}
